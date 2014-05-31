using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HaBa.SharedLibraries.Constants
{
    #region "I. Constants - GetTextConstants - GetListConstants"

    /// <summary> I.12. TaiKhoan_iTrangThai_C (Trạng Thái Tài Khoản) </summary>
    /// 
    public class TaiKhoan_iTrangThai_C
    {
        public const Int16 Mo = 1;
        public const Int16 Xem_Xet = 2;
        public const Int16 Khoa = 3;
    }

    /// <summary> I.13. CuocHen_iTrangThai_C (Trạng Thái Cuộc Hẹn) </summary>
    /// 
    public class CuocHen_iTrangThai_C
    {
        public const Int16 Di = 1;
        public const Int16 Da_Di = 2;
        public const Int16 Co_The_Di = 3;
        public const Int16 Khong_Di = 4;
        public const Int16 Tat_Nhac_Nho = 5;
    }

    #endregion
}