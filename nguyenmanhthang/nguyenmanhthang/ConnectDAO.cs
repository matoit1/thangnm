using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace nguyenmanhthang
{
    public class ConnectDAO
    {
        private static string connStr1 = "Server=.\\SQLExpress;AttachDbFilename=|DataDirectory|D:\\N17_QLDungcuHoctap_Data.mdf;Database=N17_QLDungcuHoctap;Trusted_Connection=Yes;";
        public static SqlConnection getConnection()
        {
                return new SqlConnection(connStr1);
        }

        // 8. SelectListbyAccounts_Username
        public static DataSet SelectInfo(String _a, String _b)
        {
            DataSet ds = null;
            using (SqlConnection conn = getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("LoaiDungCu_Search", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@MaLoaiDC", _a));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@TenLoaiDC", _b));
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