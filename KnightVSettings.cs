using SonsSdk;
using SUI;

namespace KnightVSettings;

public class KnightVSettings : SonsMod
{
    public KnightVSettings()
    {
        HarmonyPatchAll = true;
    }

    protected override void OnInitializeMod()
    {
        Config.Init();
    }

    protected override void OnSdkInitialized()
    {
        SettingsRegistry.CreateSettings(this, null, typeof(Config));
    }
}