using LiveSplit.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;
using System.Linq;

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
			OnGameTimePaused,
			OnGameTimeResumed,
			OnSplitsUpdated,
			OnRunFinishedWithPB,
			OnRunFinishedWithoutPB,
			OnLostPBPace
		}

		protected StreamerBot_Event(LiveSplitState state)
		{
			GameName = state.Run.GameName;
			Category = state.Run.CategoryName;
			SplitPath = state.Run.FilePath;
			RunMetadata metaData = state.Run.Metadata;
			Platform = metaData.PlatformName ?? "";
			UsesEmulator = metaData.UsesEmulator;
			SubCategory = new Dictionary<string, string>();
			Variables = new Dictionary<string, string>();
			if(metaData.Game == null)
				URL_Leaderboard = "";
			else
			{
				if(metaData.Category != null)
				{
					URL_Leaderboard = metaData.Category.WebLink.AbsoluteUri;
				}
				else
				{
					URL_Leaderboard = metaData.Game.WebLink.AbsoluteUri;
				}
			}

			foreach (KeyValuePair<SpeedrunComSharp.Variable, SpeedrunComSharp.VariableValue> variable in metaData.VariableValues)
			{
				if (variable.Key.IsSubcategory)
					SubCategory[variable.Key.Name.Replace(' ', '_')] = variable.Value?.Value ?? "";
				else
					Variables[variable.Key.Name.Replace(' ', '_')] = variable.Value?.Value ?? "";
			}
		}

		public string GameName;
		public string Category;
		public Dictionary<string, string> SubCategory;
		public string Platform;
		public bool UsesEmulator;
		public Dictionary<string, string> Variables;
		public string SplitPath;
		public string URL_Leaderboard;

		public abstract EventTypeE EventType { get; }
	}
}
