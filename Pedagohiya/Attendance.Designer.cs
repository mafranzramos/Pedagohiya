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
            btnDeleteTextTextBox = new Button();
            comboBoxSection = new ComboBox();
            comboBoxSubject = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            tabControl3 = new TabControl();
            tabPage6 = new TabPage();
            tabPage5 = new TabPage();
            tabPage4 = new TabPage();
            button1 = new Button();
            tabControl3.SuspendLayout();
            tabPage6.SuspendLayout();
            tabPage4.SuspendLayout();
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
            btnDeleteTextTextBox.Location = new Point(43, 543);
            btnDeleteTextTextBox.Margin = new Padding(10);
            btnDeleteTextTextBox.Name = "btnDeleteTextTextBox";
            btnDeleteTextTextBox.Padding = new Padding(16, 0, 0, 0);
            btnDeleteTextTextBox.Size = new Size(233, 54);
            btnDeleteTextTextBox.TabIndex = 18;
            btnDeleteTextTextBox.Text = "        Delete the Text";
            btnDeleteTextTextBox.TextAlign = ContentAlignment.MiddleLeft;
            btnDeleteTextTextBox.UseVisualStyleBackColor = false;
            // 
            // comboBoxSection
            // 
            comboBoxSection.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxSection.FormattingEnabled = true;
            comboBoxSection.Location = new Point(499, 21);
            comboBoxSection.Name = "comboBoxSection";
            comboBoxSection.Size = new Size(238, 38);
            comboBoxSection.TabIndex = 20;
            comboBoxSection.Text = "SECTION:";
            // 
            // comboBoxSubject
            // 
            comboBoxSubject.BackColor = SystemColors.Window;
            comboBoxSubject.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxSubject.FormattingEnabled = true;
            comboBoxSubject.ImeMode = ImeMode.NoControl;
            comboBoxSubject.Location = new Point(20, 21);
            comboBoxSubject.Name = "comboBoxSubject";
            comboBoxSubject.Size = new Size(455, 38);
            comboBoxSubject.TabIndex = 19;
            comboBoxSubject.Text = "SUBJECT";
            comboBoxSubject.SelectedIndexChanged += comboBoxSubject_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            dateTimePicker1.Location = new Point(782, 21);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(387, 36);
            dateTimePicker1.TabIndex = 21;
            // 
            // tabControl3
            // 
            tabControl3.Appearance = TabAppearance.FlatButtons;
            tabControl3.Controls.Add(tabPage6);
            tabControl3.Controls.Add(tabPage5);
            tabControl3.Controls.Add(tabPage4);
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
            // tabPage6
            // 
            tabPage6.BackColor = Color.White;
            tabPage6.Controls.Add(btnDeleteTextTextBox);
            tabPage6.Controls.Add(dateTimePicker1);
            tabPage6.Controls.Add(comboBoxSubject);
            tabPage6.Controls.Add(comboBoxSection);
            tabPage6.Location = new Point(4, 54);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(1221, 660);
            tabPage6.TabIndex = 2;
            tabPage6.Text = "Mark Attendance";
            // 
            // tabPage5
            // 
            tabPage5.BackColor = Color.White;
            tabPage5.Location = new Point(4, 54);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(1221, 660);
            tabPage5.TabIndex = 1;
            tabPage5.Text = "View Attendance";
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.White;
            tabPage4.Controls.Add(button1);
            tabPage4.ForeColor = Color.Black;
            tabPage4.Location = new Point(4, 54);
            tabPage4.Margin = new Padding(7);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1221, 660);
            tabPage4.TabIndex = 0;
            tabPage4.Text = "Attendance Reports?";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatAppearance.BorderSize = 3;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Image = Properties.Resources.upHere6;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(18, 576);
            button1.Margin = new Padding(10);
            button1.Name = "button1";
            button1.Padding = new Padding(16, 0, 0, 0);
            button1.Size = new Size(233, 54);
            button1.TabIndex = 17;
            button1.Text = "        Delete the Text";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            // 
            // Attendance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl3);
            Controls.Add(label2);
            Name = "Attendance";
            Size = new Size(1284, 804);
            tabControl3.ResumeLayout(false);
            tabPage6.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button btnDeleteTextTextBox;
        private ComboBox comboBoxSection;
        private ComboBox comboBoxSubject;
        private DateTimePicker dateTimePicker1;
        private TabControl tabControl3;
        private TabPage tabPage6;
        private TabPage tabPage5;
        private TabPage tabPage4;
        private Button button1;
    }
}
