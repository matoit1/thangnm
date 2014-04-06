using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using EntityObject;

namespace DataAccessObject
{
    public class ErrorDAO
    {
        #region "CheckExists"
        /// <summary> 1. Error_CheckExists </summary>
        /// <param name="_ErrorEO"></param>
        /// <returns></returns>
        public static bool Error_CheckExists(ErrorEO _ErrorEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                bool bOutput = false;
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblError_CheckExists", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_lErrorID", _ErrorEO.PK_lErrorID));
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
        /// <summary> 2. Error_Insert </summary>
        /// <param name="_ErrorEO"></param>
        /// <returns></returns>
        public static bool Error_Insert(ErrorEO _ErrorEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblError_Insert", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_lErrorID", _ErrorEO.PK_lErrorID));
                    cmd.Parameters.Add(new SqlParameter("@sLink", _ErrorEO.sLink));
                    cmd.Parameters.Add(new SqlParameter("@sIP", _ErrorEO.sIP));
                    cmd.Parameters.Add(new SqlParameter("@sBrowser", _ErrorEO.sBrowser));
                    cmd.Parameters.Add(new SqlParameter("@iCodes", _ErrorEO.iCodes));
                    cmd.Parameters.Add(new SqlParameter("@iStatus", _ErrorEO.iStatus));
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

        /// <summary> 3. Error_Update </summary>
        /// <param name="_ErrorEO"></param>
        /// <returns></returns>
        public static bool Error_Update(ErrorEO _ErrorEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblError_Update", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_lErrorID", _ErrorEO.PK_lErrorID));
                    cmd.Parameters.Add(new SqlParameter("@sLink", _ErrorEO.sLink));
                    cmd.Parameters.Add(new SqlParameter("@sIP", _ErrorEO.sIP));
                    cmd.Parameters.Add(new SqlParameter("@sBrowser", _ErrorEO.sBrowser));
                    cmd.Parameters.Add(new SqlParameter("@iCodes", _ErrorEO.iCodes));
                    cmd.Parameters.Add(new SqlParameter("@iStatus", _ErrorEO.iStatus));
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

        /// <summary> 4. Error_Delete </summary>
        /// <param name="_ErrorEO"></param>
        /// <returns></returns>
        public static bool Error_Delete(ErrorEO _ErrorEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblError_Delete", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_lErrorID", _ErrorEO.PK_lErrorID));
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

        /// <summary> 5. Error_DeleteList </summary>
        /// <param name="_ListPK_sMaMonhoc"></param>
        /// <returns></returns>
        public static bool Error_DeleteList(String _ListPK_lErrorID)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblError_DeleteList", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ListPK_lErrorID", _ListPK_lErrorID));
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
        /// <summary> 6. Error_SelectItem </summary>
        /// <param name="_ErrorEO"></param>
        /// <returns></returns>
        public static ErrorEO Error_SelectItem(ErrorEO _ErrorEO)
        {
            ErrorEO oOutput = new ErrorEO();
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblError_SelectItem", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_lErrorID", _ErrorEO.PK_lErrorID));
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    conn.Close();
                    oOutput = DataSet2Object.Error(ds);
                    return oOutput = DataSet2Object.Error(ds);
                }
                catch (Exception)
                {
                    conn.Close();
                    return oOutput;
                }
            }
        }

        /// <summary> 7. Error_SelectList </summary>
        /// <param name="_ErrorEO"></param>
        /// <returns></returns>
        public static DataSet Error_SelectList()
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblError_SelectList", conn);
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

        /// <summary> 8. Error_Search </summary>
        /// <param name="_ErrorEO"></param>
        /// <returns></returns>
        public static DataSet Error_Search(ErrorEO _ErrorEO)
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblError_Search", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_lErrorID", _ErrorEO.PK_lErrorID));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sLink", _ErrorEO.sLink));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sIP", _ErrorEO.sIP));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sBrowser", _ErrorEO.sBrowser));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@iCodes", _ErrorEO.iCodes));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@tTime", _ErrorEO.tTime));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@tTimeCheck", _ErrorEO.tTimeCheck));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@iStatus", _ErrorEO.iStatus));
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