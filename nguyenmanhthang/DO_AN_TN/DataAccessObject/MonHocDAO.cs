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
        // 1. MonHoc_Insert
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

        // 2. MonHoc_Update
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

        // 3. MonHoc_Delete
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

        // 4. MonHoc_DeleteList
        public static bool MonHoc_DeleteList(String _ListTopic_ID)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblMonHoc_DeleteList", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ListTopic_ID", _ListTopic_ID));
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

        // 5. MonHoc_SelectItem
        public static DataSet MonHoc_SelectItem(MonHocEO _MonHocEO)
        {
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
                    return ds;
                }
                catch (Exception)
                {
                    conn.Close();
                    return ds;
                }
            }
        }

        // 6. MonHoc_SelectList
        public static DataSet MonHoc_SelectList(MonHocEO _MonHocEO)
        {
            DataSet ds = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblMonHoc_SelectList", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    //da.SelectCommand.Parameters.Add(new SqlParameter("@PK_sMaMonhoc", _MonHocEO.PK_sMaMonhoc));
                    //da.SelectCommand.Parameters.Add(new SqlParameter("@sTenMonhoc", _MonHocEO.sTenMonhoc));
                    //da.SelectCommand.Parameters.Add(new SqlParameter("@iSotrinh", _MonHocEO.iSotrinh));
                    //da.SelectCommand.Parameters.Add(new SqlParameter("@iSotietday", _MonHocEO.iSotietday));
                    //da.SelectCommand.Parameters.Add(new SqlParameter("@iTrangThai", _MonHocEO.iTrangThai));
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

        // 7. MonHoc_CheckExists
        public static DataSet MonHoc_CheckExists(MonHocEO _MonHocEO)
        {
            DataSet ds = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblMonHoc_CheckExists", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_sMaMonhoc", _MonHocEO.PK_sMaMonhoc));
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