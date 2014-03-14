﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace DataAccessObject
{
    public static class ConnectionDAO
    {
        private static string connStr = ConfigurationManager.ConnectionStrings["connectdb"].ConnectionString;
        public static SqlConnection getConnection()
        {
            try
            {
                return new SqlConnection(connStr);
            }
            catch(Exception ex)
            {
                return new SqlConnection(ex.Message);
            }
        }
    }
}
