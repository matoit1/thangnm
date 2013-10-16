using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using EntityObject;

namespace DataAccessObject
{
    public class CommentDAO
    {
        // 1. Comment_Insert
        public static bool Comment_Insert(CommentEO _CommentEO)
        {
            using (SqlConnection conn = Connection.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Comment_Insert", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Topic_ID", _CommentEO.Topic_ID));
                    cmd.Parameters.Add(new SqlParameter("@Comment_Name", _CommentEO.Comment_Name));
                    cmd.Parameters.Add(new SqlParameter("@Comment_Email", _CommentEO.Comment_Email));
                    cmd.Parameters.Add(new SqlParameter("@Comment_Website", _CommentEO.Comment_Website));
                    cmd.Parameters.Add(new SqlParameter("@Comment_Content", _CommentEO.Comment_Content));
                    cmd.Parameters.Add(new SqlParameter("@Comment_Status", _CommentEO.Comment_Status));
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

        // 2. Comment_Update
        public static bool Comment_Update(CommentEO _CommentEO)
        {
            using (SqlConnection conn = Connection.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Comment_Update", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Comment_ID", _CommentEO.Comment_ID));
                    cmd.Parameters.Add(new SqlParameter("@Topic_ID", _CommentEO.Topic_ID));
                    cmd.Parameters.Add(new SqlParameter("@Comment_Name", _CommentEO.Comment_Name));
                    cmd.Parameters.Add(new SqlParameter("@Comment_Email", _CommentEO.Comment_Email));
                    cmd.Parameters.Add(new SqlParameter("@Comment_Website", _CommentEO.Comment_Website));
                    cmd.Parameters.Add(new SqlParameter("@Comment_Content", _CommentEO.Comment_Content));
                    cmd.Parameters.Add(new SqlParameter("@Comment_Status", _CommentEO.Comment_Status));
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

        // 3. Comment_Delete
        public static bool Comment_Delete(CommentEO _CommentEO)
        {
            using (SqlConnection conn = Connection.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Comment_Delete", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Comment_ID", _CommentEO.Comment_ID));
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

        // 4. Comment_Block
        public static bool Comment_Block(CommentEO _CommentEO)
        {
            using (SqlConnection conn = Connection.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Comment_Block", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Comment_ID", _CommentEO.Comment_ID));
                    cmd.Parameters.Add(new SqlParameter("@Comment_Status", _CommentEO.Comment_Status));
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

        // 5. Comment_SelectListbyTopic_ID
        public static DataSet Comment_SelectListbyTopic_ID(CommentEO _CommentEO)
        {
            DataSet ds = null;
            using (SqlConnection conn = Connection.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Comment_SelectListbyTopic_ID", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@Topic_ID", _CommentEO.Topic_ID));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@Comment_Status", _CommentEO.Comment_Status));
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
