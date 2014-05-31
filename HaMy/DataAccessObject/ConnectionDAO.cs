using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace HaMy.DataAccessObject
{
    public static class ConnectionDAO
    {
        public static string connectdb=HaMy.Properties.Settings.Default.HaMyConnectionString;

        public static SqlConnection getConnection()
        {
            try
            {
                return new SqlConnection(connectdb);
            }
            catch (Exception ex)
            {
                return new SqlConnection(ex.Message);
            }
        }
    }
}
