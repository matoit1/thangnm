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
        /// <summary> 1. LichDayVaHoc_CheckExists </summary>
        /// <param name="_LichDayVaHocEO"></param>
        /// <returns></returns>
        public static bool LichDayVaHoc_CheckExists(LichDayVaHocEO _LichDayVaHocEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblLichDayVaHoc_CheckExists", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@FK_sMaPCCT", _LichDayVaHocEO.FK_sMaPCCT));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@FK_sMalop", _LichDayVaHocEO.FK_sMalop));
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    conn.Close();
                    if (Convert.ToInt32(ds.Tables[0].Rows.Count) > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception)
                {
                    conn.Close();
                    return false;
                }
            }
        }

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

        /// <summary> 6. LichDayVaHoc_SelectItem </summary>
        /// <param name="_LichDayVaHocEO"></param>
        /// <returns></returns>
        public static LichDayVaHocEO LichDayVaHoc_SelectItem(LichDayVaHocEO _LichDayVaHocEO)
        {
            LichDayVaHocEO output = new LichDayVaHocEO();
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
                    ds = new DataSet();
                    da.Fill(ds);
                    conn.Close();
                    output = DataSet2Object.LichDayVaHoc(ds);
                    return output;
                }
                catch (Exception)
                {
                    conn.Close();
                    return output;
                }
            }
        }

        /// <summary> 7. LichDayVaHoc_SelectList </summary>
        /// <param name="_LichDayVaHocEO"></param>
        /// <returns></returns>
        public static DataSet LichDayVaHoc_SelectList(LichDayVaHocEO _LichDayVaHocEO)
        {
            DataSet ds = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblLichDayVaHoc_SelectList", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
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

        /// <summary> 8. LichDayVaHoc_Search </summary>
        /// <param name="_LichDayVaHocEO"></param>
        /// <returns></returns>
        public static DataSet LichDayVaHoc_Search(LichDayVaHocEO _LichDayVaHocEO)
        {
            DataSet ds = null;
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
                    da.SelectCommand.Parameters.Add(new SqlParameter("@iTrangThai", _LichDayVaHocEO.iTrangThai));
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