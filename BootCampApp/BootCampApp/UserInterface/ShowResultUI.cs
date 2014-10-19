using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BootCampApp.DataAccessLayer.View;
using BootCampApp.BusinessLogicLayer;

namespace BootCampApp.UserInterface
{
    public partial class ShowResultUI : Form
    {
        ResultBll aResultBll = new ResultBll();
        List<CourseResultView> result = new List<CourseResultView>();

        public ShowResultUI()
        {
            InitializeComponent();
            ShowDataInGrid();
        }

        private void ShowDataInGrid()
        {

            result = aResultBll.GetAllResult();
            showResultDataGridView.DataSource = result;
        }
    }
}
