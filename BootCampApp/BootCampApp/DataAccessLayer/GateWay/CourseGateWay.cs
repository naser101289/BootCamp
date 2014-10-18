using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BootCampApp.DataAccessLayer.DataAccessObject;

namespace BootCampApp.DataAccessLayer.GateWay
{
    class CourseGateWay
    {
        private SqlConnection connection;

        public CourseGateWay()
        {
            string conn = @"server=NASER; database=BootCamp;integrated security=true";
            connection = new SqlConnection();
            connection.ConnectionString = conn;
        }


        public List<Course> GetAllCourse()
        {
            connection.Open();
            string query = string.Format("SELECT * FROM Course");
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();
            List<Course> courses = new List<Course>();
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    Course aCourse = new Course();
                    aCourse.CourseId = (int)aReader[0];
                    aCourse.CourseName = aReader[1].ToString();
                    aCourse.CourseTitle = aReader[2].ToString();

                    courses.Add(aCourse);
                }
            }
            connection.Close();
            return courses;
        }

        
    }
}
