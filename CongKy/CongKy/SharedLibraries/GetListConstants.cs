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
            output.Add(ChiTietGiaoTrinh_iType_C.Pdf, GetTextConstants.ChiTietGiaoTrinh_iType_GTC(ChiTietGiaoTrinh_iType_C.Pdf));
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
            output.Add(TaiKhoan_iQuyenHan_C.GiangVien, GetTextConstants.TaiKhoan_iQuyenHan_GTC(TaiKhoan_iQuyenHan_C.GiangVien));
            output.Add(TaiKhoan_iQuyenHan_C.Sinh_Vien, GetTextConstants.TaiKhoan_iQuyenHan_GTC(TaiKhoan_iQuyenHan_C.Sinh_Vien));
            return output;
        }
        #endregion
    }
}