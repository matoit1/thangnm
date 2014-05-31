using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using HaMy.EntityObject;

namespace HaMy.DataAccessObject
{
    public class tblNguoiDungDAO
    {
        #region "CheckExists"
        /// <summary> 1. NguoiDung_CheckExists_PK_iNguoiDung </summary>
        /// <param name="_tblNguoiDungEO"></param>
        /// <returns></returns>
        public static bool NguoiDung_CheckExists_PK_iNguoiDung(tblNguoiDungEO _tblNguoiDungEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                bool bOutput = false;
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblNguoiDung_CheckExists_PK_iNguoiDung", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_iNguoiDung", _tblNguoiDungEO.PK_iNguoiDung));
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
        /// <summary> 2. NguoiDung_Insert </summary>
        /// <param name="_tblNguoiDungEO"></param>
        /// <returns></returns>
        public static bool NguoiDung_Insert(tblNguoiDungEO _tblNguoiDungEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblNguoiDung_Insert", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@sHoTen", _tblNguoiDungEO.sHoTen));
                    cmd.Parameters.Add(new SqlParameter("@sDiaChi", _tblNguoiDungEO.sDiaChi));
                    cmd.Parameters.Add(new SqlParameter("@sEmail", _tblNguoiDungEO.sEmail));
                    cmd.Parameters.Add(new SqlParameter("@sSoDienThoai", _tblNguoiDungEO.sSoDienThoai));
                    cmd.Parameters.Add(new SqlParameter("@tNgaySinh", _tblNguoiDungEO.tNgaySinh));
                    cmd.Parameters.Add(new SqlParameter("@bGioiTinh", _tblNguoiDungEO.bGioiTinh));
                    cmd.Parameters.Add(new SqlParameter("@sNgheNghiep", _tblNguoiDungEO.sNgheNghiep));
                    cmd.Parameters.Add(new SqlParameter("@iTrangThai", _tblNguoiDungEO.iTrangThai));
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

        /// <summary> 3. NguoiDung_Update </summary>
        /// <param name="_tblNguoiDungEO"></param>
        /// <returns></returns>
        public static bool NguoiDung_Update(tblNguoiDungEO _tblNguoiDungEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblNguoiDung_Update", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_iNguoiDung", _tblNguoiDungEO.PK_iNguoiDung));
                    cmd.Parameters.Add(new SqlParameter("@sHoTen", _tblNguoiDungEO.sHoTen));
                    cmd.Parameters.Add(new SqlParameter("@sDiaChi", _tblNguoiDungEO.sDiaChi));
                    cmd.Parameters.Add(new SqlParameter("@sEmail", _tblNguoiDungEO.sEmail));
                    cmd.Parameters.Add(new SqlParameter("@sSoDienThoai", _tblNguoiDungEO.sSoDienThoai));
                    cmd.Parameters.Add(new SqlParameter("@tNgaySinh", _tblNguoiDungEO.tNgaySinh));
                    cmd.Parameters.Add(new SqlParameter("@bGioiTinh", _tblNguoiDungEO.bGioiTinh));
                    cmd.Parameters.Add(new SqlParameter("@sNgheNghiep", _tblNguoiDungEO.sNgheNghiep));
                    cmd.Parameters.Add(new SqlParameter("@iTrangThai", _tblNguoiDungEO.iTrangThai));
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

        /// <summary> 4. NguoiDung_Delete </summary>
        /// <param name="_tblNguoiDungEO"></param>
        /// <returns></returns>
        public static bool NguoiDung_Delete(tblNguoiDungEO _tblNguoiDungEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblNguoiDung_Delete", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_iNguoiDung", _tblNguoiDungEO.PK_iNguoiDung));
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

        /// <summary> 5. NguoiDung_DeleteList </summary>
        /// <param name="_ListPK_sMaMonhoc"></param>
        /// <returns></returns>
        public static bool NguoiDung_DeleteList(String _ListPK_iNguoiDung)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblNguoiDung_DeleteList", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ListPK_iNguoiDung", _ListPK_iNguoiDung));
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
        /// <summary> 6. NguoiDung_SelectItem </summary>
        /// <param name="_tblNguoiDungEO"></param>
        /// <returns></returns>
        public static tblNguoiDungEO NguoiDung_SelectItem(tblNguoiDungEO _tblNguoiDungEO)
        {
            tblNguoiDungEO oOutput = new tblNguoiDungEO();
            DataSet ds = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblNguoiDung_SelectItem", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_iNguoiDung", _tblNguoiDungEO.PK_iNguoiDung));
                    ds = new DataSet();
                    da.Fill(ds);
                    conn.Close();
                    oOutput = DataSet2Object.NguoiDungDO(ds);
                    return oOutput;
                }
                catch (Exception)
                {
                    conn.Close();
                    return oOutput;
                }
            }
        }
        /// <summary> 6. NguoiDung_SelectItemPK_iNguoiDungID </summary>
        /// <param name="_tblNguoiDungEO"></param>
        /// <returns></returns>
        public static tblNguoiDungEO NguoiDung_SelectItemPK_iNguoiDung(String PK_iNguoiDung)
        {
            tblNguoiDungEO oOutput = new tblNguoiDungEO();
            DataSet ds = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblNguoiDung_SelectItemByPK_iNguoiDung", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_iNguoiDungI", PK_iNguoiDung));
                    ds = new DataSet();
                    da.Fill(ds);
                    conn.Close();
                    oOutput = DataSet2Object.NguoiDungDO(ds);
                    return oOutput;
                }
                catch (Exception)
                {
                    conn.Close();
                    return oOutput;
                }
            }
        }

        /// <summary> 8. NguoiDung_SelectList </summary>
        /// <param name="_tblNguoiDungEO"></param>
        /// <returns></returns>
        public static DataSet NguoiDung_SelectList()
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblNguoiDung_SelectList", conn);
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

      

       
        /// <summary> 13. NguoiDung_Search </summary>
        /// <param name="_tblNguoiDungEO"></param>
        /// <returns></returns>
        public static DataSet NguoiDung_Search(tblNguoiDungEO _tblNguoiDungEO)
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblNguoiDung_Search", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_iNguoiDung", (_tblNguoiDungEO.PK_iNguoiDung == 0) ? (object)DBNull.Value : _tblNguoiDungEO.PK_iNguoiDung));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sHoTen", (String.IsNullOrEmpty(_tblNguoiDungEO.sHoTen)) ? (object)DBNull.Value : _tblNguoiDungEO.sHoTen));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sDiaChi", (String.IsNullOrEmpty(_tblNguoiDungEO.sDiaChi)) ? (object)DBNull.Value : _tblNguoiDungEO.sDiaChi));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sEmail", (String.IsNullOrEmpty(_tblNguoiDungEO.sEmail)) ? (object)DBNull.Value : _tblNguoiDungEO.sEmail));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sSoDienThoai", (String.IsNullOrEmpty(_tblNguoiDungEO.sSoDienThoai)) ? (object)DBNull.Value : _tblNguoiDungEO.sSoDienThoai));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@tNgaySinh", (_tblNguoiDungEO.tNgaySinh == DateTime.MinValue) ? (object)DBNull.Value : _tblNguoiDungEO.tNgaySinh));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@bGioiTinh", _tblNguoiDungEO.bGioiTinh));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sNgheNghiep", (String.IsNullOrEmpty(_tblNguoiDungEO.sNgheNghiep)) ? (object)DBNull.Value : _tblNguoiDungEO.sNgheNghiep));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@iTrangThai", (_tblNguoiDungEO.iTrangThai == 0) ? (object)DBNull.Value : _tblNguoiDungEO.iTrangThai));
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