using LiveSplit.StreamerBot.Extensions;
using System;
using System.Xml;

namespace LiveSplit.StreamerBot.CustomAttributes
{
	public class LiveSplitStreamerBotStoreLayoutSetting : Attribute { }

	public abstract class LiveSplitStreamerBotSettingsAttribute : Attribute
	{
		public string NAME { get; protected set; }

		public abstract object GetDefaultValue();
		public abstract void GetSetting(XmlElement settingNode, object objToStore);
		public abstract object SetSetting(XmlNode settingNode, object objToStoreTo);

	}

	public class LiveSplitStreamerBotSettingsAttributeBool : LiveSplitStreamerBotSettingsAttribute
	{
		public bool DEFAULT_VALUE { get; private set; }

		public LiveSplitStreamerBotSettingsAttributeBool(bool defaultValue)
		{
			DEFAULT_VALUE = defaultValue;
		}

		public LiveSplitStreamerBotSettingsAttributeBool(string Name, bool defaultValue)
		{
			this.NAME = Name;
			DEFAULT_VALUE = defaultValue;
		}

		public override object GetDefaultValue() => DEFAULT_VALUE;

		public override void GetSetting(XmlElement settingNode, object objToStore)
		{
			settingNode.AppendChild(settingNode.OwnerDocument.ToElement(this.NAME, (bool)objToStore));
		}

		public override object SetSetting(XmlNode settingNode, object objToStoreTo)
		{
			return XML_Utils.ReadBool(settingNode, this.NAME, DEFAULT_VALUE);
		}
	}

	public class LiveSplitStreamerBotSettingsAttributeString : LiveSplitStreamerBotSettingsAttribute
	{
		public string DEFAULT_VALUE { get; private set; }

		public LiveSplitStreamerBotSettingsAttributeString(string defaultValue)
		{
			DEFAULT_VALUE = defaultValue;
		}

		public LiveSplitStreamerBotSettingsAttributeString(string Name, string defaultValue)
		{
			this.NAME = Name;
			DEFAULT_VALUE = defaultValue;
		}

		public override object GetDefaultValue() => DEFAULT_VALUE;

		public override void GetSetting(XmlElement settingNode, object objToStore)
		{
			settingNode.AppendChild(settingNode.OwnerDocument.ToElement(this.NAME, (string)objToStore));
		}

		public override object SetSetting(XmlNode settingNode, object objToStoreTo)
		{
			var value = XML_Utils.ReadString(settingNode, this.NAME, DEFAULT_VALUE);
			return value;
		}
	}
}
