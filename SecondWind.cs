using UnityEngine;

namespace CharmCoffeeCup
{
	/// <summary>
	/// Watches the local player's energy. Energy is a local number on <see cref="PlayerController"/>, so no network
	/// is needed: when it reaches zero and the charm is ready, part of it is given back and the cup wears down.
	/// </summary>
	internal sealed class SecondWind : MonoBehaviour
	{
		internal CoffeeCupCharm Charm { get; set; } = null!;

		private void Update()
		{
			if (Charm == null || !Charm.IsActive)
			{
				return;
			}

			PlayerController? player = PlayerController.instance;
			if (player == null || player.EnergyCurrent > 0f)
			{
				return;
			}

			if (Charm.TryUse())
			{
				player.EnergyCurrent = player.EnergyStart * (Charm.RestorePercent.Value / 100f);
				Charm.LogDebug($"Second Wind: energy restored to {player.EnergyCurrent:0} of {player.EnergyStart:0}");
			}
		}
	}
}
