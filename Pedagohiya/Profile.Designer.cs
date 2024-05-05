namespace Pedagohiya
{
    partial class Profile
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            btnCreateProfile = new Button();
            label7 = new Label();
            btnExistingProfile = new Button();
            lblChooseYourProfile = new Label();
            panel1 = new Panel();
            titlePanel = new Panel();
            label5 = new Label();
            label6 = new Label();
            panelExistingProfile = new Panel();
            panelCreateProfile = new Panel();
            label9 = new Label();
            label10 = new Label();
            UsernameTextBox = new TextBox();
            btnStart = new Button();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            titlePanel.SuspendLayout();
            panelCreateProfile.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(panel2, 1, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Location = new Point(-65, 99);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 558F));
            tableLayoutPanel1.Size = new Size(1103, 553);
            tableLayoutPanel1.TabIndex = 17;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnCreateProfile);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(btnExistingProfile);
            panel2.Controls.Add(lblChooseYourProfile);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(705, -2);
            panel2.Name = "panel2";
            panel2.Size = new Size(340, 552);
            panel2.TabIndex = 17;
            // 
            // btnCreateProfile
            // 
            btnCreateProfile.BackColor = Color.White;
            btnCreateProfile.BackgroundImageLayout = ImageLayout.None;
            btnCreateProfile.FlatAppearance.BorderColor = Color.Black;
            btnCreateProfile.FlatAppearance.BorderSize = 3;
            btnCreateProfile.FlatStyle = FlatStyle.Flat;
            btnCreateProfile.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateProfile.Image = Properties.Resources.dashboard;
            btnCreateProfile.ImageAlign = ContentAlignment.MiddleLeft;
            btnCreateProfile.Location = new Point(37, 288);
            btnCreateProfile.Margin = new Padding(10);
            btnCreateProfile.Name = "btnCreateProfile";
            btnCreateProfile.Padding = new Padding(16, 0, 0, 0);
            btnCreateProfile.Size = new Size(279, 69);
            btnCreateProfile.TabIndex = 12;
            btnCreateProfile.Text = "        Create Profile";
            btnCreateProfile.TextAlign = ContentAlignment.MiddleLeft;
            btnCreateProfile.UseVisualStyleBackColor = false;
            btnCreateProfile.Click += btnCreateProfile_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(105, 375);
            label7.Name = "label7";
            label7.Size = new Size(136, 13);
            label7.TabIndex = 11;
            label7.Text = "Sponsored  by Coca Cola";
            // 
            // btnExistingProfile
            // 
            btnExistingProfile.BackColor = Color.White;
            btnExistingProfile.BackgroundImageLayout = ImageLayout.None;
            btnExistingProfile.FlatAppearance.BorderColor = Color.Black;
            btnExistingProfile.FlatAppearance.BorderSize = 3;
            btnExistingProfile.FlatStyle = FlatStyle.Flat;
            btnExistingProfile.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExistingProfile.Image = Properties.Resources.dashboard;
            btnExistingProfile.ImageAlign = ContentAlignment.MiddleLeft;
            btnExistingProfile.Location = new Point(37, 199);
            btnExistingProfile.Margin = new Padding(10);
            btnExistingProfile.Name = "btnExistingProfile";
            btnExistingProfile.Padding = new Padding(16, 0, 0, 0);
            btnExistingProfile.Size = new Size(279, 69);
            btnExistingProfile.TabIndex = 13;
            btnExistingProfile.Text = "        Use existing profile";
            btnExistingProfile.TextAlign = ContentAlignment.MiddleLeft;
            btnExistingProfile.UseVisualStyleBackColor = false;
            btnExistingProfile.Click += ExistingProfilebtn_Click;
            // 
            // lblChooseYourProfile
            // 
            lblChooseYourProfile.AutoSize = true;
            lblChooseYourProfile.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChooseYourProfile.ForeColor = Color.Black;
            lblChooseYourProfile.Location = new Point(43, 145);
            lblChooseYourProfile.Name = "lblChooseYourProfile";
            lblChooseYourProfile.Size = new Size(269, 37);
            lblChooseYourProfile.TabIndex = 1;
            lblChooseYourProfile.Text = "Choose Your Profile";
            lblChooseYourProfile.Visible = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(titlePanel);
            panel1.Controls.Add(panelExistingProfile);
            panel1.Controls.Add(panelCreateProfile);
            panel1.Dock = DockStyle.Right;
            panel1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(3, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(696, 552);
            panel1.TabIndex = 2;
            // 
            // titlePanel
            // 
            titlePanel.BackgroundImageLayout = ImageLayout.None;
            titlePanel.Controls.Add(label5);
            titlePanel.Controls.Add(label6);
            titlePanel.Dock = DockStyle.Right;
            titlePanel.Location = new Point(-257, 0);
            titlePanel.Name = "titlePanel";
            titlePanel.Size = new Size(300, 552);
            titlePanel.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(21, 236);
            label5.Name = "label5";
            label5.Size = new Size(256, 47);
            label5.TabIndex = 0;
            label5.Text = "PEDAGOHIYA";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Variable Text Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(36, 290);
            label6.Name = "label6";
            label6.Size = new Size(225, 21);
            label6.TabIndex = 9;
            label6.Text = "Efficient Faculty Management";
            // 
            // panelExistingProfile
            // 
            panelExistingProfile.Dock = DockStyle.Right;
            panelExistingProfile.Location = new Point(43, 0);
            panelExistingProfile.Name = "panelExistingProfile";
            panelExistingProfile.Size = new Size(304, 552);
            panelExistingProfile.TabIndex = 18;
            panelExistingProfile.Visible = false;
            // 
            // panelCreateProfile
            // 
            panelCreateProfile.Controls.Add(label9);
            panelCreateProfile.Controls.Add(label10);
            panelCreateProfile.Controls.Add(UsernameTextBox);
            panelCreateProfile.Controls.Add(btnStart);
            panelCreateProfile.Dock = DockStyle.Right;
            panelCreateProfile.Location = new Point(347, 0);
            panelCreateProfile.Name = "panelCreateProfile";
            panelCreateProfile.Size = new Size(349, 552);
            panelCreateProfile.TabIndex = 17;
            panelCreateProfile.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(52, 199);
            label9.Name = "label9";
            label9.Size = new Size(259, 37);
            label9.TabIndex = 1;
            label9.Text = "Create Your Profile";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(52, 236);
            label10.Name = "label10";
            label10.Size = new Size(130, 15);
            label10.TabIndex = 3;
            label10.Text = "Choose a ProfileName: ";
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.BorderStyle = BorderStyle.FixedSingle;
            UsernameTextBox.Cursor = Cursors.IBeam;
            UsernameTextBox.Location = new Point(43, 264);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(274, 32);
            UsernameTextBox.TabIndex = 5;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.White;
            btnStart.BackgroundImageLayout = ImageLayout.None;
            btnStart.Cursor = Cursors.Hand;
            btnStart.FlatAppearance.BorderColor = Color.Black;
            btnStart.FlatAppearance.BorderSize = 2;
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStart.ForeColor = Color.Black;
            btnStart.ImageAlign = ContentAlignment.MiddleRight;
            btnStart.Location = new Point(62, 310);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(246, 44);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start Using Pedagohiya";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "Profile";
            Size = new Size(1279, 856);
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            titlePanel.ResumeLayout(false);
            titlePanel.PerformLayout();
            panelCreateProfile.ResumeLayout(false);
            panelCreateProfile.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private Button btnCreateProfile;
        private Label label7;
        private Button btnExistingProfile;
        private Label lblChooseYourProfile;
        private Panel panel1;
        private Panel titlePanel;
        private Label label5;
        private Label label6;
        private Panel panelExistingProfile;
        private Panel panelCreateProfile;
        private Label label9;
        private Label label10;
        private TextBox UsernameTextBox;
        private Button btnStart;
    }
}
