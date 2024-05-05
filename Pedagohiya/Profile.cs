using System.Drawing.Text;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.ApplicationServices;
using System.IO;
using Pedagohiya;
using NAudio.Wave;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
namespace Pedagohiya
{
    public partial class Profile : UserControl
    {
        private WaveOut waveOut;
        private string _userProfilesFolder = @"CSV Files";
        public Profile()
        {
            InitializeComponent();
            PopulateExistingProfiles();
            waveOut = new WaveOut();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            titlePanel.Visible = true;
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

        private void ExistingProfilebtn_Click(object sender, EventArgs e)
        {
            LoadClickSound(@"Assets\click3.wav"); // Load the sound before playing
            waveOut.Play();
            panelCreateProfile.Visible = false;
            panelExistingProfile.Visible = true;
            titlePanel.Visible = false;
            lblChooseYourProfile.Visible = true;

        }

        private void btnCreateProfile_Click(object sender, EventArgs e)
        {
            LoadClickSound(@"Assets\342200__christopherderp__videogame-menu-button-click.wav"); // Load the sound before playing
            waveOut.Play();
            panelCreateProfile.Visible = true;
            panelExistingProfile.Visible = false;
            titlePanel.Visible = false;
            lblChooseYourProfile.Visible = false;
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            LoadClickSound(@"Assets\click4.mp3"); // Load the sound before playing
            waveOut.Play();
            var username = UsernameTextBox.Text;

            // Validate username (optional)
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter a username.");
                return;
            }

            // Create user profile folder path
            var userProfileFolder = Path.Combine(@"CSV Files\", username);

            UserProfileManager.SaveProfile(username);

            // Check if folder already exists
            if (Directory.Exists(userProfileFolder))
            {
                MessageBox.Show("Username already exists. Please choose a different username.");
                UsernameTextBox.Clear(); // Clear username for another attempt
                return;
            }

            // Create user profile folder
            try
            {
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
            panelExistingProfile.Controls.Clear(); // Clear any existing buttons
            var usernames = GetProfileUsernames();

            int buttonYPosition = 50; // Adjust starting position for buttons

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
            foreach (var folder in Directory.EnumerateDirectories(_userProfilesFolder))
            {
                usernames.Add(Path.GetFileName(folder)); // Get username from folder name
            }
            return usernames;
        }

        private void UserProfileButton_Click(object sender, EventArgs e)
        {
            var username = ((Button)sender).Text;
            var dashboardForm = new DashboardForm(username); // Pass username to DashboardForm
            UserProfileManager.SaveProfile(username);
            dashboardForm.Show();
            this.Hide(); // Hide the login form (optional)
        }


        private static void DashboardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing) // Check if user clicked "X" button
            {
                Application.Exit(); // Exit the entire application
            }
        }
    }
}
