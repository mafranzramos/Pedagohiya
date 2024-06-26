﻿using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Pedagohiya
{
    public partial class Settings : UserControl
    {
        private WaveOut waveOut;
        private DashboardForm _dashboardForm;

        public Settings()
        {
            InitializeComponent();
            waveOut = new WaveOut();
            trackBar1.Value = 70;
            float volumeLevel = (float)trackBar1.Value / trackBar1.Maximum;
            lbl_Volume.Text = $"Volume: {Math.Round(volumeLevel * 100f)}%"; // Format as percentage
            SoundManager.VolumeLevel = volumeLevel;
        }

        public DashboardForm DashboardForm
        {
            get => _dashboardForm;
            set => _dashboardForm = value;
        }
 
        private void btnChangeProfile_Click(object sender, EventArgs e)
        {
            UserProfileManager.ClearSavedProfile();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.ParentForm.Hide();
            Click1();
        }

        private void btnLogoutQuit_Click(object sender, EventArgs e)
        {
            UserProfileManager.ClearSavedProfile();
            Application.Exit();
            Click1();
        }

        private void btnMute_Click(object sender, EventArgs e)
        {
            SoundManager.ToggleMute();
            UpdateMuteButtonText();
        }

        private void UpdateMuteButtonText()
        {
            if (SoundManager.IsMuted)
            {
                btnMute.Text = "        UNMUTE SOUND";
                btnMute.Image = Image.FromFile(@"Assets\sound.png");
            }
            else
            {
                btnMute.Text = "        MUTE SOUND";
                btnMute.Image = Image.FromFile(@"Assets\nosound.png");
            }
        }

        private void Profile_Click(object sender, EventArgs e)
        {
            Click1();
        }

        public void Click1()
        {
            if (!SoundManager.IsMuted)
            {
                LoadClickSound(@"Assets\342200__christopherderp__videogame-menu-button-click.wav");
                waveOut.Play();
            }
        }

        public void Click2()
        {
            if (!SoundManager.IsMuted)
            {
                LoadClickSound(@"Assets\click3.wav");
                waveOut.Play();
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

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            string basePath = @"CSV Files\";

            try
            {
                Process.Start("explorer.exe", basePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening folder: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            float volumeLevel = (float)trackBar1.Value / trackBar1.Maximum;
            lbl_Volume.Text = $"Volume: {Math.Round(volumeLevel * 100f)}%";
            SoundManager.VolumeLevel = volumeLevel;
        }

        private void linkLabelIcons8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenUrl("https://icons8.com");
        }

        private void linkLabelFreeSound_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenUrl("https://freesound.org/");
        }

        private void OpenUrl(string url)
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true // This will use the default web browser
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred trying to open the URL: " + ex.Message);
            }
        }



        private void Color_Change(object sender, EventArgs e)
        {
            if (DashboardForm != null)
            {
                if (sender is Button button)
                {
                    
                    Color buttonBackColor = button.BackColor;
                    panel2.BackColor = buttonBackColor;
                    DashboardForm.FlowLayoutPanelBackColor = buttonBackColor;
                    if (DashboardForm.StudentPanel!= null)
                    {
                        DashboardForm.StudentPanel.PanelBackColor = buttonBackColor;
                    }
                }
            }
        }
    }

}
