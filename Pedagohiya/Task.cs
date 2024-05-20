using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
using System.IO;

namespace Pedagohiya
{
    public partial class Task : UserControl
    {

        private string dayoftheWeek = DateTime.Today.DayOfWeek.ToString();
        DateTime now = DateTime.Now;
        int taskNumber;
        string basePath = @"CSV Files\";
        private string username = UserProfileManager.GetSavedProfile();
        private Panel previouslyClickedPanel = null;



        public Task()
        {
            InitializeComponent();
            FixCalendar();
            addText();
            addTask_Popup2.Visible = false;
            PopulateYearRangeComboBox();

            cmbSem.SelectedIndexChanged += Cmb_SelectedIndexChanged;
            cmbSY.SelectedIndexChanged += Cmb_SelectedIndexChanged;
            SubjectListSection.SelectedIndexChanged += SubjectListSection_SelectedIndexChanged;
            SectionList.SelectedIndexChanged += SectionList_SelectedIndexChanged;
        }

        private void Task_Load(object sender, EventArgs e)
        {
            if (taskNumber == 0)
            {
                lblNoActYet.Visible = true;
                addTask_Popup2.Visible = false;
                flpTaskList.Visible = false;
                dgvTask.Visible = false;
            }

        }

        private void Cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshSubjectList(SubjectListSection);
            RefreshSectionList(SectionList);

        }
        private void SubjectListSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshSectionList(SectionList);
        }

        private void SectionList_SelectedIndexChanged(Object sender, EventArgs e)
        {
            getTasks();
        }

        //KUNIN SUBJECTS
        public void RefreshSubjectList(ListBox listbox)
        {
            listbox.Items.Clear();
            SubjectListSection.Enabled = true;
            string selectedYear = cmbSY.SelectedItem.ToString();
            string selectedSemester = cmbSem.SelectedItem.ToString();
            string dataPath = Path.Combine(basePath, username, selectedYear, selectedSemester);

            // Check if the directory exists before accessing it
            if (Directory.Exists(dataPath))
            {
                string[] subdirectories = Directory.GetDirectories(dataPath);
                int i = 1;
                foreach (string subdirectory in subdirectories)
                {
                    listbox.Items.Add(i + ". " + Path.GetFileName(subdirectory));
                    i++;
                }
            }
            else
            {
                listbox.Items.Add("No subjects found for this year and semester.");
                SubjectListSection.Enabled = false;
            }
        }


        // KUNIN SECTIONS
        private void RefreshSectionList(ListBox listBox)
        {
            listBox.Items.Clear();

            if (SubjectListSection.SelectedIndex == -1 || cmbSY.SelectedIndex == -1 || cmbSem.SelectedIndex == -1)
            {
                listBox.Items.Add("Please select a subject, year, and semester.");
                listBox.Enabled = false;
                return;
            }

            listBox.Enabled = true;
            string selectedSubject = SubjectListSection.SelectedItem.ToString();
            selectedSubject = selectedSubject.Substring(selectedSubject.IndexOf('.') + 1).Trim();
            string selectedYear = cmbSY.SelectedItem.ToString();
            string selectedSemester = cmbSem.SelectedItem.ToString();
            string subjectPath = Path.Combine(basePath, username, selectedYear, selectedSemester, selectedSubject);

            if (Directory.Exists(subjectPath))
            {
                string[] directories = Directory.GetDirectories(subjectPath);

                if (directories.Length == 0)
                {
                    listBox.Items.Add("No sections so far.");
                }
                else
                {
                    int i = 1;
                    foreach (string directoryPath in directories)
                    {
                        string sectionName = Path.GetFileName(directoryPath);
                        listBox.Items.Add(i + ". " + sectionName);
                        i++;
                    }
                }
            }
            else
            {
                listBox.Items.Add("No sections found.");
                listBox.Enabled = false;
            }
        }

        // LAMNAN UNG CMBSY
        private void PopulateYearRangeComboBox()
        {
            int currentYear = DateTime.Now.Year;
            int startYear = currentYear - 1;
            int endYear = DateTime.Now.Year + 1;

            for (int year = startYear; year <= endYear; year++)
            {
                cmbSY.Items.Add($"{year}-{year + 1}");
            }
        }

        // display lng...
        public void addText()
        {
            lblDate.Text = now.ToString("MMMM") + " " + now.ToString("dd");
        }

        // calendar format
        public void FixCalendar()
        {
            DateTime now = DateTime.Now;
            string dayOfTWShort = now.ToString("ddd");
            int dayOfMonth = now.Day;
            int currentDayOfWeek = (int)now.DayOfWeek;

            Label[] daysLabel = { lblSun, lblMon, lblTue, lblWed, lblThu, lblFri, lblSat };
            Panel[] daysPanel = { pnlSun, pnlMon, pnlTue, pnlWed, pnlThu, pnlFri, pnlSat };
            Label[] dayWeekLabel = { lblSunD, lblMonD, lblTueD, lblWedD, lblThuD, lblFriD, lblSatD };

            DateTime startOfWeek = now.AddDays(-currentDayOfWeek);

            for (int i = 0; i < daysLabel.Length; i++)
            {
                Label currentLabel = daysLabel[i];
                Label currentDayWeekLabel = dayWeekLabel[i];
                Panel currentPanel = daysPanel[i];

                DateTime currentDate = startOfWeek.AddDays(i);

                currentDayWeekLabel.Text = currentDate.Day.ToString();

                if (dayOfTWShort == currentLabel.Text)
                {
                    ApplyDayStyleToPanel(currentPanel, true);
                    ApplyDayStyleToLabel(currentLabel, true);
                    ApplyDayWeekStyleToLabel(currentDayWeekLabel, true);
                }
                else
                {
                    ApplyDayStyleToPanel(currentPanel, false);
                    ApplyDayStyleToLabel(currentLabel, false);
                    ApplyDayWeekStyleToLabel(currentDayWeekLabel, false);
                }
            }
        }

        private void ApplyDayStyleToPanel(Panel panel, bool highlight)
        {
            if (highlight)
            {
                panel.BackColor = ColorTranslator.FromHtml("#4264d0");
            }
            else
            {
                panel.BackColor = ColorTranslator.FromHtml("#dee3f2");
            }
        }

        private void ApplyDayStyleToLabel(Label label, bool bold)
        {
            Font currentFont = label.Font;

            if (bold)
            {
                label.Font = new Font(currentFont, FontStyle.Bold);
                label.ForeColor = Color.White;
            }
            else
            {
                label.Font = new Font(currentFont, FontStyle.Regular);
                label.ForeColor = SystemColors.ControlText;
            }
        }

        private void ApplyDayWeekStyleToLabel(Label label, bool white)
        {
            if (white)
            {
                label.ForeColor = Color.White;
            }
            else
            {
                label.ForeColor = SystemColors.ControlText;
            }
        }


        private void pbAddButton_click(object sender, EventArgs e)
        {
            addTask_Popup2.Visible = true;

        }

        private void getTasks()
        {
            if (SubjectListSection.SelectedItem == null || cmbSY.SelectedItem == null || cmbSem.SelectedItem == null || SectionList.SelectedItem == null)
            {
                MessageBox.Show("Please make sure to select a subject, year, semester, and section.");
                return;
            }

            string selectedSubject = SubjectListSection.SelectedItem.ToString().Substring(3).Trim();
            string selectedYear = cmbSY.SelectedItem.ToString();
            string selectedSemester = cmbSem.SelectedItem.ToString();
            string selectedSection = SectionList.SelectedItem.ToString().Substring(3).Trim();

            string csvFilePath = Path.Combine(basePath, username, selectedYear, selectedSemester, selectedSubject, selectedSection, selectedSection + "_taskList.csv");

            int numTasks = 0;
            flpTaskList.Controls.Clear();

            if (File.Exists(csvFilePath))
            {
                string[] tasks = File.ReadAllLines(csvFilePath);
                numTasks = tasks.Length;

                foreach (string task in tasks)
                {
                    string[] taskDetails = task.Split(',');

                    if (taskDetails.Length == 3)
                    {
                        string taskTitle = taskDetails[0];
                        string taskDesc = taskDetails[1];
                        string taskDeadline = taskDetails[2];

                        flpTaskList.Show();
                        Panel taskPanel = CreateTaskPanel(taskTitle, taskDesc, taskDeadline, selectedSection, selectedYear);
                        flpTaskList.Controls.Add(taskPanel);
                    }
                }
            }
            else
            {
                MessageBox.Show("No tasks found for the selected section.");
            }

            MessageBox.Show($"Number of tasks: {numTasks}");
        }

        private Panel CreateTaskPanel(string title, string desc, string deadline, string selectedSection, string selectedYear)
        {
            Panel pnlTaskInstance = new Panel
            {
                BackgroundImage = Properties.Resources.fortaskbg,
                BackgroundImageLayout = ImageLayout.Zoom,
                Size = new Size(639, 181),
                BorderStyle = pnlTask.BorderStyle,
                Padding = pnlTask.Padding,
                BackColor = Color.Transparent
            };

            pnlTaskInstance.Click += pnlTask_click;

            PictureBox pictureBox1 = new PictureBox
            {
                BackColor = Color.Transparent,
                BackgroundImage = Properties.Resources.task1,
                BackgroundImageLayout = ImageLayout.Zoom,
                Location = new Point(22, -3),
                Size = new Size(173, 178),
                TabStop = false
            };
            pictureBox1.Click += pnlTask_click;
            pnlTaskInstance.Controls.Add(pictureBox1);

            Label lblTaskTitle = new Label
            {
                Text = title,
                Font = new Font("Libre Franklin", 15.75F, FontStyle.Bold),
                BackColor = Color.Transparent,
                Location = new Point(205, 20),
                AutoSize = true
            };
            lblTaskTitle.Click += pnlTask_click;
            pnlTaskInstance.Controls.Add(lblTaskTitle);

            Label lblTaskDesc = new Label
            {
                Text = desc,
                Font = new Font("Libre Franklin", 11.9999981F),
                BackColor = Color.Transparent,
                ForeColor = SystemColors.ControlDarkDark,
                Location = new Point(208, 55),
                AutoSize = true
            };
            lblTaskDesc.Click += pnlTask_click;
            pnlTaskInstance.Controls.Add(lblTaskDesc);

            Label lblDateSubmi = new Label
            {
                Text = deadline,
                Font = new Font("Libre Franklin", 11.9999981F),
                BackColor = Color.Transparent,
                ForeColor = SystemColors.ActiveCaptionText,
                Location = new Point(516, 26),
                AutoSize = true
            };
            lblDateSubmi.Click += pnlTask_click;
            pnlTaskInstance.Controls.Add(lblDateSubmi);

            Label lblSection = new Label
            {
                Text = selectedSection,
                Font = new Font("Libre Franklin Light", 11.2499981F),
                Location = new Point(324, 128),
                AutoSize = true
            };
            lblSection.Click += pnlTask_click;
            pnlTaskInstance.Controls.Add(lblSection);

            Label lblSY = new Label
            {
                Text = selectedYear,
                Font = new Font("Libre Franklin Light", 11.2499981F),
                Location = new Point(205, 128),
                AutoSize = true
            };
            lblSY.Click += pnlTask_click;
            pnlTaskInstance.Controls.Add(lblSY);

            CheckBox checkBox = new CheckBox
            {
                Location = new Point(10, 10),
                AutoSize = true
            };
            pnlTaskInstance.Controls.Add(checkBox);

            return pnlTaskInstance;
        }

        private void pnlTask_click(object sender, EventArgs e)
        {
            Panel clickedPanel = sender as Panel;

            if (clickedPanel == null && sender is Control clickedControl)
            {
                clickedPanel = clickedControl.Parent as Panel;
            }

            if (clickedPanel != null && clickedPanel != previouslyClickedPanel)
            {
                if (previouslyClickedPanel != null)
                {
                    previouslyClickedPanel.BackColor = Color.Transparent;
                }

                clickedPanel.BackColor = ColorTranslator.FromHtml("#4264d0");
                string taskTitle = GetTaskTitleFromPanel(clickedPanel);
                previouslyClickedPanel = clickedPanel;
                LoadSubmissionsData(taskTitle);
            }
            else if (clickedPanel == previouslyClickedPanel)
            {
                dgvTask.Visible = false;
            }
        }

        private string GetTaskTitleFromPanel(Panel panel)
        {
            Label lblTaskTitle = panel.Controls.OfType<Label>().FirstOrDefault(label => label.Font.Bold);
            return lblTaskTitle?.Text;
        }

        private void LoadSubmissionsData(string taskTitle)
        {
            // Construct the path to the submissions CSV file based on the task title
            string selectedSubject = SubjectListSection.SelectedItem.ToString().Substring(3).Trim();
            string selectedYear = cmbSY.SelectedItem.ToString();
            string selectedSemester = cmbSem.SelectedItem.ToString();
            string selectedSection = SectionList.SelectedItem.ToString().Substring(3).Trim();
            string submissionsCsvPath = Path.Combine(basePath, username, selectedYear, selectedSemester, selectedSubject, selectedSection, $"{taskTitle}_Submissions.csv");

            // Check if the submissions CSV file exists
            if (File.Exists(submissionsCsvPath))
            {
                // Load data from the CSV file into the DataTable
                DataTable dataTable = new DataTable();
                using (var reader = new StreamReader(submissionsCsvPath))
                {
                    string line = reader.ReadLine();
                    if (!string.IsNullOrEmpty(line))
                    {
                        string[] headers = line.Split(',');
                        foreach (string header in headers)
                        {
                            dataTable.Columns.Add(header);
                        }

                        while ((line = reader.ReadLine()) != null)
                        {
                            string[] values = line.Split(',');
                            dataTable.Rows.Add(values);
                        }
                    }
                }

                // Bind the DataTable to the DataGridView
                dgvTask.DataSource = dataTable;
                dgvTask.DefaultCellStyle.Font = new Font("Libre Franklin", 18);
                dgvTask.ColumnHeadersDefaultCellStyle.Font = new Font("Libre Franklin", 18);
                dgvTask.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                // Adjust rows to fit the content
                dgvTask.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                // Optionally, set specific column widths
                foreach (DataGridViewColumn column in dgvTask.Columns)
                {
                    column.Width = 150; // Set the desired width for each column
                }

                // Optionally, set specific row heights
                foreach (DataGridViewRow row in dgvTask.Rows)
                {
                    row.Height = 30; // Set the desired height for each row
                }
                // Show the DataGridView
                dgvTask.Visible = true;
            }
            else
            {
                // Hide the DataGridView if the submissions CSV file doesn't exist
                dgvTask.Visible = false;
            }
        }




        private void pbRefreshButton_click(object sender, EventArgs e)
        {
            getTasks();
        }

        private void pbDeleteButton_click(object sender, EventArgs e)
        {
            DeleteSelectedTasks();
        }

        private void DeleteSelectedTasks()
        {
            List<Panel> panelsToDelete = new List<Panel>();
            List<string> taskTitles = new List<string>();

            foreach (Panel taskPanel in flpTaskList.Controls)
            {
                CheckBox checkBox = taskPanel.Controls.OfType<CheckBox>().FirstOrDefault();
                Label lblTaskTitle = taskPanel.Controls.OfType<Label>().FirstOrDefault(label => label.Font.Bold);

                if (checkBox != null && lblTaskTitle != null && checkBox.Checked)
                {
                    panelsToDelete.Add(taskPanel);
                    taskTitles.Add(lblTaskTitle.Text);
                }
            }

            if (panelsToDelete.Count > 0)
            {
                string message = panelsToDelete.Count == 1
                    ? $"Are you sure you want to delete \"{taskTitles[0]}\"?"
                    : $"Are you sure you want to delete the following tasks?\n- {string.Join("\n- ", taskTitles)}";

                DialogResult result = MessageBox.Show(message, "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    foreach (Panel panel in panelsToDelete)
                    {
                        flpTaskList.Controls.Remove(panel);
                        DeleteTaskFromFile(panel);
                    }
                }
            }
            else
            {
                MessageBox.Show("No tasks selected for deletion.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DeleteTaskFromFile(Panel panel)
        {
            Label lblTaskTitle = panel.Controls.OfType<Label>().FirstOrDefault(label => label.Font.Bold);
            string taskTitle = lblTaskTitle?.Text;

            string selectedSubject = SubjectListSection.SelectedItem.ToString().Substring(3).Trim();
            string selectedYear = cmbSY.SelectedItem.ToString();
            string selectedSemester = cmbSem.SelectedItem.ToString();
            string selectedSection = SectionList.SelectedItem.ToString().Substring(3).Trim();

            string csvFilePath = Path.Combine(basePath, username, selectedYear, selectedSemester, selectedSubject, selectedSection, selectedSection + "_taskList.csv");

            if (File.Exists(csvFilePath))
            {
                var lines = File.ReadAllLines(csvFilePath).Where(line => !line.StartsWith(taskTitle + ",")).ToArray();
                File.WriteAllLines(csvFilePath, lines);
            }
        }

    }
}

