using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace DataAccessObject
{
    class Connection
    {
        private static string connStr1 = ConfigurationManager.ConnectionStrings["connectdb"].ConnectionString;
        
        public static SqlConnection getConnection()
        {
                return new SqlConnection(connStr1);
        }
    }
}
