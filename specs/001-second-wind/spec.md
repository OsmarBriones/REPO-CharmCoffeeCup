## User Scenarios

### User Story 1 - Second Wind (Priority: P1)
A player stores a Coffee Cup in a pocket. When their energy reaches 0 while the cup is pocketed, 30% of their maximum energy comes back instantly. A cooldown (default 3 s, configurable, 0 disables it) prevents chain triggers and is shown on the pocket slot by CharmCore.
**Acceptance**: energy hits 0 with the cup pocketed -> energy jumps to 30% and the cup wears 20% of its original value; during the cooldown nothing happens; with the cup out of the pocket nothing happens.

### User Story 2 - Wear (Priority: P1)
Each Second Wind wears 20% of the cup's original value (configurable). The cup breaks when worn out.

## Requirements
- FR-001: Registers a charm with CharmCore for the Coffee Cup valuable (prefab Valuable Arctic Coffee Cup).
- FR-002: Detects the local player's energy reaching 0 (PlayerController.EnergyCurrent) and restores 30% of EnergyStart.
- FR-003: Settings via CharmCore: Enabled, WearPercent (20), CooldownSeconds (3), host-authoritative; plus RestorePercent (30).
- FR-004: All players install it (Category 2); depends on CharmCore.
