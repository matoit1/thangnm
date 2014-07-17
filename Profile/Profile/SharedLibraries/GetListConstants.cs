using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using SharedLibraries.Constants;

namespace SharedLibraries
{
    public class GetListConstants
    {
        #region "I. Constants - GetTextConstants - GetListConstants"
        
        /// <summary> I.5. HoaDon_iTrangThai_GLC (Trạng Thái Hóa Đơn) </summary>
        /// <returns></returns>
        public static SortedList HoaDon_iTrangThai_GLC()
        {
            SortedList output = new SortedList();
            output.Add(HoaDon_iTrangThai_C.Chua_Kiem_Tra, GetTextConstants.HoaDon_iTrangThai_GTC(HoaDon_iTrangThai_C.Chua_Kiem_Tra));
            output.Add(HoaDon_iTrangThai_C.Chua_Giao_Hang, GetTextConstants.HoaDon_iTrangThai_GTC(HoaDon_iTrangThai_C.Chua_Giao_Hang));
            output.Add(HoaDon_iTrangThai_C.Da_Giao_Hang, GetTextConstants.HoaDon_iTrangThai_GTC(HoaDon_iTrangThai_C.Da_Giao_Hang));
            output.Add(HoaDon_iTrangThai_C.Huy, GetTextConstants.HoaDon_iTrangThai_GTC(HoaDon_iTrangThai_C.Huy));
            return output;
        }

        /// <summary> I.7. NhomSanPham_iTrangThai_GLC (Trạng Thái Nhóm Sản Phẩm) </summary>
        /// <returns></returns>
        public static SortedList NhomSanPham_iTrangThai_GLC()
        {
            SortedList output = new SortedList();
            output.Add(NhomSanPham_iTrangThai_C.Mo, GetTextConstants.NhomSanPham_iTrangThai_GTC(NhomSanPham_iTrangThai_C.Mo));
            output.Add(NhomSanPham_iTrangThai_C.Khoa, GetTextConstants.NhomSanPham_iTrangThai_GTC(NhomSanPham_iTrangThai_C.Khoa));
            return output;
        }

        /// <summary> I.8. SanPham_iTrangThai_GLC (Trạng Thái Sản Phẩm) </summary>
        /// <returns></returns>
        public static SortedList SanPham_iTrangThai_GLC()
        {
            SortedList output = new SortedList();
            output.Add(SanPham_iTrangThai_C.Mo, GetTextConstants.SanPham_iTrangThai_GTC(SanPham_iTrangThai_C.Mo));
            output.Add(SanPham_iTrangThai_C.Het_Hang, GetTextConstants.SanPham_iTrangThai_GTC(SanPham_iTrangThai_C.Het_Hang));
            output.Add(SanPham_iTrangThai_C.Khoa, GetTextConstants.SanPham_iTrangThai_GTC(SanPham_iTrangThai_C.Khoa));
            return output;
        }

        /// <summary> I.9. SanPham_iDoTuoi_GLC (Độ Tuổi Sản Phẩm) </summary>
        /// <returns></returns>
        public static SortedList SanPham_iDoTuoi_GLC()
        {
            SortedList output = new SortedList();
            output.Add(SanPham_iDoTuoi_C.Loai1, GetTextConstants.SanPham_iDoTuoi_GTC(SanPham_iDoTuoi_C.Loai1));
            output.Add(SanPham_iDoTuoi_C.Loai2, GetTextConstants.SanPham_iDoTuoi_GTC(SanPham_iDoTuoi_C.Loai2));
            output.Add(SanPham_iDoTuoi_C.Loai3, GetTextConstants.SanPham_iDoTuoi_GTC(SanPham_iDoTuoi_C.Loai3));
            output.Add(SanPham_iDoTuoi_C.Loai4, GetTextConstants.SanPham_iDoTuoi_GTC(SanPham_iDoTuoi_C.Loai4));
            output.Add(SanPham_iDoTuoi_C.Loai5, GetTextConstants.SanPham_iDoTuoi_GTC(SanPham_iDoTuoi_C.Loai5));
            return output;
        }

        /// <summary> I.10 SanPham_iGioiTinh_GLC (Giới Tính Sản Phẩm) </summary>
        /// <returns></returns>
        public static SortedList SanPham_iGioiTinh_GLC()
        {
            SortedList output = new SortedList();
            output.Add(SanPham_iGioiTinh_C.Nam, GetTextConstants.SanPham_iGioiTinh_GTC(SanPham_iGioiTinh_C.Nam));
            output.Add(SanPham_iGioiTinh_C.Nu, GetTextConstants.SanPham_iGioiTinh_GTC(SanPham_iGioiTinh_C.Nu));
            output.Add(SanPham_iGioiTinh_C.Nam_Nu, GetTextConstants.SanPham_iGioiTinh_GTC(SanPham_iGioiTinh_C.Nam_Nu));
            return output;
        }

        /// <summary>  I.12. TaiKhoan_iTrangThai_GLC (Trạng Thái Tài Khoản) </summary>
        /// <returns></returns>
        public static SortedList TaiKhoan_iTrangThai_GLC()
        {
            SortedList output = new SortedList();
            output.Add(TaiKhoan_iTrangThai_C.Mo, GetTextConstants.TaiKhoan_iTrangThai_GTC(TaiKhoan_iTrangThai_C.Mo));
            output.Add(TaiKhoan_iTrangThai_C.Xem_Xet, GetTextConstants.TaiKhoan_iTrangThai_GTC(TaiKhoan_iTrangThai_C.Xem_Xet));
            output.Add(TaiKhoan_iTrangThai_C.Khoa, GetTextConstants.TaiKhoan_iTrangThai_GTC(TaiKhoan_iTrangThai_C.Khoa));
            return output;
        }

        /// <summary> I.2. TaiKhoan_iQuyenHan_GLC (Quyền Hạn Tài Khoản) </summary>
        /// <returns></returns>
        public static SortedList TaiKhoan_iQuyenHan_GLC()
        {
            SortedList output = new SortedList();
            output.Add(TaiKhoan_iQuyenHan_C.QuanTri, GetTextConstants.TaiKhoan_iQuyenHan_GTC(TaiKhoan_iQuyenHan_C.QuanTri));
            output.Add(TaiKhoan_iQuyenHan_C.Nhan_Vien, GetTextConstants.TaiKhoan_iQuyenHan_GTC(TaiKhoan_iQuyenHan_C.Nhan_Vien));
            output.Add(TaiKhoan_iQuyenHan_C.Khach_Hang, GetTextConstants.TaiKhoan_iQuyenHan_GTC(TaiKhoan_iQuyenHan_C.Khach_Hang));
            return output;
        }

        /// <summary> I.11. ThanhToan_iTrangThai_GLC (Trạng Thái Thanh Toán) </summary>
        /// <returns></returns>
        public static SortedList ThanhToan_iTrangThai_GLC()
        {
            SortedList output = new SortedList();
            output.Add(ThanhToan_iTrangThai_C.Mo, GetTextConstants.ThanhToan_iTrangThai_GTC(ThanhToan_iTrangThai_C.Mo));
            output.Add(ThanhToan_iTrangThai_C.Xem_Xet, GetTextConstants.ThanhToan_iTrangThai_GTC(ThanhToan_iTrangThai_C.Xem_Xet));
            output.Add(ThanhToan_iTrangThai_C.Khoa, GetTextConstants.ThanhToan_iTrangThai_GTC(ThanhToan_iTrangThai_C.Khoa));
            return output;
        }
        #endregion
    }
}