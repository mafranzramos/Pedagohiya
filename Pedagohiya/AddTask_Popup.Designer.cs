namespace Pedagohiya
{
    partial class AddTask_Popup
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
            lblTitle = new Label();
            panel1 = new Panel();
            btnClear = new Button();
            calendarDeadline = new MonthCalendar();
            btnSetDeadline = new Button();
            flowLayoutPanelSections = new FlowLayoutPanel();
            btnAddTask = new Button();
            checkAllSections = new CheckBox();
            txtDesc = new TextBox();
            txtTaskTitle = new TextBox();
            SubjectListSection = new ListBox();
            lblDeadline = new Label();
            cmbSY = new ComboBox();
            cmbSem = new ComboBox();
            pbCloseButton = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbCloseButton).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Libre Franklin SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.ButtonFace;
            lblTitle.Location = new Point(20, 27);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(139, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Add Task for";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(calendarDeadline);
            panel1.Controls.Add(btnSetDeadline);
            panel1.Controls.Add(flowLayoutPanelSections);
            panel1.Controls.Add(btnAddTask);
            panel1.Controls.Add(checkAllSections);
            panel1.Controls.Add(txtDesc);
            panel1.Controls.Add(txtTaskTitle);
            panel1.Controls.Add(SubjectListSection);
            panel1.Controls.Add(lblDeadline);
            panel1.Location = new Point(0, 86);
            panel1.Name = "panel1";
            panel1.Size = new Size(605, 372);
            panel1.TabIndex = 1;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(66, 100, 208);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Libre Franklin Medium", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(395, 300);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(175, 39);
            btnClear.TabIndex = 22;
            btnClear.Text = "Clear all";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_click;
            // 
            // calendarDeadline
            // 
            calendarDeadline.BackColor = Color.FromArgb(222, 227, 242);
            calendarDeadline.Font = new Font("Libre Franklin", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            calendarDeadline.Location = new Point(78, 147);
            calendarDeadline.Name = "calendarDeadline";
            calendarDeadline.TabIndex = 20;
            // 
            // btnSetDeadline
            // 
            btnSetDeadline.BackColor = Color.FromArgb(222, 227, 242);
            btnSetDeadline.FlatStyle = FlatStyle.Flat;
            btnSetDeadline.Font = new Font("Libre Franklin", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSetDeadline.ForeColor = Color.Black;
            btnSetDeadline.Location = new Point(20, 229);
            btnSetDeadline.Name = "btnSetDeadline";
            btnSetDeadline.Size = new Size(111, 30);
            btnSetDeadline.TabIndex = 19;
            btnSetDeadline.Text = "Set deadline";
            btnSetDeadline.TextAlign = ContentAlignment.MiddleLeft;
            btnSetDeadline.UseVisualStyleBackColor = false;
            btnSetDeadline.Click += btnSetDeadline_click;
            // 
            // flowLayoutPanelSections
            // 
            flowLayoutPanelSections.Font = new Font("Libre Franklin", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            flowLayoutPanelSections.Location = new Point(395, 202);
            flowLayoutPanelSections.Name = "flowLayoutPanelSections";
            flowLayoutPanelSections.Size = new Size(175, 85);
            flowLayoutPanelSections.TabIndex = 18;
            // 
            // btnAddTask
            // 
            btnAddTask.BackColor = Color.FromArgb(66, 100, 208);
            btnAddTask.FlatStyle = FlatStyle.Flat;
            btnAddTask.Font = new Font("Libre Franklin Medium", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddTask.ForeColor = Color.White;
            btnAddTask.Location = new Point(20, 300);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(334, 39);
            btnAddTask.TabIndex = 17;
            btnAddTask.Text = "Add Task";
            btnAddTask.UseVisualStyleBackColor = false;
            btnAddTask.Click += this.btnAddTask_click;
            // 
            // checkAllSections
            // 
            checkAllSections.AutoSize = true;
            checkAllSections.Font = new Font("Libre Franklin", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkAllSections.Location = new Point(395, 170);
            checkAllSections.Name = "checkAllSections";
            checkAllSections.Size = new Size(179, 26);
            checkAllSections.TabIndex = 15;
            checkAllSections.Text = "Apply to all sections?";
            checkAllSections.UseVisualStyleBackColor = true;
            // 
            // txtDesc
            // 
            txtDesc.BackColor = Color.FromArgb(222, 227, 242);
            txtDesc.BorderStyle = BorderStyle.None;
            txtDesc.Font = new Font("Libre Franklin", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDesc.Location = new Point(20, 87);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(334, 121);
            txtDesc.TabIndex = 13;
            txtDesc.Text = "Task Description";
            // 
            // txtTaskTitle
            // 
            txtTaskTitle.BackColor = Color.FromArgb(222, 227, 242);
            txtTaskTitle.BorderStyle = BorderStyle.None;
            txtTaskTitle.Font = new Font("Libre Franklin", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTaskTitle.Location = new Point(20, 38);
            txtTaskTitle.Multiline = true;
            txtTaskTitle.Name = "txtTaskTitle";
            txtTaskTitle.Size = new Size(334, 37);
            txtTaskTitle.TabIndex = 12;
            txtTaskTitle.Text = "Task Title";
            // 
            // SubjectListSection
            // 
            SubjectListSection.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            SubjectListSection.Font = new Font("Libre Franklin", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SubjectListSection.FormattingEnabled = true;
            SubjectListSection.ItemHeight = 22;
            SubjectListSection.Location = new Point(395, 38);
            SubjectListSection.Name = "SubjectListSection";
            SubjectListSection.Size = new Size(175, 114);
            SubjectListSection.TabIndex = 11;
            // 
            // lblDeadline
            // 
            lblDeadline.AutoSize = true;
            lblDeadline.Font = new Font("Libre Franklin", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDeadline.Location = new Point(149, 233);
            lblDeadline.Name = "lblDeadline";
            lblDeadline.Size = new Size(109, 22);
            lblDeadline.TabIndex = 21;
            lblDeadline.Text = "Task Deadline";
            // 
            // cmbSY
            // 
            cmbSY.Font = new Font("Libre Franklin", 11.9999981F);
            cmbSY.FormattingEnabled = true;
            cmbSY.Location = new Point(162, 28);
            cmbSY.Name = "cmbSY";
            cmbSY.Size = new Size(143, 31);
            cmbSY.TabIndex = 2;
            cmbSY.Text = "School Year";
            // 
            // cmbSem
            // 
            cmbSem.Font = new Font("Libre Franklin", 11.9999981F);
            cmbSem.FormattingEnabled = true;
            cmbSem.Items.AddRange(new object[] { "FIRST", "SECOND", "SUMMER" });
            cmbSem.Location = new Point(320, 28);
            cmbSem.Name = "cmbSem";
            cmbSem.Size = new Size(105, 31);
            cmbSem.TabIndex = 3;
            cmbSem.Text = "Semester";
            // 
            // pbCloseButton
            // 
            pbCloseButton.BackgroundImage = Properties.Resources.quit_white;
            pbCloseButton.BackgroundImageLayout = ImageLayout.Zoom;
            pbCloseButton.Location = new Point(558, 10);
            pbCloseButton.Name = "pbCloseButton";
            pbCloseButton.Size = new Size(35, 30);
            pbCloseButton.TabIndex = 4;
            pbCloseButton.TabStop = false;
            pbCloseButton.Click += pbCloseBtn_click;
            // 
            // AddTask_Popup
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(66, 100, 208);
            Controls.Add(pbCloseButton);
            Controls.Add(cmbSY);
            Controls.Add(cmbSem);
            Controls.Add(panel1);
            Controls.Add(lblTitle);
            Font = new Font("Libre Franklin", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "AddTask_Popup";
            Size = new Size(605, 458);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbCloseButton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Panel panel1;
        private ComboBox cmbSY;
        private ComboBox cmbSem;
        private PictureBox pbCloseButton;
        private ListBox SubjectListSection;
        private TextBox txtDesc;
        private TextBox txtTaskTitle;
        private CheckBox checkAllSections;
        private Button btnAddTask;
        private FlowLayoutPanel flowLayoutPanelSections;
        private Button btnSetDeadline;
        private MonthCalendar calendarDeadline;
        private Label lblDeadline;
        private Button btnClear;
    }
}
