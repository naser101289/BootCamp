using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCampApp.DataAccessLayer.GateWay
{
    class CourseGateWay
    {
        private SqlConnection connection;

        public CourseGateWay()
        {
            string conn = ConfigurationManager.ConnectionStrings["BootCamp"].ConnectionString;
            connection = new SqlConnection();
            connection.ConnectionString = conn;
        }
    }
}
