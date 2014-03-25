using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using EntityObject;

namespace DataAccessObject
{
    public class DiemThiDAO
    {
        /// <summary> 1. DiemThi_CheckExists </summary>
        /// <param name="_DiemThiEO"></param>
        /// <returns></returns>
        public static bool DiemThi_CheckExists(DiemThiEO _DiemThiEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblDiemThi_CheckExists", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@FK_sMaSV", _DiemThiEO.FK_sMaSV));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@FK_sMaMonhoc", _DiemThiEO.FK_sMaMonhoc));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_iSolanhoc", _DiemThiEO.PK_iSolanhoc));
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

        /// <summary> 2. DiemThi_Insert </summary>
        /// <param name="_DiemThiEO"></param>
        /// <returns></returns>
        public static bool DiemThi_Insert(DiemThiEO _DiemThiEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblDiemThi_Insert", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@FK_sMaSV", _DiemThiEO.FK_sMaSV));
                    cmd.Parameters.Add(new SqlParameter("@FK_sMaMonhoc", _DiemThiEO.FK_sMaMonhoc));
                    cmd.Parameters.Add(new SqlParameter("@PK_iSolanhoc", _DiemThiEO.PK_iSolanhoc));
                    cmd.Parameters.Add(new SqlParameter("@fDiemchuyencan", _DiemThiEO.fDiemchuyencan));
                    cmd.Parameters.Add(new SqlParameter("@fDiemgiuaky", _DiemThiEO.fDiemgiuaky));
                    cmd.Parameters.Add(new SqlParameter("@fDiemthilan1", _DiemThiEO.fDiemthilan1));
                    cmd.Parameters.Add(new SqlParameter("@fDiemthilan2", _DiemThiEO.fDiemthilan2));
                    cmd.Parameters.Add(new SqlParameter("@iTrangThai", _DiemThiEO.iTrangThai));
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

        /// <summary> 3. DiemThi_Update </summary>
        /// <param name="_DiemThiEO"></param>
        /// <returns></returns>
        public static bool DiemThi_Update(DiemThiEO _DiemThiEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblDiemThi_Update", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@FK_sMaSV", _DiemThiEO.FK_sMaSV));
                    cmd.Parameters.Add(new SqlParameter("@FK_sMaMonhoc", _DiemThiEO.FK_sMaMonhoc));
                    cmd.Parameters.Add(new SqlParameter("@PK_iSolanhoc", _DiemThiEO.PK_iSolanhoc));
                    cmd.Parameters.Add(new SqlParameter("@fDiemchuyencan", _DiemThiEO.fDiemchuyencan));
                    cmd.Parameters.Add(new SqlParameter("@fDiemgiuaky", _DiemThiEO.fDiemgiuaky));
                    cmd.Parameters.Add(new SqlParameter("@fDiemthilan1", _DiemThiEO.fDiemthilan1));
                    cmd.Parameters.Add(new SqlParameter("@fDiemthilan2", _DiemThiEO.fDiemthilan2));
                    cmd.Parameters.Add(new SqlParameter("@iTrangThai", _DiemThiEO.iTrangThai));
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

        /// <summary> 4. DiemThi_Delete </summary>
        /// <param name="_DiemThiEO"></param>
        /// <returns></returns>
        public static bool DiemThi_Delete(DiemThiEO _DiemThiEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblDiemThi_Delete", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@FK_sMaSV", _DiemThiEO.FK_sMaSV));
                    cmd.Parameters.Add(new SqlParameter("@FK_sMaMonhoc", _DiemThiEO.FK_sMaMonhoc));
                    cmd.Parameters.Add(new SqlParameter("@PK_iSolanhoc", _DiemThiEO.PK_iSolanhoc));
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

        /// <summary> 5. DiemThi_DeleteList </summary>
        /// <param name="_ListPK_sMaMonhoc"></param>
        /// <returns></returns>
        public static bool DiemThi_DeleteList(String _ListPK_lCauhoi_ID)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblDiemThi_DeleteList", conn);
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

        /// <summary> 6. DiemThi_SelectItem </summary>
        /// <param name="_DiemThiEO"></param>
        /// <returns></returns>
        public static DiemThiEO DiemThi_SelectItem(DiemThiEO _DiemThiEO)
        {
            DiemThiEO output = new DiemThiEO();
            DataSet ds = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblDiemThi_SelectItem", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@FK_sMaSV", _DiemThiEO.FK_sMaSV));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@FK_sMaMonhoc", _DiemThiEO.FK_sMaMonhoc));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_iSolanhoc", _DiemThiEO.PK_iSolanhoc));
                    ds = new DataSet();
                    da.Fill(ds);
                    conn.Close();
                    output = DataSet2Object.DiemThi(ds);
                    return output;
                }
                catch (Exception)
                {
                    conn.Close();
                    return output;
                }
            }
        }

        /// <summary> 7. DiemThi_SelectList </summary>
        /// <param name="_DiemThiEO"></param>
        /// <returns></returns>
        public static DataSet DiemThi_SelectList()
        {
            DataSet ds = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblDiemThi_SelectList", conn);
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

        /// <summary> 8. DiemThi_Search </summary>
        /// <param name="_DiemThiEO"></param>
        /// <returns></returns>
        public static DataSet DiemThi_Search(DiemThiEO _DiemThiEO)
        {
            DataSet ds = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblDiemThi_Search", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@FK_sMaSV", _DiemThiEO.FK_sMaSV));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@FK_sMaMonhoc", _DiemThiEO.FK_sMaMonhoc));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_iSolanhoc", _DiemThiEO.PK_iSolanhoc));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@fDiemchuyencan", _DiemThiEO.fDiemchuyencan));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@fDiemgiuaky", _DiemThiEO.fDiemgiuaky));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@fDiemthilan1", _DiemThiEO.fDiemthilan1));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@fDiemthilan2", _DiemThiEO.fDiemthilan2));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@iTrangThai", _DiemThiEO.iTrangThai));
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