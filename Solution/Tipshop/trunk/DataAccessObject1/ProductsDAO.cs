using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using EntityObject;

namespace DataAccessObject
{
    public class ProductsDAO
    {
        //  1. Begin Insert Table Group Products
        public static bool InsertGroupProducts(ProductsEO _ProductsEO)
        {

            using (SqlConnection conn = Connect.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("ThangNMjsc_InsertGroupProducts", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Products_Parent", _ProductsEO.Products_Parent));
                    cmd.Parameters.Add(new SqlParameter("@Products_Name", _ProductsEO.Products_Name));
                    cmd.Parameters.Add(new SqlParameter("@Products_Description", _ProductsEO.Products_Description));
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

        //  2. Begin Insert Table Products
        public static bool InsertProducts(ProductsEO _ProductsEO)
        {

            using (SqlConnection conn = Connect.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("ThangNMjsc_InsertProducts", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Products_Group", _ProductsEO.Products_Group));
                    cmd.Parameters.Add(new SqlParameter("@Products_Name", _ProductsEO.Products_Name));
                    cmd.Parameters.Add(new SqlParameter("@Products_Price", _ProductsEO.Products_Price));
                    cmd.Parameters.Add(new SqlParameter("@Products_Sale", _ProductsEO.Products_Sale));
                    cmd.Parameters.Add(new SqlParameter("@Products_VAT", _ProductsEO.Products_VAT));
                    cmd.Parameters.Add(new SqlParameter("@Products_Description", _ProductsEO.Products_Description));
                    cmd.Parameters.Add(new SqlParameter("@Products_Info", _ProductsEO.Products_Info));
                    cmd.Parameters.Add(new SqlParameter("@Products_Origin", _ProductsEO.Products_Info));
                    cmd.Parameters.Add(new SqlParameter("@Products_Image1", _ProductsEO.Products_Image1));
                    cmd.Parameters.Add(new SqlParameter("@Products_Image2", _ProductsEO.Products_Image2));
                    cmd.Parameters.Add(new SqlParameter("@Products_Image3", _ProductsEO.Products_Image3));
                    cmd.Parameters.Add(new SqlParameter("@Products_Video", _ProductsEO.Products_Video));
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

        //  3. Begin Update Table Group Products
        public static bool UpdateGroupProducts(ProductsEO _ProductsEO)
        {
            using (SqlConnection conn = Connect.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("ThangNMjsc_UpdateGroupProducts", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Products_ID", _ProductsEO.Products_ID));
                    cmd.Parameters.Add(new SqlParameter("@Products_Parent", _ProductsEO.Products_Parent));
                    cmd.Parameters.Add(new SqlParameter("@Products_Name", _ProductsEO.Products_Name));
                    cmd.Parameters.Add(new SqlParameter("@Products_Description", _ProductsEO.Products_Description));
                    cmd.Parameters.Add(new SqlParameter("@Products_Visible", _ProductsEO.Products_Visible));
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

        // 4. Begin Update Table Products
        public static bool UpdateProducts(ProductsEO _ProductsEO)
        {
            using (SqlConnection conn = Connect.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("ThangNMjsc_UpdateProducts", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Products_ID", _ProductsEO.Products_ID));
                    cmd.Parameters.Add(new SqlParameter("@Products_Group", _ProductsEO.Products_Group));
                    cmd.Parameters.Add(new SqlParameter("@Products_Name", _ProductsEO.Products_Name));
                    cmd.Parameters.Add(new SqlParameter("@Products_Price", _ProductsEO.Products_Price));
                    cmd.Parameters.Add(new SqlParameter("@Products_Sale", _ProductsEO.Products_Sale));
                    cmd.Parameters.Add(new SqlParameter("@Products_VAT", _ProductsEO.Products_VAT));
                    cmd.Parameters.Add(new SqlParameter("@Products_Description", _ProductsEO.Products_Description));
                    cmd.Parameters.Add(new SqlParameter("@Products_Info", _ProductsEO.Products_Info));
                    cmd.Parameters.Add(new SqlParameter("@Products_Origin", _ProductsEO.Products_Origin));
                    cmd.Parameters.Add(new SqlParameter("@Products_Image1", _ProductsEO.Products_Image1));
                    cmd.Parameters.Add(new SqlParameter("@Products_Image2", _ProductsEO.Products_Image2));
                    cmd.Parameters.Add(new SqlParameter("@Products_Image3", _ProductsEO.Products_Image3));
                    cmd.Parameters.Add(new SqlParameter("@Products_Video", _ProductsEO.Products_Video));
                    cmd.Parameters.Add(new SqlParameter("@Products_Visible", _ProductsEO.Products_Visible));
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

        //  5. Begin Delete Table Group Products
        public static bool deleteProductsbyProducts_ID(String Products_ID)
        {
            using (SqlConnection conn = Connect.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("ThangNMjsc_DeleteProductsbyProducts_ID", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Products_ID", Products_ID));
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

        //  6. Begin Dataset Group Products
        public static DataSet DataSetGroupProducts(Int64 Products_Group)
        {
            DataSet ds = null;
            using (SqlConnection conn = Connect.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("ThangNMjsc_getDataSetGroupProducts", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@Products_Group", Products_Group));
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

        //  7. Begin Dataset Group Products_Parent
        public static DataSet DataSetGroupProducts_Parent(Int64 Products_Group)
        {
            DataSet ds = null;
            using (SqlConnection conn = Connect.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("ThangNMjsc_getGroupProducts_Parent", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@Products_Group", Products_Group));
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

        //  8. Begin Dataset Group Products_Childrent
        public static DataSet DataSetGroupProducts_Childrent(Int64 Products_Parent)
        {
            DataSet ds = null;
            using (SqlConnection conn = Connect.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("ThangNMjsc_getGroupProducts_Childrent", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@Products_Parent", Products_Parent));
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

        // 9. Begin Dataset Products
        public static DataSet DataSetProducts(Int64 Products_Group)
        {
            DataSet ds = null;
            using (SqlConnection conn = Connect.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("ThangNMjsc_getDataSetProducts", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@Products_Group", Products_Group));
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

        //  10. Begin get Data Set Products by Products_ID
        public static DataSet DataSetProductsbyProducts_ID(Int64 Products_ID)
        {
            DataSet ds = null;
            using (SqlConnection conn = Connect.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("ThangNMjsc_getDataSetProductsbyProducts_ID", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@Products_ID", Products_ID));
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

        //  11. Begin get Data Set Search Products by Name
        public static DataSet DataSetSearchProductsbyName(string Products_Name, string Products_Description, string Products_Info, string Products_Origin)
        {
            DataSet ds = null;
            using (SqlConnection conn = Connect.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("ThangNMjsc_SearchProductsbyName", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@Products_Name", Products_Name));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@Products_Description", Products_Description));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@Products_Info", Products_Info));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@Products_Origin", Products_Origin));
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

        //  12. Begin Dataset ProductbyProducts_GroupTop
        public static DataSet DataSetProductbyProducts_GroupTop(Int64 Products_Group, int Top)
        {
            DataSet ds = null;
            using (SqlConnection conn = Connect.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("ThangNMjsc_getProductbyProducts_GroupTop", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@Products_Group", Products_Group));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@Top", Top));
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

        //  13. Begin Dataset NewProductTop
        public static DataSet DataSetNewProductTop(int Top)
        {
            DataSet ds = null;
            using (SqlConnection conn = Connect.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("ThangNMjsc_getNewProductTop", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@Top", Top));
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

        //  14. Begin Dataset Group Products Show
        public static DataSet DataSetGroupProductsShow(Int64 Products_Group)
        {
            DataSet ds = null;
            using (SqlConnection conn = Connect.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("ThangNMjsc_getDataSetGroupProductsShow", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@Products_Group", Products_Group));
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