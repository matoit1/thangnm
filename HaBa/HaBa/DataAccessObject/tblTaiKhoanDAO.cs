using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using HaBa.EntityObject;

namespace HaBa.DataAccessObject
{
    public class tblTaiKhoanDAO
    {
        #region "CheckExists"
        /// <summary> 1. Account_CheckExists_PK_iAccountID </summary>
        /// <param name="_tblTaiKhoanEO"></param>
        /// <returns></returns>
        public static bool Account_CheckExists_PK_iAccountID(tblTaiKhoanEO _tblTaiKhoanEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                bool bOutput = false;
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblAccount_CheckExists_PK_iAccountID", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_iAccountID", _tblTaiKhoanEO.PK_iAccountID));
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
        /// <param name="_tblTaiKhoanEO"></param>
        /// <returns></returns>
        public static bool Account_CheckExists_sUsername(tblTaiKhoanEO _tblTaiKhoanEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                bool bOutput = false;
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblAccount_CheckExists_sUsername", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@sUsername", _tblTaiKhoanEO.sUsername));
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
        /// <param name="_tblTaiKhoanEO"></param>
        /// <returns></returns>
        public static bool Account_CheckExists_sEmail(tblTaiKhoanEO _tblTaiKhoanEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                bool bOutput = false;
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblAccount_CheckExists_sEmail", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@sEmail", _tblTaiKhoanEO.sEmail));
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
        /// <param name="_tblTaiKhoanEO"></param>
        /// <returns></returns>
        public static bool Account_Insert(tblTaiKhoanEO _tblTaiKhoanEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblAccount_Insert", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_iAccountID", _tblTaiKhoanEO.PK_iAccountID));
                    cmd.Parameters.Add(new SqlParameter("@sFullName", _tblTaiKhoanEO.sFullName));
                    cmd.Parameters.Add(new SqlParameter("@sUsername", _tblTaiKhoanEO.sUsername));
                    cmd.Parameters.Add(new SqlParameter("@sPassword", _tblTaiKhoanEO.sPassword));
                    cmd.Parameters.Add(new SqlParameter("@sEmail", _tblTaiKhoanEO.sEmail));
                    cmd.Parameters.Add(new SqlParameter("@sAddress", _tblTaiKhoanEO.sAddress));
                    cmd.Parameters.Add(new SqlParameter("@sPhoneNumber", _tblTaiKhoanEO.sPhoneNumber));
                    cmd.Parameters.Add(new SqlParameter("@tDateOfBirth", _tblTaiKhoanEO.tDateOfBirth));
                    cmd.Parameters.Add(new SqlParameter("@iPermission", _tblTaiKhoanEO.iPermission));
                    cmd.Parameters.Add(new SqlParameter("@tRegisterDate", _tblTaiKhoanEO.tRegisterDate));
                    cmd.Parameters.Add(new SqlParameter("@sLinkAvatar", _tblTaiKhoanEO.sLinkAvatar));
                    cmd.Parameters.Add(new SqlParameter("@bStatus", _tblTaiKhoanEO.bStatus));
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
        /// <param name="_tblTaiKhoanEO"></param>
        /// <returns></returns>
        public static bool Account_Update(tblTaiKhoanEO _tblTaiKhoanEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblAccount_Update", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_iAccountID", _tblTaiKhoanEO.PK_iAccountID));
                    cmd.Parameters.Add(new SqlParameter("@sFullName", _tblTaiKhoanEO.sFullName));
                    cmd.Parameters.Add(new SqlParameter("@sUsername", _tblTaiKhoanEO.sUsername));
                    cmd.Parameters.Add(new SqlParameter("@sPassword", _tblTaiKhoanEO.sPassword));
                    cmd.Parameters.Add(new SqlParameter("@sEmail", _tblTaiKhoanEO.sEmail));
                    cmd.Parameters.Add(new SqlParameter("@sAddress", _tblTaiKhoanEO.sAddress));
                    cmd.Parameters.Add(new SqlParameter("@sPhoneNumber", _tblTaiKhoanEO.sPhoneNumber));
                    cmd.Parameters.Add(new SqlParameter("@tDateOfBirth", _tblTaiKhoanEO.tDateOfBirth));
                    cmd.Parameters.Add(new SqlParameter("@iPermission", _tblTaiKhoanEO.iPermission));
                    cmd.Parameters.Add(new SqlParameter("@tRegisterDate", _tblTaiKhoanEO.tRegisterDate));
                    cmd.Parameters.Add(new SqlParameter("@sLinkAvatar", _tblTaiKhoanEO.sLinkAvatar));
                    cmd.Parameters.Add(new SqlParameter("@bStatus", _tblTaiKhoanEO.bStatus));
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
        /// <param name="_tblTaiKhoanEO"></param>
        /// <returns></returns>
        public static bool Account_ResetPassword(tblTaiKhoanEO _tblTaiKhoanEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblAccount_ResetPassword", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@sUsername", _tblTaiKhoanEO.sUsername));
                    cmd.Parameters.Add(new SqlParameter("@sPassword", _tblTaiKhoanEO.sPassword));
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
        /// <param name="_tblTaiKhoanEO"></param>
        /// <returns></returns>
        public static bool Account_Delete(tblTaiKhoanEO _tblTaiKhoanEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblAccount_Delete", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_iAccountID", _tblTaiKhoanEO.PK_iAccountID));
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
        /// <param name="_tblTaiKhoanEO"></param>
        /// <returns></returns>
        public static tblTaiKhoanEO Account_SelectItem(tblTaiKhoanEO _tblTaiKhoanEO)
        {
            tblTaiKhoanEO oOutput = new tblTaiKhoanEO();
            DataSet ds = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblAccount_SelectItem", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_iAccountID", _tblTaiKhoanEO.PK_iAccountID));
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
        /// <param name="_tblTaiKhoanEO"></param>
        /// <returns></returns>
        public static tblTaiKhoanEO Account_SelectBysUsername(tblTaiKhoanEO _tblTaiKhoanEO)
        {
            tblTaiKhoanEO oOutput = new tblTaiKhoanEO();
            DataSet ds = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblAccount_SelectBysUsername", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sUsername", _tblTaiKhoanEO.sUsername));
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
        /// <param name="_tblTaiKhoanEO"></param>
        /// <returns></returns>
        public static tblTaiKhoanEO Account_SelectBysEmailvssPhoneNumber(tblTaiKhoanEO _tblTaiKhoanEO)
        {
            tblTaiKhoanEO oOutput = new tblTaiKhoanEO();
            DataSet ds = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblAccount_SelectBysEmailvssPhoneNumber", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sEmail", _tblTaiKhoanEO.sEmail));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sPhoneNumber", _tblTaiKhoanEO.sPhoneNumber));
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
        /// <param name="_tblTaiKhoanEO"></param>
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
        /// <param name="_tblTaiKhoanEO"></param>
        /// <returns></returns>
        public static DataSet Account_Search(tblTaiKhoanEO _tblTaiKhoanEO)
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblAccount_Search", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_iAccountID", _tblTaiKhoanEO.PK_iAccountID));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sFullName", _tblTaiKhoanEO.sFullName));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sUsername", _tblTaiKhoanEO.sUsername));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sPassword", _tblTaiKhoanEO.sPassword));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sEmail", _tblTaiKhoanEO.sEmail));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sAddress", _tblTaiKhoanEO.sAddress));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sPhoneNumber", _tblTaiKhoanEO.sPhoneNumber));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@tDateOfBirth", _tblTaiKhoanEO.tDateOfBirth));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@iPermission", _tblTaiKhoanEO.iPermission));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@tRegisterDate", _tblTaiKhoanEO.tRegisterDate));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sLinkAvatar", _tblTaiKhoanEO.sLinkAvatar));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@bStatus", _tblTaiKhoanEO.bStatus));
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
        /// <param name="_tblTaiKhoanEO"></param>
        /// <returns></returns>
        public static DataSet Account_Login(tblTaiKhoanEO _tblTaiKhoanEO)
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblAccount_Login", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sUsername", _tblTaiKhoanEO.sUsername));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sPassword", _tblTaiKhoanEO.sPassword));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@iPermission", _tblTaiKhoanEO.iPermission));
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