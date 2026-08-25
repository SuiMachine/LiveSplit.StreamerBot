using LiveSplit.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using static LiveSplit.Streamerbot.StreamerBot_Events.Event_SplitData;

namespace LiveSplit.Streamerbot.StreamerBot_Events
{
	internal class StreamerBot_Events_CurrentRun : StreamerBot_Event
	{
		public StreamerBot_Events_CurrentRun(LiveSplitState state) : base(state)
		{
			Phase = state.CurrentPhase;
			SplitCount = state.Run.Count;
			AutosplitterPresent = (state.Run.AutoSplitter?.IsActivated ?? false) || state.IsGameTimeInitialized;
			AttemptCount = state.Run.AttemptCount;
			Offset = state.Run.Offset;
			TimingMethod = state.CurrentTimingMethod;


			if (Phase == TimerPhase.NotRunning)
			{
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
			else
			{
				CurrentRealTime = state.CurrentTime[TimingMethod.RealTime].GetValueOrDefault();
				CurrentGameTime = state.CurrentTime[TimingMethod.GameTime].GetValueOrDefault();

				LoadTimes = state.LoadingTimes;
				CurrentSplitIndex = state.CurrentSplitIndex;
				Splits = new SplitData[state.Run.Count];
				CurrentSplit = new SplitData()
				{
					Name = state.CurrentSplit.Name,
					PersonalBestSplitRealTime = state.CurrentSplit.PersonalBestSplitTime[TimingMethod.RealTime].GetValueOrDefault(),
					PersonalBestSplitGameTime = state.CurrentSplit.PersonalBestSplitTime[TimingMethod.GameTime].GetValueOrDefault(),
					BestSegmentRealTime = state.CurrentSplit.PersonalBestSplitTime[TimingMethod.RealTime].GetValueOrDefault(),
					BestSegmentGameTime = state.CurrentSplit.PersonalBestSplitTime[TimingMethod.GameTime].GetValueOrDefault(),
				};

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
		}

		public override EventTypeE EventType => EventTypeE.OnSplitsRunUpdate;
		[JsonConverter(typeof(StringEnumConverter))]
		public TimerPhase Phase = TimerPhase.NotRunning;

		public bool? AutosplitterPresent;
		public int? AttemptCount;
		public TimeSpan? Offset;
		public TimeSpan? CurrentRealTime;
		public TimeSpan? CurrentGameTime;
		public TimeSpan? LoadTimes;

		public SplitData CurrentSplit;
		public int? CurrentSplitIndex;

		public SplitData[] Splits;
		public int? SplitCount;
		public TimingMethod TimingMethod = TimingMethod.RealTime;
	}
}
