using LiveSplit.Model;
using LiveSplit.Streamerbot.StreamerBot_Events;
using System;
using System.Linq;

namespace LiveSplit.StreamerBot
{
	public class StreamerBot_TimerEvents
	{
		private StreamerBot_Connection streamerBotConnection;
		private StreamerBot_Events_SplitData runProperties;

		public void RegisterEvents(LiveSplitState state, StreamerBot_Connection streamerBotConnection)
		{
			this.runProperties = new StreamerBot_Events_SplitData(state);
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

			if (streamerBotConnection != null)
				streamerBotConnection.OnConnectionChanged -= ConnectionChanged;

			if(state.Run.AutoSplitter != null)
			{
			}
		}

		private void UpdateRunProperties(LiveSplitState state)
		{
			if (state.Run == null)
				return;

			StreamerBot_Events_SplitData changesOnly = new StreamerBot_Events_SplitData(state);

			if (runProperties.GameName != state.Run.GameName)
			{
				runProperties.GameName = state.Run.GameName;
				changesOnly.GameName = state.Run.GameName;
			}

			if (runProperties.Category != state.Run.CategoryName)
			{
				runProperties.Category = state.Run.CategoryName;
				changesOnly.Category = state.Run.CategoryName;
			}

			if (runProperties.SplitCount != state.Run.Count)
			{
				runProperties.SplitCount = state.Run.Count;
				changesOnly.SplitCount = state.Run.Count;
			}

			if(runProperties.AutosplitterPresent != (state.Run.AutoSplitter?.IsActivated ?? false) || runProperties.AutosplitterPresent != state.IsGameTimeInitialized)
			{
				runProperties.AutosplitterPresent = (state.Run.AutoSplitter?.IsActivated ?? false) || state.IsGameTimeInitialized;
				changesOnly.AutosplitterPresent = runProperties.AutosplitterPresent;
			}

			if (runProperties.AttemptCount != state.Run.AttemptCount)
			{
				runProperties.AttemptCount = state.Run.AttemptCount;
				changesOnly.AttemptCount = state.Run.AttemptCount;
			}

			streamerBotConnection.SendMessage(changesOnly);
		}


		private void State_OnPause(object sender, EventArgs e) => streamerBotConnection.SendMessage(new StreamerBot_Events_Splits.OnPause((LiveSplitState)sender));

		private void State_OnReset(object sender, TimerPhase value) => streamerBotConnection.SendMessage(new StreamerBot_Events_Splits.OnReset((LiveSplitState)sender));

		private void State_OnResume(object sender, EventArgs e) => streamerBotConnection.SendMessage(new StreamerBot_Events_Splits.OnResume((LiveSplitState)sender));

		private void State_OnSplit(object sender, EventArgs e)
		{
			LiveSplitState state = (LiveSplitState)sender;
			if (state.CurrentSplit != null)
			{
				//Todo = secure this!
				var currentTime = state.Run[state.CurrentSplitIndex - 1].SplitTime[state.CurrentTimingMethod];
				var pbTime = state.Run[state.CurrentSplitIndex - 1].Comparisons[state.CurrentComparison][state.CurrentTimingMethod];

				if (currentTime > pbTime)
				{
					streamerBotConnection.SendMessage(new StreamerBot_Events_Splits.OnRedSplit(state));
				}
				else
				{
					streamerBotConnection.SendMessage(new StreamerBot_Events_Splits.OnGreenSplit(state));
				}
			}
			else if (state.CurrentPhase == TimerPhase.Ended)
			{
				var currentEndRunTime = state.CurrentTime[state.CurrentTimingMethod];
				var pbRunTime = state.Run.Last().Comparisons[state.CurrentComparison][state.CurrentTimingMethod];

				if (currentEndRunTime > pbRunTime)
				{
				}
				else
				{
				}
			}
		}

		private void State_OnStart(object sender, EventArgs e)
		{
			var state = (LiveSplitState)sender;
			streamerBotConnection.SendMessage(new StreamerBot_Events_Splits.OnStart(state));
			if(state.Run.AutoSplitter != null)
			{
			}
		}

		private void State_OnUndoSplit(object sender, EventArgs e) => streamerBotConnection.SendMessage(new StreamerBot_Events_Splits.OnUndoSplit((LiveSplitState)sender));

		private void State_OnSkipSplit(object sender, EventArgs e) => streamerBotConnection.SendMessage(new StreamerBot_Events_Splits.OnSkipSplit((LiveSplitState)sender));
	}
}
