using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using CongKy.EntityObject;

namespace CongKy.DataAccessObject
{
    public class tblChiTietGiaoTrinhDAO
    {
        #region "CheckExists"
        /// <summary> 1. ChiTietGiaoTrinh_CheckExists_FK_sSanPhamID </summary>
        /// <param name="_tblChiTietGiaoTrinhEO"></param>
        /// <returns></returns>
        public static bool ChiTietGiaoTrinh_CheckExists_PK_iGiaoTrinhID(tblChiTietGiaoTrinhEO _tblChiTietGiaoTrinhEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                bool bOutput = false;
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblChiTietGiaoTrinh_CheckExists_PK_iGiaoTrinhID", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_iGiaoTrinhID", _tblChiTietGiaoTrinhEO.PK_iGiaoTrinhID));
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
        /// <summary> 2. ChiTietGiaoTrinh_Insert </summary>
        /// <param name="_tblChiTietGiaoTrinhEO"></param>
        /// <returns></returns>
        public static bool ChiTietGiaoTrinh_Insert(tblChiTietGiaoTrinhEO _tblChiTietGiaoTrinhEO, tblMonHocEO _tblMonHocEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblChiTietGiaoTrinh_Insert", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@sTenBaiHoc", _tblChiTietGiaoTrinhEO.sTenBaiHoc));
                    cmd.Parameters.Add(new SqlParameter("@sThongTin", _tblChiTietGiaoTrinhEO.sThongTin));
                    cmd.Parameters.Add(new SqlParameter("@sLinkDownload", _tblChiTietGiaoTrinhEO.sLinkDownload));
                    cmd.Parameters.Add(new SqlParameter("@iType", _tblChiTietGiaoTrinhEO.iType));
                    cmd.Parameters.Add(new SqlParameter("@iTrangThai", _tblChiTietGiaoTrinhEO.iTrangThai));
                    cmd.Parameters.Add(new SqlParameter("@PK_iMonHocID", _tblMonHocEO.PK_iMonHocID));
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

        /// <summary> 3. ChiTietGiaoTrinh_Update </summary>
        /// <param name="_tblChiTietGiaoTrinhEO"></param>
        /// <returns></returns>
        public static bool ChiTietGiaoTrinh_Update(tblChiTietGiaoTrinhEO _tblChiTietGiaoTrinhEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblChiTietGiaoTrinh_Update", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_iGiaoTrinhID", _tblChiTietGiaoTrinhEO.PK_iGiaoTrinhID));
                    cmd.Parameters.Add(new SqlParameter("@sTenBaiHoc", _tblChiTietGiaoTrinhEO.sTenBaiHoc));
                    cmd.Parameters.Add(new SqlParameter("@sThongTin", _tblChiTietGiaoTrinhEO.sThongTin));
                    cmd.Parameters.Add(new SqlParameter("@sLinkDownload", _tblChiTietGiaoTrinhEO.sLinkDownload));
                    cmd.Parameters.Add(new SqlParameter("@iType", _tblChiTietGiaoTrinhEO.iType));
                    cmd.Parameters.Add(new SqlParameter("@iTrangThai", _tblChiTietGiaoTrinhEO.iTrangThai));
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

        /// <summary> 4. ChiTietGiaoTrinh_Delete </summary>
        /// <param name="_tblChiTietGiaoTrinhEO"></param>
        /// <returns></returns>
        public static bool ChiTietGiaoTrinh_Delete(tblChiTietGiaoTrinhEO _tblChiTietGiaoTrinhEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblChiTietGiaoTrinh_Delete", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_iGiaoTrinhID", _tblChiTietGiaoTrinhEO.PK_iGiaoTrinhID));
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
        /// <summary> 6. ChiTietGiaoTrinh_SelectItem </summary>
        /// <param name="_tblChiTietGiaoTrinhEO"></param>
        /// <returns></returns>
        public static tblChiTietGiaoTrinhEO ChiTietGiaoTrinh_SelectItem(tblChiTietGiaoTrinhEO _tblChiTietGiaoTrinhEO)
        {
            tblChiTietGiaoTrinhEO oOutput = new tblChiTietGiaoTrinhEO();
            DataSet ds = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblChiTietGiaoTrinh_SelectItem", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_iGiaoTrinhID", _tblChiTietGiaoTrinhEO.PK_iGiaoTrinhID));
                    ds = new DataSet();
                    da.Fill(ds);
                    conn.Close();
                    oOutput = DataSet2Object.ChiTietGiaoTrinhDO(ds);
                    return oOutput;
                }
                catch (Exception)
                {
                    conn.Close();
                    return oOutput;
                }
            }
        }
        
        /// <summary> 8. ChiTietGiaoTrinh_SelectList </summary>
        /// <param name="_tblChiTietGiaoTrinhEO"></param>
        /// <returns></returns>
        public static DataSet ChiTietGiaoTrinh_SelectList()
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblChiTietGiaoTrinh_SelectList", conn);
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

        /// <summary> 8. ChiTietGiaoTrinh_By_PK_iTaiKhoanID_PK_iMonHocID_PK_iGiaoTrinhID </summary>
        /// <param name="_tblChiTietGiaoTrinhEO"></param>
        /// <returns></returns>
        public static DataSet ChiTietGiaoTrinh_By_PK_iTaiKhoanID_PK_iMonHocID_PK_iGiaoTrinhID(int PK_iTaiKhoanID, int PK_iMonHocID, int PK_iGiaoTrinhID, Int16 iTrangThai, bool newfeed)
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblChiTietGiaoTrinh_By_PK_iTaiKhoanID_PK_iMonHocID_PK_iGiaoTrinhID", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_iTaiKhoanID", (PK_iTaiKhoanID == 0) ? (object)DBNull.Value : PK_iTaiKhoanID));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_iMonHocID", (PK_iMonHocID == 0) ? (object)DBNull.Value : PK_iMonHocID));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_iGiaoTrinhID", (PK_iGiaoTrinhID == 0) ? (object)DBNull.Value : PK_iGiaoTrinhID));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@iTrangThai", (iTrangThai == 0) ? (object)DBNull.Value : iTrangThai));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@newfeed", (newfeed == null) ? false : newfeed));
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

        

        /// <summary> 9. ChiTietGiaoTrinh_Search </summary>
        /// <param name="_tblChiTietGiaoTrinhEO"></param>
        /// <returns></returns>
        public static DataSet ChiTietGiaoTrinh_Search(tblChiTietGiaoTrinhEO _tblChiTietGiaoTrinhEO)
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblChiTietGiaoTrinh_Search", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_iGiaoTrinhID", _tblChiTietGiaoTrinhEO.PK_iGiaoTrinhID));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sTenBaiHoc", _tblChiTietGiaoTrinhEO.sTenBaiHoc));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sThongTin", _tblChiTietGiaoTrinhEO.sThongTin));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sLinkDownload", _tblChiTietGiaoTrinhEO.sLinkDownload));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@iType", _tblChiTietGiaoTrinhEO.iType));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@tNgayCapNhat", _tblChiTietGiaoTrinhEO.tNgayCapNhat));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@iTrangThai", _tblChiTietGiaoTrinhEO.iTrangThai));
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