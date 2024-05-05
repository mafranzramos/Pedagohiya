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

namespace Pedagohiya
{
    public partial class Class_Management : UserControl
    {
        private string username;
        string basePath = @"D:\Users\22viv\source\repos\Pedagohiya\Pedagohiya\CSV Files\";
        public Class_Management(string username)
        {

            InitializeComponent();
            this.username = username;
            RefreshCheckboxList();
            RefreshSubjectList(SubjectList);
            RefreshSubjectList(SubjectListSection);
            RefreshSectionList(SectionList);
            PopulateSubjectList(comboBoxSubject);
            comboBoxSection.Items.Add("Select subject first bruv");
        }
        public Class_Management()
        {
            InitializeComponent();
        }


        private void PopulateSectionList(ComboBox comboBoxSection)
        {
            comboBoxSection.Items.Clear();
            string selectedSubject = comboBoxSubject.SelectedItem.ToString();
            string userPath = Path.Combine(basePath, username, selectedSubject);
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
            string selectedSection = comboBoxSection.SelectedItem.ToString();

            string csvFilePath = Path.Combine(basePath, username, selectedSubject, selectedSection, selectedSection + "_classList.csv");

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

        private void RefreshSubjectList(ListBox listbox)
        {
            listbox.Items.Clear();
            string dataPath = Path.Combine(basePath, username);
            string[] subdirectories = Directory.GetDirectories(dataPath);

            int i = 1;
            foreach (string subdirectory in subdirectories)
            {
                listbox.Items.Add(i + ". " + Path.GetFileName(subdirectory));
                i++;
            }
        }

        private void RefreshSectionList(ListBox listBox)
        {

            listBox.Items.Clear();

            if (SubjectListSection.SelectedIndex == -1)
            {
                return;
            }

            // Get the selected subject directory
            string selectedSubject = SubjectListSection.SelectedItem.ToString().Split('.')[1].Trim();
            string subjectPath = Path.Combine(basePath, username, selectedSubject);
            string[] directories = Directory.GetDirectories(subjectPath);

            if (directories.Length == 0)
            {
                SectionList.Text = "No Sections";
                return;
            }

            int i = 1;
            foreach (string directoryPath in directories)
            {
                // Extract the section name from the directory name
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
            string folderName = textBoxSubject.Text.Trim();

            if (string.IsNullOrEmpty(folderName))
            {
                MessageBox.Show("Please enter a folder name.");
                return;
            }
            string folderPath = Path.Combine(basePath, username, folderName);
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
                    RefreshSubjectList(SubjectList);
                    RefreshSubjectList(SubjectListSection);
                    PopulateSubjectList(comboBoxSubject);

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error creating folder: {ex.Message}");
                }
            }

        }

        private void btnEditSubject_Click(object sender, EventArgs e)
        {

            btnEditSubject.Text = "FINALIZE NAME?";
            labelNewName.Visible = true;
            labelSubjectName.Visible = false;
        }

        private void btnDeleteSubject_Click(object sender, EventArgs e)
        {
            labelNewName.Visible = false;
            labelSubjectName.Visible = true;
            string subjectName = textBoxSubject.Text;
            if (string.IsNullOrEmpty(subjectName))
            {
                MessageBox.Show("Please select a subject to delete.");
                return;
            }

            string folderPath = Path.Combine(basePath, username, subjectName);
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
            RefreshSubjectList(SubjectList);
            RefreshSubjectList(SubjectListSection);
            PopulateSubjectList(comboBoxSubject);
        }

        // === SECTION ACTIONS === 
        private void btnAddSection_Click(object sender, EventArgs e)
        {
            // Check if a subject is selected
            if (SubjectListSection.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a subject from the SubjectList before adding a section.");
                return;
            }

            // Get the selected subject directory
            string selectedSubject = SubjectListSection.SelectedItem.ToString().Split('.')[1].Trim();
            string subjectPath = Path.Combine(basePath, username, selectedSubject);

            // Get the section name from the textbox (optional: add validation)
            string sectionName = textBoxSection.Text.Trim();
            if (string.IsNullOrEmpty(sectionName))
            {
                MessageBox.Show("Please enter a name for the section.");
                return;
            }

            // Create the section directory within the subject directory
            string sectionPath = Path.Combine(subjectPath, sectionName);
            if (Directory.Exists(sectionPath))
            {
                MessageBox.Show("A section named '" + sectionName + "' already exists in this subject.");
                return;
            }

            try
            {
                Directory.CreateDirectory(sectionPath);
                string csvFilePath = Path.Combine(sectionPath, sectionName + "_classList.csv");
                File.Create(csvFilePath);

                MessageBox.Show("Section '" + sectionName + "' added successfully!");
                textBoxSection.Text = "";
                RefreshSubjectList(SubjectList);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating section: {ex.Message}");
            }
            RefreshSectionList(SectionList);
            PopulateSubjectList(comboBoxSubject);
        }

        private void btnDeleteSection_Click(object sender, EventArgs e)
        {
            // Check if a subject is selected
            if (SubjectListSection.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a subject from the SubjectList before deleting a section.");
                return;
            }
            string selectedSubject = SubjectListSection.SelectedItem.ToString().Split('.')[1].Trim();
            string subjectPath = Path.Combine(basePath, username, selectedSubject);

            // Get the section name to delete (optional: display list for selection)
            string sectionName = textBoxSection.Text.Trim(); // Assuming section name is entered

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
            string userPath = Path.Combine(basePath, username);
            string[] subjectDirectories = Directory.GetDirectories(userPath);

            if (subjectDirectories.Length == 0)
            {
                comboBoxSubject.Items.Add("No Subjects Found");
                return;
            }
            foreach (string subjectPath in subjectDirectories)
            {
                string subjectName = Path.GetFileName(subjectPath);
                comboBoxSubject.Items.Add(subjectName);
            }

        }
        private void btnPush_Click(object sender, EventArgs e)
        {
            string inputText = textBoxInput.Text;
            string[] parts = inputText.Split(new[] { ',' }, 2);
            if (parts.Length == 2)
            {
                string srCode = parts[0].Trim();
                string name = parts[1].Trim();
                string csvLine = $"{srCode},{name}";

                string selectedSubject = comboBoxSubject.SelectedItem.ToString();
                string selectedSection = comboBoxSection.SelectedItem.ToString();

                string csvFilePath = Path.Combine(basePath, username, selectedSubject, selectedSection, selectedSection + "_classList.csv");

                File.AppendAllLines(csvFilePath, new string[] { csvLine });
                RefreshCheckboxList();
            }
            else
            {
                MessageBox.Show("Invalid input format. Please enter data in the correct format (SR code, name).");
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

                string csvFilePath = Path.Combine(basePath, username, selectedSubject, selectedSection, selectedSection + "_classList.csv");
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

                // Combine the current text with the selected items (adding a newline if current text is not empty)
                string newText = string.IsNullOrEmpty(currentText) ? selectedText : $"{currentText}\n{selectedText}";

                // Update the textbox content
                textBoxInput.Text = newText;

                try
                {
                    // Overwrite the CSV file with all remaining entries (including new lines)
                    File.WriteAllLines(csvFilePath, allEntries.ToArray());
                }
                catch (Exception ex)
                {
                    // Handle errors during file write operation (optional)
                    MessageBox.Show($"Error updating CSV file: {ex.Message}");
                }

                // Refresh the checkedlistbox based on the updated CSV (call RefreshCheckedListBox again)
                RefreshCheckboxList();

                // Update the textbox content with selected items and proper formatting


            }
            else
            {
                // Handle no selection case (optional)
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

        private void SubjectList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
