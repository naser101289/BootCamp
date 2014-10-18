using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BootCampApp.DataAccessLayer.GateWay;
using BootCampApp.DataAccessLayer.DataAccessObject;

namespace BootCampApp.BusinessLogicLayer
{
    class CourseBll
    {
        CourseGateWay aCourseGateWay;

        public CourseBll()
        {
            aCourseGateWay = new CourseGateWay();
        }

        public List<Course> GetAllCourse()
        {
            return aCourseGateWay.GetAllCourse();
        }

    }
}
