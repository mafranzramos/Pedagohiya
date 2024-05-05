using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using NAudio.Wave;
using Microsoft.VisualBasic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
namespace Pedagohiya
{
    public partial class LoginForm : Form
    {
        // TESTING GIT AGAIN // TRY GIT TO VS
        private WaveOut waveOut;
        private string basePath = @"D:\Users\22viv\source\repos\Pedagohiya\Pedagohiya\CSV Files";

        public LoginForm()
        {
            InitializeComponent();
            PopulateExistingProfiles();
            waveOut = new WaveOut();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            titlePanel.Visible = true;
        }

        private void ExistingProfilebtn_Click(object sender, EventArgs e)
        {
            LoadClickSound(1);
            panelCreateProfile.Visible = false;
            panelExistingProfile.Visible = true;
            titlePanel.Visible = false;
            lblChooseYourProfile.Visible = true;
            lblDeleteProfile.Visible = false;
        }

        private void btnCreateProfile_Click(object sender, EventArgs e)
        {
            LoadClickSound(2);
            panelCreateProfile.Visible = true;
            panelExistingProfile.Visible = false;
            titlePanel.Visible = false;
            lblChooseYourProfile.Visible = false;
            lblDeleteProfile.Visible = false;
        }

        private void btnDeleteProfile_Click(object sender, EventArgs e)
        {
            LoadClickSound(1);
            panelCreateProfile.Visible = false;
            panelExistingProfile.Visible = true;
            titlePanel.Visible = false;
            lblChooseYourProfile.Visible = false;
            lblDeleteProfile.Visible = true;
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashedBytes.Length; i++)
                {
                    builder.Append(hashedBytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void SaveCredentialsToCSV(string username, string hashedPassword)
        {
            string csvPath = Path.Combine(basePath, "Accounts.csv");
            if (!File.Exists(csvPath))
            {
                File.Create(csvPath).Dispose();
            }

            using (var writer = new StreamWriter(csvPath, true))
            {
                writer.WriteLine($"{username},{hashedPassword}");
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            LoadClickSound(3);
            var username = UsernameTextBox.Text;
            var password = PasswordTextBox.Text;

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter a username.");
                return;
            }
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter a password.");
                return;
            }

            var userProfileFolder = Path.Combine(basePath, username);

            if (Directory.Exists(userProfileFolder))
            {
                MessageBox.Show("Username already exists. Please choose a different username.");
                UsernameTextBox.Clear();
                return;
            }

            try
            {
                var hashedPassword = HashPassword(password);
                SaveCredentialsToCSV(username, hashedPassword);
                UserProfileManager.SaveProfile(username);
                Directory.CreateDirectory(userProfileFolder);
                MessageBox.Show($"Profile created successfully for user: {username}");
                var dashboardForm = new DashboardForm(username);
                dashboardForm.FormClosing += DashboardForm_FormClosing;
                dashboardForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating profile: {ex.Message}");
            }
        }

        private void PopulateExistingProfiles()
        {
            panelExistingProfile.Controls.Clear();
            var usernames = GetProfileUsernames();

            int buttonYPosition = 50;

            foreach (var username in usernames)
            {
                var button = new Button();
                button.Text = username;
                button.Location = new Point(70, buttonYPosition);
                button.BackColor = Color.White;
                button.BackgroundImageLayout = ImageLayout.None;
                button.Cursor = Cursors.Hand;
                button.FlatAppearance.BorderColor = Color.Black;
                button.FlatAppearance.BorderSize = 2;
                button.FlatStyle = FlatStyle.Flat;
                button.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
                button.Size = new Size(180, 44);
                button.ForeColor = Color.Black;
                button.TabIndex = 0;
                button.Click += new EventHandler(UserProfileButton_Click);
                panelExistingProfile.Controls.Add(button);
                buttonYPosition += 40;
            }
        }

        private List<string> GetProfileUsernames()
        {
            var usernames = new List<string>();
            foreach (var folder in Directory.EnumerateDirectories(basePath))
            {
                usernames.Add(Path.GetFileName(folder)); // Get username from folder name
            }
            return usernames;
        }

        private void UserProfileButton_Click(object sender, EventArgs e)
        {
            var username = ((Button)sender).Text;

            if (lblDeleteProfile.Visible)
            {
                DeleteProfile(username);
            }
            else
            {
                NavigateToDashboard(username);
            }
        }

        private void NavigateToDashboard(string username)
        {
            string enteredPassword = PromptPassword();
            string hashedEnteredPassword = HashPassword(enteredPassword);
            string storedHashedPassword = GetHashedPasswordFromCSV(username);

            if (hashedEnteredPassword != storedHashedPassword)
            {
                MessageBox.Show("Incorrect password. Navigation aborted.");
                return;
            }

            var dashboardForm = new DashboardForm(username);
            UserProfileManager.SaveProfile(username);
            dashboardForm.Show();
            this.Hide();
        }


        private void DeleteProfile(string username)
        {
            var userProfileFolder = Path.Combine(basePath, username);

            if (Directory.Exists(userProfileFolder))
            {
                string enteredPassword = PromptPassword();

                string hashedEnteredPassword = HashPassword(enteredPassword);

                string storedHashedPassword = GetHashedPasswordFromCSV(username);

                if (hashedEnteredPassword != storedHashedPassword)
                {
                    MessageBox.Show("Incorrect password. Profile deletion aborted.");
                    return;
                }

                var result = MessageBox.Show($"Are you sure you want to delete profile '{username}'?",
                                              "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        Directory.Delete(userProfileFolder, true);
                        MessageBox.Show($"Profile '{username}' deleted successfully.");
                        PopulateExistingProfiles(); // Refresh the profile buttons after deletion
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting profile '{username}': {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show($"Profile '{username}' does not exist.");
            }
        }

        private string PromptPassword()
        {
            string enteredPassword = Microsoft.VisualBasic.Interaction.InputBox("Enter your password", "Password Confirmation", "", -1, -1);
            return enteredPassword;
        }

        private string GetHashedPasswordFromCSV(string username)
        {
            string csvPath = Path.Combine(basePath, "Accounts.csv");
            if (!File.Exists(csvPath))
            {
                throw new FileNotFoundException("Accounts.csv file not found.");
            }

            string[] lines = File.ReadAllLines(csvPath);
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length == 2 && parts[0] == username)
                {
                    return parts[1]; // Return the hashed password
                }
            }

            throw new Exception($"Username '{username}' not found in the Accounts.csv file.");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private static void DashboardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private string filePath;
        private void LoadClickSound(int x)
        {
            switch (x)
            {
                case 1:
                    filePath = @"D:\Users\22viv\source\repos\Pedagohiya\Pedagohiya\Assets\click3.wav";
                    break;
                case 2:
                    filePath = @"D:\Users\22viv\source\repos\Pedagohiya\Pedagohiya\Assets\342200__christopherderp__videogame-menu-button-click.wav";
                    break;
                case 3:
                    filePath = @"D:\Users\22viv\source\repos\Pedagohiya\Pedagohiya\Assets\click4.mp3";
                    break;
                default:
                    filePath = @"D:\Users\22viv\source\repos\Pedagohiya\Pedagohiya\Assets\click3.wav";
                    break;
            }
            try
            {
                var audioFileReader = new AudioFileReader(filePath);
                waveOut.Init(audioFileReader);
                waveOut.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading click sound: " + ex.Message);
            }
        }
    }
}
