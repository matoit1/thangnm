using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using DataAccessObject;
using EntityObject;

namespace nguyenmanhthang.Library.DataBase
{
    public class LoadAnimationDAO
    {
        public static DataSet Topic_SelectListbyTopic_Category(Int32 Quantity, Int32 Topic_Category)
        {
            DataSet ds = null;
            using (SqlConnection conn = Connection.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Topic_SelectListbyTopic_Category", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@Quantity", Quantity));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@Topic_Category", Topic_Category));
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