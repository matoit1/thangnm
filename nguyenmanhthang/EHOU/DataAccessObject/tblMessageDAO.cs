using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using DataAccessObject;
using System.Data;
using EntityObject;

namespace DataAccessObject
{
    public class tblMessageDAO
    {
        #region "CheckExists"
        /// <summary> 1. Message_CheckExists </summary>
        /// <param name="_tblMessageEO"></param>
        /// <returns></returns>
        public static bool Message_CheckExists(tblMessageEO _tblMessageEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                bool bOutput = false;
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblMessage_CheckExists", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_lMaMessage", _tblMessageEO.PK_lMessage));
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
        /// <summary> 2. Message_Insert </summary>
        /// <param name="_tblMessageEO"></param>
        /// <returns></returns>
        public static bool Message_Insert(tblMessageEO _tblMessageEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblMessage_Insert", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@FK_sRoom", _tblMessageEO.FK_sRoom));
                    cmd.Parameters.Add(new SqlParameter("@FK_sUsername", _tblMessageEO.FK_sUsername));
                    cmd.Parameters.Add(new SqlParameter("@sContent", _tblMessageEO.sContent));
                    //cmd.Parameters.Add(new SqlParameter("@tNgayGui", _tblMessageEO.tNgayGui));
                    cmd.Parameters.Add(new SqlParameter("@iStatus", _tblMessageEO.iStatus));
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

        /// <summary> 3. Message_Update </summary>
        /// <param name="_tblMessageEO"></param>
        /// <returns></returns>
        public static bool Message_Update(tblMessageEO _tblMessageEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblMessage_Update", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_lMessage", _tblMessageEO.PK_lMessage));
                    cmd.Parameters.Add(new SqlParameter("@FK_sRoom", _tblMessageEO.FK_sRoom));
                    cmd.Parameters.Add(new SqlParameter("@FK_sUsername", _tblMessageEO.FK_sUsername));
                    cmd.Parameters.Add(new SqlParameter("@sContent", _tblMessageEO.sContent));
                    //cmd.Parameters.Add(new SqlParameter("@tNgayGui", _tblMessageEO.tNgayGui));
                    cmd.Parameters.Add(new SqlParameter("@iStatus", _tblMessageEO.iStatus));
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

        /// <summary> 4. Message_Delete </summary>
        /// <param name="_tblMessageEO"></param>
        /// <returns></returns>
        public static bool Message_Delete(tblMessageEO _tblMessageEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblMessage_Delete", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_lMessage", _tblMessageEO.PK_lMessage));
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

        /// <summary> 5. Message_DeleteList </summary>
        /// <param name="_ListPK_sMaMonhoc"></param>
        /// <returns></returns>
        public static bool Message_DeleteList(String _ListPK_lMessage)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblMessage_DeleteList", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ListPK_lMessage", _ListPK_lMessage));
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
        /// <summary> 6. Message_SelectItem </summary>
        /// <param name="_tblMessageEO"></param>
        /// <returns></returns>
        public static tblMessageEO Message_SelectItem(tblMessageEO _tblMessageEO)
        {
            tblMessageEO oOutput = new tblMessageEO();
            DataSet ds = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblMessage_SelectItem", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_lMessage", _tblMessageEO.PK_lMessage));
                    ds = new DataSet();
                    da.Fill(ds);
                    conn.Close();
                    oOutput = DataSet2Object.Message(ds);
                    return oOutput;
                }
                catch (Exception)
                {
                    conn.Close();
                    return oOutput;
                }
            }
        }

        /// <summary> 7. Message_SelectList </summary>
        /// <param name="_tblMessageEO"></param>
        /// <returns></returns>
        public static DataSet Message_SelectList(tblMessageEO _tblMessageEO)
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblMessage_SelectList", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@FK_sRoom", _tblMessageEO.FK_sRoom));
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

        /// <summary> 8. Message_Search </summary>
        /// <param name="_tblMessageEO"></param>
        /// <returns></returns>
        public static DataSet Message_Search(tblMessageEO _tblMessageEO)
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblMessage_Search", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_lMessage", _tblMessageEO.PK_lMessage));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@FK_sRoom", _tblMessageEO.FK_sRoom));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@FK_sUsername", _tblMessageEO.FK_sUsername));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sContent", _tblMessageEO.sContent));
                    //cmd.Parameters.Add(new SqlParameter("@tNgayGui", _tblMessageEO.tNgayGui));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@iStatus", _tblMessageEO.iStatus));
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