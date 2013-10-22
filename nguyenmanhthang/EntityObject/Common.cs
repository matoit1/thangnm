using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityObject
{
    public class Common
    {
        public string GetTextCategory(int Topic_Category)
        {
            switch (Topic_Category)
            {
                case 1: return "Học tập"; break;
                case 11: return "Lập trình"; break;
                case 111: return ""; break;
                case 112: return ""; break;
                case 113: return ""; break;
                case 114: return ""; break;
                case 115: return ""; break;
                case 116: return ""; break;
                case 117: return ""; break;
                case 12: return "Thiết kế - Đồ họa"; break;
                case 13: return "Công nghệ mạng"; break;
                case 14: return "Mobile"; break;

                case 2: return "Phần mềm"; break;
                case 21: return "Hệ điều hành"; break;
                case 211: return "Phần mềm"; break;
                case 212: return "Phần mềm"; break;
                case 213: return "Phần mềm"; break;
                case 214: return "Phần mềm"; break;
                case 22: return "Bảo mật"; break;
                case 23: return "Văn phòng"; break;
                case 24: return "Portable"; break;

                case 3: return "Thủ thuật"; break;
                case 31: return "Máy tính"; break;
                case 32: return "Website"; break;
                case 33: return "Facebook"; break;
                case 331: return ""; break;
                case 332: return "Thủ thuật"; break;
                case 333: return "Thủ thuật"; break;
                case 34: return "Yahoo"; break;
                case 35: return "Khác..."; break;

                case 4: return "Giải trí"; break;
                case 41: return "Giải trí"; break;
                case 411: return "Giải trí"; break;
                case 412: return "Giải trí"; break;
                case 413: return "Giải trí"; break;
                case 42: return "Giải trí"; break;
                case 43: return "Giải trí"; break;
                case 44: return "Giải trí"; break;
                case 45: return "Giải trí"; break;
                case 46: return "Giải trí"; break;
                case 47: return "Giải trí"; break;
                case 48: return "Giải trí"; break;

                case 5: return "Ứng dụng"; break;
                case 51: return "Ứng dụng"; break;
                case 52: return "Ứng dụng"; break;
                case 521: return "Ứng dụng"; break;
                case 522: return "Ứng dụng"; break;
                case 523: return "Ứng dụng"; break;
                case 524: return "Ứng dụng"; break;
                case 53: return "Ứng dụng"; break;
                case 54: return "Ứng dụng"; break;
                case 55: return "Ứng dụng"; break;
                case 56: return "Ứng dụng"; break;
                case 561: return "Ứng dụng"; break;
                case 562: return "Ứng dụng"; break;
                case 563: return "Ứng dụng"; break;
                case 564: return "Ứng dụng"; break;
                case 565: return "Ứng dụng"; break;
                case 566: return "Ứng dụng"; break;

                case 6: return "Upload"; break;
                case 61: return "Server 1 Dropbox"; break;
                case 611: return "Upload"; break;
                case 612: return "Download"; break;
                case 62: return "Server 2 Dropbox"; break;
                case 621: return "Upload"; break;
                case 622: return "Download"; break;
                case 63: return "Server 3 Upfile.vn"; break;

                default: return "Other"; break;
            }
        }
    }
}
