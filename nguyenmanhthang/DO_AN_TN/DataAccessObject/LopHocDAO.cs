using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using EntityObject;

namespace DataAccessObject
{
    public class LopHocDAO
    {
        /// <summary> 1. LopHoc_CheckExists </summary>
        /// <param name="_LopHocEO"></param>
        /// <returns></returns>
        public static bool LopHoc_CheckExists(LopHocEO _LopHocEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblLopHoc_CheckExists", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_sMalop", _LopHocEO.PK_sMalop));
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

        /// <summary> 2. LopHoc_Insert </summary>
        /// <param name="_LopHocEO"></param>
        /// <returns></returns>
        public static bool LopHoc_Insert(LopHocEO _LopHocEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblLopHoc_Insert", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_sMalop", _LopHocEO.PK_sMalop));
                    cmd.Parameters.Add(new SqlParameter("@sTenlop", _LopHocEO.sTenlop));
                    cmd.Parameters.Add(new SqlParameter("@iNamvaotruong", _LopHocEO.iNamvaotruong));
                    cmd.Parameters.Add(new SqlParameter("@iSiso", _LopHocEO.iSiso));
                    cmd.Parameters.Add(new SqlParameter("@iSoNamDaoTao", _LopHocEO.iSoNamDaoTao));
                    cmd.Parameters.Add(new SqlParameter("@iTrangThai", _LopHocEO.iTrangThai));
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

        /// <summary> 3. LopHoc_Update </summary>
        /// <param name="_LopHocEO"></param>
        /// <returns></returns>
        public static bool LopHoc_Update(LopHocEO _LopHocEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblLopHoc_Update", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_sMalop", _LopHocEO.PK_sMalop));
                    cmd.Parameters.Add(new SqlParameter("@sTenlop", _LopHocEO.sTenlop));
                    cmd.Parameters.Add(new SqlParameter("@iNamvaotruong", _LopHocEO.iNamvaotruong));
                    cmd.Parameters.Add(new SqlParameter("@iSiso", _LopHocEO.iSiso));
                    cmd.Parameters.Add(new SqlParameter("@iSoNamDaoTao", _LopHocEO.iSoNamDaoTao));
                    cmd.Parameters.Add(new SqlParameter("@iTrangThai", _LopHocEO.iTrangThai));
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

        /// <summary> 4. LopHoc_Delete </summary>
        /// <param name="_LopHocEO"></param>
        /// <returns></returns>
        public static bool LopHoc_Delete(LopHocEO _LopHocEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblLopHoc_Delete", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_sMalop", _LopHocEO.PK_sMalop));
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

        /// <summary> 5. LopHoc_DeleteList </summary>
        /// <param name="_ListPK_sMaMonhoc"></param>
        /// <returns></returns>
        public static bool LopHoc_DeleteList(String _ListPK_sMalop)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblLopHoc_DeleteList", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ListPK_sMalop", _ListPK_sMalop));
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

        /// <summary> 6. LopHoc_SelectItem </summary>
        /// <param name="_LopHocEO"></param>
        /// <returns></returns>
        public static LopHocEO LopHoc_SelectItem(LopHocEO _LopHocEO)
        {
            LopHocEO output = new LopHocEO();
            DataSet ds = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblLopHoc_SelectItem", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_sMalop", _LopHocEO.PK_sMalop));
                    ds = new DataSet();
                    da.Fill(ds);
                    conn.Close();
                    output = DataSet2Object.LopHoc(ds);
                    return output;
                }
                catch (Exception)
                {
                    conn.Close();
                    return output;
                }
            }
        }

        /// <summary> 7. LopHoc_SelectList </summary>
        /// <param name="_LopHocEO"></param>
        /// <returns></returns>
        public static DataSet LopHoc_SelectList()
        {
            DataSet ds = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblLopHoc_SelectList", conn);
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

        /// <summary> 8. LopHoc_Search </summary>
        /// <param name="_LopHocEO"></param>
        /// <returns></returns>
        public static DataSet LopHoc_Search(LopHocEO _LopHocEO)
        {
            DataSet ds = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblLopHoc_Search", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_sMalop", _LopHocEO.PK_sMalop));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sTenlop", _LopHocEO.sTenlop));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@iNamvaotruong", _LopHocEO.iNamvaotruong));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@iSiso", _LopHocEO.iSiso));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@iSoNamDaoTao", _LopHocEO.iSoNamDaoTao));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@iTrangThai", _LopHocEO.iTrangThai));
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