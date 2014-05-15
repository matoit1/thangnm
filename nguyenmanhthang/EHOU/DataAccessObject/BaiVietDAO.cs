﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using EntityObject;

namespace DataAccessObject
{
    public class BaiVietDAO
    {
        #region "CheckExists"
        /// <summary> 1. BaiViet_CheckExists </summary>
        /// <param name="_BaiVietEO"></param>
        /// <returns></returns>
        public static bool BaiViet_CheckExists(BaiVietEO _BaiVietEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                bool bOutput = false;
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblBaiViet_CheckExists", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_lMaBaiViet", _BaiVietEO.PK_lMaBaiViet));
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
        /// <summary> 2. BaiViet_Insert </summary>
        /// <param name="_BaiVietEO"></param>
        /// <returns></returns>
        public static bool BaiViet_Insert(BaiVietEO _BaiVietEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblBaiViet_Insert", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@FK_sMaGV", _BaiVietEO.FK_sMaGV));
                    cmd.Parameters.Add(new SqlParameter("@PK_lMaBaiViet", _BaiVietEO.PK_lMaBaiViet));
                    cmd.Parameters.Add(new SqlParameter("@sTieuDe", _BaiVietEO.sTieuDe));
                    cmd.Parameters.Add(new SqlParameter("@sLinkAnh", _BaiVietEO.sLinkAnh));
                    cmd.Parameters.Add(new SqlParameter("@sTag", _BaiVietEO.sTag));
                    cmd.Parameters.Add(new SqlParameter("@sNoiDung", _BaiVietEO.sNoiDung));
                    cmd.Parameters.Add(new SqlParameter("@iLuotXem", _BaiVietEO.iLuotXem));
                    cmd.Parameters.Add(new SqlParameter("@sMoTa", _BaiVietEO.sMoTa));
                    cmd.Parameters.Add(new SqlParameter("@iTrangThai", _BaiVietEO.iTrangThai));
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

        /// <summary> 3. BaiViet_Update </summary>
        /// <param name="_BaiVietEO"></param>
        /// <returns></returns>
        public static bool BaiViet_Update(BaiVietEO _BaiVietEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblBaiViet_Update", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@FK_sMaGV", _BaiVietEO.FK_sMaGV));
                    cmd.Parameters.Add(new SqlParameter("@PK_lMaBaiViet", _BaiVietEO.PK_lMaBaiViet));
                    cmd.Parameters.Add(new SqlParameter("@sTieuDe", _BaiVietEO.sTieuDe));
                    cmd.Parameters.Add(new SqlParameter("@sLinkAnh", _BaiVietEO.sLinkAnh));
                    cmd.Parameters.Add(new SqlParameter("@sTag", _BaiVietEO.sTag));
                    cmd.Parameters.Add(new SqlParameter("@sNoiDung", _BaiVietEO.sNoiDung));
                    cmd.Parameters.Add(new SqlParameter("@iLuotXem", _BaiVietEO.iLuotXem));
                    cmd.Parameters.Add(new SqlParameter("@sMoTa", _BaiVietEO.sMoTa));
                    cmd.Parameters.Add(new SqlParameter("@iTrangThai", _BaiVietEO.iTrangThai));
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

        /// <summary> 3. BaiViet_Update_iLuotXem </summary>
        /// <param name="_BaiVietEO"></param>
        /// <returns></returns>
        public static bool BaiViet_Update_iLuotXem(BaiVietEO _BaiVietEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblBaiViet_Update_iLuotXem", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_lMaBaiViet", _BaiVietEO.PK_lMaBaiViet));
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

        /// <summary> 4. BaiViet_Delete </summary>
        /// <param name="_BaiVietEO"></param>
        /// <returns></returns>
        public static bool BaiViet_Delete(BaiVietEO _BaiVietEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblBaiViet_Delete", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_lMaBaiViet", _BaiVietEO.PK_lMaBaiViet));
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

        /// <summary> 5. BaiViet_DeleteList </summary>
        /// <param name="_ListPK_sMaMonhoc"></param>
        /// <returns></returns>
        public static bool BaiViet_DeleteList(String _ListPK_lMaBaiViet)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblBaiViet_DeleteList", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ListPK_lMaBaiViet", _ListPK_lMaBaiViet));
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
        /// <summary> 6. BaiViet_SelectItem </summary>
        /// <param name="_BaiVietEO"></param>
        /// <returns></returns>
        public static BaiVietEO BaiViet_SelectItem(BaiVietEO _BaiVietEO)
        {
            BaiVietEO oOutput = new BaiVietEO();
            DataSet ds = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblBaiViet_SelectItem", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_lMaBaiViet", _BaiVietEO.PK_lMaBaiViet));
                    ds = new DataSet();
                    da.Fill(ds);
                    conn.Close();
                    oOutput = DataSet2Object.BaiViet(ds);
                    return oOutput;
                }
                catch (Exception)
                {
                    conn.Close();
                    return oOutput;
                }
            }
        }

        /// <summary> 7. BaiViet_SelectList </summary>
        /// <param name="_BaiVietEO"></param>
        /// <returns></returns>
        public static DataSet BaiViet_SelectList()
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblBaiViet_SelectList", conn);
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

        /// <summary> 8. BaiViet_Search </summary>
        /// <param name="_BaiVietEO"></param>
        /// <returns></returns>
        public static DataSet BaiViet_Search(BaiVietEO _BaiVietEO)
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblBaiViet_Search", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@FK_sMaGV", _BaiVietEO.FK_sMaGV));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_lMaBaiViet", _BaiVietEO.PK_lMaBaiViet));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sTieuDe", _BaiVietEO.sTieuDe));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sLinkAnh", _BaiVietEO.sLinkAnh));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sTag", _BaiVietEO.sTag));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sNoiDung", _BaiVietEO.sNoiDung));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@iLuotXem", _BaiVietEO.iLuotXem));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@tNgayViet", _BaiVietEO.tNgayViet));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@tNgayCapNhat", _BaiVietEO.tNgayCapNhat));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sMoTa", _BaiVietEO.sMoTa));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@iTrangThai", _BaiVietEO.iTrangThai));
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