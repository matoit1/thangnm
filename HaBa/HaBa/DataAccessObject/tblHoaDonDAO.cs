﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using HaBa.EntityObject;

namespace HaBa.DataAccessObject
{
    public class tblHoaDonDAO
    {
        #region "CheckExists"
        /// <summary> 1. HoaDon_CheckExists </summary>
        /// <param name="_tblHoaDonEO"></param>
        /// <returns></returns>
        public static bool HoaDon_CheckExists(tblHoaDonEO _tblHoaDonEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                bool bOutput = false;
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblHoaDon_CheckExists", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_iTaiKhoanID", _tblHoaDonEO.PK_lHoaDonID));
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
        /// <summary> 2. HoaDon_Insert </summary>
        /// <param name="_tblHoaDonEO"></param>
        /// <returns></returns>
        public static bool HoaDon_Insert(tblHoaDonEO _tblHoaDonEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblHoaDon_Insert", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@FK_iTaiKhoanID_Giao", _tblHoaDonEO.FK_iTaiKhoanID_Giao));
                    cmd.Parameters.Add(new SqlParameter("@FK_iTaiKhoanID_Nhan", _tblHoaDonEO.FK_iTaiKhoanID_Nhan));
                    cmd.Parameters.Add(new SqlParameter("@FK_iThanhToanID", _tblHoaDonEO.FK_iThanhToanID));
                    cmd.Parameters.Add(new SqlParameter("@sHoTen", _tblHoaDonEO.sHoTen));
                    cmd.Parameters.Add(new SqlParameter("@sEmail", _tblHoaDonEO.sEmail));
                    cmd.Parameters.Add(new SqlParameter("@sDiaChi", _tblHoaDonEO.sDiaChi));
                    cmd.Parameters.Add(new SqlParameter("@sSoDienThoai", _tblHoaDonEO.sSoDienThoai));
                    cmd.Parameters.Add(new SqlParameter("@sGhiChu", _tblHoaDonEO.sGhiChu));
                    cmd.Parameters.Add(new SqlParameter("@tNgayGiaoHang", _tblHoaDonEO.tNgayGiaoHang));
                    cmd.Parameters.Add(new SqlParameter("@iTrangThai", _tblHoaDonEO.iTrangThai));
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

        /// <summary> 3. HoaDon_Update </summary>
        /// <param name="_tblHoaDonEO"></param>
        /// <returns></returns>
        public static bool HoaDon_Update(tblHoaDonEO _tblHoaDonEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblHoaDon_Update", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_lHoaDonID", _tblHoaDonEO.PK_lHoaDonID));
                    cmd.Parameters.Add(new SqlParameter("@FK_iTaiKhoanID_Giao", _tblHoaDonEO.FK_iTaiKhoanID_Giao));
                    cmd.Parameters.Add(new SqlParameter("@FK_iTaiKhoanID_Nhan", _tblHoaDonEO.FK_iTaiKhoanID_Nhan));
                    cmd.Parameters.Add(new SqlParameter("@FK_iThanhToanID", _tblHoaDonEO.FK_iThanhToanID));
                    cmd.Parameters.Add(new SqlParameter("@sHoTen", _tblHoaDonEO.sHoTen));
                    cmd.Parameters.Add(new SqlParameter("@sEmail", _tblHoaDonEO.sEmail));
                    cmd.Parameters.Add(new SqlParameter("@sDiaChi", _tblHoaDonEO.sDiaChi));
                    cmd.Parameters.Add(new SqlParameter("@sSoDienThoai", _tblHoaDonEO.sSoDienThoai));
                    cmd.Parameters.Add(new SqlParameter("@sGhiChu", _tblHoaDonEO.sGhiChu));
                    cmd.Parameters.Add(new SqlParameter("@tNgayDatHang", _tblHoaDonEO.tNgayDatHang));
                    cmd.Parameters.Add(new SqlParameter("@tNgayGiaoHang", _tblHoaDonEO.tNgayGiaoHang));
                    cmd.Parameters.Add(new SqlParameter("@iTrangThai", _tblHoaDonEO.iTrangThai));
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

        /// <summary> 4. HoaDon_Delete </summary>
        /// <param name="_tblHoaDonEO"></param>
        /// <returns></returns>
        public static bool HoaDon_Delete(tblHoaDonEO _tblHoaDonEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblHoaDon_Delete", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_lHoaDonID", _tblHoaDonEO.PK_lHoaDonID));
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

        /// <summary> 5. HoaDon_DeleteList </summary>
        /// <param name="_ListPK_sMaMonhoc"></param>
        /// <returns></returns>
        public static bool HoaDon_DeleteList(String _ListPK_lHoaDonID)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblHoaDon_DeleteList", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ListPK_lHoaDonID", _ListPK_lHoaDonID));
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
        /// <summary> 6. HoaDon_SelectItem </summary>
        /// <param name="_tblHoaDonEO"></param>
        /// <returns></returns>
        public static tblHoaDonEO HoaDon_SelectItem(tblHoaDonEO _tblHoaDonEO)
        {
            tblHoaDonEO oOutput = new tblHoaDonEO();
            DataSet ds = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblHoaDon_SelectItem", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_lHoaDonID", _tblHoaDonEO.PK_lHoaDonID));
                    ds = new DataSet();
                    da.Fill(ds);
                    conn.Close();
                    oOutput = DataSet2Object.HoaDonDO(ds);
                    return oOutput;
                }
                catch (Exception)
                {
                    conn.Close();
                    return oOutput;
                }
            }
        }

        /// <summary> 8. HoaDon_SelectList </summary>
        /// <param name="_tblHoaDonEO"></param>
        /// <returns></returns>
        public static DataSet HoaDon_SelectList()
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblHoaDon_SelectList", conn);
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

        /// <summary> 9. HoaDon_Search </summary>
        /// <param name="_tblHoaDonEO"></param>
        /// <returns></returns>
        public static DataSet HoaDon_Search(tblHoaDonEO _tblHoaDonEO)
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblHoaDon_Search", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_lHoaDonID", _tblHoaDonEO.PK_lHoaDonID));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@FK_iTaiKhoanID_Giao", _tblHoaDonEO.FK_iTaiKhoanID_Giao));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@FK_iTaiKhoanID_Nhan", _tblHoaDonEO.FK_iTaiKhoanID_Nhan));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@FK_iThanhToanID", _tblHoaDonEO.FK_iThanhToanID));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sHoTen", _tblHoaDonEO.sHoTen));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sEmail", _tblHoaDonEO.sEmail));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sDiaChi", _tblHoaDonEO.sDiaChi));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sSoDienThoai", _tblHoaDonEO.sSoDienThoai));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sGhiChu", _tblHoaDonEO.sGhiChu));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@tNgayDatHang", _tblHoaDonEO.tNgayDatHang));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@tNgayGiaoHang", _tblHoaDonEO.tNgayGiaoHang));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@iTrangThai", _tblHoaDonEO.iTrangThai));
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