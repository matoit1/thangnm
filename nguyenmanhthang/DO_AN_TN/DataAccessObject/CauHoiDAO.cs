using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using EntityObject;

namespace DataAccessObject
{
    public class CauHoiDAO
    {
        /// <summary> 1. CauHoi_CheckExists </summary>
        /// <param name="_CauHoiEO"></param>
        /// <returns></returns>
        public static bool CauHoi_CheckExists(CauHoiEO _CauHoiEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblCauHoi_CheckExists", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_lCauhoi_ID", _CauHoiEO.PK_lCauhoi_ID));
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    conn.Close();
                    if (Convert.ToInt32(ds.Tables[0].Rows.Count) > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception)
                {
                    conn.Close();
                    return false;
                }
            }
        }

        /// <summary> 2. CauHoi_Insert </summary>
        /// <param name="_CauHoiEO"></param>
        /// <returns></returns>
        public static bool CauHoi_Insert(CauHoiEO _CauHoiEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblCauHoi_Insert", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@FK_sMaGV", _CauHoiEO.FK_sMaGV));
                    cmd.Parameters.Add(new SqlParameter("@PK_lCauhoi_ID", _CauHoiEO.PK_lCauhoi_ID));
                    cmd.Parameters.Add(new SqlParameter("@sCauhoi_Cauhoi", _CauHoiEO.sCauhoi_Cauhoi));
                    cmd.Parameters.Add(new SqlParameter("@sCauhoi_A", _CauHoiEO.sCauhoi_A));
                    cmd.Parameters.Add(new SqlParameter("@sCauhoi_B", _CauHoiEO.sCauhoi_B));
                    cmd.Parameters.Add(new SqlParameter("@sCauhoi_C", _CauHoiEO.sCauhoi_C));
                    cmd.Parameters.Add(new SqlParameter("@sCauhoi_D", _CauHoiEO.sCauhoi_D));
                    cmd.Parameters.Add(new SqlParameter("@iCauhoi_Dung", _CauHoiEO.iCauhoi_Dung));
                    cmd.Parameters.Add(new SqlParameter("@sBoCauHoi", _CauHoiEO.sBoCauHoi));
                    cmd.Parameters.Add(new SqlParameter("@tNgayTao", _CauHoiEO.tNgayTao));
                    cmd.Parameters.Add(new SqlParameter("@tNgayCapNhat", _CauHoiEO.tNgayCapNhat));
                    cmd.Parameters.Add(new SqlParameter("@iTrangThai", _CauHoiEO.iTrangThai));
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

        /// <summary> 3. CauHoi_Update </summary>
        /// <param name="_CauHoiEO"></param>
        /// <returns></returns>
        public static bool CauHoi_Update(CauHoiEO _CauHoiEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblCauHoi_Update", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@FK_sMaGV", _CauHoiEO.FK_sMaGV));
                    cmd.Parameters.Add(new SqlParameter("@PK_lCauhoi_ID", _CauHoiEO.PK_lCauhoi_ID));
                    cmd.Parameters.Add(new SqlParameter("@sCauhoi_Cauhoi", _CauHoiEO.sCauhoi_Cauhoi));
                    cmd.Parameters.Add(new SqlParameter("@sCauhoi_A", _CauHoiEO.sCauhoi_A));
                    cmd.Parameters.Add(new SqlParameter("@sCauhoi_B", _CauHoiEO.sCauhoi_B));
                    cmd.Parameters.Add(new SqlParameter("@sCauhoi_C", _CauHoiEO.sCauhoi_C));
                    cmd.Parameters.Add(new SqlParameter("@sCauhoi_D", _CauHoiEO.sCauhoi_D));
                    cmd.Parameters.Add(new SqlParameter("@iCauhoi_Dung", _CauHoiEO.iCauhoi_Dung));
                    cmd.Parameters.Add(new SqlParameter("@sBoCauHoi", _CauHoiEO.sBoCauHoi));
                    cmd.Parameters.Add(new SqlParameter("@tNgayTao", _CauHoiEO.tNgayTao));
                    cmd.Parameters.Add(new SqlParameter("@tNgayCapNhat", _CauHoiEO.tNgayCapNhat));
                    cmd.Parameters.Add(new SqlParameter("@iTrangThai", _CauHoiEO.iTrangThai));
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

        /// <summary> 4. CauHoi_Delete </summary>
        /// <param name="_CauHoiEO"></param>
        /// <returns></returns>
        public static bool CauHoi_Delete(CauHoiEO _CauHoiEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblCauHoi_Delete", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_lCauhoi_ID", _CauHoiEO.PK_lCauhoi_ID));
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

        /// <summary> 5. CauHoi_DeleteList </summary>
        /// <param name="_ListPK_sMaMonhoc"></param>
        /// <returns></returns>
        public static bool CauHoi_DeleteList(String _ListPK_lCauhoi_ID)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblCauHoi_DeleteList", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ListPK_lCauhoi_ID", _ListPK_lCauhoi_ID));
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

        /// <summary> 6. CauHoi_SelectItem </summary>
        /// <param name="_CauHoiEO"></param>
        /// <returns></returns>
        public static CauHoiEO CauHoi_SelectItem(CauHoiEO _CauHoiEO)
        {
            CauHoiEO output = new CauHoiEO();
            DataSet ds = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblCauHoi_SelectItem", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_lCauhoi_ID", _CauHoiEO.PK_lCauhoi_ID));
                    ds = new DataSet();
                    da.Fill(ds);
                    conn.Close();
                    output = DataSet2Object.CauHoi(ds);
                    return output;
                }
                catch (Exception)
                {
                    conn.Close();
                    return output;
                }
            }
        }

        /// <summary> 7. CauHoi_SelectList </summary>
        /// <param name="_CauHoiEO"></param>
        /// <returns></returns>
        public static DataSet CauHoi_SelectList()
        {
            DataSet ds = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblCauHoi_SelectList", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    ds = new DataSet();
                    da.Fill(ds);
                    conn.Close();
                    return ds;
                }
                catch (Exception)
                {
                    conn.Close();
                    return ds;
                }
            }
        }

        /// <summary> 8. CauHoi_Search </summary>
        /// <param name="_CauHoiEO"></param>
        /// <returns></returns>
        public static DataSet CauHoi_Search(CauHoiEO _CauHoiEO)
        {
            DataSet ds = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblCauHoi_Search", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@FK_sMaGV", _CauHoiEO.FK_sMaGV));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_lCauhoi_ID", _CauHoiEO.PK_lCauhoi_ID));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sCauhoi_Cauhoi", _CauHoiEO.sCauhoi_Cauhoi));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sCauhoi_A", _CauHoiEO.sCauhoi_A));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sCauhoi_B", _CauHoiEO.sCauhoi_B));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sCauhoi_C", _CauHoiEO.sCauhoi_C));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sCauhoi_D", _CauHoiEO.sCauhoi_D));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@iCauhoi_Dung", _CauHoiEO.iCauhoi_Dung));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sBoCauHoi", _CauHoiEO.sBoCauHoi));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@tNgayTao", _CauHoiEO.tNgayTao));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@tNgayCapNhat", _CauHoiEO.tNgayCapNhat));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@iTrangThai", _CauHoiEO.iTrangThai));
                    ds = new DataSet();
                    da.Fill(ds);
                    conn.Close();
                    return ds;
                }
                catch (Exception)
                {
                    conn.Close();
                    return ds;
                }
            }
        }
    }
}