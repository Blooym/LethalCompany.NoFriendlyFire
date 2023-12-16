using GameNetcodeStuff;
using HarmonyLib;
using UnityEngine;

namespace NoFriendlyFire.Patches
{
    [HarmonyPatch]
    internal class NoFriendlyFireDamagePatch
    {
        [HarmonyPatch(typeof(PlayerControllerB), "DamagePlayerFromOtherClientServerRpc")]
        [HarmonyPrefix]
        public static void DamagePlayerFromOtherClientServerRpc(ref int damageAmount, Vector3 hitDirection, int playerWhoHit)
        {
            NoFriendlyFire.LoggerInstance.LogDebug($"Player{playerWhoHit} attempted to friendly fire, setting damage amount to 0.");
            damageAmount = 0;
        }
    }
}