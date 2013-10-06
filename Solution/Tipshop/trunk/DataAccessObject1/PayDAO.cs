using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using EntityObject;

namespace DataAccessObject
{
    public class PayDAO
    {
        // 1. Begin Insert Table Pay
        public static bool InsertPay(PayEO _PayEO)
        {
            using (SqlConnection conn = Connect.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("ThangNMjsc_InsertPay", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Pay_Name", _PayEO.Pay_Name));
                    cmd.Parameters.Add(new SqlParameter("@Pay_Visible", _PayEO.Pay_Visible));
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
        // End Insert Table Pay

        // 2. Begin Update Table Pay
        public static bool UpdatePay(PayEO _PayEO)
        {
            using (SqlConnection conn = Connect.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("ThangNMjsc_UpdatePay", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Pay_ID", _PayEO.Pay_ID));
                    cmd.Parameters.Add(new SqlParameter("@Pay_Name", _PayEO.Pay_Name));
                    cmd.Parameters.Add(new SqlParameter("@Pay_Visible", _PayEO.Pay_Visible));
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
        // End Update Table Pay

        // 3. Begin Delete Table Pay
        public static bool deletePay(String Pay_ID)
        {
            using (SqlConnection conn = Connect.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("ThangNMjsc_DeletePay", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Pay_ID", Pay_ID));
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
        // End Delete Table Pay

        //Begin Dataset Pay by Pay_Visible
        public static DataSet DataSetPaybyPay_Visible(bool Pay_Visible)
        {
            DataSet ds = null;
            using (SqlConnection conn = Connect.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("ThangNMjsc_getDataSetPaybyPay_Visible", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@Pay_Visible", Pay_Visible));
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
        //End Dataset Pay by Pay_Visible

        //Begin Dataset Pay by Pay_ID
        public static DataSet DataSetPaybyPay_ID(int Pay_ID)
        {
            DataSet ds = null;
            using (SqlConnection conn = Connect.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("ThangNMjsc_getDataSetPaybyPay_ID", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@Pay_ID", Pay_ID));
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
        //End Dataset Pay by Pay_ID

        //Begin Get Dataset Pay
        public static DataSet DataSetPay()
        {
            DataSet ds = null;
            using (SqlConnection conn = Connect.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("ThangNMjsc_getDataSetPay", conn);
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
        //End Get Dataset Pay
    }
}
