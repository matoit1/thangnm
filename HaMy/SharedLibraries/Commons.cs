using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Text.RegularExpressions;
using System.Collections;

namespace HaMy.SharedLibraries
{
    public class Commons
    {
        public static DataTable Convert_SortList_To_DataTable(SortedList _SortedList)
        {
            DataTable tb = new DataTable("tblTrangThai");
            tb.Columns.Add("Key");
            tb.Columns.Add("Value");
            for (int i = 0; i < _SortedList.Count; i++)
            {
                DataRow dr = tb.NewRow();
                dr[0] = _SortedList.GetKey(i);
                dr[1] = _SortedList.GetByIndex(i);
                tb.Rows.Add(dr);
            }
            return tb;
        }

        public static string GetTempDate()
        {
            string strTmpDate = System.DateTime.Now.ToShortDateString();
            strTmpDate = strTmpDate.Replace(":", "-").Trim();
            strTmpDate = strTmpDate.Replace("/", "-").Trim();
            return strTmpDate;
        }
    }

    public class Messages
    {
        #region "Error"
        public const string Khong_Thoa_Man_Dieu_Kien_Tim_Kiem = "Không thỏa mãn điều kiện tìm kiếm!";
        public const string Loi = "Lỗi: ";
        public const string Loi_Tai_Du_Lieu = "Lỗi tải dữ liệu!";
        public const string Khong_Duoc_De_Trong = "Trường này không được để trống!";
        public const string Ma_Da_Ton_Tai = "Mã đã tồn tại, vui lòng chọn mã khác!";
        public const string Ma_Khong_Hop_Le = "Mã không hợp lệ!";
        public const string Khong_Dung_Dinh_Dang_Email = "Không đúng định dạng Email, Vui lòng kiểm tra lại!";
        public const string Khong_Dung_Dinh_Dang_So_Dien_Thoai = "Không đúng định dạng Số điện thoại, Vui lòng kiểm tra lại!";
        public const string Khong_Dung_Dinh_Dang_So_Dien_Thoai_Do_Dai = "Số điện thoại phải trong khoảng 10 số < sđt < 13 số, Vui lòng kiểm tra lại!";
        public const string Khong_Dung_Dinh_Dang_So = "Không đúng định dạng Số, Vui lòng kiểm tra lại!";
        public const string Khong_Dung_Dinh_Dang_Ngay = "Không đúng định dạng Ngày/ Giờ, Vui lòng kiểm tra lại!";
        public const string Bat_Dau_Ket_Thuc = "Thời gian kết thúc phải lớn hơn bắt đầu";
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
        public static readonly string Format_DateTime_Temp = Convert.ToString(DateTime.Now.ToString("dd-MM-yyyy"));
        public static readonly string Format_DateTime = "dd/MM/yyyy";
        public static readonly string Format_Number = "###,##0.######";
        public static readonly string Viet_Nam_Dong = " VNĐ";
        #endregion

    }
}