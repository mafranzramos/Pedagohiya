namespace Pedagohiya
{
    partial class EditTask_Popup
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
            panel1 = new Panel();
            EditbtnClear = new Button();
            EditcalendarDeadline = new MonthCalendar();
            EditbtnSetDeadline = new Button();
            EditbtnSave = new Button();
            EdittxtDesc = new TextBox();
            EdittxtTaskTitle = new TextBox();
            EditlblDeadline = new Label();
            lblTitle = new Label();
            EditpbCloseButton = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EditpbCloseButton).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(EditbtnClear);
            panel1.Controls.Add(EditcalendarDeadline);
            panel1.Controls.Add(EditbtnSetDeadline);
            panel1.Controls.Add(EditbtnSave);
            panel1.Controls.Add(EdittxtDesc);
            panel1.Controls.Add(EdittxtTaskTitle);
            panel1.Controls.Add(EditlblDeadline);
            panel1.Location = new Point(0, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(605, 291);
            panel1.TabIndex = 6;
            // 
            // EditbtnClear
            // 
            EditbtnClear.BackColor = Color.FromArgb(66, 100, 208);
            EditbtnClear.FlatStyle = FlatStyle.Flat;
            EditbtnClear.Font = new Font("Libre Franklin Medium", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EditbtnClear.ForeColor = Color.White;
            EditbtnClear.Location = new Point(429, 233);
            EditbtnClear.Name = "EditbtnClear";
            EditbtnClear.Size = new Size(141, 39);
            EditbtnClear.TabIndex = 22;
            EditbtnClear.Text = "Clear all";
            EditbtnClear.UseVisualStyleBackColor = false;
            // 
            // EditcalendarDeadline
            // 
            EditcalendarDeadline.BackColor = Color.FromArgb(222, 227, 242);
            EditcalendarDeadline.Font = new Font("Libre Franklin", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EditcalendarDeadline.Location = new Point(20, 110);
            EditcalendarDeadline.Name = "EditcalendarDeadline";
            EditcalendarDeadline.TabIndex = 20;
            // 
            // EditbtnSetDeadline
            // 
            EditbtnSetDeadline.BackColor = Color.FromArgb(222, 227, 242);
            EditbtnSetDeadline.FlatStyle = FlatStyle.Flat;
            EditbtnSetDeadline.Font = new Font("Libre Franklin", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EditbtnSetDeadline.ForeColor = Color.Black;
            EditbtnSetDeadline.Location = new Point(20, 229);
            EditbtnSetDeadline.Name = "EditbtnSetDeadline";
            EditbtnSetDeadline.Size = new Size(111, 30);
            EditbtnSetDeadline.TabIndex = 19;
            EditbtnSetDeadline.Text = "Set deadline";
            EditbtnSetDeadline.TextAlign = ContentAlignment.MiddleLeft;
            EditbtnSetDeadline.UseVisualStyleBackColor = false;
            // 
            // EditbtnSave
            // 
            EditbtnSave.BackColor = Color.FromArgb(66, 100, 208);
            EditbtnSave.FlatStyle = FlatStyle.Flat;
            EditbtnSave.Font = new Font("Libre Franklin Medium", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EditbtnSave.ForeColor = Color.White;
            EditbtnSave.Location = new Point(266, 233);
            EditbtnSave.Name = "EditbtnSave";
            EditbtnSave.Size = new Size(157, 39);
            EditbtnSave.TabIndex = 17;
            EditbtnSave.Text = "Save Changes";
            EditbtnSave.UseVisualStyleBackColor = false;
            // 
            // EdittxtDesc
            // 
            EdittxtDesc.BackColor = Color.FromArgb(222, 227, 242);
            EdittxtDesc.BorderStyle = BorderStyle.None;
            EdittxtDesc.Font = new Font("Libre Franklin", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EdittxtDesc.Location = new Point(20, 87);
            EdittxtDesc.Multiline = true;
            EdittxtDesc.Name = "EdittxtDesc";
            EdittxtDesc.Size = new Size(550, 121);
            EdittxtDesc.TabIndex = 13;
            EdittxtDesc.Text = "Task Description";
            // 
            // EdittxtTaskTitle
            // 
            EdittxtTaskTitle.BackColor = Color.FromArgb(222, 227, 242);
            EdittxtTaskTitle.BorderStyle = BorderStyle.None;
            EdittxtTaskTitle.Font = new Font("Libre Franklin", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EdittxtTaskTitle.Location = new Point(20, 38);
            EdittxtTaskTitle.Multiline = true;
            EdittxtTaskTitle.Name = "EdittxtTaskTitle";
            EdittxtTaskTitle.Size = new Size(550, 37);
            EdittxtTaskTitle.TabIndex = 12;
            EdittxtTaskTitle.Text = "Task Title";
            // 
            // EditlblDeadline
            // 
            EditlblDeadline.AutoSize = true;
            EditlblDeadline.Font = new Font("Libre Franklin", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EditlblDeadline.Location = new Point(137, 233);
            EditlblDeadline.Name = "EditlblDeadline";
            EditlblDeadline.Size = new Size(109, 22);
            EditlblDeadline.TabIndex = 21;
            EditlblDeadline.Text = "Task Deadline";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Libre Franklin SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.ButtonFace;
            lblTitle.Location = new Point(14, 11);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(105, 30);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Edit Task";
            // 
            // EditpbCloseButton
            // 
            EditpbCloseButton.BackgroundImage = Properties.Resources.quit_white;
            EditpbCloseButton.BackgroundImageLayout = ImageLayout.Zoom;
            EditpbCloseButton.Location = new Point(558, 5);
            EditpbCloseButton.Name = "EditpbCloseButton";
            EditpbCloseButton.Size = new Size(35, 30);
            EditpbCloseButton.TabIndex = 9;
            EditpbCloseButton.TabStop = false;
            // 
            // EditTask_Popup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(66, 100, 208);
            Controls.Add(panel1);
            Controls.Add(lblTitle);
            Controls.Add(EditpbCloseButton);
            Name = "EditTask_Popup";
            Size = new Size(605, 344);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EditpbCloseButton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button EditbtnClear;
        private MonthCalendar EditcalendarDeadline;
        private Button EditbtnSetDeadline;
        private Button EditbtnSave;
        private TextBox EdittxtDesc;
        private TextBox EdittxtTaskTitle;
        private Label EditlblDeadline;
        private Label lblTitle;
        private PictureBox EditpbCloseButton;
    }
}
