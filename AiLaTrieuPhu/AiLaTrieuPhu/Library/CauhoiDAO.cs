using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace AiLaTrieuPhu.Library
{
    public class CauhoiDAO
    {
        // 1. Insert
        public static bool Insert( String _Cauhoi_cauhoi, String _Cauhoi_A, String _Cauhoi_B, String _Cauhoi_C, String _Cauhoi_D, Int32 _Cauhoi_dung, Int32 _Cauhoi_capdo)
        {
            using (SqlConnection conn = Connection.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Cauhoi_Insert", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Cauhoi_cauhoi", _Cauhoi_cauhoi));
                    cmd.Parameters.Add(new SqlParameter("@Cauhoi_A", _Cauhoi_A));
                    cmd.Parameters.Add(new SqlParameter("@Cauhoi_B", _Cauhoi_B));
                    cmd.Parameters.Add(new SqlParameter("@Cauhoi_C", _Cauhoi_C));
                    cmd.Parameters.Add(new SqlParameter("@Cauhoi_D", _Cauhoi_D));
                    cmd.Parameters.Add(new SqlParameter("@Cauhoi_dung", _Cauhoi_dung));
                    cmd.Parameters.Add(new SqlParameter("@Cauhoi_capdo", _Cauhoi_capdo));
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

        // 1. Update
        public static bool Update(Int64 _Cauhoi_ID, String _Cauhoi_cauhoi, String _Cauhoi_A, String _Cauhoi_B, String _Cauhoi_C, String _Cauhoi_D, Int32 _Cauhoi_dung, Int32 _Cauhoi_capdo)
        {
            using (SqlConnection conn = Connection.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Cauhoi_Update", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Cauhoi_ID", _Cauhoi_ID));
                    cmd.Parameters.Add(new SqlParameter("@Cauhoi_cauhoi", _Cauhoi_cauhoi));
                    cmd.Parameters.Add(new SqlParameter("@Cauhoi_A", _Cauhoi_A));
                    cmd.Parameters.Add(new SqlParameter("@Cauhoi_B", _Cauhoi_B));
                    cmd.Parameters.Add(new SqlParameter("@Cauhoi_C", _Cauhoi_C));
                    cmd.Parameters.Add(new SqlParameter("@Cauhoi_D", _Cauhoi_D));
                    cmd.Parameters.Add(new SqlParameter("@Cauhoi_dung", _Cauhoi_dung));
                    cmd.Parameters.Add(new SqlParameter("@Cauhoi_capdo", _Cauhoi_capdo));
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

        // 1. Delete
        public static bool Delete(Int64 _Cauhoi_ID)
        {
            using (SqlConnection conn = Connection.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Cauhoi_Delete", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Cauhoi_ID", _Cauhoi_ID));
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

        // 6. Search
        public static DataSet Search(Int64 _Cauhoi_ID, String _Cauhoi_cauhoi)
        {
            DataSet ds = null;
            using (SqlConnection conn = Connection.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Cauhoi_Search", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@Cauhoi_ID", _Cauhoi_ID));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@Cauhoi_cauhoi", _Cauhoi_cauhoi));
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
    


        // 6. CheckAccounts_Username
        public static DataSet DanhsachCauhoi(int _Capdo)
        {
            DataSet ds = null;
            using (SqlConnection conn = Connection.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Cauhoi_DanhsachCauhoi", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@Cauhoi_capdo", _Capdo));
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


        // 6. Lay Cau hoi theo ma
        public static DataSet LoadCauHoiTheoID(Int64 _Cauhoi_ID)
        {
            DataSet ds = null;
            using (SqlConnection conn = Connection.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("LoadCauHoiTheoID", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@Cauhoi_ID", _Cauhoi_ID));
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