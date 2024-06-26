﻿using Microsoft.VisualBasic.FileIO;
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
using System.Windows.Forms;

namespace Pedagohiya
{
    public partial class Students : UserControl
    {
        private string username;
        string basePath = @"CSV Files\";
        private WaveOut waveOut;
        public Students(string username)
        {
            InitializeComponent();
            this.username = username;
            waveOut = new WaveOut();
        }
        public Students()
        {
            InitializeComponent();
        }
        public Color PanelBackColor
        {
            get => panel2.BackColor;
            set => panel2.BackColor = value;
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
            int endYear = DateTime.Now.Year + 1; 

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
                MessageBox.Show("CSV file not found: " + csvFilePath, "Debug Info"); 
                return;
            }
            try
            {
                string[] lines = File.ReadAllLines(csvFilePath);

                for (int i = 1; i < lines.Length; i++)
                {
                    checkBoxStudent.Items.Add(lines[i]);
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
            Click();

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
                using (StreamWriter write = File.AppendText(csvClassList))
                {
                    write.WriteLine("SRCODE, LASTNAME, FIRST NAME, MIDDLE NAME");
                }
                string csvAttendanceList = Path.Combine(sectionPath, sectionName + "_attendanceList.csv");
                using (FileStream fs = File.Create(csvAttendanceList)) { }
                string csvTaskList = Path.Combine(sectionPath, sectionName + "_taskList.csv");
                using (FileStream fs = File.Create(csvTaskList)) { }
                using (StreamWriter write = File.AppendText(csvTaskList))
                {
                    write.WriteLine("SRCODE");
                }
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
                MessageBox.Show("Please select a year, semester, subject, and section on the dropboxes above before pushing data.");
                return;
            }

            string inputText = textBoxInput.Text;
            string[] lines = inputText.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            string selectedSubject = comboBoxSubject.SelectedItem.ToString();
            string selectedSection = comboBoxSection.SelectedItem.ToString();
            string selectedYear = SchoolYearComboBox.SelectedItem.ToString();
            string selectedSemester = SemesterComboBox.SelectedItem.ToString();

            string csvFilePath = Path.Combine(basePath, username, selectedYear, selectedSemester, selectedSubject, selectedSection, selectedSection + "_classList.csv");
            string taskListPath = Path.Combine(basePath, username, selectedYear, selectedSemester, selectedSubject, selectedSection, selectedSection + "_taskList.csv");

            List<string> existingSR = new List<string>();

            try
            {
                if (File.Exists(csvFilePath))
                {
                    string[] existingLines = File.ReadAllLines(csvFilePath);
                    foreach (string existingLine in existingLines)
                    {
                        string[] parts = existingLine.Split(',');
                        if (parts.Length >= 1)
                        {
                            existingSR.Add(parts[0].Trim());
                        }
                    }
                }

                foreach (string line in lines)
                {
                    string[] parts = line.Split(new[] { ',' }, 4);
                    if (parts.Length == 4)
                    {
                        string srCode = parts[0].Trim();

                        if (!existingSR.Contains(srCode))
                        {
                            string lastName = parts[1].Trim();
                            string firstName = parts[2].Trim();
                            string middleName = parts[3].Trim();
                            string csvLine = $"{srCode},{lastName},{firstName},{middleName}";

                            File.AppendAllLines(csvFilePath, new string[] { csvLine });
                            existingSR.Add(srCode);
                            RefreshCheckboxList();
                            File.AppendAllLines(taskListPath, new string[] { srCode });
                        }
                        else
                        {
                            MessageBox.Show($"SR code '{srCode}' already exists in the list. DOUBLE CHECK.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid input format. Please enter data in the correct format (SRCODE, LASTNAME, FIRST NAME, MIDDLE NAME).");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while writing to the file: {ex.Message}");
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
                string selectedSubject = comboBoxSubject.SelectedItem.ToString();
                string selectedSection = comboBoxSection.SelectedItem.ToString();
                string selectedYear = SchoolYearComboBox.SelectedItem.ToString();
                string selectedSemester = SemesterComboBox.SelectedItem.ToString();

                string csvFilePath = Path.Combine(basePath, username, selectedYear, selectedSemester, selectedSubject, selectedSection, selectedSection + "_classList.csv");
                string taskListFilePath = Path.Combine(basePath, username, selectedYear, selectedSemester, selectedSubject, selectedSection, selectedSection + "_taskList.csv");

                List<string> allEntries = new List<string>();
                List<string> allTaskEntries = new List<string>();

                try
                {
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

                    using (StreamReader reader = new StreamReader(taskListFilePath))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            string srCode = line.Split(',')[0]; 
                            if (!selectedItems.Any(item => item.StartsWith(srCode)))
                            {
                                allTaskEntries.Add(line);
                            }
                        }
                    }

                    string selectedText = string.Join("\n", selectedItems.Select(item => item.Replace("\\", "")));
                    string currentText = textBoxInput.Text;
                    string newText = string.IsNullOrEmpty(currentText) ? selectedText : $"{currentText}\n{selectedText}";
                    textBoxInput.Text = newText;

                    File.WriteAllLines(csvFilePath, allEntries.ToArray());
                    File.WriteAllLines(taskListFilePath, allTaskEntries.ToArray());
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
        }

        private void SemesterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableButtonsIfSelected();
        }
        private void SchoolYearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableButtonsIfSelected();
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

                studentDetailsDict.Clear();
                listBoxResult.Items.Clear(); 

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
                                    string searchTextLower = searchText.ToLower();
                                    if (line.ToLower().Contains(searchTextLower))
                                    {
                                        string[] studentInfo = line.Split(',');
                                        string studentSRCode = studentInfo[0].Trim(); // Assuming SR code is the first element
                                        string lastName = studentInfo[1].Trim(); // Assuming last name is the second element
                                        string firstName = studentInfo[2].Trim(); // Assuming first name is the third element
                                        string middleName = studentInfo[3].Trim(); // Assuming middle name is the fourth element
                                        string middleInitial = string.IsNullOrEmpty(middleName) ? "" : $"{middleName[0]}.";
                                        string fullName = $"{firstName} {middleName} {lastName}"; 

                                        string subjectName = Path.GetFileName(Path.GetDirectoryName(sectionFolder)); 

                                        string studentKey = $"{fullName},{studentSRCode}";

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


        private static readonly Random random = new Random();
        public void Click()
        {
            if (!SoundManager.IsMuted)
            {
                var soundKey = random.Next(0, 2) == 0 ? "1" : "2";
                if (soundKey == "1")
                {
                    LoadClickSound(@"Assets\342200__christopherderp__videogame-menu-button-click.wav");
                    waveOut.Play();
                }
                else
                {
                    LoadClickSound(@"Assets\click3.wav");
                    waveOut.Play();
                }
            }
        }
        private void LoadClickSound(string filePath)
        {
            try
            {
                var audioFileReader = new AudioFileReader(filePath);
                waveOut.Init(audioFileReader);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading click sound: " + ex.Message);
            }
        }

        private void Clicks(object sender, EventArgs e)
        {
            Click();
        }
    }
}
