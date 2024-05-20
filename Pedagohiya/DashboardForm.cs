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
using System.DirectoryServices.ActiveDirectory;
namespace Pedagohiya
{
    public partial class DashboardForm : Form
    {
        private WaveOut waveOut;

        public Students StudentPanel { get; set; }

        public DashboardForm()
        {
            MessageBox.Show("DAPAT HINDI TO MADAANAN");
        }
        public DashboardForm(string username)
        {
            InitializeComponent();
            StudentPanel = new Students(username);
            AttendancePanel = new Attendance(username);
            mainContainer.Controls.Add(StudentPanel);
            mainContainer.Controls.Add(AttendancePanel);
            lblUsername.Text = "Hello, " + username + "!";
            waveOut = new WaveOut();
            DockFull();
            InitializeSettingsControl();
        }
        private void InitializeSettingsControl()
        {
            // Assuming SettingsPanel is a Panel control that contains the Settings UserControl
            var settingsControl = mainContainer.Controls.OfType<Settings>().FirstOrDefault();
            if (settingsControl != null)
            {
                settingsControl.DashboardForm = this;
            }
            else
            {
                MessageBox.Show("Settings control not found");
            }
        }

        public Color FlowLayoutPanelBackColor
        {
            get => flowLayoutPanel1.BackColor;
            set
            {
                flowLayoutPanel1.BackColor = value;
                panel5.BackColor = value;
            }
        }
        public void DockFull()
        {
            dashboard1.Dock = DockStyle.Fill;
            SettingsPanel.Dock = DockStyle.Fill;
            StudentPanel.Dock = DockStyle.Fill;
            //ProfilePanel.Dock = DockStyle.Fill;
            AttendancePanel.Dock = DockStyle.Fill;
            DashboardPanel.Dock = DockStyle.Fill;
            taskPanel.Dock = DockStyle.Fill;    
        }

        public void CloseDashboard()
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTask_click(object sender, EventArgs e)
        {
            Click();
            dashboard1.Visible = false;
            SettingsPanel.Visible = false;
            StudentPanel.Visible = false;
            //ProfilePanel.Visible = false;
            taskPanel.Visible = true;
        }


        private void btnSettings_Click(object sender, EventArgs e)
        {
            Click();
            SettingsPanel.Visible = true;
            dashboard1.Visible = false;
            StudentPanel.Visible = false;
            //ProfilePanel.Visible = false;
            taskPanel.Visible = false;
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
            taskPanel.Visible = false;
        }

        private void btnClassManagement_Click(object sender, EventArgs e)
        {
            Click();
            dashboard1.Visible = false;
            SettingsPanel.Visible = false;
            StudentPanel.Visible = true;
            //ProfilePanel.Visible = false;
            taskPanel.Visible = false;
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            Click();
            AttendancePanel.Visible = true;
            taskPanel.Visible = false;
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
        private bool isDuckVisible = false;

        private void lblUsername_Click(object sender, EventArgs e)
        {
            isDuckVisible = !isDuckVisible;
            duck_Pic.Visible = isDuckVisible;
        }
        private bool is8ballVisible = false;
        private void label1_Click(object sender, EventArgs e)
        {
            MagicLabel.Text = "Hmm..";
            is8ballVisible = !is8ballVisible;
            magic8ball.Visible = is8ballVisible;
        }

        private void duck_Pic_Click(object sender, EventArgs e)
        {
            var soundKey = random.Next(0, 3);
            switch (soundKey)
            {
                case 0:
                    LoadClickSound(@"Assets\333916__lextrack__cat-meowing.mp3");
                    waveOut.Play();
                    break;
                case 1:
                    LoadClickSound(@"Assets\24730__propthis__squeak2.wav");
                    waveOut.Play();
                    break;
                case 2:
                    LoadClickSound(@"Assets\372529__glitchedtones__dog-shih-tzu-bark-x3-01.wav");
                    waveOut.Play();
                    break;
            }

        }
        private void magic_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            string[] answers = {
            "It is certain.",
            "Ask again later.",
            "No",
            "Most likely.",
            "Outlook good.",
            "Signs point to yes.",
            "Don't count on it.",
            "Very doubtful.",
            "Ask your mom",
            "Why not",
            "Yes? Yes!",
            "Nah",
            "Duh",
            "NOOOOOOO ! ! !",
            "YESSSSSSS ! ! !"
        };

            int randomIndex = random.Next(answers.Length);
            MagicLabel.Text = answers[randomIndex];
        }

    }
}
