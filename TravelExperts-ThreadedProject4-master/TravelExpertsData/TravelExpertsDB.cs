using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsData
{
    public class TravelExpertsDB
    {
        /// 
        /// Travel Experts database connection string
        /// 
        public static SqlConnection GetConnection()
        {
            string connectionString = @"Data Source=localhost\sqlexpress;Initial Catalog=TravelExperts;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            return con;
        }
    }
}
