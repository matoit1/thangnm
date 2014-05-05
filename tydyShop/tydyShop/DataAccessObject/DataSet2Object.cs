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
        public static AccountEO Account(DataSet input)
        {
            try
            {
                AccountEO output = new AccountEO();
                foreach (DataRow dr in input.Tables[0].Rows)
                {
                    output.PK_iAccountID = (dr["PK_iAccountID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["PK_iAccountID"]);
                    output.sFullName = (dr["sFullName"] == DBNull.Value) ? "" : Convert.ToString(dr["sFullName"]);
                    output.sUsername = (dr["sUsername"] == DBNull.Value) ? "" : Convert.ToString(dr["sUsername"]);
                    output.sPassword = (dr["sPassword"] == DBNull.Value) ? "" : Convert.ToString(dr["sPassword"]);
                    output.sEmail = (dr["sEmail"] == DBNull.Value) ? "" : Convert.ToString(dr["sEmail"]);
                    output.sAddress = (dr["sAddress"] == DBNull.Value) ? "" : Convert.ToString(dr["sAddress"]);
                    output.sPhoneNumber = (dr["sPhoneNumber"] == DBNull.Value) ? "" : Convert.ToString(dr["sPhoneNumber"]);
                    output.tDateOfBirth = (dr["tDateOfBirth"] == DBNull.Value) ? DateTime.MinValue : DateTime.ParseExact(dr["tDateOfBirth"].ToString(), Messages.DateTime_Format, CultureInfo.InvariantCulture);
                    output.iPermission = (dr["iPermission"] == DBNull.Value) ? Convert.ToInt16(0) : Convert.ToInt16(dr["iPermission"]);
                    output.tRegisterDate = (dr["tRegisterDate"] == DBNull.Value) ? DateTime.MinValue : DateTime.ParseExact(dr["tRegisterDate"].ToString(), Messages.DateTime_Format, CultureInfo.InvariantCulture);
                    output.sLinkAvatar = (dr["sLinkAvatar"] == DBNull.Value) ? "" : Convert.ToString(dr["sLinkAvatar"]);
                    output.bStatus = (dr["bStatus"] == DBNull.Value) ? false : Convert.ToBoolean(dr["bStatus"]);
                }
                return output;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //public static AdvertisementEO Advertisement(DataSet input)
        //{
        //    try
        //    {
        //        AdvertisementEO output = new AdvertisementEO();
        //        foreach (DataRow dr in input.Tables[0].Rows)
        //        {
        //            output.PK_iAdvID = Convert.ToInt32(dr["PK_iAdvID"]);
        //            output.sTitle = Convert.ToString(dr["sTitle"]);
        //            output.sLink = Convert.ToString(dr["sLink"]);
        //            output.sImage = Convert.ToString(dr["sImage"]);
        //        }
        //        return output;
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}

        //public static AnswersEO Answers(DataSet input)
        //{
        //    try
        //    {
        //        AnswersEO output = new AnswersEO();
        //        foreach (DataRow dr in input.Tables[0].Rows)
        //        {
        //            output.Answers_ID = (dr["Answers_ID"] == DBNull.Value) ? 0 : Convert.ToInt64(dr["Answers_ID"]);
        //            output.Support_ID = (dr["Support_ID"] == DBNull.Value) ? 0 : Convert.ToInt64(dr["Support_ID"]);
        //            output.Staff_ID = (dr["Staff_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["Staff_ID"]);
        //            output.Answers_Content = (dr["Answers_Content"] == DBNull.Value) ? "" : Convert.ToString(dr["Answers_Content"]);
        //            output.Answers_Question = (dr["Answers_Question"] == DBNull.Value) ? "" : Convert.ToString(dr["Answers_Question"]);
        //            output.Answers_DateTimeA = (dr["Answers_DateTimeA"] == DBNull.Value) ? DateTime.MinValue : DateTime.ParseExact(dr["Answers_DateTimeA"].ToString(), Messages.DateTime_Format, CultureInfo.InvariantCulture);
        //            output.Answers_DateTimeB = (dr["Answers_DateTimeB"] == DBNull.Value) ? DateTime.MinValue : DateTime.ParseExact(dr["Answers_DateTimeB"].ToString(), Messages.DateTime_Format, CultureInfo.InvariantCulture);
        //        }
        //        return output;
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}

        //public static OrdersEO Orders(DataSet input)
        //{
        //    try
        //    {
        //        OrdersEO output = new OrdersEO();
        //        foreach (DataRow dr in input.Tables[0].Rows)
        //        {
        //            output.Orders_ID = (dr["Orders_ID"] == DBNull.Value) ? 0 : Convert.ToInt64(dr["Orders_ID"]);
        //            output.Client_ID = (dr["Client_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["Client_ID"]);
        //            output.Pay_ID = (dr["Pay_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["Pay_ID"]);
        //            output.Pay_Email = (dr["Pay_Email"] == DBNull.Value) ? "" : Convert.ToString(dr["Pay_Email"]);
        //            output.Pay_FullName = (dr["Pay_FullName"] == DBNull.Value) ? "" : Convert.ToString(dr["Pay_FullName"]);
        //            output.Pay_Address = (dr["Pay_Address"] == DBNull.Value) ? "" : Convert.ToString(dr["Pay_Address"]);
        //            output.Pay_PhoneNumber = (dr["Pay_PhoneNumber"] == DBNull.Value) ? "" : Convert.ToString(dr["Pay_PhoneNumber"]);
        //            output.Pay_Note = (dr["Pay_Note"] == DBNull.Value) ? "" : Convert.ToString(dr["Pay_Note"]);
        //            output.Pay_Status = (dr["Pay_Status"] == DBNull.Value) ? false : Convert.ToBoolean(dr["Pay_Status"]);
        //            output.Pay_DateOfStart = (dr["Pay_DateOfStart"] == DBNull.Value) ? DateTime.MinValue : DateTime.ParseExact(dr["Pay_DateOfStart"].ToString(), Messages.DateTime_Format, CultureInfo.InvariantCulture);
        //            output.Pay_DateOfFinish = (dr["Pay_DateOfFinish"] == DBNull.Value) ? DateTime.MinValue : DateTime.ParseExact(dr["Pay_DateOfFinish"].ToString(), Messages.DateTime_Format, CultureInfo.InvariantCulture);
        //        }
        //        return output;
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}

        //public static OrdersDetailsEO OrdersDetails(DataSet input)
        //{
        //    try
        //    {
        //        OrdersDetailsEO output = new OrdersDetailsEO();
        //        foreach (DataRow dr in input.Tables[0].Rows)
        //        {
        //            output.OrdersDetails_ID = (dr["OrdersDetails_ID"] == DBNull.Value) ? 0 : Convert.ToInt64(dr["OrdersDetails_ID"]);
        //            output.Orders_ID = (dr["Orders_ID"] == DBNull.Value) ? 0 : Convert.ToInt64(dr["Orders_ID"]);
        //            output.Pro_ID = (dr["Pro_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["Pro_ID"]);
        //            output.OrdersDetails_UnitPrice = (dr["OrdersDetails_UnitPrice"] == DBNull.Value) ? 0 : Convert.ToInt64(dr["OrdersDetails_UnitPrice"]);
        //            output.OrdersDetails_Quantity = (dr["OrdersDetails_Quantity"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["OrdersDetails_Quantity"]);
        //        }
        //        return output;
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}

        //public static PayEO Pay(DataSet input)
        //{
        //    try
        //    {
        //        PayEO output = new PayEO();
        //        foreach (DataRow dr in input.Tables[0].Rows)
        //        {
        //            output.Pay_ID = (dr["Pay_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["Pay_ID"]);
        //            output.Pay_Name = (dr["Pay_Name"] == DBNull.Value) ? "" : Convert.ToString(dr["Pay_Name"]);
        //            output.Pay_Visible = (dr["Pay_Visible"] == DBNull.Value) ? false : Convert.ToBoolean(dr["Pay_Visible"]);
        //        }
        //        return output;
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}

        public static ProductEO Product(DataSet input)
        {
            try
            {
                ProductEO output = new ProductEO();
                foreach (DataRow dr in input.Tables[0].Rows)
                {
                    output.PK_lProductID = (dr["PK_lProductID"] == DBNull.Value) ? 0 : Convert.ToInt64(dr["PK_lProductID"]);
                    output.lGroup = (dr["lGroup"] == DBNull.Value) ? 0 : Convert.ToInt64(dr["lGroup"]);
                    output.lParent = (dr["lParent"] == DBNull.Value) ? 0 : Convert.ToInt64(dr["lParent"]);
                    output.sName = (dr["sName"] == DBNull.Value) ? "" : Convert.ToString(dr["sName"]);
                    output.lPrice = (dr["lPrice"] == DBNull.Value) ? 0 : Convert.ToInt64(dr["lPrice"]);
                    output.lSale = (dr["lSale"] == DBNull.Value) ? 0 : Convert.ToInt64(dr["lSale"]);
                    output.bVAT = (dr["bVAT"] == DBNull.Value) ? false : Convert.ToBoolean(dr["bVAT"]);
                    output.sDescription = (dr["sDescription"] == DBNull.Value) ? "" : Convert.ToString(dr["sDescription"]);
                    output.sInfomation = (dr["sInfomation"] == DBNull.Value) ? "" : Convert.ToString(dr["sInfomation"]);
                    output.sOrigin = (dr["sOrigin"] == DBNull.Value) ? "" : Convert.ToString(dr["sOrigin"]);
                    output.iQuantity = (dr["iQuantity"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["iQuantity"]);
                    output.sLinkImage = (dr["sLinkImage"] == DBNull.Value) ? "" : Convert.ToString(dr["sLinkImage"]);
                    output.sLinkImageThumbnail = (dr["sLinkImageThumbnail"] == DBNull.Value) ? "" : Convert.ToString(dr["sLinkImageThumbnail"]);
                    //output.tLastUpdate = (dr["tLastUpdate"] == DBNull.Value) ? DateTime.MinValue : DateTime.ParseExact(dr["tLastUpdate"].ToString(), Messages.DateTime_Format, CultureInfo.InvariantCulture);
                    output.bStatus = (dr["bStatus"] == DBNull.Value) ? false : Convert.ToBoolean(dr["bStatus"]);
                }
                return output;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //public static SupportsEO Supports(DataSet input)
        //{
        //    try
        //    {
        //        SupportsEO output = new SupportsEO();
        //        foreach (DataRow dr in input.Tables[0].Rows)
        //        {
        //            output.Supports_ID = (dr["Supports_ID"] == DBNull.Value) ? 0 : Convert.ToInt64(dr["Supports_ID"]);
        //            output.Customer_ID = (dr["Customer_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["Customer_ID"]);
        //            output.Product_ID = (dr["Product_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["Product_ID"]);
        //            output.Supports_Type = (dr["Supports_Type"] == DBNull.Value) ? "" : Convert.ToString(dr["Supports_Type"]);
        //            output.Supports_Status = (dr["Supports_Status"] == DBNull.Value) ? false : Convert.ToBoolean(dr["Supports_Status"]);
        //        }
        //        return output;
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}

        //public static WebsiteEO Website(DataSet input)
        //{
        //    try
        //    {
        //        WebsiteEO output = new WebsiteEO();
        //        foreach (DataRow dr in input.Tables[0].Rows)
        //        {
        //            output.Website_ID = (dr["Website_ID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["Website_ID"]);
        //            output.Website_Title = (dr["Website_Title"] == DBNull.Value) ? "" : Convert.ToString(dr["Website_Title"]);
        //            output.Website_Content = (dr["Website_Content"] == DBNull.Value) ? "" : Convert.ToString(dr["Website_Content"]);
        //            output.Website_LastUpdate = (dr["Website_LastUpdate"] == DBNull.Value) ? DateTime.MinValue : DateTime.ParseExact(dr["Website_LastUpdate"].ToString(), Messages.DateTime_Format, CultureInfo.InvariantCulture);
        //        }
        //        return output;
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}

    }
}