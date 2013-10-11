using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessObject
{
    public class AccountsDAO
    {
        // Begin Login Admin
        public static DataSet Accounts_Login(string Accounts_Username, string Accounts_Password)
        {
            DataSet ds = null;
            using (SqlConnection conn = Connection.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Accounts_Login", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@Accounts_Username", Accounts_Username));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@Accounts_Password", Accounts_Password));
                    ds = new DataSet();
                    da.Fill(ds);
                    conn.Close();
                    return ds;
                }
                catch (Exception)
                {
                    conn.Close();
                    return ds;
                }
            }
        }
        // End Login Admin


        //Begin Get DataSet Accounts by Username
        public static DataSet getAccountsbyUsername(string Accounts_Username)
        {
            DataSet ds = new DataSet();
            using (SqlConnection conn = Connection.getConnection())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("getAccountsbyUsername", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Accounts_Username", Accounts_Username));
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(ds);
                    return ds;
                }
                catch (Exception)
                {
                    return ds;
                }
            }
        }
        //End Get Accounts by Username
    }
}
