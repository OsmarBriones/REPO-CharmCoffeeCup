# Changelog

## [Unreleased]

### Added
- `Debug.DebugMode` (off by default): puts a Coffee Cup on the floor at the start of each level and writes detailed logs.
- Second Wind: a Coffee Cup in a pocket restores part of your energy the moment it runs out, wearing the cup down. Cooldown shown on the slot.

### Changed
- Runtime hygiene pass: guarded the debug log in the per-frame effect; no per-level state, nothing else to change.
