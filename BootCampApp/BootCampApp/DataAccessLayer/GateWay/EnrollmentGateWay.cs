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
    class EnrollmentGateWay
    {
        private SqlConnection connection;


        public EnrollmentGateWay()
        {
            string conn = ConfigurationManager.ConnectionStrings["BootCamp"].ConnectionString;
            connection = new SqlConnection();
            connection.ConnectionString = conn;
        }

        public Enrollment GetEnrollment(string regNo)
        {
            Enrollment anEnrollment=new Enrollment();
            connection.Open();
            string query = string.Format("SELECT * FROM Enrollment WHERE Student_RegNo='{0}'",regNo);
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();
            
            List<Course> courses = new List<Course>();
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    anEnrollment.StudentName=aReader[1].ToString();
                    anEnrollment.Email = aReader[2].ToString();
                }
            }
            connection.Close();
            return courses;
        }
    }
}
