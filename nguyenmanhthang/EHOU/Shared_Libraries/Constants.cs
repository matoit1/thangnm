using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shared_Libraries.Constants
{

    /// <summary> tblAccount_iType_C</summary>
    /// 
    public class tblAccount_iType_C
    {
        public const Int16 Sinh_Vien = 1;
        public const Int16 Giang_Vien = 2;
        public const Int16 Quan_Tri = 3;
    }

    /// <summary> tblAccount_iStatus_C </summary>
    /// 
    public class tblAccount_iStatus_C
    {
        public const Int16 Mo = 1;
        public const Int16 Khoa = 2;
    }

    /// <summary> tblMessage_iStatus_C </summary>
    /// 
    public class tblMessage_iStatus_C
    {
        public const Int16 Hien = 1;
        public const Int16 An = 2;
    }

    /// <summary> tblPart_iStatus_C </summary>
    /// 
    public class tblPart_iStatus_C
    {
        public const Int16 Hoc = 1;
        public const Int16 Day_Offline = 2;
        public const Int16 Hoc_Bu = 3;
        public const Int16 Nghi = 4;
        public const Int16 Thi = 5;
        public const Int16 Kiem_Tra_Giua_Ky = 6;
    }

    /// <summary> tblSubject_iStatus_C </summary>
    /// 
    public class tblSubject_iStatus_C
    {
        public const Int16 Mo = 1;
        public const Int16 Tam_Khoa = 2;
        public const Int16 Khoa = 3;
    }


    /// <summary> tblSubject_Student_iStatus_C </summary>
    /// 
    public class tblSubject_Student_iStatus_C
    {
        public const Int16 Hoc = 1;
        public const Int16 Vao_Muon = 2;
        public const Int16 Nghi = 3;
    }

    /// <summary> Emoticons_C (Biểu tượng cảm xúc) </summary>
    /// 
    public class Emoticons_C
    {
        public const string Icon_1 = "<3";
        public const string Icon_2 = ":D";
        public const string Icon_3 = ":))";
        public const string Icon_4 = ":)";
        public const string Icon_5 = "=))";
        public const string Icon_6 = "X-(";
        public const string Icon_7 = ":X";
        public const string Icon_8 = "(*)";
        public const string Icon_9 = ":(";
    }


    #region "II. Định dạng"
    /// <summary> II.1. DateTimeFomat (Định dạng ngày giờ) </summary>
    /// 
    public class DateTimeFomat
    {
        public const string DISPLAY_DATE_FORMAT = "dd/MM/yyyy";
        public const string DISPLAY_DATETIME_FORMAT = "dd/MM/yyyy HH:mm";
    }

    /// <summary> II.2. NumberFomat (Định dạng số) </summary>
    /// 
    public class NumberFomat
    {
        public const string DISPLAY_NUMBER = "###,##0.######";
    }
    #endregion
}