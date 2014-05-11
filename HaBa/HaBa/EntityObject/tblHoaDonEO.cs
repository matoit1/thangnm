using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HaBa.EntityObject
{
    [Serializable()]
    public class tblHoaDonEO
    {
        private Int64 _PK_lHoaDonID;
        private int _FK_iTaiKhoanID_Giao;
        private int _FK_iTaiKhoanID_Nhan;
        private Int16 _FK_iThanhToanID;
        private string _sHoTen;
        private string _sEmail;
        private string _sDiaChi;
        private string _sSoDienThoai;
        private string _sGhiChu;
        private DateTime _tNgayDatHang;
        private DateTime _tNgayGiaoHang;
        private Int16 _iTrangThai;

        // 1. Xay dung cac phuong thuc set, get cho PK_lHoaDonID
        public Int64 PK_lHoaDonID
        {
            get { return this._PK_lHoaDonID; }
            set { this._PK_lHoaDonID = value; }
        }

        // 2. Xay dung cac phuong thuc set, get cho FK_iTaiKhoanID_Giao
        public int FK_iTaiKhoanID_Giao
        {
            get { return this._FK_iTaiKhoanID_Giao; }
            set { this._FK_iTaiKhoanID_Giao = value; }
        }

        // 3. Xay dung cac phuong thuc set, get cho FK_iTaiKhoanID_Nhan
        public int FK_iTaiKhoanID_Nhan
        {
            get { return this._FK_iTaiKhoanID_Nhan; }
            set { this._FK_iTaiKhoanID_Nhan = value; }
        }

        // 4. Xay dung cac phuong thuc set, get cho Pay_ID
        public Int16 FK_iThanhToanID
        {
            get { return this._FK_iThanhToanID; }
            set { this._FK_iThanhToanID = value; }
        }

        // 5. Xay dung cac phuong thuc set, get cho sHoTen
        public string sHoTen
        {
            get { return this._sHoTen; }
            set { this._sHoTen = value; }
        }

        // 6. Xay dung cac phuong thuc set, get cho sEmail
        public string sEmail
        {
            get { return this._sEmail; }
            set { this._sEmail = value; }
        }

        // 7. Xay dung cac phuong thuc set, get cho sDiaChi
        public string sDiaChi
        {
            get { return this._sDiaChi; }
            set { this._sDiaChi = value; }
        }

        // 8. Xay dung cac phuong thuc set, get cho sSoDienThoai
        public string sSoDienThoai
        {
            get { return this._sSoDienThoai; }
            set { this._sSoDienThoai = value; }
        }

        // 9. Xay dung cac phuong thuc set, get cho sGhiChu
        public string sGhiChu
        {
            get { return this._sGhiChu; }
            set { this._sGhiChu = value; }
        }

        // 11. Xay dung cac phuong thuc set, get cho tNgayDatHang
        public DateTime tNgayDatHang
        {
            get { return this._tNgayDatHang; }
            set { this._tNgayDatHang = value; }
        }

        // 12. Xay dung cac phuong thuc set, get cho tNgayGiaoHang
        public DateTime tNgayGiaoHang
        {
            get { return this._tNgayGiaoHang; }
            set { this._tNgayGiaoHang = value; }
        }

        // 13. Xay dung cac phuong thuc set, get cho iTrangThai
        public Int16 iTrangThai
        {
            get { return this._iTrangThai; }
            set { this._iTrangThai = value; }
        }
    }
}