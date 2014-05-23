using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CongKy.SharedLibraries.Constants
{
    #region "I. Constants - GetTextConstants - GetListConstants"

    /// <summary> I.5. HoaDon_iTrangThai_C (Trạng Thái Hóa Đơn) </summary>
    /// 
    public class HoaDon_iTrangThai_C
    {
        public const Int16 Chua_Kiem_Tra = 1;
        public const Int16 Chua_Giao_Hang = 2;
        public const Int16 Da_Giao_Hang = 3;
        public const Int16 Huy = 4;
    }

    /// <summary> I.7. NhomSanPham_iTrangThai_C (Trạng Thái Nhóm Sản Phẩm) </summary>
    /// 
    public class NhomSanPham_iTrangThai_C
    {
        public const Int16 Mo = 1;
        public const Int16 Khoa = 2;
    }

    /// <summary> I.8. SanPham_iTrangThai_C (Trạng Thái Sản Phẩm) </summary>
    /// 
    public class SanPham_iTrangThai_C
    {
        public const Int16 Mo = 1;
        public const Int16 Het_Hang = 2;
        public const Int16 Khoa = 3;

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