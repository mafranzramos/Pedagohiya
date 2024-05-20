using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Shapes;
using static System.Windows.Forms.LinkLabel;
using Path = System.IO.Path;

namespace Pedagohiya
{
    public partial class Attendance : UserControl
    {
        private string username;
        string basePath = @"CSV Files\";
        public Attendance(string username)
        {
            InitializeComponent();
            this.username = username;

        }
        public Attendance()
        {
            InitializeComponent();
        }

        private void Attendance_Load(object sender, EventArgs e)
        {
            comboBoxSection.Items.Add("CLICK ON A SUBJECT TO SHOW THE AVAILABLE SECTIONS");
            PopulateYearRangeComboBox();
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
            RefreshCheckboxList();
        }

        private void YearSemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isSelected = SchoolYearComboBox.SelectedIndex != -1 && SemesterComboBox.SelectedIndex != -1;
            if (isSelected)
            {
                Refresh();
            }
        }
        private void RefreshCheckboxList()
        {
            checkedListBoxStudent.Items.Clear();
            if (comboBoxSubject.SelectedIndex == -1 || comboBoxSection.SelectedIndex == -1)
            {
                markButton.Visible = false;
                checkedListBoxStudent.Visible = false;
                return;
            }
            markButton.Visible = true;
            checkedListBoxStudent.Visible = true;

            string selectedSubject = comboBoxSubject.SelectedItem.ToString();
            string selectedYear = SchoolYearComboBox.SelectedItem.ToString();
            string selectedSemester = SemesterComboBox.SelectedItem.ToString();
            string selectedSection = comboBoxSection.SelectedItem.ToString();

            string classCSV = Path.Combine(basePath, username, selectedYear, selectedSemester, selectedSubject, selectedSection, selectedSection + "_classList.csv");
            string attendanceCSV = Path.Combine(basePath, username, selectedYear, selectedSemester, selectedSubject, selectedSection, selectedSection + "_attendanceList.csv");

            if (!File.Exists(classCSV))
            {
                checkedListBoxStudent.Items.Clear();
                MessageBox.Show("CSV file not found: " + classCSV, "Debug Info");
                return;
            }
            try
            {
                string[] classString = File.ReadAllLines(classCSV);
                string[] attendanceString = File.ReadAllLines(attendanceCSV);

                if (attendanceString.Length != classString.Length + 1)
                {
                    using (StreamWriter writer = new StreamWriter(attendanceCSV))
                    {
                        writer.WriteLine("attendance");
                        for (int i = 0; i < classString.Length; i++)
                        {
                            string[] line = classString[i].Split(',');
                            writer.WriteLine(line[0]);
                        }
                    }
                }

                for (int i = 0; i < classString.Length; i++)
                {
                    string[] line = classString[i].Split(',');
                    string newItem = line[1] + ", " + line[2] + " " + line[3];
                    checkedListBoxStudent.Items.Add(newItem);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error reading CSV file: " + ex.Message, "Error");
            }
        }

        private void Refresh()
        {
            RefreshCheckboxList();
            PopulateSubjectList(comboBoxSubject);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshCheckboxList();
        }

        private void markButton_Click(object sender, EventArgs e)
        {
            AttendanceConfirmationPopup popup = new AttendanceConfirmationPopup();
            DialogResult dr = popup.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string selectedYear = SchoolYearComboBox.SelectedItem?.ToString();
                string selectedSemester = SemesterComboBox.SelectedItem?.ToString();
                string selectedSubject = comboBoxSubject.SelectedItem?.ToString();
                string sectionName = comboBoxSection.SelectedItem?.ToString();
                string CSV = Path.Combine(basePath, username, selectedYear, selectedSemester, selectedSubject, sectionName, sectionName + "_attendanceList.csv");
                string[] attendanceString = File.ReadAllLines(CSV);
                using (StreamWriter writer = new StreamWriter(CSV))
                {
                    for (int currentLine = 0; currentLine < attendanceString.Length; currentLine++)
                    {
                        if (currentLine == 0) writer.WriteLine(attendanceString[currentLine] + dateTimePicker1.Value.ToString(",MM/dd/yyyy"));
                        else
                        {
                            if (checkedListBoxStudent.GetItemChecked(currentLine - 1))
                                writer.WriteLine(attendanceString[currentLine] + ",1");
                            else
                                writer.WriteLine(attendanceString[currentLine] + ",0");
                        }
                    }
                }

                checkedListBoxStudent.Items.Clear();
                markButton.Visible = false;
                checkedListBoxStudent.Visible = false;
            }
        }
    }
}
