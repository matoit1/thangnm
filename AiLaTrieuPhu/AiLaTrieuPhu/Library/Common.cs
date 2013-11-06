using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AiLaTrieuPhu.Library
{
    public class Common
    {
        public String getMoney(int i){
            String money;
            switch (i){
                case 1: money = "200.000"; break;
                case 2: money = "400.000"; break;
                case 3: money = "600.000"; break;
                case 4: money = "1.000.000"; break;
                case 5: money = "2.000.000"; break;
                case 6: money = "3.000.000"; break;
                case 7: money = "6.000.000"; break;
                case 8: money = "10.000.000"; break;
                case 9: money = "14.000.000"; break;
                case 10: money = "22.000.000"; break;
                case 11: money = "30.000.000"; break;
                case 12: money = "40.000.000"; break;
                case 13: money = "60.000.000"; break;
                case 14: money = "85.000.000"; break;
                case 15: money = "150.000.000"; break;
                default: money="0"; break;
            }
            return money;
        }
    }
}