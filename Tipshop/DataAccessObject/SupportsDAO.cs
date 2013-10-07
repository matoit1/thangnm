using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using EntityObject;

namespace DataAccessObject
{
    public class SupportsDAO
    {
        //// Begin Insert Table Products
        //public static bool InsertSupports(SupportsEO _SupportsEO)
        //{

        //    using (SqlConnection conn = Connect.getConnection())
        //    {
        //        try
        //        {
        //            conn.Open();
        //            SqlCommand cmd = new SqlCommand("ThangNMjsc_InsertSupports", conn);
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.Parameters.Add(new SqlParameter("@Customer_ID", _SupportsEO.Customer_ID));
        //            cmd.Parameters.Add(new SqlParameter("@Product_ID", _SupportsEO.Product_ID));
        //            cmd.Parameters.Add(new SqlParameter("@Supports_Type", _SupportsEO.Supports_Type));
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
        //// End Insert Table Products
    }
}
