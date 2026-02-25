using LiveSplit.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LiveSplit.Streamerbot.StreamerBot_Events
{
	public abstract partial class StreamerBot_Event
	{
		[JsonConverter(typeof(StringEnumConverter))]
		public enum EventTypeE
		{
			Invalid,
			OnStart,
			OnReset,
			OnPause,
			OnResume,
			OnSkipSplit,
			OnUndoSplit,
			OnGreenSplit,
			OnRedSplit,
			OnSplitsUpdated
		}

		protected StreamerBot_Event(LiveSplitState state)
		{
		}

		public abstract EventTypeE EventType { get; }

	}
}
