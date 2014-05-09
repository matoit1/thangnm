using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Text.RegularExpressions;

namespace Shared_Libraries
{
    public class Common
    {
        public static string ShowIconByKey(string sInput){
            string sOutput = "";
            sOutput = sInput.Replace(":)", "<img src=\"../../Images/Smileys/1.gif\" />");
            sOutput = sOutput.Replace(":(", "<img src=\"../../Images/Smileys/2.gif\" />");
            sOutput = sOutput.Replace(":))", "<img src=\"../../Images/Smileys/3.gif\" />");
            sOutput = sOutput.Replace(":D", "<img src=\"../../Images/Smileys/4.gif\" />");
            sOutput = sOutput.Replace("=))", "<img src=\"../../Images/Smileys/5.gif\" />");
            sOutput = sOutput.Replace("<3", "<img src=\"../../Images/Smileys/6.gif\" />");
            return sOutput;
        }

        public static string ConvertToUnSign(string text)
        {
            for (int i = 32; i < 48; i++)
            {
                if(i!=46){
                text = text.Replace(((char)i).ToString(), " ");
                }
            }
            //text = text.Replace(".", "-");
            text = text.Replace(" ", "-");
            text = text.Replace(",", "-");
            text = text.Replace(";", "-");
            text = text.Replace(":", "-");
            Regex regex = new Regex(@"\p{IsCombiningDiacriticalMarks}+");
            string strFormD = text.Normalize(System.Text.NormalizationForm.FormD);
            return regex.Replace(strFormD, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }

        public static Int16 CaHocHienTai()
        {
            switch (DateTime.Now.Hour)
            {
                case 7:
                case 8:
                case 9:
                case 10:
                case 11: return 1;
                case 13:
                case 14:
                case 15:
                case 16:
                case 17: return 2;
                case 18:
                case 19:
                case 20:
                case 21:
                case 22: return 3;
                default: return 0;
            }
        }

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
    }

    public class RewriteUrl
    {
        public static string ConvertToUnSign(string text)
        {
            for (int i = 32; i < 48; i++)
            {
                text = text.Replace(((char)i).ToString(), " ");
            }
            text = text.Replace(".", "-");
            text = text.Replace(" ", "-");
            text = text.Replace(",", "-");
            text = text.Replace(";", "-");
            text = text.Replace(":", "-");
            Regex regex = new Regex(@"\p{IsCombiningDiacriticalMarks}+");
            string strFormD = text.Normalize(System.Text.NormalizationForm.FormD);
            return regex.Replace(strFormD, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }
    }

    public class Messages
    {
        #region "ChatRoom"
        public const string ChatRoom_Hide_Fail = "Ẩn tin nhắn không thành công !";
        public const string ChatRoom_Hide_Success = "Ẩn tin nhắn thành công !";
        public const string ChatRoom_Fail = "Gửi tin nhắn không thành công !";
        public const string ChatRoom_Limit = "Bạn không được phép gửi tin nhắn nữa !";
        public const string ChatRoom_BlackList_Fail = "Chặn không thành công !";
        public const string ChatRoom_BlackList_Success = "Chặn thành công !";
        public const int ChatRoom_MaxRooms = 10;
        public const int ChatRoom_SessionTimeout = 5;
        public const int ChatRoom_MaxUsers = 50;
        #endregion

        #region "Error"
        public const string Khong_Thoa_Man_Dieu_Kien_Tim_Kiem = "Không thỏa mãn điều kiện tìm kiếm!";
        public const string Loi = "Lỗi: ";
        public const string Loi_Tai_Du_Lieu = "Lỗi tải dữ liệu!";
        public const string Ma_Da_Ton_Tai = "Mã đã tồn tại, vui lòng chọn mã khác!";
        public const string Ma_Khong_Hop_Le = "Mã không hợp lệ!";
        public const string Khong_Dung_Dinh_Dang_So = "Không đúng định dạng số, Vui lòng kiểm tra lại!";
        public const string Khong_Dung_Dinh_Dang_Ngay = "Không đúng định dạng ngày/ giờ, Vui lòng kiểm tra lại!";
        #endregion

        #region "Information"
        public const string Tong_So_Ban_Ghi = "Tổng số bản ghi: ";
        public const string Them_Thanh_Cong = "Thêm thành công!";
        public const string Them_That_Bai = "Thêm thất bại, vui lòng kiểm tra lại!";
        public const string Sua_Thanh_Cong = "Sửa thành công!";
        public const string Sua_That_Bai = "Sửa thất bại, vui lòng kiểm tra lại!";
        public const string Xoa_Thanh_Cong = "Xóa thành công!";
        public const string Xoa_That_Bai = "Xóa thất bại, vui lòng kiểm tra lại!";
        public const string Ngay_Day_Khong_Hop_Le = "Ngày dạy phải nằm trong khoảng: ";
        #endregion

        #region "Information"
        public const string Chua_Den_Thoi_Gian_Hoc = "Chưa đến thời gian học!";
        public const string Buoi_Hoc_Hom_Nay_Duoc_Nghi = "Buổi học hôm nay được nghỉ!";
        public const string Ca_Hoc_Hien_Tai_La = "Ca học hiện tại là: ";
        #endregion

        #region "Security"
        public const string Dang_Nhap_Thanh_Cong = "Đăng nhập thành công!";
        public const string Dang_Nhap_That_Bai = "Đăng nhập thất bại, vui lòng kiểm tra lại!";
        public const string Doi_Mat_Khau_That_Bai = "Đổi mật khẩu thất bại, vui lòng kiểm tra lại!";
        public const string Doi_Mat_Khau_Thanh_Cong = "Đổi mật khẩu thành công!";
        public const string Gui_Mail_Doi_Mat_Khau_Thanh_Cong = "Hệ thống đã gửi mật khẩu mới vào Email của bạn!";
        public const string Gui_Mail_Doi_Mat_Khau_That_Bai = "Không thể kết nối tới Email!";
        public const string Sai_Ten_Tai_Khoan = "Tài khoản không đúng, Vui lòng thử lại!";
        public const string Sai_Email = "Email không đúng, Vui lòng thử lại!";
        public const string Sai_Mat_Khau = "Mật khẩu không đúng, Vui lòng thử lại!";
        public const string Sai_Ten_Tai_Khoan_Hoac_Email = "Không có tên tài khoản và email nào trùng khớp. Vui lòng kiểm tra lại!";
        public const string Sai_Email_Hoac_So_Dien_Thoai = "Không có email và số điện thoại nào trùng khớp. Vui lòng kiểm tra lại!";
        public const string Sai_Captcha = "Captcha không chính xác, vui lòng kiểm tra lại!";
        #endregion

        #region "Format"
        public static readonly string DateTime_Temp = Convert.ToString(DateTime.Now.ToString("dd-MM-yyyy"));
        #endregion

        #region "tblCauHoi"
        public const string Thi_Trac_Nghiem_Mon = "THI TRẮC NGHIỆM MÔN: ";
        public const string Ban_Da_Tra_Loi_Dung = "Bạn đã trả lời đúng: ";
        public const string Tra_Loi_Dung = "Bạn đã trả lời đúng!";
        public const string Tra_Loi_Sai = "Bạn đã trả lời sai!";
        public const string Cham_Diem_Thanh_Cong = "Chấm điểm thành công!";
        public const string Cham_Diem_Khong_Thanh_Cong = "Chấm điểm không thành công!";
        public const string Het_Thoi_Gian_Tra_Loi_Cau_Hoi = "Hết thời gian trả lời câu hỏi! ";
        #endregion

        #region "Upload"
        public const string Video = "Video/";
        public const string Ebook = "Ebook/";
        public const string Example = "Example/";
        public const string Other = "Other/";
        public const string Upload_Hoc_Lieu = "Upload học liệu";
        public const string UpLoad_Video_Giang_Day = "Upload video giảng dạy";
        public const string Upload_Bai_Kiem_Tra = "Upload bài kiểm tra";
        public const string Tai_Len_Thanh_Cong = "Tải lên thành công!";
        #endregion
    }
}