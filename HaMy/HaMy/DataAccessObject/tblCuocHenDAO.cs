using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using HaMy.EntityObject;

namespace HaMy.DataAccessObject
{
    public class tblCuocHenDAO
    {
        #region "CheckExists"
        /// <summary> 1. CuocHen_CheckExists </summary>
        /// <param name="_tblCuocHenEO"></param>
        /// <returns></returns>
        public static bool CuocHen_CheckExists(tblCuocHenEO _tblCuocHenEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                bool bOutput = false;
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblCuocHen_CheckExists", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_lCuocHen", _tblCuocHenEO.PK_lCuocHen));
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
        /// <summary> 2. CuocHen_Insert </summary>
        /// <param name="_tblCuocHenEO"></param>
        /// <returns></returns>
        public static bool CuocHen_Insert(tblCuocHenEO _tblCuocHenEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblCuocHen_Insert", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@FK_iNguoiDung", _tblCuocHenEO.FK_iNguoiDung));
                    cmd.Parameters.Add(new SqlParameter("@FK_iDoiTac", _tblCuocHenEO.FK_iDoiTac));
                    cmd.Parameters.Add(new SqlParameter("@sNoiDung", _tblCuocHenEO.sNoiDung));
                    cmd.Parameters.Add(new SqlParameter("@sDiaDiem", _tblCuocHenEO.sDiaDiem));
                    cmd.Parameters.Add(new SqlParameter("@tNgayGioBatDau", _tblCuocHenEO.tNgayGioBatDau));
                    cmd.Parameters.Add(new SqlParameter("@tNgayGioKetThuc", _tblCuocHenEO.tNgayGioKetThuc));
                    cmd.Parameters.Add(new SqlParameter("@iTrangThai", _tblCuocHenEO.iTrangThai));
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

        /// <summary> 3. CuocHen_Update </summary>
        /// <param name="_tblCuocHenEO"></param>
        /// <returns></returns>
        public static bool CuocHen_Update(tblCuocHenEO _tblCuocHenEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblCuocHen_Update", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_lCuocHen", _tblCuocHenEO.PK_lCuocHen));
                    cmd.Parameters.Add(new SqlParameter("@FK_iNguoiDung", _tblCuocHenEO.FK_iNguoiDung));
                    cmd.Parameters.Add(new SqlParameter("@FK_iDoiTac", _tblCuocHenEO.FK_iDoiTac));
                    cmd.Parameters.Add(new SqlParameter("@sNoiDung", _tblCuocHenEO.sNoiDung));
                    cmd.Parameters.Add(new SqlParameter("@sDiaDiem", _tblCuocHenEO.sDiaDiem));
                    cmd.Parameters.Add(new SqlParameter("@tNgayGioBatDau", _tblCuocHenEO.tNgayGioBatDau));
                    cmd.Parameters.Add(new SqlParameter("@tNgayGioKetThuc", _tblCuocHenEO.tNgayGioKetThuc));
                    cmd.Parameters.Add(new SqlParameter("@iTrangThai", _tblCuocHenEO.iTrangThai));
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

        /// <summary> 4. CuocHen_Delete </summary>
        /// <param name="_tblCuocHenEO"></param>
        /// <returns></returns>
        public static bool CuocHen_Delete(tblCuocHenEO _tblCuocHenEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblCuocHen_Delete", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_lCuocHen", _tblCuocHenEO.PK_lCuocHen));
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

        /// <summary> 5. CuocHen_DeleteList </summary>
        /// <param name="_ListPK_sMaMonhoc"></param>
        /// <returns></returns>
        public static bool CuocHen_DeleteList(String _LisPK_lCuocHen)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblCuocHen_DeleteList", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ListPK_lCuocHen", _LisPK_lCuocHen));
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
        /// <summary> 6. CuocHen_SelectItem </summary>
        /// <param name="_tblCuocHenEO"></param>
        /// <returns></returns>
        public static tblCuocHenEO CuocHen_SelectItem(tblCuocHenEO _tblCuocHenEO)
        {
            tblCuocHenEO oOutput = new tblCuocHenEO();
            DataSet ds = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblCuocHen_SelectItem", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_lCuocHen", _tblCuocHenEO.PK_lCuocHen));
                    ds = new DataSet();
                    da.Fill(ds);
                    conn.Close();
                    oOutput = DataSet2Object.CuocHenDO(ds);
                    return oOutput;
                }
                catch (Exception)
                {
                    conn.Close();
                    return oOutput;
                }
            }
        }
        
        /// <summary> 8. CuocHen_SelectList </summary>
        /// <param name="_tblCuocHenEO"></param>
        /// <returns></returns>
        public static DataSet CuocHen_SelectList()
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblCuocHen_SelectList", conn);
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

        /// <summary> 9. CuocHen_Search </summary>
        /// <param name="_tblCuocHenEO"></param>
        /// <returns></returns>
        public static DataSet CuocHen_Search(tblCuocHenEO _tblCuocHenEO)
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblCuocHen_Search", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_lCuocHen", _tblCuocHenEO.PK_lCuocHen));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@FK_iNguoiDung", _tblCuocHenEO.FK_iNguoiDung));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@FK_iDoiTac", _tblCuocHenEO.FK_iDoiTac));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sNoiDung", _tblCuocHenEO.sNoiDung));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sDiaDiem", _tblCuocHenEO.sDiaDiem));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@tNgayGioBatDau", _tblCuocHenEO.tNgayGioBatDau));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@tNgayGioKetThuc", _tblCuocHenEO.tNgayGioKetThuc));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@iTrangThai", _tblCuocHenEO.iTrangThai));
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