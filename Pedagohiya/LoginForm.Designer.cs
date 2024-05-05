namespace Pedagohiya
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label6 = new Label();
            label5 = new Label();
            label7 = new Label();
            panel1 = new Panel();
            titlePanel = new Panel();
            panelExistingProfile = new Panel();
            panelCreateProfile = new Panel();
            label9 = new Label();
            label10 = new Label();
            UsernameTextBox = new TextBox();
            btnStart = new Button();
            lblChooseYourProfile = new Label();
            btnCreateProfile = new Button();
            btnExistingProfile = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblDeleteProfile = new Label();
            btnDeleteProfile = new Button();
            btnClose = new Button();
            btnMinimize = new Button();
            label1 = new Label();
            PasswordTextBox = new TextBox();
            panel1.SuspendLayout();
            titlePanel.SuspendLayout();
            panelCreateProfile.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(103, 422);
            label7.Name = "label7";
            label7.Size = new Size(136, 13);
            label7.TabIndex = 11;
            label7.Text = "Sponsored  by Coca Cola";
            // 
            // panel1
            // 
            panel1.Controls.Add(titlePanel);
            panel1.Controls.Add(panelExistingProfile);
            panel1.Controls.Add(panelCreateProfile);
            panel1.Dock = DockStyle.Right;
            panel1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(3, 20);
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
            panelCreateProfile.Controls.Add(PasswordTextBox);
            panelCreateProfile.Controls.Add(label1);
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
            label9.Location = new Point(52, 159);
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
            label10.Location = new Point(52, 213);
            label10.Name = "label10";
            label10.Size = new Size(130, 15);
            label10.TabIndex = 3;
            label10.Text = "Choose a ProfileName: ";
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.BorderStyle = BorderStyle.FixedSingle;
            UsernameTextBox.Cursor = Cursors.IBeam;
            UsernameTextBox.Location = new Point(52, 236);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(259, 32);
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
            btnStart.Location = new Point(60, 358);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(246, 44);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start Using Pedagohiya";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // lblChooseYourProfile
            // 
            lblChooseYourProfile.AutoSize = true;
            lblChooseYourProfile.Dock = DockStyle.Fill;
            lblChooseYourProfile.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChooseYourProfile.ForeColor = Color.Black;
            lblChooseYourProfile.Location = new Point(3, 37);
            lblChooseYourProfile.Name = "lblChooseYourProfile";
            lblChooseYourProfile.Size = new Size(269, 37);
            lblChooseYourProfile.TabIndex = 1;
            lblChooseYourProfile.Text = "Choose Your Profile";
            lblChooseYourProfile.Visible = false;
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
            btnCreateProfile.Location = new Point(37, 248);
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
            btnExistingProfile.Location = new Point(37, 159);
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
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(panel2, 1, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Location = new Point(26, 104);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 558F));
            tableLayoutPanel1.Size = new Size(1448, 575);
            tableLayoutPanel1.TabIndex = 16;
            // 
            // panel2
            // 
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Controls.Add(btnDeleteProfile);
            panel2.Controls.Add(btnCreateProfile);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(btnExistingProfile);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(705, 20);
            panel2.Name = "panel2";
            panel2.Size = new Size(340, 552);
            panel2.TabIndex = 17;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(lblDeleteProfile);
            flowLayoutPanel1.Controls.Add(lblChooseYourProfile);
            flowLayoutPanel1.Location = new Point(37, 104);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(275, 42);
            flowLayoutPanel1.TabIndex = 18;
            // 
            // lblDeleteProfile
            // 
            lblDeleteProfile.AutoSize = true;
            lblDeleteProfile.Dock = DockStyle.Fill;
            lblDeleteProfile.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDeleteProfile.ForeColor = Color.Black;
            lblDeleteProfile.Location = new Point(3, 0);
            lblDeleteProfile.Name = "lblDeleteProfile";
            lblDeleteProfile.Size = new Size(216, 37);
            lblDeleteProfile.TabIndex = 15;
            lblDeleteProfile.Text = "Delete a profile";
            lblDeleteProfile.Visible = false;
            // 
            // btnDeleteProfile
            // 
            btnDeleteProfile.BackColor = Color.White;
            btnDeleteProfile.BackgroundImageLayout = ImageLayout.None;
            btnDeleteProfile.FlatAppearance.BorderColor = Color.Black;
            btnDeleteProfile.FlatAppearance.BorderSize = 3;
            btnDeleteProfile.FlatStyle = FlatStyle.Flat;
            btnDeleteProfile.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteProfile.Image = Properties.Resources.dashboard;
            btnDeleteProfile.ImageAlign = ContentAlignment.MiddleLeft;
            btnDeleteProfile.Location = new Point(37, 343);
            btnDeleteProfile.Margin = new Padding(10);
            btnDeleteProfile.Name = "btnDeleteProfile";
            btnDeleteProfile.Padding = new Padding(16, 0, 0, 0);
            btnDeleteProfile.Size = new Size(279, 69);
            btnDeleteProfile.TabIndex = 14;
            btnDeleteProfile.Text = "        Delete Profile";
            btnDeleteProfile.TextAlign = ContentAlignment.MiddleLeft;
            btnDeleteProfile.UseVisualStyleBackColor = false;
            btnDeleteProfile.Click += btnDeleteProfile_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Brown;
            btnClose.BackgroundImageLayout = ImageLayout.None;
            btnClose.FlatAppearance.BorderColor = Color.Black;
            btnClose.FlatAppearance.BorderSize = 3;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Image = Properties.Resources.quit_white;
            btnClose.Location = new Point(1427, 33);
            btnClose.Margin = new Padding(10);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(32, 32);
            btnClose.TabIndex = 14;
            btnClose.TextAlign = ContentAlignment.MiddleLeft;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.BackColor = Color.White;
            btnMinimize.BackgroundImageLayout = ImageLayout.None;
            btnMinimize.FlatAppearance.BorderColor = Color.Black;
            btnMinimize.FlatAppearance.BorderSize = 3;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinimize.Image = Properties.Resources.minimize;
            btnMinimize.ImageAlign = ContentAlignment.TopCenter;
            btnMinimize.Location = new Point(1385, 33);
            btnMinimize.Margin = new Padding(10);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(32, 32);
            btnMinimize.TabIndex = 15;
            btnMinimize.TextAlign = ContentAlignment.MiddleLeft;
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(52, 290);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 6;
            label1.Text = "Enter password:";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.BorderStyle = BorderStyle.FixedSingle;
            PasswordTextBox.Cursor = Cursors.IBeam;
            PasswordTextBox.Location = new Point(52, 311);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(259, 32);
            PasswordTextBox.TabIndex = 7;
            // 
            // LoginForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(1511, 783);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(btnMinimize);
            Controls.Add(btnClose);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pedagohiya";
            WindowState = FormWindowState.Maximized;
            Load += Main_Load;
            panel1.ResumeLayout(false);
            titlePanel.ResumeLayout(false);
            titlePanel.PerformLayout();
            panelCreateProfile.ResumeLayout(false);
            panelCreateProfile.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label5;
        private Label label6;
        private Label label7;
        private Panel panel1;
        private Button btnCreateProfile;
        private Button btnExistingProfile;
        private Panel panelCreateProfile;
        private Label label9;
        private Label label10;
        private TextBox UsernameTextBox;
        private Button btnStart;
        private Panel titlePanel;
        private Panel panelExistingProfile;
        private Label lblChooseYourProfile;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private Button btnClose;
        private Button btnMinimize;
        private Button btnDeleteProfile;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblDeleteProfile;
        private TextBox PasswordTextBox;
        private Label label1;
    }
}
