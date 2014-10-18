using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BootCampApp.DataAccessLayer.GateWay;

namespace BootCampApp.BusinessLogicLayer
{
    class StudentBll
    {
        public  StudentGateWay AStudentGateWay;
        public StudentBll()
        {
            AStudentGateWay = new StudentGateWay();
        }
    }
}
