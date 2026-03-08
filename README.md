# Tarkov DLSS 4.5
This pre-patcher enables **DLSS 4.5** support in SPT/Fika.

## Installation
> [!WARNING]
> Backup `nvngx_dlss.dll` located in `EscapeFromTarkov_Data\Plugins\x86_64` of your SPT installation folder before proceeding. 

1. Locate `nvngx_dlss.dll` in the live `EscapeFromTarkov_Data\Plugins\x86_64` folder.
    * The 4.5 DLL is also available [here](https://www.techpowerup.com/download/nvidia-dlss-dll/).
2. Copy and paste the DLL into the SPT `EscapeFromTarkov_Data\Plugins\x86_64` folder.
3. Extract the downloaded pre-patcher.
4. Select one of the new presets in-game.

## Notes
Set DLSS to any setting above **Preset J** before installation to prevent loading failures. This plugin removes obsolete presets that are incompatible with **DLSS 4.5**. 

Selecting any preset below **J** will result in an automatic reversion to **Preset K**; this behavior occurs natively when using the updated DLSS DLL.

Disable driver-level overrides before use.
