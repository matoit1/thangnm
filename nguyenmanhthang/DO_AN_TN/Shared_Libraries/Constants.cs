using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shared_Libraries.Constants
{
    /// <summary>
    /// Hoc_Vi (Học vị)
    /// </summary>
    public class Hoc_Vi
    {
        public const Int32 Tu_Tai = 1;
        public const Int32 Cu_Nhan = 2;
        public const Int32 Ky_Su = 3;
        public const Int32 Thac_Si = 4;
        public const Int32 Tien_Si = 5;
        public const Int32 Tien_Si_Khoa_Hoc = 6;
    }

    /// <summary>
    /// Gioi_Tinh (Giới tính)
    /// </summary>
    public class Gioi_Tinh
    {
        public const Boolean Nam = true;
        public const Boolean Nu = false;
    }

    /// <summary>
    /// Doan_Thanh_Nien_Cong_San_HCM (Đoàn thanh niên cộng sản Hồ Chí Minh)
    /// </summary>
    public class Doan_Thanh_Nien_Cong_San_HCM
    {
        public const Boolean Da_Vao_Doan = true;
        public const Boolean Chua_Vao_Doan = false;
    }

    /// <summary>
    /// He_So_Tinh_Diem (Hệ số tính điểm)
    /// </summary>
    public class He_So_Tinh_Diem
    {
        public const double Diem_Chuyen_Can = 0.1;
        public const double Diem_Giua_Ky = 0.2;
        public const double Diem_Thi = 0.7;
    }
}