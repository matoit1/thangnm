using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace CongKy.DataAccessObject
{
    public static class ConnectionDAO
    {
        public static string CongKyConnectionString = ConfigurationManager.ConnectionStrings["CongKyConnectionString"].ConnectionString;

        public static SqlConnection getConnection()
        {
            try
            {
                return new SqlConnection(CongKyConnectionString);
            }
            catch (Exception ex)
            {
                return new SqlConnection(ex.Message);
            }
        }
    }
}
