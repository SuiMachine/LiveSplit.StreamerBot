using LiveSplit.Model;
using System;
using System.Diagnostics;

namespace LiveSplit.Streamerbot.StreamerBot_Events
{
	internal class Event_SplitData : StreamerBot_Event
	{
		[DebuggerDisplay("Split - {Name} | PB Split Game Time: {PersonalBestSplitGameTime} | PB Split Real Time: {PersonalBestSplitRealTime} | Best Segment Game Time: {BestSegmentGameTime} | Best Segment Real Time: {BestSegmentRealTime}")]
		public class SplitData
		{
			public string Name;
			public TimeSpan? PersonalBestSplitGameTime;
			public TimeSpan? PersonalBestSplitRealTime;
			public TimeSpan? BestSegmentGameTime;
			public TimeSpan? BestSegmentRealTime;

			public static bool SplitsChanged(SplitData a, SplitData b)
			{
				if (ReferenceEquals(a, b))
					return false;
				if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
					return true;
				return a.Name != b.Name
					|| a.PersonalBestSplitGameTime != b.PersonalBestSplitGameTime
					|| a.PersonalBestSplitRealTime != b.PersonalBestSplitRealTime
					|| a.BestSegmentGameTime != b.BestSegmentGameTime
					|| a.BestSegmentRealTime != b.BestSegmentRealTime;
			}
		}

		public Event_SplitData(LiveSplitState state) : base(state)
		{
			SplitCount = state.Run.Count;
			AutosplitterPresent = (state.Run.AutoSplitter?.IsActivated ?? false) || state.IsGameTimeInitialized;
			AttemptCount = state.Run.AttemptCount;
			Offset = state.Run.Offset;
			Splits = new SplitData[state.Run.Count];

			for (int i = 0; i < Splits.Length; i++)
			{
				Splits[i] = new SplitData()
				{
					Name = state.Run[i].Name,
					PersonalBestSplitGameTime = state.Run[i].PersonalBestSplitTime[Model.TimingMethod.GameTime].GetValueOrDefault(),
					PersonalBestSplitRealTime = state.Run[i].PersonalBestSplitTime[Model.TimingMethod.RealTime].GetValueOrDefault(),
					BestSegmentGameTime = state.Run[i].PersonalBestSplitTime[Model.TimingMethod.GameTime].GetValueOrDefault(),
					BestSegmentRealTime = state.Run[i].BestSegmentTime[Model.TimingMethod.RealTime].GetValueOrDefault(),
				};
			}
		}

/*		public Event_SplitData(LiveSplitState state, Event_SplitData compareAgainst) : base(state)
		{
			if (compareAgainst == null)
				return;


			if (compareAgainst.GameName != state.Run.GameName)
				GameName = state.Run.GameName;

			if (compareAgainst.Category != state.Run.CategoryName)
				Category = state.Run.CategoryName;

			if (compareAgainst.AutosplitterPresent != ((state.Run.AutoSplitter?.IsActivated ?? false) || compareAgainst.AutosplitterPresent != state.IsGameTimeInitialized))
				AutosplitterPresent = (state.Run.AutoSplitter?.IsActivated ?? false) || state.IsGameTimeInitialized;

			if (compareAgainst.AttemptCount != state.Run.AttemptCount)
				AttemptCount = state.Run.AttemptCount;

			if (compareAgainst.Offset != state.Run.Offset)
				Offset = state.Run.Offset;

			bool splitsNeedAttaching = false;
			if (compareAgainst.SplitCount != state.Run.Count)
			{
				SplitCount = state.Run.Count;
				splitsNeedAttaching = true;
			}



			SplitData[] tempSplitsSplits = new SplitData[state.Run.Count];

			for (int i = 0; i < tempSplitsSplits.Length; i++)
			{
				tempSplitsSplits[i] = new SplitData()
				{
					Name = state.Run[i].Name,
					PersonalBestSplitGameTime = state.Run[i].PersonalBestSplitTime[Model.TimingMethod.GameTime].GetValueOrDefault(),
					PersonalBestSplitRealTime = state.Run[i].PersonalBestSplitTime[Model.TimingMethod.RealTime].GetValueOrDefault(),
					BestSegmentGameTime = state.Run[i].PersonalBestSplitTime[Model.TimingMethod.GameTime].GetValueOrDefault(),
					BestSegmentRealTime = state.Run[i].BestSegmentTime[Model.TimingMethod.RealTime].GetValueOrDefault(),
				};

				if (!splitsNeedAttaching && SplitData.SplitsChanged(tempSplitsSplits[i], compareAgainst.Splits[i]))
					splitsNeedAttaching = true;
			}

			if (splitsNeedAttaching)
				this.Splits = tempSplitsSplits;
		}*/

		public override EventTypeE EventType => EventTypeE.OnSplitsUpdated;

		public bool? AutosplitterPresent;
		public int? AttemptCount;
		public TimeSpan? Offset;
		public SplitData[] Splits;
		public int? SplitCount;
		public TimingMethod? TimingMethod = null;
	}
}
