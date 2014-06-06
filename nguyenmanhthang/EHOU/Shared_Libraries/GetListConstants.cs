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

        /// <summary> tblAccount_iType_GLC </summary>
        /// <returns></returns>
        public static SortedList tblAccount_iType_GLC()
        {
            SortedList output = new SortedList();
            output.Add(tblAccount_iType_C.Sinh_Vien, GetTextConstants.tblAccount_iType_GTC(tblAccount_iType_C.Sinh_Vien));
            output.Add(tblAccount_iType_C.Giang_Vien, GetTextConstants.tblAccount_iType_GTC(tblAccount_iType_C.Giang_Vien));
            output.Add(tblAccount_iType_C.Quan_Tri, GetTextConstants.tblAccount_iType_GTC(tblAccount_iType_C.Quan_Tri));
            return output;
        }

        /// <summary> tblAccount_iStatus_GLC </summary>
        /// <returns></returns>
        public static SortedList tblAccount_iStatus_GLC()
        {
            SortedList output = new SortedList();
            output.Add(tblAccount_iStatus_C.Mo, GetTextConstants.tblAccount_iStatus_GTC(tblAccount_iStatus_C.Mo));
            output.Add(tblAccount_iStatus_C.Khoa, GetTextConstants.tblAccount_iStatus_GTC(tblAccount_iStatus_C.Khoa));
            return output;
        }

        /// <summary> tblMessage_iStatus_GLC </summary>
        /// <returns></returns>
        public static SortedList tblMessage_iStatus_GLC()
        {
            SortedList output = new SortedList();
            output.Add(tblMessage_iStatus_C.Hien, GetTextConstants.tblMessage_iStatus_GTC(tblMessage_iStatus_C.Hien));
            output.Add(tblMessage_iStatus_C.An, GetTextConstants.tblMessage_iStatus_GTC(tblMessage_iStatus_C.An));
            return output;
        }

        /// <summary> tblPart_iStatus_GLC </summary>
        /// <returns></returns>
        public static SortedList tblPart_iStatus_GLC()
        {
            SortedList output = new SortedList();
            output.Add(tblPart_iStatus_C.Hoc, GetTextConstants.tblPart_iStatus_GTC(tblPart_iStatus_C.Hoc));
            output.Add(tblPart_iStatus_C.Day_Offline, GetTextConstants.tblPart_iStatus_GTC(tblPart_iStatus_C.Day_Offline));
            output.Add(tblPart_iStatus_C.Hoc_Bu, GetTextConstants.tblPart_iStatus_GTC(tblPart_iStatus_C.Hoc_Bu));
            output.Add(tblPart_iStatus_C.Nghi, GetTextConstants.tblPart_iStatus_GTC(tblPart_iStatus_C.Nghi));
            output.Add(tblPart_iStatus_C.Thi, GetTextConstants.tblPart_iStatus_GTC(tblPart_iStatus_C.Thi));
            output.Add(tblPart_iStatus_C.Kiem_Tra_Giua_Ky, GetTextConstants.tblPart_iStatus_GTC(tblPart_iStatus_C.Kiem_Tra_Giua_Ky));
            return output;
        }

        /// <summary> tblSubject_iStatus_GLC </summary>
        /// <returns></returns>
        public static SortedList tblSubject_iStatus_GLC()
        {
            SortedList output = new SortedList();
            output.Add(tblSubject_iStatus_C.Mo, GetTextConstants.tblSubject_iStatus_GTC(tblSubject_iStatus_C.Mo));
            output.Add(tblSubject_iStatus_C.Tam_Khoa, GetTextConstants.tblSubject_iStatus_GTC(tblSubject_iStatus_C.Tam_Khoa));
            output.Add(tblSubject_iStatus_C.Khoa, GetTextConstants.tblSubject_iStatus_GTC(tblSubject_iStatus_C.Khoa));
            return output;
        }

        /// <summary> tblSubject_Student_iStatus_GLC </summary>
        /// <returns></returns>
        public static SortedList tblSubject_Student_iStatus_GLC()
        {
            SortedList output = new SortedList();
            output.Add(tblSubject_Student_iStatus_C.Hoc, GetTextConstants.tblSubject_Student_iStatus_GTC(tblSubject_Student_iStatus_C.Hoc));
            output.Add(tblSubject_Student_iStatus_C.Vao_Muon, GetTextConstants.tblSubject_Student_iStatus_GTC(tblSubject_Student_iStatus_C.Vao_Muon));
            output.Add(tblSubject_Student_iStatus_C.Nghi, GetTextConstants.tblSubject_Student_iStatus_GTC(tblSubject_Student_iStatus_C.Nghi));
            return output;
        }

        /// <summary> Emoticons_GLC (Biểu tượng cảm xúc) </summary>
        /// <returns></returns>
        public static SortedList Emoticons_GLC()
        {
            SortedList output = new SortedList();
            output.Add(Emoticons_C.Icon_1, GetTextConstants.Emoticons_GTC(Emoticons_C.Icon_1));
            output.Add(Emoticons_C.Icon_2, GetTextConstants.Emoticons_GTC(Emoticons_C.Icon_2));
            output.Add(Emoticons_C.Icon_3, GetTextConstants.Emoticons_GTC(Emoticons_C.Icon_3));
            output.Add(Emoticons_C.Icon_4, GetTextConstants.Emoticons_GTC(Emoticons_C.Icon_4));
            output.Add(Emoticons_C.Icon_5, GetTextConstants.Emoticons_GTC(Emoticons_C.Icon_5));
            output.Add(Emoticons_C.Icon_6, GetTextConstants.Emoticons_GTC(Emoticons_C.Icon_6));
            output.Add(Emoticons_C.Icon_7, GetTextConstants.Emoticons_GTC(Emoticons_C.Icon_7));
            output.Add(Emoticons_C.Icon_8, GetTextConstants.Emoticons_GTC(Emoticons_C.Icon_8));
            output.Add(Emoticons_C.Icon_9, GetTextConstants.Emoticons_GTC(Emoticons_C.Icon_9));
            return output;
        }

        /// <summary> I.5.  ChiTietGiaoTrinh_iTrangThai_GLC (Trạng Thái Chi Tiết Giáo Trình) </summary>
        /// <returns></returns>
        public static SortedList ChiTietGiaoTrinh_iTrangThai_GLC()
        {
            SortedList output = new SortedList();
            output.Add(tblMaterial_iStatus_C.Mo, GetTextConstants.tblMaterial_iStatus_GTC(tblMaterial_iStatus_C.Mo));
            output.Add(tblMaterial_iStatus_C.Khoa, GetTextConstants.tblMaterial_iStatus_GTC(tblMaterial_iStatus_C.Khoa));
            return output;
        }

        /// <summary> I.5.  ChiTietGiaoTrinh_iType_GLC (Loại Chi Tiết Giáo Trình) </summary>
        /// <returns></returns>
        public static SortedList ChiTietGiaoTrinh_iType_GLC()
        {
            SortedList output = new SortedList();
            output.Add(tblMaterial_iType_C.Video, GetTextConstants.tblMaterial_iType_GTC(tblMaterial_iType_C.Video));
            output.Add(tblMaterial_iType_C.Pdf, GetTextConstants.tblMaterial_iType_GTC(tblMaterial_iType_C.Pdf));
            output.Add(tblMaterial_iType_C.Other, GetTextConstants.tblMaterial_iType_GTC(tblMaterial_iType_C.Other));
            return output;
        }
    }
}