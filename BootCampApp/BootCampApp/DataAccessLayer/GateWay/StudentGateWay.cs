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
    class StudentGateWay
    {
        private SqlConnection connection;

        public StudentGateWay()
        {
            string conn = ConfigurationManager.ConnectionStrings["BootCamp"].ConnectionString;
            connection = new SqlConnection();
            connection.ConnectionString = conn;
        }

        public string SaveEnroll(Student aStudent, string sysDate)
        {
            connection.Open();
            string query = string.Format("INSERT INTO t_StudentEnroll VALUES(@aNewReg, @aNewCourse,@aNewDate)");
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Add(new SqlParameter("@aNewReg", aStudent.RegNo));
            command.Parameters.Add(new SqlParameter("@aNewCourse", aStudent.Courses));
            command.Parameters.Add(new SqlParameter("@aNewDate", sysDate));

            int affectedRows = command.ExecuteNonQuery();
            connection.Close();
            if (affectedRows > 0)
                return "Student enrollment has been saved to database";
            return "Something went wrong";
        }

        public string HasThisStudent(string regNo)
        {
            connection.Open();
            string query = string.Format("SELECT * FROM t_Student WHERE Student_RegNo=@aNewID");
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Add(new SqlParameter("@aNewID", regNo));
            SqlDataReader aReader = command.ExecuteReader();


            Student aStudent = new Student();
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    
                    aStudent.Name = aReader[0].ToString();
                    aStudent.Email = aReader[1].ToString();
                    //student.Add(aStudent);
                }
            }
            connection.Close();
            return ;
        }
    }
}
