using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BootCampApp.DataAccessLayer.DataAccessObject;
using BootCampApp.DataAccessLayer.GateWay;
using BootCampApp.DataAccessLayer.View;

namespace BootCampApp.BusinessLogicLayer
{
    class StudentBll
    {
        public  StudentGateWay aStudentGateWay;
        public CourseGateWay aCourseGateWay;
        public List<Student> Students { set; get; }
        public List<Course> Courses { set; get; }

        private Student aStudent;

        public StudentBll()
        {
            aStudentGateWay = new StudentGateWay();
            aCourseGateWay = new CourseGateWay();
        }

        public Enrollment SearchRegNo(string regNo)
        {
            Enrollment anEnrollment=new Enrollment();
            if (HasThisStudent(regNo))
            {
                //anEnrollment=
            }
            return null;
        }

        public bool HasThisStudent(string regNo)
        {
           return aStudentGateWay.HasThisStudent(regNo);
        }
    }
}
