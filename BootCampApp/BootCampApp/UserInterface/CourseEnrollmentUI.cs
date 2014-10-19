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
    public partial class CourseEnrollmentUI : Form
    {
        StudentBll aStudentBll;
        
        List<StudentCourseView> student;
        

        public CourseEnrollmentUI()
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
            
            ShowDataInGrid();

        }

        private void ShowDataInGrid()
        {
         
            student = aStudentBll.GetStudent(regnoTextBox.Text);
            enrolledCoursesDataGridView.DataSource = student;
        }

        private void enrollButton_Click(object sender, EventArgs e)
        {

            Student aStudent = new Student();
            aStudent.RegNo = regnoTextBox.Text;
            aStudent.Name = nameTextBox.Text;
            aStudent.Email = emailTextBox.Text;

            Course aCourse = (Course)courseComboBox.SelectedItem;
            aStudent.CourseId = aCourse.CourseId;
            string msg = aStudentBll.Enroll(aStudent);
            MessageBox.Show(msg);
            ShowDataInGrid();

        }

        

    }
}
