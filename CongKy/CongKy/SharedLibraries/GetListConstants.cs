using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using CongKy.SharedLibraries.Constants;

namespace CongKy.SharedLibraries
{
    public class GetListConstants
    {
        #region "I. Constants - GetTextConstants - GetListConstants"

        /// <summary> I.5.  ChiTietGiaoTrinh_iTrangThai_GLC (Trạng Thái Chi Tiết Giáo Trình) </summary>
        /// <returns></returns>
        public static SortedList ChiTietGiaoTrinh_iTrangThai_GLC()
        {
            SortedList output = new SortedList();
            output.Add(ChiTietGiaoTrinh_iTrangThai_C.Mo, GetTextConstants.ChiTietGiaoTrinh_iTrangThai_GTC(ChiTietGiaoTrinh_iTrangThai_C.Mo));
            output.Add(ChiTietGiaoTrinh_iTrangThai_C.Khoa, GetTextConstants.ChiTietGiaoTrinh_iTrangThai_GTC(ChiTietGiaoTrinh_iTrangThai_C.Khoa));
            return output;
        }

        /// <summary> I.5.  ChiTietGiaoTrinh_iType_GLC (Loại Chi Tiết Giáo Trình) </summary>
        /// <returns></returns>
        public static SortedList ChiTietGiaoTrinh_iType_GLC()
        {
            SortedList output = new SortedList();
            output.Add(ChiTietGiaoTrinh_iType_C.Video, GetTextConstants.ChiTietGiaoTrinh_iType_GTC(ChiTietGiaoTrinh_iType_C.Video));
            output.Add(ChiTietGiaoTrinh_iType_C.Ebook, GetTextConstants.ChiTietGiaoTrinh_iType_GTC(ChiTietGiaoTrinh_iType_C.Ebook));
            output.Add(ChiTietGiaoTrinh_iType_C.Software, GetTextConstants.ChiTietGiaoTrinh_iType_GTC(ChiTietGiaoTrinh_iType_C.Software));
            output.Add(ChiTietGiaoTrinh_iType_C.Other, GetTextConstants.ChiTietGiaoTrinh_iType_GTC(ChiTietGiaoTrinh_iType_C.Other));
            return output;
        }

        /// <summary> I.7. DangKyDayHoc_iTrangThai_GLC (Trạng Thái Dăng ký dạy học) </summary>
        /// <returns></returns>
        public static SortedList DangKyDayHoc_iTrangThai_GLC()
        {
            SortedList output = new SortedList();
            output.Add(DangKyDayHoc_iTrangThai_C.Mo, GetTextConstants.DangKyDayHoc_iTrangThai_GTC(DangKyDayHoc_iTrangThai_C.Mo));
            output.Add(DangKyDayHoc_iTrangThai_C.Khoa, GetTextConstants.DangKyDayHoc_iTrangThai_GTC(DangKyDayHoc_iTrangThai_C.Khoa));
            return output;
        }

        /// <summary> I.8. MonHoc_iTrangThai_GLC (Trạng Thái môn học) </summary>
        /// <returns></returns>
        public static SortedList MonHoc_iTrangThai_GLC()
        {
            SortedList output = new SortedList();
            output.Add(MonHoc_iTrangThai_C.Mo, GetTextConstants.MonHoc_iTrangThai_GTC(MonHoc_iTrangThai_C.Mo));
            output.Add(MonHoc_iTrangThai_C.Khoa, GetTextConstants.MonHoc_iTrangThai_GTC(MonHoc_iTrangThai_C.Khoa));
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