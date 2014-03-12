using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using Shared_Libraries.Constants;

namespace Shared_Libraries
{
    public class GetListConstants
    {
        #region "I. Constants - GetTextConstants - GetListConstants"
        /// <summary> I.1. Quyen_Han_GLC (Quyền hạn) </summary>
        /// <returns></returns>
        public static SortedList Quyen_Han_GLC()
        {
            SortedList output = new SortedList();
            output.Add(Hoc_Vi_C.Tu_Tai, GetTextConstants.Hoc_Vi_GTC(Hoc_Vi_C.Tu_Tai));
            output.Add(Hoc_Vi_C.Cu_Nhan, GetTextConstants.Hoc_Vi_GTC(Hoc_Vi_C.Cu_Nhan));
            output.Add(Hoc_Vi_C.Ky_Su, GetTextConstants.Hoc_Vi_GTC(Hoc_Vi_C.Ky_Su));
            output.Add(Hoc_Vi_C.Thac_Si, GetTextConstants.Hoc_Vi_GTC(Hoc_Vi_C.Thac_Si));
            output.Add(Hoc_Vi_C.Tien_Si, GetTextConstants.Hoc_Vi_GTC(Hoc_Vi_C.Tien_Si));
            output.Add(Hoc_Vi_C.Tien_Si_Khoa_Hoc, GetTextConstants.Hoc_Vi_GTC(Hoc_Vi_C.Tien_Si_Khoa_Hoc));
            return output;
        }

        /// <summary> I.2. Hoc_Vi_GLC (Học vị) </summary>
        /// <returns></returns>
        public static SortedList Hoc_Vi_GLC()
        {
            SortedList output = new SortedList();
            output.Add(Hoc_Vi_C.Tu_Tai, GetTextConstants.Hoc_Vi_GTC(Hoc_Vi_C.Tu_Tai));
            output.Add(Hoc_Vi_C.Cu_Nhan, GetTextConstants.Hoc_Vi_GTC(Hoc_Vi_C.Cu_Nhan));
            output.Add(Hoc_Vi_C.Ky_Su, GetTextConstants.Hoc_Vi_GTC(Hoc_Vi_C.Ky_Su));
            output.Add(Hoc_Vi_C.Thac_Si, GetTextConstants.Hoc_Vi_GTC(Hoc_Vi_C.Thac_Si));
            output.Add(Hoc_Vi_C.Tien_Si, GetTextConstants.Hoc_Vi_GTC(Hoc_Vi_C.Tien_Si));
            output.Add(Hoc_Vi_C.Tien_Si_Khoa_Hoc, GetTextConstants.Hoc_Vi_GTC(Hoc_Vi_C.Tien_Si_Khoa_Hoc));
            return output;
        }

        /// <summary> I.3. Gioi_Tinh_GLC (Giới tính) </summary>
        /// <returns></returns>
        public static SortedList Gioi_Tinh_GLC()
        {
            SortedList output = new SortedList();
            output.Add(Gioi_Tinh_C.Nam, GetTextConstants.Gioi_Tinh_GTC(Gioi_Tinh_C.Nam));
            output.Add(Gioi_Tinh_C.Nu, GetTextConstants.Gioi_Tinh_GTC(Gioi_Tinh_C.Nu));
            return output;
        }

        /// <summary> I.4. Hon_Nhan_GLC (Hôn Nhân) </summary>
        /// <returns></returns>
        public static SortedList Hon_Nhan_GLC()
        {
            SortedList output = new SortedList();
            output.Add(Hon_Nhan_C.Da_Ket_Hon, GetTextConstants.Hon_Nhan_GTC(Hon_Nhan_C.Da_Ket_Hon));
            output.Add(Hon_Nhan_C.Chua_Ket_Hon, GetTextConstants.Hon_Nhan_GTC(Hon_Nhan_C.Chua_Ket_Hon));
            return output;
        }

        /// <summary> I.5. Cong_Chuc_GLC (Công Chức) </summary>
        /// <returns></returns>
        public static SortedList Cong_Chuc_GLC()
        {
            SortedList output = new SortedList();
            output.Add(Cong_Chuc_C.Da_Co_Cong_Chuc, GetTextConstants.Cong_Chuc_GTC(Cong_Chuc_C.Da_Co_Cong_Chuc));
            output.Add(Cong_Chuc_C.Chua_Co_Cong_Chuc, GetTextConstants.Cong_Chuc_GTC(Cong_Chuc_C.Chua_Co_Cong_Chuc));
            return output;
        }

        /// <summary> I.6. Trang_Thai_Giao_Vien_GLC (Trạng Thái Giáo Viên) </summary>
        /// <returns></returns>
        public static SortedList Trang_Thai_Giao_Vien_GLC()
        {
            SortedList output = new SortedList();
            output.Add(Trang_Thai_Giao_Vien_C.Chuyen_Cong_Tac, GetTextConstants.Trang_Thai_Giao_Vien_GTC(Trang_Thai_Giao_Vien_C.Chuyen_Cong_Tac));
            output.Add(Trang_Thai_Giao_Vien_C.Nghi_Che_Do, GetTextConstants.Trang_Thai_Giao_Vien_GTC(Trang_Thai_Giao_Vien_C.Nghi_Che_Do));
            output.Add(Trang_Thai_Giao_Vien_C.Nghi_Phep, GetTextConstants.Trang_Thai_Giao_Vien_GTC(Trang_Thai_Giao_Vien_C.Nghi_Phep));
            output.Add(Trang_Thai_Giao_Vien_C.Tam_Dinh_Chi_Cong_Tac, GetTextConstants.Trang_Thai_Giao_Vien_GTC(Trang_Thai_Giao_Vien_C.Tam_Dinh_Chi_Cong_Tac));
            output.Add(Trang_Thai_Giao_Vien_C.Nghi_Huu, GetTextConstants.Trang_Thai_Giao_Vien_GTC(Trang_Thai_Giao_Vien_C.Nghi_Huu));
            output.Add(Trang_Thai_Giao_Vien_C.Bo_Viec, GetTextConstants.Trang_Thai_Giao_Vien_GTC(Trang_Thai_Giao_Vien_C.Bo_Viec));
            return output;
        }

        /// <summary> I.7. Trang_Thai_Sinh_Vien_GLC (Trạng Thái Sinh Viên) </summary>
        /// <returns></returns>
        public static SortedList Trang_Thai_Sinh_Vien_GLC()
        {
            SortedList output = new SortedList();
            output.Add(Trang_Thai_Sinh_Vien_C.Chuyen_Truong, GetTextConstants.Trang_Thai_Giao_Vien_GTC(Trang_Thai_Sinh_Vien_C.Chuyen_Truong));
            output.Add(Trang_Thai_Sinh_Vien_C.Chuyen_Lop, GetTextConstants.Trang_Thai_Giao_Vien_GTC(Trang_Thai_Sinh_Vien_C.Chuyen_Lop));
            output.Add(Trang_Thai_Sinh_Vien_C.Bao_Luu_Ket_Qua, GetTextConstants.Trang_Thai_Giao_Vien_GTC(Trang_Thai_Sinh_Vien_C.Bao_Luu_Ket_Qua));
            output.Add(Trang_Thai_Sinh_Vien_C.Bo_Hoc, GetTextConstants.Trang_Thai_Giao_Vien_GTC(Trang_Thai_Sinh_Vien_C.Bo_Hoc));
            output.Add(Trang_Thai_Sinh_Vien_C.Luu_Ban, GetTextConstants.Trang_Thai_Giao_Vien_GTC(Trang_Thai_Sinh_Vien_C.Luu_Ban));
            output.Add(Trang_Thai_Sinh_Vien_C.Duoi_Hoc, GetTextConstants.Trang_Thai_Giao_Vien_GTC(Trang_Thai_Sinh_Vien_C.Duoi_Hoc));
            return output;
        }

        /// <summary> I.8. Doan_Thanh_Nien_Cong_San_HCM_GLC (Đoàn thanh niên cộng sản Hồ Chí Minh) </summary>
        /// <returns></returns>
        public static SortedList Doan_Thanh_Nien_Cong_San_HCM_GLC()
        {
            SortedList output = new SortedList();
            output.Add(Doan_Thanh_Nien_Cong_San_HCM_C.Da_Vao_Doan, GetTextConstants.Doan_Thanh_Nien_Cong_San_HCM_GTC(Doan_Thanh_Nien_Cong_San_HCM_C.Da_Vao_Doan));
            output.Add(Doan_Thanh_Nien_Cong_San_HCM_C.Chua_Vao_Doan, GetTextConstants.Doan_Thanh_Nien_Cong_San_HCM_GTC(Doan_Thanh_Nien_Cong_San_HCM_C.Chua_Vao_Doan));
            return output;
        }

        /// <summary> I.9. Quan_He_Voi_Nguoi_Lien_He_GLC (Quan hệ với người liên hệ) </summary>
        /// <returns></returns>
        public static SortedList Quan_He_Voi_Nguoi_Lien_He_GLC()
        {
            SortedList output = new SortedList();
            output.Add(Quan_He_Voi_Nguoi_Lien_He_C.Bo, GetTextConstants.Quan_He_Voi_Nguoi_Lien_He_GTC(Quan_He_Voi_Nguoi_Lien_He_C.Bo));
            output.Add(Quan_He_Voi_Nguoi_Lien_He_C.Me, GetTextConstants.Quan_He_Voi_Nguoi_Lien_He_GTC(Quan_He_Voi_Nguoi_Lien_He_C.Me));
            output.Add(Quan_He_Voi_Nguoi_Lien_He_C.Anh, GetTextConstants.Quan_He_Voi_Nguoi_Lien_He_GTC(Quan_He_Voi_Nguoi_Lien_He_C.Anh));
            output.Add(Quan_He_Voi_Nguoi_Lien_He_C.Chi, GetTextConstants.Quan_He_Voi_Nguoi_Lien_He_GTC(Quan_He_Voi_Nguoi_Lien_He_C.Chi));
            output.Add(Quan_He_Voi_Nguoi_Lien_He_C.Bac, GetTextConstants.Quan_He_Voi_Nguoi_Lien_He_GTC(Quan_He_Voi_Nguoi_Lien_He_C.Bac));
            output.Add(Quan_He_Voi_Nguoi_Lien_He_C.Chu, GetTextConstants.Quan_He_Voi_Nguoi_Lien_He_GTC(Quan_He_Voi_Nguoi_Lien_He_C.Chu));
            output.Add(Quan_He_Voi_Nguoi_Lien_He_C.Co, GetTextConstants.Quan_He_Voi_Nguoi_Lien_He_GTC(Quan_He_Voi_Nguoi_Lien_He_C.Co));
            output.Add(Quan_He_Voi_Nguoi_Lien_He_C.Di, GetTextConstants.Quan_He_Voi_Nguoi_Lien_He_GTC(Quan_He_Voi_Nguoi_Lien_He_C.Di));
            output.Add(Quan_He_Voi_Nguoi_Lien_He_C.Khac, GetTextConstants.Quan_He_Voi_Nguoi_Lien_He_GTC(Quan_He_Voi_Nguoi_Lien_He_C.Khac));
            return output;
        }

        /// <summary> I.10 He_So_Tinh_Diem_GLC (Hệ số tính điểm) </summary>
        /// <returns></returns>
        public static SortedList He_So_Tinh_Diem_GLC()
        {
            SortedList output = new SortedList();
            output.Add(He_So_Tinh_Diem_C.Diem_Chuyen_Can, GetTextConstants.He_So_Tinh_Diem_GTC(He_So_Tinh_Diem_C.Diem_Chuyen_Can));
            output.Add(He_So_Tinh_Diem_C.Diem_Giua_Ky, GetTextConstants.He_So_Tinh_Diem_GTC(He_So_Tinh_Diem_C.Diem_Giua_Ky));
            output.Add(He_So_Tinh_Diem_C.Diem_Thi, GetTextConstants.He_So_Tinh_Diem_GTC(He_So_Tinh_Diem_C.Diem_Thi));
            return output;
        }

        /// <summary> I.11. Xep_Loai_Ket_Qua_Hoc_Tap_GLC (Xếp loại kết quả học tập) </summary>
        /// <returns></returns>
        public static SortedList Xep_Loai_Ket_Qua_Hoc_Tap_GLC()
        {
            SortedList output = new SortedList();
            output.Add(Xep_Loai_Ket_Qua_Hoc_Tap_C.Xuat_Sac, GetTextConstants.Xep_Loai_Ket_Qua_Hoc_Tap_GTC(Xep_Loai_Ket_Qua_Hoc_Tap_C.Xuat_Sac));
            output.Add(Xep_Loai_Ket_Qua_Hoc_Tap_C.Gioi, GetTextConstants.Xep_Loai_Ket_Qua_Hoc_Tap_GTC(Xep_Loai_Ket_Qua_Hoc_Tap_C.Gioi));
            output.Add(Xep_Loai_Ket_Qua_Hoc_Tap_C.Kha, GetTextConstants.Xep_Loai_Ket_Qua_Hoc_Tap_GTC(Xep_Loai_Ket_Qua_Hoc_Tap_C.Kha));
            output.Add(Xep_Loai_Ket_Qua_Hoc_Tap_C.Trung_Binh_Kha, GetTextConstants.Xep_Loai_Ket_Qua_Hoc_Tap_GTC(Xep_Loai_Ket_Qua_Hoc_Tap_C.Trung_Binh_Kha));
            output.Add(Xep_Loai_Ket_Qua_Hoc_Tap_C.Trung_Binh, GetTextConstants.Xep_Loai_Ket_Qua_Hoc_Tap_GTC(Xep_Loai_Ket_Qua_Hoc_Tap_C.Trung_Binh));
            output.Add(Xep_Loai_Ket_Qua_Hoc_Tap_C.Yeu, GetTextConstants.Xep_Loai_Ket_Qua_Hoc_Tap_GTC(Xep_Loai_Ket_Qua_Hoc_Tap_C.Yeu));
            output.Add(Xep_Loai_Ket_Qua_Hoc_Tap_C.Kem, GetTextConstants.Xep_Loai_Ket_Qua_Hoc_Tap_GTC(Xep_Loai_Ket_Qua_Hoc_Tap_C.Kem));
            return output;
        }

        /// <summary>  I.12. Tinh_Diem_Chuyen_Can_GLC (Tính điểm chuyên cần) </summary>
        /// <returns></returns>
        public static SortedList Tinh_Diem_Chuyen_Can_GLC()
        {
            SortedList output = new SortedList();
            output.Add(Tinh_Diem_Chuyen_Can_C.Mot_Buoi, GetTextConstants.Tinh_Diem_Chuyen_Can_GTC(Tinh_Diem_Chuyen_Can_C.Mot_Buoi));
            output.Add(Tinh_Diem_Chuyen_Can_C.Hai_Buoi, GetTextConstants.Tinh_Diem_Chuyen_Can_GTC(Tinh_Diem_Chuyen_Can_C.Hai_Buoi));
            output.Add(Tinh_Diem_Chuyen_Can_C.Ba_Buoi, GetTextConstants.Tinh_Diem_Chuyen_Can_GTC(Tinh_Diem_Chuyen_Can_C.Ba_Buoi));
            output.Add(Tinh_Diem_Chuyen_Can_C.Bon_Buoi, GetTextConstants.Tinh_Diem_Chuyen_Can_GTC(Tinh_Diem_Chuyen_Can_C.Bon_Buoi));
            output.Add(Tinh_Diem_Chuyen_Can_C.Nam_Buoi, GetTextConstants.Tinh_Diem_Chuyen_Can_GTC(Tinh_Diem_Chuyen_Can_C.Nam_Buoi));
            return output;
        }

        /// <summary> I.13. Chuc_Vu_GLC (Chức vụ) </summary>
        /// <returns></returns>
        public static SortedList Chuc_Vu_GLC()
        {
            SortedList output = new SortedList();
            output.Add(Chuc_Vu_C.Vien_Truong, GetTextConstants.Chuc_Vu_GTC(Chuc_Vu_C.Vien_Truong));
            output.Add(Chuc_Vu_C.Pho_Vien_Truong, GetTextConstants.Chuc_Vu_GTC(Chuc_Vu_C.Pho_Vien_Truong));
            output.Add(Chuc_Vu_C.Truong_Khoa, GetTextConstants.Chuc_Vu_GTC(Chuc_Vu_C.Truong_Khoa));
            output.Add(Chuc_Vu_C.Pho_Khoa, GetTextConstants.Chuc_Vu_GTC(Chuc_Vu_C.Pho_Khoa));
            output.Add(Chuc_Vu_C.Truong_Phong_Dao_Tao, GetTextConstants.Chuc_Vu_GTC(Chuc_Vu_C.Truong_Phong_Dao_Tao));
            output.Add(Chuc_Vu_C.Pho_Phong_Dao_Tao, GetTextConstants.Chuc_Vu_GTC(Chuc_Vu_C.Pho_Phong_Dao_Tao));
            output.Add(Chuc_Vu_C.Van_Thu, GetTextConstants.Chuc_Vu_GTC(Chuc_Vu_C.Van_Thu));
            output.Add(Chuc_Vu_C.Truong_Bo_Mon_Mang, GetTextConstants.Chuc_Vu_GTC(Chuc_Vu_C.Truong_Bo_Mon_Mang));
            output.Add(Chuc_Vu_C.Truong_Bo_Mon_Mobile, GetTextConstants.Chuc_Vu_GTC(Chuc_Vu_C.Truong_Bo_Mon_Mobile));
            output.Add(Chuc_Vu_C.Truong_Bo_Mon_Web, GetTextConstants.Chuc_Vu_GTC(Chuc_Vu_C.Truong_Bo_Mon_Web));
            output.Add(Chuc_Vu_C.Truong_Bo_Mon_Do_Hoa, GetTextConstants.Chuc_Vu_GTC(Chuc_Vu_C.Truong_Bo_Mon_Do_Hoa));
            output.Add(Chuc_Vu_C.Truong_Bo_Mon_Bao_Tri, GetTextConstants.Chuc_Vu_GTC(Chuc_Vu_C.Truong_Bo_Mon_Bao_Tri));
            output.Add(Chuc_Vu_C.Can_Bo_Nhan_Vien_Nha_Truong, GetTextConstants.Chuc_Vu_GTC(Chuc_Vu_C.Can_Bo_Nhan_Vien_Nha_Truong));
            return output;
        }
        #endregion
    }
}