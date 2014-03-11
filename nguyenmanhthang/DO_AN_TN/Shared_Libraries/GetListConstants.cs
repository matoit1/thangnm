using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using Shared_Libraries.Constants;

namespace Shared_Libraries
{
    public class GetListConstants
    {
        public static SortedList Hoc_Vi_GLC()
        {
            SortedList output = new SortedList();
            output.Add(Hoc_Vi_C.Tu_Tai, GetTextConstants.Hoc_Vi_GTC(Hoc_Vi_C.Tu_Tai));
            output.Add(Hoc_Vi_C.Cu_Nhan, GetTextConstants.Hoc_Vi_GTC(Hoc_Vi_C.Cu_Nhan));
            output.Add(Hoc_Vi_C.Ky_Su, GetTextConstants.Hoc_Vi_GTC(Hoc_Vi_C.Ky_Su));
            output.Add(Hoc_Vi_C.Thac_Si, GetTextConstants.Hoc_Vi_GTC(Hoc_Vi_C.Thac_Si));
            output.Add(Hoc_Vi_C.Tien_Si, GetTextConstants.Hoc_Vi_GTC(Hoc_Vi_C.Tien_Si));
            output.Add(Hoc_Vi_C.Tien_Si_Khoa_Hoc, GetTextConstants.Hoc_Vi_GTC(Hoc_Vi_C.Tien_Si_Khoa_Hoc));
            return output;
        }

        public static SortedList Xep_Loai_Ket_Qua_Hoc_Tap_GLC()
        {
            SortedList output = new SortedList();
            output.Add(Hoc_Vi_C.Tu_Tai, GetTextConstants.Xep_Loai_Ket_Qua_Hoc_Tap_GTC(Hoc_Vi_C.Tu_Tai));
            output.Add(Hoc_Vi_C.Cu_Nhan, GetTextConstants.Xep_Loai_Ket_Qua_Hoc_Tap_GTC(Hoc_Vi_C.Cu_Nhan));
            output.Add(Hoc_Vi_C.Ky_Su, GetTextConstants.Xep_Loai_Ket_Qua_Hoc_Tap_GTC(Hoc_Vi_C.Ky_Su));
            output.Add(Hoc_Vi_C.Thac_Si, GetTextConstants.Xep_Loai_Ket_Qua_Hoc_Tap_GTC(Hoc_Vi_C.Thac_Si));
            output.Add(Hoc_Vi_C.Tien_Si, GetTextConstants.Xep_Loai_Ket_Qua_Hoc_Tap_GTC(Hoc_Vi_C.Tien_Si));
            output.Add(Hoc_Vi_C.Tien_Si_Khoa_Hoc, GetTextConstants.Xep_Loai_Ket_Qua_Hoc_Tap_GTC(Hoc_Vi_C.Tien_Si_Khoa_Hoc));
            return output;
        }

        public static SortedList Tinh_Diem_Chuyen_Can_GLC()
        {
            SortedList output = new SortedList();
            output.Add(Hoc_Vi_C.Tu_Tai, GetTextConstants.Xep_Loai_Ket_Qua_Hoc_Tap_GTC(Hoc_Vi_C.Tu_Tai));
            output.Add(Hoc_Vi_C.Cu_Nhan, GetTextConstants.Xep_Loai_Ket_Qua_Hoc_Tap_GTC(Hoc_Vi_C.Cu_Nhan));
            output.Add(Hoc_Vi_C.Ky_Su, GetTextConstants.Xep_Loai_Ket_Qua_Hoc_Tap_GTC(Hoc_Vi_C.Ky_Su));
            output.Add(Hoc_Vi_C.Thac_Si, GetTextConstants.Xep_Loai_Ket_Qua_Hoc_Tap_GTC(Hoc_Vi_C.Thac_Si));
            output.Add(Hoc_Vi_C.Tien_Si, GetTextConstants.Xep_Loai_Ket_Qua_Hoc_Tap_GTC(Hoc_Vi_C.Tien_Si));
            output.Add(Hoc_Vi_C.Tien_Si_Khoa_Hoc, GetTextConstants.Xep_Loai_Ket_Qua_Hoc_Tap_GTC(Hoc_Vi_C.Tien_Si_Khoa_Hoc));
            return output;
        }

        public static SortedList Chuc_Vu_GLC()
        {
            SortedList output = new SortedList();
            output.Add(Hoc_Vi_C.Tu_Tai, GetTextConstants.Chuc_Vu_GTC(Hoc_Vi_C.Tu_Tai));
            output.Add(Hoc_Vi_C.Cu_Nhan, GetTextConstants.Chuc_Vu_GTC(Hoc_Vi_C.Cu_Nhan));
            output.Add(Hoc_Vi_C.Ky_Su, GetTextConstants.Chuc_Vu_GTC(Hoc_Vi_C.Ky_Su));
            output.Add(Hoc_Vi_C.Thac_Si, GetTextConstants.Chuc_Vu_GTC(Hoc_Vi_C.Thac_Si));
            output.Add(Hoc_Vi_C.Tien_Si, GetTextConstants.Chuc_Vu_GTC(Hoc_Vi_C.Tien_Si));
            output.Add(Hoc_Vi_C.Tien_Si_Khoa_Hoc, GetTextConstants.Chuc_Vu_GTC(Hoc_Vi_C.Tien_Si_Khoa_Hoc));
            return output;
        }

        public static SortedList Quan_He_Voi_Nguoi_Lien_He_GLC()
        {
            SortedList output = new SortedList();
            output.Add(Quan_He_Voi_Nguoi_Lien_He_C.Bo, GetTextConstants.Quan_He_Voi_Nguoi_Lien_He_GTC(Quan_He_Voi_Nguoi_Lien_He_C.Bo));
            output.Add(Quan_He_Voi_Nguoi_Lien_He_C.Me, GetTextConstants.Quan_He_Voi_Nguoi_Lien_He_GTC(Quan_He_Voi_Nguoi_Lien_He_C.Me));
            output.Add(Quan_He_Voi_Nguoi_Lien_He_C.Anh, GetTextConstants.Quan_He_Voi_Nguoi_Lien_He_GTC(Quan_He_Voi_Nguoi_Lien_He_C.Anh));
            output.Add(Quan_He_Voi_Nguoi_Lien_He_C.Chi, GetTextConstants.Quan_He_Voi_Nguoi_Lien_He_GTC(Quan_He_Voi_Nguoi_Lien_He_C.Chi));
            output.Add(Quan_He_Voi_Nguoi_Lien_He_C.Bac, GetTextConstants.Quan_He_Voi_Nguoi_Lien_He_GTC(Quan_He_Voi_Nguoi_Lien_He_C.Bac));
            output.Add(Quan_He_Voi_Nguoi_Lien_He_C.Chu, GetTextConstants.Quan_He_Voi_Nguoi_Lien_He_GTC(Quan_He_Voi_Nguoi_Lien_He_C.Chu));
            output.Add(Quan_He_Voi_Nguoi_Lien_He_C.Co, GetTextConstants.Quan_He_Voi_Nguoi_Lien_He_GTC(Quan_He_Voi_Nguoi_Lien_He_C.Co));
            output.Add(Quan_He_Voi_Nguoi_Lien_He_C.Di, GetTextConstants.Quan_He_Voi_Nguoi_Lien_He_GTC(Quan_He_Voi_Nguoi_Lien_He_C.Di));
            output.Add(Quan_He_Voi_Nguoi_Lien_He_C.Khac, GetTextConstants.Quan_He_Voi_Nguoi_Lien_He_GTC(Quan_He_Voi_Nguoi_Lien_He_C.Khac));
            return output;
        }

        public static SortedList Doan_Thanh_Nien_Cong_San_HCM_GLC()
        {
            SortedList output = new SortedList();
            output.Add(Doan_Thanh_Nien_Cong_San_HCM_C.Da_Vao_Doan, GetTextConstants.Doan_Thanh_Nien_Cong_San_HCM_GTC(Doan_Thanh_Nien_Cong_San_HCM_C.Da_Vao_Doan));
            output.Add(Doan_Thanh_Nien_Cong_San_HCM_C.Chua_Vao_Doan, GetTextConstants.Doan_Thanh_Nien_Cong_San_HCM_GTC(Doan_Thanh_Nien_Cong_San_HCM_C.Chua_Vao_Doan));
            return output;
        }
    }
}