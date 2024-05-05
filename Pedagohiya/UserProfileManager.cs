using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedagohiya
{
    internal class UserProfileManager
    {
        public static string GetSavedProfile()
        {
            // Read saved username from application settings
            return Properties.Settings.Default.SavedUsername;
        }

        public static void SaveProfile(string username)
        {
            // Save username to application settings
            Properties.Settings.Default.SavedUsername = username;
            Properties.Settings.Default.Save();
        }

        public static void ClearSavedProfile()
        {
            // Clear saved username from application settings
            Properties.Settings.Default.SavedUsername = "";
            Properties.Settings.Default.Save();
        }
    }
}
