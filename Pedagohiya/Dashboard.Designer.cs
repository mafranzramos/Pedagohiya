namespace Pedagohiya
{
    partial class Dashboard
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
            cmbSY = new ComboBox();
            cmbSem = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            pnlProfile = new Panel();
            lblSY = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            lblEmail = new Label();
            lblSemester = new Label();
            label4 = new Label();
            lblName = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            pnlCalendar = new Panel();
            lblSubmiTask3 = new Label();
            lblSubmiTask2 = new Label();
            lblSubmiTask1 = new Label();
            lblSubmiDate3 = new Label();
            label13 = new Label();
            label12 = new Label();
            lblSubmiDate2 = new Label();
            lblSubmiDate1 = new Label();
            label5 = new Label();
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
            label19 = new Label();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            lblDateDisplay = new Label();
            pictureBox3 = new PictureBox();
            lblGreetTwo = new Label();
            lblGreet = new Label();
            pnlTotalSub = new Panel();
            label18 = new Label();
            label20 = new Label();
            lblTotalSub = new Label();
            pnlTotalSect = new Panel();
            label22 = new Label();
            label21 = new Label();
            lblTotalSect = new Label();
            pnlTotalStud = new Panel();
            label24 = new Label();
            label23 = new Label();
            lblTotalStud = new Label();
            pnlProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlCalendar.SuspendLayout();
            pnlSat.SuspendLayout();
            pnlFri.SuspendLayout();
            pnlThu.SuspendLayout();
            pnlWed.SuspendLayout();
            pnlTue.SuspendLayout();
            pnlMon.SuspendLayout();
            pnlSun.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            pnlTotalSub.SuspendLayout();
            pnlTotalSect.SuspendLayout();
            pnlTotalStud.SuspendLayout();
            SuspendLayout();
            // 
            // cmbSY
            // 
            cmbSY.Font = new Font("Libre Franklin", 11.0999994F);
            cmbSY.Location = new Point(39, 58);
            cmbSY.Margin = new Padding(4);
            cmbSY.Name = "cmbSY";
            cmbSY.Size = new Size(242, 30);
            cmbSY.TabIndex = 0;
            cmbSY.Text = "2023-2024";
            cmbSY.SelectedIndexChanged += Cmb_SelectedIndexChanged;
            // 
            // cmbSem
            // 
            cmbSem.Font = new Font("Libre Franklin", 11.0999994F);
            cmbSem.Items.AddRange(new object[] { "FIRST", "SECOND", "SUMMER" });
            cmbSem.Location = new Point(313, 58);
            cmbSem.Margin = new Padding(4);
            cmbSem.Name = "cmbSem";
            cmbSem.Size = new Size(248, 30);
            cmbSem.TabIndex = 1;
            cmbSem.Text = "FIRST";
            cmbSem.SelectedIndexChanged += Cmb_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Libre Franklin", 9.900001F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(36, 36);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(85, 19);
            label1.TabIndex = 2;
            label1.Text = "School Year";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Libre Franklin", 9.900001F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(309, 35);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(72, 19);
            label2.TabIndex = 3;
            label2.Text = "Semester";
            // 
            // pnlProfile
            // 
            pnlProfile.BackgroundImage = Properties.Resources.dbwhite_11;
            pnlProfile.BackgroundImageLayout = ImageLayout.Zoom;
            pnlProfile.Controls.Add(lblSY);
            pnlProfile.Controls.Add(label10);
            pnlProfile.Controls.Add(label9);
            pnlProfile.Controls.Add(label8);
            pnlProfile.Controls.Add(label7);
            pnlProfile.Controls.Add(lblEmail);
            pnlProfile.Controls.Add(lblSemester);
            pnlProfile.Controls.Add(label4);
            pnlProfile.Controls.Add(lblName);
            pnlProfile.Controls.Add(label3);
            pnlProfile.Controls.Add(pictureBox1);
            pnlProfile.Location = new Point(782, -7);
            pnlProfile.Name = "pnlProfile";
            pnlProfile.Size = new Size(514, 387);
            pnlProfile.TabIndex = 4;
            // 
            // lblSY
            // 
            lblSY.AutoSize = true;
            lblSY.BackColor = Color.Transparent;
            lblSY.Font = new Font("Libre Franklin", 11.2499981F);
            lblSY.ForeColor = Color.DimGray;
            lblSY.Location = new Point(230, 222);
            lblSY.Name = "lblSY";
            lblSY.Size = new Size(81, 22);
            lblSY.TabIndex = 15;
            lblSY.Text = "Semester";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Libre Franklin", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Gray;
            label10.Location = new Point(330, 284);
            label10.Name = "label10";
            label10.Size = new Size(54, 17);
            label10.TabIndex = 14;
            label10.Text = "Campus";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Libre Franklin", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Gray;
            label9.Location = new Point(105, 286);
            label9.Name = "label9";
            label9.Size = new Size(78, 17);
            label9.TabIndex = 13;
            label9.Text = "Department";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Libre Franklin", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(282, 305);
            label8.Name = "label8";
            label8.Size = new Size(155, 36);
            label8.TabIndex = 12;
            label8.Text = "Main II\r\nAlangilan, Batangas City";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Libre Franklin", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(67, 307);
            label7.Name = "label7";
            label7.Size = new Size(162, 36);
            label7.TabIndex = 11;
            label7.Text = "College of Informatics\r\nand Computing Sciences";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Libre Franklin", 11.2499981F);
            lblEmail.ForeColor = Color.DimGray;
            lblEmail.Location = new Point(230, 178);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 22);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "Email";
            // 
            // lblSemester
            // 
            lblSemester.AutoSize = true;
            lblSemester.BackColor = Color.Transparent;
            lblSemester.Font = new Font("Libre Franklin", 11.2499981F);
            lblSemester.ForeColor = Color.DimGray;
            lblSemester.Location = new Point(230, 200);
            lblSemester.Name = "lblSemester";
            lblSemester.Size = new Size(81, 22);
            lblSemester.TabIndex = 9;
            lblSemester.Text = "Semester";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Libre Franklin", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(230, 160);
            label4.Name = "label4";
            label4.Size = new Size(169, 18);
            label4.TabIndex = 8;
            label4.Text = "ASSOCIATE PROFESSOR I";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Libre Franklin Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.Black;
            lblName.Location = new Point(230, 129);
            lblName.Name = "lblName";
            lblName.Size = new Size(68, 27);
            lblName.TabIndex = 7;
            lblName.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(66, 100, 208);
            label3.Font = new Font("Libre Franklin", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(67, 39);
            label3.Name = "label3";
            label3.Size = new Size(102, 27);
            label3.TabIndex = 6;
            label3.Text = "My Profile";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.dash_topbg1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(20, -32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(467, 189);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pnlCalendar
            // 
            pnlCalendar.BackgroundImage = Properties.Resources.dbwhite_11;
            pnlCalendar.BackgroundImageLayout = ImageLayout.Zoom;
            pnlCalendar.Controls.Add(lblSubmiTask3);
            pnlCalendar.Controls.Add(lblSubmiTask2);
            pnlCalendar.Controls.Add(lblSubmiTask1);
            pnlCalendar.Controls.Add(lblSubmiDate3);
            pnlCalendar.Controls.Add(label13);
            pnlCalendar.Controls.Add(label12);
            pnlCalendar.Controls.Add(lblSubmiDate2);
            pnlCalendar.Controls.Add(lblSubmiDate1);
            pnlCalendar.Controls.Add(label5);
            pnlCalendar.Controls.Add(pnlSat);
            pnlCalendar.Controls.Add(pnlFri);
            pnlCalendar.Controls.Add(pnlThu);
            pnlCalendar.Controls.Add(pnlWed);
            pnlCalendar.Controls.Add(pnlTue);
            pnlCalendar.Controls.Add(pnlMon);
            pnlCalendar.Controls.Add(pnlSun);
            pnlCalendar.Controls.Add(label19);
            pnlCalendar.Controls.Add(pictureBox2);
            pnlCalendar.Location = new Point(789, 367);
            pnlCalendar.Name = "pnlCalendar";
            pnlCalendar.Size = new Size(503, 449);
            pnlCalendar.TabIndex = 15;
            // 
            // lblSubmiTask3
            // 
            lblSubmiTask3.AutoSize = true;
            lblSubmiTask3.BackColor = Color.Transparent;
            lblSubmiTask3.Font = new Font("Libre Franklin", 11.2499981F);
            lblSubmiTask3.ForeColor = Color.Black;
            lblSubmiTask3.Location = new Point(214, 366);
            lblSubmiTask3.Name = "lblSubmiTask3";
            lblSubmiTask3.Size = new Size(99, 22);
            lblSubmiTask3.TabIndex = 23;
            lblSubmiTask3.Text = "SubmiTask3";
            // 
            // lblSubmiTask2
            // 
            lblSubmiTask2.AutoSize = true;
            lblSubmiTask2.BackColor = Color.Transparent;
            lblSubmiTask2.Font = new Font("Libre Franklin", 11.2499981F);
            lblSubmiTask2.ForeColor = Color.Black;
            lblSubmiTask2.Location = new Point(214, 308);
            lblSubmiTask2.Name = "lblSubmiTask2";
            lblSubmiTask2.Size = new Size(98, 22);
            lblSubmiTask2.TabIndex = 22;
            lblSubmiTask2.Text = "SubmiTask2";
            // 
            // lblSubmiTask1
            // 
            lblSubmiTask1.AutoSize = true;
            lblSubmiTask1.BackColor = Color.Transparent;
            lblSubmiTask1.Font = new Font("Libre Franklin", 11.2499981F);
            lblSubmiTask1.ForeColor = Color.Black;
            lblSubmiTask1.Location = new Point(214, 250);
            lblSubmiTask1.Name = "lblSubmiTask1";
            lblSubmiTask1.Size = new Size(96, 22);
            lblSubmiTask1.TabIndex = 21;
            lblSubmiTask1.Text = "SubmiTask1";
            lblSubmiTask1.Click += SubmiTask1_Click;
            // 
            // lblSubmiDate3
            // 
            lblSubmiDate3.AutoSize = true;
            lblSubmiDate3.BackColor = Color.Transparent;
            lblSubmiDate3.Font = new Font("Libre Franklin", 11.2499981F);
            lblSubmiDate3.ForeColor = Color.Black;
            lblSubmiDate3.Location = new Point(45, 366);
            lblSubmiDate3.Name = "lblSubmiDate3";
            lblSubmiDate3.Size = new Size(100, 22);
            lblSubmiDate3.TabIndex = 20;
            lblSubmiDate3.Text = "SubmiDate3";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.ForeColor = SystemColors.ControlDark;
            label13.Location = new Point(41, 334);
            label13.Name = "label13";
            label13.Size = new Size(406, 22);
            label13.TabIndex = 19;
            label13.Text = "------------------------------------------------------------------";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.ForeColor = SystemColors.ControlDark;
            label12.Location = new Point(41, 275);
            label12.Name = "label12";
            label12.Size = new Size(406, 22);
            label12.TabIndex = 18;
            label12.Text = "------------------------------------------------------------------";
            // 
            // lblSubmiDate2
            // 
            lblSubmiDate2.AutoSize = true;
            lblSubmiDate2.BackColor = Color.Transparent;
            lblSubmiDate2.Font = new Font("Libre Franklin", 11.2499981F);
            lblSubmiDate2.ForeColor = Color.Black;
            lblSubmiDate2.Location = new Point(45, 308);
            lblSubmiDate2.Name = "lblSubmiDate2";
            lblSubmiDate2.Size = new Size(99, 22);
            lblSubmiDate2.TabIndex = 17;
            lblSubmiDate2.Text = "SubmiDate2";
            // 
            // lblSubmiDate1
            // 
            lblSubmiDate1.AutoSize = true;
            lblSubmiDate1.BackColor = Color.Transparent;
            lblSubmiDate1.Font = new Font("Libre Franklin", 11.2499981F);
            lblSubmiDate1.ForeColor = Color.Black;
            lblSubmiDate1.Location = new Point(45, 250);
            lblSubmiDate1.Name = "lblSubmiDate1";
            lblSubmiDate1.Size = new Size(97, 22);
            lblSubmiDate1.TabIndex = 11;
            lblSubmiDate1.Text = "SubmiDate1";
            lblSubmiDate1.Click += SubmiDate1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(41, 214);
            label5.Name = "label5";
            label5.Size = new Size(406, 22);
            label5.TabIndex = 16;
            label5.Text = "------------------------------------------------------------------";
            // 
            // pnlSat
            // 
            pnlSat.BackColor = Color.White;
            pnlSat.Controls.Add(lblSatD);
            pnlSat.Controls.Add(lblSat);
            pnlSat.Location = new Point(409, 126);
            pnlSat.Name = "pnlSat";
            pnlSat.Size = new Size(45, 70);
            pnlSat.TabIndex = 15;
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
            pnlFri.BackColor = Color.White;
            pnlFri.Controls.Add(lblFriD);
            pnlFri.Controls.Add(lblFri);
            pnlFri.Location = new Point(349, 126);
            pnlFri.Name = "pnlFri";
            pnlFri.Size = new Size(45, 70);
            pnlFri.TabIndex = 14;
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
            pnlThu.BackColor = Color.White;
            pnlThu.Controls.Add(lblThuD);
            pnlThu.Controls.Add(lblThu);
            pnlThu.Location = new Point(287, 126);
            pnlThu.Name = "pnlThu";
            pnlThu.Size = new Size(45, 70);
            pnlThu.TabIndex = 13;
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
            pnlWed.BackColor = Color.White;
            pnlWed.Controls.Add(lblWedD);
            pnlWed.Controls.Add(lblWed);
            pnlWed.Location = new Point(226, 126);
            pnlWed.Name = "pnlWed";
            pnlWed.Size = new Size(45, 70);
            pnlWed.TabIndex = 12;
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
            pnlTue.BackColor = Color.White;
            pnlTue.Controls.Add(lblTueD);
            pnlTue.Controls.Add(lblTue);
            pnlTue.Location = new Point(162, 126);
            pnlTue.Name = "pnlTue";
            pnlTue.Size = new Size(45, 70);
            pnlTue.TabIndex = 11;
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
            pnlMon.BackColor = Color.White;
            pnlMon.Controls.Add(lblMonD);
            pnlMon.Controls.Add(lblMon);
            pnlMon.Location = new Point(96, 126);
            pnlMon.Name = "pnlMon";
            pnlMon.Size = new Size(45, 70);
            pnlMon.TabIndex = 11;
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
            pnlSun.BackColor = Color.White;
            pnlSun.Controls.Add(lblSunD);
            pnlSun.Controls.Add(lblSun);
            pnlSun.Location = new Point(32, 126);
            pnlSun.Name = "pnlSun";
            pnlSun.Size = new Size(45, 70);
            pnlSun.TabIndex = 10;
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
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.FromArgb(66, 100, 208);
            label19.Font = new Font("Libre Franklin", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.White;
            label19.Location = new Point(44, 48);
            label19.Name = "label19";
            label19.Size = new Size(121, 27);
            label19.TabIndex = 6;
            label19.Text = "My Calendar";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.dash_topbg1;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(0, -32);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(504, 204);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.dashbg_3;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(lblDateDisplay);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(lblGreetTwo);
            panel1.Controls.Add(lblGreet);
            panel1.Location = new Point(10, 81);
            panel1.Name = "panel1";
            panel1.Size = new Size(797, 258);
            panel1.TabIndex = 16;
            // 
            // lblDateDisplay
            // 
            lblDateDisplay.AutoSize = true;
            lblDateDisplay.BackColor = Color.FromArgb(114, 141, 228);
            lblDateDisplay.Font = new Font("Libre Franklin", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDateDisplay.ForeColor = Color.White;
            lblDateDisplay.Location = new Point(57, 53);
            lblDateDisplay.Name = "lblDateDisplay";
            lblDateDisplay.Size = new Size(90, 22);
            lblDateDisplay.TabIndex = 26;
            lblDateDisplay.Text = "Have a nice";
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.dashlightvv_2;
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(17, 35);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(249, 65);
            pictureBox3.TabIndex = 25;
            pictureBox3.TabStop = false;
            // 
            // lblGreetTwo
            // 
            lblGreetTwo.AutoSize = true;
            lblGreetTwo.BackColor = Color.Transparent;
            lblGreetTwo.Font = new Font("Libre Franklin", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGreetTwo.ForeColor = Color.White;
            lblGreetTwo.Location = new Point(50, 186);
            lblGreetTwo.Name = "lblGreetTwo";
            lblGreetTwo.Size = new Size(95, 23);
            lblGreetTwo.TabIndex = 24;
            lblGreetTwo.Text = "Have a nice";
            // 
            // lblGreet
            // 
            lblGreet.AutoSize = true;
            lblGreet.Font = new Font("Libre Franklin", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGreet.ForeColor = Color.White;
            lblGreet.Location = new Point(47, 151);
            lblGreet.Name = "lblGreet";
            lblGreet.Size = new Size(92, 39);
            lblGreet.TabIndex = 0;
            lblGreet.Text = "Greet";
            // 
            // pnlTotalSub
            // 
            pnlTotalSub.BackgroundImage = Properties.Resources.dbwhite_11;
            pnlTotalSub.BackgroundImageLayout = ImageLayout.Zoom;
            pnlTotalSub.Controls.Add(label18);
            pnlTotalSub.Controls.Add(label20);
            pnlTotalSub.Controls.Add(lblTotalSub);
            pnlTotalSub.Location = new Point(29, 327);
            pnlTotalSub.Name = "pnlTotalSub";
            pnlTotalSub.Size = new Size(231, 197);
            pnlTotalSub.TabIndex = 17;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.Transparent;
            label18.Font = new Font("Libre Franklin", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.Gray;
            label18.Location = new Point(17, 25);
            label18.Name = "label18";
            label18.Size = new Size(111, 22);
            label18.TabIndex = 29;
            label18.Text = "Total Subjects";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = Color.Transparent;
            label20.Font = new Font("Libre Franklin", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.Black;
            label20.Location = new Point(117, 112);
            label20.Name = "label20";
            label20.Size = new Size(71, 22);
            label20.TabIndex = 28;
            label20.Text = "subjects";
            // 
            // lblTotalSub
            // 
            lblTotalSub.AutoSize = true;
            lblTotalSub.BackColor = Color.Transparent;
            lblTotalSub.Font = new Font("Libre Franklin", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalSub.ForeColor = Color.Black;
            lblTotalSub.Location = new Point(133, 73);
            lblTotalSub.Name = "lblTotalSub";
            lblTotalSub.Size = new Size(36, 39);
            lblTotalSub.TabIndex = 27;
            lblTotalSub.Text = "0";
            // 
            // pnlTotalSect
            // 
            pnlTotalSect.BackgroundImage = Properties.Resources.dbwhite_11;
            pnlTotalSect.BackgroundImageLayout = ImageLayout.Zoom;
            pnlTotalSect.Controls.Add(label22);
            pnlTotalSect.Controls.Add(label21);
            pnlTotalSect.Controls.Add(lblTotalSect);
            pnlTotalSect.Location = new Point(286, 327);
            pnlTotalSect.Name = "pnlTotalSect";
            pnlTotalSect.Size = new Size(231, 197);
            pnlTotalSect.TabIndex = 18;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = Color.Transparent;
            label22.Font = new Font("Libre Franklin", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label22.ForeColor = Color.Gray;
            label22.Location = new Point(18, 25);
            label22.Name = "label22";
            label22.Size = new Size(111, 22);
            label22.TabIndex = 30;
            label22.Text = "Total Sections";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = Color.Transparent;
            label21.Font = new Font("Libre Franklin", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label21.ForeColor = Color.Black;
            label21.Location = new Point(136, 112);
            label21.Name = "label21";
            label21.Size = new Size(71, 22);
            label21.TabIndex = 30;
            label21.Text = "sections";
            // 
            // lblTotalSect
            // 
            lblTotalSect.AutoSize = true;
            lblTotalSect.BackColor = Color.Transparent;
            lblTotalSect.Font = new Font("Libre Franklin", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalSect.ForeColor = Color.Black;
            lblTotalSect.Location = new Point(151, 73);
            lblTotalSect.Name = "lblTotalSect";
            lblTotalSect.Size = new Size(36, 39);
            lblTotalSect.TabIndex = 29;
            lblTotalSect.Text = "0";
            // 
            // pnlTotalStud
            // 
            pnlTotalStud.BackgroundImage = Properties.Resources.dbwhite_11;
            pnlTotalStud.BackgroundImageLayout = ImageLayout.Zoom;
            pnlTotalStud.Controls.Add(label24);
            pnlTotalStud.Controls.Add(label23);
            pnlTotalStud.Controls.Add(lblTotalStud);
            pnlTotalStud.Location = new Point(541, 327);
            pnlTotalStud.Name = "pnlTotalStud";
            pnlTotalStud.Size = new Size(231, 197);
            pnlTotalStud.TabIndex = 18;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.BackColor = Color.Transparent;
            label24.Font = new Font("Libre Franklin", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label24.ForeColor = Color.Gray;
            label24.Location = new Point(22, 25);
            label24.Name = "label24";
            label24.Size = new Size(114, 22);
            label24.TabIndex = 31;
            label24.Text = "Total Students";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.BackColor = Color.Transparent;
            label23.Font = new Font("Libre Franklin", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label23.ForeColor = Color.Black;
            label23.Location = new Point(133, 112);
            label23.Name = "label23";
            label23.Size = new Size(74, 22);
            label23.TabIndex = 32;
            label23.Text = "students";
            // 
            // lblTotalStud
            // 
            lblTotalStud.AutoSize = true;
            lblTotalStud.BackColor = Color.Transparent;
            lblTotalStud.Font = new Font("Libre Franklin", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalStud.ForeColor = Color.Black;
            lblTotalStud.Location = new Point(149, 73);
            lblTotalStud.Name = "lblTotalStud";
            lblTotalStud.Size = new Size(36, 39);
            lblTotalStud.TabIndex = 31;
            lblTotalStud.Text = "0";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(9F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 227, 242);
            BackgroundImageLayout = ImageLayout.Zoom;
            Controls.Add(pnlTotalStud);
            Controls.Add(pnlTotalSect);
            Controls.Add(pnlTotalSub);
            Controls.Add(cmbSem);
            Controls.Add(cmbSY);
            Controls.Add(panel1);
            Controls.Add(pnlCalendar);
            Controls.Add(pnlProfile);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Font = new Font("Libre Franklin", 11.0999994F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(9, 10, 9, 10);
            Name = "Dashboard";
            Size = new Size(1279, 839);
            Load += dashboard_Load;
            pnlProfile.ResumeLayout(false);
            pnlProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlCalendar.ResumeLayout(false);
            pnlCalendar.PerformLayout();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            pnlTotalSub.ResumeLayout(false);
            pnlTotalSub.PerformLayout();
            pnlTotalSect.ResumeLayout(false);
            pnlTotalSect.PerformLayout();
            pnlTotalStud.ResumeLayout(false);
            pnlTotalStud.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbSY;
        private ComboBox cmbSem;
        private Label label1;
        private Label label2;
        private Panel pnlProfile;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private Label lblName;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label lblEmail;
        private Label lblSemester;
        private Panel pnlCalendar;
        private Label lblSubmiDate2;
        private Label lblSun;
        private Label label19;
        private PictureBox pictureBox2;
        private Panel pnlSun;
        private Label lblSunD;
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
        private Label label5;
        private Label label12;
        private Label lblSubmiDate1;
        private Label label13;
        private Label lblSubmiDate3;
        private Label lblSubmiTask3;
        private Label lblSubmiTask2;
        private Label lblSubmiTask1;
        private Panel panel1;
        private Label lblGreet;
        private Label lblGreetTwo;
        private PictureBox pictureBox3;
        private Label lblDateDisplay;
        private Panel pnlTotalSub;
        private Panel pnlTotalSect;
        private Panel pnlTotalStud;
        private Label label20;
        private Label lblTotalSub;
        private Label label21;
        private Label lblTotalSect;
        private Label label23;
        private Label lblTotalStud;
        private Label label18;
        private Label label22;
        private Label label24;
        private Label lblSY;
    }
}
