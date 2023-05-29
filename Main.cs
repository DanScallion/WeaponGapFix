using HarmonyLib;
using TaleWorlds.MountAndBlade;

namespace WeaponGapFix
{
    public class Main : MBSubModuleBase
    {
        protected override void OnSubModuleLoad()
        {
            base.OnSubModuleLoad();
            this.harmonyGapFix = new Harmony("WeaponGapFix");
            this.harmonyGapFix.PatchAll();
        }

        private Harmony harmonyGapFix;
    }
}