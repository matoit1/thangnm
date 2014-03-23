﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shared_Libraries
{
    public class Common
    {
        /// <summary> RemoveHtmlTags (Loại bỏ thẻ html) </summary>
        /// <param name="htmlString"></param>
        /// <returns></returns>
        public static string RemoveHtmlTags(string htmlString)
        {
            var array = new char[htmlString.Length];
            var arrayIndex = 0;
            var inside = false;

            foreach (var @let in htmlString)
            {
                if (let == '<')
                {
                    inside = true;
                    continue;
                }
                if (let == '>')
                {
                    inside = false;
                    continue;
                }
                if (inside) continue;
                array[arrayIndex] = let;
                arrayIndex++;
            }
            return new string(array, 0, arrayIndex);
        }

        public static string GetTempDate()
        {
            string strTmpDate = System.DateTime.Now.ToShortDateString();
            strTmpDate = strTmpDate.Replace(":", "-").Trim();
            strTmpDate = strTmpDate.Replace("/", "-").Trim();
            return strTmpDate;
        }
    }

    public class Messages
    {
        public const string Tong_So_Ban_Ghi = "Tổng số bản ghi: ";
        public const string Khong_Thoa_Man_Dieu_Kien_Tim_Kiem = "Không thỏa mãn điều kiện tìm kiếm!";
        public const string Loi = "Lỗi: ";
        public const string Khong_Dung_Dinh_Dang_So = "Không đúng định dạng số, Vui lòng kiểm tra lại!";
        public const string Khong_Dung_Dinh_Dang_Ngay = "Không đúng định dạng ngày/ giờ, Vui lòng kiểm tra lại!";

        public const string Them_Thanh_Cong = "Thêm thành công";
        public const string Them_That_Bai = "Thêm thất bại, vui lòng kiểm tra lại!";
        public const string Sua_Thanh_Cong = "Sửa thành công";
        public const string Sua_That_Bai = "Sửa thất bại, vui lòng kiểm tra lại!";
        public const string Xoa_Thanh_Cong = "Xóa thành công";
        public const string Xoa_That_Bai = "Xóa thất bại, vui lòng kiểm tra lại!";

        public static readonly string DateTime_Temp = Convert.ToString(DateTime.Now.ToString("dd-MM-yyyy"));
    }
}