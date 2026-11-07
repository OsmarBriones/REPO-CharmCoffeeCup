# QA battery: Second Wind (CharmCore + CharmCoffeeCup)

Deploy: Pockets, CharmCore and CharmCoffeeCup are in the r2modman `Debug` profile (hashes match the builds). Restart the game first.

## Quick start with debug mode
Set `DebugMode = true` in the `Debug` section of `BepInEx/config/com.osmar.CharmCoffeeCup.cfg` (off by default). When a level starts, a Coffee Cup is placed on the floor about 2.5 m in front of you; the log then also shows the detailed lines (`Carrying`, `Used`, `Wear ...`, `After wear ...`, `Second Wind: energy restored`). Any level works.

## Single player
- [ ] Log shows `Charm registered: Coffee Cup - Second Wind` and `CharmCore 1.0.0 loaded!`.
- [ ] Find the Coffee Cup (Arctic levels), store it in a slot. The slot shows its picture and value.
- [ ] Sprint until the bar empties: energy jumps to about 30%, `Second Wind: energy restored` in the log, the cup's value drops about 20% of its original, a red loss number appears.
- [ ] A dark veil with seconds appears on the slot for 3 s and empties; sprinting to zero again inside the pause does nothing.
- [ ] Take the cup out: at zero energy nothing is restored.
- [ ] Repeat about 5 times: the cup breaks, the slot empties, the power stops, no errors in the log.

## Settings
- [ ] `CooldownSeconds = 0`: no veil, it triggers every time the bar hits zero.
- [ ] `WearPercent = 0`: no wear. `RestorePercent = 100`: full bar.
- [ ] Charm `Enabled = false`: no effect and no wear.
- [ ] CharmCore `WearMultiplier = 2`: wear doubles. `Enabled = false`: nothing works.

## Multiplayer (host and client)
- [ ] Client with the cup: the energy restore happens on the client, the value drops on both machines.
- [ ] Host settings override the client's (different `CooldownSeconds`/`RestorePercent` in each cfg).
- [ ] Client leaves and rejoins: no stuck veil, pocket state as Pockets restores it.

Log patterns: `Second Wind`, `Charm registered`, `threw`, `Exception`.
