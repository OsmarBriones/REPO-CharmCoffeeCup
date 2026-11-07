using BepInEx;
using CharmCore.Api;
using UnityEngine;

namespace CharmCoffeeCup
{
	[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
	[BepInDependency("com.osmar.Pockets", BepInDependency.DependencyFlags.HardDependency)]
	[BepInDependency("com.osmar.CharmCore", BepInDependency.DependencyFlags.HardDependency)]
	public class CharmCoffeeCupPlugin : BaseUnityPlugin
	{
		public const string PluginGuid = "com.osmar.CharmCoffeeCup";
		public const string PluginName = "CharmCoffeeCup";
		public const string PluginVersion = "1.0.0";

		internal static new BepInEx.Logging.ManualLogSource Logger { get; private set; } = null!;

		private void Awake()
		{
			Logger = base.Logger;

			// Prevent the plugin from being deleted
			this.gameObject.transform.parent = null;
			this.gameObject.hideFlags = HideFlags.HideAndDontSave;

			CoffeeCupCharm charm = new CoffeeCupCharm();
			CharmsApi.Register(charm, Config);
			this.gameObject.AddComponent<SecondWind>().Charm = charm;

			Logger.LogInfo($"{PluginName} {PluginVersion} loaded!");
		}
	}
}
