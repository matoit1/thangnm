using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HaBa.SharedLibraries.Constants
{
    #region "I. Sinh Viên"
    /// <summary> I.7. NhomSanPham_iTrangThai_C (Trạng Thái Nhóm Sản Phẩm) </summary>
    /// 
    public class NhomSanPham_iTrangThai_C
    {
        public const Int16 Mo = 1;
        public const Int16 Khoa = 2;
    }

    /// <summary> I.8. SanPham_iTrangThai_C (Đoàn thanh niên cộng sản Hồ Chí Minh) </summary>
    /// 
    public class SanPham_iTrangThai_C
    {
        public const Int16 Mo = 1;
        public const Int16 Het_Hang = 2;
        public const Int16 Khoa = 3;

    }

    /// <summary> I.9. SanPham_iDoTuoi_C (Quan hệ với người liên hệ) </summary>
    /// 
    public class SanPham_iDoTuoi_C
    {
        public const Int16 Loai1 = 1;
        public const Int16 Loai2 = 2;
        public const Int16 Loai3 = 3;
        public const Int16 Loai4 = 4;
        public const Int16 Loai5 = 5;
    }

    /// <summary> I.10 SanPham_iGioiTinh_C (Hệ số tính điểm) </summary>
    /// 
    public class SanPham_iGioiTinh_C
    {
        public const Int16 Nam = 1;
        public const Int16 Nu = 2;
        public const Int16 Nam_Nu = 3;
    }

    /// <summary> I.11. Xep_Loai_Ket_Qua_Hoc_Tap_C (Xếp loại kết quả học tập) </summary>
    /// 
    public class Xep_Loai_Ket_Qua_Hoc_Tap_C
    {
        public const Int16 Xuat_Sac = 9;
        public const Int16 Gioi = 8;
        public const Int16 Kha = 7;
        public const Int16 Trung_Binh_Kha = 6;
        public const Int16 Trung_Binh = 5;
        public const Int16 Yeu = 4;
        public const Int16 Kem = 3;
    }

    /// <summary> I.12. Tinh_Diem_Chuyen_Can_C (Tính điểm chuyên cần) </summary>
    /// 
    public class Tinh_Diem_Chuyen_Can_C
    {
        public const Int16 Mot_Buoi = 1;
        public const Int16 Hai_Buoi = 2;
        public const Int16 Ba_Buoi = 3;
        public const Int16 Bon_Buoi = 4;
        public const Int16 Nam_Buoi = 5;
    }
    #endregion


    #region "II. Giảng Viên"
    /// <summary> I.2. GiangVien_iHocViGV_C (Học vị) </summary>
    /// 
    public class GiangVien_iHocViGV_C
    {
        public const Int16 Tu_Tai = 1;
        public const Int16 Cu_Nhan = 2;
        public const Int16 Ky_Su = 3;
        public const Int16 Thac_Si = 4;
        public const Int16 Tien_Si = 5;
        public const Int16 Tien_Si_Khoa_Hoc = 6;
    }

    /// <summary> I.5. GiangVien_bCongChucGV_C (Công Chức) </summary>
    /// 
    public class GiangVien_bCongChucGV_C
    {
        public const Boolean Da_Co_Cong_Chuc = true;
        public const Boolean Chua_Co_Cong_Chuc = false;
    }

    /// <summary> I.6. GiangVien_iTrangThaiGV_C (Trạng Thái Giáo Viên) </summary>
    /// 
    public class GiangVien_iTrangThaiGV_C
    {
        public const Int16 Dang_Cong_Tac = 1;
        public const Int16 Chuyen_Cong_Tac = 2;
        public const Int16 Nghi_Che_Do = 3;
        public const Int16 Nghi_Phep = 4;
        public const Int16 Tam_Dinh_Chi_Cong_Tac = 5;
        public const Int16 Nghi_Huu = 6;
        public const Int16 Bo_Viec = 7;
    }

    /// <summary> I.13. GiangVien_iChucVuGV_C (Chức vụ) </summary>
    /// 
    public class GiangVien_iChucVuGV_C
    {
        public const Int16 Vien_Truong = 1;
        public const Int16 Pho_Vien_Truong = 2;
        public const Int16 Truong_Khoa = 3;
        public const Int16 Pho_Khoa = 4;
        public const Int16 Truong_Phong_Dao_Tao = 5;
        public const Int16 Pho_Phong_Dao_Tao = 6;
        public const Int16 Van_Thu = 7;
        public const Int16 Truong_Bo_Mon_Mang = 50;
        public const Int16 Truong_Bo_Mon_Mobile = 51;
        public const Int16 Truong_Bo_Mon_Web = 52;
        public const Int16 Truong_Bo_Mon_Do_Hoa = 53;
        public const Int16 Truong_Bo_Mon_Bao_Tri = 54;
        public const Int16 Can_Bo_Nhan_Vien_Nha_Truong = 55;
    }
    #endregion


    #region "III. Khác"
    /// <summary> I.1. Quyen_Han_C (Quyền hạn)</summary>
    /// 
    public class Quyen_Han_C
    {
        public const Int16 Quan_Tri_Vien = 1;
        public const Int16 Giang_Vien = 2;
        public const Int16 Sinh_Vien = 3;
        public const Int16 Nhan_Vien = 4;
        public const Int16 Khach = 5;
        public const Int16 An_Danh = 6;
    }

    /// <summary> I.3. Gioi_Tinh_C (Giới tính) </summary>
    /// 
    public class Gioi_Tinh_C
    {
        public const Boolean Nam = true;
        public const Boolean Nu = false;
    }

    /// <summary> I.4. Hon_Nhan_C (Hôn Nhân) </summary>
    /// 
    public class Hon_Nhan_C
    {
        public const Boolean Da_Ket_Hon = true;
        public const Boolean Chua_Ket_Hon = false;
    }
    #endregion   


    /// <summary> II.2. LichDayVaHoc_iCaHoc_C (Ca học) </summary>
    /// 
    public class LichDayVaHoc_iCaHoc_C
    {
        public const Int16 Sang = 1;
        public const Int16 Chieu = 2;
        public const Int16 Toi = 3;
    }



    #region "II. Trạng Thái"
    /// <summary> II.1. BaiViet_iTrangThai_C (Trạng thái sửa lỗi) </summary>
    /// 
    public class BaiViet_iTrangThai_C
    {
        public const Int16 Cho_Xem_Xet = 1;
        public const Int16 Da_Kiem_Duyet = 2;
        public const Int16 Tam_Khoa = 3;
        public const Int16 Khoa = 4;
    }

    /// <summary> II.2. CauHoi_iTrangThai_C (Trạng thái sửa lỗi) </summary>
    /// 
    public class CauHoi_iTrangThai_C
    {
        public const Int16 Cho_Xem_Xet = 1;
        public const Int16 Da_Kiem_Duyet = 2;
        public const Int16 Tam_Khoa = 3;
        public const Int16 Khoa = 4;
    }

    /// <summary> II.3. DiemThi_iTrangThai_C (Trạng thái sửa lỗi) </summary>
    /// 
    public class DiemThi_iTrangThai_C
    {
        public const Int16 Binh_Thuong = 1;
        public const Int16 Phuc_Khao = 2;
        public const Int16 Huy_Ket_Qua = 3;
    }

    /// <summary> II.4. Error_iStatus_C (Trạng thái sửa lỗi) </summary>
    /// 
    public class Error_iStatus_C
    {
        public const Int16 Da_Phat_Hien = 1;
        public const Int16 Da_Xem = 2;
        public const Int16 Dang_Sua = 3;
        public const Int16 Da_Sua = 4;
        public const Int16 Cho_Kiem_Tra_Lai = 5;
    }

    /// <summary> II.6. LichDayVaHoc_iTrangThai_C (Trạng thái sửa lỗi) </summary>
    /// 
    public class LichDayVaHoc_iTrangThai_C
    {
        public const Int16 Hoc = 1;
        public const Int16 Day_Offline = 2;
        public const Int16 Hoc_Bu = 3;
        public const Int16 Nghi = 4;
        public const Int16 Thi = 5;
        public const Int16 Kiem_Tra_Giua_Ky = 6;
    }

    /// <summary> II.7. LopHoc_iTrangThai_C (Trạng thái sửa lỗi) </summary>
    /// 
    public class LopHoc_iTrangThai_C
    {
        public const Int16 Binh_Thuong = 1;
        public const Int16 Tach_Lop = 2;
        public const Int16 Gop_Lop = 3;
        public const Int16 Huy_Lop = 4;
    }

    /// <summary> II.8. MonHoc_iTrangThai_C (Trạng thái sửa lỗi) </summary>
    /// 
    public class MonHoc_iTrangThai_C
    {
        public const Int16 Mo = 1;
        public const Int16 Tam_Khoa = 2;
        public const Int16 Khoa = 3;
    }

    /// <summary> II.9. PhanCongCongTac_iTrangThai_C (Trạng thái sửa lỗi) </summary>
    /// 
    public class PhanCongCongTac_iTrangThai_C
    {
        public const Int16 Binh_Thuong = 1;
        public const Int16 Chuyen_GV = 2;
        public const Int16 Huy = 3;
        public const Int16 Hoc_Lai = 4;
        public const Int16 Hoc_Xong = 5;
    }
    #endregion


    #region "II. Định dạng"
    /// <summary> II.1. DateTimeFomat (Định dạng ngày giờ) </summary>
    /// 
    public class DateTimeFomat
    {
        public const string DISPLAY_DATE_FORMAT = "dd/MM/yyyy";
        public const string DISPLAY_DATETIME_FORMAT = "dd/MM/yyyy HH:mm";
    }

    /// <summary> II.2. NumberFomat (Định dạng số) </summary>
    /// 
    public class NumberFomat
    {
        public const string DISPLAY_NUMBER = "###,##0.######";
    }
    #endregion
}