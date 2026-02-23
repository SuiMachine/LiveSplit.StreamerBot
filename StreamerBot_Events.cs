using LiveSplit.Model;
using LiveSplit.StreamerBot.Extensions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace LiveSplit.StreamerBot
{
	public abstract class StreamerBot_Event
	{
		[JsonConverter(typeof(StringEnumConverter))]
		public enum EventTypeE
		{
			OnStart,
			OnReset,
			OnPause,
			OnResume,
			OnSplit,
			OnSkipSplit,
			OnUndoSplit,
			OnGold,
			OnGoldSplit,
			OnGreenSplit,
			OnRedSplit
		}

		public class OnStart : StreamerBot_Event
		{
			public override EventTypeE EventType => EventTypeE.OnStart;

			internal OnStart(LiveSplitState state) : base(state) { }
		}

		public class OnUndoSplit : StreamerBot_Event_OnSplit
		{
			public override EventTypeE EventType => EventTypeE.OnUndoSplit;

			internal OnUndoSplit(LiveSplitState state) : base(state) { }
		}

		public class OnSkipSplit : StreamerBot_Event_OnSplit
		{
			public override EventTypeE EventType => EventTypeE.OnSkipSplit;

			internal OnSkipSplit(LiveSplitState state) : base(state) { }
		}

		public class OnGreenSplit : StreamerBot_Event_OnSplit
		{
			public override EventTypeE EventType => EventTypeE.OnGreenSplit;

			internal OnGreenSplit(LiveSplitState state) : base(state) { }
		}

		public class OnRedSplit : StreamerBot_Event_OnSplit
		{
			public override EventTypeE EventType => EventTypeE.OnGreenSplit;

			internal OnRedSplit(LiveSplitState state) : base(state) { }
		}


		public class OnGoldSplit : StreamerBot_Event_OnSplit
		{
			public override EventTypeE EventType => EventTypeE.OnGreenSplit;

			internal OnGoldSplit(LiveSplitState state) : base(state) { }
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

		public class StreamerBot_Event_OnSplit : StreamerBot_Event
		{
			public override EventTypeE EventType => EventTypeE.OnSplit;
			public TimeSpan LastSplitTime;
			public TimeSpan LastSplitGameTime;
			public TimeSpan LastSplitRealTime;
			public TimeSpan SplitTimeDifference;
			public double LastSplitTimeSeconds;
			public double LastSplitGameTimeSeconds;
			public double LastSplitRealTimeSeconds;
			public string PreviousSplitName;
			public string CurrentSplitName;
			public int CurrentSplitIndex;
			public bool WasLastSplitAheadOfPB;

			internal StreamerBot_Event_OnSplit(LiveSplitState state) : base(state)
			{
				this.CurrentSplitName = state.CurrentSplit.Name;
				this.CurrentSplitIndex = state.CurrentSplitIndex;

				if (state.CurrentSplitIndex > 0)
				{
					var lastSplit = state.Run[state.CurrentSplitIndex - 1];
					var personalBestSegmentTime = lastSplit.BestSegmentTime[state.CurrentTimingMethod].GetValueOrDefault();
					var lastSplitTime = lastSplit.SplitTime[state.CurrentTimingMethod].GetValueOrDefault();
					WasLastSplitAheadOfPB = lastSplitTime <= personalBestSegmentTime;

					this.PreviousSplitName = lastSplit.Name;
					this.SplitTimeDifference = lastSplit.Comparisons[state.CurrentComparison][state.CurrentTimingMethod].GetValueOrDefault() - lastSplit.SplitTime[state.CurrentTimingMethod].GetValueOrDefault();

					this.LastSplitTime = lastSplit.SplitTime[state.CurrentTimingMethod].GetValueOrDefault();
					this.LastSplitGameTime = lastSplit.SplitTime[TimingMethod.GameTime].GetValueOrDefault();
					this.LastSplitRealTime = lastSplit.SplitTime[TimingMethod.RealTime].GetValueOrDefault();

					this.LastSplitTimeSeconds = LastSplitTime.TotalSeconds;
					this.LastSplitGameTimeSeconds = LastSplitGameTime.TotalSeconds;
					this.LastSplitRealTimeSeconds = LastSplitRealTime.TotalSeconds;
				}
			}
		}

		protected StreamerBot_Event(LiveSplitState state)
		{
			if (state == null)
				return;

			this.AttemptCount = state.Run.AttemptCount;
			this.TimingMethod = state.CurrentTimingMethod;
			this.IsGameTimeInitiated = state.IsGameTimeInitialized;
			this.CurrentComparison = state.CurrentComparison;
		}

		public abstract EventTypeE EventType { get; }
		public int AttemptCount = 0;
		[JsonConverter(typeof(StringEnumConverter))]
		public TimingMethod TimingMethod;
		public bool IsGameTimeInitiated;
		public string CurrentComparison;
	}
}
