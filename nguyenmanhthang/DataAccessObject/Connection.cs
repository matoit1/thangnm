using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace DataAccessObject
{
    public static class Connection
    {
        private static string connStr1 = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
        private static string connStr2 = ConfigurationManager.ConnectionStrings["connect_public"].ConnectionString;
        public static SqlConnection getConnection()
        {
            try
            {
                return new SqlConnection(connStr1);
            }
            catch
            {
                return new SqlConnection(connStr2);
            }
        }
    }
}
