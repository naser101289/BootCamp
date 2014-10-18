using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BootCampApp.DataAccessLayer.GateWay;

namespace BootCampApp.BusinessLogicLayer
{
    class CourseBll
    {
        public CourseGateWay ACourseGateWay;
        public CourseBll()
        {
            ACourseGateWay = new CourseGateWay();
        }
    }
}
