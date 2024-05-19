namespace Pedagohiya
{
    partial class Settings
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label3 = new Label();
            btnLogoutQuit = new Button();
            btnChangeProfile = new Button();
            btnOpenFolder = new Button();
            btnMute = new Button();
            tabPage1 = new TabPage();
            tabPage4 = new TabPage();
            lbl_Volume = new Label();
            trackBar1 = new TrackBar();
            tabPage5 = new TabPage();
            tabPage6 = new TabPage();
            tabControl3 = new TabControl();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            tabPage5.SuspendLayout();
            tabPage6.SuspendLayout();
            tabControl3.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(18, 9);
            label3.Name = "label3";
            label3.Size = new Size(202, 50);
            label3.TabIndex = 7;
            label3.Text = "SETTINGS";
            // 
            // btnLogoutQuit
            // 
            btnLogoutQuit.BackColor = Color.White;
            btnLogoutQuit.BackgroundImageLayout = ImageLayout.None;
            btnLogoutQuit.FlatAppearance.BorderColor = Color.Black;
            btnLogoutQuit.FlatAppearance.BorderSize = 3;
            btnLogoutQuit.FlatStyle = FlatStyle.Flat;
            btnLogoutQuit.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogoutQuit.Image = Properties.Resources.settings;
            btnLogoutQuit.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogoutQuit.Location = new Point(481, 217);
            btnLogoutQuit.Margin = new Padding(10);
            btnLogoutQuit.Name = "btnLogoutQuit";
            btnLogoutQuit.Padding = new Padding(16, 0, 0, 0);
            btnLogoutQuit.Size = new Size(258, 54);
            btnLogoutQuit.TabIndex = 13;
            btnLogoutQuit.Text = "        LOGOUT AND QUIT";
            btnLogoutQuit.TextAlign = ContentAlignment.MiddleLeft;
            btnLogoutQuit.UseVisualStyleBackColor = false;
            btnLogoutQuit.Click += btnLogoutQuit_Click;
            // 
            // btnChangeProfile
            // 
            btnChangeProfile.BackColor = Color.White;
            btnChangeProfile.BackgroundImageLayout = ImageLayout.None;
            btnChangeProfile.FlatAppearance.BorderColor = Color.Black;
            btnChangeProfile.FlatAppearance.BorderSize = 3;
            btnChangeProfile.FlatStyle = FlatStyle.Flat;
            btnChangeProfile.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChangeProfile.Image = Properties.Resources.student;
            btnChangeProfile.ImageAlign = ContentAlignment.MiddleLeft;
            btnChangeProfile.Location = new Point(481, 143);
            btnChangeProfile.Margin = new Padding(10);
            btnChangeProfile.Name = "btnChangeProfile";
            btnChangeProfile.Padding = new Padding(16, 0, 0, 0);
            btnChangeProfile.Size = new Size(258, 54);
            btnChangeProfile.TabIndex = 12;
            btnChangeProfile.Text = "        MANAGE PROFILE";
            btnChangeProfile.TextAlign = ContentAlignment.MiddleLeft;
            btnChangeProfile.UseVisualStyleBackColor = false;
            btnChangeProfile.Click += btnChangeProfile_Click;
            // 
            // btnOpenFolder
            // 
            btnOpenFolder.BackColor = Color.White;
            btnOpenFolder.BackgroundImageLayout = ImageLayout.None;
            btnOpenFolder.FlatAppearance.BorderColor = Color.Black;
            btnOpenFolder.FlatAppearance.BorderSize = 3;
            btnOpenFolder.FlatStyle = FlatStyle.Flat;
            btnOpenFolder.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOpenFolder.Image = Properties.Resources.folder;
            btnOpenFolder.ImageAlign = ContentAlignment.MiddleLeft;
            btnOpenFolder.Location = new Point(481, 143);
            btnOpenFolder.Margin = new Padding(10);
            btnOpenFolder.Name = "btnOpenFolder";
            btnOpenFolder.Padding = new Padding(16, 0, 0, 0);
            btnOpenFolder.Size = new Size(258, 54);
            btnOpenFolder.TabIndex = 19;
            btnOpenFolder.Text = "        OPEN CSV FOLDER";
            btnOpenFolder.TextAlign = ContentAlignment.MiddleLeft;
            btnOpenFolder.UseVisualStyleBackColor = false;
            btnOpenFolder.Click += btnOpenFolder_Click;
            // 
            // btnMute
            // 
            btnMute.BackColor = Color.White;
            btnMute.BackgroundImageLayout = ImageLayout.None;
            btnMute.FlatAppearance.BorderColor = Color.Black;
            btnMute.FlatAppearance.BorderSize = 3;
            btnMute.FlatStyle = FlatStyle.Flat;
            btnMute.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMute.Image = Properties.Resources.nosound;
            btnMute.ImageAlign = ContentAlignment.MiddleLeft;
            btnMute.Location = new Point(480, 142);
            btnMute.Margin = new Padding(10);
            btnMute.Name = "btnMute";
            btnMute.Padding = new Padding(16, 0, 0, 0);
            btnMute.Size = new Size(258, 54);
            btnMute.TabIndex = 18;
            btnMute.Text = "        MUTE SOUND";
            btnMute.TextAlign = ContentAlignment.MiddleLeft;
            btnMute.UseVisualStyleBackColor = false;
            btnMute.Click += btnMute_Click;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Location = new Point(4, 54);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(1199, 626);
            tabPage1.TabIndex = 3;
            tabPage1.Text = "Credits";
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.White;
            tabPage4.Controls.Add(lbl_Volume);
            tabPage4.Controls.Add(trackBar1);
            tabPage4.Controls.Add(btnMute);
            tabPage4.ForeColor = Color.Black;
            tabPage4.Location = new Point(4, 54);
            tabPage4.Margin = new Padding(7);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1199, 626);
            tabPage4.TabIndex = 0;
            tabPage4.Text = "Sound";
            // 
            // lbl_Volume
            // 
            lbl_Volume.AutoSize = true;
            lbl_Volume.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Volume.ForeColor = Color.Black;
            lbl_Volume.Location = new Point(519, 305);
            lbl_Volume.Name = "lbl_Volume";
            lbl_Volume.Size = new Size(113, 32);
            lbl_Volume.TabIndex = 20;
            lbl_Volume.Text = "VOLUME";
            // 
            // trackBar1
            // 
            trackBar1.BackColor = Color.White;
            trackBar1.Location = new Point(334, 365);
            trackBar1.Maximum = 100;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(577, 45);
            trackBar1.TabIndex = 19;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // tabPage5
            // 
            tabPage5.BackColor = Color.White;
            tabPage5.Controls.Add(btnOpenFolder);
            tabPage5.Location = new Point(4, 54);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(1199, 626);
            tabPage5.TabIndex = 1;
            tabPage5.Text = "CSV File Directory";
            // 
            // tabPage6
            // 
            tabPage6.BackColor = Color.White;
            tabPage6.Controls.Add(btnChangeProfile);
            tabPage6.Controls.Add(btnLogoutQuit);
            tabPage6.Location = new Point(4, 54);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(1199, 626);
            tabPage6.TabIndex = 2;
            tabPage6.Text = "Profile";
            // 
            // tabControl3
            // 
            tabControl3.Appearance = TabAppearance.FlatButtons;
            tabControl3.Controls.Add(tabPage6);
            tabControl3.Controls.Add(tabPage5);
            tabControl3.Controls.Add(tabPage4);
            tabControl3.Controls.Add(tabPage1);
            tabControl3.Cursor = Cursors.Hand;
            tabControl3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControl3.ItemSize = new Size(260, 50);
            tabControl3.Location = new Point(25, 60);
            tabControl3.Multiline = true;
            tabControl3.Name = "tabControl3";
            tabControl3.Padding = new Point(5, 5);
            tabControl3.RightToLeft = RightToLeft.No;
            tabControl3.RightToLeftLayout = true;
            tabControl3.SelectedIndex = 0;
            tabControl3.Size = new Size(1207, 684);
            tabControl3.SizeMode = TabSizeMode.Fixed;
            tabControl3.TabIndex = 21;
            tabControl3.Click += Profile_Click;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tabControl3);
            Controls.Add(label3);
            Name = "Settings";
            Size = new Size(1279, 839);
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            tabPage5.ResumeLayout(false);
            tabPage6.ResumeLayout(false);
            tabControl3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button btnLogoutQuit;
        private Button btnChangeProfile;
        private Button btnMute;
        private Button btnOpenFolder;
        private TabPage tabPage1;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TabControl tabControl3;
        private TrackBar trackBar1;
        private Label lbl_Volume;
    }
}
