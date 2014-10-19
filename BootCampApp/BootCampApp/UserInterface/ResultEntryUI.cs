using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BootCampApp.BusinessLogicLayer;
using BootCampApp.DataAccessLayer.DataAccessObject;
using BootCampApp.DataAccessLayer.View;

namespace BootCampApp.UserInterface
{
    public partial class ResultEntryUI : Form
    {
        StudentBll aStudentBll;
        ResultBll aResultBll;

        

        public ResultEntryUI()
        {
            InitializeComponent();
            ShowCourseComboBox();
        }

        private void ShowCourseComboBox()
        {
            CourseBll aCourseBll = new CourseBll();
            List<Course> courses = aCourseBll.GetAllCourse();
            foreach (Course aCourse in courses)
            {
                courseComboBox.Items.Add(aCourse);
            }

            courseComboBox.DisplayMember = "CourseTitle";
            courseComboBox.ValueMember = "CourseId";

        }

        private void findButton_Click(object sender, EventArgs e)
        {
            aStudentBll = new StudentBll();

            aStudentBll.GetStudent(regnoTextBox.Text);
            // nameTextBox.Text = ;
            // emailTextBox.Text = ;
        }

        private void viewResultSheetButton_Click(object sender, EventArgs e)
        {
            ShowResultUI aShowResultUi = new ShowResultUI();
            aShowResultUi.ShowDialog();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            aResultBll = new ResultBll();

            Result aResult = new Result();
            aResult.RegNo = regnoTextBox.Text;
            aResult.Score = Convert.ToInt32(scoreTextBox.Text);
            
            Course aCourse = (Course)courseComboBox.SelectedItem;
            aResult.CourseId = aCourse.CourseId;
            string msg = aResultBll.Save(aResult);
            MessageBox.Show(msg);
            
        }
    }
}
