using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using EntityObject;

namespace DataAccessObject
{
    public class OrdersDetailsDAO
    {
        // 1. Begin Insert Table Orders Details
        public static bool InsertOrdersDetails(OrdersDetailsEO _OrdersDetailsEO)
        {
            using (SqlConnection conn = Connect.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("ThangNMjsc_InsertOrdersDetails", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Orders_ID", _OrdersDetailsEO.Orders_ID));
                    cmd.Parameters.Add(new SqlParameter("@Pro_ID", _OrdersDetailsEO.Pro_ID));
                    cmd.Parameters.Add(new SqlParameter("@OrdersDetails_UnitPrice", _OrdersDetailsEO.OrdersDetails_UnitPrice));
                    cmd.Parameters.Add(new SqlParameter("@OrdersDetails_Quantity", _OrdersDetailsEO.OrdersDetails_Quantity));
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
        // End Insert Table Orders Details
    }
}
