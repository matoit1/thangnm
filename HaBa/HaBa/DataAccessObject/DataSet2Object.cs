using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Globalization;
using HaBa.SharedLibraries;
using HaBa.EntityObject;
using System.Data.SqlTypes;

namespace HaBa.DataAccessObject
{
    public class DataSet2Object
    {
        public static tblTaiKhoanEO Account(DataSet input)
        {
            try
            {
                tblTaiKhoanEO output = new tblTaiKhoanEO();
                foreach (DataRow dr in input.Tables[0].Rows)
                {
                    output.PK_iTaiKhoanID = (dr["PK_iTaiKhoanID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["PK_iTaiKhoanID"]);
                    output.sTenDangNhap = (dr["sTenDangNhap"] == DBNull.Value) ? "" : Convert.ToString(dr["sTenDangNhap"]);
                    output.sMatKhau = (dr["sMatKhau"] == DBNull.Value) ? "" : Convert.ToString(dr["sMatKhau"]);
                    output.sHoTen = (dr["sHoTen"] == DBNull.Value) ? "" : Convert.ToString(dr["sHoTen"]);
                    output.sEmail = (dr["sEmail"] == DBNull.Value) ? "" : Convert.ToString(dr["sEmail"]);
                    output.sDiaChi = (dr["sDiaChi"] == DBNull.Value) ? "" : Convert.ToString(dr["sDiaChi"]);
                    output.sSoDienThoai = (dr["sSoDienThoai"] == DBNull.Value) ? "" : Convert.ToString(dr["sSoDienThoai"]);
                    output.sLinkAvatar = (dr["sLinkAvatar"] == DBNull.Value) ? "" : Convert.ToString(dr["sLinkAvatar"]);
                    output.tNgaySinh = (dr["tNgaySinh"] == DBNull.Value) ? SqlDateTime.MinValue.Value : Convert.ToDateTime(dr["tNgaySinh"]);
                    output.tNgayDangKy = (dr["tNgayDangKy"] == DBNull.Value) ? SqlDateTime.MinValue.Value : Convert.ToDateTime(dr["tNgayDangKy"]);
                    //output.tNgaySinh = (dr["tDateOfBirth"] == DBNull.Value) ? DateTime.MinValue : DateTime.ParseExact(dr["tDateOfBirth"].ToString(), Messages.Format_DateTime, CultureInfo.InvariantCulture);
                    //output.tNgayDangKy = (dr["tRegisterDate"] == DBNull.Value) ? DateTime.MinValue : DateTime.ParseExact(dr["tRegisterDate"].ToString(), Messages.Format_DateTime, CultureInfo.InvariantCulture);
                    output.iQuyenHan = (dr["iQuyenHan"] == DBNull.Value) ? Convert.ToInt16(0) : Convert.ToInt16(dr["iQuyenHan"]);
                    output.iTrangThai = (dr["iTrangThai"] == DBNull.Value) ? Convert.ToInt16(0) : Convert.ToInt16(dr["iTrangThai"]);
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

        public static tblSanPhamEO Product(DataSet input)
        {
            try
            {
                tblSanPhamEO output = new tblSanPhamEO();
                foreach (DataRow dr in input.Tables[0].Rows)
                {
                    output.PK_lSanPhamID = (dr["PK_lSanPhamID"] == DBNull.Value) ? 0 : Convert.ToInt64(dr["PK_lSanPhamID"]);
                    output.FK_iNhomSanPhamID = (dr["FK_iNhomSanPhamID"] == DBNull.Value) ? Convert.ToInt16(0) : Convert.ToInt16(dr["FK_iNhomSanPhamID"]);
                    output.sTenSanPham = (dr["sTenSanPham"] == DBNull.Value) ? "" : Convert.ToString(dr["sTenSanPham"]);
                    output.sMoTa = (dr["sMoTa"] == DBNull.Value) ? "" : Convert.ToString(dr["sMoTa"]);
                    output.sXuatXu = (dr["sXuatXu"] == DBNull.Value) ? "" : Convert.ToString(dr["sXuatXu"]);
                    output.sLinkImage = (dr["sLinkImage"] == DBNull.Value) ? "" : Convert.ToString(dr["sLinkImage"]);
                    output.lGiaBan = (dr["lGiaBan"] == DBNull.Value) ? 0 : Convert.ToInt64(dr["lGiaBan"]);
                    output.iVAT = (dr["iVAT"] == DBNull.Value) ? Convert.ToInt16(0) : Convert.ToInt16(dr["iVAT"]);
                    output.iDoTuoi = (dr["iDoTuoi"] == DBNull.Value) ? Convert.ToInt16(0) : Convert.ToInt16(dr["iDoTuoi"]);
                    output.iGioiTinh = (dr["iGioiTinh"] == DBNull.Value) ? Convert.ToInt16(0) : Convert.ToInt16(dr["iGioiTinh"]);
                    output.iSoLuong = (dr["iSoLuong"] == DBNull.Value) ? Convert.ToInt16(0) : Convert.ToInt16(dr["iSoLuong"]);
                    output.tNgayCapNhat = (dr["tNgayCapNhat"] == DBNull.Value) ? SqlDateTime.MinValue.Value : Convert.ToDateTime(dr["tNgayCapNhat"]);
                    //output.tNgayCapNhat = (dr["tNgayCapNhat"] == DBNull.Value) ? DateTime.MinValue : DateTime.ParseExact(dr["tNgayCapNhat"].ToString(), Messages.DateTime_Format, CultureInfo.InvariantCulture);
                    output.iTrangThai = (dr["iTrangThai"] == DBNull.Value) ? Convert.ToInt16(0) : Convert.ToInt16(dr["iTrangThai"]);
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