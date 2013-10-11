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
    }
}
