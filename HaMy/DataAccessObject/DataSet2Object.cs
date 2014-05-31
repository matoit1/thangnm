using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Globalization;
using HaMy.EntityObject;
using System.Data.SqlTypes;

namespace HaMy.DataAccessObject
{
    public class DataSet2Object
    {
        public static tblCuocHenEO CuocHenDO(DataSet input)
        {
            try
            {
                tblCuocHenEO output = new tblCuocHenEO();
                foreach (DataRow dr in input.Tables[0].Rows)
                {
                    output.PK_lCuocHen = (dr["PK_lCuocHen"] == DBNull.Value) ? 0 : Convert.ToInt64(dr["PK_lCuocHen"]);
                    output.FK_iNguoiDung = (dr["FK_iNguoiDung"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["FK_iNguoiDung"]);
                    output.FK_iDoiTac = (dr["FK_iDoiTac"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["FK_iDoiTac"]);
                    output.sNoiDung = (dr["sNoiDung"] == DBNull.Value) ? "" : Convert.ToString(dr["sNoiDung"]);
                    output.sDiaDiem = (dr["sDiaDiem"] == DBNull.Value) ? "" : Convert.ToString(dr["sDiaDiem"]);
                    output.tNgayGioBatDau = (dr["tNgayGioBatDau"] == DBNull.Value) ? SqlDateTime.MinValue.Value : Convert.ToDateTime(dr["tNgayGioBatDau"]);
                    output.tNgayGioKetThuc = (dr["tNgayGioKetThuc"] == DBNull.Value) ? SqlDateTime.MinValue.Value : Convert.ToDateTime(dr["tNgayGioKetThuc"]);
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

        public static tblDoiTacEO DoiTacDO(DataSet input)
        {
            try
            {
                tblDoiTacEO output = new tblDoiTacEO();
                foreach (DataRow dr in input.Tables[0].Rows)
                {
                    output.PK_iDoiTac = (dr["PK_iDoiTac"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["PK_iDoiTac"]);
                    output.FK_iNhom = (dr["FK_iNhom"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["FK_iNhom"]);
                    output.sHoTen = (dr["sHoTen"] == DBNull.Value) ? "" : Convert.ToString(dr["sHoTen"]);
                    output.sDiaChi = (dr["sDiaChi"] == DBNull.Value) ? "" : Convert.ToString(dr["sDiaChi"]);
                    output.sEmail = (dr["sEmail"] == DBNull.Value) ? "" : Convert.ToString(dr["sEmail"]);
                    output.sSoDienThoai = (dr["sSoDienThoai"] == DBNull.Value) ? "" : Convert.ToString(dr["sSoDienThoai"]);
                    output.tNgaySinh = (dr["tNgaySinh"] == DBNull.Value) ? DateTime.MinValue : Convert.ToDateTime(dr["tNgaySinh"]);
                    output.bGioiTinh = (dr["bGioiTinh"] == DBNull.Value) ? false : Convert.ToBoolean(dr["bGioiTinh"]);
                    output.sNgheNghiep = (dr["sHoTen"] == DBNull.Value) ? "" : Convert.ToString(dr["sHoTen"]);
                    output.FK_iMoiQuanHe = (dr["FK_iMoiQuanHe"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["FK_iMoiQuanHe"]);
                    output.sGhiChu = (dr["sGhiChu"] == DBNull.Value) ? "" : Convert.ToString(dr["sGhiChu"]);
                    output.iTrangThai = (dr["iTrangThai"] == DBNull.Value) ? Convert.ToInt16(0) : Convert.ToInt16(dr["iTrangThai"]);
                }
                return output;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static tblMoiQuanHeEO MoiQuanHeDO(DataSet input)
        {
            try
            {
                tblMoiQuanHeEO output = new tblMoiQuanHeEO();
                foreach (DataRow dr in input.Tables[0].Rows)
                {
                    output.PK_iMoiQuanHe = (dr["PK_iMoiQuanHe"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["PK_iMoiQuanHe"]);
                    output.sTen = (dr["sTen"] == DBNull.Value) ? "" : Convert.ToString(dr["sTen"]);
                }
                return output;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static tblNhomEO NhomDO(DataSet input)
        {
            try
            {
                tblNhomEO output = new tblNhomEO();
                foreach (DataRow dr in input.Tables[0].Rows)
                {
                    output.PK_iNhom = (dr["PK_iNhom"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["PK_iNhom"]);
                    output.sTenNhom = (dr["sTenNhom"] == DBNull.Value) ? "" : Convert.ToString(dr["sTenNhom"]);
                }
                return output;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static tblNguoiDungEO NguoiDungDO(DataSet input)
        {
            try
            {
                tblNguoiDungEO output = new tblNguoiDungEO();
                foreach (DataRow dr in input.Tables[0].Rows)
                {
                    output.PK_iNguoiDung = (dr["PK_iNguoiDung"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["PK_iNguoiDung"]);
                    output.sHoTen = (dr["sHoTen"] == DBNull.Value) ? "" : Convert.ToString(dr["sHoTen"]);
                    output.sDiaChi = (dr["sDiaChi"] == DBNull.Value) ? "" : Convert.ToString(dr["sDiaChi"]);
                    output.sEmail = (dr["sEmail"] == DBNull.Value) ? "" : Convert.ToString(dr["sEmail"]);
                    output.sSoDienThoai = (dr["sSoDienThoai"] == DBNull.Value) ? "" : Convert.ToString(dr["sSoDienThoai"]);
                    output.tNgaySinh = (dr["tNgaySinh"] == DBNull.Value) ? DateTime.MinValue : Convert.ToDateTime(dr["tNgaySinh"]);
                    output.bGioiTinh = (dr["bGioiTinh"] == DBNull.Value) ? false : Convert.ToBoolean(dr["bGioiTinh"]);
                    output.sNgheNghiep = (dr["sNgheNghiep"] == DBNull.Value) ? "" : Convert.ToString(dr["sNgheNghiep"]);
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