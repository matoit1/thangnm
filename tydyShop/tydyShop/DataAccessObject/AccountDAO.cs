using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using EntityObject;

namespace DataAccessObject
{
    public class AccountDAO
    {
        #region "CheckExists"
        /// <summary> 1. Account_CheckExists_PK_iAccountID </summary>
        /// <param name="_AccountEO"></param>
        /// <returns></returns>
        public static bool Account_CheckExists_PK_iAccountID(AccountEO _AccountEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                bool bOutput = false;
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblAccount_CheckExists_PK_iAccountID", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_iAccountID", _AccountEO.PK_iAccountID));
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        bOutput = Convert.ToBoolean(dr["return_value"]);
                    }
                    conn.Close();
                    return bOutput;
                }
                catch (Exception)
                {
                    conn.Close();
                    return bOutput;
                }
            }
        }

        /// <summary> 2. Account_CheckExists_sUsername </summary>
        /// <param name="_AccountEO"></param>
        /// <returns></returns>
        public static bool Account_CheckExists_sUsername(AccountEO _AccountEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                bool bOutput = false;
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblAccount_CheckExists_sUsername", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@sUsername", _AccountEO.sUsername));
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        bOutput = Convert.ToBoolean(dr["return_value"]);
                    }
                    conn.Close();
                    return bOutput;
                }
                catch (Exception)
                {
                    conn.Close();
                    return bOutput;
                }
            }
        }

        /// <summary> 3. Account_CheckExists_sEmail </summary>
        /// <param name="_AccountEO"></param>
        /// <returns></returns>
        public static bool Account_CheckExists_sEmail(AccountEO _AccountEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                bool bOutput = false;
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblAccount_CheckExists_sEmail", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@sEmail", _AccountEO.sEmail));
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        bOutput = Convert.ToBoolean(dr["return_value"]);
                    }
                    conn.Close();
                    return bOutput;
                }
                catch (Exception)
                {
                    conn.Close();
                    return bOutput;
                }
            }
        }
        #endregion

        #region "Insert, Update, Delete"
        /// <summary> 2. Account_Insert </summary>
        /// <param name="_AccountEO"></param>
        /// <returns></returns>
        public static bool Account_Insert(AccountEO _AccountEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblAccount_Insert", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_iAccountID", _AccountEO.PK_iAccountID));
                    cmd.Parameters.Add(new SqlParameter("@sFullName", _AccountEO.sFullName));
                    cmd.Parameters.Add(new SqlParameter("@sUsername", _AccountEO.sUsername));
                    cmd.Parameters.Add(new SqlParameter("@sPassword", _AccountEO.sPassword));
                    cmd.Parameters.Add(new SqlParameter("@sEmail", _AccountEO.sEmail));
                    cmd.Parameters.Add(new SqlParameter("@sAddress", _AccountEO.sAddress));
                    cmd.Parameters.Add(new SqlParameter("@sPhoneNumber", _AccountEO.sPhoneNumber));
                    cmd.Parameters.Add(new SqlParameter("@tDateOfBirth", _AccountEO.tDateOfBirth));
                    cmd.Parameters.Add(new SqlParameter("@iPermission", _AccountEO.iPermission));
                    cmd.Parameters.Add(new SqlParameter("@tRegisterDate", _AccountEO.tRegisterDate));
                    cmd.Parameters.Add(new SqlParameter("@sLinkAvatar", _AccountEO.sLinkAvatar));
                    cmd.Parameters.Add(new SqlParameter("@bStatus", _AccountEO.bStatus));
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

        /// <summary> 3. Account_Update </summary>
        /// <param name="_AccountEO"></param>
        /// <returns></returns>
        public static bool Account_Update(AccountEO _AccountEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblAccount_Update", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_iAccountID", _AccountEO.PK_iAccountID));
                    cmd.Parameters.Add(new SqlParameter("@sFullName", _AccountEO.sFullName));
                    cmd.Parameters.Add(new SqlParameter("@sUsername", _AccountEO.sUsername));
                    cmd.Parameters.Add(new SqlParameter("@sPassword", _AccountEO.sPassword));
                    cmd.Parameters.Add(new SqlParameter("@sEmail", _AccountEO.sEmail));
                    cmd.Parameters.Add(new SqlParameter("@sAddress", _AccountEO.sAddress));
                    cmd.Parameters.Add(new SqlParameter("@sPhoneNumber", _AccountEO.sPhoneNumber));
                    cmd.Parameters.Add(new SqlParameter("@tDateOfBirth", _AccountEO.tDateOfBirth));
                    cmd.Parameters.Add(new SqlParameter("@iPermission", _AccountEO.iPermission));
                    cmd.Parameters.Add(new SqlParameter("@tRegisterDate", _AccountEO.tRegisterDate));
                    cmd.Parameters.Add(new SqlParameter("@sLinkAvatar", _AccountEO.sLinkAvatar));
                    cmd.Parameters.Add(new SqlParameter("@bStatus", _AccountEO.bStatus));
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

        /// <summary> 3. Account_ResetPassword </summary>
        /// <param name="_AccountEO"></param>
        /// <returns></returns>
        public static bool Account_ResetPassword(AccountEO _AccountEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblAccount_ResetPassword", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@sUsername", _AccountEO.sUsername));
                    cmd.Parameters.Add(new SqlParameter("@sPassword", _AccountEO.sPassword));
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

        /// <summary> 4. Account_Delete </summary>
        /// <param name="_AccountEO"></param>
        /// <returns></returns>
        public static bool Account_Delete(AccountEO _AccountEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblAccount_Delete", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_iAccountID", _AccountEO.PK_iAccountID));
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

        /// <summary> 5. Account_DeleteList </summary>
        /// <param name="_ListPK_sMaMonhoc"></param>
        /// <returns></returns>
        public static bool Account_DeleteList(String _ListPK_iAccountID)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblAccount_DeleteList", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ListPK_iAccountID", _ListPK_iAccountID));
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
        #endregion

        #region "Select"
        /// <summary> 6. Account_SelectItem </summary>
        /// <param name="_AccountEO"></param>
        /// <returns></returns>
        public static AccountEO Account_SelectItem(AccountEO _AccountEO)
        {
            AccountEO oOutput = new AccountEO();
            DataSet ds = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblAccount_SelectItem", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_iAccountID", _AccountEO.PK_iAccountID));
                    ds = new DataSet();
                    da.Fill(ds);
                    conn.Close();
                    oOutput = DataSet2Object.Account(ds);
                    return oOutput;
                }
                catch (Exception)
                {
                    conn.Close();
                    return oOutput;
                }
            }
        }

        /// <summary> 7. Account_SelectBysUsername </summary>
        /// <param name="_AccountEO"></param>
        /// <returns></returns>
        public static AccountEO Account_SelectBysUsername(AccountEO _AccountEO)
        {
            AccountEO oOutput = new AccountEO();
            DataSet ds = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblAccount_SelectBysUsername", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sUsername", _AccountEO.sUsername));
                    ds = new DataSet();
                    da.Fill(ds);
                    conn.Close();
                    oOutput = DataSet2Object.Account(ds);
                    return oOutput;
                }
                catch (Exception)
                {
                    conn.Close();
                    return oOutput;
                }
            }
        }

        /// <summary> 8. Account_SelectBysEmailvssPhoneNumber </summary>
        /// <param name="_AccountEO"></param>
        /// <returns></returns>
        public static AccountEO Account_SelectBysEmailvssPhoneNumber(AccountEO _AccountEO)
        {
            AccountEO oOutput = new AccountEO();
            DataSet ds = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblAccount_SelectBysEmailvssPhoneNumber", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sEmail", _AccountEO.sEmail));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sPhoneNumber", _AccountEO.sPhoneNumber));
                    ds = new DataSet();
                    da.Fill(ds);
                    conn.Close();
                    oOutput = DataSet2Object.Account(ds);
                    return oOutput;
                }
                catch (Exception)
                {
                    conn.Close();
                    return oOutput;
                }
            }
        }

        /// <summary> 8. Account_SelectList </summary>
        /// <param name="_AccountEO"></param>
        /// <returns></returns>
        public static DataSet Account_SelectList()
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblAccount_SelectList", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    dsOutput = new DataSet();
                    da.Fill(dsOutput);
                    conn.Close();
                    return dsOutput;
                }
                catch (Exception)
                {
                    conn.Close();
                    return dsOutput;
                }
            }
        }

        /// <summary> 9. Account_Search </summary>
        /// <param name="_AccountEO"></param>
        /// <returns></returns>
        public static DataSet Account_Search(AccountEO _AccountEO)
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblAccount_Search", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_iAccountID", _AccountEO.PK_iAccountID));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sFullName", _AccountEO.sFullName));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sUsername", _AccountEO.sUsername));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sPassword", _AccountEO.sPassword));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sEmail", _AccountEO.sEmail));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sAddress", _AccountEO.sAddress));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sPhoneNumber", _AccountEO.sPhoneNumber));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@tDateOfBirth", _AccountEO.tDateOfBirth));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@iPermission", _AccountEO.iPermission));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@tRegisterDate", _AccountEO.tRegisterDate));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sLinkAvatar", _AccountEO.sLinkAvatar));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@bStatus", _AccountEO.bStatus));
                    dsOutput = new DataSet();
                    da.Fill(dsOutput);
                    conn.Close();
                    return dsOutput;
                }
                catch (Exception)
                {
                    conn.Close();
                    return dsOutput;
                }
            }
        }

        /// <summary> 10. Account_Login </summary>
        /// <param name="_AccountEO"></param>
        /// <returns></returns>
        public static DataSet Account_Login(AccountEO _AccountEO)
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblAccount_Login", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sUsername", _AccountEO.sUsername));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sPassword", _AccountEO.sPassword));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@iPermission", _AccountEO.iPermission));
                    dsOutput = new DataSet();
                    da.Fill(dsOutput);
                    conn.Close();
                    return dsOutput;
                }
                catch (Exception)
                {
                    conn.Close();
                    return dsOutput;
                }
            }
        }
        #endregion
    }
}
