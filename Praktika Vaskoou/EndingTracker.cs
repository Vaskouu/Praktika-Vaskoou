using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika_Vaskoou
{
    internal static class EndingTracker
    {
        public static bool[] Endings = new bool[7];
        //public static List<bool> Endings = new List<bool>();

















        private static bool[] endingsUnlocked = new bool[6];
        public static void UnlockEnding(int endingNumber)
        {
            if (endingNumber >= 0 && endingNumber < 6)
            {
                endingsUnlocked[endingNumber] = true;
                SaveToSettings(endingsUnlocked);
            }
        }
        public static int GetUnlockedCount()
        {
            return endingsUnlocked.Count(e => e);
        }
        public static string GetDisplayText()
        {
            return $"Endings Unlocked: {GetUnlockedCount()}/6";
        }
        private static void SaveToSettings(bool[] endingsUnlocked)
        {
            for (int i = 1; i < 7; i++)
            {
                Properties.Settings.Default[$"Ending_{i}"] = endingsUnlocked[i];
            }
            Properties.Settings.Default.Save();
        }          
    }
}
