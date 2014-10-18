using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BootCampApp.DataAccessLayer.DataAccessObject;
using BootCampApp.DataAccessLayer.View;

namespace BootCampApp.DataAccessLayer.GateWay
{
    class StudentGateWay
    {
        private SqlConnection connection;

        public StudentGateWay()
        {
            string conn = @"server=NASER; database=BootCamp;integrated security=true";
            connection = new SqlConnection();
            connection.ConnectionString = conn;
        }


        public string Enroll(Student aStudent)
        {
            connection.Open();
            string query = string.Format("INSERT INTO Student VALUES('{0}','{1}','{2}',{3})", aStudent.RegNo,
                aStudent.Name,aStudent.Email, aStudent.CourseId);
            SqlCommand command = new SqlCommand(query, connection);

            int affectedRows = command.ExecuteNonQuery();
            connection.Close();
            if (affectedRows > 0)
                return "insert success";
            return "something wrong";
        }


        public List<StudentCourseView> GetStudent(string regNo)
        {
            connection.Open();
            string query = string.Format("SELECT * FROM View_1 WHERE RegNo = '{0}'", regNo);
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();
            List<StudentCourseView> student = new List<StudentCourseView>();
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    StudentCourseView aStudentCourseView = new StudentCourseView();

                    aStudentCourseView.RegNo = aReader[0].ToString();
                    aStudentCourseView.Name =  aReader[1].ToString();

                    aStudentCourseView.Email = aReader[2].ToString();
                    aStudentCourseView.Title = aReader[3].ToString();
                    aStudentCourseView.CourseId = (int) aReader[4];

                    student.Add(aStudentCourseView);
                }
            }
            connection.Close();
            return student;
        }

        public List<StudentCourseView> GetAllStudent()
        {
            connection.Open();
            string query = string.Format("SELECT * FROM View_1");
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();
            List<StudentCourseView> students = new List<StudentCourseView>();
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    StudentCourseView aStudentCourseView = new StudentCourseView();

                    aStudentCourseView.RegNo = aReader[0].ToString();
                    aStudentCourseView.Name = aReader[1].ToString();

                    aStudentCourseView.Email = aReader[2].ToString();
                    aStudentCourseView.Title = aReader[3].ToString();
                    aStudentCourseView.CourseId = (int)aReader[4];

                    students.Add(aStudentCourseView);
                }
            }
            connection.Close();
            return students;
        }
    }
}
