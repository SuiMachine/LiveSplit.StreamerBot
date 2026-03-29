using LiveSplit.Model;
using LiveSplit.Streamerbot.StreamerBot_Events;
using System;
using System.Linq;
using System.Threading;

namespace LiveSplit.StreamerBot
{
	public class StreamerBot_TimerEvents
	{
		private StreamerBot_Connection streamerBotConnection;
		private Event_SplitData runProperties;
		private bool m_ShouldRunPolling = false;
		private bool m_CheckTimerThreadRunning = false;
		private Thread m_CheckTimerThread = null;
		private bool m_LastPaceWasBehindPB;

		public void RegisterEvents(LiveSplitState state, StreamerBot_Connection streamerBotConnection)
		{
			this.runProperties = new Event_SplitData(state);
			this.streamerBotConnection = streamerBotConnection;
			state.OnPause += State_OnPause;
			state.OnReset += State_OnReset;
			state.OnResume += State_OnResume;
			state.OnSplit += State_OnSplit;
			state.OnStart += State_OnStart;
			state.OnUndoSplit += State_OnUndoSplit;
			state.OnSkipSplit += State_OnSkipSplit;
			state.RunManuallyModified += State_RunManuallyModified;
			this.streamerBotConnection.OnConnectionChanged += ConnectionChanged;

			this.streamerBotConnection.Log("Registered Timer Events");

			//TODO: We'll need some hacky way of handling game time so we can report it.
			System.Timers.Timer st = new System.Timers.Timer(500)
			{
				AutoReset = false,
			};
			st.Elapsed += (s, e) =>
			{
				UpdateRunProperties(state);
			};
			st.Start();
		}

		private void ConnectionChanged(bool state)
		{
			this.streamerBotConnection?.Log($"Connection changed {state}");

			if (state)
			{
				streamerBotConnection.SendMessage(runProperties, true);
			}
		}

		private void State_RunManuallyModified(object sender, EventArgs e) => UpdateRunProperties((LiveSplitState)sender);

		public void UnregisterEvents(LiveSplitState state)
		{
			state.OnPause -= State_OnPause;
			state.OnReset -= State_OnReset;
			state.OnResume -= State_OnResume;
			state.OnSplit -= State_OnSplit;
			state.OnStart -= State_OnStart;
			state.OnUndoSplit -= State_OnUndoSplit;
			state.OnSkipSplit -= State_OnSkipSplit;
			state.RunManuallyModified -= State_RunManuallyModified;

			this.streamerBotConnection?.Log("Unregistered Timer Events");
			if (streamerBotConnection != null)
				streamerBotConnection.OnConnectionChanged -= ConnectionChanged;
		}

		private void UpdateRunProperties(LiveSplitState state)
		{
			if (state.Run == null)
				return;

			Event_SplitData changesOnly = new Event_SplitData(state);

			streamerBotConnection.SendMessage(changesOnly);
		}


		private void State_OnPause(object sender, EventArgs e) => streamerBotConnection.SendMessage(new StreamerBot_Events_Splits.OnPause((LiveSplitState)sender));

		private void State_OnReset(object sender, TimerPhase value)
		{
			m_ShouldRunPolling = false;
			if (m_CheckTimerThreadRunning != false)
			{
				m_CheckTimerThreadRunning = false;
				streamerBotConnection.SendMessage(new StreamerBot_Events_Splits.OnGameTimePaused((LiveSplitState)sender));
			}
			streamerBotConnection.SendMessage(new StreamerBot_Events_Splits.OnReset((LiveSplitState)sender));
		}

		private void State_OnResume(object sender, EventArgs e) => streamerBotConnection.SendMessage(new StreamerBot_Events_Splits.OnResume((LiveSplitState)sender));

		private void State_OnSplit(object sender, EventArgs e)
		{
			LiveSplitState state = (LiveSplitState)sender;
			if (state.CurrentSplit != null)
			{
				//Todo = secure this?
				var currentTime = state.Run[state.CurrentSplitIndex - 1].SplitTime[state.CurrentTimingMethod];
				var pbTime = state.Run[state.CurrentSplitIndex - 1].Comparisons[state.CurrentComparison][state.CurrentTimingMethod];

				if (currentTime > pbTime)
				{
					streamerBotConnection.SendMessage(new StreamerBot_Events_Splits.OnRedSplit(state));
				}
				else
				{
					streamerBotConnection.SendMessage(new StreamerBot_Events_Splits.OnGreenSplit(state));
					m_LastPaceWasBehindPB = false;
				}
			}
			else if (state.CurrentPhase == TimerPhase.Ended)
			{
				var currentTime = state.Run[state.CurrentSplitIndex - 1].SplitTime[state.CurrentTimingMethod];
				var pbTime = state.Run[state.CurrentSplitIndex - 1].Comparisons[state.CurrentComparison][state.CurrentTimingMethod];

				if (currentTime > pbTime)
				{
					streamerBotConnection.SendMessage(new StreamerBot_Events_Splits.OnRunFinishedWithoutPB(state));

				}
				else
				{
					streamerBotConnection.SendMessage(new StreamerBot_Events_Splits.OnRunFinishedWithPB(state));
				}
			}
		}

		private void State_OnStart(object sender, EventArgs e)
		{
			var state = (LiveSplitState)sender;
			streamerBotConnection.SendMessage(new StreamerBot_Events_Splits.OnStart(state));
			bool hasAutosplitter = state.Run.AutoSplitter != null || state.IsGameTimeInitialized;

			m_ShouldRunPolling = true;
			m_CheckTimerThread = new Thread(() =>
			{
				PollTimer(state, hasAutosplitter);
			});

			m_CheckTimerThread.Start();
		}

		private void PollTimer(LiveSplitState state, bool hasAutosplitter)
		{
			TimeSpan lastTime = state.CurrentTime[state.CurrentTimingMethod].GetValueOrDefault();

			//Should probably implement cancellation token :-/
			while (m_ShouldRunPolling)
			{
				if (hasAutosplitter)
				{
					var isPausedNow = state.IsGameTimePaused;
					if (isPausedNow != m_CheckTimerThreadRunning)
					{
						m_CheckTimerThreadRunning = isPausedNow;
						if (isPausedNow)
						{
							streamerBotConnection.SendMessage(new StreamerBot_Events_Splits.OnGameTimePaused(state));
						}
						else
						{
							streamerBotConnection.SendMessage(new StreamerBot_Events_Splits.OnGameTimeResumed(state));
						}
					}
				}

				TimeSpan newTime = state.CurrentTime[state.CurrentTimingMethod].GetValueOrDefault();

				if (state.CurrentSplitIndex < state.Run.Count)
				{
					if (state.CurrentSplitIndex < 0 || state.CurrentSplit == null)
					{
						Thread.Sleep(25);
						continue;
					}
					TimeSpan splitTime = state.CurrentSplit.Comparisons[state.CurrentComparison][state.CurrentTimingMethod].GetValueOrDefault();
					if (newTime != lastTime && splitTime != default)
					{
						if (newTime > splitTime && splitTime >= lastTime)
						{
							streamerBotConnection.SendMessage(new StreamerBot_Events_Splits.OnLostPBPace(state, m_LastPaceWasBehindPB));
							m_LastPaceWasBehindPB = false;
						}
					}
				}

				lastTime = newTime;

				Thread.Sleep(25);
			}
#if DEBUG
			System.Diagnostics.Debug.WriteLine("Ending Game Time Polling Thread");
#endif
		}

		private void State_OnUndoSplit(object sender, EventArgs e) => streamerBotConnection.SendMessage(new StreamerBot_Events_Splits.OnUndoSplit((LiveSplitState)sender));

		private void State_OnSkipSplit(object sender, EventArgs e) => streamerBotConnection.SendMessage(new StreamerBot_Events_Splits.OnSkipSplit((LiveSplitState)sender));
	}
}
