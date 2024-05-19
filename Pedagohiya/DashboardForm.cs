using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;
using Microsoft.VisualBasic.FileIO;
using NAudio.Wave;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
namespace Pedagohiya
{
    public partial class DashboardForm : Form
    {
        private WaveOut waveOut;
        private Students StudentPanel;
        public DashboardForm()
        {
            MessageBox.Show("DAPAT HINDI TO MADAANAN");
        }
        public DashboardForm(string username)
        {
            InitializeComponent();
            StudentPanel = new Students(username);
            mainContainer.Controls.Add(StudentPanel);
            lblUsername.Text = "Hello, " + username + "!";
            waveOut = new WaveOut();
            DockFull();

        }
        public void DockFull()
        {
            dashboard1.Dock = DockStyle.Fill;
            SettingsPanel.Dock = DockStyle.Fill;
            StudentPanel.Dock = DockStyle.Fill;
            AttendancePanel.Dock = DockStyle.Fill;
            DashboardPanel.Dock = DockStyle.Fill;
        }

        public void CloseDashboard()
        {
            this.Close(); 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Click();
            SettingsPanel.Visible = true;
            dashboard1.Visible = false;
            StudentPanel.Visible = false;
            //ProfilePanel.Visible = false;
            AttendancePanel.Visible = false;
        }

        private void btnMinimize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Click();
            dashboard1.Visible = true;
            SettingsPanel.Visible = false;
            StudentPanel.Visible = false;
            //ProfilePanel.Visible = false;
            AttendancePanel.Visible = false;
        }

        private void btnClassManagement_Click(object sender, EventArgs e)
        {
            Click();
            dashboard1.Visible = false;
            SettingsPanel.Visible = false;
            StudentPanel.Visible = true;
            AttendancePanel.Visible = false;
            //ProfilePanel.Visible = false;
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            Click();
            AttendancePanel.Visible = true;
            dashboard1.Visible = false;
            SettingsPanel.Visible = false;
            StudentPanel.Visible = false;

        }
        private static readonly Random random = new Random();
        public void Click()
        {
            if (!SoundManager.IsMuted)
            {
                var soundKey = random.Next(0, 2) == 0 ? "1" : "2";
                if (soundKey == "1")
                {
                    LoadClickSound(@"Assets\342200__christopherderp__videogame-menu-button-click.wav");
                    waveOut.Play();
                }
                else
                {
                    LoadClickSound(@"Assets\click3.wav");
                    waveOut.Play();
                }

            }

        }
        private void LoadClickSound(string filePath)
        {
            try
            {
                var audioFileReader = new AudioFileReader(filePath);
                waveOut.Init(audioFileReader);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading click sound: " + ex.Message);
            }
        }
    }
}
