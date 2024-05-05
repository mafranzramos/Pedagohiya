using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Pedagohiya
{
    public partial class Settings : UserControl
    {
        public Settings()
        {
            InitializeComponent();
        }
        private void btnChangeProfile_Click(object sender, EventArgs e)
        {
            UserProfileManager.ClearSavedProfile();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
             this.ParentForm.Hide();
        }

        private void btnLogoutQuit_Click(object sender, EventArgs e)
        {
            UserProfileManager.ClearSavedProfile();
            Application.Exit();
        }
    }
}


