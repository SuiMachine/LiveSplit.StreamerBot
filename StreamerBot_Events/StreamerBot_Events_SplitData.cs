using LiveSplit.Model;
using System;

namespace LiveSplit.Streamerbot.StreamerBot_Events
{
	internal class StreamerBot_Events_SplitData : StreamerBot_Event
	{
		public StreamerBot_Events_SplitData(LiveSplitState state) : base(state)
		{

		}

		public override EventTypeE EventType => EventTypeE.OnSplitsUpdated;

		public string GameName;
		public string Category;
		public bool? AutosplitterPresent;
		public int? SplitCount;
		public int? AttemptCount;
		//Run start offset maybe?

	}
}
