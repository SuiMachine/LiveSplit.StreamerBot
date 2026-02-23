using LiveSplit.Model;
using LiveSplit.UI.Components;
using System;
using System.Reflection;

namespace LiveSplit.StreamerBot
{
	public class StreamerBotFactory : IComponentFactory
	{
		private StreamerBot_Component _instance;

		public string ComponentName => "StreamerBot Connection";

		public string Description => "Allows to execute actions in StreamerBot based on LiveSplit states.";

		public ComponentCategory Category
		{
			get { return ComponentCategory.Other; }
		}

		public IComponent Create(LiveSplitState state)
		{
			return (_instance = new StreamerBot_Component(state));
		}

		public string UpdateName
		{
			get { return this.ComponentName; }
		}

		public string UpdateURL
		{
			get { return "https://raw.githubusercontent.com/SuiMachine/LiveSplit.StreamerBot/master/"; }
		}

		public Version Version
		{
			get { return Assembly.GetExecutingAssembly().GetName().Version; }
		}

		public string XMLURL => this.UpdateURL + "Components/update.LiveSplit.StreamerBot.xml";
	}
}
