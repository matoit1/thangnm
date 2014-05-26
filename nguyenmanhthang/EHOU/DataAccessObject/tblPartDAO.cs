using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EntityObject;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessObject
{
    public class tblPartDAO
    {
        #region "CheckExists"
        /// <summary> 1. Part_CheckExists </summary>
        /// <param name="_tblPartEO"></param>
        /// <returns></returns>
        public static bool Part_CheckExists(tblPartEO _tblPartEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                bool bOutput = false;
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblPart_CheckExists", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_lMaPart", _tblPartEO.PK_iPart));
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
        /// <summary> 2. Part_Insert </summary>
        /// <param name="_tblPartEO"></param>
        /// <returns></returns>
        public static bool Part_Insert(tblPartEO _tblPartEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblPart_Insert", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_iPart", _tblPartEO.PK_iPart));
                    cmd.Parameters.Add(new SqlParameter("@FK_sSubject", _tblPartEO.FK_sSubject));
                    cmd.Parameters.Add(new SqlParameter("@sTitle", _tblPartEO.sTitle));
                    cmd.Parameters.Add(new SqlParameter("@sLinkVideo", _tblPartEO.sLinkVideo));
                    cmd.Parameters.Add(new SqlParameter("@sBlackList", _tblPartEO.sBlackList));
                    cmd.Parameters.Add(new SqlParameter("@tDateTimeStart", _tblPartEO.tDateTimeStart));
                    cmd.Parameters.Add(new SqlParameter("@tDateTimeEnd", _tblPartEO.tDateTimeEnd));
                    cmd.Parameters.Add(new SqlParameter("@iStatus", _tblPartEO.iStatus));
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

        /// <summary> 3. Part_Update </summary>
        /// <param name="_tblPartEO"></param>
        /// <returns></returns>
        public static bool Part_Update(tblPartEO _tblPartEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblPart_Update", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_iPart", _tblPartEO.PK_iPart));
                    cmd.Parameters.Add(new SqlParameter("@FK_sSubject", _tblPartEO.FK_sSubject));
                    cmd.Parameters.Add(new SqlParameter("@sTitle", _tblPartEO.sTitle));
                    cmd.Parameters.Add(new SqlParameter("@sLinkVideo", _tblPartEO.sLinkVideo));
                    cmd.Parameters.Add(new SqlParameter("@sBlackList", _tblPartEO.sBlackList));
                    cmd.Parameters.Add(new SqlParameter("@tDateTimeStart", _tblPartEO.tDateTimeStart));
                    cmd.Parameters.Add(new SqlParameter("@tDateTimeEnd", _tblPartEO.tDateTimeEnd));
                    cmd.Parameters.Add(new SqlParameter("@iStatus", _tblPartEO.iStatus));
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

        /// <summary> 3. Part_Update_sLinkVideo_sBlackList </summary>
        /// <param name="_LichDayVaHocEO"></param>
        /// <returns></returns>
        public static bool Part_Update_sLinkVideo_sBlackList(tblPartEO _tblPartEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblPart_Update_sLinkVideo_sBlackList", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_iPart", _tblPartEO.PK_iPart));
                    cmd.Parameters.Add(new SqlParameter("@FK_sSubject", _tblPartEO.FK_sSubject));
                    cmd.Parameters.Add(new SqlParameter("@sLinkVideo", (_tblPartEO.sLinkVideo == null) ? (object)DBNull.Value : _tblPartEO.sLinkVideo));
                    cmd.Parameters.Add(new SqlParameter("@sBlackList", (_tblPartEO.sBlackList == null) ? (object)DBNull.Value : _tblPartEO.sBlackList));

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

        /// <summary> 4. Part_Delete </summary>
        /// <param name="_tblPartEO"></param>
        /// <returns></returns>
        public static bool Part_Delete(tblPartEO _tblPartEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblPart_Delete", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_iPart", _tblPartEO.PK_iPart));
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

        /// <summary> 5. Part_DeleteList </summary>
        /// <param name="_ListPK_sMaMonhoc"></param>
        /// <returns></returns>
        public static bool Part_DeleteList(String _ListPK_iPart)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblPart_DeleteList", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ListPK_iPart", _ListPK_iPart));
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
        /// <summary> 6. Part_SelectItem </summary>
        /// <param name="_tblPartEO"></param>
        /// <returns></returns>
        public static tblPartEO Part_SelectItem(tblPartEO _tblPartEO)
        {
            tblPartEO oOutput = new tblPartEO();
            DataSet ds = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblPart_SelectItem", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_iPart", _tblPartEO.PK_iPart));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@FK_sSubject", _tblPartEO.FK_sSubject));
                    ds = new DataSet();
                    da.Fill(ds);
                    conn.Close();
                    oOutput = DataSet2Object.Part(ds);
                    return oOutput;
                }
                catch (Exception)
                {
                    conn.Close();
                    return oOutput;
                }
            }
        }

        /// <summary> 7. Part_SelectList </summary>
        /// <param name="_tblPartEO"></param>
        /// <returns></returns>
        public static DataSet Part_SelectList(tblPartEO _tblPartEO)
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblPart_SelectList", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@FK_sSubject", _tblPartEO.FK_sSubject));
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

        /// <summary> 7. Part_SelectByFK_sSubject </summary>
        /// <param name="_tblPartEO"></param>
        /// <returns></returns>
        public static DataSet Part_SelectByFK_sSubject(tblPartEO _tblPartEO)
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblPart_SelectByFK_sSubject", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@FK_sSubject", _tblPartEO.FK_sSubject));
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

        /// <summary> 8. Part_Search </summary>
        /// <param name="_tblPartEO"></param>
        /// <returns></returns>
        public static DataSet Part_Search(tblPartEO _tblPartEO)
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblPart_Search", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_iPart", _tblPartEO.PK_iPart));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@FK_sSubject", _tblPartEO.FK_sSubject));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sTitle", _tblPartEO.sTitle));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sLinkVideo", _tblPartEO.sLinkVideo));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sBlackList", _tblPartEO.sBlackList));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@tDateTimeStart", _tblPartEO.tDateTimeStart));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@tDateTimeEnd", _tblPartEO.tDateTimeEnd));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@iStatus", _tblPartEO.iStatus));
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