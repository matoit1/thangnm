using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntityObject;
using System.Data;
using DataAccessObject;

namespace BusinessObject
{
    public class ProductsBO
    {
        //  1. Insert Group Products
        public static bool setInsertGroupProducts(Int64 Products_Parent, string Products_Name, string Products_Description)
        {
            ProductsEO _ProductsEO = new ProductsEO();
            _ProductsEO.Products_Parent = Products_Parent;
            _ProductsEO.Products_Name = Products_Name;
            _ProductsEO.Products_Description = Products_Description;
            if (ProductsDAO.InsertGroupProducts(_ProductsEO))
                return true;
            else
                return false;
        }

        //   2.  Insert Products
        public static bool setInsertProducts(Int64 Products_Group, string Products_Name, Int64 Products_Price, Int64 Products_Sale, bool Products_VAT, string Products_Description, string Products_Info, string Products_Origin, string Products_Image1, string Products_Image2, string Products_Image3, string Products_Video)
        {
            ProductsEO _ProductsEO = new ProductsEO();
            _ProductsEO.Products_Group = Products_Group;
            _ProductsEO.Products_Name = Products_Name;
            _ProductsEO.Products_Price = Products_Price;
            _ProductsEO.Products_Sale = Products_Sale;
            _ProductsEO.Products_VAT = Products_VAT;
            _ProductsEO.Products_Description = Products_Description;
            _ProductsEO.Products_Info = Products_Info;
            _ProductsEO.Products_Origin = Products_Origin;
            _ProductsEO.Products_Image1 = Products_Image1;
            _ProductsEO.Products_Image2 = Products_Image2;
            _ProductsEO.Products_Image3 = Products_Image3;
            _ProductsEO.Products_Video = Products_Video;
            if (ProductsDAO.InsertProducts(_ProductsEO))
                return true;
            else
                return false;
        }

        //   3. Update Group Products
        public static bool setUpdateGroupProducts(Int64 Products_ID, Int64 Products_Parent, string Products_Name, string Products_Description, bool Products_Visible)
        {
            ProductsEO _ProductsEO = new ProductsEO();
            _ProductsEO.Products_ID = Products_ID;
            _ProductsEO.Products_Parent = Products_Parent;
            _ProductsEO.Products_Name = Products_Name;
            _ProductsEO.Products_Description = Products_Description;
            _ProductsEO.Products_Visible = Products_Visible;
            if (ProductsDAO.UpdateGroupProducts(_ProductsEO))
                return true;
            else
                return false;
        }

        //  4. Update Products
        public static bool setUpdateProducts(Int64 Products_ID, Int64 Products_Group, string Products_Name, Int64 Products_Price, Int64 Products_Sale, bool Products_VAT, string Products_Description, string Products_Info, string Products_Origin, string Products_Image1, string Products_Image2, string Products_Image3, string Products_Video, bool Products_Visible)
        {
            ProductsEO _ProductsEO = new ProductsEO();
            _ProductsEO.Products_ID = Products_ID;
            _ProductsEO.Products_Group = Products_Group;
            _ProductsEO.Products_Name = Products_Name;
            _ProductsEO.Products_Price = Products_Price;
            _ProductsEO.Products_Sale = Products_Sale;
            _ProductsEO.Products_VAT = Products_VAT;
            _ProductsEO.Products_Description = Products_Description;
            _ProductsEO.Products_Info = Products_Info;
            _ProductsEO.Products_Origin = Products_Origin;
            _ProductsEO.Products_Image1 = Products_Image1;
            _ProductsEO.Products_Image2 = Products_Image2;
            _ProductsEO.Products_Image3 = Products_Image3;
            _ProductsEO.Products_Video = Products_Video;
            _ProductsEO.Products_Visible = Products_Visible;
            if (ProductsDAO.UpdateProducts(_ProductsEO))
                return true;
            else
                return false;
        }

        //  5. Delete Accounts by Username
        public static bool setdeleteProductsbyProducts_ID(String Products_ID)
        {
            if (ProductsDAO.deleteProductsbyProducts_ID(Products_ID))
                return true;
            else
                return false;
        }

        //  6. Get DataSet Group Products
        public static DataSet getDataSetGroupProducts(Int64 Products_Group)
        {
            DataSet ds = ProductsDAO.DataSetGroupProducts(Products_Group);
            return ds;
        }

        //  7. Get DataSet Products_Parent
        public static DataSet getDataSetGroupProducts_Parent(Int64 Products_Group)
        {
            DataSet ds = ProductsDAO.DataSetGroupProducts_Parent(Products_Group);
            return ds;
        }

        //  8. Get DataSet Products_Childrent
        public static DataSet getDataSetGroupProducts_Childrent(Int64 Products_Parent)
        {
            DataSet ds = ProductsDAO.DataSetGroupProducts_Childrent(Products_Parent);
            return ds;
        }

        // 9. Get DataSet Products
        public static DataSet getDataSetProducts(Int64 Products_Group)
        {
            DataSet ds = ProductsDAO.DataSetProducts(Products_Group);
            return ds;
        }

        //  10. Begin Get DataSet Products by Products_ID
        public static DataSet getDataSetProductsbyProducts_ID(Int64 Products_ID)
        {
            return ProductsDAO.DataSetProductsbyProducts_ID(Products_ID);
        }

        //  11. Begin Get DataSet Search Products by Name
        public static DataSet getDataSetSearchProductsbyName(string Products_Name, string Products_Description, string Products_Info, string Products_Origin)
        {
            return ProductsDAO.DataSetSearchProductsbyName(Products_Name, Products_Description, Products_Info, Products_Origin);
        }

        //  12. Get DataSet Group Products
        public static DataSet getDataSetProductbyProducts_GroupTop(Int64 Products_Group, int Top)
        {
            DataSet ds = ProductsDAO.DataSetProductbyProducts_GroupTop(Products_Group, Top);
            return ds;
        }

        //  13. Get DataSet NewProductTop
        public static DataSet getDataSetNewProductTop(int Top)
        {
            DataSet ds = ProductsDAO.DataSetNewProductTop(Top);
            return ds;
        }

        //  14. Get DataSet Group Products Show
        public static DataSet getDataSetGroupProductsShow(Int64 Products_Group)
        {
            DataSet ds = ProductsDAO.DataSetGroupProductsShow(Products_Group);
            return ds;
        }
    }
}
