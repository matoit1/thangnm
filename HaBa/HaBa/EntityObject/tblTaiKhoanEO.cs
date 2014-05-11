using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HaBa.EntityObject
{
    [Serializable()]
    public class tblTaiKhoanEO
    {
        private int _PK_iTaiKhoanID;
        private string _sTenDangNhap;
        private string _sMatKhau;
        private string _sHoTen;
        private string _sEmail;
        private string _sDiaChi;
        private string _sSoDienThoai;
        private string _sLinkAvatar;
        private DateTime _tNgaySinh;
        private DateTime _tNgayDangKy;
        private Int16 _iQuyenHan;
        private Int16 _iTrangThai;

        // 1. Xay dung cac phuong thuc set, get cho PK_iTaiKhoanID
        public int PK_iTaiKhoanID
        {
            get { return this._PK_iTaiKhoanID; }
            set { this._PK_iTaiKhoanID = value; }
        }

        // 2. Xay dung cac phuong thuc set, get cho sHoTen
        public string sHoTen
        {
            get { return this._sHoTen; }
            set { this._sHoTen = value; }
        }

        // 3. Xay dung cac phuong thuc set, get cho sTenDangNhap
        public string sTenDangNhap
        {
            get { return this._sTenDangNhap; }
            set { this._sTenDangNhap = value; }
        }

        // 4. Xay dung cac phuong thuc set, get cho sMatKhau
        public string sMatKhau
        {
            get { return this._sMatKhau; }
            set { this._sMatKhau = value; }
        }

        // 5. Xay dung cac phuong thuc set, get cho sEmail
        public string sEmail
        {
            get { return this._sEmail; }
            set { this._sEmail = value; }
        }

        // 6. Xay dung cac phuong thuc set, get cho sDiaChi
        public string sDiaChi
        {
            get { return this._sDiaChi; }
            set { this._sDiaChi = value; }
        }

        // 7. Xay dung cac phuong thuc set, get cho sSoDienThoai
        public string sSoDienThoai
        {
            get { return this._sSoDienThoai; }
            set { this._sSoDienThoai = value; }
        }

        // 8. Xay dung cac phuong thuc set, get cho sLinkAvatar
        public string sLinkAvatar
        {
            get { return this._sLinkAvatar; }
            set { this._sLinkAvatar = value; }
        }

        // 9. Xay dung cac phuong thuc set, get cho tNgaySinh
        public DateTime tNgaySinh
        {
            get { return this._tNgaySinh; }
            set { this._tNgaySinh = value; }
        }

        // 10. Xay dung cac phuong thuc set, get cho tNgayDangKy
        public DateTime tNgayDangKy
        {
            get { return this._tNgayDangKy; }
            set { this._tNgayDangKy = value; }
        }

        // 11. Xay dung cac phuong thuc set, get cho iQuyenHan
        public Int16 iQuyenHan
        {
            get { return this._iQuyenHan; }
            set { this._iQuyenHan = value; }
        }

        // 12. Xay dung cac phuong thuc set, get cho iTrangThai
        public Int16 iTrangThai
        {
            get { return this._iTrangThai; }
            set { this._iTrangThai = value; }
        }
    }
}