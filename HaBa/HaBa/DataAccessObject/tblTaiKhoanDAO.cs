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
        /// <summary> 1. TaiKhoan_CheckExists_PK_iTaiKhoanID </summary>
        /// <param name="_tblTaiKhoanEO"></param>
        /// <returns></returns>
        public static bool TaiKhoan_CheckExists_PK_iTaiKhoanID(tblTaiKhoanEO _tblTaiKhoanEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                bool bOutput = false;
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblTaiKhoan_CheckExists_PK_iTaiKhoanID", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_iTaiKhoanID", _tblTaiKhoanEO.PK_iTaiKhoanID));
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

        /// <summary> 2. TaiKhoan_CheckExists_sTenDangNhap </summary>
        /// <param name="_tblTaiKhoanEO"></param>
        /// <returns></returns>
        public static bool TaiKhoan_CheckExists_sTenDangNhap(tblTaiKhoanEO _tblTaiKhoanEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                bool bOutput = false;
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblTaiKhoan_CheckExists_sTenDangNhap", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@sTenDangNhap", _tblTaiKhoanEO.sTenDangNhap));
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

        /// <summary> 3. TaiKhoan_CheckExists_sEmail </summary>
        /// <param name="_tblTaiKhoanEO"></param>
        /// <returns></returns>
        public static bool TaiKhoan_CheckExists_sEmail(tblTaiKhoanEO _tblTaiKhoanEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                bool bOutput = false;
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblTaiKhoan_CheckExists_sEmail", conn);
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
        /// <summary> 2. TaiKhoan_Insert </summary>
        /// <param name="_tblTaiKhoanEO"></param>
        /// <returns></returns>
        public static bool TaiKhoan_Insert(tblTaiKhoanEO _tblTaiKhoanEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblTaiKhoan_Insert", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@sTenDangNhap", _tblTaiKhoanEO.sTenDangNhap));
                    cmd.Parameters.Add(new SqlParameter("@sMatKhau", _tblTaiKhoanEO.sMatKhau));
                    cmd.Parameters.Add(new SqlParameter("@sHoTen", _tblTaiKhoanEO.sHoTen));
                    cmd.Parameters.Add(new SqlParameter("@sEmail", _tblTaiKhoanEO.sEmail));
                    cmd.Parameters.Add(new SqlParameter("@sDiaChi", _tblTaiKhoanEO.sDiaChi));
                    cmd.Parameters.Add(new SqlParameter("@sSoDienThoai", _tblTaiKhoanEO.sSoDienThoai));
                    cmd.Parameters.Add(new SqlParameter("@sLinkAvatar", _tblTaiKhoanEO.sLinkAvatar));
                    cmd.Parameters.Add(new SqlParameter("@tNgaySinh", (_tblTaiKhoanEO.tNgaySinh == DateTime.MinValue) ? (object)DBNull.Value : _tblTaiKhoanEO.tNgaySinh));
                    cmd.Parameters.Add(new SqlParameter("@iQuyenHan", _tblTaiKhoanEO.iQuyenHan));
                    cmd.Parameters.Add(new SqlParameter("@iTrangThai", _tblTaiKhoanEO.iTrangThai));
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

        /// <summary> 3. TaiKhoan_Update </summary>
        /// <param name="_tblTaiKhoanEO"></param>
        /// <returns></returns>
        public static bool TaiKhoan_Update(tblTaiKhoanEO _tblTaiKhoanEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblTaiKhoan_Update", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_iTaiKhoanID", _tblTaiKhoanEO.PK_iTaiKhoanID));
                    cmd.Parameters.Add(new SqlParameter("@sTenDangNhap", _tblTaiKhoanEO.sTenDangNhap));
                    cmd.Parameters.Add(new SqlParameter("@sMatKhau", _tblTaiKhoanEO.sMatKhau));
                    cmd.Parameters.Add(new SqlParameter("@sHoTen", _tblTaiKhoanEO.sHoTen));
                    cmd.Parameters.Add(new SqlParameter("@sEmail", _tblTaiKhoanEO.sEmail));
                    cmd.Parameters.Add(new SqlParameter("@sDiaChi", _tblTaiKhoanEO.sDiaChi));
                    cmd.Parameters.Add(new SqlParameter("@sSoDienThoai", _tblTaiKhoanEO.sSoDienThoai));
                    cmd.Parameters.Add(new SqlParameter("@sLinkAvatar", _tblTaiKhoanEO.sLinkAvatar));
                    cmd.Parameters.Add(new SqlParameter("@tNgaySinh", _tblTaiKhoanEO.tNgaySinh));
                    cmd.Parameters.Add(new SqlParameter("@tNgayDangKy", _tblTaiKhoanEO.tNgayDangKy));
                    cmd.Parameters.Add(new SqlParameter("@iQuyenHan", _tblTaiKhoanEO.iQuyenHan));
                    cmd.Parameters.Add(new SqlParameter("@iTrangThai", _tblTaiKhoanEO.iTrangThai));
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

        /// <summary> 3. TaiKhoan_ResetPassword </summary>
        /// <param name="_tblTaiKhoanEO"></param>
        /// <returns></returns>
        public static bool TaiKhoan_ResetPassword(tblTaiKhoanEO _tblTaiKhoanEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblTaiKhoan_ResetPassword", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@sTenDangNhap", _tblTaiKhoanEO.sTenDangNhap));
                    cmd.Parameters.Add(new SqlParameter("@sMatKhau", _tblTaiKhoanEO.sMatKhau));
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

        /// <summary> 4. TaiKhoan_Delete </summary>
        /// <param name="_tblTaiKhoanEO"></param>
        /// <returns></returns>
        public static bool TaiKhoan_Delete(tblTaiKhoanEO _tblTaiKhoanEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblTaiKhoan_Delete", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_iTaiKhoanID", _tblTaiKhoanEO.PK_iTaiKhoanID));
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

        /// <summary> 5. TaiKhoan_DeleteList </summary>
        /// <param name="_ListPK_sMaMonhoc"></param>
        /// <returns></returns>
        public static bool TaiKhoan_DeleteList(String _ListPK_iTaiKhoanID)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblTaiKhoan_DeleteList", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ListPK_iTaiKhoanID", _ListPK_iTaiKhoanID));
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
        /// <summary> 6. TaiKhoan_SelectItem </summary>
        /// <param name="_tblTaiKhoanEO"></param>
        /// <returns></returns>
        public static tblTaiKhoanEO TaiKhoan_SelectItem(tblTaiKhoanEO _tblTaiKhoanEO)
        {
            tblTaiKhoanEO oOutput = new tblTaiKhoanEO();
            DataSet ds = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblTaiKhoan_SelectItem", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_iTaiKhoanID", _tblTaiKhoanEO.PK_iTaiKhoanID));
                    ds = new DataSet();
                    da.Fill(ds);
                    conn.Close();
                    oOutput = DataSet2Object.TaiKhoanDO(ds);
                    return oOutput;
                }
                catch (Exception)
                {
                    conn.Close();
                    return oOutput;
                }
            }
        }
        /// <summary> 6. TaiKhoan_SelectItemByPK_iTaiKhoanID </summary>
        /// <param name="_tblTaiKhoanEO"></param>
        /// <returns></returns>
        public static tblTaiKhoanEO TaiKhoan_SelectItemByPK_iTaiKhoanID(Int32 _PK_iTaiKhoanID)
        {
            tblTaiKhoanEO oOutput = new tblTaiKhoanEO();
            DataSet ds = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblTaiKhoan_SelectItemByPK_iTaiKhoanID", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_iTaiKhoanID", _PK_iTaiKhoanID));
                    ds = new DataSet();
                    da.Fill(ds);
                    conn.Close();
                    oOutput = DataSet2Object.TaiKhoanDO(ds);
                    return oOutput;
                }
                catch (Exception)
                {
                    conn.Close();
                    return oOutput;
                }
            }
        }

        /// <summary> 7. TaiKhoan_SelectBysUsername </summary>
        /// <param name="_tblTaiKhoanEO"></param>
        /// <returns></returns>
        public static tblTaiKhoanEO TaiKhoan_SelectItemBysTenDangNhap(tblTaiKhoanEO _tblTaiKhoanEO)
        {
            tblTaiKhoanEO oOutput = new tblTaiKhoanEO();
            DataSet ds = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblTaiKhoan_SelectItemBysTenDangNhap", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sTenDangNhap", _tblTaiKhoanEO.sTenDangNhap));
                    ds = new DataSet();
                    da.Fill(ds);
                    conn.Close();
                    oOutput = DataSet2Object.TaiKhoanDO(ds);
                    return oOutput;
                }
                catch (Exception)
                {
                    conn.Close();
                    return oOutput;
                }
            }
        }

        /// <summary> 8. TaiKhoan_SelectBysEmailvssPhoneNumber </summary>
        /// <param name="_tblTaiKhoanEO"></param>
        /// <returns></returns>
        public static tblTaiKhoanEO TaiKhoan_SelectBysEmailvssPhoneNumber(tblTaiKhoanEO _tblTaiKhoanEO)
        {
            tblTaiKhoanEO oOutput = new tblTaiKhoanEO();
            DataSet ds = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblTaiKhoan_SelectBysEmailvssPhoneNumber", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sEmail", _tblTaiKhoanEO.sEmail));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sSoDienThoai", _tblTaiKhoanEO.sSoDienThoai));
                    ds = new DataSet();
                    da.Fill(ds);
                    conn.Close();
                    oOutput = DataSet2Object.TaiKhoanDO(ds);
                    return oOutput;
                }
                catch (Exception)
                {
                    conn.Close();
                    return oOutput;
                }
            }
        }

        /// <summary> 8. TaiKhoan_SelectList </summary>
        /// <param name="_tblTaiKhoanEO"></param>
        /// <returns></returns>
        public static DataSet TaiKhoan_SelectList()
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblTaiKhoan_SelectList", conn);
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

        /// <summary> 8. TaiKhoan_SelectListByiQuyenHan </summary>
        /// <param name="_tblTaiKhoanEO"></param>
        /// <returns></returns>
        public static DataSet TaiKhoan_SelectListByiQuyenHan(tblTaiKhoanEO _tblTaiKhoanEO)
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblTaiKhoan_SelectListByiQuyenHan", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@iQuyenHan", _tblTaiKhoanEO.iQuyenHan));
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

        /// <summary> 8. TaiKhoan_SelectListByiQuyenHan_iTrangThai </summary>
        /// <param name="_tblTaiKhoanEO"></param>
        /// <returns></returns>
        public static DataSet TaiKhoan_SelectListByiQuyenHan_iTrangThai(tblTaiKhoanEO _tblTaiKhoanEO)
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblTaiKhoan_SelectListByiQuyenHan_iTrangThai", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@iQuyenHan", (_tblTaiKhoanEO.iQuyenHan == 0) ? (object)DBNull.Value : _tblTaiKhoanEO.iQuyenHan));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@iTrangThai", (_tblTaiKhoanEO.iTrangThai == 0) ? (object)DBNull.Value : _tblTaiKhoanEO.iTrangThai));
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

        /// <summary> 9. TaiKhoan_Search </summary>
        /// <param name="_tblTaiKhoanEO"></param>
        /// <returns></returns>
        public static DataSet TaiKhoan_Search(tblTaiKhoanEO _tblTaiKhoanEO)
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblTaiKhoan_Search", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_iTaiKhoanID", _tblTaiKhoanEO.PK_iTaiKhoanID));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sTenDangNhap", _tblTaiKhoanEO.sTenDangNhap));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sMatKhau", _tblTaiKhoanEO.sMatKhau));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sHoTen", _tblTaiKhoanEO.sHoTen));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sEmail", _tblTaiKhoanEO.sEmail));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sDiaChi", _tblTaiKhoanEO.sDiaChi));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sSoDienThoai", _tblTaiKhoanEO.sSoDienThoai));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sLinkAvatar", _tblTaiKhoanEO.sLinkAvatar));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@tNgaySinh", _tblTaiKhoanEO.tNgaySinh));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@tNgayDangKy", _tblTaiKhoanEO.tNgayDangKy));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@iQuyenHan", _tblTaiKhoanEO.iQuyenHan));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@iTrangThai", _tblTaiKhoanEO.iTrangThai));
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

        /// <summary> 10. TaiKhoan_Login </summary>
        /// <param name="_tblTaiKhoanEO"></param>
        /// <returns></returns>
        public static DataSet TaiKhoan_Login(tblTaiKhoanEO _tblTaiKhoanEO)
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblTaiKhoan_Login", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sTenDangNhap", _tblTaiKhoanEO.sTenDangNhap));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sMatKhau", _tblTaiKhoanEO.sMatKhau));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@iQuyenHan", _tblTaiKhoanEO.iQuyenHan));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@iTrangThai", _tblTaiKhoanEO.iTrangThai));
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