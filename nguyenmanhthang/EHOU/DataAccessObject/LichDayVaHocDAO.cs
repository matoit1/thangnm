using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using EntityObject;

namespace DataAccessObject
{
    public class LichDayVaHocDAO
    {
        #region "CheckExists"
        /// <summary> 1. LichDayVaHoc_CheckExists </summary>
        /// <param name="_LichDayVaHocEO"></param>
        /// <returns></returns>
        public static bool LichDayVaHoc_CheckExists(LichDayVaHocEO _LichDayVaHocEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                bool bOutput = false;
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblLichDayVaHoc_CheckExists", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@FK_sMaPCCT", _LichDayVaHocEO.FK_sMaPCCT));
                    cmd.Parameters.Add(new SqlParameter("@FK_sMalop", _LichDayVaHocEO.FK_sMalop));
                    cmd.Parameters.Add(new SqlParameter("@iCaHoc", _LichDayVaHocEO.iCaHoc));
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
        /// <summary> 2. LichDayVaHoc_Insert </summary>
        /// <param name="_LichDayVaHocEO"></param>
        /// <returns></returns>
        public static bool LichDayVaHoc_Insert(LichDayVaHocEO _LichDayVaHocEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblLichDayVaHoc_Insert", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@FK_sMaPCCT", _LichDayVaHocEO.FK_sMaPCCT));
                    cmd.Parameters.Add(new SqlParameter("@FK_sMalop", _LichDayVaHocEO.FK_sMalop));
                    cmd.Parameters.Add(new SqlParameter("@iCaHoc", _LichDayVaHocEO.iCaHoc));
                    cmd.Parameters.Add(new SqlParameter("@tNgayDay", _LichDayVaHocEO.tNgayDay));
                    cmd.Parameters.Add(new SqlParameter("@iSoTietDay", _LichDayVaHocEO.iSoTietDay));
                    cmd.Parameters.Add(new SqlParameter("@sSinhVienNghi", _LichDayVaHocEO.sSinhVienNghi));
                    cmd.Parameters.Add(new SqlParameter("@sSinhVienChan", _LichDayVaHocEO.sSinhVienChan));
                    cmd.Parameters.Add(new SqlParameter("@sLinkVideo", _LichDayVaHocEO.sLinkVideo));
                    cmd.Parameters.Add(new SqlParameter("@iTrangThai", _LichDayVaHocEO.iTrangThai));
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

        /// <summary> 3. LichDayVaHoc_Update </summary>
        /// <param name="_LichDayVaHocEO"></param>
        /// <returns></returns>
        public static bool LichDayVaHoc_Update(LichDayVaHocEO _LichDayVaHocEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblLichDayVaHoc_Update", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@FK_sMaPCCT", _LichDayVaHocEO.FK_sMaPCCT));
                    cmd.Parameters.Add(new SqlParameter("@FK_sMalop", _LichDayVaHocEO.FK_sMalop));
                    cmd.Parameters.Add(new SqlParameter("@iCaHoc", _LichDayVaHocEO.iCaHoc));
                    cmd.Parameters.Add(new SqlParameter("@tNgayDay", _LichDayVaHocEO.tNgayDay));
                    cmd.Parameters.Add(new SqlParameter("@iSoTietDay", _LichDayVaHocEO.iSoTietDay));
                    cmd.Parameters.Add(new SqlParameter("@sSinhVienNghi", _LichDayVaHocEO.sSinhVienNghi));
                    cmd.Parameters.Add(new SqlParameter("@sSinhVienChan", _LichDayVaHocEO.sSinhVienChan));
                    cmd.Parameters.Add(new SqlParameter("@sLinkVideo", _LichDayVaHocEO.sLinkVideo));
                    cmd.Parameters.Add(new SqlParameter("@iTrangThai", _LichDayVaHocEO.iTrangThai));
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

        /// <summary> 3. LichDayVaHoc_UpdateLinkVideo </summary>
        /// <param name="_LichDayVaHocEO"></param>
        /// <returns></returns>
        public static bool LichDayVaHoc_Update_sSinhVienNghi_sSinhVienChan_sLinkVideo(LichDayVaHocEO _LichDayVaHocEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblLichDayVaHoc_Update_sSinhVienNghi_sSinhVienChan_sLinkVideo", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@FK_sMaPCCT", _LichDayVaHocEO.FK_sMaPCCT));
                    cmd.Parameters.Add(new SqlParameter("@FK_sMalop", _LichDayVaHocEO.FK_sMalop));
                    cmd.Parameters.Add(new SqlParameter("@iCaHoc", _LichDayVaHocEO.iCaHoc));
                    cmd.Parameters.Add(new SqlParameter("@sSinhVienNghi", (_LichDayVaHocEO.sSinhVienNghi == null) ? (object)DBNull.Value : _LichDayVaHocEO.sSinhVienNghi));
                    cmd.Parameters.Add(new SqlParameter("@sSinhVienChan", (_LichDayVaHocEO.sSinhVienChan == null) ? (object)DBNull.Value : _LichDayVaHocEO.sSinhVienChan));
                    cmd.Parameters.Add(new SqlParameter("@sLinkVideo", (_LichDayVaHocEO.sLinkVideo == null) ? (object)DBNull.Value : _LichDayVaHocEO.sLinkVideo));
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

        /// <summary> 4. LichDayVaHoc_Delete </summary>
        /// <param name="_LichDayVaHocEO"></param>
        /// <returns></returns>
        public static bool LichDayVaHoc_Delete(LichDayVaHocEO _LichDayVaHocEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblLichDayVaHoc_Delete", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@FK_sMaPCCT", _LichDayVaHocEO.FK_sMaPCCT));
                    cmd.Parameters.Add(new SqlParameter("@FK_sMalop", _LichDayVaHocEO.FK_sMalop));
                    cmd.Parameters.Add(new SqlParameter("@iCaHoc", _LichDayVaHocEO.iCaHoc));
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

        /// <summary> 5. LichDayVaHoc_DeleteList </summary>
        /// <param name="_ListPK_sMaMonhoc"></param>
        /// <returns></returns>
        public static bool LichDayVaHoc_DeleteList(String _ListFK_sMaPCCT)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblLichDayVaHoc_DeleteList", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ListFK_sMaPCCT", _ListFK_sMaPCCT));
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
        /// <summary> 6. LichDayVaHoc_SelectItem </summary>
        /// <param name="_LichDayVaHocEO"></param>
        /// <returns></returns>
        public static LichDayVaHocEO LichDayVaHoc_SelectItem(LichDayVaHocEO _LichDayVaHocEO)
        {
            LichDayVaHocEO oOutput = new LichDayVaHocEO();
            DataSet ds = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblLichDayVaHoc_SelectItem", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@FK_sMaPCCT", _LichDayVaHocEO.FK_sMaPCCT));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@FK_sMalop", _LichDayVaHocEO.FK_sMalop));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@iCaHoc", _LichDayVaHocEO.iCaHoc));
                    ds = new DataSet();
                    da.Fill(ds);
                    conn.Close();
                    oOutput = DataSet2Object.LichDayVaHoc(ds);
                    return oOutput;
                }
                catch (Exception)
                {
                    conn.Close();
                    return oOutput;
                }
            }
        }

        /// <summary> 7. LichDayVaHoc_SelectList </summary>
        /// <param name="_LichDayVaHocEO"></param>
        /// <returns></returns>
        public static DataSet LichDayVaHoc_SelectList(PhanCongCongTacEO _PhanCongCongTacEO, LichDayVaHocEO _LichDayVaHocEO, Int16 iType)
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblLichDayVaHoc_SelectList", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@FK_sMalop", (_LichDayVaHocEO.FK_sMalop == null) ? (object)DBNull.Value : _LichDayVaHocEO.FK_sMalop));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@FK_sMaGV", (_PhanCongCongTacEO.FK_sMaGV == null) ? (object)DBNull.Value : _PhanCongCongTacEO.FK_sMaGV));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@iType", iType));
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

        /// <summary> 8. LichDayVaHoc_Search </summary>
        /// <param name="_LichDayVaHocEO"></param>
        /// <returns></returns>
        public static DataSet LichDayVaHoc_Search(LichDayVaHocEO _LichDayVaHocEO)
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblLichDayVaHoc_Search", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@FK_sMaPCCT", _LichDayVaHocEO.FK_sMaPCCT));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@FK_sMalop", _LichDayVaHocEO.FK_sMalop));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@iCaHoc", _LichDayVaHocEO.iCaHoc));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@tNgayDay", _LichDayVaHocEO.tNgayDay));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@iSoTietDay", _LichDayVaHocEO.iSoTietDay));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sSinhVienNghi", _LichDayVaHocEO.sSinhVienNghi));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sSinhVienChan", _LichDayVaHocEO.sSinhVienChan));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sLinkVideo", _LichDayVaHocEO.sLinkVideo));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@iTrangThai", _LichDayVaHocEO.iTrangThai));
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