namespace Pedagohiya
{
    partial class Task
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label4 = new Label();
            pnlTask = new Panel();
            pictureBox1 = new PictureBox();
            lblSection = new Label();
            lblSY = new Label();
            lblDateSubmi = new Label();
            lblTaskDesc = new Label();
            lblTaskTitle = new Label();
            pnlSat = new Panel();
            lblSatD = new Label();
            lblSat = new Label();
            pnlFri = new Panel();
            lblFriD = new Label();
            lblFri = new Label();
            pnlThu = new Panel();
            lblThuD = new Label();
            lblThu = new Label();
            pnlWed = new Panel();
            lblWedD = new Label();
            lblWed = new Label();
            pnlTue = new Panel();
            lblTueD = new Label();
            lblTue = new Label();
            pnlMon = new Panel();
            lblMonD = new Label();
            lblMon = new Label();
            pnlSun = new Panel();
            lblSunD = new Label();
            lblSun = new Label();
            panel2 = new Panel();
            lblDate = new Label();
            pbAddButton = new PictureBox();
            lblNoActYet = new Label();
            pbDeleteButton = new PictureBox();
            cmbSem = new ComboBox();
            cmbSY = new ComboBox();
            label1 = new Label();
            label5 = new Label();
            flpTaskList = new FlowLayoutPanel();
            SubjectListSection = new ListBox();
            label2 = new Label();
            SectionList = new ListBox();
            label3 = new Label();
            addTask_Popup2 = new AddTask_Popup();
            pbRefreshButton = new PictureBox();
            dgvTask = new DataGridView();
            label6 = new Label();
            pnlTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlSat.SuspendLayout();
            pnlFri.SuspendLayout();
            pnlThu.SuspendLayout();
            pnlWed.SuspendLayout();
            pnlTue.SuspendLayout();
            pnlMon.SuspendLayout();
            pnlSun.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAddButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDeleteButton).BeginInit();
            flpTaskList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbRefreshButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTask).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Libre Franklin", 27.7499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(25, 27);
            label4.Name = "label4";
            label4.Size = new Size(302, 53);
            label4.TabIndex = 10;
            label4.Text = "Course Activity";
            // 
            // pnlTask
            // 
            pnlTask.BackgroundImage = Properties.Resources.fortaskbg;
            pnlTask.BackgroundImageLayout = ImageLayout.Zoom;
            pnlTask.Controls.Add(pictureBox1);
            pnlTask.Controls.Add(lblSection);
            pnlTask.Controls.Add(lblSY);
            pnlTask.Controls.Add(lblDateSubmi);
            pnlTask.Controls.Add(lblTaskDesc);
            pnlTask.Controls.Add(lblTaskTitle);
            pnlTask.Location = new Point(3, 3);
            pnlTask.Name = "pnlTask";
            pnlTask.Size = new Size(639, 181);
            pnlTask.TabIndex = 13;
            pnlTask.Click += pnlTask_click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.task1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(22, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(173, 178);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // lblSection
            // 
            lblSection.AutoSize = true;
            lblSection.Font = new Font("Libre Franklin Light", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSection.Location = new Point(324, 128);
            lblSection.Name = "lblSection";
            lblSection.Size = new Size(63, 22);
            lblSection.TabIndex = 4;
            lblSection.Text = "Section";
            // 
            // lblSY
            // 
            lblSY.AutoSize = true;
            lblSY.Font = new Font("Libre Franklin Light", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSY.Location = new Point(205, 128);
            lblSY.Name = "lblSY";
            lblSY.Size = new Size(98, 22);
            lblSY.TabIndex = 3;
            lblSY.Text = "2023 - 2024";
            // 
            // lblDateSubmi
            // 
            lblDateSubmi.AutoSize = true;
            lblDateSubmi.BackColor = Color.Transparent;
            lblDateSubmi.Font = new Font("Libre Franklin", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDateSubmi.ForeColor = SystemColors.ActiveCaptionText;
            lblDateSubmi.Location = new Point(516, 26);
            lblDateSubmi.Name = "lblDateSubmi";
            lblDateSubmi.Size = new Size(70, 23);
            lblDateSubmi.TabIndex = 2;
            lblDateSubmi.Text = "Date, 10";
            // 
            // lblTaskDesc
            // 
            lblTaskDesc.AutoSize = true;
            lblTaskDesc.BackColor = Color.Transparent;
            lblTaskDesc.Font = new Font("Libre Franklin", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTaskDesc.ForeColor = SystemColors.ControlDarkDark;
            lblTaskDesc.Location = new Point(208, 55);
            lblTaskDesc.Name = "lblTaskDesc";
            lblTaskDesc.Size = new Size(130, 23);
            lblTaskDesc.TabIndex = 1;
            lblTaskDesc.Text = "task description";
            // 
            // lblTaskTitle
            // 
            lblTaskTitle.AutoSize = true;
            lblTaskTitle.BackColor = Color.Transparent;
            lblTaskTitle.Font = new Font("Libre Franklin", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTaskTitle.Location = new Point(205, 20);
            lblTaskTitle.Name = "lblTaskTitle";
            lblTaskTitle.Size = new Size(112, 30);
            lblTaskTitle.TabIndex = 0;
            lblTaskTitle.Text = "Task Title";
            // 
            // pnlSat
            // 
            pnlSat.BackColor = Color.Transparent;
            pnlSat.Controls.Add(lblSatD);
            pnlSat.Controls.Add(lblSat);
            pnlSat.Location = new Point(390, 79);
            pnlSat.Name = "pnlSat";
            pnlSat.Size = new Size(45, 70);
            pnlSat.TabIndex = 22;
            // 
            // lblSatD
            // 
            lblSatD.AutoSize = true;
            lblSatD.BackColor = Color.Transparent;
            lblSatD.Font = new Font("Libre Franklin", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSatD.ForeColor = Color.Black;
            lblSatD.Location = new Point(10, 40);
            lblSatD.Name = "lblSatD";
            lblSatD.Size = new Size(23, 18);
            lblSatD.TabIndex = 10;
            lblSatD.Text = "10";
            // 
            // lblSat
            // 
            lblSat.AutoSize = true;
            lblSat.BackColor = Color.Transparent;
            lblSat.Font = new Font("Libre Franklin", 11.2499981F);
            lblSat.ForeColor = Color.Black;
            lblSat.Location = new Point(6, 4);
            lblSat.Name = "lblSat";
            lblSat.Size = new Size(34, 22);
            lblSat.TabIndex = 9;
            lblSat.Text = "Sat";
            // 
            // pnlFri
            // 
            pnlFri.BackColor = Color.Transparent;
            pnlFri.Controls.Add(lblFriD);
            pnlFri.Controls.Add(lblFri);
            pnlFri.Location = new Point(330, 79);
            pnlFri.Name = "pnlFri";
            pnlFri.Size = new Size(45, 70);
            pnlFri.TabIndex = 21;
            // 
            // lblFriD
            // 
            lblFriD.AutoSize = true;
            lblFriD.BackColor = Color.Transparent;
            lblFriD.Font = new Font("Libre Franklin", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFriD.ForeColor = Color.Black;
            lblFriD.Location = new Point(10, 40);
            lblFriD.Name = "lblFriD";
            lblFriD.Size = new Size(23, 18);
            lblFriD.TabIndex = 10;
            lblFriD.Text = "10";
            // 
            // lblFri
            // 
            lblFri.AutoSize = true;
            lblFri.BackColor = Color.Transparent;
            lblFri.Font = new Font("Libre Franklin", 11.2499981F);
            lblFri.ForeColor = Color.Black;
            lblFri.Location = new Point(9, 5);
            lblFri.Name = "lblFri";
            lblFri.Size = new Size(28, 22);
            lblFri.TabIndex = 9;
            lblFri.Text = "Fri";
            // 
            // pnlThu
            // 
            pnlThu.BackColor = Color.Transparent;
            pnlThu.Controls.Add(lblThuD);
            pnlThu.Controls.Add(lblThu);
            pnlThu.Location = new Point(268, 79);
            pnlThu.Name = "pnlThu";
            pnlThu.Size = new Size(45, 70);
            pnlThu.TabIndex = 20;
            // 
            // lblThuD
            // 
            lblThuD.AutoSize = true;
            lblThuD.BackColor = Color.Transparent;
            lblThuD.Font = new Font("Libre Franklin", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblThuD.ForeColor = Color.Black;
            lblThuD.Location = new Point(10, 40);
            lblThuD.Name = "lblThuD";
            lblThuD.Size = new Size(23, 18);
            lblThuD.TabIndex = 10;
            lblThuD.Text = "10";
            // 
            // lblThu
            // 
            lblThu.AutoSize = true;
            lblThu.BackColor = Color.Transparent;
            lblThu.Font = new Font("Libre Franklin", 11.2499981F);
            lblThu.ForeColor = Color.Black;
            lblThu.Location = new Point(3, 5);
            lblThu.Name = "lblThu";
            lblThu.Size = new Size(38, 22);
            lblThu.TabIndex = 9;
            lblThu.Text = "Thu";
            // 
            // pnlWed
            // 
            pnlWed.BackColor = Color.Transparent;
            pnlWed.Controls.Add(lblWedD);
            pnlWed.Controls.Add(lblWed);
            pnlWed.Location = new Point(207, 79);
            pnlWed.Name = "pnlWed";
            pnlWed.Size = new Size(45, 70);
            pnlWed.TabIndex = 19;
            // 
            // lblWedD
            // 
            lblWedD.AutoSize = true;
            lblWedD.BackColor = Color.Transparent;
            lblWedD.Font = new Font("Libre Franklin", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWedD.ForeColor = Color.Black;
            lblWedD.Location = new Point(10, 40);
            lblWedD.Name = "lblWedD";
            lblWedD.Size = new Size(23, 18);
            lblWedD.TabIndex = 10;
            lblWedD.Text = "10";
            // 
            // lblWed
            // 
            lblWed.AutoSize = true;
            lblWed.BackColor = Color.Transparent;
            lblWed.Font = new Font("Libre Franklin", 11.2499981F);
            lblWed.ForeColor = Color.Black;
            lblWed.Location = new Point(3, 5);
            lblWed.Name = "lblWed";
            lblWed.Size = new Size(43, 22);
            lblWed.TabIndex = 9;
            lblWed.Text = "Wed";
            // 
            // pnlTue
            // 
            pnlTue.BackColor = Color.Transparent;
            pnlTue.Controls.Add(lblTueD);
            pnlTue.Controls.Add(lblTue);
            pnlTue.Location = new Point(143, 79);
            pnlTue.Name = "pnlTue";
            pnlTue.Size = new Size(45, 70);
            pnlTue.TabIndex = 17;
            // 
            // lblTueD
            // 
            lblTueD.AutoSize = true;
            lblTueD.BackColor = Color.Transparent;
            lblTueD.Font = new Font("Libre Franklin", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTueD.ForeColor = Color.Black;
            lblTueD.Location = new Point(10, 40);
            lblTueD.Name = "lblTueD";
            lblTueD.Size = new Size(23, 18);
            lblTueD.TabIndex = 10;
            lblTueD.Text = "10";
            // 
            // lblTue
            // 
            lblTue.AutoSize = true;
            lblTue.BackColor = Color.Transparent;
            lblTue.Font = new Font("Libre Franklin", 11.2499981F);
            lblTue.ForeColor = Color.Black;
            lblTue.Location = new Point(3, 5);
            lblTue.Name = "lblTue";
            lblTue.Size = new Size(37, 22);
            lblTue.TabIndex = 9;
            lblTue.Text = "Tue";
            // 
            // pnlMon
            // 
            pnlMon.BackColor = Color.Transparent;
            pnlMon.Controls.Add(lblMonD);
            pnlMon.Controls.Add(lblMon);
            pnlMon.Location = new Point(77, 79);
            pnlMon.Name = "pnlMon";
            pnlMon.Size = new Size(45, 70);
            pnlMon.TabIndex = 18;
            // 
            // lblMonD
            // 
            lblMonD.AutoSize = true;
            lblMonD.BackColor = Color.Transparent;
            lblMonD.Font = new Font("Libre Franklin", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMonD.ForeColor = Color.Black;
            lblMonD.Location = new Point(10, 40);
            lblMonD.Name = "lblMonD";
            lblMonD.Size = new Size(23, 18);
            lblMonD.TabIndex = 10;
            lblMonD.Text = "10";
            // 
            // lblMon
            // 
            lblMon.AutoSize = true;
            lblMon.BackColor = Color.Transparent;
            lblMon.Font = new Font("Libre Franklin", 11.2499981F);
            lblMon.ForeColor = Color.Black;
            lblMon.Location = new Point(2, 5);
            lblMon.Name = "lblMon";
            lblMon.Size = new Size(42, 22);
            lblMon.TabIndex = 9;
            lblMon.Text = "Mon";
            // 
            // pnlSun
            // 
            pnlSun.BackColor = Color.Transparent;
            pnlSun.Controls.Add(lblSunD);
            pnlSun.Controls.Add(lblSun);
            pnlSun.Location = new Point(13, 79);
            pnlSun.Name = "pnlSun";
            pnlSun.Size = new Size(45, 70);
            pnlSun.TabIndex = 16;
            // 
            // lblSunD
            // 
            lblSunD.AutoSize = true;
            lblSunD.BackColor = Color.Transparent;
            lblSunD.Font = new Font("Libre Franklin", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSunD.ForeColor = Color.Black;
            lblSunD.Location = new Point(10, 40);
            lblSunD.Name = "lblSunD";
            lblSunD.Size = new Size(23, 18);
            lblSunD.TabIndex = 10;
            lblSunD.Text = "10";
            // 
            // lblSun
            // 
            lblSun.AutoSize = true;
            lblSun.BackColor = Color.Transparent;
            lblSun.Font = new Font("Libre Franklin", 11.2499981F);
            lblSun.ForeColor = Color.Black;
            lblSun.Location = new Point(3, 5);
            lblSun.Name = "lblSun";
            lblSun.Size = new Size(38, 22);
            lblSun.TabIndex = 9;
            lblSun.Text = "Sun";
            // 
            // panel2
            // 
            panel2.Controls.Add(lblDate);
            panel2.Controls.Add(pnlSun);
            panel2.Controls.Add(pnlSat);
            panel2.Controls.Add(pnlMon);
            panel2.Controls.Add(pnlFri);
            panel2.Controls.Add(pnlTue);
            panel2.Controls.Add(pnlThu);
            panel2.Controls.Add(pnlWed);
            panel2.Location = new Point(779, 38);
            panel2.Name = "panel2";
            panel2.Size = new Size(454, 168);
            panel2.TabIndex = 23;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Libre Franklin SemiBold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDate.Location = new Point(4, 20);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(139, 39);
            lblDate.TabIndex = 23;
            lblDate.Text = "Month 10";
            // 
            // pbAddButton
            // 
            pbAddButton.BackgroundImage = Properties.Resources.addbutton;
            pbAddButton.BackgroundImageLayout = ImageLayout.Zoom;
            pbAddButton.Location = new Point(64, 184);
            pbAddButton.Name = "pbAddButton";
            pbAddButton.Size = new Size(46, 36);
            pbAddButton.TabIndex = 24;
            pbAddButton.TabStop = false;
            pbAddButton.Click += pbAddButton_click;
            // 
            // lblNoActYet
            // 
            lblNoActYet.AutoSize = true;
            lblNoActYet.Font = new Font("Libre Franklin", 23.9999962F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblNoActYet.ForeColor = Color.FromArgb(66, 100, 208);
            lblNoActYet.Location = new Point(197, 400);
            lblNoActYet.Name = "lblNoActYet";
            lblNoActYet.Size = new Size(293, 46);
            lblNoActYet.TabIndex = 25;
            lblNoActYet.Text = "No activities yet...";
            // 
            // pbDeleteButton
            // 
            pbDeleteButton.BackColor = Color.Transparent;
            pbDeleteButton.BackgroundImage = Properties.Resources.trashbutton;
            pbDeleteButton.BackgroundImageLayout = ImageLayout.Zoom;
            pbDeleteButton.Location = new Point(124, 184);
            pbDeleteButton.Name = "pbDeleteButton";
            pbDeleteButton.Size = new Size(42, 36);
            pbDeleteButton.TabIndex = 28;
            pbDeleteButton.TabStop = false;
            pbDeleteButton.Click += pbDeleteButton_click;
            // 
            // cmbSem
            // 
            cmbSem.Font = new Font("Libre Franklin", 11.0999994F);
            cmbSem.FormattingEnabled = true;
            cmbSem.Items.AddRange(new object[] { "FIRST", "SECOND", "SUMMER" });
            cmbSem.Location = new Point(155, 135);
            cmbSem.Margin = new Padding(4);
            cmbSem.Name = "cmbSem";
            cmbSem.Size = new Size(100, 30);
            cmbSem.TabIndex = 30;
            cmbSem.Text = "FIRST";
            // 
            // cmbSY
            // 
            cmbSY.Font = new Font("Libre Franklin", 11.0999994F);
            cmbSY.FormattingEnabled = true;
            cmbSY.Location = new Point(28, 135);
            cmbSY.Margin = new Padding(4);
            cmbSY.Name = "cmbSY";
            cmbSY.Size = new Size(105, 30);
            cmbSY.TabIndex = 29;
            cmbSY.Text = "2023-2024";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Libre Franklin", 9.900001F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(151, 112);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(72, 19);
            label1.TabIndex = 32;
            label1.Text = "Semester";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Libre Franklin", 9.900001F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(25, 113);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(85, 19);
            label5.TabIndex = 31;
            label5.Text = "School Year";
            // 
            // flpTaskList
            // 
            flpTaskList.AutoScroll = true;
            flpTaskList.Controls.Add(pnlTask);
            flpTaskList.Location = new Point(3, 240);
            flpTaskList.Name = "flpTaskList";
            flpTaskList.Size = new Size(702, 570);
            flpTaskList.TabIndex = 33;
            // 
            // SubjectListSection
            // 
            SubjectListSection.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            SubjectListSection.BorderStyle = BorderStyle.None;
            SubjectListSection.Font = new Font("Libre Franklin", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SubjectListSection.FormattingEnabled = true;
            SubjectListSection.ItemHeight = 22;
            SubjectListSection.Location = new Point(274, 136);
            SubjectListSection.Name = "SubjectListSection";
            SubjectListSection.Size = new Size(168, 110);
            SubjectListSection.TabIndex = 34;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Libre Franklin", 9.900001F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(296, 92);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(127, 19);
            label2.TabIndex = 35;
            label2.Text = "Select one subject";
            // 
            // SectionList
            // 
            SectionList.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            SectionList.BorderStyle = BorderStyle.None;
            SectionList.Font = new Font("Libre Franklin", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SectionList.FormattingEnabled = true;
            SectionList.ItemHeight = 22;
            SectionList.Location = new Point(465, 136);
            SectionList.Name = "SectionList";
            SectionList.Size = new Size(167, 110);
            SectionList.TabIndex = 36;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Libre Franklin", 9.900001F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(485, 92);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(127, 19);
            label3.TabIndex = 37;
            label3.Text = "Select one section";
            // 
            // addTask_Popup2
            // 
            addTask_Popup2.BackColor = Color.FromArgb(66, 100, 208);
            addTask_Popup2.Font = new Font("Libre Franklin", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addTask_Popup2.Location = new Point(339, 240);
            addTask_Popup2.Name = "addTask_Popup2";
            addTask_Popup2.Size = new Size(605, 458);
            addTask_Popup2.TabIndex = 6;
            // 
            // pbRefreshButton
            // 
            pbRefreshButton.BackColor = Color.Transparent;
            pbRefreshButton.BackgroundImage = Properties.Resources.refreshbutton;
            pbRefreshButton.BackgroundImageLayout = ImageLayout.Zoom;
            pbRefreshButton.Location = new Point(181, 184);
            pbRefreshButton.Name = "pbRefreshButton";
            pbRefreshButton.Size = new Size(42, 36);
            pbRefreshButton.TabIndex = 38;
            pbRefreshButton.TabStop = false;
            pbRefreshButton.Click += pbRefreshButton_click;
            // 
            // dgvTask
            // 
            dgvTask.AllowUserToAddRows = false;
            dgvTask.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.Padding = new Padding(15);
            dgvTask.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvTask.BackgroundColor = Color.FromArgb(223, 227, 242);
            dgvTask.BorderStyle = BorderStyle.None;
            dgvTask.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTask.GridColor = Color.FromArgb(113, 139, 220);
            dgvTask.Location = new Point(748, 298);
            dgvTask.Name = "dgvTask";
            dgvTask.Size = new Size(514, 353);
            dgvTask.TabIndex = 39;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Libre Franklin SemiBold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(792, 253);
            label6.Name = "label6";
            label6.Size = new Size(221, 39);
            label6.TabIndex = 24;
            label6.Text = "Submission List";
            // 
            // Task
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 227, 242);
            Controls.Add(pbRefreshButton);
            Controls.Add(label3);
            Controls.Add(addTask_Popup2);
            Controls.Add(SectionList);
            Controls.Add(label2);
            Controls.Add(SubjectListSection);
            Controls.Add(flpTaskList);
            Controls.Add(cmbSem);
            Controls.Add(cmbSY);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(pbDeleteButton);
            Controls.Add(pbAddButton);
            Controls.Add(panel2);
            Controls.Add(label4);
            Controls.Add(lblNoActYet);
            Controls.Add(dgvTask);
            Controls.Add(label6);
            Font = new Font("Libre Franklin", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Task";
            Size = new Size(1279, 856);
            Load += Task_Load;
            pnlTask.ResumeLayout(false);
            pnlTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlSat.ResumeLayout(false);
            pnlSat.PerformLayout();
            pnlFri.ResumeLayout(false);
            pnlFri.PerformLayout();
            pnlThu.ResumeLayout(false);
            pnlThu.PerformLayout();
            pnlWed.ResumeLayout(false);
            pnlWed.PerformLayout();
            pnlTue.ResumeLayout(false);
            pnlTue.PerformLayout();
            pnlMon.ResumeLayout(false);
            pnlMon.PerformLayout();
            pnlSun.ResumeLayout(false);
            pnlSun.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbAddButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDeleteButton).EndInit();
            flpTaskList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbRefreshButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTask).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private Panel pnlTask;
        private Label lblDateSubmi;
        private Label lblTaskDesc;
        private Label lblTaskTitle;
        private Label lblSection;
        private Label lblSY;
        private PictureBox pictureBox1;
        private Panel pnlSat;
        private Label lblSatD;
        private Label lblSat;
        private Panel pnlFri;
        private Label lblFriD;
        private Label lblFri;
        private Panel pnlThu;
        private Label lblThuD;
        private Label lblThu;
        private Panel pnlWed;
        private Label lblWedD;
        private Label lblWed;
        private Panel pnlTue;
        private Label lblTueD;
        private Label lblTue;
        private Panel pnlMon;
        private Label lblMonD;
        private Label lblMon;
        private Panel pnlSun;
        private Label lblSunD;
        private Label lblSun;
        private Panel panel2;
        private Label lblDate;
        private PictureBox pbAddButton;
        private Label lblNoActYet;
        private AddTask_Popup addTask_Popup1;
        private PictureBox pbDeleteButton;
        private ComboBox cmbSem;
        private ComboBox cmbSY;
        private Label label1;
        private Label label5;
        private FlowLayoutPanel flpTaskList;
        private ListBox SubjectListSection;
        private Label label2;
        private ListBox SectionList;
        private Label label3;
        private AddTask_Popup addTask_Popup2;
        private PictureBox pbRefreshButton;
        private DataGridView dgvTask;
        private Label label6;
    }
}
