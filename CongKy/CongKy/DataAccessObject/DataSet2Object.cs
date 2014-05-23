using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Globalization;
using CongKy.SharedLibraries;
using CongKy.EntityObject;
using System.Data.SqlTypes;

namespace CongKy.DataAccessObject
{
    public class DataSet2Object
    {
        public static tblTaiKhoanEO TaiKhoanDO(DataSet input)
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

        public static tblDangKyDayHocEO DangKyDayHocDO(DataSet input)
        {
            try
            {
                tblDangKyDayHocEO output = new tblDangKyDayHocEO();
                foreach (DataRow dr in input.Tables[0].Rows)
                {
                    output.FK_iTaiKhoanID = (dr["FK_iTaiKhoanID"] == DBNull.Value) ? Convert.ToInt32(0) : Convert.ToInt32(dr["FK_iTaiKhoanID"]);
                    output.FK_iMonHocID = (dr["FK_iMonHocID"] == DBNull.Value) ? Convert.ToInt32(0) : Convert.ToInt32(dr["FK_iMonHocID"]);
                    output.tNgayDangKy = (dr["tNgayDangKy"] == DBNull.Value) ? DateTime.MinValue : Convert.ToDateTime(dr["tNgayDangKy"]);
                    output.iTrangThai = (dr["iTrangThai"] == DBNull.Value) ? Convert.ToInt16(0) : Convert.ToInt16(dr["iTrangThai"]);
                }
                return output;
            }
            catch (Exception)
            {
                throw;
            }
        }

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

        public static tblMonHocEO MonHocDO(DataSet input)
        {
            try
            {
                tblMonHocEO output = new tblMonHocEO();
                foreach (DataRow dr in input.Tables[0].Rows)
                {
                    output.PK_iMonHocID = (dr["PK_iMonHocID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["PK_iMonHocID"]);
                    output.sTenMonHoc = (dr["sTenMonHoc"] == DBNull.Value) ? "" : Convert.ToString(dr["sTenMonHoc"]);
                    output.iTrangThai = (dr["iTrangThai"] == DBNull.Value) ? Convert.ToInt16(0) : Convert.ToInt16(dr["iTrangThai"]);
                }
                return output;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static tblChiTietGiaoTrinhEO ChiTietGiaoTrinhDO(DataSet input)
        {
            try
            {
                tblChiTietGiaoTrinhEO output = new tblChiTietGiaoTrinhEO();
                foreach (DataRow dr in input.Tables[0].Rows)
                {
                    output.PK_iGiaoTrinhID = (dr["PK_iGiaoTrinhID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["PK_iGiaoTrinhID"]);
                    output.sTenBaiHoc = (dr["sTenBaiHoc"] == DBNull.Value) ? "" : Convert.ToString(dr["sTenBaiHoc"]);
                    output.sLinkDownload = (dr["sLinkDownload"] == DBNull.Value) ? "" : Convert.ToString(dr["sLinkDownload"]);
                    output.iType = (dr["iType"] == DBNull.Value) ? Convert.ToInt16(0) : Convert.ToInt16(dr["iType"]);
                    output.tNgayCapNhat = (dr["tNgayCapNhat"] == DBNull.Value) ? DateTime.MinValue : Convert.ToDateTime(dr["tNgayCapNhat"]);
                    output.iTrangThai = (dr["iTrangThai"] == DBNull.Value) ? Convert.ToInt16(0) : Convert.ToInt16(dr["iTrangThai"]);
                }
                return output;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static tblGiaoTrinhEO GiaoTrinhDO(DataSet input)
        {
            try
            {
                tblGiaoTrinhEO output = new tblGiaoTrinhEO();
                foreach (DataRow dr in input.Tables[0].Rows)
                {
                    output.FK_iMonHocID = (dr["PK_iThanhToanID"] == DBNull.Value) ? Convert.ToInt32(0) : Convert.ToInt32(dr["FK_iMonHocID"]);
                    output.FK_iGiaoTrinhID = (dr["FK_iGiaoTrinhID"] == DBNull.Value) ? Convert.ToInt32(0) : Convert.ToInt32(dr["FK_iGiaoTrinhID"]);
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