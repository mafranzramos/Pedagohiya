using Microsoft.VisualBasic.FileIO;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using NAudio.Wave;

namespace Pedagohiya
{
    public partial class Students : UserControl
    {
        private string username;
        string basePath = @"CSV Files\";
        public Students(string username)
        {
            InitializeComponent();
            this.username = username;
        }
        public Students()
        {
            InitializeComponent();
        }

        private void Students_Load(object sender, EventArgs e)
        {
            SubjectList.Items.Add("PICK A SCHOOL YEAR AND SEMESTER FIRST");
            comboBoxSection.Items.Add("CLICK ON A SUBJECT TO SHOW THE AVAILABLE SECTIONS");
            PopulateYearRangeComboBox();
        }
        private void Refresh()
        {
            RefreshCheckboxList();
            RefreshSubjectList(SubjectList);
            RefreshSubjectList(SubjectListSection);
            RefreshSectionList(SectionList);
            PopulateSubjectList(comboBoxSubject);
        }
        private void PopulateYearRangeComboBox()
        {
            int currentYear = DateTime.Now.Year;
            int startYear = currentYear - 1;
            int endYear = DateTime.Now.Year + 1; // Get current year and add 1 for next year

            for (int year = startYear; year <= endYear; year++)
            {
                SchoolYearComboBox.Items.Add($"{year}-{year + 1}");
            }
        }
        private void PopulateSectionList(ComboBox comboBoxSection)
        {
            comboBoxSection.Items.Clear();
            string selectedYear = SchoolYearComboBox.SelectedItem.ToString();
            string selectedSemester = SemesterComboBox.SelectedItem.ToString();
            string selectedSubject = comboBoxSubject.SelectedItem.ToString();
            string userPath = Path.Combine(basePath, username, selectedYear, selectedSemester, selectedSubject);
            string[] sectionDirectories = Directory.GetDirectories(userPath);

            if (sectionDirectories.Length == 0)
            {
                comboBoxSection.Items.Add("No Section Found");
                return;
            }
            foreach (string sectionPath in sectionDirectories)
            {
                string sectionName = Path.GetFileName(sectionPath);
                comboBoxSection.Items.Add(sectionName);
            }
        }
        private void RefreshCheckboxList()
        {
            checkBoxStudent.Items.Clear();
            if (comboBoxSubject.SelectedIndex == -1 || comboBoxSection.SelectedIndex == -1)
            {
                return;
            }
            string selectedSubject = comboBoxSubject.SelectedItem.ToString();
            string selectedYear = SchoolYearComboBox.SelectedItem.ToString();
            string selectedSemester = SemesterComboBox.SelectedItem.ToString();
            string selectedSection = comboBoxSection.SelectedItem.ToString();

            string csvFilePath = Path.Combine(basePath, username, selectedYear, selectedSemester, selectedSubject, selectedSection, selectedSection + "_classList.csv");

            if (!File.Exists(csvFilePath))
            {
                checkBoxStudent.Items.Clear();
                MessageBox.Show("CSV file not found: " + csvFilePath, "Debug Info"); // Debug message
                return;
            }
            try
            {
                string[] lines = File.ReadAllLines(csvFilePath);
                foreach (string line in lines)
                {
                    checkBoxStudent.Items.Add(line);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error reading CSV file: " + ex.Message, "Error");
            }
        }
        public void RefreshSubjectList(ListBox listbox)
        {
            listbox.Items.Clear();
            SubjectListSection.Enabled = true;
            string selectedYear = SchoolYearComboBox.SelectedItem.ToString();
            string selectedSemester = SemesterComboBox.SelectedItem.ToString();
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
                listbox.Items.Add("No subjects found for this year and semester.");
                SubjectListSection.Enabled = false;
            }
        }

        private void RefreshSectionList(ListBox listBox)
        {
            listBox.Items.Clear();
            if (SubjectListSection.SelectedIndex == -1 || SchoolYearComboBox.SelectedIndex == -1 || SemesterComboBox.SelectedIndex == -1)
            {
                return;
            }
            string selectedSubject = SubjectListSection.SelectedItem.ToString().Split('.')[1].Trim();
            string selectedYear = SchoolYearComboBox.SelectedItem.ToString();
            string selectedSemester = SemesterComboBox.SelectedItem.ToString();
            string subjectPath = Path.Combine(basePath, username, selectedYear, selectedSemester, selectedSubject);
            string[] directories = Directory.GetDirectories(subjectPath);

            if (directories.Length == 0)
            {
                SectionList.Items.Add("No sections so far");
                return;
            }

            int i = 1;
            foreach (string directoryPath in directories)
            {
                string sectionName = Path.GetFileName(directoryPath);
                listBox.Items.Add(i + ". " + sectionName);
                i++;
            }
        }

        // === SUBJECT ACTIONS === 
        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            labelNewName.Visible = false;
            labelSubjectName.Visible = true;


            string selectedYear = SchoolYearComboBox.SelectedItem?.ToString();
            string selectedSemester = SemesterComboBox.SelectedItem?.ToString();
            string folderName = textBoxSubject.Text;

            if (string.IsNullOrEmpty(selectedYear) || string.IsNullOrEmpty(selectedSemester))
            {

                MessageBox.Show("Please pick a year and semester first from the dropdown boxes at the top.", "Missing Selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrEmpty(folderName))
            {
                MessageBox.Show("Please enter a folder name.");
                return;
            }

            string folderPath = Path.Combine(basePath, username, selectedYear, selectedSemester, folderName);
            if (Directory.Exists(folderPath))
            {
                MessageBox.Show("The folder '" + folderName + "' already exists. Please check your subjects list.");
                textBoxSubject.Text = "";
            }
            else
            {
                try
                {
                    Directory.CreateDirectory(folderPath);
                    textBoxSubject.Text = "";
                    Refresh();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error creating folder: {ex.Message}");
                }
            }

        }

        private void btnDeleteSubject_Click(object sender, EventArgs e)
        {
            labelNewName.Visible = false;
            labelSubjectName.Visible = true;

            string subjectName = textBoxSubject.Text;
            string selectedYear = SchoolYearComboBox.SelectedItem?.ToString();
            string selectedSemester = SemesterComboBox.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedYear) || string.IsNullOrEmpty(selectedSemester))
            {

                MessageBox.Show("Please pick a year and semester first from the dropdown boxes at the top.", "Missing Selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrEmpty(subjectName))
            {
                MessageBox.Show("Please Enter the Subject you want to delete.");
                return;
            }

            string folderPath = Path.Combine(basePath, username, selectedYear, selectedSemester, subjectName);
            if (Directory.Exists(folderPath))
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete the subject '" + subjectName + "'?\n" +
                    "This action cannot be undone and will permanently delete all data associated with this subject.",
                    "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    Directory.Delete(folderPath, true);
                }
            }
            else
            {
                MessageBox.Show("The subject '" + subjectName + "' does not exist.");
                textBoxSubject.Text = "";
            }
            textBoxSubject.Text = "";
            Refresh();
        }

        // === SECTION ACTIONS === 
        private void btnAddSection_Click(object sender, EventArgs e)
        {
            string selectedYear = SchoolYearComboBox.SelectedItem?.ToString();
            string selectedSemester = SemesterComboBox.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedYear) || string.IsNullOrEmpty(selectedSemester))
            {

                MessageBox.Show("Please pick a year and semester first from the dropdown boxes at the top.", "Missing Selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (SubjectListSection.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a subject from the SubjectList before adding a section.");
                return;
            }

            string selectedSubject = SubjectListSection.SelectedItem.ToString().Split('.')[1].Trim();
            string subjectPath = Path.Combine(basePath, username, selectedYear, selectedSemester, selectedSubject);

            string sectionName = textBoxSection.Text.Trim();

            if (string.IsNullOrEmpty(sectionName))
            {
                MessageBox.Show("Please enter a name for the section.");
                return;
            }

            string sectionPath = Path.Combine(subjectPath, sectionName);
            if (Directory.Exists(sectionPath))
            {
                MessageBox.Show("A section named '" + sectionName + "' already exists in this subject.");
                return;
            }

            try
            {
                Directory.CreateDirectory(sectionPath);
                string csvClassList = Path.Combine(sectionPath, sectionName + "_classList.csv");
                using (FileStream fs = File.Create(csvClassList)) { }
                string csvAttendanceList = Path.Combine(sectionPath, sectionName + "_attendanceList.csv");
                using (FileStream fs = File.Create(csvAttendanceList)) { }
                string csvTaskList = Path.Combine(sectionPath, sectionName + "_taskList.csv");
                using (FileStream fs = File.Create(csvTaskList)) { }

                MessageBox.Show("Section '" + sectionName + "' added successfully!");
                textBoxSection.Text = "";
                RefreshSubjectList(SubjectList);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating section: {ex.Message}");
            }
            Refresh();
        }

        private void btnDeleteSection_Click(object sender, EventArgs e)
        {
            if (SubjectListSection.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a subject from the SubjectList before deleting a section.");
                return;
            }
            string selectedSubject = SubjectListSection.SelectedItem.ToString().Split('.')[1].Trim();
            string selectedYear = SchoolYearComboBox.SelectedItem.ToString();
            string selectedSemester = SemesterComboBox.SelectedItem.ToString();
            string subjectPath = Path.Combine(basePath, username, selectedYear, selectedSemester, selectedSubject);

            string sectionName = textBoxSection.Text.Trim();

            if (string.IsNullOrEmpty(sectionName))
            {
                MessageBox.Show("Please enter the name of the section to delete.");
                return;
            }

            string sectionPath = Path.Combine(subjectPath, sectionName);

            if (!Directory.Exists(sectionPath))
            {
                MessageBox.Show("The section '" + sectionName + "' does not exist in this subject.");
                return;
            }

            DialogResult result = MessageBox.Show(
              "Are you sure you want to delete the section '" + sectionName + "'?\n" +
              "This action cannot be undone and will permanently delete all data associated with this section.",
              "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    Directory.Delete(sectionPath, true);
                    MessageBox.Show("Section '" + sectionName + "' deleted successfully!");
                    RefreshSubjectList(SubjectList); // Refresh subject list to reflect changes
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting section: {ex.Message}");
                }
            }
            RefreshSectionList(SectionList);
            PopulateSubjectList(comboBoxSubject);
        }

        private void btnEditSection_Click(object sender, EventArgs e)
        {

        }
        // === STUDENT ACTIONS ===
        private void PopulateSubjectList(ComboBox comboBoxSubject)
        {
            comboBoxSubject.Items.Clear();

            string selectedYear = SchoolYearComboBox.SelectedItem.ToString();
            string selectedSemester = SemesterComboBox.SelectedItem.ToString();
            string userPath = Path.Combine(basePath, username, selectedYear, selectedSemester);
            if (!Directory.Exists(userPath))
            {
                Directory.CreateDirectory(userPath);
            }
            string[] subjectDirectories = Directory.GetDirectories(userPath);

            if (subjectDirectories.Length == 0)
            {
                comboBoxSubject.Items.Add("No Subjects Found");
            }
            else
            {
                foreach (string subjectPath in subjectDirectories)
                {
                    string subjectName = Path.GetFileName(subjectPath);
                    comboBoxSubject.Items.Add(subjectName);
                }
            }
        }
        private void btnPush_Click(object sender, EventArgs e)
        {
            if (comboBoxSubject.SelectedIndex == -1 || comboBoxSection.SelectedIndex == -1 || SchoolYearComboBox.SelectedIndex == -1 || SemesterComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a subject, section, year, and semester before pushing data.");
                return;
            }

            string inputText = textBoxInput.Text;
            string[] parts = inputText.Split(new[] { ',' }, 4);
            if (parts.Length == 4)
            {
                string srCode = parts[0].Trim();
                string lastName = parts[1].Trim();
                string firstName = parts[2].Trim();
                string middleName = parts[3].Trim();
                string csvLine = $"{srCode},{lastName},{firstName},{middleName}";

                string selectedSubject = comboBoxSubject.SelectedItem.ToString();
                string selectedSection = comboBoxSection.SelectedItem.ToString();
                string selectedYear = SchoolYearComboBox.SelectedItem.ToString();
                string selectedSemester = SemesterComboBox.SelectedItem.ToString();

                string csvFilePath = Path.Combine(basePath, username, selectedYear, selectedSemester, selectedSubject, selectedSection, selectedSection + "_classList.csv");

                try
                {
                    File.AppendAllLines(csvFilePath, new string[] { csvLine });
                    RefreshCheckboxList();
                    MessageBox.Show("Data pushed successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while writing to the file: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Invalid input format. Please enter data in the correct format (SRCODE, LASTNAME, FIRST NAME, MIDDLE NAME).");
            }
        }


        private void btnDeleteTextTextBox_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = "";
        }

        private void btnPull_Click(object sender, EventArgs e)
        {

            var selectedItems = checkBoxStudent.CheckedItems.Cast<string>().ToList();

            if (selectedItems.Count > 0)
            {
                List<string> allEntries = new List<string>();
                string selectedSubject = comboBoxSubject.SelectedItem.ToString();
                string selectedSection = comboBoxSection.SelectedItem.ToString();
                string selectedYear = SchoolYearComboBox.SelectedItem.ToString();
                string selectedSemester = SemesterComboBox.SelectedItem.ToString();

                string csvFilePath = Path.Combine(basePath, username, selectedYear, selectedSemester, selectedSubject, selectedSection, selectedSection + "_classList.csv");
                using (StreamReader reader = new StreamReader(csvFilePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (!selectedItems.Contains(line))
                        {
                            allEntries.Add(line);
                        }
                    }
                }
                string selectedText = string.Join("\n", selectedItems.Select(item => item.Replace("\\", "")));

                string currentText = textBoxInput.Text;

                string newText = string.IsNullOrEmpty(currentText) ? selectedText : $"{currentText}\n{selectedText}";

                textBoxInput.Text = newText;

                try
                {
                    File.WriteAllLines(csvFilePath, allEntries.ToArray());
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating CSV file: {ex.Message}");
                }

                RefreshCheckboxList();
            }
            else
            {
                MessageBox.Show("Please select one or more items from the list.");
            }
        }

        private void SubjectListSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            SectionList.Text = "";
            RefreshSectionList(SectionList);
        }

        private void comboBoxSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSubject.SelectedIndex == -1)
            {
                comboBoxSection.Items.Clear();
                comboBoxSection.Text = "";
                return;
            }
            string selectedSubjectText = comboBoxSubject.SelectedItem.ToString();

            if (selectedSubjectText == "No Subjects Found")
            {
                comboBoxSection.Items.Clear();
                return;
            }
            comboBoxSection.Items.Clear();
            PopulateSectionList(comboBoxSection);

        }
        private void comboBoxSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSectionText = comboBoxSection.SelectedItem.ToString();
            comboBoxSection.Text = selectedSectionText;
            RefreshCheckboxList();
        }
        private void EnableButtonsIfSelected()
        {
            bool isSelected = SchoolYearComboBox.SelectedIndex != -1 && SemesterComboBox.SelectedIndex != -1;
            if (isSelected)
            {
                Refresh();
            }
            /* btnAddSubject.Enabled = isSelected;
             btnDeleteSubject.Enabled = isSelected;
             btnAddSection.Enabled = isSelected;*/
            btnDeleteSection.Enabled = isSelected;
            btnPush.Enabled = isSelected;
            btnPull.Enabled = isSelected;
        }

        private void SemesterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableButtonsIfSelected();
        }
        private void SchoolYearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableButtonsIfSelected();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private Dictionary<string, List<string>> studentDetailsDict = new Dictionary<string, List<string>>();

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            listBoxResult.Visible = true;
            string searchText = textBoxSearch.Text.Trim();
            string selectedYear = SchoolYearComboBox.SelectedItem?.ToString();
            string selectedSemester = SemesterComboBox.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedYear) || string.IsNullOrEmpty(selectedSemester))
            {
                MessageBox.Show("Please pick a year and semester first from the dropdown boxes at the top.", "Missing Selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (searchText.Length >= 1)
            {
                string dataPath = Path.Combine(basePath, username, selectedYear, selectedSemester);

                studentDetailsDict.Clear(); // Clear previous search results
                listBoxResult.Items.Clear(); // Clear previous search results in ListBox

                foreach (string subjectFolder in Directory.EnumerateDirectories(dataPath))
                {
                    foreach (string sectionFolder in Directory.EnumerateDirectories(subjectFolder))
                    {
                        string sectionName = Path.GetFileName(sectionFolder);
                        string classListFile = Path.Combine(sectionFolder, $"{sectionName}_classList.csv");

                        if (File.Exists(classListFile))
                        {
                            try
                            {
                                string[] lines = File.ReadAllLines(classListFile);
                                foreach (string line in lines)
                                {
                                    if (line.Contains(searchText))
                                    {
                                        string[] studentInfo = line.Split(',');
                                        string studentSRCode = studentInfo[0].Trim(); // Assuming SR code is the first element
                                        string lastName = studentInfo[1].Trim(); // Assuming last name is the second element
                                        string firstName = studentInfo[2].Trim(); // Assuming first name is the third element
                                        string middleName = studentInfo[3].Trim(); // Assuming middle name is the fourth element
                                        string middleInitial = string.IsNullOrEmpty(middleName) ? "" : $"{middleName[0]}.";
                                        string fullName = $"{firstName} {middleName} {lastName}"; // Full name with middle initial

                                        string subjectName = Path.GetFileName(Path.GetDirectoryName(sectionFolder)); // Get subject name from parent folder

                                        // Unique key for each student
                                        string studentKey = $"{fullName},{studentSRCode}";

                                        // Store detailed information
                                        string sectionAndSubject = $"{sectionName} ({subjectName})";

                                        if (!studentDetailsDict.ContainsKey(studentKey))
                                        {
                                            studentDetailsDict[studentKey] = new List<string>();
                                        }

                                        studentDetailsDict[studentKey].Add(sectionAndSubject);
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Error reading file '{classListFile}': {ex.Message}");
                            }
                        }
                        else
                        {
                            MessageBox.Show($"Section folder '{sectionFolder}' does not have a class list file.");
                        }
                    }
                }

                foreach (var student in studentDetailsDict)
                {
                    string[] studentKeyParts = student.Key.Split(',');
                    string fullName = studentKeyParts[0];
                    string studentSRCode = studentKeyParts[1];

                    // Add name and SR code to listBoxResult
                    string displayInfo = $"{fullName} ({studentSRCode})";
                    listBoxResult.Items.Add(displayInfo);
                }
            }
        }

        private void listBoxResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxResult.SelectedIndex != -1)
            {
                int selectedIndex = listBoxResult.SelectedIndex;
                string selectedDetail = listBoxResult.Items[selectedIndex] as string;
                int srCodeStart = selectedDetail.LastIndexOf('(') + 1;
                int srCodeLength = selectedDetail.LastIndexOf(')') - srCodeStart;
                string studentSRCode = selectedDetail.Substring(srCodeStart, srCodeLength).Trim();
                string fullName = selectedDetail.Substring(0, srCodeStart - 2).Trim();

                string studentKey = $"{fullName},{studentSRCode}";

                if (studentDetailsDict.TryGetValue(studentKey, out List<string> sectionsAndSubjects))
                {
                    string aggregatedSectionsAndSubjects = string.Join("\n", sectionsAndSubjects);

                    // Update label text with retrieved information
                    Label_Name.Text = "Name: " + fullName;
                    Label_SRCode.Text = "SR-Code: " + studentSRCode;
                    Label_Section.Text = aggregatedSectionsAndSubjects;
                }
            }
        }
        private void textBoxInput_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = "";
        }
    }
}
