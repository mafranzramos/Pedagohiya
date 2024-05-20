using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Pedagohiya
{
    public partial class AddTask_Popup : UserControl
    {

        string basePath = @"CSV Files\";
        private string username = UserProfileManager.GetSavedProfile();
        private string selectedYear;
        private string selectedSemester;
        private string selectedSubject;
        private string selectedSection;


        public AddTask_Popup()
        {
            InitializeComponent();
            PopulateYearRangeComboBox();
            calendarDeadline.Hide();
            calendarDeadline.MinDate = DateTime.Today; 

            cmbSem.SelectedIndexChanged += Cmb_SelectedIndexChanged;
            cmbSY.SelectedIndexChanged += Cmb_SelectedIndexChanged;
            SubjectListSection.SelectedIndexChanged += SubjectListSection_SelectedIndexChanged;
            checkAllSections.CheckedChanged += CheckAllSections_CheckedChanged;
            calendarDeadline.DateSelected += CalendarDeadline_DateSelected;

            

            txtTaskTitle.Enabled = false;
            txtDesc.Enabled = false;
            btnSetDeadline.Enabled = false;
            btnAddTask.Enabled = false;
        }

        private void Cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshSubjectList(SubjectListSection);
            RefreshSectionCheckBoxes();
        }

        private void SubjectListSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshSectionCheckBoxes();
            EnableControls();
        }

        private void CheckAllSections_CheckedChanged(object sender, EventArgs e)
        {
            bool checkAll = checkAllSections.Checked;
            foreach (Control control in flowLayoutPanelSections.Controls)
            {
                if (control is CheckBox checkBox)
                {
                    checkBox.Checked = checkAll;
                }
            }
        }

        private void PopulateYearRangeComboBox()
        {
            int currentYear = DateTime.Now.Year;
            int startYear = currentYear - 1;
            int endYear = currentYear + 1;

            for (int year = startYear; year <= endYear; year++)
            {
                cmbSY.Items.Add($"{year}-{year + 1}");
            }
        }

        public void RefreshSubjectList(ListBox listbox)
        {
            listbox.Items.Clear();

            if (cmbSY.SelectedItem == null || cmbSem.SelectedItem == null)
            {
                listbox.Items.Add("Select both year & semester.");
                listbox.Enabled = false;
                return;
            }

            listbox.Enabled = true;
            string selectedYear = cmbSY.SelectedItem.ToString();
            string selectedSemester = cmbSem.SelectedItem.ToString();
            string dataPath = Path.Combine(basePath, username, selectedYear, selectedSemester);

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
                listbox.Items.Add("No subjects found.");
                listbox.Enabled = false;
            }
        }

        private void RefreshSectionCheckBoxes()
        {
            flowLayoutPanelSections.Controls.Clear();

            if (SubjectListSection.SelectedIndex == -1 || cmbSY.SelectedIndex == -1 || cmbSem.SelectedIndex == -1)
            {
                Label noSelectionLabel = new Label();
                noSelectionLabel.Text = "Select a subject, year, &semester.";
                flowLayoutPanelSections.Controls.Add(noSelectionLabel);
                flowLayoutPanelSections.Enabled = false;
                return;
            }

            flowLayoutPanelSections.Enabled = true;
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
                    Label noSectionsLabel = new Label();
                    noSectionsLabel.Text = "No sections so far.";
                    flowLayoutPanelSections.Controls.Add(noSectionsLabel);
                }
                else
                {
                    int i = 1;
                    foreach (string directoryPath in directories)
                    {
                        string sectionName = Path.GetFileName(directoryPath);
                        CheckBox checkBox = new CheckBox();
                        checkBox.Text = i + ". " + sectionName;
                        checkBox.AutoSize = true;
                        flowLayoutPanelSections.Controls.Add(checkBox);
                        i++;
                    }
                }
            }
            else
            {
                Label noSectionsFoundLabel = new Label();
                noSectionsFoundLabel.Text = "No sections found.";
                flowLayoutPanelSections.Controls.Add(noSectionsFoundLabel);
                flowLayoutPanelSections.Enabled = false;
            }
        }

        private void pbCloseBtn_click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to discard changes?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void btnSetDeadline_click(object sender, EventArgs e)
        {
            calendarDeadline.MinDate = DateTime.Today; // Ensure the minimum date is updated each time
            calendarDeadline.Show();
        }

        private void CalendarDeadline_DateSelected(object sender, DateRangeEventArgs e)
        {
            lblDeadline.Text = e.Start.ToShortDateString();
            calendarDeadline.Hide(); 
        }

        private void btnClear_click (object sender, EventArgs e)
        {
            lblDeadline.Text = string.Empty; 
            calendarDeadline.SetDate(DateTime.Today);
            calendarDeadline.Hide(); 


            cmbSY.SelectedIndex = -1;
            cmbSem.SelectedIndex = -1;


            SubjectListSection.Items.Clear();
            flowLayoutPanelSections.Controls.Clear();
            txtDesc.Text = "Task Description";
            txtTaskTitle.Text = "Task Title";

            txtTaskTitle.Enabled = false;
            txtDesc.Enabled = false;
            btnSetDeadline.Enabled = false;
            btnAddTask.Enabled = false;
        }

        private void EnableControls()
        {
   
            if (cmbSY.SelectedItem != null && cmbSem.SelectedItem != null && SubjectListSection.SelectedItem != null)
            {
                txtTaskTitle.Enabled = true;
                txtDesc.Enabled = true;
                btnSetDeadline.Enabled = true;
                btnAddTask.Enabled = true;
            }
        }


        private void btnAddTask_click(object sender, EventArgs e)
        {
            if ((txtDesc.Text == "" || txtDesc.Text == "Task Description") ||
                (txtTaskTitle.Text == "" || txtTaskTitle.Text == "Task Title") ||
                lblDeadline.Text == "Task Deadline")
            {
                MessageBox.Show("Enter details first.");
                return;
            }
            else
            {
                string selectedSubject = SubjectListSection.SelectedItem.ToString().Substring(3).Trim();
                string selectedYear = cmbSY.SelectedItem.ToString();
                string selectedSemester = cmbSem.SelectedItem.ToString();

                List<string> selectedSections = GetSelectedSections(); // Get all checked sections

                if (selectedSections.Count == 0)
                {
                    MessageBox.Show("Please select at least one section.");
                    return;
                }

                string taskTitle = txtTaskTitle.Text;
                string taskDesc = txtDesc.Text;
                string taskDeadline = lblDeadline.Text;
                string csvLine = $"{taskTitle},{taskDesc},{taskDeadline}";

                bool duplicateFound = false;
                foreach (string section in selectedSections)
                {
                    string sanitizedSection = SanitizeDirectoryName(section);
                    string csvFilePath = Path.Combine(basePath, username, selectedYear, selectedSemester, selectedSubject, sanitizedSection, sanitizedSection + "_taskList.csv");

                    if (CheckForDuplicateTask(taskTitle, taskDesc, taskDeadline, csvFilePath))
                    {
                        duplicateFound = true;
                        break;
                    }
                }

                if (duplicateFound)
                {
                    DialogResult result = MessageBox.Show("A similar task has been previously written. Do you want to proceed?", "Duplicate Task Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.No)
                    {
                        return;
                    }
                }

                foreach (string section in selectedSections)
                {
                    string sanitizedSection = SanitizeDirectoryName(section);
                    string csvFilePath = Path.Combine(basePath, username, selectedYear, selectedSemester, selectedSubject, sanitizedSection, sanitizedSection + "_taskList.csv");

                    try
                    {
                        File.AppendAllLines(csvFilePath, new string[] { csvLine });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while adding the task to section {section}: {ex.Message}");
                        return;
                    }
                }

                GenerateSubmissions(selectedSections, selectedSubject, selectedYear, selectedSemester, taskTitle);

                MessageBox.Show("Task added successfully to all selected sections.");
                this.Hide();
            }
        }

        private bool CheckForDuplicateTask(string taskTitle, string taskDesc, string taskDeadline, string csvFilePath)
        {
            if (File.Exists(csvFilePath))
            {
                var lines = File.ReadAllLines(csvFilePath);
                foreach (var line in lines)
                {
                    var taskDetails = line.Split(',');

                    if (taskDetails.Length == 3)
                    {
                        if (taskDetails[0] == taskTitle && taskDetails[1] == taskDesc && taskDetails[2] == taskDeadline)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        private List<string> GetSelectedSections()
        {
            List<string> selectedSections = new List<string>();

            foreach (Control control in flowLayoutPanelSections.Controls)
            {
                if (control is CheckBox checkBox && checkBox.Checked)
                {
                    selectedSections.Add(checkBox.Text.Substring(checkBox.Text.IndexOf(". ") + 2));
                }
            }

            return selectedSections;
        }

        private string SanitizeDirectoryName(string directoryName)
        {
            // Replace any invalid characters with valid ones or remove them
            string invalidChars = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());
            foreach (char invalidChar in invalidChars)
            {
                directoryName = directoryName.Replace(invalidChar.ToString(), "");
            }

            // Remove leading and trailing whitespaces
            directoryName = directoryName.Trim();

            return directoryName;
        }


        private void GenerateSubmissions(List<string> selectedSections, string selectedSubject, string selectedYear, string selectedSemester, string taskTitle)
        {
            foreach (string selectedSection in selectedSections)
            {
                string sectionFolderPath = Path.Combine(basePath, username, selectedYear, selectedSemester, selectedSubject, selectedSection);
                string submissionsCsvPath = Path.Combine(sectionFolderPath, $"{taskTitle}_Submissions.csv");

                List<string> srCodes = GetSRCodesFromCSV(selectedSection, selectedYear, selectedSemester, selectedSubject);

                List<string> submissions = GenerateSubmissions(srCodes);

                File.WriteAllLines(submissionsCsvPath, submissions);
            }
        }


        private List<string> GetSRCodesFromCSV(string section, string year, string semester, string subject)
        {
            List<string> srCodes = new List<string>();

            string csvFilePath = Path.Combine(basePath, username, year, semester, subject, section, $"{section}_classList.csv");

            if (File.Exists(csvFilePath))
            {
                string[] lines = File.ReadAllLines(csvFilePath);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length >= 1)
                    {
                        string srCode = parts[0].Trim();
                        srCodes.Add(srCode);
                    }
                }
            }

            return srCodes;
        }

        private List<string> GenerateSubmissions(List<string> srCodes)
        {
            List<string> submissions = new List<string>();

            string[] statuses = { "Submitted", "Not yet submitted", "Late" };
            Random random = new Random();

            foreach (string srCode in srCodes)
            {
                string status = statuses[random.Next(statuses.Length)];
                string submission = $"{srCode},{status}";
                submissions.Add(submission);
            }

            return submissions;
        }
    }
}