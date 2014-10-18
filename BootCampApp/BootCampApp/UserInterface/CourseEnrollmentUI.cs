using System;
using System.Windows.Forms;
using BootCampApp.BusinessLogicLayer;
using BootCampApp.DataAccessLayer.DataAccessObject;
using BootCampApp.DataAccessLayer.View;

namespace BootCampApp.UserInterface
{
    public partial class CourseEnrollmentUI : Form
    {
        public CourseEnrollmentUI()
        {
            InitializeComponent();
        }

        Student aStudent = new Student();
        private StudentBll aStudentBll;
        Course aCourse = new Course();

        private void findButton_Click(object sender, EventArgs e)
        {
            Enrollment aEnrollment=new Enrollment();
            aEnrollment = aStudentBll.SearchRegNo(regnoTextBox.Text);
           // MessageBox.Show(msg);


            nameTextBox.Text = aEnrollment.StudentName;
            emailTextBox.Text = aEnrollment.Email;
            courseComboBox.DataSource = aEnrollment;
            courseComboBox.ValueMember = "Id";
            courseComboBox.DisplayMember = "CourseTitle";

        }

    }
}
