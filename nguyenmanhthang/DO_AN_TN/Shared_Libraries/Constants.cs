using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shared_Libraries.Constants
{
    #region "I. Constants - GetTextConstants - GetListConstants"
    /// <summary> I.1. Quyen_Han_C (Quyền hạn)</summary>
    /// 
    public class Quyen_Han_C
    {
        public const Int16 Khach = 0;
        public const Int16 Quan_Tri_Vien = 1;
        public const Int16 Giang_Vien = 2;
        public const Int16 Sinh_Vien = 3;
        public const Int16 Nhan_Vien = 4;
        public const Int16 An_Danh = 5;
    }    

    /// <summary> I.2. Hoc_Vi_C (Học vị) </summary>
    /// 
    public class Hoc_Vi_C
    {
        public const Int16 Tu_Tai = 1;
        public const Int16 Cu_Nhan = 2;
        public const Int16 Ky_Su = 3;
        public const Int16 Thac_Si = 4;
        public const Int16 Tien_Si = 5;
        public const Int16 Tien_Si_Khoa_Hoc = 6;
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

    /// <summary> I.5. Cong_Chuc_C (Công Chức) </summary>
    /// 
    public class Cong_Chuc_C
    {
        public const Boolean Da_Co_Cong_Chuc = true;
        public const Boolean Chua_Co_Cong_Chuc = false;
    }

    /// <summary> I.6. Trang_Thai_Giao_Vien_C (Trạng Thái Giáo Viên) </summary>
    /// 
    public class Trang_Thai_Giao_Vien_C
    {
        public const Int16 Chuyen_Cong_Tac = 1;
        public const Int16 Nghi_Che_Do = 2;
        public const Int16 Nghi_Phep = 3;
        public const Int16 Tam_Dinh_Chi_Cong_Tac = 4;
        public const Int16 Nghi_Huu = 5;
        public const Int16 Bo_Viec = 6;
    }

    /// <summary> I.7. Trang_Thai_Sinh_Vien_C (Trạng Thái Sinh Viên) </summary>
    /// 
    public class Trang_Thai_Sinh_Vien_C
    {
        public const Int16 Chuyen_Truong = 1;
        public const Int16 Chuyen_Lop = 2;
        public const Int16 Bao_Luu_Ket_Qua = 3;
        public const Int16 Bo_Hoc = 4;
        public const Int16 Luu_Ban = 5;
        public const Int16 Duoi_Hoc = 6;
    }

    /// <summary> I.8. Doan_Thanh_Nien_Cong_San_HCM_C (Đoàn thanh niên cộng sản Hồ Chí Minh) </summary>
    /// 
    public class Doan_Thanh_Nien_Cong_San_HCM_C
    {
        public const Boolean Da_Vao_Doan = true;
        public const Boolean Chua_Vao_Doan = false;
    }

    /// <summary> I.9. Quan_He_Voi_Nguoi_Lien_He_C (Quan hệ với người liên hệ) </summary>
    /// 
    public class Quan_He_Voi_Nguoi_Lien_He_C
    {
        public const Int16 Bo = 1;
        public const Int16 Me = 2;
        public const Int16 Anh = 3;
        public const Int16 Chi = 4;
        public const Int16 Bac = 5;
        public const Int16 Chu = 6;
        public const Int16 Co = 7;
        public const Int16 Di = 8;
        public const Int16 Khac = 9;
    }

    /// <summary> I.10 He_So_Tinh_Diem_C (Hệ số tính điểm) </summary>
    /// 
    public class He_So_Tinh_Diem_C
    {
        public const double Diem_Chuyen_Can = 0.1;
        public const double Diem_Giua_Ky = 0.2;
        public const double Diem_Thi = 0.7;
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



    /// <summary> I.13. Chuc_Vu_C (Chức vụ) </summary>
    /// 
    public class Chuc_Vu_C
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

    /// <summary> II.1. ErrorStatus_C (Trạng thái sửa lỗi) </summary>
    /// 
    public class ErrorStatus_C
    {
        public const Int16 Da_Phat_Hien = 1;
        public const Int16 Da_Xem = 2;
        public const Int16 Dang_Sua = 3;
        public const Int16 Da_Sua = 4;
        public const Int16 Cho_Kiem_Tra_Lai = 5;
    }
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