using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using EntityObject;

namespace DataAccessObject
{
    public class PhanCongCongTacDAO
    {
        /// <summary> 1. PhanCongCongTac_CheckExists </summary>
        /// <param name="_PhanCongCongTacEO"></param>
        /// <returns></returns>
        public static bool PhanCongCongTac_CheckExists(PhanCongCongTacEO _PhanCongCongTacEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblPhanCongCongTac_CheckExists", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_sMaPCCT", _PhanCongCongTacEO.PK_sMaPCCT));
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

        /// <summary> 2. PhanCongCongTac_Insert </summary>
        /// <param name="_PhanCongCongTacEO"></param>
        /// <returns></returns>
        public static bool PhanCongCongTac_Insert(PhanCongCongTacEO _PhanCongCongTacEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblPhanCongCongTac_Insert", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_sMaPCCT", _PhanCongCongTacEO.PK_sMaPCCT));
                    cmd.Parameters.Add(new SqlParameter("@FK_sMaGV", _PhanCongCongTacEO.FK_sMaGV));
                    cmd.Parameters.Add(new SqlParameter("@FK_sMaMonhoc", _PhanCongCongTacEO.FK_sMaMonhoc));
                    cmd.Parameters.Add(new SqlParameter("@tNgayBatDau", _PhanCongCongTacEO.tNgayBatDau));
                    cmd.Parameters.Add(new SqlParameter("@tNgayKetThuc", _PhanCongCongTacEO.tNgayKetThuc));
                    cmd.Parameters.Add(new SqlParameter("@iTrangThai", _PhanCongCongTacEO.iTrangThai));
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

        /// <summary> 3. PhanCongCongTac_Update </summary>
        /// <param name="_PhanCongCongTacEO"></param>
        /// <returns></returns>
        public static bool PhanCongCongTac_Update(PhanCongCongTacEO _PhanCongCongTacEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblPhanCongCongTac_Update", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_sMaPCCT", _PhanCongCongTacEO.PK_sMaPCCT));
                    cmd.Parameters.Add(new SqlParameter("@FK_sMaGV", _PhanCongCongTacEO.FK_sMaGV));
                    cmd.Parameters.Add(new SqlParameter("@FK_sMaMonhoc", _PhanCongCongTacEO.FK_sMaMonhoc));
                    cmd.Parameters.Add(new SqlParameter("@tNgayBatDau", _PhanCongCongTacEO.tNgayBatDau));
                    cmd.Parameters.Add(new SqlParameter("@tNgayKetThuc", _PhanCongCongTacEO.tNgayKetThuc));
                    cmd.Parameters.Add(new SqlParameter("@iTrangThai", _PhanCongCongTacEO.iTrangThai));
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

        /// <summary> 4. PhanCongCongTac_Delete </summary>
        /// <param name="_PhanCongCongTacEO"></param>
        /// <returns></returns>
        public static bool PhanCongCongTac_Delete(PhanCongCongTacEO _PhanCongCongTacEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblPhanCongCongTac_Delete", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_sMaPCCT", _PhanCongCongTacEO.PK_sMaPCCT));
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

        /// <summary> 5. PhanCongCongTac_DeleteList </summary>
        /// <param name="_ListPK_sMaMonhoc"></param>
        /// <returns></returns>
        public static bool PhanCongCongTac_DeleteList(String _ListPK_sMaPCCT)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblPhanCongCongTac_DeleteList", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ListPK_sMaPCCT", _ListPK_sMaPCCT));
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

        /// <summary> 6. PhanCongCongTac_SelectItem </summary>
        /// <param name="_PhanCongCongTacEO"></param>
        /// <returns></returns>
        public static DataSet PhanCongCongTac_SelectItem(PhanCongCongTacEO _PhanCongCongTacEO)
        {
            DataSet ds = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblPhanCongCongTac_SelectItem", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_sMaPCCT", _PhanCongCongTacEO.PK_sMaPCCT));
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

        /// <summary> 7. PhanCongCongTac_SelectList </summary>
        /// <param name="_PhanCongCongTacEO"></param>
        /// <returns></returns>
        public static DataSet PhanCongCongTac_SelectList(PhanCongCongTacEO _PhanCongCongTacEO)
        {
            DataSet ds = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblPhanCongCongTac_SelectList", conn);
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

        /// <summary> 8. PhanCongCongTac_Search </summary>
        /// <param name="_PhanCongCongTacEO"></param>
        /// <returns></returns>
        public static DataSet PhanCongCongTac_Search(PhanCongCongTacEO _PhanCongCongTacEO)
        {
            DataSet ds = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblPhanCongCongTac_Search", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_sMaPCCT", _PhanCongCongTacEO.PK_sMaPCCT));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@FK_sMaGV", _PhanCongCongTacEO.FK_sMaGV));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@FK_sMaMonhoc", _PhanCongCongTacEO.FK_sMaMonhoc));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@tNgayBatDau", _PhanCongCongTacEO.tNgayBatDau));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@tNgayKetThuc", _PhanCongCongTacEO.tNgayKetThuc));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@iTrangThai", _PhanCongCongTacEO.iTrangThai));
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