using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HaBa.EntityObject
{
    [Serializable()]
    public class tblSanPhamEO
    {
        private string _PK_sSanPhamID;
        private Int16 _FK_iNhomSanPhamID;
        private string _sTenSanPham;
        private string _sMoTa;
        private string _sThongTin;
        private string _sXuatXu;
        private string _sLinkImage;
        private Int64 _lGiaBan;
        private Int16 _iVAT;
        private Int16 _iDoTuoi;
        private Int16 _iGioiTinh;
        private Int16 _iSoLuong;
        private DateTime _tNgayCapNhat;
        private Int16 _iTrangThai;

        // 1. Xay dung cac phuong thuc set, get cho PK_sSanPhamID
        public string PK_sSanPhamID
        {
            get { return this._PK_sSanPhamID; }
            set { this._PK_sSanPhamID = value; }
        }

        // 2. Xay dung cac phuong thuc set, get cho FK_iNhomSanPhamID
        public Int16 FK_iNhomSanPhamID
        {
            get { return this._FK_iNhomSanPhamID; }
            set { this._FK_iNhomSanPhamID = value; }
        }

        // 3. Xay dung cac phuong thuc set, get cho sTenSanPham
        public string sTenSanPham
        {
            get { return this._sTenSanPham; }
            set { this._sTenSanPham = value; }
        }

        // 4. Xay dung cac phuong thuc set, get cho sMoTa
        public string sMoTa
        {
            get { return this._sMoTa; }
            set { this._sMoTa = value; }
        }

        // 4. Xay dung cac phuong thuc set, get cho sThongTin
        public string sThongTin
        {
            get { return this._sThongTin; }
            set { this._sThongTin = value; }
        }

        // 5. Xay dung cac phuong thuc set, get cho sXuatXu
        public string sXuatXu
        {
            get { return this._sXuatXu; }
            set { this._sXuatXu = value; }
        }

        // 6. Xay dung cac phuong thuc set, get cho sLinkImage
        public string sLinkImage
        {
            get { return this._sLinkImage; }
            set { this._sLinkImage = value; }
        }

        // 7. Xay dung cac phuong thuc set, get cho lGiaBan
        public Int64 lGiaBan
        {
            get { return this._lGiaBan; }
            set { this._lGiaBan = value; }
        }

        // 8. Xay dung cac phuong thuc set, get cho iVAT
        public Int16 iVAT
        {
            get { return this._iVAT; }
            set { this._iVAT = value; }
        }

        // 9. Xay dung cac phuong thuc set, get cho iDoTuoi
        public Int16 iDoTuoi
        {
            get { return this._iDoTuoi; }
            set { this._iDoTuoi = value; }
        }

        // 10. Xay dung cac phuong thuc set, get cho iGioiTinh
        public Int16 iGioiTinh
        {
            get { return this._iGioiTinh; }
            set { this._iGioiTinh = value; }
        }

        // 11. Xay dung cac phuong thuc set, get cho iSoLuong
        public Int16 iSoLuong
        {
            get { return this._iSoLuong; }
            set { this._iSoLuong = value; }
        }

        // 12. Xay dung cac phuong thuc set, get cho tNgayCapNhat
        public DateTime tNgayCapNhat
        {
            get { return this._tNgayCapNhat; }
            set { this._tNgayCapNhat = value; }
        }

        // 13. Xay dung cac phuong thuc set, get cho iTrangThai
        public Int16 iTrangThai
        {
            get { return this._iTrangThai; }
            set { this._iTrangThai = value; }
        }
    }
}