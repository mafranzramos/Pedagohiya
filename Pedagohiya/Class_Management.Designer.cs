﻿namespace Pedagohiya
{
    partial class Class_Management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Class_Management));
            label3 = new Label();
            comboBox1 = new ComboBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            textBox1 = new TextBox();
            checkedListBox1 = new CheckedListBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            tabPage1 = new TabPage();
            tabPage4 = new TabPage();
            comboBoxSection = new ComboBox();
            btnDeleteTextTextBox = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            textBoxInput = new TextBox();
            checkBoxStudent = new CheckedListBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnPush = new Button();
            btnPull = new Button();
            comboBoxSubject = new ComboBox();
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
            tabPage6 = new TabPage();
            labelSubjectName = new Label();
            labelNewName = new Label();
            btnDeleteSubject = new Button();
            btnAddSubject = new Button();
            btnEditSubject = new Button();
            textBoxSubject = new TextBox();
            SubjectList = new ListBox();
            label2 = new Label();
            tabControl3 = new TabControl();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tabPage4.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
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
            label3.Location = new Point(7, 0);
            label3.Name = "label3";
            label3.Size = new Size(426, 50);
            label3.TabIndex = 7;
            label3.Text = "CLASS MANAGEMENT";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(505, 55);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(238, 38);
            comboBox1.TabIndex = 21;
            comboBox1.Text = "SECTION:";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85.17398F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.8260212F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 525F));
            tableLayoutPanel3.Controls.Add(textBox1, 0, 1);
            tableLayoutPanel3.Controls.Add(checkedListBox1, 2, 1);
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.Size = new Size(200, 100);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(3, 3);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1, 436);
            textBox1.TabIndex = 22;
            textBox1.Text = "Type here to add students";
            // 
            // checkedListBox1
            // 
            checkedListBox1.CheckOnClick = true;
            checkedListBox1.Dock = DockStyle.Fill;
            checkedListBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.HorizontalScrollbar = true;
            checkedListBox1.Location = new Point(-321, 3);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.ScrollAlwaysVisible = true;
            checkedListBox1.Size = new Size(519, 436);
            checkedListBox1.TabIndex = 25;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(button1, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.Size = new Size(200, 100);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Dock = DockStyle.Fill;
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Image = Properties.Resources.icons8_forward_26;
            button1.Location = new Point(10, 10);
            button1.Margin = new Padding(10);
            button1.Name = "button1";
            button1.Size = new Size(180, 198);
            button1.TabIndex = 23;
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.Dock = DockStyle.Fill;
            button2.FlatAppearance.BorderColor = Color.Black;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(10, 228);
            button2.Margin = new Padding(10);
            button2.Name = "button2";
            button2.Size = new Size(180, 198);
            button2.TabIndex = 24;
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 54);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(1221, 660);
            tabPage1.TabIndex = 3;
            tabPage1.Text = "Search Student";
            tabPage1.UseVisualStyleBackColor = true;
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
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85.17398F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.8260212F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 525F));
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
            textBoxInput.Dock = DockStyle.Fill;
            textBoxInput.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxInput.Location = new Point(3, 64);
            textBoxInput.Multiline = true;
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(545, 436);
            textBoxInput.TabIndex = 22;
            textBoxInput.Text = "Type here to add students";
            // 
            // checkBoxStudent
            // 
            checkBoxStudent.CheckOnClick = true;
            checkBoxStudent.Dock = DockStyle.Fill;
            checkBoxStudent.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxStudent.FormattingEnabled = true;
            checkBoxStudent.HorizontalScrollbar = true;
            checkBoxStudent.Location = new Point(649, 64);
            checkBoxStudent.Name = "checkBoxStudent";
            checkBoxStudent.ScrollAlwaysVisible = true;
            checkBoxStudent.Size = new Size(520, 436);
            checkBoxStudent.TabIndex = 25;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnPush, 0, 0);
            tableLayoutPanel1.Controls.Add(btnPull, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(554, 64);
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
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(82, 136);
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
            SectionList.Location = new Point(616, 409);
            SectionList.Name = "SectionList";
            SectionList.SelectionMode = SelectionMode.None;
            SectionList.Size = new Size(585, 196);
            SectionList.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(806, 340);
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
            SubjectListSection.Location = new Point(616, 90);
            SubjectListSection.Name = "SubjectListSection";
            SubjectListSection.Size = new Size(585, 196);
            SubjectListSection.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(760, 26);
            label4.Name = "label4";
            label4.Size = new Size(351, 50);
            label4.TabIndex = 9;
            label4.Text = "Select the Subject ";
            // 
            // tabPage6
            // 
            tabPage6.BackColor = Color.White;
            tabPage6.Controls.Add(labelSubjectName);
            tabPage6.Controls.Add(labelNewName);
            tabPage6.Controls.Add(btnDeleteSubject);
            tabPage6.Controls.Add(btnAddSubject);
            tabPage6.Controls.Add(btnEditSubject);
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
            // 
            // btnEditSubject
            // 
            btnEditSubject.BackColor = Color.White;
            btnEditSubject.BackgroundImageLayout = ImageLayout.None;
            btnEditSubject.FlatAppearance.BorderColor = Color.Black;
            btnEditSubject.FlatAppearance.BorderSize = 3;
            btnEditSubject.FlatStyle = FlatStyle.Flat;
            btnEditSubject.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditSubject.Image = Properties.Resources.edit;
            btnEditSubject.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditSubject.Location = new Point(156, 443);
            btnEditSubject.Margin = new Padding(10);
            btnEditSubject.Name = "btnEditSubject";
            btnEditSubject.Padding = new Padding(16);
            btnEditSubject.Size = new Size(299, 83);
            btnEditSubject.TabIndex = 13;
            btnEditSubject.Text = "        Edit Section Name";
            btnEditSubject.TextAlign = ContentAlignment.MiddleLeft;
            btnEditSubject.UseVisualStyleBackColor = false;
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
            // SubjectList
            // 
            SubjectList.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            SubjectList.FormattingEnabled = true;
            SubjectList.ItemHeight = 32;
            SubjectList.Location = new Point(665, 89);
            SubjectList.Name = "SubjectList";
            SubjectList.SelectionMode = SelectionMode.None;
            SubjectList.Size = new Size(537, 548);
            SubjectList.TabIndex = 9;
            SubjectList.SelectedIndexChanged += SubjectList_SelectedIndexChanged;
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
            // Class_Management
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl3);
            Controls.Add(label3);
            Name = "Class_Management";
            Size = new Size(1279, 839);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            tabPage6.ResumeLayout(false);
            tabPage6.PerformLayout();
            tabControl3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private ComboBox comboBox1;
        private TableLayoutPanel tableLayoutPanel3;
        private TextBox textBox1;
        private CheckedListBox checkedListBox1;
        private TableLayoutPanel tableLayoutPanel4;
        private Button button1;
        private Button button2;
        private TabPage tabPage1;
        private TabPage tabPage4;
        private ComboBox comboBoxSection;
        private Button btnDeleteTextTextBox;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox textBoxInput;
        private CheckedListBox checkBoxStudent;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnPush;
        private Button btnPull;
        private ComboBox comboBoxSubject;
        private TabPage tabPage5;
        private TextBox textBoxSection;
        private Button btnEditSection;
        private Button btnDeleteSection;
        private Button btnAddSection;
        private Label label1;
        private ListBox SectionList;
        private Label label5;
        private ListBox SubjectListSection;
        private Label label4;
        private TabPage tabPage6;
        private Label labelSubjectName;
        private Label labelNewName;
        private Button btnDeleteSubject;
        private Button btnAddSubject;
        private Button btnEditSubject;
        private TextBox textBoxSubject;
        private ListBox SubjectList;
        private Label label2;
        private TabControl tabControl3;
    }
}