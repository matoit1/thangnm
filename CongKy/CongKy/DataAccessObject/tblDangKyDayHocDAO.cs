using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using CongKy.EntityObject;

namespace CongKy.DataAccessObject
{
    public class tblDangKyDayHocDAO
    {
        #region "CheckExists"
        /// <summary> 1. DangKyDayHoc_CheckExists </summary>
        /// <param name="_tblDangKyDayHocEO"></param>
        /// <returns></returns>
        public static bool DangKyDayHoc_CheckExists(tblDangKyDayHocEO _tblDangKyDayHocEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                bool bOutput = false;
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblDangKyDayHoc_CheckExists", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@FK_iTaiKhoanID", _tblDangKyDayHocEO.FK_iTaiKhoanID));
                    cmd.Parameters.Add(new SqlParameter("@FK_iMonHocID", _tblDangKyDayHocEO.FK_iMonHocID));
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
        /// <summary> 2. DangKyDayHoc_Insert </summary>
        /// <param name="_tblDangKyDayHocEO"></param>
        /// <returns></returns>
        public static bool DangKyDayHoc_Insert(tblDangKyDayHocEO _tblDangKyDayHocEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblDangKyDayHoc_Insert", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@FK_iTaiKhoanID", _tblDangKyDayHocEO.FK_iTaiKhoanID));
                    cmd.Parameters.Add(new SqlParameter("@FK_iMonHocID", _tblDangKyDayHocEO.FK_iMonHocID));
                    cmd.Parameters.Add(new SqlParameter("@tNgayDangKy", _tblDangKyDayHocEO.tNgayDangKy));
                    cmd.Parameters.Add(new SqlParameter("@iTrangThai", _tblDangKyDayHocEO.iTrangThai));
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

        

        /// <summary> 3. DangKyDayHoc_Update </summary>
        /// <param name="_tblDangKyDayHocEO"></param>
        /// <returns></returns>
        public static bool DangKyDayHoc_Update(tblDangKyDayHocEO _tblDangKyDayHocEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblDangKyDayHoc_Update", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@FK_iTaiKhoanID", _tblDangKyDayHocEO.FK_iTaiKhoanID));
                    cmd.Parameters.Add(new SqlParameter("@FK_iMonHoc", _tblDangKyDayHocEO.FK_iMonHocID));
                    cmd.Parameters.Add(new SqlParameter("@tNgayDangKy", _tblDangKyDayHocEO.tNgayDangKy));
                    cmd.Parameters.Add(new SqlParameter("@iTrangThai", _tblDangKyDayHocEO.iTrangThai));
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

        /// <summary> 4. DangKyDayHoc_Delete </summary>
        /// <param name="_tblDangKyDayHocEO"></param>
        /// <returns></returns>
        public static bool DangKyDayHoc_Delete(tblDangKyDayHocEO _tblDangKyDayHocEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblDangKyDayHoc_Delete", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@FK_iTaiKhoanID", _tblDangKyDayHocEO.FK_iTaiKhoanID));
                    cmd.Parameters.Add(new SqlParameter("@FK_iMonHocID", _tblDangKyDayHocEO.FK_iMonHocID));
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
        /// <summary> 6. DangKyDayHoc_SelectItem </summary>
        /// <param name="_tblDangKyDayHocEO"></param>
        /// <returns></returns>
        public static tblDangKyDayHocEO DangKyDayHoc_SelectItem(tblDangKyDayHocEO _tblDangKyDayHocEO)
        {
            tblDangKyDayHocEO oOutput = new tblDangKyDayHocEO();
            DataSet ds = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblDangKyDayHoc_SelectItem", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@FK_iTaiKhoanID", _tblDangKyDayHocEO.FK_iTaiKhoanID));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@FK_iMonHocID", _tblDangKyDayHocEO.FK_iMonHocID));
                    ds = new DataSet();
                    da.Fill(ds);
                    conn.Close();
                    oOutput = DataSet2Object.DangKyDayHocDO(ds);
                    return oOutput;
                }
                catch (Exception)
                {
                    conn.Close();
                    return oOutput;
                }
            }
        }
        

        /// <summary> 8. DangKyDayHoc_SelectList </summary>
        /// <param name="_tblDangKyDayHocEO"></param>
        /// <returns></returns>
        public static DataSet DangKyDayHoc_SelectList()
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblDangKyDayHoc_SelectList", conn);
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

        

        /// <summary> 9. DangKyDayHoc_Search </summary>
        /// <param name="_tblDangKyDayHocEO"></param>
        /// <returns></returns>
        public static DataSet DangKyDayHoc_Search(tblDangKyDayHocEO _tblDangKyDayHocEO)
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblDangKyDayHoc_Search", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@FK_iTaiKhoanID", _tblDangKyDayHocEO.FK_iTaiKhoanID));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@FK_iMonHocID", _tblDangKyDayHocEO.FK_iMonHocID));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@tNgayDangKy", _tblDangKyDayHocEO.tNgayDangKy));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@iTrangThai", _tblDangKyDayHocEO.iTrangThai));
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