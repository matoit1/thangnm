using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using HaBa.EntityObject;

namespace HaBa.DataAccessObject
{
    public class tblChiTietHoaDonDAO
    {
        #region "CheckExists"
        /// <summary> 1. ChiTietHoaDon_CheckExists </summary>
        /// <param name="_tblChiTietHoaDonEO"></param>
        /// <returns></returns>
        public static bool ChiTietHoaDon_CheckExists(tblChiTietHoaDonEO _tblChiTietHoaDonEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                bool bOutput = false;
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblChiTietHoaDon_CheckExists", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@FK_lHoaDonID", _tblChiTietHoaDonEO.FK_lHoaDonID));
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
        /// <summary> 2. ChiTietHoaDon_Insert </summary>
        /// <param name="_tblChiTietHoaDonEO"></param>
        /// <returns></returns>
        public static bool ChiTietHoaDon_Insert(tblChiTietHoaDonEO _tblChiTietHoaDonEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblChiTietHoaDon_Insert", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@FK_lHoaDonID", _tblChiTietHoaDonEO.FK_lHoaDonID));
                    cmd.Parameters.Add(new SqlParameter("@FK_sSanPhamID", _tblChiTietHoaDonEO.FK_sSanPhamID));
                    cmd.Parameters.Add(new SqlParameter("@lGiaBan", _tblChiTietHoaDonEO.lGiaBan));
                    cmd.Parameters.Add(new SqlParameter("@iSoLuong", _tblChiTietHoaDonEO.iSoLuong));
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

        /// <summary> 3. ChiTietHoaDon_Update </summary>
        /// <param name="_tblChiTietHoaDonEO"></param>
        /// <returns></returns>
        public static bool ChiTietHoaDon_Update(tblChiTietHoaDonEO _tblChiTietHoaDonEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblChiTietHoaDon_Update", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@FK_lHoaDonID", _tblChiTietHoaDonEO.FK_lHoaDonID));
                    cmd.Parameters.Add(new SqlParameter("@FK_sSanPhamID", _tblChiTietHoaDonEO.FK_sSanPhamID));
                    cmd.Parameters.Add(new SqlParameter("@lGiaBan", _tblChiTietHoaDonEO.lGiaBan));
                    cmd.Parameters.Add(new SqlParameter("@iSoLuong", _tblChiTietHoaDonEO.iSoLuong));
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

        /// <summary> 4. ChiTietHoaDon_Delete </summary>
        /// <param name="_tblChiTietHoaDonEO"></param>
        /// <returns></returns>
        public static bool ChiTietHoaDon_Delete(tblChiTietHoaDonEO _tblChiTietHoaDonEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblChiTietHoaDon_Delete", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@FK_lHoaDonID", _tblChiTietHoaDonEO.FK_lHoaDonID));
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

        /// <summary> 5. ChiTietHoaDon_DeleteList </summary>
        /// <param name="_ListPK_sMaMonhoc"></param>
        /// <returns></returns>
        public static bool ChiTietHoaDon_DeleteList(String _LisFK_lHoaDonID)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblChiTietHoaDon_DeleteList", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ListFK_lHoaDonID", _LisFK_lHoaDonID));
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
        /// <summary> 6. ChiTietHoaDon_SelectItem </summary>
        /// <param name="_tblChiTietHoaDonEO"></param>
        /// <returns></returns>
        public static tblChiTietHoaDonEO ChiTietHoaDon_SelectItem(tblChiTietHoaDonEO _tblChiTietHoaDonEO)
        {
            tblChiTietHoaDonEO oOutput = new tblChiTietHoaDonEO();
            DataSet ds = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblChiTietHoaDon_SelectItem", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@FK_lHoaDonID", _tblChiTietHoaDonEO.FK_lHoaDonID));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@FK_sSanPhamID", _tblChiTietHoaDonEO.FK_sSanPhamID));
                    ds = new DataSet();
                    da.Fill(ds);
                    conn.Close();
                    oOutput = DataSet2Object.ChiTietHoaDonDO(ds);
                    return oOutput;
                }
                catch (Exception)
                {
                    conn.Close();
                    return oOutput;
                }
            }
        }
        
        /// <summary> 8. ChiTietHoaDon_SelectList </summary>
        /// <param name="_tblChiTietHoaDonEO"></param>
        /// <returns></returns>
        public static DataSet ChiTietHoaDon_SelectList()
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblChiTietHoaDon_SelectList", conn);
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

        /// <summary> 8. ChiTietHoaDon_SelectListByFK_lHoaDonID </summary>
        /// <param name="_tblChiTietHoaDonEO"></param>
        /// <returns></returns>
        public static DataSet ChiTietHoaDon_SelectListByFK_lHoaDonID(tblChiTietHoaDonEO _tblChiTietHoaDonEO)
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblChiTietHoaDon_SelectListByFK_lHoaDonID", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@FK_lHoaDonID", _tblChiTietHoaDonEO.FK_lHoaDonID));
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

        /// <summary> 9. ChiTietHoaDon_Search </summary>
        /// <param name="_tblChiTietHoaDonEO"></param>
        /// <returns></returns>
        public static DataSet ChiTietHoaDon_Search(tblChiTietHoaDonEO _tblChiTietHoaDonEO)
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblChiTietHoaDon_Search", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@FK_lHoaDonID", _tblChiTietHoaDonEO.FK_lHoaDonID));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@FK_sSanPhamID", _tblChiTietHoaDonEO.FK_sSanPhamID));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@lGiaBan", _tblChiTietHoaDonEO.lGiaBan));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@iSoLuong", _tblChiTietHoaDonEO.iSoLuong));
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

        /// <summary> 10. ChiTietHoaDon_Login </summary>
        /// <param name="_tblChiTietHoaDonEO"></param>
        /// <returns></returns>
        public static DataSet ChiTietHoaDon_Login(tblChiTietHoaDonEO _tblChiTietHoaDonEO)
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblChiTietHoaDon_Login", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@FK_lHoaDonID", _tblChiTietHoaDonEO.FK_lHoaDonID));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@FK_sSanPhamID", _tblChiTietHoaDonEO.FK_sSanPhamID));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@lGiaBan", _tblChiTietHoaDonEO.lGiaBan));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@iSoLuong", _tblChiTietHoaDonEO.iSoLuong));
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