using BepInEx;
using BepInEx.Logging;
using HarmonyLib;

namespace NoFriendlyFire
{
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class NoFriendlyFire : BaseUnityPlugin
    {
        private readonly Harmony _harmony = new(PluginInfo.PLUGIN_GUID);
        public static ManualLogSource LoggerInstance { get; private set; }
        
        private void Awake()
        {
            LoggerInstance = this.Logger;
            LoggerInstance.LogInfo($"Plugin {PluginInfo.PLUGIN_NAME} loaded successfully.");
            _harmony.PatchAll();
        }
    }
}