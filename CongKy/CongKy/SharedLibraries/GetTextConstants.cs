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
                case 2: output = "Tài liệu"; break;
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

        /// <summary> I.9. SanPham_iDoTuoi_GTC (Độ Tuổi Sản Phẩm) </summary>
        /// <param name="input"></param>
        /// <returns>output</returns>
        public static string SanPham_iDoTuoi_GTC(Int16 input)
        {
            string output = "";
            switch (input)
            {
                case 1: output = "Dưới 1 tuổi"; break;
                case 2: output = "Từ 1 đến 2 tuổi"; break;
                case 3: output = "Từ 2 đến 3 tuổi"; break;
                case 4: output = "Từ 3 đến 5 tuổi"; break;
                case 5: output = "Trên 5 tuổi"; break;
            }
            return output;
        }

        /// <summary>  I.10 SanPham_iGioiTinh_GTC (Giới Tính Sản Phẩm)  </summary>
        /// <param name="input"></param>
        /// <returns>output</returns>
        public static string SanPham_iGioiTinh_GTC(Int16 input)
        {
            string output = "";
            switch (input)
            {
                case 1: output = "Nam"; break;
                case 2: output = "Nữ"; break;
                case 3: output = "Cả Nam và Nữ"; break;
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

        /// <summary> I.11. ThanhToan_iTrangThai_GTC (Trạng Thái Thanh Toán) </summary>
        /// <param name="input"></param>
        /// <returns>output</returns>
        public static string ThanhToan_iTrangThai_GTC(Int16 input)
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
        #endregion
    }
}