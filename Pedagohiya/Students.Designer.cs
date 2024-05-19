namespace Pedagohiya
{
    partial class Students
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Students));
            SubjectList = new ListBox();
            label3 = new Label();
            comboBoxSubject = new ComboBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            textBoxInput = new TextBox();
            checkBoxStudent = new CheckedListBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnPush = new Button();
            btnPull = new Button();
            tabControl3 = new TabControl();
            tabPage6 = new TabPage();
            labelSubjectName = new Label();
            labelNewName = new Label();
            btnDeleteSubject = new Button();
            btnAddSubject = new Button();
            textBoxSubject = new TextBox();
            label2 = new Label();
            tabPage5 = new TabPage();
            textBoxSection = new TextBox();
            btnEditSection = new Button();
            btnDeleteSection = new Button();
            btnAddSection = new Button();
            label1 = new Label();
            SectionList = new ListBox();
            label5 = new Label();
            SubjectListSection = new ListBox();
            label4 = new Label();
            tabPage4 = new TabPage();
            comboBoxSection = new ComboBox();
            btnDeleteTextTextBox = new Button();
            tabPage1 = new TabPage();
            StudentInfo_Panel = new Panel();
            panel1 = new Panel();
            Label_Name = new Label();
            Label_SRCode = new Label();
            Label_Section = new Label();
            Label_Subject = new Label();
            label6 = new Label();
            listBoxResult = new ListBox();
            textBoxSearch = new TextBox();
            SemesterComboBox = new ComboBox();
            SchoolYearComboBox = new ComboBox();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tabControl3.SuspendLayout();
            tabPage6.SuspendLayout();
            tabPage5.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage1.SuspendLayout();
            StudentInfo_Panel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // SubjectList
            // 
            SubjectList.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            SubjectList.FormattingEnabled = true;
            SubjectList.HorizontalScrollbar = true;
            SubjectList.ItemHeight = 32;
            SubjectList.Location = new Point(623, 104);
            SubjectList.Name = "SubjectList";
            SubjectList.SelectionMode = SelectionMode.None;
            SubjectList.Size = new Size(559, 452);
            SubjectList.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(10, 14);
            label3.Name = "label3";
            label3.Size = new Size(426, 50);
            label3.TabIndex = 6;
            label3.Text = "CLASS MANAGEMENT";
            // 
            // comboBoxSubject
            // 
            comboBoxSubject.BackColor = SystemColors.Window;
            comboBoxSubject.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxSubject.FormattingEnabled = true;
            comboBoxSubject.ImeMode = ImeMode.NoControl;
            comboBoxSubject.Location = new Point(18, 12);
            comboBoxSubject.Name = "comboBoxSubject";
            comboBoxSubject.Size = new Size(455, 38);
            comboBoxSubject.TabIndex = 15;
            comboBoxSubject.Text = "SUBJECT";
            comboBoxSubject.SelectedIndexChanged += comboBoxSubject_SelectedIndexChanged;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85.17398F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.8260212F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 527F));
            tableLayoutPanel2.Controls.Add(textBoxInput, 0, 1);
            tableLayoutPanel2.Controls.Add(checkBoxStudent, 2, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 1, 1);
            tableLayoutPanel2.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tableLayoutPanel2.Location = new Point(18, 60);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.2023811F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 87.79762F));
            tableLayoutPanel2.Size = new Size(1172, 503);
            tableLayoutPanel2.TabIndex = 16;
            // 
            // textBoxInput
            // 
            textBoxInput.BorderStyle = BorderStyle.FixedSingle;
            textBoxInput.Dock = DockStyle.Fill;
            textBoxInput.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxInput.Location = new Point(3, 64);
            textBoxInput.Multiline = true;
            textBoxInput.Name = "textBoxInput";
            textBoxInput.PlaceholderText = "SRCode, Last Name, First Name, Middle Name";
            textBoxInput.ScrollBars = ScrollBars.Both;
            textBoxInput.Size = new Size(543, 436);
            textBoxInput.TabIndex = 22;
            // 
            // checkBoxStudent
            // 
            checkBoxStudent.CheckOnClick = true;
            checkBoxStudent.Dock = DockStyle.Fill;
            checkBoxStudent.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxStudent.FormattingEnabled = true;
            checkBoxStudent.HorizontalScrollbar = true;
            checkBoxStudent.Location = new Point(647, 64);
            checkBoxStudent.Name = "checkBoxStudent";
            checkBoxStudent.ScrollAlwaysVisible = true;
            checkBoxStudent.Size = new Size(522, 436);
            checkBoxStudent.TabIndex = 25;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnPush, 0, 0);
            tableLayoutPanel1.Controls.Add(btnPull, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(552, 64);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(89, 436);
            tableLayoutPanel1.TabIndex = 26;
            // 
            // btnPush
            // 
            btnPush.BackColor = Color.Transparent;
            btnPush.BackgroundImageLayout = ImageLayout.None;
            btnPush.Dock = DockStyle.Fill;
            btnPush.FlatAppearance.BorderColor = Color.Black;
            btnPush.FlatAppearance.BorderSize = 0;
            btnPush.FlatStyle = FlatStyle.Flat;
            btnPush.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPush.Image = Properties.Resources.icons8_forward_26;
            btnPush.Location = new Point(10, 10);
            btnPush.Margin = new Padding(10);
            btnPush.Name = "btnPush";
            btnPush.Size = new Size(69, 198);
            btnPush.TabIndex = 23;
            btnPush.TextAlign = ContentAlignment.MiddleLeft;
            btnPush.UseVisualStyleBackColor = false;
            btnPush.Click += btnPush_Click;
            // 
            // btnPull
            // 
            btnPull.BackColor = Color.Transparent;
            btnPull.BackgroundImageLayout = ImageLayout.None;
            btnPull.Dock = DockStyle.Fill;
            btnPull.FlatAppearance.BorderColor = Color.Black;
            btnPull.FlatAppearance.BorderSize = 0;
            btnPull.FlatStyle = FlatStyle.Flat;
            btnPull.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPull.Image = (Image)resources.GetObject("btnPull.Image");
            btnPull.Location = new Point(10, 228);
            btnPull.Margin = new Padding(10);
            btnPull.Name = "btnPull";
            btnPull.Size = new Size(69, 198);
            btnPull.TabIndex = 24;
            btnPull.TextAlign = ContentAlignment.MiddleLeft;
            btnPull.UseVisualStyleBackColor = false;
            btnPull.Click += btnPull_Click;
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
            tabControl3.Location = new Point(22, 77);
            tabControl3.Multiline = true;
            tabControl3.Name = "tabControl3";
            tabControl3.Padding = new Point(5, 5);
            tabControl3.RightToLeft = RightToLeft.No;
            tabControl3.RightToLeftLayout = true;
            tabControl3.SelectedIndex = 0;
            tabControl3.Size = new Size(1229, 718);
            tabControl3.SizeMode = TabSizeMode.Fixed;
            tabControl3.TabIndex = 20;
            tabControl3.Click += Clicks;
            // 
            // tabPage6
            // 
            tabPage6.BackColor = Color.White;
            tabPage6.Controls.Add(labelSubjectName);
            tabPage6.Controls.Add(labelNewName);
            tabPage6.Controls.Add(btnDeleteSubject);
            tabPage6.Controls.Add(btnAddSubject);
            tabPage6.Controls.Add(textBoxSubject);
            tabPage6.Controls.Add(SubjectList);
            tabPage6.Controls.Add(label2);
            tabPage6.Location = new Point(4, 54);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(1221, 660);
            tabPage6.TabIndex = 2;
            tabPage6.Text = "Subject Actions";
            // 
            // labelSubjectName
            // 
            labelSubjectName.AutoSize = true;
            labelSubjectName.Font = new Font("Segoe UI Black", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSubjectName.ForeColor = Color.Black;
            labelSubjectName.Location = new Point(79, 132);
            labelSubjectName.Name = "labelSubjectName";
            labelSubjectName.Size = new Size(448, 50);
            labelSubjectName.TabIndex = 11;
            labelSubjectName.Text = "ENTER SUBJECT NAME:";
            // 
            // labelNewName
            // 
            labelNewName.AutoSize = true;
            labelNewName.Font = new Font("Segoe UI Black", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNewName.ForeColor = Color.Black;
            labelNewName.Location = new Point(110, 132);
            labelNewName.Name = "labelNewName";
            labelNewName.Size = new Size(377, 50);
            labelNewName.TabIndex = 12;
            labelNewName.Text = "ENTER NEW NAME:";
            labelNewName.TextAlign = ContentAlignment.MiddleCenter;
            labelNewName.Visible = false;
            // 
            // btnDeleteSubject
            // 
            btnDeleteSubject.BackColor = Color.White;
            btnDeleteSubject.BackgroundImageLayout = ImageLayout.None;
            btnDeleteSubject.FlatAppearance.BorderColor = Color.Black;
            btnDeleteSubject.FlatAppearance.BorderSize = 3;
            btnDeleteSubject.FlatStyle = FlatStyle.Flat;
            btnDeleteSubject.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteSubject.Image = Properties.Resources.delete;
            btnDeleteSubject.ImageAlign = ContentAlignment.MiddleLeft;
            btnDeleteSubject.Location = new Point(156, 340);
            btnDeleteSubject.Margin = new Padding(10);
            btnDeleteSubject.Name = "btnDeleteSubject";
            btnDeleteSubject.Padding = new Padding(16);
            btnDeleteSubject.Size = new Size(299, 83);
            btnDeleteSubject.TabIndex = 15;
            btnDeleteSubject.Text = "        Delete Subject";
            btnDeleteSubject.TextAlign = ContentAlignment.MiddleLeft;
            btnDeleteSubject.UseVisualStyleBackColor = false;
            btnDeleteSubject.Click += btnDeleteSubject_Click;
            // 
            // btnAddSubject
            // 
            btnAddSubject.BackColor = Color.White;
            btnAddSubject.BackgroundImageLayout = ImageLayout.None;
            btnAddSubject.FlatAppearance.BorderColor = Color.Black;
            btnAddSubject.FlatAppearance.BorderSize = 3;
            btnAddSubject.FlatStyle = FlatStyle.Flat;
            btnAddSubject.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddSubject.Image = Properties.Resources.plus;
            btnAddSubject.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddSubject.Location = new Point(156, 237);
            btnAddSubject.Margin = new Padding(10);
            btnAddSubject.Name = "btnAddSubject";
            btnAddSubject.Padding = new Padding(16);
            btnAddSubject.Size = new Size(299, 83);
            btnAddSubject.TabIndex = 14;
            btnAddSubject.Text = "        Add Subject";
            btnAddSubject.TextAlign = ContentAlignment.MiddleLeft;
            btnAddSubject.UseVisualStyleBackColor = false;
            btnAddSubject.Click += btnAddSubject_Click;
            // 
            // textBoxSubject
            // 
            textBoxSubject.BorderStyle = BorderStyle.FixedSingle;
            textBoxSubject.Cursor = Cursors.IBeam;
            textBoxSubject.Location = new Point(107, 185);
            textBoxSubject.Name = "textBoxSubject";
            textBoxSubject.Size = new Size(383, 39);
            textBoxSubject.TabIndex = 12;
            textBoxSubject.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(765, 36);
            label2.Name = "label2";
            label2.Size = new Size(307, 50);
            label2.TabIndex = 8;
            label2.Text = "Your Subjects :)";
            // 
            // tabPage5
            // 
            tabPage5.BackColor = Color.White;
            tabPage5.Controls.Add(textBoxSection);
            tabPage5.Controls.Add(btnEditSection);
            tabPage5.Controls.Add(btnDeleteSection);
            tabPage5.Controls.Add(btnAddSection);
            tabPage5.Controls.Add(label1);
            tabPage5.Controls.Add(SectionList);
            tabPage5.Controls.Add(label5);
            tabPage5.Controls.Add(SubjectListSection);
            tabPage5.Controls.Add(label4);
            tabPage5.Location = new Point(4, 54);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(1221, 660);
            tabPage5.TabIndex = 1;
            tabPage5.Text = "Section Actions";
            // 
            // textBoxSection
            // 
            textBoxSection.BorderStyle = BorderStyle.FixedSingle;
            textBoxSection.Cursor = Cursors.IBeam;
            textBoxSection.Location = new Point(107, 185);
            textBoxSection.Name = "textBoxSection";
            textBoxSection.Size = new Size(383, 39);
            textBoxSection.TabIndex = 18;
            textBoxSection.TextAlign = HorizontalAlignment.Center;
            // 
            // btnEditSection
            // 
            btnEditSection.BackColor = Color.White;
            btnEditSection.BackgroundImageLayout = ImageLayout.None;
            btnEditSection.FlatAppearance.BorderColor = Color.Black;
            btnEditSection.FlatAppearance.BorderSize = 3;
            btnEditSection.FlatStyle = FlatStyle.Flat;
            btnEditSection.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditSection.Image = Properties.Resources.edit;
            btnEditSection.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditSection.Location = new Point(156, 443);
            btnEditSection.Margin = new Padding(10);
            btnEditSection.Name = "btnEditSection";
            btnEditSection.Padding = new Padding(16);
            btnEditSection.Size = new Size(299, 83);
            btnEditSection.TabIndex = 17;
            btnEditSection.Text = "        Edit Section Name";
            btnEditSection.TextAlign = ContentAlignment.MiddleLeft;
            btnEditSection.UseVisualStyleBackColor = false;
            btnEditSection.Visible = false;
            btnEditSection.Click += btnEditSection_Click;
            // 
            // btnDeleteSection
            // 
            btnDeleteSection.BackColor = Color.White;
            btnDeleteSection.BackgroundImageLayout = ImageLayout.None;
            btnDeleteSection.FlatAppearance.BorderColor = Color.Black;
            btnDeleteSection.FlatAppearance.BorderSize = 3;
            btnDeleteSection.FlatStyle = FlatStyle.Flat;
            btnDeleteSection.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteSection.Image = Properties.Resources.delete;
            btnDeleteSection.ImageAlign = ContentAlignment.MiddleLeft;
            btnDeleteSection.Location = new Point(156, 340);
            btnDeleteSection.Margin = new Padding(10);
            btnDeleteSection.Name = "btnDeleteSection";
            btnDeleteSection.Padding = new Padding(16);
            btnDeleteSection.Size = new Size(299, 83);
            btnDeleteSection.TabIndex = 16;
            btnDeleteSection.Text = "        Delete Section";
            btnDeleteSection.TextAlign = ContentAlignment.MiddleLeft;
            btnDeleteSection.UseVisualStyleBackColor = false;
            btnDeleteSection.Click += btnDeleteSection_Click;
            // 
            // btnAddSection
            // 
            btnAddSection.BackColor = Color.White;
            btnAddSection.BackgroundImageLayout = ImageLayout.None;
            btnAddSection.FlatAppearance.BorderColor = Color.Black;
            btnAddSection.FlatAppearance.BorderSize = 3;
            btnAddSection.FlatStyle = FlatStyle.Flat;
            btnAddSection.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddSection.Image = Properties.Resources.plus;
            btnAddSection.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddSection.Location = new Point(156, 237);
            btnAddSection.Margin = new Padding(10);
            btnAddSection.Name = "btnAddSection";
            btnAddSection.Padding = new Padding(16);
            btnAddSection.Size = new Size(299, 83);
            btnAddSection.TabIndex = 15;
            btnAddSection.Text = "        Add Section";
            btnAddSection.TextAlign = ContentAlignment.MiddleLeft;
            btnAddSection.UseVisualStyleBackColor = false;
            btnAddSection.Click += btnAddSection_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(79, 133);
            label1.Name = "label1";
            label1.Size = new Size(447, 50);
            label1.TabIndex = 13;
            label1.Text = "ENTER SECTION NAME:";
            // 
            // SectionList
            // 
            SectionList.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            SectionList.FormattingEnabled = true;
            SectionList.ItemHeight = 32;
            SectionList.Location = new Point(634, 365);
            SectionList.Name = "SectionList";
            SectionList.SelectionMode = SelectionMode.None;
            SectionList.Size = new Size(559, 132);
            SectionList.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(796, 301);
            label5.Name = "label5";
            label5.Size = new Size(268, 50);
            label5.TabIndex = 11;
            label5.Text = "Your Sections";
            // 
            // SubjectListSection
            // 
            SubjectListSection.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            SubjectListSection.FormattingEnabled = true;
            SubjectListSection.ItemHeight = 32;
            SubjectListSection.Location = new Point(634, 87);
            SubjectListSection.Name = "SubjectListSection";
            SubjectListSection.Size = new Size(559, 132);
            SubjectListSection.TabIndex = 10;
            SubjectListSection.SelectedIndexChanged += SubjectListSection_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(757, 23);
            label4.Name = "label4";
            label4.Size = new Size(351, 50);
            label4.TabIndex = 9;
            label4.Text = "Select the Subject ";
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.White;
            tabPage4.Controls.Add(comboBoxSection);
            tabPage4.Controls.Add(btnDeleteTextTextBox);
            tabPage4.Controls.Add(tableLayoutPanel2);
            tabPage4.Controls.Add(comboBoxSubject);
            tabPage4.ForeColor = Color.Black;
            tabPage4.Location = new Point(4, 54);
            tabPage4.Margin = new Padding(7);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1221, 660);
            tabPage4.TabIndex = 0;
            tabPage4.Text = "Student Actions";
            // 
            // comboBoxSection
            // 
            comboBoxSection.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxSection.FormattingEnabled = true;
            comboBoxSection.Location = new Point(499, 12);
            comboBoxSection.Name = "comboBoxSection";
            comboBoxSection.Size = new Size(238, 38);
            comboBoxSection.TabIndex = 18;
            comboBoxSection.Text = "SECTION:";
            comboBoxSection.SelectedIndexChanged += comboBoxSection_SelectedIndexChanged;
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
            btnDeleteTextTextBox.Click += btnDeleteTextTextBox_Click;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(StudentInfo_Panel);
            tabPage1.Controls.Add(listBoxResult);
            tabPage1.Controls.Add(textBoxSearch);
            tabPage1.Location = new Point(4, 54);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(1221, 660);
            tabPage1.TabIndex = 3;
            tabPage1.Text = "Search Student";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // StudentInfo_Panel
            // 
            StudentInfo_Panel.Controls.Add(panel1);
            StudentInfo_Panel.Controls.Add(Label_Section);
            StudentInfo_Panel.Controls.Add(Label_Subject);
            StudentInfo_Panel.Controls.Add(label6);
            StudentInfo_Panel.Location = new Point(566, 22);
            StudentInfo_Panel.Name = "StudentInfo_Panel";
            StudentInfo_Panel.Size = new Size(624, 606);
            StudentInfo_Panel.TabIndex = 22;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(Label_Name);
            panel1.Controls.Add(Label_SRCode);
            panel1.Location = new Point(25, 88);
            panel1.Name = "panel1";
            panel1.Size = new Size(575, 129);
            panel1.TabIndex = 26;
            // 
            // Label_Name
            // 
            Label_Name.AutoSize = true;
            Label_Name.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label_Name.ForeColor = Color.Black;
            Label_Name.Location = new Point(19, 69);
            Label_Name.Name = "Label_Name";
            Label_Name.Size = new Size(69, 25);
            Label_Name.TabIndex = 22;
            Label_Name.Text = "Name:";
            // 
            // Label_SRCode
            // 
            Label_SRCode.AutoSize = true;
            Label_SRCode.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label_SRCode.ForeColor = Color.Black;
            Label_SRCode.Location = new Point(19, 22);
            Label_SRCode.Name = "Label_SRCode";
            Label_SRCode.Size = new Size(94, 25);
            Label_SRCode.TabIndex = 23;
            Label_SRCode.Text = "SR-Code:";
            // 
            // Label_Section
            // 
            Label_Section.AutoSize = true;
            Label_Section.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label_Section.ForeColor = Color.Black;
            Label_Section.Location = new Point(44, 321);
            Label_Section.Name = "Label_Section";
            Label_Section.Size = new Size(0, 37);
            Label_Section.TabIndex = 25;
            // 
            // Label_Subject
            // 
            Label_Subject.AutoSize = true;
            Label_Subject.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label_Subject.ForeColor = Color.Black;
            Label_Subject.Location = new Point(161, 263);
            Label_Subject.Name = "Label_Subject";
            Label_Subject.Size = new Size(321, 37);
            Label_Subject.TabIndex = 24;
            Label_Subject.Text = "SUBJECT AND SECTION:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(80, 26);
            label6.Name = "label6";
            label6.Size = new Size(482, 50);
            label6.TabIndex = 21;
            label6.Text = "STUDENT INFORMATION";
            // 
            // listBoxResult
            // 
            listBoxResult.BorderStyle = BorderStyle.FixedSingle;
            listBoxResult.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBoxResult.FormattingEnabled = true;
            listBoxResult.ItemHeight = 30;
            listBoxResult.Location = new Point(17, 53);
            listBoxResult.Name = "listBoxResult";
            listBoxResult.Size = new Size(519, 542);
            listBoxResult.TabIndex = 5;
            listBoxResult.SelectedIndexChanged += listBoxResult_SelectedIndexChanged;
            // 
            // textBoxSearch
            // 
            textBoxSearch.BorderStyle = BorderStyle.FixedSingle;
            textBoxSearch.Location = new Point(17, 14);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "Search for Student";
            textBoxSearch.Size = new Size(519, 39);
            textBoxSearch.TabIndex = 4;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // SemesterComboBox
            // 
            SemesterComboBox.BackColor = SystemColors.Window;
            SemesterComboBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SemesterComboBox.FormattingEnabled = true;
            SemesterComboBox.ImeMode = ImeMode.NoControl;
            SemesterComboBox.Items.AddRange(new object[] { "FIRST", "SECOND", "SUMMER" });
            SemesterComboBox.Location = new Point(701, 22);
            SemesterComboBox.Name = "SemesterComboBox";
            SemesterComboBox.Size = new Size(263, 38);
            SemesterComboBox.TabIndex = 17;
            SemesterComboBox.Text = "Semester:";
            SemesterComboBox.SelectedIndexChanged += SemesterComboBox_SelectedIndexChanged;
            SemesterComboBox.Click += Clicks;
            // 
            // SchoolYearComboBox
            // 
            SchoolYearComboBox.BackColor = SystemColors.Window;
            SchoolYearComboBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SchoolYearComboBox.FormattingEnabled = true;
            SchoolYearComboBox.ImeMode = ImeMode.NoControl;
            SchoolYearComboBox.Location = new Point(442, 22);
            SchoolYearComboBox.Name = "SchoolYearComboBox";
            SchoolYearComboBox.Size = new Size(238, 38);
            SchoolYearComboBox.TabIndex = 16;
            SchoolYearComboBox.Text = "School Year:";
            SchoolYearComboBox.SelectedIndexChanged += SchoolYearComboBox_SelectedIndexChanged;
            SchoolYearComboBox.Click += Clicks;
            // 
            // Students
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(SemesterComboBox);
            Controls.Add(tabControl3);
            Controls.Add(SchoolYearComboBox);
            Controls.Add(label3);
            Name = "Students";
            Size = new Size(1279, 839);
            Load += Students_Load;
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tabControl3.ResumeLayout(false);
            tabPage6.ResumeLayout(false);
            tabPage6.PerformLayout();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            StudentInfo_Panel.ResumeLayout(false);
            StudentInfo_Panel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private ComboBox comboBoxSubject;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox textBoxInput;
        private Button btnPush;
        private Button btnPull;
        private CheckedListBox checkBoxStudent;
        private TabControl tabControl3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnDeleteTextTextBox;
        private TabPage tabPage1;
        private Label label4;
        private ListBox SubjectListSection;
        private TextBox textBoxSection;
        private Button btnEditSection;
        private Button btnDeleteSection;
        private Button btnAddSection;
        private Label label1;
        private ListBox SectionList;
        private Label label5;
        private ComboBox comboBoxSection;
        private TabPage tabPage6;
        private Label labelSubjectName;
        private Label labelNewName;
        private Button btnDeleteSubject;
        private Button btnAddSubject;
        private TextBox textBoxSubject;
        private Label label2;
        private ListBox SubjectList;
        private ComboBox SemesterComboBox;
        private ComboBox SchoolYearComboBox;
        private TextBox textBoxSearch;
        private ListBox listBoxResult;
        private Label label6;
        private Panel StudentInfo_Panel;
        private Label Label_Section;
        private Label Label_Subject;
        private Label Label_SRCode;
        private Label Label_Name;
        private Panel panel1;
    }
}
