using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AiLaTrieuPhu.Library
{
    public class Common_Public
    {
        public static int RandomQuestion()
        {
            string valid = "1234567890";
            string res = "";
            Random rnd = new Random();
            for (int i = 0; i < 2; i++)
            {
                res += valid[rnd.Next(valid.Length)];
            }
            string randpass = res;
            return Convert.ToInt32(randpass);
        } 

        public static String SoTienThuong(int i)
        {
            String money;
            switch (i){
                case 1: money = "200000"; break;
                case 2: money = "400000"; break;
                case 3: money = "600000"; break;
                case 4: money = "1000000"; break;
                case 5: money = "2000000"; break;
                case 6: money = "3000000"; break;
                case 7: money = "6000000"; break;
                case 8: money = "10000000"; break;
                case 9: money = "14000000"; break;
                case 10: money = "22000000"; break;
                case 11: money = "30000000"; break;
                case 12: money = "40000000"; break;
                case 13: money = "60000000"; break;
                case 14: money = "85000000"; break;
                case 15: money = "150000000"; break;
                default: money="0"; break;
            }
            return money;
        }

        public static String TieuDe(int stt)
        {
            String status;
            switch (stt)
            {
                case 1: status = " Câu 1: Với mức thưởng trị giá: "; break;
                case 2: status = " Câu 2: Với mức thưởng trị giá: "; break;
                case 3: status = " Câu 3: Với mức thưởng trị giá: "; break;
                case 4: status = " Câu 4: Với mức thưởng trị giá: "; break;
                case 5: status = " Câu 5: Với mức thưởng trị giá: "; break;
                case 6: status = " Câu 6: Với mức thưởng trị giá: "; break;
                case 7: status = " Câu 7: Với mức thưởng trị giá: "; break;
                case 8: status = " Câu 8: Với mức thưởng trị giá: "; break;
                case 9: status = " Câu 9: Với mức thưởng trị giá: "; break;
                case 10: status = " Câu 10: Với mức thưởng trị giá: "; break;
                case 11: status = " Câu 11: Với mức thưởng trị giá: "; break;
                case 12: status = " Câu 12: Với mức thưởng trị giá: "; break;
                case 13: status = " Câu 13: Với mức thưởng trị giá: "; break;
                case 14: status = " Câu 14: Với mức thưởng trị giá: "; break;
                case 15: status = " Câu 15: Với mức thưởng trị giá: "; break;
                default: status = ""; break;
            }
            return status;
        }

    }
}