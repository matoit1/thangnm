using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using HaBa.EntityObject;

namespace HaBa.DataAccessObject
{
    public class tblNhomSanPhamDAO
    {
        #region "CheckExists"
        /// <summary> 1. NhomSanPham_CheckExists </summary>
        /// <param name="_tblNhomSanPhamEO"></param>
        /// <returns></returns>
        public static bool NhomSanPham_CheckExists(tblNhomSanPhamEO _tblNhomSanPhamEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                bool bOutput = false;
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblNhomSanPham_CheckExists", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_iNhomSanPhamID", _tblNhomSanPhamEO.PK_iNhomSanPhamID));
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
        /// <summary> 2. NhomSanPham_Insert </summary>
        /// <param name="_tblNhomSanPhamEO"></param>
        /// <returns></returns>
        public static bool NhomSanPham_Insert(tblNhomSanPhamEO _tblNhomSanPhamEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblNhomSanPham_Insert", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@iNhomCon", _tblNhomSanPhamEO.iNhomCon));
                    cmd.Parameters.Add(new SqlParameter("@sTenNhom", _tblNhomSanPhamEO.sTenNhom));
                    cmd.Parameters.Add(new SqlParameter("@iTrangThai", _tblNhomSanPhamEO.iTrangThai));
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

        /// <summary> 3. NhomSanPham_Update </summary>
        /// <param name="_tblNhomSanPhamEO"></param>
        /// <returns></returns>
        public static bool NhomSanPham_Update(tblNhomSanPhamEO _tblNhomSanPhamEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblNhomSanPham_Update", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_iNhomSanPhamID", _tblNhomSanPhamEO.PK_iNhomSanPhamID));
                    cmd.Parameters.Add(new SqlParameter("@iNhomCon", _tblNhomSanPhamEO.iNhomCon));
                    cmd.Parameters.Add(new SqlParameter("@sTenNhom", _tblNhomSanPhamEO.sTenNhom));
                    cmd.Parameters.Add(new SqlParameter("@iTrangThai", _tblNhomSanPhamEO.iTrangThai));
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


        /// <summary> 5. NhomSanPham_Delete </summary>
        /// <param name="_ListPK_sMaMonhoc"></param>
        /// <returns></returns>
        public static bool NhomSanPham_Delete(tblNhomSanPhamEO _tblNhomSanPhamEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblNhomSanPham_Delete", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_iNhomSanPhamID", _tblNhomSanPhamEO.PK_iNhomSanPhamID));
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

        
        /// <summary> 5. NhomSanPham_DeleteList </summary>
        /// <param name="_ListPK_sMaMonhoc"></param>
        /// <returns></returns>
        public static bool NhomSanPham_DeleteList(String _ListPK_iTaiKhoanID)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblNhomSanPham_DeleteList", conn);
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
        /// <summary> 6. NhomSanPham_SelectItem </summary>
        /// <param name="_tblNhomSanPhamEO"></param>
        /// <returns></returns>
        public static tblNhomSanPhamEO NhomSanPham_SelectItem(tblNhomSanPhamEO _tblNhomSanPhamEO)
        {
            tblNhomSanPhamEO oOutput = new tblNhomSanPhamEO();
            DataSet ds = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblNhomSanPham_SelectItem", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_iNhomSanPhamID", _tblNhomSanPhamEO.PK_iNhomSanPhamID));
                    ds = new DataSet();
                    da.Fill(ds);
                    conn.Close();
                    oOutput = DataSet2Object.NhomSanPhamDO(ds);
                    return oOutput;
                }
                catch (Exception)
                {
                    conn.Close();
                    return oOutput;
                }
            }
        }
        /// <summary> 6. NhomSanPham_SelectItem_By_PK_iNhomSanPhamID </summary>
        /// <param name="_tblNhomSanPhamEO"></param>
        /// <returns></returns>
        public static tblNhomSanPhamEO NhomSanPham_SelectItem_By_PK_iNhomSanPhamID(Int16 _PK_iNhomSanPhamID)
        {
            tblNhomSanPhamEO oOutput = new tblNhomSanPhamEO();
            DataSet ds = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblNhomSanPham_SelectItem", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_iNhomSanPhamID", _PK_iNhomSanPhamID));
                    ds = new DataSet();
                    da.Fill(ds);
                    conn.Close();
                    oOutput = DataSet2Object.NhomSanPhamDO(ds);
                    return oOutput;
                }
                catch (Exception)
                {
                    conn.Close();
                    return oOutput;
                }
            }
        }
        

        /// <summary> 8. NhomSanPham_SelectList </summary>
        /// <param name="_tblNhomSanPhamEO"></param>
        /// <returns></returns>
        public static DataSet NhomSanPham_SelectList()
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblNhomSanPham_SelectList", conn);
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


        /// <summary> 8. NhomSanPham_SelectListByiTrangThai </summary>
        /// <param name="_tblNhomSanPhamEO"></param>
        /// <returns></returns>
        public static DataSet NhomSanPham_SelectListByiTrangThai(tblNhomSanPhamEO _tblNhomSanPhamEO)
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblNhomSanPham_SelectListByiTrangThai", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@iTrangThai", _tblNhomSanPhamEO.iTrangThai));
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

        /// <summary> 9. NhomSanPham_Search </summary>
        /// <param name="_tblNhomSanPhamEO"></param>
        /// <returns></returns>
        public static DataSet NhomSanPham_Search(tblNhomSanPhamEO _tblNhomSanPhamEO)
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblNhomSanPham_Search", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_iNhomSanPhamID", _tblNhomSanPhamEO.PK_iNhomSanPhamID));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@iNhomCon", _tblNhomSanPhamEO.iNhomCon));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sTenNhom", _tblNhomSanPhamEO.sTenNhom));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@iTrangThai", _tblNhomSanPhamEO.iTrangThai));
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