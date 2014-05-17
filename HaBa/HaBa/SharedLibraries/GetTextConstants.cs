using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HaBa.SharedLibraries
{
    public class GetTextConstants
    {
        #region "I. Constants - GetTextConstants - GetListConstants"
        /// <summary> I.1 Quyen_Han_GTC (Quyền hạn) </summary>
        /// <param name="input"></param>
        /// <returns>ouput</returns>
        public static string Quyen_Han_GTC(Int16 input)
        {
            string ouput;
            switch (input)
            {
                case 0: ouput = "Khách"; break;
                case 1: ouput = "Quản trị viên"; break;
                case 2: ouput = "Giảng Viên"; break;
                case 3: ouput = "Sinh Viên"; break;
                case 4: ouput = "Nhân viên"; break;
                default: ouput = "N/A"; break;
            }
            return ouput;
        }

        /// <summary> I.2. GiangVien_iHocViGV_GTC (Học vị) </summary>
        /// <param name="input"></param>
        /// <returns>output</returns>
        public static string GiangVien_iHocViGV_GTC(Int16 input)
        {
            string output="";
            switch (input){
                case 1: output = "Tú Tài"; break;
                case 2: output = "Cử Nhân"; break;
                case 3: output = "Kỹ Sư"; break;
                case 4: output = "Thạc Sĩ"; break;
                case 5: output = "Tiến Sĩ"; break;
                case 6: output = "Tiến Sĩ Khoa Học"; break;
                default: output = "N/A"; break;
            }
            return output;
        }

        /// <summary> I.3. Gioi_Tinh_GTC (Giới tính) </summary>
        /// <param name="input"></param>
        /// <returns>output</returns>
        public static string Gioi_Tinh_GTC(bool input)
        {
            string output = "";
            switch (input)
            {
                case true: output = "Nam"; break;
                case false: output = "Nữ"; break;
            }
            return output;
        }

        /// <summary> I.4. Hon_Nhan_GTC (Hôn Nhân) </summary>
        /// <param name="input"></param>
        /// <returns>output</returns>
        public static string Hon_Nhan_GTC(bool input)
        {
            string output = "";
            switch (input)
            {
                case true: output = "Đã kết hôn"; break;
                case false: output = "Chưa kết hôn"; break;
            }
            return output;
        }

        /// <summary> I.5. GiangVien_bCongChucGV_GTC (Công Chức) </summary>
        /// <param name="input"></param>
        /// <returns>output</returns>
        public static string GiangVien_bCongChucGV_GTC(bool input)
        {
            string output = "";
            switch (input)
            {
                case true: output = "Đã có công chức"; break;
                case false: output = "Chưa có công chức"; break;
            }
            return output;
        }

        /// <summary> I.6. GiangVien_iTrangThaiGV_GTC (Trạng Thái Giáo Viên) </summary>
        /// <param name="input"></param>
        /// <returns>output</returns>
        public static string GiangVien_iTrangThaiGV_GTC(Int16 input)
        {
            string output = "";
            switch (input)
            {
                case 1: output = "Đang công tác"; break;
                case 2: output = "Chuyển công tác"; break;
                case 3: output = "Nghỉ chế độ"; break;
                case 4: output = "Nghỉ phép"; break;
                case 5: output = "Tạm đình chỉ công tác"; break;
                case 6: output = "Nghỉ hưu"; break;
                case 7: output = "Bỏ việc"; break;
                default: output = "N/A"; break;
            }
            return output;
        }

        /// <summary> I.7. NhomSanPham_iTrangThai_GTC (Trạng Thái Nhóm Sản Phẩm) </summary>
        /// <param name="input"></param>
        /// <returns>output</returns>
        public static string NhomSanPham_iTrangThai_GTC(Int16 input)
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

        /// <summary> I.8. SanPham_iTrangThai_GTC (Đoàn thanh niên cộng sản Hồ Chí Minh) </summary>
        /// <param name="input"></param>
        /// <returns>output</returns>
        public static string SanPham_iTrangThai_GTC(Int16 input)
        {
            string output = "";
            switch (input)
            {
                case 1: output = "Mở"; break;
                case 2: output = "Hết hàng"; break;
                case 3: output = "Khóa"; break;
                default: output = "N/A"; break;
            }
            return output;
        }

        /// <summary> I.9. SanPham_iDoTuoi_GTC (Quan hệ với người liên hệ) </summary>
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

        /// <summary>  I.10 SanPham_iGioiTinh_GTC (Hệ số tính điểm)  </summary>
        /// <param name="input"></param>
        /// <returns>output</returns>
        public static string SanPham_iGioiTinh_GTC(Int16 input)
        {
            string output = "";
            switch (input)
            {
                case 1: output = "Nam"; break;
                case 2: output = "Nữ"; break;
                case 7: output = "Cả Nam và Nữ"; break;
                default: output = "N/A"; break;
            }
            return output;
        }



        /// <summary> I.11. Xep_Loai_Ket_Qua_Hoc_Tap_GTC (Xếp loại kết quả học tập) </summary>
        /// a) Loại đạt:Từ 9 đến 10:Xuất sắc
        /// Từ 8 đến cận 9:Giỏi
        /// Từ 7 đến cận 8:Khá
        /// Từ 6 đến cận 7:Trung bình khá
        /// Từ 5 đến cận 6:Trung bình
        /// b) Loại không đạt:Từ 4 đến cận 5:Yếu
        /// Dưới 4:Kém
        /// </summary>
        /// <param name="input"></param>
        /// <returns>output</returns>
        public static string Xep_Loai_Ket_Qua_Hoc_Tap_GTC(Int16 input)
        {
            string output = "";
            switch (input)
            {
                case 9: output = "Xuất Sắc"; break;
                case 8: output = "Giỏi"; break;
                case 7: output = "Khá"; break;
                case 6: output = "Trung Bình Khá"; break;
                case 5: output = "Trung Bình"; break;
                case 4: output = "Yếu"; break;
                case 3: output = "Kém"; break;
                default: output = "N/A"; break;
            }
            return output;
        }
        #endregion

        /// <summary> I.12. Tinh_Diem_Chuyen_Can_GTC (Tính điểm chuyên cần) </summary>
        /// <param name="input"></param>
        /// <returns>output</returns>
        public static Int16 Tinh_Diem_Chuyen_Can_GTC(Int16 input)
        {
            Int16 output;
            switch (input)
            {
                case 1: output = 10; break;
                case 2: output = 9; break;
                case 3: output = 8; break;
                case 4: output = 7; break;
                case 5: output = 0; break;
                default: output = 0; break;
            }
            return output;
        }

        /// <summary> I.13. GiangVien_iChucVuGV_GTC (Chức vụ) </summary>
        /// <param name="input"></param>
        /// <returns>output</returns>
        public static string GiangVien_iChucVuGV_GTC(Int16 input)
        {
            string output = "Cán bộ nhân viên nhà trường";
            switch (input)
            {
                case 1: output = "Viện Trưởng"; break;
                case 2: output = "Phó Viện Trưởng"; break;
                case 3: output = "Trưởng Khoa"; break;
                case 4: output = "Phó Khoa"; break;
                case 5: output = "Trưởng Phòng Đào Tạo"; break;
                case 6: output = "Phó Phòng Đào Tạo"; break;
                case 7: output = "Văn Thư"; break;
                case 50: output = "Trưởng Bộ Môn Mạng"; break;
                case 51: output = "Trưởng Bộ Môn Mobile"; break;
                case 52: output = "Trưởng Bộ Môn Web"; break;
                case 53: output = "Trưởng Bộ Môn Đồ họa"; break;
                case 54: output = "Trưởng Bộ Môn Bảo trì"; break;
                case 55: output = "Cán bộ nhân viên nhà trường"; break;
                default: output = "N/A"; break;
                    
            }
            return output;
        }

        /// <summary> LichDayVaHoc_iCaHoc_GTC (Ca học) </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string LichDayVaHoc_iCaHoc_GTC(Int16 input)
        {
            string output = "";
            switch (input)
            {
                case 1: output = "Sáng"; break;
                case 2: output = "Chiều"; break;
                case 3: output = "Tối"; break;
            }
            return output;
        }
















        /// <summary> BaiViet_iTrangThai_GTC (Ca học) </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string BaiViet_iTrangThai_GTC(Int16 input)
        {
            string output = "";
            switch (input)
            {
                case 1: output = "Chờ xem xét"; break;
                case 2: output = "Đã kiểm duyệt"; break;
                case 3: output = "Tạm khóa"; break;
                case 4: output = "Khóa"; break;
            }
            return output;
        }

        /// <summary> CauHoi_iTrangThai_GTC (Ca học) </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string CauHoi_iTrangThai_GTC(Int16 input)
        {
            string output = "";
            switch (input)
            {
                case 1: output = "Chờ xem xét"; break;
                case 2: output = "Đã kiểm duyệt"; break;
                case 3: output = "Tạm khóa"; break;
                case 4: output = "Khóa"; break;
            }
            return output;
        }

        /// <summary> DiemThi_iTrangThai_GTC (Ca học) </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string DiemThi_iTrangThai_GTC(Int16 input)
        {
            string output = "";
            switch (input)
            {
                case 1: output = "Bình thường"; break;
                case 2: output = "Phúc khảo"; break;
                case 3: output = "Hủy kết quả"; break;
            }
            return output;
        }

        /// <summary> Error_iStatus_GTC (Ca học) </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string Error_iStatus_GTC(Int16 input)
        {
            string output = "";
            switch (input)
            {
                case 1: output = "Đã phát hiện"; break;
                case 2: output = "Đã xem"; break;
                case 3: output = "Đang Sửa"; break;
                case 4: output = "Đã sửa"; break;
                case 5: output = "Chờ kiểm tra lại"; break;
            }
            return output;
        }

        /// <summary> LichDayVaHoc_iTrangThai_GTC (Ca học) </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string LichDayVaHoc_iTrangThai_GTC(Int16 input)
        {
            string output = "";
            switch (input)
            {
                case 1: output = "Học"; break;
                case 2: output = "Dạy offline"; break;
                case 3: output = "Học bù"; break;
                case 4: output = "Nghỉ"; break;
                case 5: output = "Thi"; break;
                case 6: output = "Kiểm tra giữa kỳ"; break;
            }
            return output;
        }

        /// <summary> LopHoc_iTrangThai_GTC (Ca học) </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string LopHoc_iTrangThai_GTC(Int16 input)
        {
            string output = "";
            switch (input)
            {
                case 1: output = "Bình thường"; break;
                case 2: output = "Tách lớp"; break;
                case 3: output = "Gộp lớp"; break;
                case 4: output = "Hủy lớp"; break;
            }
            return output;
        }

        /// <summary> MonHoc_iTrangThai_GTC (Ca học) </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string MonHoc_iTrangThai_GTC(Int16 input)
        {
            string output = "";
            switch (input)
            {
                case 1: output = "Mở"; break;
                case 2: output = "Tạm khóa"; break;
                case 3: output = "Khóa"; break;
            }
            return output;
        }

        /// <summary> PhanCongCongTac_iTrangThai_GTC (Ca học) </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string PhanCongCongTac_iTrangThai_GTC(Int16 input)
        {
            string output = "";
            switch (input)
            {
                case 1: output = "Bình thường"; break;
                case 2: output = "Chuyển giáo viên"; break;
                case 3: output = "Nghỉ"; break;
                case 4: output = "Học lại"; break;
                case 5: output = "Học xong"; break;
            }
            return output;
        }

    }
}