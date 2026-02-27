using LiveSplit.Model;
using LiveSplit.Streamerbot.StreamerBot_Events;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics;
using System.Linq;
using WebSocketSharp;


namespace LiveSplit.StreamerBot
{
	public class StreamerBot_Connection
	{
		private static StreamerBot_Connection instance;
		private StreamerBot_Settings m_settingsForm;
		private StreamerBot_TimerEvents m_timerEvents = new StreamerBot_TimerEvents();

		public Action<bool> OnConnectionChanged;
		private WebSocket webSocket;
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
			if (!IsConnected)
			{
				try
				{
					webSocket = new WebSocket(m_settingsForm.Api_Address);
					webSocket.OnOpen += WebSocket_OnOpen;
					webSocket.OnClose += WebSocket_OnClose;
					webSocket.ConnectAsync();
				}
				catch (Exception ex)
				{
					Log(ex.ToString());
				}
			}
		}

		public void Disconnect()
		{
			if (IsConnected)
			{
				webSocket.CloseAsync();
			}
		}

		private void WebSocket_OnClose(object sender, CloseEventArgs e)
		{
			OnConnectionChanged?.Invoke(false);

			if (e.Reason != null)
				Log($"Disconnected wih a reason: \'{e.Reason}\'");
			else
				Log($"Disconnected with code {e.Code}");
		}

		private void WebSocket_OnOpen(object sender, EventArgs e)
		{
			Log("Connected!");
			OnConnectionChanged?.Invoke(true);
		}

		public void Log(string message)
		{
			if (m_settingsForm != null && m_settingsForm.DebugLog)
			{
				string t = "[StreamerBot]: " + message;
				m_settingsForm.AppendMessage(t);
				Debug.WriteLine(t);
			}
		}

		public void LogWarning(string message)
		{
			if (m_settingsForm != null && m_settingsForm.DebugLog)
			{
				string t = "[StreamerBot] Warning: " + message;
				m_settingsForm.AppendMessage(t);
				Debug.WriteLine(t);
			}
		}

		public void LogError(string error)
		{
			if (m_settingsForm != null && m_settingsForm.DebugLog)
			{
				string t = "[StreamerBot VTS] Error: " + error;
				m_settingsForm.AppendMessage(t);
				Debug.WriteLine(t);
			}
		}

		public void SetFormReference(StreamerBot_Settings form) => m_settingsForm = form;

		public void RegisterEvents(LiveSplitState state) => m_timerEvents.RegisterEvents(state, this);

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
