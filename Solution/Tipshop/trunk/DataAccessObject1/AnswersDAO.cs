using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using EntityObject;

namespace DataAccessObject
{
    public class AnswersDAO
    {
        // Begin Insert Table Answers
        public static bool InsertAnswers(SupportsEO _SupportsEO, AnswersEO _AnswersEO)
        {
            using (SqlConnection conn = Connect.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("ThangNMjsc_SendSupports", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Customer_ID", _SupportsEO.Customer_ID));
                    cmd.Parameters.Add(new SqlParameter("@Product_ID", _SupportsEO.Product_ID));
                    cmd.Parameters.Add(new SqlParameter("@Supports_Type", _SupportsEO.Supports_Type));
                    cmd.Parameters.Add(new SqlParameter("@Answers_Content", _AnswersEO.Answers_Content));
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
        // End Insert Table Answers




        // Begin Update Table Answers
        public static bool ReplySupports(AnswersEO _AnswersEO)
        {
            using (SqlConnection conn = Connect.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("ThangNMjsc_ReplySupports", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Answers_ID", _AnswersEO.Answers_ID));
                    cmd.Parameters.Add(new SqlParameter("@Support_ID", _AnswersEO.Support_ID));
                    cmd.Parameters.Add(new SqlParameter("@Staff_ID", _AnswersEO.Staff_ID));
                    cmd.Parameters.Add(new SqlParameter("@Answers_Question", _AnswersEO.Answers_Question));
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
        // End Update Table Answers


        // Begin Forward Table Answers
        public static bool ForwardSupports(AnswersEO _AnswersEO)
        {
            using (SqlConnection conn = Connect.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("ThangNMjsc_ForwardSupports", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Support_ID", _AnswersEO.Support_ID));
                    cmd.Parameters.Add(new SqlParameter("@Answers_Content", _AnswersEO.Answers_Content));
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
        // End Forward Table Answers


        // Begin Delete Table Answers by Answers_ID
        public static bool deleteSupportbySupports_ID(String SupportID)
        {
            using (SqlConnection conn = Connect.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("ThangNMjsc_DeleteSupports", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Supports_ID", SupportID));
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
        // End Delete Table Answers by Answers_ID




        //Begin Dataset New Supports
        public static DataSet DataSetNewSupports(bool Supports_Status)
        {
            DataSet ds = null;
            using (SqlConnection conn = Connect.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("ThangNMjsc_getDataSetNewSupports", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@Supports_Status", Supports_Status));
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
        //End Dataset New Supports




        //Begin DataSet Supports by Supports_ID And Answers_ID
        public static DataSet DataSetSupportsbySupports_ID(Int64 Supports_ID)
        {
            DataSet ds = null;
            using (SqlConnection conn = Connect.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("ThangNMjsc_getDataSetSupportsbySupports_ID", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@Supports_ID", Supports_ID));
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
        //End DataSet Supports by Supports_ID And Answers_ID


        ////Begin DataSet Supports by Customer_ID And Supports_Status
        //public static DataSet DataSetSupportsbyCustomer_IDandSupports_Status(int Customer_ID, bool Supports_Status)
        //{
        //    DataSet ds = null;
        //    using (SqlConnection conn = Connect.getConnection())
        //    {
        //        try
        //        {
        //            conn.Open();
        //            SqlDataAdapter da = new SqlDataAdapter("ThangNMjsc_getDataSetSupportsbyCustomer_IDandSupports_Status", conn);
        //            da.SelectCommand.CommandType = CommandType.StoredProcedure;
        //            da.SelectCommand.Parameters.Add(new SqlParameter("@Customer_ID", Customer_ID));
        //            da.SelectCommand.Parameters.Add(new SqlParameter("@Supports_Status", Supports_Status));
        //            ds = new DataSet();
        //            da.Fill(ds);
        //            conn.Close();
        //            return ds;
        //        }
        //        catch (Exception)
        //        {
        //            conn.Close();
        //            return ds;
        //        }
        //    }
        //}
        ////End DataSet Supports by Customer_ID And Supports_Status



        //Begin DataSet Search Supports by Supports_Type
        public static DataSet DataSetSearchAccountsbySupports_Type(bool Supports_Status, string Supports_Type, string Accounts_Username, string Products_Name, DateTime Answers_DateTimeA1, DateTime Answers_DateTimeA2)
        {
            DataSet ds = null;
            using (SqlConnection conn = Connect.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("ThangNMjsc_SearchAnswersbySupports_Type", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@Supports_Status", Supports_Status));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@Supports_Type", Supports_Type));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@Accounts_Username", Accounts_Username));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@Products_Name", Products_Name));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@Answers_DateTimeA1", Answers_DateTimeA1));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@Answers_DateTimeA2", Answers_DateTimeA2)); 
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
        //Begin DataSet Search Supports by Supports_Type



        //Begin DataSet Search Supports by Supports_Type And DateTime
        public static DataSet DataSetSearchAccountsbySupports_TypeAndDateTime(string Supports_Type, DateTime Answers_DateTimeBegin, DateTime Answers_DateTimeEnd)
        {
            DataSet ds = null;
            using (SqlConnection conn = Connect.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("ThangNMjsc_SearchAnswersbySupports_TypeAndDateTime", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@Supports_Type", DBNull .Value ));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@Answers_DateTimeBegin", Answers_DateTimeBegin));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@Answers_DateTimeEnd", Answers_DateTimeEnd));
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
        //Begin DataSet Search Supports by Supports_Type


        //Begin DataSet Supports by Customer_ID
        public static DataSet DataSetSupportsbyCustomer_IDandSupports_Status(int Customer_ID, bool Supports_Status)
        {
            DataSet ds = null;
            using (SqlConnection conn = Connect.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("ThangNMjsc_getDataSetSupportsbyCustomer_IDandSupports_Status", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@Customer_ID", Customer_ID));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@Supports_Status", Supports_Status));
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
        //Begin DataSet Supports by Customer_ID
    }
}
