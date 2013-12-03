using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace AiLaTrieuPhu.Library
{
    public class TaikhoanDAO
    {
        // 1. Insert
        public static bool Insert(String _taikhoan_tentaikhoan, String _taikhoan_matkhau, String _taikhoan_Email, String _taikhoan_tendaydu, String _taikhoan_diachi, DateTime _taikhoan_ngaysinh, String _taikhoan_sodienthoai, Int32 _taikhoan_quyenhan, String _taikhoan_annhdaidien,  Boolean _taikhoan_trangthai)
        {
            using (SqlConnection conn = Connection.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Taikhoan_Insert", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@taikhoan_tentaikhoan", _taikhoan_tentaikhoan));
                    cmd.Parameters.Add(new SqlParameter("@taikhoan_matkhau", _taikhoan_matkhau));
                    cmd.Parameters.Add(new SqlParameter("@taikhoan_Email", _taikhoan_Email));
                    cmd.Parameters.Add(new SqlParameter("@taikhoan_tendaydu", _taikhoan_tendaydu ));
                    cmd.Parameters.Add(new SqlParameter("@taikhoan_diachi", _taikhoan_diachi));
                    cmd.Parameters.Add(new SqlParameter("@taikhoan_ngaysinh", _taikhoan_ngaysinh));
                    cmd.Parameters.Add(new SqlParameter("@taikhoan_sodienthoai", _taikhoan_sodienthoai));
                    cmd.Parameters.Add(new SqlParameter("@taikhoan_quyenhan", _taikhoan_quyenhan));
                    cmd.Parameters.Add(new SqlParameter("@taikhoan_annhdaidien", _taikhoan_annhdaidien));
                    cmd.Parameters.Add(new SqlParameter("@taikhoan_trangthai", _taikhoan_trangthai));
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
        public static bool Update(Int64 _taikhoan_ID, String _taikhoan_tentaikhoan, String _taikhoan_matkhau, String _taikhoan_Email, String _taikhoan_tendaydu, String _taikhoan_diachi, DateTime _taikhoan_ngaysinh, String _taikhoan_sodienthoai, Int32 _taikhoan_quyenhan, String _taikhoan_annhdaidien,  Boolean _taikhoan_trangthai)
        {
            using (SqlConnection conn = Connection.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Taikhoan_Update", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@taikhoan_ID", _taikhoan_ID));
                    cmd.Parameters.Add(new SqlParameter("@taikhoan_tentaikhoan", _taikhoan_tentaikhoan));
                    cmd.Parameters.Add(new SqlParameter("@taikhoan_matkhau", _taikhoan_matkhau));
                    cmd.Parameters.Add(new SqlParameter("@taikhoan_Email", _taikhoan_Email));
                    cmd.Parameters.Add(new SqlParameter("@taikhoan_tendaydu", _taikhoan_tendaydu ));
                    cmd.Parameters.Add(new SqlParameter("@taikhoan_diachi", _taikhoan_diachi));
                    cmd.Parameters.Add(new SqlParameter("@taikhoan_ngaysinh", _taikhoan_ngaysinh));
                    cmd.Parameters.Add(new SqlParameter("@taikhoan_sodienthoai", _taikhoan_sodienthoai));
                    cmd.Parameters.Add(new SqlParameter("@taikhoan_quyenhan", _taikhoan_quyenhan));
                    cmd.Parameters.Add(new SqlParameter("@taikhoan_annhdaidien", _taikhoan_annhdaidien));
                    cmd.Parameters.Add(new SqlParameter("@taikhoan_trangthai", _taikhoan_trangthai));
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
        public static bool Delete(Int64 _taikhoan_ID)
        {
            using (SqlConnection conn = Connection.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Taikhoan_Delete", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Taikhoan_ID", _taikhoan_ID));
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
        public static DataSet Search( String _taikhoan_tentaikhoan)
        {
            DataSet ds = null;
            using (SqlConnection conn = Connection.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Taikhoan_Search", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@taikhoan_tentaikhoan", _taikhoan_tentaikhoan));
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

        public static DataSet DangNhap(String _taikhoan_tentaikhoan, String _taikhoan_matkhau)
        {
            DataSet ds = null;
            using (SqlConnection conn = Connection.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("TaikhoanLogin", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@taikhoan_tentaikhoan", _taikhoan_tentaikhoan));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@taikhoan_matkhau", _taikhoan_matkhau));
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