using HarmonyLib;
using Sons.Gameplay;
using System;

namespace KnightVSettings
{
    [HarmonyPatch(typeof(PlayerKnightVAction), "StartRiding")]
    internal static class KnightVPatch
    {
        private static void Postfix(ref PlayerKnightVAction __instance)
        {
            __instance._controlDefinition.MaxVelocity = Config.MaxVelocity.Value;
            __instance._controlDefinition.MaxPowerUsage = Config.MaxPowerUsage.Value;
            __instance._controlDefinition.WipeoutMinVelocity = Config.WipeoutMinVelocity.Value;
            __instance._controlDefinition.AccelerationInputRate = Config.AccelerationInputRate.Value;
            __instance._controlDefinition.MaxForwardAcceleration = Config.MaxForwardAcceleration.Value;
            __instance._controlDefinition.MaxReverseAcceleration = Config.MaxReverseAcceleration.Value;
            __instance._controlDefinition.SlopeHelpMultiplier = Config.SlopeHelpMultiplier.Value;
            __instance._controlDefinition.LookXRange = Config.LookXRange.Value;
            __instance._controlDefinition.LookYRange = Config.LookYRange.Value;
            __instance._controlDefinition.JumpForce = Config.JumpForce.Value;
            __instance._controlDefinition.JumpDelay = Config.JumpDelay.Value;
            __instance._controlDefinition.LeanInputRate = Config.LeanInputRate.Value;
            __instance._controlDefinition.LeanFade = Config.LeanFade.Value;
            __instance._controlDefinition.LeanVelocityReduction = Config.LeanVelocityReduction.Value;
            __instance._controlDefinition.MinMaxLean = Config.MinMaxLean.Value;
            __instance._controlDefinition.LeanVelocityThreshold = Config.LeanVelocityThreshold.Value;
            __instance._controlDefinition.LeanRightLeftBlendSmoothing = Config.LeanRightLeftBlendSmoothing.Value;
            __instance._controlDefinition.LeanRightLeftBlendMinMax = Config.LeanRightLeftBlendMinMax.Value;
            __instance._controlDefinition.LeanForwardBackwardBlendSmoothing = Config.LeanForwardBackwardBlendSmoothing.Value;
            __instance._controlDefinition.LeanForwardBackwardBlendMinMax = Config.LeanForwardBackwardBlendMinMax.Value;
            __instance._controlDefinition.WaterLevelDismountThreshold = Config.WaterLevelDismountThreshold.Value;

        }
    }
}
