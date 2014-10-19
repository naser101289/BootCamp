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
    class ResultGateWay
    {
         private SqlConnection connection;

        public ResultGateWay()
        {
            string conn = @"server=NASER; database=BootCamp;integrated security=true";
            connection = new SqlConnection();
            connection.ConnectionString = conn;
        }


        public string Save(Result aResult)
        {
            connection.Open();
            string query = string.Format("INSERT INTO Result VALUES('{0}',{1},{2})", aResult.RegNo,
                aResult.CourseId, aResult.Score);
            SqlCommand command = new SqlCommand(query, connection);

            int affectedRows = command.ExecuteNonQuery();
            connection.Close();
            if (affectedRows > 0)
                return "insert success";
            return "something wrong";
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

         public List<CourseResultView> GetAllResult()
         {
             connection.Open();
             string query = string.Format("SELECT * FROM View_2");
             SqlCommand command = new SqlCommand(query, connection);
             SqlDataReader aReader = command.ExecuteReader();
             List<CourseResultView> results = new List<CourseResultView>();
             if (aReader.HasRows)
             {
                 while (aReader.Read())
                 {
                     CourseResultView aCourseResultView = new CourseResultView();

                     aCourseResultView.RegNo = aReader[0].ToString();
                     aCourseResultView.Name = aReader[1].ToString();

                     aCourseResultView.Title = aReader[2].ToString();
                     
                     aCourseResultView.Score = (int)aReader[3];

                     results.Add(aCourseResultView);
                 }
             }
             connection.Close();
             return results;
         }
    }
}
