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
        StudentGateWay aStudentGateWay;

        public StudentBll()
        {
            aStudentGateWay = new StudentGateWay();
        }


        public string Enroll(Student aStudent)
        {

            if (aStudent.RegNo == string.Empty || aStudent.Name == string.Empty || aStudent.Email == string.Empty)
            {
                return "please fill up all field";
            }
            else
            {
                if (!HasThisEnrollValid(aStudent))
                {
                    aStudentGateWay.Enroll(aStudent);
                    return "Successfully Enrolled";
                }
                else
                {
                    
                    return "Course Already Enrolled";
                }
            }

        }
        private bool HasThisEnrollValid(Student aStudent)
        {

            aStudentGateWay = new StudentGateWay();

            List<StudentCourseView> studentList = aStudentGateWay.GetAllStudent();

            foreach (StudentCourseView student in studentList)
            {
                if ((aStudent.Name == student.Name) && (aStudent.CourseId == student.CourseId))
                {
                    return true;
                }
            }
            return false;


        }



        public List<StudentCourseView> GetStudent(string regNo)
        {
            return aStudentGateWay.GetStudent(regNo);
        }

    }
}
