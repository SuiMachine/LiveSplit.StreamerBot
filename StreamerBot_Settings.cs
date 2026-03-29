using LiveSplit.StreamerBot.CustomAttributes;
using LiveSplit.StreamerBot.Extensions;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace LiveSplit.StreamerBot
{
	public partial class StreamerBot_Settings : UserControl
	{
		private bool Loaded;
		[LiveSplitStreamerBotStoreLayoutSetting]
		[LiveSplitStreamerBotSettingsAttributeBool("Autoconnect", false)]
		public bool Autoconnect { get; set; }

		[LiveSplitStreamerBotStoreLayoutSetting]
		[LiveSplitStreamerBotSettingsAttributeString("Api_Address", "ws://127.0.0.1:9090")]
		public string Api_Address { get; set; }

		[LiveSplitStreamerBotStoreLayoutSetting]
		[LiveSplitStreamerBotSettingsAttributeBool("DebugLog", false)]
		public bool DebugLog { get; set; }

		private List<(PropertyInfo Property, LiveSplitStreamerBotSettingsAttribute Attribute)> mappings;
		private List<(PropertyInfo Property, LiveSplitStreamerBotSettingsAttribute Attribute)> layout_settingsMappings;
		private Model.LiveSplitState m_state;
		private System.Random random;

		public StreamerBot_Settings(Model.LiveSplitState state)
		{
			InitializeComponent();
			this.m_state = state;
			random = new Random();

			this.CB_Autoconnect.DataBindings.Add("Checked", this, nameof(Autoconnect), false, DataSourceUpdateMode.OnPropertyChanged);
			this.TB_Address.DataBindings.Add("Text", this, nameof(Api_Address), false, DataSourceUpdateMode.OnPropertyChanged);
			this.CB_Log_DebugMessages.DataBindings.Add("Checked", this, nameof(DebugLog), false, DataSourceUpdateMode.OnPropertyChanged);

			// defaults
			ApplyDefaults();
			StreamerBot_Connection.GetInstance().SetFormReference(this);
		}

		private void StreamerBotSettings_VisibleChanged(object sender, EventArgs e)
		{
			if (this.Visible)
			{
				ConnectionStatusChanged(StreamerBot_Connection.GetInstance().IsConnected);
				StreamerBot_Connection.GetInstance().OnConnectionChanged += ConnectionStatusChanged;
			}
			else
			{
				StreamerBot_Connection.GetInstance().OnConnectionChanged -= ConnectionStatusChanged;
			}
		}

		private void ConnectionStatusChanged(bool active)
		{
			if (this.InvokeRequired)
			{
				this.Invoke(new Action(() =>
				{
					ConnectionStatusChanged(active);
				}));
				return;
			}
			else
			{
				if (active)
				{
					L_ConnectionStatus.Text = "Connected";
					L_ConnectionStatus.ForeColor = System.Drawing.Color.Green;
					B_Connect.Text = "Disconnect";
				}
				else
				{
					L_ConnectionStatus.Text = "Disconnected";
					L_ConnectionStatus.ForeColor = System.Drawing.Color.Red;
					B_Connect.Text = "Connect";
				}
			}
		}

		private void CreateMappings()
		{
			if (mappings == null)
			{
				mappings = new List<(PropertyInfo, LiveSplitStreamerBotSettingsAttribute)>();

				var properties = typeof(StreamerBot_Settings).GetProperties();
				foreach (var property in properties)
				{
					var value = (LiveSplitStreamerBotSettingsAttribute)property.GetCustomAttribute(typeof(LiveSplitStreamerBotSettingsAttribute));
					if (value != null)
					{
						mappings.Add((property, value));
					}
				}
			}

			if (layout_settingsMappings == null)
			{
				layout_settingsMappings = new List<(PropertyInfo Property, LiveSplitStreamerBotSettingsAttribute Attribute)>();

				var properties = typeof(StreamerBot_Settings).GetProperties();
				foreach (var property in properties)
				{
					var storeAttribute = (LiveSplitStreamerBotStoreLayoutSetting)property.GetCustomAttribute(typeof(LiveSplitStreamerBotStoreLayoutSetting));
					if (storeAttribute != null)
					{
						var value = (LiveSplitStreamerBotSettingsAttribute)property.GetCustomAttribute(typeof(LiveSplitStreamerBotSettingsAttribute));

						if (value != null && !string.IsNullOrEmpty(value.NAME))
						{
							layout_settingsMappings.Add((property, value));
						}
					}
				}
			}
		}

		private void ApplyDefaults()
		{
			CreateMappings();

			foreach (var mapping in mappings)
				mapping.Property.SetValue(this, mapping.Attribute.GetDefaultValue());
		}

		public XmlNode GetSettings(XmlDocument doc)
		{
			XmlElement settingsNode = doc.CreateElement("Settings");

			settingsNode.AppendChild(doc.ToElement("Version", Assembly.GetExecutingAssembly().GetName().Version.ToString(3)));

			foreach (var mapping in layout_settingsMappings)
				mapping.Attribute.GetSetting(settingsNode, mapping.Property.GetValue(this));

			return settingsNode;
		}

		public void SetSettings(XmlNode settings)
		{
			CreateMappings();

			foreach (var mapping in layout_settingsMappings)
				mapping.Property.SetValue(this, mapping.Attribute.SetSetting(settings, mapping.Property.GetValue(this)));

			if (!Loaded)
			{
				Loaded = true;
				if (this.Autoconnect && !StreamerBot_Connection.GetInstance().IsConnected)
				{
					Task.Factory.StartNew(StreamerBot_Connection.GetInstance().Connect);
				}
			}
		}

		private void B_Connect_Click(object sender, EventArgs e)
		{
			if (DebugLog)
				AppendMessage("Connect clicked!");

			if (!StreamerBot_Connection.GetInstance().IsConnected)
				StreamerBot_Connection.GetInstance().Connect();
			else
				StreamerBot_Connection.GetInstance().Disconnect();
		}

		private void B_Test_OnStart_Click(object sender, EventArgs e)
		{
			if (DebugLog)
				AppendMessage("OnStart clicked!");

			if (!StreamerBot_Connection.GetInstance().IsConnected)
				return;

			StreamerBot_Connection.GetInstance().SendMessage(new Streamerbot.StreamerBot_Events.StreamerBot_Events_Splits.OnStart(m_state));
		}

		private void B_Test_OnPause_Click(object sender, EventArgs e)
		{
			if (DebugLog)
				AppendMessage("OnPause clicked!");

			if (!StreamerBot_Connection.GetInstance().IsConnected)
				return;

			StreamerBot_Connection.GetInstance().SendMessage(new Streamerbot.StreamerBot_Events.StreamerBot_Events_Splits.OnPause(m_state));
		}

		private void B_Test_OnReset_Click(object sender, EventArgs e)
		{
			if (DebugLog)
				AppendMessage("OnReset clicked!");

			if (!StreamerBot_Connection.GetInstance().IsConnected)
				return;

			StreamerBot_Connection.GetInstance().SendMessage(new Streamerbot.StreamerBot_Events.StreamerBot_Events_Splits.OnReset(m_state));
		}

		private void B_Test_OnResume_Click(object sender, EventArgs e)
		{
			if (DebugLog)
				AppendMessage("OnResume clicked!");

			if (!StreamerBot_Connection.GetInstance().IsConnected)
				return;

			StreamerBot_Connection.GetInstance().SendMessage(new Streamerbot.StreamerBot_Events.StreamerBot_Events_Splits.OnResume(m_state));
		}

		private void B_Test_OnUndoSplit_Click(object sender, EventArgs e)
		{
			if (DebugLog)
				AppendMessage("OnUndoSplit clicked!");

			if (!StreamerBot_Connection.GetInstance().IsConnected)
				return;

			StreamerBot_Connection.GetInstance().SendMessage(new Streamerbot.StreamerBot_Events.StreamerBot_Events_Splits.OnUndoSplit(m_state));
		}

		private void B_Test_OnSkipSplit_Click(object sender, EventArgs e)
		{
			if (DebugLog)
				AppendMessage("OnSkipSplit clicked!");

			if (!StreamerBot_Connection.GetInstance().IsConnected)
				return;

			StreamerBot_Connection.GetInstance().SendMessage(new Streamerbot.StreamerBot_Events.StreamerBot_Events_Splits.OnSkipSplit(m_state));
		}

		private void B_Test_OnRedSplit_Click(object sender, EventArgs e)
		{
			if (DebugLog)
				AppendMessage("OnRedSplitClicked(BestSplit) clicked!");

			if (!StreamerBot_Connection.GetInstance().IsConnected)
				return;

			StreamerBot_Connection.GetInstance().SendMessage(new Streamerbot.StreamerBot_Events.StreamerBot_Events_Splits.OnRedSplit(m_state)
			{
				SplitTimeDifference = new TimeSpan(0, 0, 10),
				SegmentResult = Streamerbot.StreamerBot_Events.StreamerBot_Events_Splits.SegmentResultE.BestSegment
			});
		}

		private void B_Test_OnRedSplitSavedTime_Click(object sender, EventArgs e)
		{
			if (DebugLog)
				AppendMessage("OnRedSplitClicked(SavedTime) clicked!");

			if (!StreamerBot_Connection.GetInstance().IsConnected)
				return;

			StreamerBot_Connection.GetInstance().SendMessage(new Streamerbot.StreamerBot_Events.StreamerBot_Events_Splits.OnRedSplit(m_state)
			{
				SplitTimeDifference = new TimeSpan(0, 0, 10),
				SegmentResult = Streamerbot.StreamerBot_Events.StreamerBot_Events_Splits.SegmentResultE.SavedTime
			});
		}

		private void B_Test_OnRedSplitLostTime_Click(object sender, EventArgs e)
		{
			if (DebugLog)
				AppendMessage("OnRedSplitClicked(LostTime) clicked!");

			if (!StreamerBot_Connection.GetInstance().IsConnected)
				return;

			StreamerBot_Connection.GetInstance().SendMessage(new Streamerbot.StreamerBot_Events.StreamerBot_Events_Splits.OnRedSplit(m_state)
			{
				SplitTimeDifference = new TimeSpan(0, 0, 10),
				SegmentResult = Streamerbot.StreamerBot_Events.StreamerBot_Events_Splits.SegmentResultE.LostTime
			});
		}

		private void B_Test_OnGreenSplit_Click(object sender, EventArgs e)
		{
			if (DebugLog)
				AppendMessage("OnGreenSplit(Gold) clicked!");

			if (!StreamerBot_Connection.GetInstance().IsConnected)
				return;

			StreamerBot_Connection.GetInstance().SendMessage(new Streamerbot.StreamerBot_Events.StreamerBot_Events_Splits.OnGreenSplit(m_state)
			{
				SegmentResult = Streamerbot.StreamerBot_Events.StreamerBot_Events_Splits.SegmentResultE.BestSegment
			});
		}

		private void B_Test_OnGreenSplitSaved_Click(object sender, EventArgs e)
		{
			if (DebugLog)
				AppendMessage("OnGreenSplit(SavedTime) clicked!");

			if (!StreamerBot_Connection.GetInstance().IsConnected)
				return;

			StreamerBot_Connection.GetInstance().SendMessage(new Streamerbot.StreamerBot_Events.StreamerBot_Events_Splits.OnGreenSplit(m_state)
			{
				SegmentResult = Streamerbot.StreamerBot_Events.StreamerBot_Events_Splits.SegmentResultE.SavedTime
			});
		}

		private void B_Test_OnGreenSplitLost_Click(object sender, EventArgs e)
		{
			if (DebugLog)
				AppendMessage("OnGreenSplit(LostTime) clicked!");

			if (!StreamerBot_Connection.GetInstance().IsConnected)
				return;

			StreamerBot_Connection.GetInstance().SendMessage(new Streamerbot.StreamerBot_Events.StreamerBot_Events_Splits.OnGreenSplit(m_state)
			{
				SplitTimeDifference = new TimeSpan(0, 0, -10),
				SegmentResult = Streamerbot.StreamerBot_Events.StreamerBot_Events_Splits.SegmentResultE.LostTime
			});
		}

		private void ScrollLogToEnd()
		{
			RB_LogText.SelectionStart = RB_LogText.Text.Length;
			RB_LogText.ScrollToCaret();
		}

		internal void AppendMessage(string t)
		{
			if (RB_LogText.InvokeRequired)
			{
				RB_LogText.Invoke(new Action(() =>
				{
					AppendMessage(t);
				}));
			}
			else
			{
				RB_LogText.AppendText(t + "\r\n");
				ScrollLogToEnd();
			}
		}
	}
}
