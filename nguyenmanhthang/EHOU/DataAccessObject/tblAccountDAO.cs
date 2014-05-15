using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using DataAccessObject;
using EntityObject;

namespace DataAccessObject
{
    public class tblAccountDAO
    {
        #region "CheckExists"
        /// <summary> 1. Account_CheckExists </summary>
        /// <param name="tblAccountEO"></param>
        /// <returns></returns>
        public static bool Account_CheckExists(tblAccountEO tblAccountEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                bool bOutput = false;
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblAccount_CheckExists", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_sUsername", tblAccountEO.PK_sUsername));
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
        /// <param name="tblAccountEO"></param>
        /// <returns></returns>
        public static bool Account_Insert(tblAccountEO tblAccountEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblAccount_Insert", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_sUsername", tblAccountEO.PK_sUsername));
                    cmd.Parameters.Add(new SqlParameter("@sPassword", tblAccountEO.sPassword));
                    cmd.Parameters.Add(new SqlParameter("@sEmail", tblAccountEO.sEmail));
                    cmd.Parameters.Add(new SqlParameter("@iType", tblAccountEO.iType));
                    cmd.Parameters.Add(new SqlParameter("@iStatus", tblAccountEO.iStatus));
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
        /// <param name="tblAccountEO"></param>
        /// <returns></returns>
        public static bool Account_Update(tblAccountEO tblAccountEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblAccount_Update", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_sUsername", tblAccountEO.PK_sUsername));
                    cmd.Parameters.Add(new SqlParameter("@sPassword", tblAccountEO.sPassword));
                    cmd.Parameters.Add(new SqlParameter("@sEmail", tblAccountEO.sEmail));
                    cmd.Parameters.Add(new SqlParameter("@iType", tblAccountEO.iType));
                    cmd.Parameters.Add(new SqlParameter("@iStatus", tblAccountEO.iStatus));
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
        /// <param name="tblAccountEO"></param>
        /// <returns></returns>
        public static bool Account_Delete(tblAccountEO tblAccountEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblAccount_Delete", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_sUsername", tblAccountEO.PK_sUsername));
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
        public static bool Account_DeleteList(String _ListPK_sUsername)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblAccount_DeleteList", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ListPK_sUsername", _ListPK_sUsername));
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
        /// <param name="tblAccountEO"></param>
        /// <returns></returns>
        public static tblAccountEO Account_SelectItem(tblAccountEO tblAccountEO)
        {
            tblAccountEO oOutput = new tblAccountEO();
            DataSet ds = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblAccount_SelectItem", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_sUsername", tblAccountEO.PK_sUsername));
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

        /// <summary> 7. Account_SelectList </summary>
        /// <param name="tblAccountEO"></param>
        /// <returns></returns>
        public static DataSet Account_SelectList(tblAccountEO tblAccountEO)
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblAccount_SelectList", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_sUsername", tblAccountEO.PK_sUsername));
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

        /// <summary> 8. Account_Search </summary>
        /// <param name="tblAccountEO"></param>
        /// <returns></returns>
        public static DataSet Account_Search(tblAccountEO tblAccountEO)
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblAccount_Search", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_sUsername", tblAccountEO.PK_sUsername));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sPassword", tblAccountEO.sPassword));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sEmail", tblAccountEO.sEmail));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@iType", tblAccountEO.iType));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@iStatus", tblAccountEO.iStatus));
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