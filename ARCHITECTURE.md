# CharmCoffeeCup Architecture

A Charm mod (layer 3 of the PocketCharms family): one valuable, one power. It depends on **Pockets** (storage) and **CharmCore** (registry, wear, cooldown display, host settings).

## The power: Second Wind

The Coffee Cup valuable (prefab `Valuable Arctic Coffee Cup`) in the local player's pocket restores part of their energy the moment it reaches zero.

- `CoffeeCupCharm : Charm` registers the prefab name, the defaults (wear 20%, cooldown 3 s) and one extra host-synced setting, `RestorePercent` (30).
- `SecondWind` (a `MonoBehaviour` on the plugin object) runs every frame: if the charm is active and `PlayerController.instance.EnergyCurrent <= 0`, it calls `Charm.TryUse()`. When that returns true it sets `EnergyCurrent = EnergyStart * RestorePercent / 100`.

Energy is a local number on `PlayerController`, so no patch and no network traffic is needed for the effect itself. Wear is requested through CharmCore (host applies it).

## Game members used

`PlayerController.instance`, `PlayerController.EnergyCurrent`, `PlayerController.EnergyStart` (checked by `CharmCoffeeCup.Tests`).

## Known limits

- Looked up by exact prefab name; a game update that renames the prefab needs a mod update.
- The effect checks energy once per frame; a single frame at zero energy is possible before it triggers and the vanilla sprint check fails that frame.
- Only the Arctic Coffee Cup exists today.
