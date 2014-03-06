using System.Xml.Serialization;
using System.IO;

namespace nguyenmanhthang.Library.Common
{
    public class Utils{
        public enum ButtonType{
            [Thoat] = 1;
            [QuayLai] = 2;
            [LamMoiDanhSach] = 3;
            [ChapNhan] = 4;
            [GhiLai] = 5;
            [TuChoi] = 6;
            [TimKiem] = 7;
            [PhanCong] = 8
            [DoiPhanCong] = 9;
            [In] = 10;
            [HoanThanhKiemHoa] = 11;
            [ThayDoiCotHienThi] = 12;
            [Them] = 13;
            [Xoa] = 14;
        }
        public void SetButtonToolbar(ToolBarButton  btn, ButtonType)
            Select Case type
                Case ButtonType.Thoat
                    With btn
                        .Text = "Thoát"
                        .ImageUrl = "/_layouts/images/EXIT.GIF"
                        .AccessKey = "Q"
                    End With
                Case ButtonType.QuayLai
                    With btn
                        .Text = "Quay lại"
                        .ImageUrl = "/_layouts/images/UNDO.GIF"
                        .AccessKey = "B"
                    End With
                Case ButtonType.LamMoiDanhSach
                    With btn
                        .Text = "Làm mới danh sách"
                        .ImageUrl = "/_layouts/images/REFRESH.GIF"
                        .AccessKey = "R"
                    End With
                Case ButtonType.ChapNhan
                    With btn
                        .Text = "Chấp nhận"
                        .ImageUrl = "/_layouts/images/ISSUES.GIF"
                        .AccessKey = "A"
                    End With
                Case ButtonType.GhiLai
                    With btn
                        .Text = "Ghi lại"
                        .ImageUrl = "/_layouts/images/SAVE.GIF"
                        .AccessKey = "S"
                    End With
                Case ButtonType.TuChoi
                    With btn
                        .Text = "Từ chối"
                        .ImageUrl = "/_layouts/images/UNAPPRV.GIF"
                        .AccessKey = "U"
                    End With
                Case ButtonType.TimKiem
                    With btn
                        .Text = "Tìm kiếm"
                        .ImageUrl = "/_layouts/images/searchqry.gif"
                        .AccessKey = "F"
                    End With
                Case ButtonType.PhanCong
                    With btn
                        .Text = "Phân công"
                        .ImageUrl = "/_layouts/images/ribbon_userprofile_16.png"
                        .AccessKey = "P"
                    End With
                Case ButtonType.DoiPhanCong
                    With btn
                        .Text = "Đổi phân công"
                        .ImageUrl = "/_layouts/images/synchronizationtitle.png"
                        .AccessKey = "D"
                    End With
                Case ButtonType.In
                    With btn
                        .Text = "In"
                        .ImageUrl = "/_layouts/images/printerfriendly.gif"
                        .AccessKey = "I"
                    End With


                Case ButtonType.HoanThanhKiemHoa
                    With btn
                        .Text = "Hoàn Thành Kiểm Hóa"
                        .ImageUrl = "/_layouts/images/SAVE.GIF"
                        .AccessKey = "S"
                    End With

                Case ButtonType.ThayDoiCotHienThi
                    With btn
                        .Text = "Thay Đổi Cột Hiển Thị"
                        .ImageUrl = "/_layouts/images/CHNGCOL.GIF"
                        .AccessKey = "C"
                    End With
                Case ButtonType.Them
                    With btn
                        .Text = "Thêm"
                        .ImageUrl = "/_layouts/images/advadd.png"
                        .AccessKey = "N"
                    End With
                Case ButtonType.Xoa
                    With btn
                        .Text = "Xóa"
                        .ImageUrl = "/_layouts/images/DELITEM.GIF"
                        .AccessKey = "X"
                    End With
                Case Else
            End Select
        End Sub

#region "Đổi số nguyên ra chữ"
        public string Group3ToStrX(string num){
            Dim No As String() = {"không", "một", "hai", "ba", "bốn", "năm", _
             "sáu", "bảy", "tám", "chín"}
            Dim kq As String, tram As String, chuc As String, donvi As String
            ' Trăm
            If num.Substring(0, 1) = "0" Then
                tram = ""
            Else
                tram = No(Convert.ToByte(num.Substring(0, 1))) & " trăm "
            End If
            ' Chục
            Select Case num.Substring(1, 1)
                Case "0"
                    If num.Substring(2, 1) <> "0" AndAlso num.Substring(0, 1) <> "0" Then
                        chuc = "linh "
                    Else
                        chuc = ""
                    End If


                    Exit Select
                Case "1"
                    chuc = "mười "
                    Exit Select
                Case Else
                    chuc = No(Convert.ToByte(num.Substring(1, 1))) & " mươi "
                    Exit Select
            End Select
            ' Đơn vị
            Select Case num.Substring(2, 1)
                Case "0"
                    donvi = ""
                    Exit Select
                Case "1"
                    If (num.Substring(1, 1) = "0") OrElse (num.Substring(1, 1) = "1") Then
                        donvi = "một"
                    Else
                        donvi = "mốt"
                    End If


                    Exit Select
                Case "5"
                    If num.Substring(1, 1) <> "0" Then
                        donvi = "lăm"
                    Else
                        donvi = "năm"
                    End If


                    Exit Select
                Case Else
                    donvi = No(Convert.ToByte(num.Substring(2, 1)))
                    Exit Select
            End Select
            kq = tram + chuc + donvi
            Return kq
        }

        public string IntNumStr(string num){
            string Cap = {"", " nghìn ", " triệu ", " tỷ ", " nghìn tỷ ", " triệu tỷ ", " tỷ tỷ ", " nghìn tỷ tỷ "}
            string kq= "";
            string str = num;
            string g3;
            string kqtg;
            int caps = 0;
            while (str.Length() > 3){
                g3 = str.Substring(str.Length - 3, 3);
                str = str.Substring(0, str.Length - 3);
                if (g3 != "000"){
                    kqtg = Group3ToStrX(g3) + Cap(Convert.ToByte(caps));
                }
                else{
                    kqtg = "";
                }
                kq = kqtg + kq;
                caps += 1;
            }
            //Chuẩn bị trước khi sử dụng hàm Group32Str1
            while (str.Length < 3){
                str = "0" & str;
            }

            if (str = "000") and Also (num.Length <= 3) Then
                kqtg = "không"
            Else
                kqtg = Group3ToStrX(str) + Cap(Convert.ToByte(caps))
            End If
            kq = kqtg + kq
            return kq;
        }
    #endregion

        public string Unicode2TCVN(string Data){
            Const TCVNMap As String = "¸µ¶·¹¨¾»¼½Æ©ÊÇÈÉËÐÌÎÏÑªÕÒÓÔÖÝ×ØÜÞãßáâä«èåæçé¬íêëìîóïñòô­øõö÷ùýúûüþ®¸µ¶·¹¡¾»¼½Æ¢ÊÇÈÉËÐÌÎÏÑ£ÕÒÓÔÖÝ×ØÜÞãßáâä¤èåæçé¥íêëìîóïñòô¦øõö÷ùýúûüþ§§"
            Const UnicodeMap As String = "áàảãạăắằẳẵặâấầẩẫậéèẻẽẹêếềểễệíìỉĩịóòỏõọôốồổỗộơớờởỡợúùủũụưứừửữựýỳỷỹỵđÁÀẢÃẠĂẮẰẲẴẶÂẤẦẨẪẬÉÈẺẼẸÊẾỀỂỄỆÍÌỈĨỊÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢÚÙỦŨỤƯỨỪỬỮỰÝỲỶỸỴĐÐ"
            If Data = "" Then Return ""
            Dim i, pos As Integer
            Dim Result As StringBuilder = New StringBuilder(Data.Length)
            For i = 0 To Data.Length - 1
                pos = UnicodeMap.IndexOf(Data.Chars(i))
                If pos >= 0 Then
                    Result.Append(TCVNMap.Chars(pos))
                Else
                    Result.Append(Data.Chars(i))
                End If
            Next
            return Result.ToString();
        }


        public string TCVN2Unicode(string Data){
            Const TCVNMap As String = "¸µ¶·¹¨¾»¼½Æ©ÊÇÈÉËÐÌÎÏÑªÕÒÓÔÖÝ×ØÜÞãßáâä«èåæçé¬íêëìîóïñòô­øõö÷ùýúûüþ®¸µ¶·¹¡¾»¼½Æ¢ÊÇÈÉËÐÌÎÏÑ£ÕÒÓÔÖÝ×ØÜÞãßáâä¤èåæçé¥íêëìîóïñòô¦øõö÷ùýúûüþ§§"
            Const UnicodeMap As String = "áàảãạăắằẳẵặâấầẩẫậéèẻẽẹêếềểễệíìỉĩịóòỏõọôốồổỗộơớờởỡợúùủũụưứừửữựýỳỷỹỵđÁÀẢÃẠĂẮẰẲẴẶÂẤẦẨẪẬÉÈẺẼẸÊẾỀỂỄỆÍÌỈĨỊÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢÚÙỦŨỤƯỨỪỬỮỰÝỲỶỸỴĐÐ"
            If Data = "" Then Return ""
            Dim i, pos As Integer
            Dim Result As StringBuilder = New StringBuilder(Data.Length)
            For i = 0 To Data.Length - 1
                pos = TCVNMap.IndexOf(Data.Chars(i))
                If pos >= 0 Then
                    Result.Append(UnicodeMap.Chars(pos))
                Else
                    Result.Append(Data.Chars(i))
                End If
            Next
            Return Result.ToString
        }

        public string CorrectForXMLAttr(string data){
            string s= string.empty;
            // http://support.microsoft.com/kb/316063
            if not String.IsNullOrEmpty(data){
                s = data.Replace("&", "&amp;").Replace("<", "&lt;").Replace(">", "&gt;").Replace("""", "&quot;").Replace("'", "&apos;");
            }
            return s;
        }
    }
}