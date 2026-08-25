using LiveSplit.Model;
using LiveSplit.Streamerbot.StreamerBot_Events;
using Newtonsoft.Json;
using System;
using System.Data;
using System.Diagnostics;
using WebSocketSharp;


namespace LiveSplit.StreamerBot
{
	public class StreamerBot_Connection : IDisposable
	{
		private static StreamerBot_Connection instance;
		private StreamerBot_Settings m_settingsForm;
		private StreamerBot_TimerEvents m_timerEvents = new StreamerBot_TimerEvents();
		private TimerModel m_Timer;
		private LiveSplitState m_state;

		public Action<bool> OnConnectionChanged;
		private WebSocket webSocket;
		private System.Timers.Timer m_ReconnectTimer;
		private int m_FailureCounter = 0;
		public bool IsConnected => webSocket != null && webSocket.IsAlive;

		public static StreamerBot_Connection GetInstance()
		{
			if (instance == null)
			{
				instance = new StreamerBot_Connection();
				return instance;
			}

			return instance;
		}

		public void Connect()
		{
			Log("Connecting...");
			if (!IsConnected)
			{
				try
				{
					if (m_ReconnectTimer != null)
					{
						m_ReconnectTimer.Stop();
						m_ReconnectTimer.Dispose();
						m_ReconnectTimer = null;
					}
					webSocket = new WebSocket(m_settingsForm.Api_Address);
					webSocket.OnOpen += WebSocket_OnOpen;
					webSocket.OnClose += WebSocket_OnClose;
					webSocket.OnMessage += WebSocket_OnMessage;
					webSocket.ConnectAsync();
				}
				catch (Exception ex)
				{
					LogError($"Connecting error: {ex}");
				}
			}
		}

		public void Dispose()
		{
			Disconnect();
			instance = null;
			webSocket = null;
		}

		public void Disconnect()
		{
			if (IsConnected)
			{
				webSocket.CloseAsync();
			}
		}

		private void WebSocket_OnMessage(object sender, MessageEventArgs e)
		{
			var lc = e.Data.Trim().ToLower();
			switch (lc)
			{
				case "starttimer":
					m_Timer.Start();
					return;
				case "pausertimer":
					m_Timer.Pause();
					return;
				case "unpausetimer":
					m_Timer.UndoAllPauses();
					return;
				case "resettimer":
					m_Timer.Reset();
					return;
				case "skipsplit":
					m_Timer.SkipSplit();
					return;
				case "undosplit":
					m_Timer.UndoSplit();
					return;
				case "split":
					m_Timer.Split();
					return;
				case "requestdata":
					m_timerEvents.RequestRunData(m_state);
					return;
			}
		}

		private void WebSocket_OnClose(object sender, CloseEventArgs e)
		{
			OnConnectionChanged?.Invoke(false);

			var result = TranslateCode(e.Code);

			if (!string.IsNullOrEmpty(e.Reason))
				Log($"Disconnected wih a reason: \'{e.Reason}\' - code: {result}");
			else
				Log($"Disconnected with code '{result}'");

			if (m_ReconnectTimer == null && m_settingsForm.Autoconnect)
			{
				int delay = 10_000;
				if (m_FailureCounter >= 10)
					delay = 60_000;

				m_ReconnectTimer = new System.Timers.Timer(delay);
				m_ReconnectTimer.Elapsed += (s, ev) =>
				{
					Log($"Attempting to reconnect ({m_FailureCounter})...");
					Connect();
				};
				m_FailureCounter++;
				m_ReconnectTimer.Start();
			}
		}

		private string TranslateCode(ushort code)
		{
			switch (code)
			{
				case 1000:
					return "Normal Closure";
				case 1001:
					return "Going Away";
				case 1002:
					return "Protocol Error";
				case 1003:
					return "Unsupported Data";
				case 1005:
					return "No Status Received";
				case 1006:
					return "Abnormal Closure";
				case 1007:
					return "Invalid frame payload data";
				case 1008:
					return "Policy Violation";
				case 1009:
					return "Message Too Big";
				case 1010:
					return "Mandatory Extension";
				case 1011:
					return "Internal Server Error";
				case 1015:
					return "TLS Handshake Failure";
				default:
					return $"Undefined {code}";
			}
		}

		private void WebSocket_OnOpen(object sender, EventArgs e)
		{
			Log("Connected!");
			OnConnectionChanged?.Invoke(true);
			m_FailureCounter = 0;
		}

		public void Log(string message, bool alwaysLog = false)
		{
			if (m_settingsForm != null && (m_settingsForm.DebugLog || alwaysLog))
			{
				string t = "[StreamerBot]: " + message;
				m_settingsForm.AppendMessage(t);
				Debug.WriteLine(t);
			}
		}

		public void LogWarning(string message, bool alwaysLog = false)
		{
			if (m_settingsForm != null && (m_settingsForm.DebugLog || alwaysLog))
			{
				string t = "[StreamerBot] Warning: " + message;
				m_settingsForm.AppendMessage(t);
				Debug.WriteLine(t);
			}
		}

		public void LogError(string error, bool alwaysLog = false)
		{
			if (m_settingsForm != null && (m_settingsForm.DebugLog || alwaysLog))
			{
				string t = "[StreamerBot VTS] Error: " + error;
				m_settingsForm.AppendMessage(t);
				Debug.WriteLine(t);
			}
		}

		public void SetFormReference(StreamerBot_Settings form) => m_settingsForm = form;

		public void RegisterEvents(LiveSplitState state, TimerModel timer)
		{
			m_state = state;
			m_Timer = timer;
			m_timerEvents.RegisterEvents(state, this);
		}

		public void UnregisterEvents(LiveSplitState state) => m_timerEvents.UnregisterEvents(state);

		public void SendMessage(StreamerBot_Event message, bool includeNulls = false)
		{
			if (IsConnected)
			{
#if DEBUG
				var convert = JsonConvert.SerializeObject(message, Formatting.Indented, new JsonSerializerSettings()
				{
					NullValueHandling = includeNulls ? NullValueHandling.Include : NullValueHandling.Ignore
				});

				Debug.WriteLine($"Sending: {convert}");

#else
				var convert = JsonConvert.SerializeObject(message);
#endif

				Log($"Sending {message.EventType}");
				webSocket.SendAsync(convert, new Action<bool>((success) =>
				{
					if (!success)
					{
						LogError("Failed to send");
					}
				}));
			}
		}
	}
}
