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
    public partial class Dashboard : UserControl
    {
        private string username = UserProfileManager.GetSavedProfile();
        private string basePath = @"CSV Files\";
        private string dayoftheWeek = DateTime.Today.DayOfWeek.ToString();
        DateTime now = DateTime.Now;

        public Dashboard()
        {
            InitializeComponent();
            FixCalendar();
            insertTexts();
            PopulateYearRangeComboBox();

            cmbSem.SelectedIndexChanged += Cmb_SelectedIndexChanged;
            cmbSY.SelectedIndexChanged += Cmb_SelectedIndexChanged;
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            FixCalendar();
            cmbSem.SelectedIndex = 0;
            cmbSY.SelectedIndex = 0;
            getTotalSubInfo();
            lblSemester.Text = cmbSY.SelectedItem.ToString() + " AY";
            lblSY.Text = cmbSem.SelectedItem.ToString() + " SEMESTER";
        }
        private void Cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            getTotalSubInfo();
            lblSemester.Text = cmbSY.SelectedItem.ToString() + " AY";
            lblSY.Text = cmbSem.SelectedItem.ToString() + " SEMESTER";

        }
        public void insertTexts()
        {
            lblName.Text = username;
            lblEmail.Text = username + "@g.batstate-u.edu.ph";
            lblGreet.Text = "Good Day, " + username + "!";
            lblGreetTwo.Text = "Have a Nice " + dayoftheWeek + "!";
            //lblMonthDay.Text = now.ToString("MMMM") + " " + now.ToString("dd");
            lblDateDisplay.Text = now.ToString("MMM") + " " + now.ToString("dd") + ", " + now.ToString("yyyy") + " " + now.ToString("t");
        }

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
                panel.BackColor = ColorTranslator.FromHtml("#ffffff");
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
        private void PopulateYearRangeComboBox()
        {
            int currentYear = DateTime.Now.Year;
            int startYear = currentYear - 1;
            int endYear = DateTime.Now.Year + 1; // Get current year and add 1 for next year

            for (int year = startYear; year <= endYear; year++)
            {
                cmbSY.Items.Add($"{year}-{year + 1}");
            }
        }

        private void getTotalSubInfo()
        {
            string selectedSemester = cmbSem.SelectedItem.ToString();
            string selectedYear = cmbSY.SelectedItem.ToString();

            string dataPath = Path.Combine(basePath, username, selectedYear, selectedSemester);

            if (Directory.Exists(dataPath))
            {
                //for total subjects
                string[] subdirectories = Directory.GetDirectories(dataPath);
                int totalSubjects = subdirectories.Length;
                lblTotalSub.Text = totalSubjects.ToString();

                // for total sections
                string[] sectionDirectories = Directory.GetDirectories(dataPath);
                int totalSections = sectionDirectories.Length;
                lblTotalSect.Text = totalSections.ToString();

                // for total students
                int totalStudents = 0;
                foreach (string subjectPath in Directory.GetDirectories(dataPath))
                {
                    // Iterate over all section directories within each subject directory
                    foreach (string sectionPath in Directory.GetDirectories(subjectPath))
                    {
                        string csvFilePath = Path.Combine(sectionPath, Path.GetFileName(sectionPath) + "_classList.csv");

                        if (File.Exists(csvFilePath))
                        {
                            totalStudents += File.ReadAllLines(csvFilePath).Length;
                        }
                    }
                }

                lblTotalStud.Text = totalStudents.ToString();

            }
            else
            {
                lblTotalSect.Text = "0";
                lblTotalStud.Text = "0";
                lblTotalSub.Text = "0";

            }

            
        }
  
    }
      
}
