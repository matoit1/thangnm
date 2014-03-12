using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shared_Libraries
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

        /// <summary> I.2. Hoc_Vi_GTC (Học vị) </summary>
        /// <param name="input"></param>
        /// <returns>output</returns>
        public static string Hoc_Vi_GTC(Int16 input)
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

        /// <summary> I.5. Cong_Chuc_GTC (Công Chức) </summary>
        /// <param name="input"></param>
        /// <returns>output</returns>
        public static string Cong_Chuc_GTC(bool input)
        {
            string output = "";
            switch (input)
            {
                case true: output = "Đã có công chức"; break;
                case false: output = "Chưa có công chức"; break;
            }
            return output;
        }

        /// <summary> I.6. Trang_Thai_Giao_Vien_GTC (Trạng Thái Giáo Viên) </summary>
        /// <param name="input"></param>
        /// <returns>output</returns>
        public static string Trang_Thai_Giao_Vien_GTC(Int16 input)
        {
            string output = "";
            switch (input)
            {
                case 1: output = "Chuyển công tác"; break;
                case 2: output = "Nghỉ chế độ"; break;
                case 3: output = "Nghỉ phép"; break;
                case 4: output = "Tạm đình chỉ công tác"; break;
                case 5: output = "Nghỉ hưu"; break;
                case 6: output = "Bỏ việc"; break;
                default: output = "N/A"; break;
            }
            return output;
        }

        /// <summary> I.7. Trang_Thai_Sinh_Vien_GTC (Trạng Thái Sinh Viên) </summary>
        /// <param name="input"></param>
        /// <returns>output</returns>
        public static string Trang_Thai_Sinh_Vien_GTC(Int16 input)
        {
            string output = "";
            switch (input)
            {
                case 1: output = "Chuyển trường"; break;
                case 2: output = "Chuyển lớp"; break;
                case 3: output = "Bảo lưu kết quả"; break;
                case 4: output = "Bỏ học"; break;
                case 5: output = "Lưu ban"; break;
                case 6: output = "Đuổi học"; break;
                default: output = "N/A"; break;
            }
            return output;
        }

        /// <summary> I.8. Doan_Thanh_Nien_Cong_San_HCM_GTC (Đoàn thanh niên cộng sản Hồ Chí Minh) </summary>
        /// <param name="input"></param>
        /// <returns>output</returns>
        public static string Doan_Thanh_Nien_Cong_San_HCM_GTC(bool input)
        {
            string output = "";
            switch (input)
            {
                case true: output = "Đã vào đoàn"; break;
                case false: output = "Chưa vào đoàn"; break;
            }
            return output;
        }

        /// <summary> I.9. Quan_He_Voi_Nguoi_Lien_He_GTC (Quan hệ với người liên hệ) </summary>
        /// <param name="input"></param>
        /// <returns>output</returns>
        public static string Quan_He_Voi_Nguoi_Lien_He_GTC(Int16 input)
        {
            string output = "";
            switch (input)
            {
                case 1: output = "Bố"; break;
                case 2: output = "Mẹ"; break;
                case 3: output = "Anh"; break;
                case 4: output = "Chị"; break;
                case 5: output = "Bác"; break;
                case 6: output = "Chú"; break;
                case 7: output = "Cô"; break;
                case 8: output = "Dì"; break;
                case 9: output = "N/A"; break;
            }
            return output;
        }

        /// <summary>  I.10 He_So_Tinh_Diem_GTC (Hệ số tính điểm)  </summary>
        /// <param name="input"></param>
        /// <returns>output</returns>
        public static string He_So_Tinh_Diem_GTC(double input)
        {
            int medial = Convert.ToInt32(input * 10);
            string output;
            switch (medial)
            {
                case 1: output = "Điểm chuyên cần"; break;
                case 2: output = "Điểm giữa kỳ"; break;
                case 7: output = "Điểm thi"; break;
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

        /// <summary> I.13. Chuc_Vu_GTC (Chức vụ) </summary>
        /// <param name="input"></param>
        /// <returns>output</returns>
        public static string Chuc_Vu_GTC(Int16 input)
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

    }
}