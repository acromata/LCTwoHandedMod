using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using TwoHanded.Patches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoHanded
{
    [BepInPlugin(modGUID, modName, modVersion)]
    public class TwoHandedBase : BaseUnityPlugin
    {
        // Mod Metadata
        private const string modGUID = "Acromata.TwoHanded";
        private const string modName = "Two Handed Mod";
        private const string modVersion = "1.0.0";

        // Mod Setup
        private readonly Harmony harmony = new Harmony(modGUID);
        private static TwoHandedBase Instance;
        internal ManualLogSource logSource;

        void Awake()
        {
            // Instance singleton
            if(Instance == null)
            {
                Instance = this;
            }

            // Setup log
            logSource = BepInEx.Logging.Logger.CreateLogSource(modGUID);

            // Patches
            harmony.PatchAll(typeof(TwoHandedBase));
            harmony.PatchAll(typeof(PlayerControllerBPatch));
        }
    }
}
