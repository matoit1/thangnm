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
        public static string connectdb="Data Source=tydyshop.mssql.somee.com;Initial Catalog=HaMy;Persist Security Info=True;User ID=thangnm_SQLLogin_1;Password=8xh9lukxtb";
        public static string connectdb_x64="Data Source=WIN7X64\\THANGNM;Initial Catalog=tydyshop;Persist Security Info=True;User ID=sa;Password=123";
        public static string connectdb_x84 = "Data Source=THANGNM;Initial Catalog=HaMy;Persist Security Info=True;User ID=sa;Password=abc@123"; 
        public static string connectdb_internet="Data Source=THANGNM;Initial Catalog=HaMy;Persist Security Info=True;User ID=sa;Password=abc@123"; 


        public static SqlConnection getConnection()
        {
            try
            {
                return new SqlConnection(connectdb_x84);
            }
            catch (Exception ex)
            {
                return new SqlConnection(ex.Message);
            }
        }
    }
}
