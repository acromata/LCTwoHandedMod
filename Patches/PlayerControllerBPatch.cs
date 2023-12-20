using GameNetcodeStuff;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoHanded.Patches
{
    [HarmonyPatch(typeof(PlayerControllerB))]
    internal class PlayerControllerBPatch
    {
        [HarmonyPatch("BeginGrabObject")]
        [HarmonyPostfix]
        static void UpdateBeginGrabObject(ref bool ___twoHanded)
        {
            ___twoHanded = false;
        }

        [HarmonyPatch("GrabObjectClientRpc")]
        [HarmonyPostfix]
        static void UpdateGrabObjectClientRpc(ref bool ___twoHanded)
        {
            ___twoHanded = false;
        }

        [HarmonyPatch("SwitchToItemSlot")]
        [HarmonyPostfix]
        static void UpdateSwitchToItemSlot(ref bool ___twoHanded)
        {
            ___twoHanded = false;
        }
    }
}
