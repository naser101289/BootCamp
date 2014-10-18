using System.Windows.Forms;

namespace BootCampApp.UserInterface
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
        }

        private void enrollButton_Click(object sender, System.EventArgs e)
        {
            CourseEnrollmentUI aCourseEnrollmentUi = new CourseEnrollmentUI();
            aCourseEnrollmentUi.ShowDialog();
        }

        private void enterResultButton_Click(object sender, System.EventArgs e)
        {
            ResultEntryUI aResultEntryUi = new ResultEntryUI();
            aResultEntryUi.ShowDialog();
        }

        private void showResultButton_Click(object sender, System.EventArgs e)
        {
            ResultSheetUI aResultSheetUi = new ResultSheetUI();
            aResultSheetUi.ShowDialog();

        }

    

       
    }
}
