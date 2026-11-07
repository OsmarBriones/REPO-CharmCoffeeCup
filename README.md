# Charm Coffee Cup

Second Wind: keep the Coffee Cup in your pocket and, the moment your energy runs out, a third of it comes right back.

> **Everyone in the lobby must install this mod, together with Pockets and CharmCore.** The power changes what your own character can do and its cooldown shows on your inventory slot, so friends without the mods would see an empty slot and be unable to use the pocket.

## How to Use

1. Find the **Coffee Cup** valuable (Arctic levels) and store it in a free inventory slot with [Pockets](https://thunderstore.io/c/repo/p/OsmarBriones/Pockets/) (grab it, press the slot key).
2. Run until your energy hits zero: 30% of your maximum energy comes back instantly and the cup loses part of its value.
3. A short pause follows, shown on the slot, before it can work again.
4. Take the cup out of the pocket and the power stops.

## Features

- **Second Wind:** when your energy runs out, part of it comes right back so you can get away.
- **It costs the cup:** each use wears away a share of the cup's value, so a worn cup is worth less at extraction and eventually breaks.
- **Cooldown on the slot:** a dark veil empties over the cup while you wait, with the seconds left.
- **Everything is configurable:** how much energy returns, how much the cup wears, and the pause (set it to 0 for none). The host's choices apply to everyone.

## Requirements
- [BepInEx Pack for R.E.P.O.](https://thunderstore.io/c/repo/p/BepInEx/BepInExPack/)
- [Pockets](https://thunderstore.io/c/repo/p/OsmarBriones/Pockets/)
- [CharmCore](https://thunderstore.io/c/repo/p/OsmarBriones/CharmCore/)

## Installation
1. Install through r2modman / Thunderstore Mod Manager (Pockets and CharmCore come with it), or place `CharmCoffeeCup.dll` next to `Pockets.dll` and `CharmCore.dll` in `BepInEx/plugins`. **All players need it.**
2. Launch the game once; the configuration file is created inside `BepInEx/config`.

## Configuration
Settings are in `com.osmar.CharmCoffeeCup.cfg` inside `BepInEx/config`, section `Charm.CoffeeCup`. The host's choices apply to everyone.

- `Enabled` (default `true`): turn this charm on or off.
- `WearPercent` (default `20`): share of the cup's original value lost on each use.
- `CooldownSeconds` (default `3`): pause between uses. `0` means none.
- `RestorePercent` (default `30`): share of your maximum energy that comes back.

## Issues & Bug Reports
The official way to report issues, suggest improvements, or submit feedback is by opening an issue on the official GitHub repository:
👉 [GitHub Issues](https://github.com/OsmarBriones/REPO-CharmCoffeeCup/issues)

## Credits
Developed by **Osmar Briones**
