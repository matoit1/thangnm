using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CongKy.SharedLibraries.Constants
{
    #region "I. Constants - GetTextConstants - GetListConstants"

    /// <summary> I.5. ChiTietGiaoTrinh_iTrangThai_C (Trạng Thái Chi Tiết Giáo Trình) </summary>
    /// 
    public class ChiTietGiaoTrinh_iTrangThai_C
    {
        public const Int16 Mo = 1;
        public const Int16 Khoa = 2;
    }


    /// <summary> I.5. ChiTietGiaoTrinh_iType_C (Loại Chi Tiết Giáo Trình) </summary>
    /// 
    public class ChiTietGiaoTrinh_iType_C
    {
        public const Int16 Video = 1;
        public const Int16 Ebook = 2;
        public const Int16 Software = 3;
        public const Int16 Other = 4;
    }

    /// <summary> I.7. DangKyDayHoc_iTrangThai_C (Trạng Thái Đăng ký dạy học) </summary>
    /// 
    public class DangKyDayHoc_iTrangThai_C
    {
        public const Int16 Mo = 1;
        public const Int16 Khoa = 2;
    }

    /// <summary> I.8. MonHoc_iTrangThai_C (Trạng Thái môn học) </summary>
    /// 
    public class MonHoc_iTrangThai_C
    {
        public const Int16 Mo = 1;
        public const Int16 Khoa = 2;

    }

    /// <summary> I.9. SanPham_iDoTuoi_C (Độ Tuổi Sản Phẩm) </summary>
    /// 
    public class SanPham_iDoTuoi_C
    {
        public const Int16 Loai1 = 1;
        public const Int16 Loai2 = 2;
        public const Int16 Loai3 = 3;
        public const Int16 Loai4 = 4;
        public const Int16 Loai5 = 5;
    }

    /// <summary> I.10 SanPham_iGioiTinh_C (Giới Tính Sản Phẩm) </summary>
    /// 
    public class SanPham_iGioiTinh_C
    {
        public const Int16 Nam = 1;
        public const Int16 Nu = 2;
        public const Int16 Nam_Nu = 3;
    }

    /// <summary> I.12. TaiKhoan_iTrangThai_C (Trạng Thái Tài Khoản) </summary>
    /// 
    public class TaiKhoan_iTrangThai_C
    {
        public const Int16 Mo = 1;
        public const Int16 Xem_Xet = 2;
        public const Int16 Khoa = 3;
    }

    /// <summary> I.13. TaiKhoan_iQuyenHan_C (Quyền Hạn Tài Khoản) </summary>
    /// 
    public class TaiKhoan_iQuyenHan_C
    {
        public const Int16 QuanTri = 1;
        public const Int16 Nhan_Vien = 2;
        public const Int16 Khach_Hang = 3;
    }

    /// <summary> I.11. ThanhToan_iTrangThai_C (Trạng Thái Thanh Toán) </summary>
    /// 
    public class ThanhToan_iTrangThai_C
    {
        public const Int16 Mo = 1;
        public const Int16 Xem_Xet = 2;
        public const Int16 Khoa = 3;
    }
    #endregion
}