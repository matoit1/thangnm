using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessObject
{
    public class CauhoiDAO
    {
        public static bool Insert(String _tencauhoi, String _daa, String _dab, String _dac, String _dad, Int32 _dadung)
        {
            using (SqlConnection conn = Connection.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Cauhoi_Insert", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@tencauhoi", _tencauhoi));
                    cmd.Parameters.Add(new SqlParameter("@daa", _daa));
                    cmd.Parameters.Add(new SqlParameter("@dab", _dab));
                    cmd.Parameters.Add(new SqlParameter("@dac", _dac));
                    cmd.Parameters.Add(new SqlParameter("@dad", _dad));
                    cmd.Parameters.Add(new SqlParameter("@dadung", _dadung));
                    
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

        public static bool CheckQuestion(Int64 Cauhoi_ID, Int32  Cauhoi_dung)
        {
            DataSet ds = null;
            Boolean kq = false;
            using (SqlConnection conn = Connection.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Cauhoi_CheckQuestion", conn);
                    da.SelectCommand.Parameters.Add(new SqlParameter("@Cauhoi_ID", Cauhoi_ID));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@Cauhoi_dung", Cauhoi_dung));
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    ds = new DataSet();
                    da.Fill(ds);
                    conn.Close();
                    if (ds.Tables[0].Rows.Count != 0)
                    {
                        kq = true;
                    }
                    else
                    {
                        kq = false;
                    }
                    return kq;
                }
                catch (Exception)
                {
                    conn.Close();
                    return kq;
                }
            }
        }

        public static DataSet SelectList_Question_by_Array_Cauhoi_ID(string mangcauhoi)
        {
            DataSet ds = null;
            using (SqlConnection conn = Connection.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Question_SelectList_Question_by_Array_Cauhoi_ID", conn);
                    da.SelectCommand.Parameters.Add(new SqlParameter("@mangcauhoi", mangcauhoi));
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

        public static int CountAllQuestion()
        {
            DataSet ds = null;
            int count = 0;
            using (SqlConnection conn = Connection.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("CountAllQuestion", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    ds = new DataSet();
                    da.Fill(ds);
                    conn.Close();
                    count = Convert.ToInt32(ds.Tables[0].Rows[0]["SumQuestion"].ToString());
                    return count;
                }
                catch (Exception)
                {
                    conn.Close();
                    return count;
                }
            }
        }

        public static DataSet LoadCauHoibyID(int _Cauhoi_ID)
        {
            DataSet ds = null;
            using (SqlConnection conn = Connection.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("LoadCauHoibyID", conn);
                    da.SelectCommand.Parameters.Add(new SqlParameter("@CauhoiID", _Cauhoi_ID));
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

        public static DataSet SelectList()
        {
            DataSet ds = null;
            using (SqlConnection conn = Connection.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Question_SelectList", conn);
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
    }
}
