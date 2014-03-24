using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using EntityObject;

namespace DataAccessObject
{
    public class MonHocDAO
    {
        /// <summary> 1. MonHoc_CheckExists </summary>
        /// <param name="_MonHocEO"></param>
        /// <returns></returns>
        public static bool MonHoc_CheckExists(MonHocEO _MonHocEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblMonHoc_CheckExists", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_sMaMonhoc", _MonHocEO.PK_sMaMonhoc));
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

        /// <summary> 2. MonHoc_Insert </summary>
        /// <param name="_MonHocEO"></param>
        /// <returns></returns>
        public static bool MonHoc_Insert(MonHocEO _MonHocEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblMonHoc_Insert", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_sMaMonhoc", _MonHocEO.PK_sMaMonhoc));
                    cmd.Parameters.Add(new SqlParameter("@sTenMonhoc", _MonHocEO.sTenMonhoc));
                    cmd.Parameters.Add(new SqlParameter("@iSotrinh", _MonHocEO.iSotrinh));
                    cmd.Parameters.Add(new SqlParameter("@iSotietday", _MonHocEO.iSotietday));
                    cmd.Parameters.Add(new SqlParameter("@iTrangThai", _MonHocEO.iTrangThai));
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
        /// <param name="_MonHocEO"></param>
        /// <returns></returns>
        public static bool MonHoc_Update(MonHocEO _MonHocEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblMonHoc_Update", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_sMaMonhoc", _MonHocEO.PK_sMaMonhoc));
                    cmd.Parameters.Add(new SqlParameter("@sTenMonhoc", _MonHocEO.sTenMonhoc));
                    cmd.Parameters.Add(new SqlParameter("@iSotrinh", _MonHocEO.iSotrinh));
                    cmd.Parameters.Add(new SqlParameter("@iSotietday", _MonHocEO.iSotietday));
                    cmd.Parameters.Add(new SqlParameter("@iTrangThai", _MonHocEO.iTrangThai));
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
        /// <param name="_MonHocEO"></param>
        /// <returns></returns>
        public static bool MonHoc_Delete(MonHocEO _MonHocEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblMonHoc_Delete", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_sMaMonhoc", _MonHocEO.PK_sMaMonhoc));
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

        /// <summary> 5. MonHoc_DeleteList </summary>
        /// <param name="_ListPK_sMaMonhoc"></param>
        /// <returns></returns>
        public static bool MonHoc_DeleteList(String _ListPK_sMaMonhoc)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblMonHoc_DeleteList", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ListPK_sMaMonhoc", _ListPK_sMaMonhoc));
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

        /// <summary> 6. MonHoc_SelectItem </summary>
        /// <param name="_MonHocEO"></param>
        /// <returns></returns>
        public static MonHocEO MonHoc_SelectItem(MonHocEO _MonHocEO)
        {
            MonHocEO output = new MonHocEO();
            DataSet ds = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblMonHoc_SelectItem", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_sMaMonhoc", _MonHocEO.PK_sMaMonhoc));
                    ds = new DataSet();
                    da.Fill(ds);
                    conn.Close();
                    output = DataSet2Object.MonHoc(ds);
                    return output;
                }
                catch (Exception)
                {
                    conn.Close();
                    return output;
                }
            }
        }

        /// <summary> 7. MonHoc_SelectList </summary>
        /// <param name="_MonHocEO"></param>
        /// <returns></returns>
        public static DataSet MonHoc_SelectList()
        {
            DataSet ds = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblMonHoc_SelectList", conn);
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

        /// <summary> 8. MonHoc_Search </summary>
        /// <param name="_MonHocEO"></param>
        /// <returns></returns>
        public static DataSet MonHoc_Search(MonHocEO _MonHocEO)
        {
            DataSet ds = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblMonHoc_Search", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_sMaMonhoc", _MonHocEO.PK_sMaMonhoc));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sTenMonhoc", _MonHocEO.sTenMonhoc));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@iSotrinh", _MonHocEO.iSotrinh));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@iSotietday", _MonHocEO.iSotietday));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@iTrangThai", _MonHocEO.iTrangThai));
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