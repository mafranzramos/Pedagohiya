using System;

namespace Pedagohiya
{   using Pedagohiya;
    using System.Threading;

    internal static class Program
    {
        static void Main(string[] args)
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string savedProfile = UserProfileManager.GetSavedProfile();

            if (string.IsNullOrEmpty(savedProfile))
            {
                Application.Run(new LoginForm());
            }
            else
            {
                Application.Run(new DashboardForm(savedProfile));
            }
        }
        private static void DashboardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing) 
            {
                Application.Exit();
            }
        }
    }
}