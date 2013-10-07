using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using EntityObject;

namespace DataAccessObject
{
    public class OrdersDAO
    {
        // 1. Begin Insert Table Orders
        public static OrdersEO InsertOrders(int _Client_ID, int _Pay_ID, string _Pay_Email, string _Pay_FullName, string _Pay_Address, string _Pay_PhoneNumber, string _Pay_Note, DateTime _Pay_DateOfStart, DateTime _Pay_DateOfFinish)
        {
            OrdersEO _NewID = null;
            using (SqlConnection conn = Connect.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("ThangNMjsc_InsertOrders", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Client_ID", _Client_ID));
                    cmd.Parameters.Add(new SqlParameter("@Pay_ID", _Pay_ID));
                    cmd.Parameters.Add(new SqlParameter("@Pay_Email", _Pay_Email));
                    cmd.Parameters.Add(new SqlParameter("@Pay_FullName", _Pay_FullName));
                    cmd.Parameters.Add(new SqlParameter("@Pay_Address", _Pay_Address));
                    cmd.Parameters.Add(new SqlParameter("@Pay_PhoneNumber", _Pay_PhoneNumber));
                    cmd.Parameters.Add(new SqlParameter("@Pay_Note", _Pay_Note));
                    cmd.Parameters.Add(new SqlParameter("@Pay_DateOfStart", _Pay_DateOfStart));
                    cmd.Parameters.Add(new SqlParameter("@Pay_DateOfFinish", _Pay_DateOfFinish));
                    SqlDataReader dr = cmd.ExecuteReader();
                    _NewID = new OrdersEO();
                    while (dr.Read())
                    {
                        _NewID.Orders_ID = Convert.ToInt64(dr["Orders_ID"]);
                    }
                    conn.Close();
                    return _NewID;
                }
                catch (Exception)
                {
                    conn.Close();
                    return _NewID;
                }
            }
        }
        // End Insert Table Orders

        // 2. Begin Update Table Orders
        public static bool UpdateOrders(String Orders_ID, bool Pay_Status)
        {
            using (SqlConnection conn = Connect.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("ThangNMjsc_UpdateOrders", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Orders_ID", Orders_ID));
                    cmd.Parameters.Add(new SqlParameter("@Pay_Status", Pay_Status));
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
        // End Update Table Orders

        // 3. Begin Delete Table Orders
        public static bool DeleteOrders(String Orders_ID)
        {
            using (SqlConnection conn = Connect.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("ThangNMjsc_DeleteOrders", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Orders_ID", Orders_ID));
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
        // End Delete Table Orders

        // Begin Select Orders
        public static DataSet DataSetOrders(bool Pay_Status)
        {
            DataSet ds = null;
            using (SqlConnection conn = Connect.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("ThangNMjsc_getDataSetOrders", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@Pay_Status", Pay_Status));

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
        // End Select Orders

        // Begin Select Orders byClient_ID
        public static DataSet DataSetOrdersbyClient_ID(bool Pay_Status, string Accounts_Username)
        {
            DataSet ds = null;
            using (SqlConnection conn = Connect.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("ThangNMjsc_getDataSetOrdersbyClient_ID", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@Pay_Status", Pay_Status));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@Accounts_Username", Accounts_Username));
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
        // End Select Orders byClient_ID

        // Begin Select Orders byOrders_ID
        public static DataSet DataSetOrdersbyOrders_ID(Int64 Orders_ID)
        {
            DataSet ds = null;
            using (SqlConnection conn = Connect.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("ThangNMjsc_getDataSetOrdersbyOrders_ID", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@Orders_ID", Orders_ID));
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
        // End Select Orders byOrders_ID

        // Begin Select ThangNMjsc_getSumQuantitybyOrders_ID
        public static OrdersEO SumQuantitybyOrders_ID(Int64 Orders_ID)
        {
            OrdersEO _SumQuantity = null;
            using (SqlConnection conn = Connect.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("ThangNMjsc_getSumQuantitybyOrders_ID", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Orders_ID", Orders_ID));
                    SqlDataReader dr = cmd.ExecuteReader();
                    _SumQuantity = new OrdersEO();
                    while (dr.Read())
                    {
                        _SumQuantity.Pay_ID = Convert.ToInt32(dr["SumQuantity"]);
                    }
                    conn.Close();
                    return _SumQuantity;
                }
                catch (Exception)
                {
                    conn.Close();
                    return _SumQuantity;
                }
            }
        }
        // End Select ThangNMjsc_getSumQuantitybyOrders_ID
    }
}
