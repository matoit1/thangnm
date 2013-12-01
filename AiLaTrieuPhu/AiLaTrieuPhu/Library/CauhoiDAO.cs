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
        //public static DataSet DanhsachCauhoi() 
        //{
        //    using (SqlConnection conn = Connection.getConnection())
        //    {
        //        try
        //        {
        //            conn.Open();
        //            SqlCommand cmd = new SqlCommand("Accounts_Insert", conn);
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.Parameters.Add(new SqlParameter("@Accounts_Username", _AccountsEO.Accounts_Username));
        //            cmd.ExecuteNonQuery();
        //            conn.Close();
        //            return true;
        //        }
        //        catch (Exception)
        //        {
        //            conn.Close();
        //            return false;
        //        }
        //    }
        //}

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
    }
}