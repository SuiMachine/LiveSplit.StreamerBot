using LiveSplit.Model;
using System;
using System.Xml;

namespace LiveSplit.StreamerBot.Extensions
{
	public static class XML_Utils
	{
		public static XmlElement ToElement<T>(this XmlDocument document, string name, T value)
		{
			XmlElement str = document.CreateElement(name);
			str.InnerText = value.ToString();
			return str;
		}

		public static bool ReadBool(XmlNode settings, string setting, bool default_ = false)
		{
			var assign = settings[setting];

			if (assign != null)
			{
				if (bool.TryParse(settings[setting].InnerText, out var val))
				{
					return val;
				}
				else
					return default_;
			}
			else
				return default_;
		}

		public static string ReadString(XmlNode settings, string setting, string default_ = "")
		{
			var assign = settings[setting];

			if (assign != null)
			{
				if (!string.IsNullOrEmpty(settings[setting].InnerText))
					return settings[setting].InnerText;
				else
					return default_;
			}
			else
				return default_;
		}

		public static TimeSpan? GetLastSegmentTime(this IRun run, int split, TimingMethod method)
		{
			if (split == 0)
			{
				return run[0].SplitTime[method];
			}
			else
			{
				return run[split].SplitTime[method] - run[split - 1].SplitTime[method];
			}
		}
	}
}
