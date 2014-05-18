using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HaMy.EntityObject
{
    [Serializable()]
    public class tblDoiTacEO
    {
        private Int32 _FK_iNhom;
        private Int32 _PK_iDoiTac;
        private String _sHoTen;
        private String _sDiaChi;
        private String _sEmail;
        private String _sSoDienThoai;
        private DateTime _tNgaySinh;
        private Boolean _bGioiTinh;
        private String _sNgheNghiep;
        private Int32 _FK_iMoiQuanHe;
        private String _sGhiChu;
        private Int16 _iTrangThai;

        // 1. Xay dung cac phuong thuc set, get cho FK_iNhom
        public Int32 FK_iNhom
        {
            get { return this._FK_iNhom; }
            set { this._FK_iNhom = value; }
        }

        // 2. Xay dung cac phuong thuc set, get cho PK_iDoiTac
        public Int32 PK_iDoiTac
        {
            get { return this._PK_iDoiTac; }
            set { this._PK_iDoiTac = value; }
        }

        // 3. Xay dung cac phuong thuc set, get cho sHoTen
        public String sHoTen
        {
            get { return this._sHoTen; }
            set { this._sHoTen = value; }
        }

        // 4. Xay dung cac phuong thuc set, get cho sDiaChi
        public String sDiaChi
        {
            get { return this._sDiaChi; }
            set { this._sDiaChi = value; }
        }

        // 5. Xay dung cac phuong thuc set, get cho sEmail
        public String sEmail
        {
            get { return this._sEmail; }
            set { this._sEmail = value; }
        }

        // 6. Xay dung cac phuong thuc set, get cho sSoDienThoai
        public string sSoDienThoai
        {
            get { return this._sSoDienThoai; }
            set { this._sSoDienThoai = value; }
        }

        // 7. Xay dung cac phuong thuc set, get cho tNgaySinh
        public DateTime tNgaySinh
        {
            get { return this._tNgaySinh; }
            set { this._tNgaySinh = value; }
        }

        // 8. Xay dung cac phuong thuc set, get cho bGioiTinh
        public Boolean bGioiTinh
        {
            get { return this._bGioiTinh; }
            set { this._bGioiTinh = value; }
        }

        // 9. Xay dung cac phuong thuc set, get cho sNgheNghiep
        public String sNgheNghiep
        {
            get { return this._sNgheNghiep; }
            set { this._sNgheNghiep = value; }
        }

        // 10. Xay dung cac phuong thuc set, get cho FK_iMoiQuanHe
        public Int32 FK_iMoiQuanHe
        {
            get { return this._FK_iMoiQuanHe; }
            set { this._FK_iMoiQuanHe = value; }
        }

        // 11. Xay dung cac phuong thuc set, get cho sGhiChu
        public String sGhiChu
        {
            get { return this._sGhiChu; }
            set { this._sGhiChu = value; }
        }

        // 12. Xay dung cac phuong thuc set, get cho iTrangThai
        public Int16 iTrangThai
        {
            get { return this._iTrangThai; }
            set { this._iTrangThai = value; }
        }
    }
}