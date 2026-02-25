using LiveSplit.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LiveSplit.Streamerbot.StreamerBot_Events
{
	public class StreamerBot_Events_Run : StreamerBot_Event
	{
		public StreamerBot_Events_Run(LiveSplitState state) : base(state)
		{
			if (state == null)
				return;

			this.AttemptCount = state.Run.AttemptCount;
			this.TimingMethod = state.CurrentTimingMethod;
			this.IsGameTimeInitiated = state.IsGameTimeInitialized;
			this.CurrentComparison = state.CurrentComparison;
		}

		public override EventTypeE EventType => EventTypeE.Invalid;
		public int AttemptCount = 0;
		[JsonConverter(typeof(StringEnumConverter))]
		public TimingMethod TimingMethod;
		public bool IsGameTimeInitiated;
		public string CurrentComparison;
	}
}
