using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace Shared_Libraries
{
    public class Common
    {
        /// <summary> RemoveHtmlTags (Loại bỏ thẻ html) </summary>
        /// <param name="htmlString"></param>
        /// <returns></returns>
        public static string RemoveHtmlTags(string htmlString)
        {
            var array = new char[htmlString.Length];
            var arrayIndex = 0;
            var inside = false;

            foreach (var @let in htmlString)
            {
                if (let == '<')
                {
                    inside = true;
                    continue;
                }
                if (let == '>')
                {
                    inside = false;
                    continue;
                }
                if (inside) continue;
                array[arrayIndex] = let;
                arrayIndex++;
            }
            return new string(array, 0, arrayIndex);
        }

        public static string GetTempDate()
        {
            string strTmpDate = System.DateTime.Now.ToShortDateString();
            strTmpDate = strTmpDate.Replace(":", "-").Trim();
            strTmpDate = strTmpDate.Replace("/", "-").Trim();
            return strTmpDate;
        }

        public static List<int> Get_List_ID_by_List_Index(List<int> lstIndex, DataSet ListID)
        {
            List<int> lst = new List<int>();
            int tmp;
            for (int i = 0; i < lstIndex.Count; i++)
            {
                tmp = Convert.ToInt32(ListID.Tables[0].Rows[lstIndex[i]]["PK_lCauhoi_ID"].ToString());
                lst.Add(tmp);
            }
            return lst;
        }

        public static int Random_Number(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        public static List<int> Random_Array_Not_Duplicate(int sum, int num)
        {
            int tmp;
            List<int> lst = new List<int>();
            do
            {
                tmp = Random_Number(0, sum);
                if (lst.Contains(tmp) == false)
                {
                    lst.Add(tmp);
                }
            }
            while (lst.Count < num);
            return lst;
        }



        private static string[] ChuSo = new string[10] { " không", " một", " hai", " ba", " bốn", " năm", " sáu", " bẩy", " tám", " chín" };
        private static string[] Tien = new string[6] { "", " nghìn", " triệu", " tỷ", " nghìn tỷ", " triệu tỷ" };
        // Hàm đọc số thành chữ
        public static string DocTienBangChu(long SoTien, string strTail)
        {
            int lan, i;
            long so;
            string KetQua = "", tmp = "";
            int[] ViTri = new int[6];
            if (SoTien < 0) return "Số tiền âm !";
            if (SoTien == 0) return "Không đồng !";
            if (SoTien > 0)
            {
                so = SoTien;
            }
            else
            {
                so = -SoTien;
            }
            //Kiểm tra số quá lớn
            if (SoTien > 8999999999999999)
            {
                SoTien = 0;
                return "";
            }
            ViTri[5] = (int)(so / 1000000000000000);
            so = so - long.Parse(ViTri[5].ToString()) * 1000000000000000;
            ViTri[4] = (int)(so / 1000000000000);
            so = so - long.Parse(ViTri[4].ToString()) * +1000000000000;
            ViTri[3] = (int)(so / 1000000000);
            so = so - long.Parse(ViTri[3].ToString()) * 1000000000;
            ViTri[2] = (int)(so / 1000000);
            ViTri[1] = (int)((so % 1000000) / 1000);
            ViTri[0] = (int)(so % 1000);
            if (ViTri[5] > 0)
            {
                lan = 5;
            }
            else if (ViTri[4] > 0)
            {
                lan = 4;
            }
            else if (ViTri[3] > 0)
            {
                lan = 3;
            }
            else if (ViTri[2] > 0)
            {
                lan = 2;
            }
            else if (ViTri[1] > 0)
            {
                lan = 1;
            }
            else
            {
                lan = 0;
            }
            for (i = lan; i >= 0; i--)
            {
                tmp = DocSo3ChuSo(ViTri[i]);
                KetQua += tmp;
                if (ViTri[i] != 0) KetQua += Tien[i];
                if ((i > 0) && (!string.IsNullOrEmpty(tmp))) KetQua += ",";//&& (!string.IsNullOrEmpty(tmp))
            }
            if (KetQua.Substring(KetQua.Length - 1, 1) == ",") KetQua = KetQua.Substring(0, KetQua.Length - 1);
            KetQua = KetQua.Trim() + strTail;
            return KetQua.Substring(0, 1).ToUpper() + KetQua.Substring(1);
        }
        // Hàm đọc số có 3 chữ số
        private static string DocSo3ChuSo(int baso)
        {
            int tram, chuc, donvi;
            string KetQua = "";
            tram = (int)(baso / 100);
            chuc = (int)((baso % 100) / 10);
            donvi = baso % 10;
            if ((tram == 0) && (chuc == 0) && (donvi == 0)) return "";
            if (tram != 0)
            {
                KetQua += ChuSo[tram] + " trăm";
                if ((chuc == 0) && (donvi != 0)) KetQua += " linh";
            }
            if ((chuc != 0) && (chuc != 1))
            {
                KetQua += ChuSo[chuc] + " mươi";
                if ((chuc == 0) && (donvi != 0)) KetQua = KetQua + " linh";
            }
            if (chuc == 1) KetQua += " mười";
            switch (donvi)
            {
                case 1:
                    if ((chuc != 0) && (chuc != 1))
                    {
                        KetQua += " mốt";
                    }
                    else
                    {
                        KetQua += ChuSo[donvi];
                    }
                    break;
                case 5:
                    if (chuc == 0)
                    {
                        KetQua += ChuSo[donvi];
                    }
                    else
                    {
                        KetQua += " lăm";
                    }
                    break;
                default:
                    if (donvi != 0)
                    {
                        KetQua += ChuSo[donvi];
                    }
                    break;
            }
            return KetQua;
        }



//    #region "Đổi số nguyên ra chữ"
//    public static string Group3ToStrX(string num){
//        string[] No = {"không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín"};
//        string kq;
//            string tram;
//        string chuc;
//        string donvi;
//        // Trăm
//        if (num.Substring(0, 1) == "0"){
//            tram = "";
//        }
//        else{
//            tram = No(Convert.ToByte(num.Substring(0, 1))) & " trăm ";
//        }
//        // Chục
//        switch(num.Substring(1, 1)){
//            case "0":
//                if (num.Substring(2, 1) != "0" && num.Substring(0, 1) != "0" ){
//                    chuc = "linh ";
//        }
//                else{
//                    chuc = "";
//        }
//break;
//            case "1":
//                chuc = "mười ";
//                break;
//            default:
//                chuc = No(Convert.ToByte(num.Substring(1, 1))) & " mươi ";
//                break;
//    }
//        // Đơn vị
//        switch (num.Substring(2, 1)){
//            case "0": donvi = "";break;
//            case "1": if((num.Substring(1, 1) == "0") || (num.Substring(1, 1) == "1") ){
//                    donvi = "một";
//            }
//                else{
//                    donvi = "mốt";
//        }break;
//                case "5":
//                if (num.Substring(1, 1) != "0"){
//                    donvi = "lăm";
//                }
//                else{
//                    donvi = "năm";
//                }break;
//            default:
//                donvi = No(Convert.ToByte(num.Substring(2, 1)));
//                break;
//        }
//        kq = tram + chuc + donvi;
//        return kq;
//}

//    public string IntNumStr(string num){
//        string[] Cap = {"", " nghìn ", " triệu ", " tỷ ", " nghìn tỷ ", " triệu tỷ ", " tỷ tỷ ", " nghìn tỷ tỷ "};
//        string kq = "";
//        string str = num;
//        string g3;
//        string kqtg;
//        int caps = 0;
//        while (str.Length > 3){
//            g3 = str.Substring(str.Length - 3, 3);
//            str = str.Substring(0, str.Length - 3);
//            if (g3 != "000"){
//                kqtg = Group3ToStrX(g3) + Cap(Convert.ToByte(caps));
//            }
//            else{
//                kqtg = "";
//            }
//            kq = kqtg + kq;
//            caps += 1;
//        }
//        //Chuẩn bị trước khi sử dụng hàm Group32Str1
//        while (str.Length < 3){
//            str = "0" + str;
//        }

//        if ((str == "000") & (num.Length <= 3)){
//            kqtg = "không";
//        }
//        else{
//            kqtg = Group3ToStrX(str) + Cap(Convert.ToByte(caps));
//        }
//        kq = kqtg + kq;
//        return kq;
//}
//#endregion

    }

    public class Messages
    {
        public const string Tong_So_Ban_Ghi = "Tổng số bản ghi: ";
        public const string Khong_Thoa_Man_Dieu_Kien_Tim_Kiem = "Không thỏa mãn điều kiện tìm kiếm!";
        public const string Loi = "Lỗi: ";
        public const string Loi_Tai_Du_Lieu = "Lỗi tải dữ liệu!";
        public const string Ma_Khong_Hop_Le = "Mã không hợp lệ!";
        public const string Khong_Dung_Dinh_Dang_So = "Không đúng định dạng số, Vui lòng kiểm tra lại!";
        public const string Khong_Dung_Dinh_Dang_Ngay = "Không đúng định dạng ngày/ giờ, Vui lòng kiểm tra lại!";

        public const string Them_Thanh_Cong = "Thêm thành công";
        public const string Them_That_Bai = "Thêm thất bại, vui lòng kiểm tra lại!";
        public const string Sua_Thanh_Cong = "Sửa thành công";
        public const string Sua_That_Bai = "Sửa thất bại, vui lòng kiểm tra lại!";
        public const string Xoa_Thanh_Cong = "Xóa thành công";
        public const string Xoa_That_Bai = "Xóa thất bại, vui lòng kiểm tra lại!";

        public static readonly string DateTime_Temp = Convert.ToString(DateTime.Now.ToString("dd-MM-yyyy"));
    }
}