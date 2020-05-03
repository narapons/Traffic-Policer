using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rage;
using Rage.Native;
using Traffic_Policer.Impairment_Tests;

namespace Traffic_Policer.Extensions
{
    
    internal static class ExtensionMethods
    {
        public static string ToColouredString(this DrugsLevels e)
        {
            switch (e)
            {
                case DrugsLevels.NEGATIVE:
                    return "~g~陰性";
                case DrugsLevels.POSITIVE:
                    return "~r~陽性";
            }
            return "検出不能";
        }
        public static string ToColouredString(this EVehicleDetailsStatus e)
        {
            switch (e)
            {
                case EVehicleDetailsStatus.Valid:
                    return "~g~有効";
                case EVehicleDetailsStatus.Expired:
                    return "~o~期限切れ";
                case EVehicleDetailsStatus.None:
                    return "~r~なし";
            }
            return "UNDETECTABLE";
        }
        

        
    }
}
