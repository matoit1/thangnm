using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HaBa.SharedLibraries
{
    public class GetTextConstants
    {
        #region "I. Constants - GetTextConstants - GetListConstants"

        /// <summary> I.12. TaiKhoan_iTrangThai_GTC (Trạng Thái Tài Khoản) </summary>
        /// <param name="input"></param>
        /// <returns>output</returns>
        public static string TaiKhoan_iTrangThai_GTC(Int16 input)
        {
            string output = "";
            switch (input)
            {
                case 1: output = "Mở"; break;
                case 2: output = "Xem xét"; break;
                case 3: output = "Khóa"; break;
                default: output = "N/A"; break;
            }
            return output;
        }

        /// <summary> I.2. CuocHen_iTrangThai_GTC (Trạng Thái Cuộc Hẹn) </summary>
        /// <param name="input"></param>
        /// <returns>output</returns>
        public static string CuocHen_iTrangThai_GTC(Int16 input)
        {
            string output = "";
            switch (input)
            {
                case 1: output = "Đi"; break;
                case 2: output = "Đã đi"; break;
                case 3: output = "Có thể đi"; break;
                case 4: output = "Không đi"; break;
                default: output = "N/A"; break;
            }
            return output;
        }
        #endregion
    }
}
