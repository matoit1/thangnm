using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shared_Libraries
{
    public class GetTextConstant
    {
        /// <summary>
        /// Hoc_Vi (Học vị)
        /// </summary>
        /// <param name="input"></param>
        /// <returns>output</returns>
        public static string Hoc_Vi(int input){
            string output="";
            switch (input){
                case 1: output = "Tú Tài"; break;
                case 2: output = "Cử Nhân"; break;
                case 3: output = "Kỹ Sư"; break;
                case 4: output = "Thạc Sĩ"; break;
                case 5: output = "Tiến Sĩ"; break;
                case 6: output = "Tiến Sĩ Khoa Học"; break;
                default: output = "NULL"; break;
            }
            return output;
        }

        /// <summary>
        /// Xep_Loai_Ket_Qua_Hoc_Tap (Xếp loại kết quả học tập)
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
        public static string Xep_Loai_Ket_Qua_Hoc_Tap(int input)
        {
            string output = "";
            switch (input)
            {
                case 9: case 10: output = "Xuất Sắc"; break;
                case 8: output = "Giỏi"; break;
                case 7: output = "Khá"; break;
                case 6: output = "Trung Bình Khá"; break;
                case 5: output = "Trung Bình"; break;
                case 4: output = "Yếu"; break;
                case 3: output = "Kém"; break;
                default: output = "NULL"; break;
            }
            return output;
        }

        /// <summary>
        /// Tinh_Diem_Chuyen_Can (Tính điểm chuyên cần)
        /// </summary>
        /// <param name="input"></param>
        /// <returns>output</returns>
        public static int Tinh_Diem_Chuyen_Can(int input)
        {
            int output = 10;
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

        /// <summary>
        /// Chuc_Vu (Chức vụ)
        /// </summary>
        /// <param name="input"></param>
        /// <returns>output</returns>
        public static string Chuc_Vu(int input)
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
                default: output = "Cán bộ nhân viên nhà trường"; break;
            }
            return output;
        }

        /// <summary>
        /// Gioi_Tinh (Giới tính)
        /// </summary>
        /// <param name="input"></param>
        /// <returns>output</returns>
        public static string Gioi_Tinh(bool input)
        {
            string output = "";
            switch (input)
            {
                case true: output = "Nam"; break;
                case false: output = "Nữ"; break;
            }
            return output;
        }

        /// <summary>
        /// Doan_Thanh_Nien_Cong_San_HCM (Đoàn thanh niên cộng sản Hồ Chí Minh)
        /// </summary>
        /// <param name="input"></param>
        /// <returns>output</returns>
        public static string Doan_Thanh_Nien_Cong_San_HCM(bool input)
        {
            string output = "";
            switch (input)
            {
                case true: output = "Đã vào đoàn"; break;
                case false: output = "Chưa vào đoàn"; break;
            }
            return output;
        }


    }
}