using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using HaBa.EntityObject;

namespace HaBa.DataAccessObject
{
    public class tblSanPhamDAO
    {
        #region "CheckExists"
        /// <summary> 1. SanPham_CheckExists_PK_sSanPhamID </summary>
        /// <param name="_tblSanPhamEO"></param>
        /// <returns></returns>
        public static bool SanPham_CheckExists_PK_sSanPhamID(tblSanPhamEO _tblSanPhamEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                bool bOutput = false;
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblSanPham_CheckExists_PK_sSanPhamID", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_sSanPhamID", _tblSanPhamEO.PK_sSanPhamID));
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

        /// <summary> 1. SanPham_CheckExists_FK_iNhomSanPhamID </summary>
        /// <param name="_tblSanPhamEO"></param>
        /// <returns></returns>
        public static bool SanPham_CheckExists_FK_iNhomSanPhamID(tblSanPhamEO _tblSanPhamEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                bool bOutput = false;
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblSanPham_CheckExists_FK_iNhomSanPhamID", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@FK_iNhomSanPhamID", _tblSanPhamEO.FK_iNhomSanPhamID));
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
        /// <summary> 2. SanPham_Insert </summary>
        /// <param name="_tblSanPhamEO"></param>
        /// <returns></returns>
        public static bool SanPham_Insert(tblSanPhamEO _tblSanPhamEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblSanPham_Insert", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_sSanPhamID", _tblSanPhamEO.PK_sSanPhamID));
                    cmd.Parameters.Add(new SqlParameter("@FK_iNhomSanPhamID", _tblSanPhamEO.FK_iNhomSanPhamID));
                    cmd.Parameters.Add(new SqlParameter("@sTenSanPham", _tblSanPhamEO.sTenSanPham));
                    cmd.Parameters.Add(new SqlParameter("@sMoTa", _tblSanPhamEO.sMoTa));
                    cmd.Parameters.Add(new SqlParameter("@sThongTin", _tblSanPhamEO.sThongTin));
                    cmd.Parameters.Add(new SqlParameter("@sXuatXu", _tblSanPhamEO.sXuatXu));
                    cmd.Parameters.Add(new SqlParameter("@sLinkImage", _tblSanPhamEO.sLinkImage));
                    cmd.Parameters.Add(new SqlParameter("@lGiaBan", _tblSanPhamEO.lGiaBan));
                    cmd.Parameters.Add(new SqlParameter("@iVAT", _tblSanPhamEO.iVAT));
                    cmd.Parameters.Add(new SqlParameter("@iDoTuoi", _tblSanPhamEO.iDoTuoi));
                    cmd.Parameters.Add(new SqlParameter("@iGioiTinh", _tblSanPhamEO.iGioiTinh));
                    cmd.Parameters.Add(new SqlParameter("@iSoLuong", _tblSanPhamEO.iSoLuong));
                    cmd.Parameters.Add(new SqlParameter("@iTrangThai", _tblSanPhamEO.iTrangThai));
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

        /// <summary> 3. SanPham_Update </summary>
        /// <param name="_tblSanPhamEO"></param>
        /// <returns></returns>
        public static bool SanPham_Update(tblSanPhamEO _tblSanPhamEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblSanPham_Update", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_sSanPhamID", _tblSanPhamEO.PK_sSanPhamID));
                    cmd.Parameters.Add(new SqlParameter("@FK_iNhomSanPhamID", _tblSanPhamEO.FK_iNhomSanPhamID));
                    cmd.Parameters.Add(new SqlParameter("@sTenSanPham", _tblSanPhamEO.sTenSanPham));
                    cmd.Parameters.Add(new SqlParameter("@sMoTa", _tblSanPhamEO.sMoTa));
                    cmd.Parameters.Add(new SqlParameter("@sThongTin", _tblSanPhamEO.sThongTin));
                    cmd.Parameters.Add(new SqlParameter("@sXuatXu", _tblSanPhamEO.sXuatXu));
                    cmd.Parameters.Add(new SqlParameter("@sLinkImage", _tblSanPhamEO.sLinkImage));
                    cmd.Parameters.Add(new SqlParameter("@lGiaBan", _tblSanPhamEO.lGiaBan));
                    cmd.Parameters.Add(new SqlParameter("@iVAT", _tblSanPhamEO.iVAT));
                    cmd.Parameters.Add(new SqlParameter("@iDoTuoi", _tblSanPhamEO.iDoTuoi));
                    cmd.Parameters.Add(new SqlParameter("@iGioiTinh", _tblSanPhamEO.iGioiTinh));
                    cmd.Parameters.Add(new SqlParameter("@iSoLuong", _tblSanPhamEO.iSoLuong));
                    cmd.Parameters.Add(new SqlParameter("@iTrangThai", _tblSanPhamEO.iTrangThai));
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

        /// <summary> 3. SanPham_Update_iSoLuong </summary>
        /// <param name="_tblSanPhamEO"></param>
        /// <returns></returns>
        public static bool SanPham_Update_iSoLuong(tblSanPhamEO _tblSanPhamEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblSanPham_Update_iSoLuong", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_sSanPhamID", _tblSanPhamEO.PK_sSanPhamID));
                    cmd.Parameters.Add(new SqlParameter("@iSoLuong", _tblSanPhamEO.iSoLuong));
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

        /// <summary> 4. SanPham_Delete </summary>
        /// <param name="_tblSanPhamEO"></param>
        /// <returns></returns>
        public static bool SanPham_Delete(tblSanPhamEO _tblSanPhamEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblSanPham_Delete", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_sSanPhamID", _tblSanPhamEO.PK_sSanPhamID));
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

        /// <summary> 5. SanPham_DeleteList </summary>
        /// <param name="_ListPK_sMaMonhoc"></param>
        /// <returns></returns>
        public static bool SanPham_DeleteList(String _ListPK_sSanPhamID)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblSanPham_DeleteList", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ListPK_sSanPhamID", _ListPK_sSanPhamID));
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
        /// <summary> 6. SanPham_SelectItem </summary>
        /// <param name="_tblSanPhamEO"></param>
        /// <returns></returns>
        public static tblSanPhamEO SanPham_SelectItem(tblSanPhamEO _tblSanPhamEO)
        {
            tblSanPhamEO oOutput = new tblSanPhamEO();
            DataSet ds = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblSanPham_SelectItem", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_sSanPhamID", _tblSanPhamEO.PK_sSanPhamID));
                    ds = new DataSet();
                    da.Fill(ds);
                    conn.Close();
                    oOutput = DataSet2Object.SanPhamDO(ds);
                    return oOutput;
                }
                catch (Exception)
                {
                    conn.Close();
                    return oOutput;
                }
            }
        }
        /// <summary> 6. SanPham_SelectItemPK_sSanPhamID </summary>
        /// <param name="_tblSanPhamEO"></param>
        /// <returns></returns>
        public static tblSanPhamEO SanPham_SelectItemPK_sSanPhamID(string _PK_sSanPhamID)
        {
            tblSanPhamEO oOutput = new tblSanPhamEO();
            DataSet ds = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblSanPham_SelectItemByPK_sSanPhamID", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_sSanPhamID", _PK_sSanPhamID));
                    ds = new DataSet();
                    da.Fill(ds);
                    conn.Close();
                    oOutput = DataSet2Object.SanPhamDO(ds);
                    return oOutput;
                }
                catch (Exception)
                {
                    conn.Close();
                    return oOutput;
                }
            }
        }

        /// <summary> 8. SanPham_SelectList </summary>
        /// <param name="_tblSanPhamEO"></param>
        /// <returns></returns>
        public static DataSet SanPham_SelectList()
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblSanPham_SelectList", conn);
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

        ///// <summary> 8. SanPham_SelectListByiTrangThai </summary>
        ///// <param name="_tblSanPhamEO"></param>
        ///// <returns></returns>
        //public static DataSet SanPham_SelectListByiTrangThai(tblSanPhamEO _tblSanPhamEO)
        //{
        //    DataSet dsOutput = null;
        //    using (SqlConnection conn = ConnectionDAO.getConnection())
        //    {
        //        try
        //        {
        //            conn.Open();
        //            SqlDataAdapter da = new SqlDataAdapter("tblSanPham_SelectList", conn);
        //            da.SelectCommand.CommandType = CommandType.StoredProcedure;
        //            da.SelectCommand.Parameters.Add(new SqlParameter("@iTrangThai", _tblSanPhamEO.iTrangThai));
        //            dsOutput = new DataSet();
        //            da.Fill(dsOutput);
        //            conn.Close();
        //            return dsOutput;
        //        }
        //        catch (Exception)
        //        {
        //            conn.Close();
        //            return dsOutput;
        //        }
        //    }
        //}

        /// <summary> 9. SanPham_SelectListByFK_iNhomSanPhamID_iTrangThai </summary>
        /// <param name="_tblSanPhamEO"></param>
        /// <returns></returns>
        public static DataSet SanPham_SelectListByFK_iNhomSanPhamID_iTrangThai(tblSanPhamEO _tblSanPhamEO)
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblSanPham_SelectListByFK_iNhomSanPhamID_iTrangThai", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@FK_iNhomSanPhamID", (_tblSanPhamEO.FK_iNhomSanPhamID == 0) ? (object)DBNull.Value : _tblSanPhamEO.FK_iNhomSanPhamID));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@iTrangThai", (_tblSanPhamEO.iTrangThai==0)?(object)DBNull.Value:_tblSanPhamEO.iTrangThai));
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

        /// <summary> 10. SanPham_SelectList_All_Parent_In_Group </summary>
        /// <param name="_tblSanPhamEO"></param>
        /// <returns></returns>
        public static DataSet SanPham_SelectList_All_Parent_In_Group(tblSanPhamEO _tblSanPhamEO)
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblSanPham_SelectList_All_Parent_In_Group", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@FK_iNhomSanPhamID", _tblSanPhamEO.FK_iNhomSanPhamID));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@iTrangThai", _tblSanPhamEO.iTrangThai));
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

        /// <summary> 11. SanPham_SelectList_All_SanPham </summary>
        /// <param name="_tblSanPhamEO"></param>
        /// <returns></returns>
        public static DataSet SanPham_SelectListByiTrangThai(tblSanPhamEO _tblSanPhamEO)
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblSanPham_SelectListByiTrangThai", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@iTrangThai", _tblSanPhamEO.iTrangThai));
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

        /// <summary> 12. SanPham_SelectByFK_iNhomSanPhamID </summary>
        /// <param name="_tblSanPhamEO"></param>
        /// <returns></returns>
        public static DataSet SanPham_SelectByFK_iNhomSanPhamID(tblSanPhamEO _tblSanPhamEO)
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblSanPham_SelectByFK_iNhomSanPhamID", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@FK_iNhomSanPhamID", _tblSanPhamEO.FK_iNhomSanPhamID));
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

        /// <summary> 13. SanPham_Search_Common </summary>
        /// <param name="_tblSanPhamEO"></param>
        /// <returns></returns>
        public static DataSet SanPham_Search_Common(string keyword)
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblSanPham_Search_Common", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@keyword", keyword));

                    //da.SelectCommand.Parameters.Add(new SqlParameter("@PK_sSanPhamID", _tblSanPhamEO.PK_sSanPhamID));
                    //da.SelectCommand.Parameters.Add(new SqlParameter("@lGroup", _tblSanPhamEO.lGroup));
                    //da.SelectCommand.Parameters.Add(new SqlParameter("@lParent", _tblSanPhamEO.lParent));
                    //da.SelectCommand.Parameters.Add(new SqlParameter("@sName", _tblSanPhamEO.sName));
                    //da.SelectCommand.Parameters.Add(new SqlParameter("@lPrice", _tblSanPhamEO.lPrice));
                    //da.SelectCommand.Parameters.Add(new SqlParameter("@lSale", _tblSanPhamEO.lSale));
                    //da.SelectCommand.Parameters.Add(new SqlParameter("@bVAT", _tblSanPhamEO.bVAT));
                    //da.SelectCommand.Parameters.Add(new SqlParameter("@sDescription", _tblSanPhamEO.sDescription));
                    //da.SelectCommand.Parameters.Add(new SqlParameter("@sInfomation", _tblSanPhamEO.sInfomation));
                    //da.SelectCommand.Parameters.Add(new SqlParameter("@sOrigin", _tblSanPhamEO.sOrigin));
                    //da.SelectCommand.Parameters.Add(new SqlParameter("@iQuantity", _tblSanPhamEO.iQuantity));
                    //da.SelectCommand.Parameters.Add(new SqlParameter("@sLinkImage", _tblSanPhamEO.sLinkImage));
                    //da.SelectCommand.Parameters.Add(new SqlParameter("@sLinkImage1", _tblSanPhamEO.sLinkImage1));
                    //da.SelectCommand.Parameters.Add(new SqlParameter("@sLinkImage2", _tblSanPhamEO.sLinkImage2));
                    //da.SelectCommand.Parameters.Add(new SqlParameter("@tLastUpdate", _tblSanPhamEO.tLastUpdate));
                    //da.SelectCommand.Parameters.Add(new SqlParameter("@bStatus", _tblSanPhamEO.bStatus));
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

        /// <summary> 13. SanPham_Search </summary>
        /// <param name="_tblSanPhamEO"></param>
        /// <returns></returns>
        public static DataSet SanPham_Search(tblSanPhamEO _tblSanPhamEO)
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblSanPham_Search", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_sSanPhamID", (string.IsNullOrEmpty(_tblSanPhamEO.PK_sSanPhamID) == true) ? (object)DBNull.Value : _tblSanPhamEO.PK_sSanPhamID));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sTenSanPham", (string.IsNullOrEmpty(_tblSanPhamEO.sTenSanPham) == true) ? (object)DBNull.Value : _tblSanPhamEO.sTenSanPham));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sMoTa", (string.IsNullOrEmpty(_tblSanPhamEO.sMoTa) == true) ? (object)DBNull.Value : _tblSanPhamEO.sMoTa));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sXuatXu", (string.IsNullOrEmpty(_tblSanPhamEO.sXuatXu) == true) ? (object)DBNull.Value : _tblSanPhamEO.sXuatXu));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@lGiaBan", (_tblSanPhamEO.lGiaBan == 0) ? (object)DBNull.Value : _tblSanPhamEO.lGiaBan));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@iDoTuoi", (_tblSanPhamEO.iDoTuoi == 0) ? (object)DBNull.Value : _tblSanPhamEO.iDoTuoi));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@iGioiTinh", (_tblSanPhamEO.iGioiTinh == 0) ? (object)DBNull.Value : _tblSanPhamEO.iGioiTinh));
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