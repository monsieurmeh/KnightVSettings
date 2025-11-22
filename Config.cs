using RedLoader;
using SUI;

namespace KnightVSettings;

public static class Config
{
    public static ConfigCategory Category { get; private set; }
    public static ConfigEntry<bool> DebugOutput { get; private set; }
    public static ConfigEntry<float> MaxVelocity { get; private set; }
    public static ConfigEntry<float> MaxPowerUsage { get; private set; }
    public static ConfigEntry<float> WipeoutMinVelocity { get; private set; }
    public static ConfigEntry<float> AccelerationInputRate { get; private set; }
    public static ConfigEntry<float> MaxForwardAcceleration { get; private set; }
    public static ConfigEntry<float> MaxReverseAcceleration { get; private set; }
    public static ConfigEntry<float> SlopeHelpMultiplier { get; private set; }
    public static ConfigEntry<float> LookXRange { get; private set; }
    public static ConfigEntry<float> LookYRange { get; private set; }
    public static ConfigEntry<float> JumpForce { get; private set; }
    public static ConfigEntry<float> JumpDelay { get; private set; }
    public static ConfigEntry<float> LeanInputRate { get; private set; }
    public static ConfigEntry<float> LeanFade { get; private set; }
    public static ConfigEntry<float> LeanVelocityReduction { get; private set; }
    public static ConfigEntry<float> MinMaxLean { get; private set; }
    public static ConfigEntry<float> LeanVelocityThreshold { get; private set; }
    public static ConfigEntry<float> LeanRightLeftBlendSmoothing { get; private set; }
    public static ConfigEntry<float> LeanRightLeftBlendMinMax { get; private set; }
    public static ConfigEntry<float> LeanForwardBackwardBlendSmoothing { get; private set; }
    public static ConfigEntry<float> LeanForwardBackwardBlendMinMax { get; private set; }
    public static ConfigEntry<float> WaterLevelDismountThreshold { get; private set; }


    private static SettingsRegistry.SettingsEntry _settingsEntry;

    public static void Init()
    {
        Category = ConfigSystem.CreateFileCategory("KnightVSettings", "Knight V Settings", "KnightVSettings.cfg");
        InstantiateConfigs();
        SetConfigRanges();
    }

    private static void InstantiateConfigs()
    {
        MaxVelocity = Category.CreateEntry("MaxVelocity", 20f, "Max Speed", "Sets maximum speed.");
        MaxPowerUsage = Category.CreateEntry("MaxPowerUsage", 0f, "Power Usage", "Sets power usage over time");
        WipeoutMinVelocity = Category.CreateEntry("WipeoutMinVelocity", 1000f, "Wipeout Speed", "Sets minimum speed before wipeout occurs.");
        AccelerationInputRate = Category.CreateEntry("AccelerationInputRate", 500f, "Rate of Acceleration", "Rate acceleration rises/falls when input changes.");
        MaxForwardAcceleration = Category.CreateEntry("MaxForwardAcceleration", 15f, "Max Forward Acceleration", "Sets maximum forward acceleration.");
        MaxReverseAcceleration = Category.CreateEntry("MaxReverseAcceleration", 15f, "Max Reverse Acceleration", "Sets maximum backward acceleration.");
        SlopeHelpMultiplier = Category.CreateEntry("SlopeHelpMultiplier", 1f, "Slope Assistance", "Multiplier affecting slope movement assistance.");
        LookXRange = Category.CreateEntry("LookXRange", 135f, "Horizontal Look Range", "Maximum allowed horizontal look angle.");
        LookYRange = Category.CreateEntry("LookYRange", 120f, "Vertical Look Range", "Maximum allowed vertical look angle.");
        JumpForce = Category.CreateEntry("JumpForce", 8f, "Jump Force", "Force applied when jumping.");
        JumpDelay = Category.CreateEntry("JumpDelay", 0.25f, "Jump Delay", "Delay before jump triggers.");
        LeanInputRate = Category.CreateEntry("LeanInputRate", 7f, "Lean Input Rate", "Rate at which leaning input is applied.");
        LeanFade = Category.CreateEntry("LeanFade", 4.5f, "Lean Fade", "How quickly lean input fades when input stops.");
        LeanVelocityReduction = Category.CreateEntry("LeanVelocityReduction", 0.5f, "Lean Velocity Reduction", "Amount of velocity reduced when leaning.");
        MinMaxLean = Category.CreateEntry("MinMaxLean", 8f, "Lean Range", "Minimum and maximum allowed lean values.");
        LeanVelocityThreshold = Category.CreateEntry("LeanVelocityThreshold", 18f, "Lean Velocity Threshold", "Velocity threshold that affects leaning behavior.");
        LeanRightLeftBlendSmoothing = Category.CreateEntry("LeanRightLeftBlendSmoothing", 2f, "Side Lean Smoothing", "Smoothing factor for left/right lean animation blending.");
        LeanRightLeftBlendMinMax = Category.CreateEntry("LeanRightLeftBlendMinMax", 0.6f, "Side Lean Range", "Min/max values used for right/left lean blending.");
        LeanForwardBackwardBlendSmoothing = Category.CreateEntry("LeanForwardBackwardBlendSmoothing", 2f, "Forward Lean Smoothing", "Smoothing factor for forward/backward lean animation blending.");
        LeanForwardBackwardBlendMinMax = Category.CreateEntry("LeanForwardBackwardBlendMinMax", 0.6f, "Forward Lean Range", "Min/max values used for forward/backward lean blending.");
        WaterLevelDismountThreshold = Category.CreateEntry("WaterLevelDismountThreshold", 10f, "Water Dismount Level", "Depth of water at which dismount occurs.");
        DebugOutput = Category.CreateEntry("DebugOutput", false, "Debug Output", "Logs debug output to console");
    }

    private static void SetConfigRanges()
    {
        MaxVelocity.SetRange(1f, 1000f);
        MaxPowerUsage.SetRange(0f, 100f);
        WipeoutMinVelocity.SetRange(0f, 1000f);
        AccelerationInputRate.SetRange(250f, 2500f);
        MaxForwardAcceleration.SetRange(0f, 200f);
        MaxReverseAcceleration.SetRange(0f, 200f);
        SlopeHelpMultiplier.SetRange(-5f, 5f);
        LookXRange.SetRange(30f, 360f);
        LookYRange.SetRange(30f, 180f);
        JumpForce.SetRange(0f, 500f);
        JumpDelay.SetRange(0f, 2f);
        LeanInputRate.SetRange(0f, 20f);
        LeanFade.SetRange(0f, 20f);
        LeanVelocityReduction.SetRange(0f, 5f);
        MinMaxLean.SetRange(0f, 45f);
        LeanVelocityThreshold.SetRange(0f, 100f);
        LeanRightLeftBlendSmoothing.SetRange(0f, 10f);
        LeanRightLeftBlendMinMax.SetRange(0f, 5f);
        LeanForwardBackwardBlendSmoothing.SetRange(0f, 10f);
        LeanForwardBackwardBlendMinMax.SetRange(0f, 5f);
        WaterLevelDismountThreshold.SetRange(0f, 50f);
    }

    public static void OnSettingsUiClosed()
    {
    }
}