using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using CongKy.EntityObject;

namespace CongKy.DataAccessObject
{
    public class tblMonHocDAO
    {
        #region "CheckExists"
        /// <summary> 1. MonHoc_CheckExists_PK_iMonHocID </summary>
        /// <param name="_tblMonHocEO"></param>
        /// <returns></returns>
        public static bool MonHoc_CheckExists_PK_iMonHocID(tblMonHocEO _tblMonHocEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                bool bOutput = false;
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblMonHoc_CheckExists_PK_iMonHocID", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_iMonHocID", _tblMonHocEO.PK_iMonHocID));
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

        /// <summary> 2. MonHoc_CheckExists_sTenMonHoc </summary>
        /// <param name="_tblMonHocEO"></param>
        /// <returns></returns>
        public static bool MonHoc_CheckExists_sTenMonHoc(tblMonHocEO _tblMonHocEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                bool bOutput = false;
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblMonHoc_CheckExists_sTenMonHoc", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@sTenMonHoc", _tblMonHocEO.sTenMonHoc));
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
        /// <summary> 2. MonHoc_Insert </summary>
        /// <param name="_tblMonHocEO"></param>
        /// <returns></returns>
        public static bool MonHoc_Insert(tblMonHocEO _tblMonHocEO, int FK_iTaiKhoanID)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblMonHoc_Insert", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@sTenMonHoc", _tblMonHocEO.sTenMonHoc));
                    cmd.Parameters.Add(new SqlParameter("@sLinkImage", _tblMonHocEO.sLinkImage));
                    cmd.Parameters.Add(new SqlParameter("@iTrangThai", _tblMonHocEO.iTrangThai));
                    cmd.Parameters.Add(new SqlParameter("@FK_iTaiKhoanID", FK_iTaiKhoanID));
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

        /// <summary> 3. MonHoc_Update </summary>
        /// <param name="_tblMonHocEO"></param>
        /// <returns></returns>
        public static bool MonHoc_Update(tblMonHocEO _tblMonHocEO, int FK_iTaiKhoanID)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblMonHoc_Update", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_iMonHocID", _tblMonHocEO.PK_iMonHocID));
                    cmd.Parameters.Add(new SqlParameter("@sTenMonHoc", _tblMonHocEO.sTenMonHoc));
                    cmd.Parameters.Add(new SqlParameter("@sLinkImage", _tblMonHocEO.sLinkImage));
                    cmd.Parameters.Add(new SqlParameter("@iTrangThai", _tblMonHocEO.iTrangThai));
                    cmd.Parameters.Add(new SqlParameter("@FK_iTaiKhoanID", FK_iTaiKhoanID));
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

        /// <summary> 4. MonHoc_Delete </summary>
        /// <param name="_tblMonHocEO"></param>
        /// <returns></returns>
        public static bool MonHoc_Delete(tblMonHocEO _tblMonHocEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblMonHoc_Delete", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
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

       
        #endregion

        #region "Select"
        /// <summary> 6. MonHoc_SelectItem </summary>
        /// <param name="_tblMonHocEO"></param>
        /// <returns></returns>
        public static tblMonHocEO MonHoc_SelectItem(tblMonHocEO _tblMonHocEO)
        {
            tblMonHocEO oOutput = new tblMonHocEO();
            DataSet ds = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblMonHoc_SelectItem", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_iMonHocID", _tblMonHocEO.PK_iMonHocID));
                    ds = new DataSet();
                    da.Fill(ds);
                    conn.Close();
                    oOutput = DataSet2Object.MonHocDO(ds);
                    return oOutput;
                }
                catch (Exception)
                {
                    conn.Close();
                    return oOutput;
                }
            }
        }
        /// <summary> 6. MonHoc_SelectItemPK_iMonHocID </summary>
        /// <param name="_tblMonHocEO"></param>
        /// <returns></returns>
        public static tblMonHocEO MonHoc_SelectItemPK_iMonHocID(string _PK_iMonHocID)
        {
            tblMonHocEO oOutput = new tblMonHocEO();
            DataSet ds = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblMonHoc_SelectItemByPK_iMonHocID", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_iMonHocID", _PK_iMonHocID));
                    ds = new DataSet();
                    da.Fill(ds);
                    conn.Close();
                    oOutput = DataSet2Object.MonHocDO(ds);
                    return oOutput;
                }
                catch (Exception)
                {
                    conn.Close();
                    return oOutput;
                }
            }
        }

        /// <summary> 8. MonHoc_SelectList </summary>
        /// <param name="_tblMonHocEO"></param>
        /// <returns></returns>
        public static DataSet MonHoc_SelectList()
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblMonHoc_SelectList", conn);
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

        /// <summary> 11. MonHoc_SelectListByiTrangThai </summary>
        /// <param name="_tblMonHocEO"></param>
        /// <returns></returns>
        public static DataSet MonHoc_SelectListByiTrangThai(tblMonHocEO _tblMonHocEO)
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblMonHoc_SelectListByiTrangThai", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@iTrangThai", _tblMonHocEO.iTrangThai));
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

        /// <summary> 11. MonHoc_SelectListByFK_iTaiKhoanID </summary>
        /// <param name="_tblMonHocEO"></param>
        /// <returns></returns>
        public static DataSet MonHoc_SelectListByFK_iTaiKhoanID(tblMonHocEO _tblMonHocEO, tblTaiKhoanEO _tblTaiKhoanEO)
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblMonHoc_SelectListByFK_iTaiKhoanID", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@iTrangThai", _tblMonHocEO.iTrangThai));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@FK_iTaiKhoanID", _tblTaiKhoanEO.PK_iTaiKhoanID));
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

        /// <summary> 12. MonHoc_SelectBysTenMonHoc </summary>
        /// <param name="_tblMonHocEO"></param>
        /// <returns></returns>
        public static DataSet MonHoc_SelectBysTenMonHoc(tblMonHocEO _tblMonHocEO)
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblMonHoc_SelectBysTenMonHoc", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sTenMonHoc", _tblMonHocEO.sTenMonHoc));
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

        /// <summary> 13. MonHoc_Search </summary>
        /// <param name="_tblMonHocEO"></param>
        /// <returns></returns>
        public static DataSet MonHoc_Search(tblMonHocEO _tblMonHocEO)
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblMonHoc_Search", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sTenMonHoc", (string.IsNullOrEmpty(_tblMonHocEO.sTenMonHoc) == true) ? (object)DBNull.Value : _tblMonHocEO.sTenMonHoc));
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