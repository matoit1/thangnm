using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using EntityObject;

namespace DataAccessObject
{
    public class AccountsDAO
    {
        // Begin Insert Table Accounts Admin
        public static bool setInsertAccountsAdmin(AccountsEO _AccountsEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("ThangNMjsc_InsertAccountsAdmin", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Accounts_Username", _AccountsEO.Accounts_Username));
                    cmd.Parameters.Add(new SqlParameter("@Accounts_Password", _AccountsEO.Accounts_Password));
                    cmd.Parameters.Add(new SqlParameter("@Accounts_Email", _AccountsEO.Accounts_Email));
                    cmd.Parameters.Add(new SqlParameter("@Accounts_Permission", _AccountsEO.Accounts_Permission));
                    cmd.Parameters.Add(new SqlParameter("@Accounts_LinkAvatar", _AccountsEO.Accounts_LinkAvatar));
                    cmd.Parameters.Add(new SqlParameter("@Accounts_FullName", _AccountsEO.Accounts_FullName));
                    cmd.Parameters.Add(new SqlParameter("@Accounts_Address", _AccountsEO.Accounts_Address));
                    cmd.Parameters.Add(new SqlParameter("@Accounts_DateOfBirth", _AccountsEO.Accounts_DateOfBirth));
                    cmd.Parameters.Add(new SqlParameter("@Accounts_PhoneNumber", _AccountsEO.Accounts_PhoneNumber));
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
        // End Insert Table Accounts Admin




        // Begin Insert Table Accounts
        public static bool setInsertAccounts(AccountsEO _AccountsEO)
        {

            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("ThangNMjsc_InsertAccounts", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Accounts_Username", _AccountsEO.Accounts_Username));
                    cmd.Parameters.Add(new SqlParameter("@Accounts_Password", _AccountsEO.Accounts_Password));
                    cmd.Parameters.Add(new SqlParameter("@Accounts_Email", _AccountsEO.Accounts_Email));
                    cmd.Parameters.Add(new SqlParameter("@Accounts_LinkAvatar", _AccountsEO.Accounts_LinkAvatar));
                    cmd.Parameters.Add(new SqlParameter("@Accounts_FullName", _AccountsEO.Accounts_FullName));
                    cmd.Parameters.Add(new SqlParameter("@Accounts_Address", _AccountsEO.Accounts_Address));
                    cmd.Parameters.Add(new SqlParameter("@Accounts_DateOfBirth", _AccountsEO.Accounts_DateOfBirth));
                    cmd.Parameters.Add(new SqlParameter("@Accounts_PhoneNumber", _AccountsEO.Accounts_PhoneNumber));
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
        // End Insert Table Accounts



        // Begin Update Table Accounts Admin
        public static bool setUpdateAccountsAdmin(AccountsEO _AccountsEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("ThangNMjsc_UpdateAccountsAdmin", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Accounts_Username", _AccountsEO.Accounts_Username));
                    cmd.Parameters.Add(new SqlParameter("@Accounts_Password", _AccountsEO.Accounts_Password));
                    cmd.Parameters.Add(new SqlParameter("@Accounts_Email", _AccountsEO.Accounts_Email));
                    cmd.Parameters.Add(new SqlParameter("@Accounts_Permission", _AccountsEO.Accounts_Permission));
                    cmd.Parameters.Add(new SqlParameter("@Accounts_LinkAvatar", _AccountsEO.Accounts_LinkAvatar));
                    cmd.Parameters.Add(new SqlParameter("@Accounts_FullName", _AccountsEO.Accounts_FullName));
                    cmd.Parameters.Add(new SqlParameter("@Accounts_Address", _AccountsEO.Accounts_Address));
                    cmd.Parameters.Add(new SqlParameter("@Accounts_DateOfBirth", _AccountsEO.Accounts_DateOfBirth));
                    cmd.Parameters.Add(new SqlParameter("@Accounts_PhoneNumber", _AccountsEO.Accounts_PhoneNumber));
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
        // End Update Table Accounts Admin



        // Begin Update Table Accounts
        public static bool setUpdateAccounts(AccountsEO _AccountsEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("ThangNMjsc_UpdateAccounts", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Accounts_Username", _AccountsEO.Accounts_Username));
                    cmd.Parameters.Add(new SqlParameter("@Accounts_Password", _AccountsEO.Accounts_Password));
                    cmd.Parameters.Add(new SqlParameter("@Accounts_Email", _AccountsEO.Accounts_Email));
                    cmd.Parameters.Add(new SqlParameter("@Accounts_LinkAvatar", _AccountsEO.Accounts_LinkAvatar));
                    cmd.Parameters.Add(new SqlParameter("@Accounts_FullName", _AccountsEO.Accounts_FullName));
                    cmd.Parameters.Add(new SqlParameter("@Accounts_Address", _AccountsEO.Accounts_Address));
                    cmd.Parameters.Add(new SqlParameter("@Accounts_DateOfBirth", _AccountsEO.Accounts_DateOfBirth));
                    cmd.Parameters.Add(new SqlParameter("@Accounts_PhoneNumber", _AccountsEO.Accounts_PhoneNumber));
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
        // End Update Table Accounts




        // Begin ThangNMjsc_ResetPasswordAccounts
        public static bool setResetPasswordAccounts(AccountsEO _AccountsEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("ThangNMjsc_ResetPasswordAccounts", conn);
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
        // End ThangNMjsc_ResetPasswordAccounts


        // Begin Delete Table Accounts
        public static bool setdeleteAccountsbyUsername(String Accounts_Username)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("ThangNMjsc_deleteAccountsbyUsername", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Accounts_Username", Accounts_Username));
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
        // End Delete Table Accounts



        // Begin Login Admin
        public static DataSet LoginAccountsAdmin(AccountsEO _AccountsEO)
        {
            DataSet ds = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Accounts_Login", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@Accounts_Username", _AccountsEO.Accounts_Username));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@Accounts_Password", _AccountsEO.Accounts_Password));
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
        // End Login Admin


        // Begin Login
        public static DataSet setLoginAccounts(string Accounts_Username, string Accounts_Password)
        {
            DataSet ds = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("ThangNMjsc_LoginAccounts", conn);
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
        // End Login




        // Begin Select Account Staff
        public static DataSet AllStaff(int Permission)
        {
            DataSet ds = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("ThangNMjsc_AllStaff", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@Permission", Permission));
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
        // End Select Account Staff



        // Begin Select Account Customer
        public static DataSet AllCustomer(int Permission)
        {
            DataSet ds = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("ThangNMjsc_Customer", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@Permission", Permission));

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
        // End Select Account Customer




        // Begin Check Email
        public static DataSet setCheckEmailAccounts(string Accounts_Email)
        {
            DataSet ds = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("ThangNMjsc_CheckEmailAccounts", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@Accounts_Email", Accounts_Email));
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
        // End Check Email



        // Begin Check Username 
        public static DataSet setCheckUsernameAccounts(string Accounts_Username)
        {
            DataSet ds = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("ThangNMjsc_CheckAccounts", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@Accounts_Username", Accounts_Username));
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
        // End Test Email


        //Begin Get Dataset Accounts
        public static DataSet getDataSetAccounts(int Accounts_Permission)
        {
            DataSet ds = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("ThangNMjsc_getDataSetAccounts", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@Accounts_Permission", Accounts_Permission));
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
        //End Get Dataset Accounts





        //Begin Accounts_Select_ByAccounts_Username
        public static DataSet Accounts_Select_ByAccounts_Username(AccountsEO _AccountsEO)
        {
            DataSet ds = new DataSet();
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Accounts_Select_ByAccounts_Username", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Accounts_Username", _AccountsEO.Accounts_Username));
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
        //End Accounts_Select_ByAccounts_Username





        //Begin Get DataSet Search Accounts by Fullname
        public static DataSet DataSetSearchAccountsbyFullname(string Accounts_Fullname, string Accounts_Username, string Accounts_Email, string Accounts_Permission, string Accounts_Address)
        {
            DataSet ds = new DataSet();
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("ThangNMjsc_SearchAccountsbyFullname", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Accounts_Fullname", Accounts_Fullname));
                    cmd.Parameters.Add(new SqlParameter("@Accounts_Username", Accounts_Username));
                    cmd.Parameters.Add(new SqlParameter("@Accounts_Email", Accounts_Email));
                    cmd.Parameters.Add(new SqlParameter("@Accounts_Permission", Accounts_Permission));
                    cmd.Parameters.Add(new SqlParameter("@Accounts_Address", Accounts_Address));
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
        //End Get DataSet Search Accounts by Fullname
    }
}
