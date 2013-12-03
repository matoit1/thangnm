using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace AiLaTrieuPhu.Library
{
    public class DiemDAO
    {
        // 1. Insert
        public static bool Insert(Int32 _Diem_User, Int64 _Diem_tien)
        {
            using (SqlConnection conn = Connection.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Diem_Insert", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Diem_User", _Diem_User));
                    cmd.Parameters.Add(new SqlParameter("@Diem_tien", _Diem_tien));
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

        // 2. Update
        public static bool Update(Int64 _Diem_ID, Int32 _Diem_User, Int64 _Diem_tien)
        {
            using (SqlConnection conn = Connection.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Diem_Update", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Diem_ID", _Diem_ID));
                    cmd.Parameters.Add(new SqlParameter("@Diem_User", _Diem_User));
                    cmd.Parameters.Add(new SqlParameter("@Diem_tien", _Diem_tien));
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

        // 3. Delete
        public static bool Delete(Int64 _Diem_ID)
        {
            using (SqlConnection conn = Connection.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Diem_Delete", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Diem_ID", _Diem_ID));
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

        // 4. Search
        public static DataSet Search(Int32 _Diem_User)
        {
            DataSet ds = null;
            using (SqlConnection conn = Connection.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Cauhoi_Search", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@Diem_User", _Diem_User));
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

       