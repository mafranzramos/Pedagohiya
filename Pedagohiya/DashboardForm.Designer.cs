using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Pedagohiya
{
    partial class DashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>Fs
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        /// 

        private void InitializeComponent()
        {
            label5 = new Label();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblUsername = new Label();
            btnDashboard = new Button();
            duck_Pic = new PictureBox();
            btnAttendance = new Button();
            btnTasks = new Button();
            magic8ball = new Panel();
            MagicLabel = new Label();
            pictureBox1 = new PictureBox();
            btnClassManagement = new Button();
            btnSettings = new Button();
            panel2 = new Panel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            label3 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            button10 = new Button();
            label4 = new Label();
            panel4 = new Panel();
            flowLayoutPanel6 = new FlowLayoutPanel();
            button25 = new Button();
            button26 = new Button();
            button27 = new Button();
            label8 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            button28 = new Button();
            label9 = new Label();
            panel3 = new Panel();
            checkedListBox1 = new CheckedListBox();
            AttendancePanel = new Attendance();
            tableLayoutPanel2 = new TableLayoutPanel();
            label6 = new Label();
            mainContainer = new Panel();
            SettingsPanel = new Settings();
            dashboard1 = new Dashboard();
            taskPanel = new Task();
            DashboardPanel = new Panel();
            panel5 = new Panel();
            btnMinimize = new Button();
            btnClose = new Button();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)duck_Pic).BeginInit();
            magic8ball.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel4.SuspendLayout();
            flowLayoutPanel6.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel3.SuspendLayout();
            mainContainer.SuspendLayout();
            DashboardPanel.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(45, 70, 76);
            label5.Location = new Point(22, 19);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(0, 57);
            label5.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(26, 26);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(352, 65);
            label1.TabIndex = 2;
            label1.Text = "PEDAGOHIYA";
            label1.Click += label1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(66, 100, 208);
            flowLayoutPanel1.Controls.Add(lblUsername);
            flowLayoutPanel1.Controls.Add(btnDashboard);
            flowLayoutPanel1.Controls.Add(duck_Pic);
            flowLayoutPanel1.Controls.Add(btnAttendance);
            flowLayoutPanel1.Controls.Add(btnTasks);
            flowLayoutPanel1.Controls.Add(magic8ball);
            flowLayoutPanel1.Controls.Add(btnClassManagement);
            flowLayoutPanel1.Controls.Add(btnSettings);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(19, 21, 19, 21);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(28, 32, 28, 32);
            flowLayoutPanel1.Size = new Size(472, 1758);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.Black;
            lblUsername.Location = new Point(34, 32);
            lblUsername.Margin = new Padding(6, 0, 6, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.RightToLeft = RightToLeft.No;
            lblUsername.Size = new Size(349, 51);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "Pick a profile first!";
            lblUsername.TextAlign = ContentAlignment.MiddleCenter;
            lblUsername.Click += lblUsername_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.White;
            btnDashboard.BackgroundImageLayout = ImageLayout.None;
            btnDashboard.FlatAppearance.BorderColor = Color.Black;
            btnDashboard.FlatAppearance.BorderSize = 3;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.Black;
            btnDashboard.Image = Properties.Resources.dashboard;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(47, 104);
            btnDashboard.Margin = new Padding(19, 21, 19, 21);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(30, 0, 0, 0);
            btnDashboard.Size = new Size(373, 115);
            btnDashboard.TabIndex = 6;
            btnDashboard.Text = "        Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // duck_Pic
            // 
            duck_Pic.BackgroundImageLayout = ImageLayout.None;
            duck_Pic.Image = Properties.Resources.XOsX;
            duck_Pic.Location = new Point(34, 246);
            duck_Pic.Margin = new Padding(6, 6, 6, 6);
            duck_Pic.Name = "duck_Pic";
            duck_Pic.Size = new Size(386, 213);
            duck_Pic.SizeMode = PictureBoxSizeMode.Zoom;
            duck_Pic.TabIndex = 11;
            duck_Pic.TabStop = false;
            duck_Pic.Visible = false;
            duck_Pic.Click += duck_Pic_Click;
            // 
            // btnAttendance
            // 
            btnAttendance.BackColor = Color.White;
            btnAttendance.BackgroundImageLayout = ImageLayout.None;
            btnAttendance.FlatAppearance.BorderColor = Color.Black;
            btnAttendance.FlatAppearance.BorderSize = 3;
            btnAttendance.FlatStyle = FlatStyle.Flat;
            btnAttendance.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAttendance.Image = Properties.Resources.itask;
            btnAttendance.ImageAlign = ContentAlignment.MiddleLeft;
            btnAttendance.Location = new Point(47, 486);
            btnAttendance.Margin = new Padding(19, 21, 19, 21);
            btnAttendance.Name = "btnAttendance";
            btnAttendance.Padding = new Padding(30, 0, 0, 0);
            btnAttendance.Size = new Size(373, 115);
            btnAttendance.TabIndex = 9;
            btnAttendance.Text = "        Attendance";
            btnAttendance.TextAlign = ContentAlignment.MiddleLeft;
            btnAttendance.UseVisualStyleBackColor = false;
            btnAttendance.Click += btnAttendance_Click;
            // 
            // btnTasks
            // 
            btnTasks.BackColor = Color.White;
            btnTasks.BackgroundImageLayout = ImageLayout.None;
            btnTasks.FlatAppearance.BorderColor = Color.Black;
            btnTasks.FlatAppearance.BorderSize = 3;
            btnTasks.FlatStyle = FlatStyle.Flat;
            btnTasks.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTasks.Image = Properties.Resources.icons8_high_priority_26;
            btnTasks.ImageAlign = ContentAlignment.MiddleLeft;
            btnTasks.Location = new Point(47, 643);
            btnTasks.Margin = new Padding(19, 21, 19, 21);
            btnTasks.Name = "btnTasks";
            btnTasks.Padding = new Padding(30, 0, 0, 0);
            btnTasks.Size = new Size(373, 115);
            btnTasks.TabIndex = 7;
            btnTasks.Text = "        Tasks";
            btnTasks.TextAlign = ContentAlignment.MiddleLeft;
            btnTasks.UseVisualStyleBackColor = false;
            btnTasks.Click += btnTask_click;
            // 
            // magic8ball
            // 
            magic8ball.Controls.Add(MagicLabel);
            magic8ball.Controls.Add(pictureBox1);
            magic8ball.Location = new Point(34, 785);
            magic8ball.Margin = new Padding(6, 6, 6, 6);
            magic8ball.Name = "magic8ball";
            magic8ball.Size = new Size(386, 247);
            magic8ball.TabIndex = 15;
            magic8ball.Visible = false;
            // 
            // MagicLabel
            // 
            MagicLabel.AutoSize = true;
            MagicLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MagicLabel.Location = new Point(6, 207);
            MagicLabel.Margin = new Padding(6, 0, 6, 0);
            MagicLabel.Name = "MagicLabel";
            MagicLabel.Size = new Size(119, 41);
            MagicLabel.TabIndex = 13;
            MagicLabel.Text = "Hmm...";
            MagicLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.billiard;
            pictureBox1.Location = new Point(113, 0);
            pictureBox1.Margin = new Padding(6, 6, 6, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(163, 201);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Click += magic_Click;
            // 
            // btnClassManagement
            // 
            btnClassManagement.BackColor = Color.White;
            btnClassManagement.BackgroundImageLayout = ImageLayout.None;
            btnClassManagement.FlatAppearance.BorderColor = Color.Black;
            btnClassManagement.FlatAppearance.BorderSize = 3;
            btnClassManagement.FlatStyle = FlatStyle.Flat;
            btnClassManagement.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClassManagement.Image = Properties.Resources.student;
            btnClassManagement.ImageAlign = ContentAlignment.MiddleLeft;
            btnClassManagement.Location = new Point(47, 1059);
            btnClassManagement.Margin = new Padding(19, 21, 19, 21);
            btnClassManagement.Name = "btnClassManagement";
            btnClassManagement.Padding = new Padding(30, 0, 0, 0);
            btnClassManagement.Size = new Size(373, 139);
            btnClassManagement.TabIndex = 7;
            btnClassManagement.Text = "         Class Management";
            btnClassManagement.TextAlign = ContentAlignment.MiddleLeft;
            btnClassManagement.UseVisualStyleBackColor = false;
            btnClassManagement.Click += btnClassManagement_Click;
            // 
            // btnSettings
            // 
            btnSettings.BackColor = Color.White;
            btnSettings.BackgroundImageLayout = ImageLayout.None;
            btnSettings.FlatAppearance.BorderColor = Color.Black;
            btnSettings.FlatAppearance.BorderSize = 3;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSettings.Image = Properties.Resources.settings;
            btnSettings.ImageAlign = ContentAlignment.MiddleLeft;
            btnSettings.Location = new Point(47, 1240);
            btnSettings.Margin = new Padding(19, 21, 19, 21);
            btnSettings.Name = "btnSettings";
            btnSettings.Padding = new Padding(30, 0, 0, 0);
            btnSettings.Size = new Size(373, 115);
            btnSettings.TabIndex = 10;
            btnSettings.Text = "        Settings";
            btnSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += btnSettings_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(flowLayoutPanel2);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 100);
            panel2.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(button7);
            flowLayoutPanel2.Controls.Add(button8);
            flowLayoutPanel2.Controls.Add(button9);
            flowLayoutPanel2.Location = new Point(37, 59);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(887, 66);
            flowLayoutPanel2.TabIndex = 12;
            // 
            // button7
            // 
            button7.BackColor = Color.White;
            button7.BackgroundImageLayout = ImageLayout.None;
            button7.FlatAppearance.BorderColor = Color.Black;
            button7.FlatAppearance.BorderSize = 3;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Image = Properties.Resources.student;
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(10, 10);
            button7.Margin = new Padding(10);
            button7.Name = "button7";
            button7.Padding = new Padding(16, 0, 0, 0);
            button7.Size = new Size(259, 42);
            button7.TabIndex = 8;
            button7.Text = "        Manage Students";
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.White;
            button8.BackgroundImageLayout = ImageLayout.None;
            button8.FlatAppearance.BorderColor = Color.Black;
            button8.FlatAppearance.BorderSize = 3;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.Image = Properties.Resources.student;
            button8.ImageAlign = ContentAlignment.MiddleLeft;
            button8.Location = new Point(289, 10);
            button8.Margin = new Padding(10);
            button8.Name = "button8";
            button8.Padding = new Padding(16, 0, 0, 0);
            button8.Size = new Size(259, 42);
            button8.TabIndex = 9;
            button8.Text = "        Search Student";
            button8.TextAlign = ContentAlignment.MiddleLeft;
            button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = Color.White;
            button9.BackgroundImageLayout = ImageLayout.None;
            button9.FlatAppearance.BorderColor = Color.Black;
            button9.FlatAppearance.BorderSize = 3;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.Image = Properties.Resources.student;
            button9.ImageAlign = ContentAlignment.MiddleLeft;
            button9.Location = new Point(568, 10);
            button9.Margin = new Padding(10);
            button9.Name = "button9";
            button9.Padding = new Padding(16, 0, 0, 0);
            button9.Size = new Size(259, 42);
            button9.TabIndex = 10;
            button9.Text = "        Search Sort";
            button9.TextAlign = ContentAlignment.MiddleLeft;
            button9.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(17, 11);
            label3.Name = "label3";
            label3.Size = new Size(376, 86);
            label3.TabIndex = 5;
            label3.Text = "STUDENTS";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.802093F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 92.19791F));
            tableLayoutPanel1.Controls.Add(button10, 0, 0);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(200, 100);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // button10
            // 
            button10.BackColor = Color.Transparent;
            button10.BackgroundImageLayout = ImageLayout.None;
            button10.FlatAppearance.BorderColor = Color.Black;
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button10.Image = Properties.Resources.back;
            button10.Location = new Point(10, 10);
            button10.Margin = new Padding(10);
            button10.Name = "button10";
            button10.Size = new Size(1, 20);
            button10.TabIndex = 14;
            button10.TextAlign = ContentAlignment.MiddleLeft;
            button10.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(18, 0);
            label4.Name = "label4";
            label4.Size = new Size(176, 135);
            label4.TabIndex = 11;
            label4.Text = "MANAGE STUDENTS";
            // 
            // panel4
            // 
            panel4.Controls.Add(flowLayoutPanel6);
            panel4.Controls.Add(label8);
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 100);
            panel4.TabIndex = 0;
            // 
            // flowLayoutPanel6
            // 
            flowLayoutPanel6.Controls.Add(button25);
            flowLayoutPanel6.Controls.Add(button26);
            flowLayoutPanel6.Controls.Add(button27);
            flowLayoutPanel6.Location = new Point(37, 59);
            flowLayoutPanel6.Name = "flowLayoutPanel6";
            flowLayoutPanel6.Size = new Size(887, 66);
            flowLayoutPanel6.TabIndex = 12;
            // 
            // button25
            // 
            button25.BackColor = Color.White;
            button25.BackgroundImageLayout = ImageLayout.None;
            button25.FlatAppearance.BorderColor = Color.Black;
            button25.FlatAppearance.BorderSize = 3;
            button25.FlatStyle = FlatStyle.Flat;
            button25.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button25.Image = Properties.Resources.student;
            button25.ImageAlign = ContentAlignment.MiddleLeft;
            button25.Location = new Point(10, 10);
            button25.Margin = new Padding(10);
            button25.Name = "button25";
            button25.Padding = new Padding(16, 0, 0, 0);
            button25.Size = new Size(259, 42);
            button25.TabIndex = 8;
            button25.Text = "        Manage Students";
            button25.TextAlign = ContentAlignment.MiddleLeft;
            button25.UseVisualStyleBackColor = false;
            // 
            // button26
            // 
            button26.BackColor = Color.White;
            button26.BackgroundImageLayout = ImageLayout.None;
            button26.FlatAppearance.BorderColor = Color.Black;
            button26.FlatAppearance.BorderSize = 3;
            button26.FlatStyle = FlatStyle.Flat;
            button26.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button26.Image = Properties.Resources.student;
            button26.ImageAlign = ContentAlignment.MiddleLeft;
            button26.Location = new Point(289, 10);
            button26.Margin = new Padding(10);
            button26.Name = "button26";
            button26.Padding = new Padding(16, 0, 0, 0);
            button26.Size = new Size(259, 42);
            button26.TabIndex = 9;
            button26.Text = "        Search Student";
            button26.TextAlign = ContentAlignment.MiddleLeft;
            button26.UseVisualStyleBackColor = false;
            // 
            // button27
            // 
            button27.BackColor = Color.White;
            button27.BackgroundImageLayout = ImageLayout.None;
            button27.FlatAppearance.BorderColor = Color.Black;
            button27.FlatAppearance.BorderSize = 3;
            button27.FlatStyle = FlatStyle.Flat;
            button27.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button27.Image = Properties.Resources.student;
            button27.ImageAlign = ContentAlignment.MiddleLeft;
            button27.Location = new Point(568, 10);
            button27.Margin = new Padding(10);
            button27.Name = "button27";
            button27.Padding = new Padding(16, 0, 0, 0);
            button27.Size = new Size(259, 42);
            button27.TabIndex = 10;
            button27.Text = "        Search Sort";
            button27.TextAlign = ContentAlignment.MiddleLeft;
            button27.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(17, 11);
            label8.Name = "label8";
            label8.Size = new Size(376, 86);
            label8.TabIndex = 5;
            label8.Text = "STUDENTS";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.80780208F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 98.1922F));
            tableLayoutPanel4.Controls.Add(button28, 1, 4);
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 5;
            tableLayoutPanel4.Size = new Size(200, 100);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // button28
            // 
            button28.BackColor = Color.White;
            button28.BackgroundImageLayout = ImageLayout.None;
            button28.FlatAppearance.BorderColor = Color.Black;
            button28.FlatAppearance.BorderSize = 3;
            button28.FlatStyle = FlatStyle.Flat;
            button28.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button28.Image = Properties.Resources.student;
            button28.ImageAlign = ContentAlignment.MiddleLeft;
            button28.Location = new Point(13, 10);
            button28.Margin = new Padding(10);
            button28.Name = "button28";
            button28.Padding = new Padding(16, 0, 0, 0);
            button28.Size = new Size(177, 42);
            button28.TabIndex = 16;
            button28.Text = "        DELETE";
            button28.TextAlign = ContentAlignment.MiddleLeft;
            button28.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(16, 10);
            label9.Name = "label9";
            label9.Size = new Size(170, 135);
            label9.TabIndex = 11;
            label9.Text = "MANAGE STUDENTS";
            // 
            // panel3
            // 
            panel3.Controls.Add(checkedListBox1);
            panel3.Location = new Point(8, 8);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 100);
            panel3.TabIndex = 0;
            // 
            // checkedListBox1
            // 
            checkedListBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.HorizontalScrollbar = true;
            checkedListBox1.Location = new Point(659, 224);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(238, 196);
            checkedListBox1.TabIndex = 2;
            // 
            // AttendancePanel
            // 
            AttendancePanel.Dock = DockStyle.Top;
            AttendancePanel.Location = new Point(0, 186);
            AttendancePanel.Margin = new Padding(3, 4, 3, 4);
            AttendancePanel.Name = "AttendancePanel";
            AttendancePanel.Size = new Size(1273, 137);
            AttendancePanel.TabIndex = 4;
            AttendancePanel.Visible = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.Size = new Size(200, 100);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(92, 135);
            label6.TabIndex = 4;
            label6.Text = "DASHBOARD";
            // 
            // mainContainer
            // 
            mainContainer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mainContainer.Controls.Add(SettingsPanel);
            mainContainer.Controls.Add(dashboard1);
            mainContainer.Controls.Add(taskPanel);
            mainContainer.Dock = DockStyle.Left;
            mainContainer.ImeMode = ImeMode.Disable;
            mainContainer.Location = new Point(472, 132);
            mainContainer.Margin = new Padding(6, 4, 6, 4);
            mainContainer.Name = "mainContainer";
            mainContainer.Size = new Size(2364, 1626);
            mainContainer.TabIndex = 6;
            // 
            // SettingsPanel
            // 
            SettingsPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            SettingsPanel.BackColor = Color.White;
            SettingsPanel.DashboardForm = null;
            SettingsPanel.Dock = DockStyle.Top;
            SettingsPanel.Location = new Point(0, 164);
            SettingsPanel.Margin = new Padding(6, 9, 6, 9);
            SettingsPanel.Name = "SettingsPanel";
            SettingsPanel.Size = new Size(2364, 233);
            SettingsPanel.TabIndex = 2;
            SettingsPanel.Visible = false;
            // 
            // dashboard1
            // 
            dashboard1.BackColor = Color.FromArgb(223, 227, 242);
            dashboard1.BackgroundImageLayout = ImageLayout.Zoom;
            dashboard1.Dock = DockStyle.Top;
            dashboard1.Font = new Font("Libre Franklin", 11.0999994F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dashboard1.Location = new Point(0, 0);
            dashboard1.Margin = new Padding(6, 9, 6, 9);
            dashboard1.Name = "dashboard1";
            dashboard1.Size = new Size(2364, 164);
            dashboard1.TabIndex = 1;
            // 
            // taskPanel
            // 
            taskPanel.BackColor = Color.FromArgb(223, 227, 242);
            taskPanel.Font = new Font("Libre Franklin", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            taskPanel.Location = new Point(0, 809);
            taskPanel.Margin = new Padding(11, 13, 11, 13);
            taskPanel.Name = "taskPanel";
            taskPanel.Size = new Size(2396, 177);
            taskPanel.TabIndex = 8;
            // 
            // DashboardPanel
            // 
            DashboardPanel.Controls.Add(mainContainer);
            DashboardPanel.Controls.Add(panel5);
            DashboardPanel.Controls.Add(flowLayoutPanel1);
            DashboardPanel.Dock = DockStyle.Fill;
            DashboardPanel.Location = new Point(0, 0);
            DashboardPanel.Margin = new Padding(6, 6, 6, 6);
            DashboardPanel.Name = "DashboardPanel";
            DashboardPanel.Size = new Size(2836, 1758);
            DashboardPanel.TabIndex = 18;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(66, 100, 208);
            panel5.Controls.Add(btnMinimize);
            panel5.Controls.Add(btnClose);
            panel5.Controls.Add(label1);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(472, 0);
            panel5.Margin = new Padding(6, 6, 6, 6);
            panel5.Name = "panel5";
            panel5.Size = new Size(2364, 132);
            panel5.TabIndex = 19;
            // 
            // btnMinimize
            // 
            btnMinimize.AutoSize = true;
            btnMinimize.BackColor = Color.White;
            btnMinimize.BackgroundImageLayout = ImageLayout.None;
            btnMinimize.FlatAppearance.BorderColor = Color.Black;
            btnMinimize.FlatAppearance.BorderSize = 3;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinimize.Image = Properties.Resources.minimize;
            btnMinimize.ImageAlign = ContentAlignment.TopCenter;
            btnMinimize.Location = new Point(2203, 15);
            btnMinimize.Margin = new Padding(19, 21, 19, 21);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(71, 81);
            btnMinimize.TabIndex = 16;
            btnMinimize.TextAlign = ContentAlignment.MiddleLeft;
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click_1;
            // 
            // btnClose
            // 
            btnClose.AutoSize = true;
            btnClose.BackColor = Color.Brown;
            btnClose.BackgroundImageLayout = ImageLayout.None;
            btnClose.FlatAppearance.BorderColor = Color.Black;
            btnClose.FlatAppearance.BorderSize = 3;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Image = Properties.Resources.quit_white;
            btnClose.Location = new Point(2279, 15);
            btnClose.Margin = new Padding(19, 21, 19, 21);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(71, 81);
            btnClose.TabIndex = 15;
            btnClose.TextAlign = ContentAlignment.MiddleLeft;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnExit_Click;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(2836, 1758);
            ControlBox = false;
            Controls.Add(DashboardPanel);
            Controls.Add(label5);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6, 4, 6, 4);
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PEDAGOHIYA";
            WindowState = FormWindowState.Maximized;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)duck_Pic).EndInit();
            magic8ball.ResumeLayout(false);
            magic8ball.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            flowLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            mainContainer.ResumeLayout(false);
            DashboardPanel.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnDashboard;
        private Button btnClassManagement;
        private Button btnTasks;
        private Button btnAttendance;
        private Button btnSettings;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button button7;
        private Button button8;
        private Button button9;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button10;
        private Label label4;
        private Panel panel3;
        private Label lblUsername;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel4;
        private FlowLayoutPanel flowLayoutPanel6;
        private Button button25;
        private Button button26;
        private Button button27;
        private Label label8;
        private TableLayoutPanel tableLayoutPanel4;
        private Button button28;
        private Label label9;
        private CheckedListBox checkedListBox1;
        private Label label6;
        private Settings SettingsPanel;
        private Panel mainContainer;
        //private Students StudentPanel;
        private Panel DashboardPanel;
        private Panel panel5;
        private Button btnClose;
        private Button btnMinimize;
        private Dashboard dashboard1;
        private Attendance AttendancePanel;
        private PictureBox duck_Pic;
        private PictureBox pictureBox1;
        private Label MagicLabel;
        private Panel magic8ball;
        private Task taskPanel;
    }
}