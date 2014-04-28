using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace DataAccessObject
{
    public static class ConnectionDAO
    {
        public static string connectdb_internet = ConfigurationManager.ConnectionStrings["connectdb_internet"].ConnectionString;
        public static string connectdb_x84 = ConfigurationManager.ConnectionStrings["connectdb_x84"].ConnectionString;
        public static string connectdb_x64 = ConfigurationManager.ConnectionStrings["connectdb_x64"].ConnectionString;

        public static SqlConnection getConnection()
        {
            SqlConnection _SqlConnection;
            try
            {
                using (_SqlConnection = new SqlConnection(connectdb_x64))
                {
                    _SqlConnection.Open();
                    _SqlConnection.Close();
                    return _SqlConnection;
                }
            }
            catch
            {
                try
                {
                    using (_SqlConnection = new SqlConnection(connectdb_x84))
                    {
                        _SqlConnection.Open();
                        _SqlConnection.Close();
                        return _SqlConnection;
                    }
                }
                catch
                {
                    using (_SqlConnection = new SqlConnection(connectdb_internet))
                    {
                        _SqlConnection.Open();
                        _SqlConnection.Close();
                        return _SqlConnection;
                    }
                }
            }
        }
    }
}
