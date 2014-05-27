using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shared_Libraries
{
    public class GetTextConstants
    {
        /// <summary> tblAccount_iType_GTC </summary>
        /// <param name="input"></param>
        /// <returns>output</returns>
        public static string tblAccount_iType_GTC(Int16 input)
        {
            string output;
            switch (input)
            {
                case 1: output = "Sinh Viên"; break;
                case 2: output = "Giảng Viên"; break;
                case 3: output = "Quản Trị"; break;
                default: output = "N/A"; break;
            }
            return output;
        }

        /// <summary> I.6. tblAccount_iStatus_GTC </summary>
        /// <param name="input"></param>
        /// <returns>output</returns>
        public static string tblAccount_iStatus_GTC(Int16 input)
        {
            string output = "";
            switch (input)
            {
                case 1: output = "Mở"; break;
                case 2: output = "Khóa"; break;
                default: output = "N/A"; break;
            }
            return output;
        }

        /// <summary> tblMessage_iStatus_GTC </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string tblMessage_iStatus_GTC(Int16 input)
        {
            string output = "";
            switch (input)
            {
                case 1: output = "Hiện"; break;
                case 2: output = "Ẩn"; break;
            }
            return output;
        }

        /// <summary> tblPart_iStatus_GTC </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string tblPart_iStatus_GTC(Int16 input)
        {
            string output = "";
            switch (input)
            {
                case 1: output = "Học"; break;
                case 2: output = "Dạy offline"; break;
                case 3: output = "Học bù"; break;
                case 4: output = "Nghỉ"; break;
                case 5: output = "Thi"; break;
                case 6: output = "Kiểm tra giữa kỳ"; break;
            }
            return output;
        }
        
        /// <summary> tblSubject_iStatus_GTC</summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string tblSubject_iStatus_GTC(Int16 input)
        {
            string output = "";
            switch (input)
            {
                case 1: output = "Mở"; break;
                case 2: output = "Tạm khóa"; break;
                case 3: output = "Khóa"; break;
            }
            return output;
        }
        
        /// <summary> tblSubject_Student_iStatus_GTC </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string tblSubject_Student_iStatus_GTC(Int16 input)
        {
            string output = "";
            switch (input)
            {
                case 1: output = "Học"; break;
                case 2: output = "Vào muộn"; break;
                case 3: output = "Nghỉ"; break;
            }
            return output;
        }


        /// <summary> Emoticons_GTC (Biểu tượng cảm xúc) </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string Emoticons_GTC(string input)
        {
            string output = "";
            switch (input)
            {
                case "<3": output = "<img src=\"../../Images/Smileys/Icon_1.gif\" />"; break;
                case ":D": output = "<img src=\"../../Images/Smileys/Icon_2.gif\" />"; break;
                case ":))": output = "<img src=\"../../Images/Smileys/Icon_3.gif\" />"; break;
                case ":)": output = "<img src=\"../../Images/Smileys/Icon_4.gif\" />"; break;
                case "=))": output = "<img src=\"../../Images/Smileys/Icon_5.gif\" />"; break;
                case "X-(": output = "<img src=\"../../Images/Smileys/Icon_6.gif\" />"; break;
                case ":X": output = "<img src=\"../../Images/Smileys/Icon_7.gif\" />"; break;
                case "(*)": output = "<img src=\"../../Images/Smileys/Icon_8.gif\" />"; break;
                case ":(": output = "<img src=\"../../Images/Smileys/Icon_9.gif\" />"; break;
            }
            return output;
        }

    }
}