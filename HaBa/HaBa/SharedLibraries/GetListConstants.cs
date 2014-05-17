using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using HaBa.SharedLibraries.Constants;

namespace HaBa.SharedLibraries
{
    public class GetListConstants
    {
        #region "I. Constants - GetTextConstants - GetListConstants"
        /// <summary> I.1. Quyen_Han_GLC (Quyền hạn) </summary>
        /// <returns></returns>
        public static SortedList Quyen_Han_GLC()
        {
            SortedList output = new SortedList();
            output.Add(Quyen_Han_C.Khach, GetTextConstants.Quyen_Han_GTC(Quyen_Han_C.Khach));
            output.Add(Quyen_Han_C.Quan_Tri_Vien, GetTextConstants.Quyen_Han_GTC(Quyen_Han_C.Quan_Tri_Vien));
            output.Add(Quyen_Han_C.Giang_Vien, GetTextConstants.Quyen_Han_GTC(Quyen_Han_C.Giang_Vien));
            output.Add(Quyen_Han_C.Sinh_Vien, GetTextConstants.Quyen_Han_GTC(Quyen_Han_C.Sinh_Vien));
            output.Add(Quyen_Han_C.Nhan_Vien, GetTextConstants.Quyen_Han_GTC(Quyen_Han_C.Nhan_Vien));
            return output;
        }

        /// <summary> I.2. GiangVien_iHocViGV_GLC (Học vị) </summary>
        /// <returns></returns>
        public static SortedList GiangVien_iHocViGV_GLC()
        {
            SortedList output = new SortedList();
            output.Add(GiangVien_iHocViGV_C.Tu_Tai, GetTextConstants.GiangVien_iHocViGV_GTC(GiangVien_iHocViGV_C.Tu_Tai));
            output.Add(GiangVien_iHocViGV_C.Cu_Nhan, GetTextConstants.GiangVien_iHocViGV_GTC(GiangVien_iHocViGV_C.Cu_Nhan));
            output.Add(GiangVien_iHocViGV_C.Ky_Su, GetTextConstants.GiangVien_iHocViGV_GTC(GiangVien_iHocViGV_C.Ky_Su));
            output.Add(GiangVien_iHocViGV_C.Thac_Si, GetTextConstants.GiangVien_iHocViGV_GTC(GiangVien_iHocViGV_C.Thac_Si));
            output.Add(GiangVien_iHocViGV_C.Tien_Si, GetTextConstants.GiangVien_iHocViGV_GTC(GiangVien_iHocViGV_C.Tien_Si));
            output.Add(GiangVien_iHocViGV_C.Tien_Si_Khoa_Hoc, GetTextConstants.GiangVien_iHocViGV_GTC(GiangVien_iHocViGV_C.Tien_Si_Khoa_Hoc));
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

        /// <summary> I.5. GiangVien_bCongChucGV_GLC (Công Chức) </summary>
        /// <returns></returns>
        public static SortedList GiangVien_bCongChucGV_GLC()
        {
            SortedList output = new SortedList();
            output.Add(GiangVien_bCongChucGV_C.Da_Co_Cong_Chuc, GetTextConstants.GiangVien_bCongChucGV_GTC(GiangVien_bCongChucGV_C.Da_Co_Cong_Chuc));
            output.Add(GiangVien_bCongChucGV_C.Chua_Co_Cong_Chuc, GetTextConstants.GiangVien_bCongChucGV_GTC(GiangVien_bCongChucGV_C.Chua_Co_Cong_Chuc));
            return output;
        }

        /// <summary> I.6. GiangVien_iTrangThaiGV_GLC (Trạng Thái Giáo Viên) </summary>
        /// <returns></returns>
        public static SortedList GiangVien_iTrangThaiGV_GLC()
        {
            SortedList output = new SortedList();
            output.Add(GiangVien_iTrangThaiGV_C.Dang_Cong_Tac, GetTextConstants.GiangVien_iTrangThaiGV_GTC(GiangVien_iTrangThaiGV_C.Dang_Cong_Tac));
            output.Add(GiangVien_iTrangThaiGV_C.Chuyen_Cong_Tac, GetTextConstants.GiangVien_iTrangThaiGV_GTC(GiangVien_iTrangThaiGV_C.Chuyen_Cong_Tac));
            output.Add(GiangVien_iTrangThaiGV_C.Nghi_Che_Do, GetTextConstants.GiangVien_iTrangThaiGV_GTC(GiangVien_iTrangThaiGV_C.Nghi_Che_Do));
            output.Add(GiangVien_iTrangThaiGV_C.Nghi_Phep, GetTextConstants.GiangVien_iTrangThaiGV_GTC(GiangVien_iTrangThaiGV_C.Nghi_Phep));
            output.Add(GiangVien_iTrangThaiGV_C.Tam_Dinh_Chi_Cong_Tac, GetTextConstants.GiangVien_iTrangThaiGV_GTC(GiangVien_iTrangThaiGV_C.Tam_Dinh_Chi_Cong_Tac));
            output.Add(GiangVien_iTrangThaiGV_C.Nghi_Huu, GetTextConstants.GiangVien_iTrangThaiGV_GTC(GiangVien_iTrangThaiGV_C.Nghi_Huu));
            output.Add(GiangVien_iTrangThaiGV_C.Bo_Viec, GetTextConstants.GiangVien_iTrangThaiGV_GTC(GiangVien_iTrangThaiGV_C.Bo_Viec));
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

        /// <summary> I.8. SanPham_iTrangThai_GLC (Đoàn thanh niên cộng sản Hồ Chí Minh) </summary>
        /// <returns></returns>
        public static SortedList SanPham_iTrangThai_GLC()
        {
            SortedList output = new SortedList();
            output.Add(SanPham_iTrangThai_C.Mo, GetTextConstants.SanPham_iTrangThai_GTC(SanPham_iTrangThai_C.Mo));
            output.Add(SanPham_iTrangThai_C.Het_Hang, GetTextConstants.SanPham_iTrangThai_GTC(SanPham_iTrangThai_C.Het_Hang));
            output.Add(SanPham_iTrangThai_C.Khoa, GetTextConstants.SanPham_iTrangThai_GTC(SanPham_iTrangThai_C.Khoa));
            return output;
        }

        /// <summary> I.9. SanPham_iDoTuoi_GLC (Quan hệ với người liên hệ) </summary>
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

        /// <summary> I.10 SanPham_iGioiTinh_GLC (Hệ số tính điểm) </summary>
        /// <returns></returns>
        public static SortedList SanPham_iGioiTinh_GLC()
        {
            SortedList output = new SortedList();
            output.Add(SanPham_iGioiTinh_C.Nam, GetTextConstants.SanPham_iGioiTinh_GTC(SanPham_iGioiTinh_C.Nam));
            output.Add(SanPham_iGioiTinh_C.Nu, GetTextConstants.SanPham_iGioiTinh_GTC(SanPham_iGioiTinh_C.Nu));
            output.Add(SanPham_iGioiTinh_C.Nam_Nu, GetTextConstants.SanPham_iGioiTinh_GTC(SanPham_iGioiTinh_C.Nam_Nu));
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

        /// <summary> I.13. GiangVien_iChucVuGV_GLC (Chức vụ) </summary>
        /// <returns></returns>
        public static SortedList GiangVien_iChucVuGV_GLC()
        {
            SortedList output = new SortedList();
            output.Add(GiangVien_iChucVuGV_C.Vien_Truong, GetTextConstants.GiangVien_iChucVuGV_GTC(GiangVien_iChucVuGV_C.Vien_Truong));
            output.Add(GiangVien_iChucVuGV_C.Pho_Vien_Truong, GetTextConstants.GiangVien_iChucVuGV_GTC(GiangVien_iChucVuGV_C.Pho_Vien_Truong));
            output.Add(GiangVien_iChucVuGV_C.Truong_Khoa, GetTextConstants.GiangVien_iChucVuGV_GTC(GiangVien_iChucVuGV_C.Truong_Khoa));
            output.Add(GiangVien_iChucVuGV_C.Pho_Khoa, GetTextConstants.GiangVien_iChucVuGV_GTC(GiangVien_iChucVuGV_C.Pho_Khoa));
            output.Add(GiangVien_iChucVuGV_C.Truong_Phong_Dao_Tao, GetTextConstants.GiangVien_iChucVuGV_GTC(GiangVien_iChucVuGV_C.Truong_Phong_Dao_Tao));
            output.Add(GiangVien_iChucVuGV_C.Pho_Phong_Dao_Tao, GetTextConstants.GiangVien_iChucVuGV_GTC(GiangVien_iChucVuGV_C.Pho_Phong_Dao_Tao));
            output.Add(GiangVien_iChucVuGV_C.Van_Thu, GetTextConstants.GiangVien_iChucVuGV_GTC(GiangVien_iChucVuGV_C.Van_Thu));
            output.Add(GiangVien_iChucVuGV_C.Truong_Bo_Mon_Mang, GetTextConstants.GiangVien_iChucVuGV_GTC(GiangVien_iChucVuGV_C.Truong_Bo_Mon_Mang));
            output.Add(GiangVien_iChucVuGV_C.Truong_Bo_Mon_Mobile, GetTextConstants.GiangVien_iChucVuGV_GTC(GiangVien_iChucVuGV_C.Truong_Bo_Mon_Mobile));
            output.Add(GiangVien_iChucVuGV_C.Truong_Bo_Mon_Web, GetTextConstants.GiangVien_iChucVuGV_GTC(GiangVien_iChucVuGV_C.Truong_Bo_Mon_Web));
            output.Add(GiangVien_iChucVuGV_C.Truong_Bo_Mon_Do_Hoa, GetTextConstants.GiangVien_iChucVuGV_GTC(GiangVien_iChucVuGV_C.Truong_Bo_Mon_Do_Hoa));
            output.Add(GiangVien_iChucVuGV_C.Truong_Bo_Mon_Bao_Tri, GetTextConstants.GiangVien_iChucVuGV_GTC(GiangVien_iChucVuGV_C.Truong_Bo_Mon_Bao_Tri));
            output.Add(GiangVien_iChucVuGV_C.Can_Bo_Nhan_Vien_Nha_Truong, GetTextConstants.GiangVien_iChucVuGV_GTC(GiangVien_iChucVuGV_C.Can_Bo_Nhan_Vien_Nha_Truong));
            return output;
        }

        /// <summary> I.8. LichDayVaHoc_iCaHoc_GLC (Ca học) </summary>
        /// <returns></returns>
        public static SortedList LichDayVaHoc_iCaHoc_GLC()
        {
            SortedList output = new SortedList();
            output.Add(LichDayVaHoc_iCaHoc_C.Sang, GetTextConstants.LichDayVaHoc_iCaHoc_GTC(LichDayVaHoc_iCaHoc_C.Sang));
            output.Add(LichDayVaHoc_iCaHoc_C.Chieu, GetTextConstants.LichDayVaHoc_iCaHoc_GTC(LichDayVaHoc_iCaHoc_C.Chieu));
            output.Add(LichDayVaHoc_iCaHoc_C.Toi, GetTextConstants.LichDayVaHoc_iCaHoc_GTC(LichDayVaHoc_iCaHoc_C.Toi));
            return output;
        }



        /// <summary> III.1. BaiViet_iTrangThai_GLC (Trạng Thái bài viết) </summary>
        /// <returns></returns>
        public static SortedList BaiViet_iTrangThai_GLC()
        {
            SortedList output = new SortedList();
            output.Add(BaiViet_iTrangThai_C.Cho_Xem_Xet, GetTextConstants.BaiViet_iTrangThai_GTC(BaiViet_iTrangThai_C.Cho_Xem_Xet));
            output.Add(BaiViet_iTrangThai_C.Da_Kiem_Duyet, GetTextConstants.BaiViet_iTrangThai_GTC(BaiViet_iTrangThai_C.Da_Kiem_Duyet));
            output.Add(BaiViet_iTrangThai_C.Tam_Khoa, GetTextConstants.BaiViet_iTrangThai_GTC(BaiViet_iTrangThai_C.Tam_Khoa));
            output.Add(BaiViet_iTrangThai_C.Khoa, GetTextConstants.BaiViet_iTrangThai_GTC(BaiViet_iTrangThai_C.Khoa));
            return output;
        }

        /// <summary> III.2. CauHoi_iTrangThai_GLC (Trạng Thái câu hỏi) </summary>
        /// <returns></returns>
        public static SortedList CauHoi_iTrangThai_GLC()
        {
            SortedList output = new SortedList();
            output.Add(CauHoi_iTrangThai_C.Da_Kiem_Duyet, GetTextConstants.CauHoi_iTrangThai_GTC(CauHoi_iTrangThai_C.Da_Kiem_Duyet));
            output.Add(CauHoi_iTrangThai_C.Cho_Xem_Xet, GetTextConstants.CauHoi_iTrangThai_GTC(CauHoi_iTrangThai_C.Cho_Xem_Xet));
            output.Add(CauHoi_iTrangThai_C.Tam_Khoa, GetTextConstants.CauHoi_iTrangThai_GTC(CauHoi_iTrangThai_C.Tam_Khoa));
            output.Add(CauHoi_iTrangThai_C.Khoa, GetTextConstants.CauHoi_iTrangThai_GTC(CauHoi_iTrangThai_C.Khoa));
            return output;
        }

        /// <summary> III.3. DiemThi_iTrangThai_GLC (Trạng Thái điểm thi) </summary>
        /// <returns></returns>
        public static SortedList DiemThi_iTrangThai_GLC()
        {
            SortedList output = new SortedList();
            output.Add(DiemThi_iTrangThai_C.Binh_Thuong, GetTextConstants.DiemThi_iTrangThai_GTC(DiemThi_iTrangThai_C.Binh_Thuong));
            output.Add(DiemThi_iTrangThai_C.Phuc_Khao, GetTextConstants.DiemThi_iTrangThai_GTC(DiemThi_iTrangThai_C.Phuc_Khao));
            output.Add(DiemThi_iTrangThai_C.Huy_Ket_Qua, GetTextConstants.DiemThi_iTrangThai_GTC(DiemThi_iTrangThai_C.Huy_Ket_Qua));
            return output;
        }

        /// <summary> III.4. Error_iStatus_GLC </summary>
        /// <returns></returns>
        public static SortedList Error_iStatus_GLC()
        {
            SortedList output = new SortedList();
            output.Add(Error_iStatus_C.Da_Phat_Hien, GetTextConstants.Error_iStatus_GTC(Error_iStatus_C.Da_Phat_Hien));
            output.Add(Error_iStatus_C.Da_Xem, GetTextConstants.Error_iStatus_GTC(Error_iStatus_C.Da_Xem));
            output.Add(Error_iStatus_C.Dang_Sua, GetTextConstants.Error_iStatus_GTC(Error_iStatus_C.Dang_Sua));
            output.Add(Error_iStatus_C.Da_Sua, GetTextConstants.Error_iStatus_GTC(Error_iStatus_C.Da_Sua));
            output.Add(Error_iStatus_C.Cho_Kiem_Tra_Lai, GetTextConstants.Error_iStatus_GTC(Error_iStatus_C.Cho_Kiem_Tra_Lai));
            return output;
        }

        /// <summary> III.5. LichDayVaHoc_iTrangThai_GLC (Trạng Thái lịch dạy và học) </summary>
        /// <returns></returns>
        public static SortedList LichDayVaHoc_iTrangThai_GLC()
        {
            SortedList output = new SortedList();
            output.Add(LichDayVaHoc_iTrangThai_C.Hoc, GetTextConstants.LichDayVaHoc_iTrangThai_GTC(LichDayVaHoc_iTrangThai_C.Hoc));
            output.Add(LichDayVaHoc_iTrangThai_C.Day_Offline, GetTextConstants.LichDayVaHoc_iTrangThai_GTC(LichDayVaHoc_iTrangThai_C.Day_Offline));
            output.Add(LichDayVaHoc_iTrangThai_C.Hoc_Bu, GetTextConstants.LichDayVaHoc_iTrangThai_GTC(LichDayVaHoc_iTrangThai_C.Hoc_Bu));
            output.Add(LichDayVaHoc_iTrangThai_C.Nghi, GetTextConstants.LichDayVaHoc_iTrangThai_GTC(LichDayVaHoc_iTrangThai_C.Nghi));
            output.Add(LichDayVaHoc_iTrangThai_C.Thi, GetTextConstants.LichDayVaHoc_iTrangThai_GTC(LichDayVaHoc_iTrangThai_C.Thi));
            output.Add(LichDayVaHoc_iTrangThai_C.Kiem_Tra_Giua_Ky, GetTextConstants.LichDayVaHoc_iTrangThai_GTC(LichDayVaHoc_iTrangThai_C.Kiem_Tra_Giua_Ky));
            return output;
        }

        /// <summary> III.6. LopHoc_iTrangThai_GLC (Trạng Thái lớp học) </summary>
        /// <returns></returns>
        public static SortedList LopHoc_iTrangThai_GLC()
        {
            SortedList output = new SortedList();
            output.Add(LopHoc_iTrangThai_C.Binh_Thuong, GetTextConstants.LopHoc_iTrangThai_GTC(LopHoc_iTrangThai_C.Binh_Thuong));
            output.Add(LopHoc_iTrangThai_C.Tach_Lop, GetTextConstants.LopHoc_iTrangThai_GTC(LopHoc_iTrangThai_C.Tach_Lop));
            output.Add(LopHoc_iTrangThai_C.Gop_Lop, GetTextConstants.LopHoc_iTrangThai_GTC(LopHoc_iTrangThai_C.Gop_Lop));
            output.Add(LopHoc_iTrangThai_C.Huy_Lop, GetTextConstants.LopHoc_iTrangThai_GTC(LopHoc_iTrangThai_C.Huy_Lop));
            return output;
        }

        /// <summary> III.7. MonHoc_iTrangThai_GLC (Trạng Thái môn học) </summary>
        /// <returns></returns>
        public static SortedList MonHoc_iTrangThai_GLC()
        {
            SortedList output = new SortedList();
            output.Add(MonHoc_iTrangThai_C.Mo, GetTextConstants.MonHoc_iTrangThai_GTC(MonHoc_iTrangThai_C.Mo));
            output.Add(MonHoc_iTrangThai_C.Tam_Khoa, GetTextConstants.MonHoc_iTrangThai_GTC(MonHoc_iTrangThai_C.Tam_Khoa));
            output.Add(MonHoc_iTrangThai_C.Khoa, GetTextConstants.MonHoc_iTrangThai_GTC(MonHoc_iTrangThai_C.Khoa));
            return output;
        }

        /// <summary> III.8. PhanCongCongTac_iTrangThai_GLC (Trạng Thái môn học) </summary>
        /// <returns></returns>
        public static SortedList PhanCongCongTac_iTrangThai_GLC()
        {
            SortedList output = new SortedList();
            output.Add(PhanCongCongTac_iTrangThai_C.Binh_Thuong, GetTextConstants.PhanCongCongTac_iTrangThai_GTC(PhanCongCongTac_iTrangThai_C.Binh_Thuong));
            output.Add(PhanCongCongTac_iTrangThai_C.Chuyen_GV, GetTextConstants.PhanCongCongTac_iTrangThai_GTC(PhanCongCongTac_iTrangThai_C.Chuyen_GV));
            output.Add(PhanCongCongTac_iTrangThai_C.Huy, GetTextConstants.PhanCongCongTac_iTrangThai_GTC(PhanCongCongTac_iTrangThai_C.Huy));
            output.Add(PhanCongCongTac_iTrangThai_C.Hoc_Lai, GetTextConstants.PhanCongCongTac_iTrangThai_GTC(PhanCongCongTac_iTrangThai_C.Hoc_Lai));
            output.Add(PhanCongCongTac_iTrangThai_C.Hoc_Xong, GetTextConstants.PhanCongCongTac_iTrangThai_GTC(PhanCongCongTac_iTrangThai_C.Hoc_Xong));
            return output;
        }
        #endregion
    }
}