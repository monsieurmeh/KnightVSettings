using HarmonyLib;
using Sons.Gameplay;
using System;
using static RedLoader.RLog;

namespace KnightVSettings
{
    [HarmonyPatch(typeof(PlayerKnightVAction), "StartRiding")]
    internal static class KnightVPatch
    {
        private static void Postfix(ref PlayerKnightVAction __instance)
        {
            if (Config.DebugOutput.Value) ReportValues(ref __instance);
            SetValues(ref __instance);
            if (Config.DebugOutput.Value) ReportValues(ref __instance);

        }

        private static void ReportValues(ref PlayerKnightVAction __instance)
        {
            Console.WriteLine($"MaxVelocity: {__instance._controlDefinition.MaxVelocity}");
            Console.WriteLine($"MaxPowerUsage: {__instance._controlDefinition.MaxPowerUsage}");
            Console.WriteLine($"WipeoutMinVelocity: {__instance._controlDefinition.WipeoutMinVelocity}");
            Console.WriteLine($"AccelerationInputRate: {__instance._controlDefinition.AccelerationInputRate}");
            Console.WriteLine($"MaxForwardAcceleration: {__instance._controlDefinition.MaxForwardAcceleration}");
            Console.WriteLine($"MaxReverseAcceleration: {__instance._controlDefinition.MaxReverseAcceleration}");
            Console.WriteLine($"SlopeHelpMultiplier: {__instance._controlDefinition.SlopeHelpMultiplier}");
            Console.WriteLine($"LookXRange: {__instance._controlDefinition.LookXRange}");
            Console.WriteLine($"LookYRange: {__instance._controlDefinition.LookYRange}");
            Console.WriteLine($"JumpForce: {__instance._controlDefinition.JumpForce}");
            Console.WriteLine($"JumpDelay: {__instance._controlDefinition.JumpDelay}");
            Console.WriteLine($"LeanInputRate: {__instance._controlDefinition.LeanInputRate}");
            Console.WriteLine($"LeanFade: {__instance._controlDefinition.LeanFade}");
            Console.WriteLine($"LeanVelocityReduction: {__instance._controlDefinition.LeanVelocityReduction}");
            Console.WriteLine($"MinMaxLean: {__instance._controlDefinition.MinMaxLean}");
            Console.WriteLine($"LeanVelocityThreshold: {__instance._controlDefinition.LeanVelocityThreshold}");
            Console.WriteLine($"LeanRightLeftBlendSmoothing: {__instance._controlDefinition.LeanRightLeftBlendSmoothing}");
            Console.WriteLine($"LeanRightLeftBlendMinMax: {__instance._controlDefinition.LeanRightLeftBlendMinMax}");
            Console.WriteLine($"LeanForwardBackwardBlendSmoothing: {__instance._controlDefinition.LeanForwardBackwardBlendSmoothing}");
            Console.WriteLine($"LeanForwardBackwardBlendMinMax: {__instance._controlDefinition.LeanForwardBackwardBlendMinMax}");
            Console.WriteLine($"WaterLevelDismountThreshold: {__instance._controlDefinition.WaterLevelDismountThreshold}");
        }
        private static void SetValues(ref PlayerKnightVAction __instance)
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
            __instance._controlDefinition.WaterLevelDismountThreshold = Config.WaterLevelDismountThreshold.Value;
        }
    }
}
