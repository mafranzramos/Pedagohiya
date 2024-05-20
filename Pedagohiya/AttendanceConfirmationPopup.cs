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
    public partial class AttendanceConfirmationPopup : Form
    {
        public AttendanceConfirmationPopup()
        {
            InitializeComponent();
        }

        private void AttendanceConfirmationPopup_Load(object sender, EventArgs e)
        {

        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
