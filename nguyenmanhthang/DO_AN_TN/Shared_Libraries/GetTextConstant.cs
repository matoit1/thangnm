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