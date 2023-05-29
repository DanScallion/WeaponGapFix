using HarmonyLib;
using TaleWorlds.Core;

namespace WeaponGapFix
{
    [HarmonyPatch(typeof(Crafting), "ScaleThePiece")]
    internal class Scale
    {
        public static bool Prefix(CraftingPiece.PieceTypes scalingPieceType, ref int
            percentage)
        {
            
        percentage = (percentage - 90) * (300 / 20);
           
            //MBInformationManager.AddQuickInformation(new TaleWorlds.Localization.TextObject(percentage.ToString()));
            return true;
        }
    }
}