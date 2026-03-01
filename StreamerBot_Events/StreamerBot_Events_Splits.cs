using LiveSplit.Model;
using System;

namespace LiveSplit.Streamerbot.StreamerBot_Events
{
	public class StreamerBot_Events_Splits
	{
		public class OnStart : StreamerBot_Event
		{
			public override EventTypeE EventType => EventTypeE.OnStart;

			internal OnStart(LiveSplitState state) : base(state) { }
		}

		public class OnUndoSplit : OnSplit
		{
			public override EventTypeE EventType => EventTypeE.OnUndoSplit;

			internal OnUndoSplit(LiveSplitState state) : base(state)
			{
				this.WasLastSplitGold = false;
			}
		}

		public class OnSkipSplit : OnSplit
		{
			public override EventTypeE EventType => EventTypeE.OnSkipSplit;

			internal OnSkipSplit(LiveSplitState state) : base(state)
			{
				this.WasLastSplitGold = false;
			}
		}

		public class OnGreenSplit : OnSplit
		{
			public override EventTypeE EventType => EventTypeE.OnGreenSplit;

			internal OnGreenSplit(LiveSplitState state) : base(state) { }
		}

		public class OnRedSplit : OnSplit
		{
			public override EventTypeE EventType => EventTypeE.OnRedSplit;

			internal OnRedSplit(LiveSplitState state) : base(state) { }
		}


		public class OnResume : StreamerBot_Event
		{
			public override EventTypeE EventType => EventTypeE.OnResume;

			internal OnResume(LiveSplitState state) : base(state) { }
		}

		public class OnReset : StreamerBot_Event
		{
			public override EventTypeE EventType => EventTypeE.OnReset;

			internal OnReset(LiveSplitState state) : base(state) { }
		}

		public class OnPause : StreamerBot_Event
		{
			public override EventTypeE EventType => EventTypeE.OnPause;

			internal OnPause(LiveSplitState state) : base(state) { }
		}

		public class OnGameTimePaused : StreamerBot_Event
		{
			public override EventTypeE EventType => EventTypeE.OnGameTimePaused;
			public TimeSpan CurrentGameTime;
			public TimeSpan CurrentRealTime;
			public TimeSpan CurrentLoadTime;

			internal OnGameTimePaused(LiveSplitState state) : base(state)
			{
				this.CurrentGameTime = state.CurrentTime[TimingMethod.GameTime].GetValueOrDefault();
				this.CurrentRealTime = state.CurrentTime[TimingMethod.RealTime].GetValueOrDefault();
				this.CurrentLoadTime = state.LoadingTimes;
			}
		}

		public class OnGameTimeResumed : OnGameTimePaused
		{
			public override EventTypeE EventType => EventTypeE.OnGameTimeResumed;

			internal OnGameTimeResumed(LiveSplitState state) : base(state) { }
		}

		public class OnRunFinishedWithPB : OnRunFinishedWithoutPB
		{
			public override EventTypeE EventType => EventTypeE.OnRunFinishedWithPB;
			internal OnRunFinishedWithPB(LiveSplitState state) : base(state) { }
		}

		public class OnRunFinishedWithoutPB : OnSplit
		{
			public override EventTypeE EventType => EventTypeE.OnRunFinishedWithoutPB;
			internal OnRunFinishedWithoutPB(LiveSplitState state) : base(state) { }
		}

		public class OnSplit : StreamerBot_Event
		{
			public override EventTypeE EventType => EventTypeE.Invalid;
			public TimeSpan LastSplitTime;
			public TimeSpan LastSplitGameTime;
			public TimeSpan LastSplitRealTime;
			public TimeSpan SplitTimeDifference;
			public string PreviousSplitName;
			public string CurrentSplitName;
			public int CurrentSplitIndex;
			public bool WasLastSplitGold;

			internal OnSplit(LiveSplitState state) : base(state)
			{
				this.CurrentSplitName = state.CurrentSplit?.Name ?? "";
				this.CurrentSplitIndex = state.CurrentSplitIndex;

				if (state.CurrentSplitIndex > 0)
				{
					ISegment lastSplit = state.Run[state.CurrentSplitIndex - 1];

					TimeSpan personalBestSegmentTime = lastSplit.BestSegmentTime[state.CurrentTimingMethod].GetValueOrDefault();
					TimeSpan lastSegmentTime = lastSplit.SplitTime[state.CurrentTimingMethod].GetValueOrDefault() - (state.CurrentSplitIndex - 2 >= 0 ? state.Run[state.CurrentSplitIndex - 2].SplitTime[state.CurrentTimingMethod].GetValueOrDefault() : TimeSpan.Zero);

					this.WasLastSplitGold = lastSegmentTime < personalBestSegmentTime;

					this.PreviousSplitName = lastSplit.Name;
					this.SplitTimeDifference = lastSplit.Comparisons[state.CurrentComparison][state.CurrentTimingMethod].GetValueOrDefault() - lastSplit.SplitTime[state.CurrentTimingMethod].GetValueOrDefault();

					this.LastSplitTime = lastSplit.SplitTime[state.CurrentTimingMethod].GetValueOrDefault();
					this.LastSplitGameTime = lastSplit.SplitTime[TimingMethod.GameTime].GetValueOrDefault();
					this.LastSplitRealTime = lastSplit.SplitTime[TimingMethod.RealTime].GetValueOrDefault();
				}
			}
		}
	}
}
