using LiveSplit.Model;
using LiveSplit.StreamerBot.Extensions;
using System.Linq;

namespace LiveSplit.StreamerBot
{
	public class StreamerBot_TimerEvents
	{
		private StreamerBot_Connection streamerBotConnection;
		LiveSplitState state;

		public void RegisterEvents(LiveSplitState state, StreamerBot_Connection streamerBotConnection)
		{
			this.state = state;
			this.streamerBotConnection = streamerBotConnection;
			state.OnPause += State_OnPause;
			state.OnReset += State_OnReset;
			state.OnResume += State_OnResume;
			state.OnSplit += State_OnSplit;
			state.OnStart += State_OnStart;
			state.OnUndoSplit += State_OnUndoSplit;
			state.OnSkipSplit += State_OnSkipSplit;
		}

		public void UnregisterEvents(LiveSplitState state)
		{
			state.OnPause -= State_OnPause;
			state.OnReset -= State_OnReset;
			state.OnResume -= State_OnResume;
			state.OnSplit -= State_OnSplit;
			state.OnStart -= State_OnStart;
			state.OnUndoSplit -= State_OnUndoSplit;
			state.OnSkipSplit -= State_OnSkipSplit;
		}


		private void State_OnPause(object sender, System.EventArgs e) => streamerBotConnection.SendMessage(new StreamerBot_Event.OnPause(state));

		private void State_OnReset(object sender, TimerPhase value) => streamerBotConnection.SendMessage(new StreamerBot_Event.OnReset(state));

		private void State_OnResume(object sender, System.EventArgs e) => streamerBotConnection.SendMessage(new StreamerBot_Event.OnResume(state));

		private void State_OnSplit(object sender, System.EventArgs e)
		{
			if (state.CurrentSplit != null)
			{
				//Todo = secure this!
				var currentTime = state.Run[state.CurrentSplitIndex - 1].SplitTime[state.CurrentTimingMethod];
				var pbTime = state.Run[state.CurrentSplitIndex - 1].Comparisons[state.CurrentComparison][state.CurrentTimingMethod];

				if (currentTime > pbTime)
				{
					//Todo - get segment times!
					var personalBestSegmentTime = state.Run[state.CurrentSplitIndex - 1].BestSegmentTime[state.CurrentTimingMethod];
					streamerBotConnection.SendMessage(new StreamerBot_Event.OnRedSplit(state));
				}
				else
				{
					//Todo - get segment times!
					var personalBestSegmentTime = state.Run[state.CurrentSplitIndex - 1].BestSegmentTime[state.CurrentTimingMethod];
					streamerBotConnection.SendMessage(new StreamerBot_Event.OnGreenSplit(state));
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

		private void State_OnStart(object sender, System.EventArgs e) => streamerBotConnection.SendMessage(new StreamerBot_Event.OnStart((LiveSplitState)sender));

		private void State_OnUndoSplit(object sender, System.EventArgs e) => streamerBotConnection.SendMessage(new StreamerBot_Event.OnUndoSplit((LiveSplitState)sender));

		private void State_OnSkipSplit(object sender, System.EventArgs e) => streamerBotConnection.SendMessage(new StreamerBot_Event.OnSkipSplit((LiveSplitState)sender));
	}
}
