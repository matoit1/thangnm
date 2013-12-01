using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace AiLaTrieuPhu.Library
{
    public static class Connection
    {
        private static string connStr = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
        public static SqlConnection getConnection()
        {
                return new SqlConnection(connStr);
        }
    }
}
