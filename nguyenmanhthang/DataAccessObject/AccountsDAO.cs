using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using EntityObject;

namespace DataAccessObject
{
    public class AccountsDAO
    {
        // 1. Insert
        public static bool Insert(AccountsEO _AccountsEO)
        {
            using (SqlConnection conn = Connection.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Accounts_Insert", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Accounts_Username", _AccountsEO.Accounts_Username));
                    cmd.Parameters.Add(new SqlParameter("@Accounts_Password", _AccountsEO.Accounts_Password));
                    cmd.Parameters.Add(new SqlParameter("@Accounts_Email", _AccountsEO.Accounts_Email));
                    cmd.Parameters.Add(new SqlParameter("@Accounts_FullName", _AccountsEO.Accounts_FullName));
                    cmd.Parameters.Add(new SqlParameter("@Accounts_Address", _AccountsEO.Accounts_Address));
                    cmd.Parameters.Add(new SqlParameter("@Accounts_DateOfBirth", _AccountsEO.Accounts_DateOfBirth));
                    cmd.Parameters.Add(new SqlParameter("@Accounts_PhoneNumber", _AccountsEO.Accounts_PhoneNumber));
                    cmd.Parameters.Add(new SqlParameter("@Accounts_Permission", _AccountsEO.Accounts_Permission));
                    cmd.Parameters.Add(new SqlParameter("@Accounts_LinkAvatar", _AccountsEO.Accounts_LinkAvatar));
                    cmd.Parameters.Add(new SqlParameter("@Accounts_Signature", _AccountsEO.Accounts_Signature));
                    cmd.Parameters.Add(new SqlParameter("@Accounts_Like", _AccountsEO.Accounts_Like));
                    cmd.Parameters.Add(new SqlParameter("@Accounts_Notification", _AccountsEO.Accounts_Notification));
                    cmd.Parameters.Add(new SqlParameter("@Accounts_Status", _AccountsEO.Accounts_Status));
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
                catch (Exception)
                {
                    conn.Close();
                    return false;
                }
            }
        }

        // 2. Update
        public static bool Update(AccountsEO _AccountsEO)
        {
            using (SqlConnection conn = Connection.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Accounts_Update", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Accounts_Username", _AccountsEO.Accounts_Username));
                    cmd.Parameters.Add(new SqlParameter("@Accounts_Password", _AccountsEO.Accounts_Password));
                    cmd.Parameters.Add(new SqlParameter("@Accounts_Email", _AccountsEO.Accounts_Email));
                    cmd.Parameters.Add(new SqlParameter("@Accounts_FullName", _AccountsEO.Accounts_FullName));
                    cmd.Parameters.Add(new SqlParameter("@Accounts_Address", _AccountsEO.Accounts_Address));
                    cmd.Parameters.Add(new SqlParameter("@Accounts_DateOfBirth", _AccountsEO.Accounts_DateOfBirth));
                    cmd.Parameters.Add(new SqlParameter("@Accounts_PhoneNumber", _AccountsEO.Accounts_PhoneNumber));
                    cmd.Parameters.Add(new SqlParameter("@Accounts_Permission", _AccountsEO.Accounts_Permission));
                    cmd.Parameters.Add(new SqlParameter("@Accounts_LinkAvatar", _AccountsEO.Accounts_LinkAvatar));
                    cmd.Parameters.Add(new SqlParameter("@Accounts_Signature", _AccountsEO.Accounts_Signature));
                    cmd.Parameters.Add(new SqlParameter("@Accounts_Like", _AccountsEO.Accounts_Like));
                    cmd.Parameters.Add(new SqlParameter("@Accounts_Notification", _AccountsEO.Accounts_Notification));
                    cmd.Parameters.Add(new SqlParameter("@Accounts_Status", _AccountsEO.Accounts_Status));
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
                catch (Exception)
                {
                    conn.Close();
                    return false;
                }
            }
        }

        // 3. ResetPassword
        public static bool ResetPassword(AccountsEO _AccountsEO)
        {
            using (SqlConnection conn = Connection.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Accounts_ResetPassword", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Accounts_Username", _AccountsEO.Accounts_Username));
                    cmd.Parameters.Add(new SqlParameter("@Accounts_Password", _AccountsEO.Accounts_Password));
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
                catch (Exception)
                {
                    conn.Close();
                    return false;
                }
            }
        }

        // 4. Delete
        public static bool Delete(AccountsEO _AccountsEO)
        {
            using (SqlConnection conn = Connection.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Accounts_Delete", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Accounts_Username", _AccountsEO.Accounts_Username));
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
                catch (Exception)
                {
                    conn.Close();
                    return false;
                }
            }
        }

        // 5. Login
        public static DataSet Login(AccountsEO _AccountsEO)
        {
            DataSet ds = null;
            using (SqlConnection conn = Connection.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Accounts_Login", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@Accounts_Username", _AccountsEO.Accounts_Username));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@Accounts_Password", _AccountsEO.Accounts_Password));
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

        // 6. CheckAccounts_Username
        public static DataSet CheckAccounts_Username(AccountsEO _AccountsEO)
        {
            DataSet ds = null;
            using (SqlConnection conn = Connection.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Accounts_CheckAccounts_Username", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@Accounts_Username", _AccountsEO.Accounts_Username));
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

        // 7. CheckAccounts_Email
        public static DataSet CheckAccounts_Email(AccountsEO _AccountsEO)
        {
            DataSet ds = null;
            using (SqlConnection conn = Connection.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Accounts_CheckAccounts_Email", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@Accounts_Email", _AccountsEO.Accounts_Email));
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

        // 8. SelectListbyAccounts_Username
        public static DataSet SelectInfoByAccounts_Username(AccountsEO _AccountsEO)
        {
            DataSet ds = null;
            using (SqlConnection conn = Connection.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Accounts_SelectListbyAccounts_Username", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@Accounts_Username", _AccountsEO.Accounts_Username));
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

        // 9. SelectInfoByAccounts_ID
        public static DataSet SelectInfoByAccounts_ID(AccountsEO _AccountsEO)
        {
            DataSet ds = null;
            using (SqlConnection conn = Connection.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Accounts_SelectInfoByAccounts_ID", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@Accounts_ID", _AccountsEO.Accounts_ID));
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

        // 10. SelectInfoByAccounts_EmailvsAccounts_PhoneNumber
        public static DataSet SelectInfoByAccounts_EmailvsAccounts_PhoneNumber(AccountsEO _AccountsEO)
        {
            DataSet ds = null;
            using (SqlConnection conn = Connection.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Accounts_SelectInfoByAccounts_EmailvsAccounts_PhoneNumber", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@Accounts_Email", _AccountsEO.Accounts_Email));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@Accounts_PhoneNumber", _AccountsEO.Accounts_PhoneNumber));
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

        // 10. SearchAccounts
        public static DataSet SearchAccounts(AccountsEO _AccountsEO)
        {
            DataSet ds = null;
            using (SqlConnection conn = Connection.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Accounts_SearchAccounts", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@Accounts_Username", _AccountsEO.Accounts_Username));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@Accounts_Email", _AccountsEO.Accounts_Email));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@Accounts_FullName", _AccountsEO.Accounts_FullName));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@Accounts_Address", _AccountsEO.Accounts_Address));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@Accounts_Permission", _AccountsEO.Accounts_Permission));
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

        // 11. GetAccounts_IDbyAccounts_Username
        public static DataSet GetAccounts_IDbyAccounts_Username(AccountsEO _AccountsEO)
        {
            DataSet ds = null;
            using (SqlConnection conn = Connection.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Accounts_GetAccounts_IDbyAccounts_Username", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@Accounts_Username", _AccountsEO.Accounts_Username));
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

        // 12. SelectListByAccounts_Status
        public static DataSet SelectListByAccounts_Status(AccountsEO _AccountsEO)
        {
            DataSet ds = null;
            using (SqlConnection conn = Connection.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Accounts_SelectListByAccounts_Status", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@Accounts_Status", _AccountsEO.Accounts_Status));
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
    }
}
