namespace Pedagohiya
{
    partial class Attendance
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
            label2 = new Label();
            comboBoxSection = new ComboBox();
            comboBoxSubject = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            tabControl3 = new TabControl();
            Marking = new TabPage();
            markButton = new Button();
            SemesterComboBox = new ComboBox();
            checkedListBoxStudent = new CheckedListBox();
            SchoolYearComboBox = new ComboBox();
            Viewing = new TabPage();
            tabControl3.SuspendLayout();
            Marking.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(15, 11);
            label2.Name = "label2";
            label2.Size = new Size(240, 45);
            label2.TabIndex = 8;
            label2.Text = "ATTENDANCE";
            // 
            // comboBoxSection
            // 
            comboBoxSection.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxSection.FormattingEnabled = true;
            comboBoxSection.Location = new Point(727, 29);
            comboBoxSection.Name = "comboBoxSection";
            comboBoxSection.Size = new Size(200, 38);
            comboBoxSection.TabIndex = 20;
            comboBoxSection.Text = "SECTION:";
            comboBoxSection.SelectedIndexChanged += comboBoxSection_SelectedIndexChanged;
            // 
            // comboBoxSubject
            // 
            comboBoxSubject.BackColor = SystemColors.Window;
            comboBoxSubject.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxSubject.FormattingEnabled = true;
            comboBoxSubject.ImeMode = ImeMode.NoControl;
            comboBoxSubject.Location = new Point(506, 29);
            comboBoxSubject.Name = "comboBoxSubject";
            comboBoxSubject.Size = new Size(200, 38);
            comboBoxSubject.TabIndex = 19;
            comboBoxSubject.Text = "SUBJECT";
            comboBoxSubject.SelectedIndexChanged += comboBoxSubject_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            dateTimePicker1.Location = new Point(26, 99);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(387, 36);
            dateTimePicker1.TabIndex = 21;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // tabControl3
            // 
            tabControl3.Appearance = TabAppearance.FlatButtons;
            tabControl3.Controls.Add(Marking);
            tabControl3.Controls.Add(Viewing);
            tabControl3.Cursor = Cursors.Hand;
            tabControl3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControl3.ItemSize = new Size(260, 50);
            tabControl3.Location = new Point(26, 59);
            tabControl3.Multiline = true;
            tabControl3.Name = "tabControl3";
            tabControl3.Padding = new Point(5, 5);
            tabControl3.RightToLeft = RightToLeft.No;
            tabControl3.RightToLeftLayout = true;
            tabControl3.SelectedIndex = 0;
            tabControl3.Size = new Size(1229, 718);
            tabControl3.SizeMode = TabSizeMode.Fixed;
            tabControl3.TabIndex = 22;
            // 
            // Marking
            // 
            Marking.BackColor = Color.FromArgb(67, 101, 208);
            Marking.Controls.Add(markButton);
            Marking.Controls.Add(SemesterComboBox);
            Marking.Controls.Add(checkedListBoxStudent);
            Marking.Controls.Add(SchoolYearComboBox);
            Marking.Controls.Add(dateTimePicker1);
            Marking.Controls.Add(comboBoxSubject);
            Marking.Controls.Add(comboBoxSection);
            Marking.Location = new Point(4, 54);
            Marking.Name = "Marking";
            Marking.Size = new Size(1221, 660);
            Marking.TabIndex = 2;
            Marking.Text = "Mark Attendance";
            // 
            // markButton
            // 
            markButton.Location = new Point(26, 587);
            markButton.Name = "markButton";
            markButton.Size = new Size(620, 46);
            markButton.TabIndex = 24;
            markButton.Text = "Mark";
            markButton.UseVisualStyleBackColor = true;
            markButton.Visible = false;
            markButton.Click += markButton_Click;
            // 
            // SemesterComboBox
            // 
            SemesterComboBox.BackColor = SystemColors.Window;
            SemesterComboBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SemesterComboBox.FormattingEnabled = true;
            SemesterComboBox.ImeMode = ImeMode.NoControl;
            SemesterComboBox.Items.AddRange(new object[] { "FIRST", "SECOND", "SUMMER" });
            SemesterComboBox.Location = new Point(256, 29);
            SemesterComboBox.Name = "SemesterComboBox";
            SemesterComboBox.Size = new Size(200, 38);
            SemesterComboBox.TabIndex = 23;
            SemesterComboBox.Text = "Semester:";
            SemesterComboBox.SelectedIndexChanged += YearSemComboBox_SelectedIndexChanged;
            // 
            // checkedListBoxStudent
            // 
            checkedListBoxStudent.CheckOnClick = true;
            checkedListBoxStudent.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkedListBoxStudent.FormattingEnabled = true;
            checkedListBoxStudent.IntegralHeight = false;
            checkedListBoxStudent.Location = new Point(26, 165);
            checkedListBoxStudent.Name = "checkedListBoxStudent";
            checkedListBoxStudent.Size = new Size(620, 396);
            checkedListBoxStudent.TabIndex = 22;
            checkedListBoxStudent.Visible = false;
            // 
            // SchoolYearComboBox
            // 
            SchoolYearComboBox.BackColor = SystemColors.Window;
            SchoolYearComboBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SchoolYearComboBox.FormattingEnabled = true;
            SchoolYearComboBox.ImeMode = ImeMode.NoControl;
            SchoolYearComboBox.Location = new Point(26, 29);
            SchoolYearComboBox.Name = "SchoolYearComboBox";
            SchoolYearComboBox.Size = new Size(200, 38);
            SchoolYearComboBox.TabIndex = 22;
            SchoolYearComboBox.Text = "School Year:";
            SchoolYearComboBox.SelectedIndexChanged += YearSemComboBox_SelectedIndexChanged;
            // 
            // Viewing
            // 
            Viewing.BackColor = Color.FromArgb(67, 101, 208);
            Viewing.Location = new Point(4, 54);
            Viewing.Name = "Viewing";
            Viewing.Padding = new Padding(3);
            Viewing.Size = new Size(1221, 660);
            Viewing.TabIndex = 1;
            Viewing.Text = "View Attendance";
            // 
            // Attendance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 227, 242);
            Controls.Add(tabControl3);
            Controls.Add(label2);
            Name = "Attendance";
            Size = new Size(1284, 804);
            Load += Attendance_Load;
            tabControl3.ResumeLayout(false);
            Marking.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private ComboBox comboBoxSection;
        private ComboBox comboBoxSubject;
        private DateTimePicker dateTimePicker1;
        private TabControl tabControl3;
        private TabPage Marking;
        private TabPage Viewing;
        private ComboBox SchoolYearComboBox;
        private ComboBox SemesterComboBox;
        private CheckedListBox checkedListBoxStudent;
        private Button markButton;
    }
}
