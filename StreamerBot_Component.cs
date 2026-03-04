using LiveSplit.Model;
using LiveSplit.UI;
using LiveSplit.UI.Components;
using System.Windows.Forms;
using System.Xml;

namespace LiveSplit.StreamerBot
{
	class StreamerBot_Component : LogicComponent
	{
		public override string ComponentName => "StreamerBot Connection";

		public StreamerBot_Settings Settings { get; set; }

		public bool Disposed { get; private set; }

		private TimerModel _timer;
		private LiveSplitState _state;

		public StreamerBot_Component(LiveSplitState state)
		{
			_state = state;

			_timer = new TimerModel { CurrentState = state };
			StreamerBot_Connection.GetInstance().RegisterEvents(_state);
			this.Settings = new StreamerBot_Settings(state);
		}

		public override void Dispose()
		{
			this.Disposed = true;
			var instance = StreamerBot_Connection.GetInstance();
			instance.UnregisterEvents(_state);
			instance.Dispose();
			this.Settings = null;
			this._state = null;
			this._timer = null;
		}

		public override XmlNode GetSettings(XmlDocument document)
		{
			return this.Settings.GetSettings(document);
		}

		public override Control GetSettingsControl(LayoutMode mode)
		{
			return this.Settings;
		}

		public override void SetSettings(XmlNode settings)
		{
			this.Settings.SetSettings(settings);
		}

		public override void Update(IInvalidator invalidator, LiveSplitState state, float width, float height, LayoutMode mode) { }
		//public override void RenameComparison(string oldName, string newName) { }
	}
}
