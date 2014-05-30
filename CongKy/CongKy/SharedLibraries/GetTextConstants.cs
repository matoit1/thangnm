using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CongKy.SharedLibraries
{
    public class GetTextConstants
    {
        #region "I. Constants - GetTextConstants - GetListConstants"

        /// <summary> I.5.  ChiTietGiaoTrinh_iTrangThai_GTC (Trạng Thái Chi Tiết Giáo Trình) </summary>
        /// <param name="input"></param>
        /// <returns>output</returns>
        public static string ChiTietGiaoTrinh_iTrangThai_GTC(Int16 input)
        {
            string output = "";
            switch (input)
            {
                case 1: output = "Mở"; break;
                case 2: output = "Khóa"; break;
                default: output = "N/A"; break;
            }
            return output;
        }

        /// <summary> I.5.  ChiTietGiaoTrinh_iType_GTC (Loại Chi Tiết Giáo Trình) </summary>
        /// <param name="input"></param>
        /// <returns>output</returns>
        public static string ChiTietGiaoTrinh_iType_GTC(Int16 input)
        {
            string output = "";
            switch (input)
            {
                case 1: output = "Video"; break;
                case 2: output = "Tài liệu Pdf"; break;
                case 3: output = "Phần mềm"; break;
                case 4: output = "Loại khác"; break;
                default: output = "N/A"; break;
            }
            return output;
        }

        /// <summary> I.7. DangKyDayHoc_iTrangThai_GTC (Trạng Thái Đăng ký dạy học) </summary>
        /// <param name="input"></param>
        /// <returns>output</returns>
        public static string DangKyDayHoc_iTrangThai_GTC(Int16 input)
        {
            string output = "";
            switch (input)
            {
                case 1: output = "Mở"; break;
                case 2: output = "Khóa"; break;
                default: output = "N/A"; break;
            }
            return output;
        }

        /// <summary> I.8. MonHoc_iTrangThai_GTC (Trạng Thái môn học) </summary>
        /// <param name="input"></param>
        /// <returns>output</returns>
        public static string MonHoc_iTrangThai_GTC(Int16 input)
        {
            string output = "";
            switch (input)
            {
                case 1: output = "Mở"; break;
                case 2: output = "Khóa"; break;
                default: output = "N/A"; break;
            }
            return output;
        }

        /// <summary> I.12. TaiKhoan_iTrangThai_GTC (Trạng Thái Tài Khoản) </summary>
        /// <param name="input"></param>
        /// <returns>output</returns>
        public static string TaiKhoan_iTrangThai_GTC(Int16 input)
        {
            string output = "";
            switch (input)
            {
                case 1: output = "Mở"; break;
                case 2: output = "Xem xét"; break;
                case 3: output = "Khóa"; break;
                default: output = "N/A"; break;
            }
            return output;
        }

        /// <summary> I.2. TaiKhoan_iQuyenHan_GTC (Quyền Hạn Tài Khoản) </summary>
        /// <param name="input"></param>
        /// <returns>output</returns>
        public static string TaiKhoan_iQuyenHan_GTC(Int16 input)
        {
            string output = "";
            switch (input)
            {
                case 1: output = "Quản trị"; break;
                case 2: output = "Giảng Viên"; break;
                case 3: output = "Sinh Viên"; break;
                default: output = "N/A"; break;
            }
            return output;
        }
        #endregion



        /// <summary> I.5.  ERROR_GTC </summary>
        /// <param name="input"></param>
        /// <returns>output</returns>
        public static string ERROR_GTC(Int16 input)
        {
            string output = "";
            switch (input)
            {
                case 1: output = "Bạn không có quyền truy cập vào tài nguyên này!"; break;
                case 2: output = "Lỗi!"; break;
                default: output = "N/A"; break;
            }
            return output;
        }
    }
}