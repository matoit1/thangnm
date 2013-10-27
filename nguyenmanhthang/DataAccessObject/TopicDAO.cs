using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntityObject;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessObject
{
    public class TopicDAO
    {
        // 1. Topic_Insert
        public static bool Topic_Insert(TopicEO _TopicEO)
        {
            using (SqlConnection conn = Connection.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Topic_Insert", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Topic_Author", _TopicEO.Topic_Author));
                    cmd.Parameters.Add(new SqlParameter("@Topic_Title", _TopicEO.Topic_Title));
                    cmd.Parameters.Add(new SqlParameter("@Topic_LinkImage", _TopicEO.Topic_LinkImage));
                    cmd.Parameters.Add(new SqlParameter("@Topic_Category", _TopicEO.Topic_Category));
                    cmd.Parameters.Add(new SqlParameter("@Topic_Parent", _TopicEO.Topic_Parent));
                    cmd.Parameters.Add(new SqlParameter("@Topic_Tag", _TopicEO.Topic_Tag));
                    cmd.Parameters.Add(new SqlParameter("@Topic_Content", _TopicEO.Topic_Content));
                    cmd.Parameters.Add(new SqlParameter("@Topic_Description", _TopicEO.Topic_Description));
                    cmd.Parameters.Add(new SqlParameter("@Topic_Visit", _TopicEO.Topic_Visit));
                    cmd.Parameters.Add(new SqlParameter("@Topic_Status", _TopicEO.Topic_Status));
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

        // 2. Topic_Update
        public static bool Topic_Update(TopicEO _TopicEO)
        {
            using (SqlConnection conn = Connection.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Topic_Update", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Topic_ID", _TopicEO.Topic_ID));
                    cmd.Parameters.Add(new SqlParameter("@Topic_Author", _TopicEO.Topic_Author));
                    cmd.Parameters.Add(new SqlParameter("@Topic_Title", _TopicEO.Topic_Title));
                    cmd.Parameters.Add(new SqlParameter("@Topic_LinkImage", _TopicEO.Topic_LinkImage));
                    cmd.Parameters.Add(new SqlParameter("@Topic_Category", _TopicEO.Topic_Category));
                    cmd.Parameters.Add(new SqlParameter("@Topic_Parent", _TopicEO.Topic_Parent));
                    cmd.Parameters.Add(new SqlParameter("@Topic_Tag", _TopicEO.Topic_Tag));
                    cmd.Parameters.Add(new SqlParameter("@Topic_Content", _TopicEO.Topic_Content));
                    cmd.Parameters.Add(new SqlParameter("@Topic_Description", _TopicEO.Topic_Description));
                    cmd.Parameters.Add(new SqlParameter("@Topic_Visit", _TopicEO.Topic_Visit));
                    cmd.Parameters.Add(new SqlParameter("@Topic_Status", _TopicEO.Topic_Status));
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

        // 3. Topic_Delete
        public static bool Topic_Delete(TopicEO _TopicEO)
        {
            using (SqlConnection conn = Connection.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Topic_Delete", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Topic_ID", _TopicEO.Topic_ID));
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

        // 4. Topic_Block
        public static bool Topic_Block(TopicEO _TopicEO)
        {
            using (SqlConnection conn = Connection.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Topic_Block", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Topic_ID", _TopicEO.Topic_ID));
                    cmd.Parameters.Add(new SqlParameter("@Topic_Status", _TopicEO.Topic_Status));
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

        // 5. Topic_SelectListbyTopic_Status
        public static DataSet Topic_SelectListbyTopic_Status(TopicEO _TopicEO)
        {
            DataSet ds = null;
            using (SqlConnection conn = Connection.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Topic_SelectListbyTopic_Status", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@Topic_Status", _TopicEO.Topic_Status));
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

        // 6. Topic_getTopicbyTopic_ID
        public static DataSet Topic_getTopicbyTopic_ID(TopicEO _TopicEO)
        {
            DataSet ds = null;
            using (SqlConnection conn = Connection.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Topic_getTopicbyTopic_ID", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@Topic_ID", _TopicEO.Topic_ID));
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

        // 7. Topic_SelectListToShow
        public static DataSet Topic_SelectListToShow(TopicEO _TopicEO, int Quantity)
        {
            DataSet ds = null;
            using (SqlConnection conn = Connection.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Topic_SelectListToShow", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@Topic_Status", _TopicEO.Topic_Status));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@Quantity", Quantity));
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

        // 8. Topic_ASC_Visit
        public static bool Topic_ASC_Visit(TopicEO _TopicEO)
        {
            using (SqlConnection conn = Connection.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Topic_ASC_Visit", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Topic_ID", _TopicEO.Topic_ID));
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
    }
}
