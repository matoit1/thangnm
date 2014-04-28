using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Globalization;
using SharedLibraries;
using EntityObject;

namespace DataAccessObject
{
    public class DataSet2Object
    {
        public static AccountsEO Accounts(DataSet input)
        {
            try
            {
                AccountsEO output = new AccountsEO();
                foreach (DataRow dr in input.Tables[0].Rows)
                {
                    output.Accounts_ID = (dr["Accounts_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["Accounts_ID"]);
                    output.Accounts_Username = (dr["Accounts_Username"] == DBNull.Value) ? "" : Convert.ToString(dr["Accounts_Username"]);
                    output.Accounts_Password = (dr["Accounts_Password"] == DBNull.Value) ? "" : Convert.ToString(dr["Accounts_Password"]);
                    output.Accounts_Email = (dr["Accounts_Email"] == DBNull.Value) ? "" : Convert.ToString(dr["Accounts_Email"]);
                    output.Accounts_Permission = (dr["Accounts_Permission"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["Accounts_Permission"]);
                    output.Accounts_RegisterDate = (dr["Accounts_RegisterDate"] == DBNull.Value) ? DateTime.MinValue : DateTime.ParseExact(dr["Accounts_RegisterDate"].ToString(), Messages.DateTime_Format, CultureInfo.InvariantCulture);
                    output.Accounts_LinkAvatar = (dr["Accounts_LinkAvatar"] == DBNull.Value) ? "" : Convert.ToString(dr["Accounts_LinkAvatar"]);
                    output.Accounts_FullName = (dr["Accounts_FullName"] == DBNull.Value) ? "" : Convert.ToString(dr["Accounts_FullName"]);
                    output.Accounts_Address = (dr["Accounts_Address"] == DBNull.Value) ? "" : Convert.ToString(dr["Accounts_Address"]);
                    output.Accounts_DateOfBirth = (dr["Accounts_DateOfBirth"] == DBNull.Value) ? DateTime.MinValue : DateTime.ParseExact(dr["Accounts_DateOfBirth"].ToString(), Messages.DateTime_Format, CultureInfo.InvariantCulture);
                    output.Accounts_PhoneNumber = (dr["Accounts_PhoneNumber"] == DBNull.Value) ? "" : Convert.ToString(dr["Accounts_PhoneNumber"]);
                    output.Accounts_Status = (dr["Accounts_Status"] == DBNull.Value) ? false : Convert.ToBoolean(dr["Accounts_Status"]);
                }
                return output;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static AdvertisementEO Advertisement(DataSet input)
        {
            try
            {
                AdvertisementEO output = new AdvertisementEO();
                foreach (DataRow dr in input.Tables[0].Rows)
                {
                    output.PK_iAdvID = Convert.ToInt32(dr["PK_iAdvID"]);
                    output.sTitle = Convert.ToString(dr["sTitle"]);
                    output.sLink = Convert.ToString(dr["sLink"]);
                    output.sImage = Convert.ToString(dr["sImage"]);
                }
                return output;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static AnswersEO Answers(DataSet input)
        {
            try
            {
                AnswersEO output = new AnswersEO();
                foreach (DataRow dr in input.Tables[0].Rows)
                {
                    output.Answers_ID = (dr["Answers_ID"] == DBNull.Value) ? 0 : Convert.ToInt64(dr["Answers_ID"]);
                    output.Support_ID = (dr["Support_ID"] == DBNull.Value) ? 0 : Convert.ToInt64(dr["Support_ID"]);
                    output.Staff_ID = (dr["Staff_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["Staff_ID"]);
                    output.Answers_Content = (dr["Answers_Content"] == DBNull.Value) ? "" : Convert.ToString(dr["Answers_Content"]);
                    output.Answers_Question = (dr["Answers_Question"] == DBNull.Value) ? "" : Convert.ToString(dr["Answers_Question"]);
                    output.Answers_DateTimeA = (dr["Answers_DateTimeA"] == DBNull.Value) ? DateTime.MinValue : DateTime.ParseExact(dr["Answers_DateTimeA"].ToString(), Messages.DateTime_Format, CultureInfo.InvariantCulture);
                    output.Answers_DateTimeB = (dr["Answers_DateTimeB"] == DBNull.Value) ? DateTime.MinValue : DateTime.ParseExact(dr["Answers_DateTimeB"].ToString(), Messages.DateTime_Format, CultureInfo.InvariantCulture);
                }
                return output;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static OrdersEO Orders(DataSet input)
        {
            try
            {
                OrdersEO output = new OrdersEO();
                foreach (DataRow dr in input.Tables[0].Rows)
                {
                    output.Orders_ID = (dr["Orders_ID"] == DBNull.Value) ? 0 : Convert.ToInt64(dr["Orders_ID"]);
                    output.Client_ID = (dr["Client_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["Client_ID"]);
                    output.Pay_ID = (dr["Pay_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["Pay_ID"]);
                    output.Pay_Email = (dr["Pay_Email"] == DBNull.Value) ? "" : Convert.ToString(dr["Pay_Email"]);
                    output.Pay_FullName = (dr["Pay_FullName"] == DBNull.Value) ? "" : Convert.ToString(dr["Pay_FullName"]);
                    output.Pay_Address = (dr["Pay_Address"] == DBNull.Value) ? "" : Convert.ToString(dr["Pay_Address"]);
                    output.Pay_PhoneNumber = (dr["Pay_PhoneNumber"] == DBNull.Value) ? "" : Convert.ToString(dr["Pay_PhoneNumber"]);
                    output.Pay_Note = (dr["Pay_Note"] == DBNull.Value) ? "" : Convert.ToString(dr["Pay_Note"]);
                    output.Pay_Status = (dr["Pay_Status"] == DBNull.Value) ? false : Convert.ToBoolean(dr["Pay_Status"]);
                    output.Pay_DateOfStart = (dr["Pay_DateOfStart"] == DBNull.Value) ? DateTime.MinValue : DateTime.ParseExact(dr["Pay_DateOfStart"].ToString(), Messages.DateTime_Format, CultureInfo.InvariantCulture);
                    output.Pay_DateOfFinish = (dr["Pay_DateOfFinish"] == DBNull.Value) ? DateTime.MinValue : DateTime.ParseExact(dr["Pay_DateOfFinish"].ToString(), Messages.DateTime_Format, CultureInfo.InvariantCulture);
                }
                return output;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static OrdersDetailsEO OrdersDetails(DataSet input)
        {
            try
            {
                OrdersDetailsEO output = new OrdersDetailsEO();
                foreach (DataRow dr in input.Tables[0].Rows)
                {
                    output.OrdersDetails_ID = (dr["OrdersDetails_ID"] == DBNull.Value) ? 0 : Convert.ToInt64(dr["OrdersDetails_ID"]);
                    output.Orders_ID = (dr["Orders_ID"] == DBNull.Value) ? 0 : Convert.ToInt64(dr["Orders_ID"]);
                    output.Pro_ID = (dr["Pro_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["Pro_ID"]);
                    output.OrdersDetails_UnitPrice = (dr["OrdersDetails_UnitPrice"] == DBNull.Value) ? 0 : Convert.ToInt64(dr["OrdersDetails_UnitPrice"]);
                    output.OrdersDetails_Quantity = (dr["OrdersDetails_Quantity"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["OrdersDetails_Quantity"]);
                }
                return output;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static PayEO Pay(DataSet input)
        {
            try
            {
                PayEO output = new PayEO();
                foreach (DataRow dr in input.Tables[0].Rows)
                {
                    output.Pay_ID = (dr["Pay_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["Pay_ID"]);
                    output.Pay_Name = (dr["Pay_Name"] == DBNull.Value) ? "" : Convert.ToString(dr["Pay_Name"]);
                    output.Pay_Visible = (dr["Pay_Visible"] == DBNull.Value) ? false : Convert.ToBoolean(dr["Pay_Visible"]);
                }
                return output;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static ProductsEO Products(DataSet input)
        {
            try
            {
                ProductsEO output = new ProductsEO();
                foreach (DataRow dr in input.Tables[0].Rows)
                {
                    output.Products_ID = (dr["Products_ID"] == DBNull.Value) ? 0 : Convert.ToInt64(dr["Products_ID"]);
                    output.Products_Group = (dr["Products_Group"] == DBNull.Value) ? 0 : Convert.ToInt64(dr["Products_Group"]);
                    output.Products_Parent = (dr["Products_Parent"] == DBNull.Value) ? 0 : Convert.ToInt64(dr["Products_Parent"]);
                    output.Products_Name = (dr["Products_Name"] == DBNull.Value) ? "" : Convert.ToString(dr["Products_Name"]);
                    output.Products_Price = (dr["Products_Price"] == DBNull.Value) ? 0 : Convert.ToInt64(dr["Products_Price"]);
                    output.Products_Sale = (dr["Products_Sale"] == DBNull.Value) ? 0 : Convert.ToInt64(dr["Products_Sale"]);
                    output.Products_VAT = (dr["Products_VAT"] == DBNull.Value) ? false : Convert.ToBoolean(dr["Products_VAT"]);
                    output.Products_Description = (dr["Products_Description"] == DBNull.Value) ? "" : Convert.ToString(dr["Products_Description"]);
                    output.Products_Info = (dr["Products_Info"] == DBNull.Value) ? "" : Convert.ToString(dr["Products_Info"]);
                    output.Products_Origin = (dr["Products_Origin"] == DBNull.Value) ? "" : Convert.ToString(dr["Products_Origin"]);
                    output.Products_Image1 = (dr["Products_Image1"] == DBNull.Value) ? "" : Convert.ToString(dr["Products_Image1"]);
                    output.Products_Image2 = (dr["Products_Image2"] == DBNull.Value) ? "" : Convert.ToString(dr["Products_Image2"]);
                    output.Products_Image3 = (dr["Products_Image3"] == DBNull.Value) ? "" : Convert.ToString(dr["Products_Image3"]);
                    output.Products_Video = (dr["Products_Video"] == DBNull.Value) ? "" : Convert.ToString(dr["Products_Video"]);
                    //output.Products_LastUpdate = (dr["Products_LastUpdate"] == DBNull.Value) ? DateTime.MinValue : DateTime.ParseExact(dr["Products_LastUpdate"].ToString(), Messages.DateTime_Format, CultureInfo.InvariantCulture);
                    output.Products_Visible = (dr["Products_Visible"] == DBNull.Value) ? false : Convert.ToBoolean(dr["Products_Visible"]);
                }
                return output;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static SupportsEO Supports(DataSet input)
        {
            try
            {
                SupportsEO output = new SupportsEO();
                foreach (DataRow dr in input.Tables[0].Rows)
                {
                    output.Supports_ID = (dr["Supports_ID"] == DBNull.Value) ? 0 : Convert.ToInt64(dr["Supports_ID"]);
                    output.Customer_ID = (dr["Customer_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["Customer_ID"]);
                    output.Product_ID = (dr["Product_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["Product_ID"]);
                    output.Supports_Type = (dr["Supports_Type"] == DBNull.Value) ? "" : Convert.ToString(dr["Supports_Type"]);
                    output.Supports_Status = (dr["Supports_Status"] == DBNull.Value) ? false : Convert.ToBoolean(dr["Supports_Status"]);
                }
                return output;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static WebsiteEO Website(DataSet input)
        {
            try
            {
                WebsiteEO output = new WebsiteEO();
                foreach (DataRow dr in input.Tables[0].Rows)
                {
                    output.Website_ID = (dr["Website_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["Website_ID"]);
                    output.Website_Title = (dr["Website_Title"] == DBNull.Value) ? "" : Convert.ToString(dr["Website_Title"]);
                    output.Website_Content = (dr["Website_Content"] == DBNull.Value) ? "" : Convert.ToString(dr["Website_Content"]);
                    output.Website_LastUpdate = (dr["Website_LastUpdate"] == DBNull.Value) ? DateTime.MinValue : DateTime.ParseExact(dr["Website_LastUpdate"].ToString(), Messages.DateTime_Format, CultureInfo.InvariantCulture);
                }
                return output;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}