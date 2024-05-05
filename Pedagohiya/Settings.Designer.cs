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
            tabControl3 = new TabControl();
            tabPage6 = new TabPage();
            btnLogoutQuit = new Button();
            btnChangeProfile = new Button();
            tabPage5 = new TabPage();
            tabPage4 = new TabPage();
            btnDeleteTextTextBox = new Button();
            tabPage1 = new TabPage();
            tabControl3.SuspendLayout();
            tabPage6.SuspendLayout();
            tabPage4.SuspendLayout();
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
            tabControl3.Size = new Size(1229, 718);
            tabControl3.SizeMode = TabSizeMode.Fixed;
            tabControl3.TabIndex = 21;
            // 
            // tabPage6
            // 
            tabPage6.BackColor = Color.White;
            tabPage6.Controls.Add(btnLogoutQuit);
            tabPage6.Controls.Add(btnChangeProfile);
            tabPage6.Location = new Point(4, 54);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(1221, 660);
            tabPage6.TabIndex = 2;
            tabPage6.Text = "Profile";
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
            btnLogoutQuit.Location = new Point(497, 309);
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
            btnChangeProfile.Image = Properties.Resources.settings;
            btnChangeProfile.ImageAlign = ContentAlignment.MiddleLeft;
            btnChangeProfile.Location = new Point(497, 235);
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
            // tabPage5
            // 
            tabPage5.BackColor = Color.White;
            tabPage5.Location = new Point(4, 54);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(1221, 660);
            tabPage5.TabIndex = 1;
            tabPage5.Text = "CSV File Directory";
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.White;
            tabPage4.Controls.Add(btnDeleteTextTextBox);
            tabPage4.ForeColor = Color.Black;
            tabPage4.Location = new Point(4, 54);
            tabPage4.Margin = new Padding(7);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1221, 660);
            tabPage4.TabIndex = 0;
            tabPage4.Text = "Sound";
            // 
            // btnDeleteTextTextBox
            // 
            btnDeleteTextTextBox.BackColor = Color.White;
            btnDeleteTextTextBox.BackgroundImageLayout = ImageLayout.None;
            btnDeleteTextTextBox.FlatAppearance.BorderColor = Color.Black;
            btnDeleteTextTextBox.FlatAppearance.BorderSize = 3;
            btnDeleteTextTextBox.FlatStyle = FlatStyle.Flat;
            btnDeleteTextTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteTextTextBox.Image = Properties.Resources.upHere6;
            btnDeleteTextTextBox.ImageAlign = ContentAlignment.MiddleLeft;
            btnDeleteTextTextBox.Location = new Point(18, 576);
            btnDeleteTextTextBox.Margin = new Padding(10);
            btnDeleteTextTextBox.Name = "btnDeleteTextTextBox";
            btnDeleteTextTextBox.Padding = new Padding(16, 0, 0, 0);
            btnDeleteTextTextBox.Size = new Size(233, 54);
            btnDeleteTextTextBox.TabIndex = 17;
            btnDeleteTextTextBox.Text = "        Delete the Text";
            btnDeleteTextTextBox.TextAlign = ContentAlignment.MiddleLeft;
            btnDeleteTextTextBox.UseVisualStyleBackColor = false;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 54);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(1221, 660);
            tabPage1.TabIndex = 3;
            tabPage1.Text = "Credits";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl3);
            Controls.Add(label3);
            Name = "Settings";
            Size = new Size(1279, 839);
            tabControl3.ResumeLayout(false);
            tabPage6.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TabControl tabControl3;
        private TabPage tabPage6;
        private TabPage tabPage5;
        private TabPage tabPage4;
        private Button btnDeleteTextTextBox;
        private TabPage tabPage1;
        private Button btnLogoutQuit;
        private Button btnChangeProfile;
    }
}
