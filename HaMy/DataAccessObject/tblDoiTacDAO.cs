using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using HaMy.EntityObject;

namespace HaMy.DataAccessObject
{
    public class tblDoiTacDAO
    {
        #region "CheckExists"
        /// <summary> 1. DoiTac_CheckExists </summary>
        /// <param name="_tblDoiTacEO"></param>
        /// <returns></returns>
        public static bool DoiTac_CheckExists(tblDoiTacEO _tblDoiTacEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                bool bOutput = false;
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblDoiTac_CheckExists", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_iDoiTac", _tblDoiTacEO.PK_iDoiTac));
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
        /// <summary> 2. DoiTac_Insert </summary>
        /// <param name="_tblDoiTacEO"></param>
        /// <returns></returns>
        public static bool DoiTac_Insert(tblDoiTacEO _tblDoiTacEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblDoiTac_Insert", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@FK_iNhom", _tblDoiTacEO.FK_iNhom));
                    cmd.Parameters.Add(new SqlParameter("@sHoTen", _tblDoiTacEO.sHoTen));
                    cmd.Parameters.Add(new SqlParameter("@sDiaChi", _tblDoiTacEO.sDiaChi));
                    cmd.Parameters.Add(new SqlParameter("@sEmail", _tblDoiTacEO.sEmail));
                    cmd.Parameters.Add(new SqlParameter("@sSoDienThoai", _tblDoiTacEO.sSoDienThoai));
                    cmd.Parameters.Add(new SqlParameter("@tNgaySinh", _tblDoiTacEO.tNgaySinh));
                    cmd.Parameters.Add(new SqlParameter("@bGioiTinh", _tblDoiTacEO.bGioiTinh));
                    cmd.Parameters.Add(new SqlParameter("@sNgheNghiep", _tblDoiTacEO.sNgheNghiep));
                    cmd.Parameters.Add(new SqlParameter("@sGhiChu", _tblDoiTacEO.sGhiChu));
                    cmd.Parameters.Add(new SqlParameter("@FK_iMoiQuanHe", _tblDoiTacEO.FK_iMoiQuanHe));
                    cmd.Parameters.Add(new SqlParameter("@iTrangThai", _tblDoiTacEO.iTrangThai));
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

        /// <summary> 3. DoiTac_Update </summary>
        /// <param name="_tblDoiTacEO"></param>
        /// <returns></returns>
        public static bool DoiTac_Update(tblDoiTacEO _tblDoiTacEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblDoiTac_Update", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_iDoiTac", _tblDoiTacEO.PK_iDoiTac));
                    cmd.Parameters.Add(new SqlParameter("@FK_iNhom", _tblDoiTacEO.FK_iNhom));
                    cmd.Parameters.Add(new SqlParameter("@sHoTen", _tblDoiTacEO.sHoTen));
                    cmd.Parameters.Add(new SqlParameter("@sDiaChi", _tblDoiTacEO.sDiaChi));
                    cmd.Parameters.Add(new SqlParameter("@sEmail", _tblDoiTacEO.sEmail));
                    cmd.Parameters.Add(new SqlParameter("@sSoDienThoai", _tblDoiTacEO.sSoDienThoai));
                    cmd.Parameters.Add(new SqlParameter("@tNgaySinh", _tblDoiTacEO.tNgaySinh));
                    cmd.Parameters.Add(new SqlParameter("@bGioiTinh", _tblDoiTacEO.bGioiTinh));
                    cmd.Parameters.Add(new SqlParameter("@sNgheNghiep", _tblDoiTacEO.sNgheNghiep));
                    cmd.Parameters.Add(new SqlParameter("@sGhiChu", _tblDoiTacEO.sGhiChu));
                    cmd.Parameters.Add(new SqlParameter("@FK_iMoiQuanHe", _tblDoiTacEO.FK_iMoiQuanHe));
                    cmd.Parameters.Add(new SqlParameter("@iTrangThai", _tblDoiTacEO.iTrangThai));
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

        /// <summary> 4. DoiTac_Delete </summary>
        /// <param name="_tblDoiTacEO"></param>
        /// <returns></returns>
        public static bool DoiTac_Delete(tblDoiTacEO _tblDoiTacEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblDoiTac_Delete", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_iDoiTac", _tblDoiTacEO.PK_iDoiTac));
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

        /// <summary> 5. DoiTac_DeleteList </summary>
        /// <param name="_ListPK_sMaMonhoc"></param>
        /// <returns></returns>
        public static bool DoiTac_DeleteList(String _ListPK_iDoiTac)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblDoiTac_DeleteList", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ListPK_iDoiTac", _ListPK_iDoiTac));
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
        /// <summary> 6. DoiTac_SelectItem </summary>
        /// <param name="_tblDoiTacEO"></param>
        /// <returns></returns>
        public static tblDoiTacEO DoiTac_SelectItem(tblDoiTacEO _tblDoiTacEO)
        {
            tblDoiTacEO oOutput = new tblDoiTacEO();
            DataSet ds = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblDoiTac_SelectItem", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_iDoiTac", _tblDoiTacEO.PK_iDoiTac));
                    ds = new DataSet();
                    da.Fill(ds);
                    conn.Close();
                    oOutput = DataSet2Object.DoiTacDO(ds);
                    return oOutput;
                }
                catch (Exception)
                {
                    conn.Close();
                    return oOutput;
                }
            }
        }

        /// <summary> 8. DoiTac_SelectList </summary>
        /// <param name="_tblDoiTacEO"></param>
        /// <returns></returns>
        public static DataSet DoiTac_SelectList()
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblDoiTac_SelectList", conn);
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

        /// <summary> 9. DoiTac_Search </summary>
        /// <param name="_tblDoiTacEO"></param>
        /// <returns></returns>
        public static DataSet DoiTac_Search(tblDoiTacEO _tblDoiTacEO)
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblDoiTac_Search", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@FK_iNhom", (_tblDoiTacEO.FK_iNhom == 0) ? (object)DBNull.Value : _tblDoiTacEO.FK_iNhom));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_iDoiTac", (_tblDoiTacEO.PK_iDoiTac == 0) ? (object)DBNull.Value : _tblDoiTacEO.PK_iDoiTac));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sHoTen", (String.IsNullOrEmpty(_tblDoiTacEO.sHoTen)) ? (object)DBNull.Value : _tblDoiTacEO.sHoTen));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sDiaChi", (String.IsNullOrEmpty(_tblDoiTacEO.sDiaChi)) ? (object)DBNull.Value : _tblDoiTacEO.sDiaChi));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sEmail", (String.IsNullOrEmpty(_tblDoiTacEO.sEmail)) ? (object)DBNull.Value : _tblDoiTacEO.sEmail));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sSoDienThoai", (String.IsNullOrEmpty(_tblDoiTacEO.sSoDienThoai)) ? (object)DBNull.Value : _tblDoiTacEO.sSoDienThoai));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@tNgaySinh", (_tblDoiTacEO.tNgaySinh == DateTime.MinValue) ? (object)DBNull.Value : _tblDoiTacEO.tNgaySinh));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@bGioiTinh", _tblDoiTacEO.bGioiTinh));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sNgheNghiep", (String.IsNullOrEmpty(_tblDoiTacEO.sNgheNghiep)) ? (object)DBNull.Value : _tblDoiTacEO.sNgheNghiep));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@FK_iMoiQuanHe", (_tblDoiTacEO.FK_iMoiQuanHe == 0) ? (object)DBNull.Value : _tblDoiTacEO.FK_iMoiQuanHe));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sGhiChu", (String.IsNullOrEmpty(_tblDoiTacEO.sGhiChu)) ? (object)DBNull.Value : _tblDoiTacEO.sGhiChu));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@iTrangThai", (_tblDoiTacEO.iTrangThai == 0) ? (object)DBNull.Value : _tblDoiTacEO.iTrangThai));
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