# NoFriendlyFire for Lethal Company

<a href="https://thunderstore.io/c/lethal-company/p/Blooym/NoFriendlyFire/">
 <img width="180" src="Thunderstore/available_on_thunderstore.png" alt="Available on Thunderstore">
</a>

A very simple mod for Lethal Company that sets all incoming damage taken from other players to zero whilst ensuring that mechanics that require friendly fire still function as intended.

## Compatibility

This mod should be compatible with any other mod that adds additional equipment as long as any damage to players is applied using the `DamagePlayerFromOtherClientServerRpc` method.
    
## Building Locally

First, setup your development environment for BepInEx / Lethal Company modding, you can follow the guide [here](https://web.archive.org/web/20231216233930/https://lethal.wiki/modding/initial-setup.html) if you need help with that.

Afterwards, you'll need to move the files `Assembly-CSharp.dll` and `Unity.Netcode.Runtime.dll` from `<Lethal Company Path>/LethalCompany_Data/Managed` to `lib/` and run `dotnet build`.