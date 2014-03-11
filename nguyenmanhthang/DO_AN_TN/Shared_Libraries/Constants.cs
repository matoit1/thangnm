﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shared_Libraries.Constants
{
    /// <summary>
    /// Hoc_Vi (Học vị)
    /// </summary>
    public class Hoc_Vi_C
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
    public class Gioi_Tinh_C
    {
        public const Boolean Nam = true;
        public const Boolean Nu = false;
    }

    /// <summary>
    /// Hon_Nhan (Hôn Nhân)
    /// </summary>
    public class Hon_Nhan_C
    {
        public const Boolean Da_Ket_Hon = true;
        public const Boolean Chua_Ket_Hon = false;
    }

    /// <summary>
    /// Cong_Chuc (Công Chức)
    /// </summary>
    public class Cong_Chuc_C
    {
        public const Boolean Da_Co_Cong_Chuc = true;
        public const Boolean Chua_Co_Cong_Chuc = false;
    }

    /// <summary>
    /// Giao_Vien_Trang_Thai (Trạng Thái Giáo Viên)
    /// </summary>
    public class Giao_Vien_Trang_Thai_C
    {
        public const Int16 Chuyen_Cong_Tac = 1;
        public const Int16 Nghi_Che_Do = 2;
        public const Int16 Nghi_Phep = 3;
        public const Int16 Tam_Dinh_Chi_Cong_Tac = 4;
        public const Int16 Da_Nghi_Huu = 5;
        public const Int16 Bo_Viec = 6;
    }

    /// <summary>
    /// Sinh_Vien_Trang_Thai (Trạng Thái Sinh Viên)
    /// </summary>
    public class Sinh_Vien_Trang_Thai_C
    {
        public const Int16 Chuyen_Truong = 1;
        public const Int16 Chuyen_Lop = 2;
        public const Int16 Bao_Luu_Ket_Qua = 3;
        public const Int16 Bo_Hoc = 4;
        public const Int16 Luu_Ban = 5;
        public const Int16 Duoi_Hoc = 6;
    }

    /// <summary>
    /// Doan_Thanh_Nien_Cong_San_HCM (Đoàn thanh niên cộng sản Hồ Chí Minh)
    /// </summary>
    public class Doan_Thanh_Nien_Cong_San_HCM_C
    {
        public const Boolean Da_Vao_Doan = true;
        public const Boolean Chua_Vao_Doan = false;
    }

    /// <summary>
    /// Quan_He_Voi_Nguoi_Lien_He (Quan hệ với người liên hệ)
    /// </summary>
    public class Quan_He_Voi_Nguoi_Lien_He_C
    {
        public const Int16 Bo = 1;
        public const Int16 Me = 2;
        public const Int16 Anh = 3;
        public const Int16 Chi = 4;
        public const Int16 Bac = 5;
        public const Int16 Chu = 6;
        public const Int16 Co = 7;
        public const Int16 Di = 8;
        public const Int16 Khac = 9;
    }

    /// <summary>
    /// He_So_Tinh_Diem (Hệ số tính điểm)
    /// </summary>
    public class He_So_Tinh_Diem_C
    {
        public const double Diem_Chuyen_Can = 0.1;
        public const double Diem_Giua_Ky = 0.2;
        public const double Diem_Thi = 0.7;
    }
}