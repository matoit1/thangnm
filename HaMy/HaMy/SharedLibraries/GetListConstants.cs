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

        /// <summary> I.2. CuocHen_iTrangThai_GLC (Trạng Thái Cuộc Hẹn) </summary>
        /// <returns></returns>
        public static SortedList CuocHen_iTrangThai_GLC()
        {
            SortedList output = new SortedList();
            output.Add(CuocHen_iTrangThai_C.Di, GetTextConstants.CuocHen_iTrangThai_GTC(CuocHen_iTrangThai_C.Di));
            output.Add(CuocHen_iTrangThai_C.Da_Di, GetTextConstants.CuocHen_iTrangThai_GTC(CuocHen_iTrangThai_C.Da_Di));
            output.Add(CuocHen_iTrangThai_C.Co_The_Di, GetTextConstants.CuocHen_iTrangThai_GTC(CuocHen_iTrangThai_C.Co_The_Di));
            output.Add(CuocHen_iTrangThai_C.Khong_Di, GetTextConstants.CuocHen_iTrangThai_GTC(CuocHen_iTrangThai_C.Khong_Di));
            return output;
        }
        #endregion
    }
}