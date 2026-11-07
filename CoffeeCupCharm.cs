using CharmCore.Api;

namespace CharmCoffeeCup
{
	/// <summary>Second Wind: the Coffee Cup in a pocket gives back energy the moment it runs out.</summary>
	internal sealed class CoffeeCupCharm : Charm
	{
		internal const string PrefabName = "Valuable Arctic Coffee Cup";

		internal CoffeeCupCharm()
			: base("CoffeeCup", "Coffee Cup - Second Wind", defaultWearPercent: 20f, defaultCooldownSeconds: 3f, PrefabName)
		{
			RestorePercent = AddSetting("RestorePercent", 30f, 1f, 100f, "Share of your maximum energy that comes back when it runs out, in percent.");
		}

		/// <summary>Share of the maximum energy restored when it hits zero.</summary>
		internal CharmSetting RestorePercent { get; }
	}
}
