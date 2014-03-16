using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityObject
{
    public class BaiVietEO
    {
        private string _FK_sMaGV;
        private Int64 _PK_lMaBaiViet;
        private string _sTieuDe;
        private string _sLinkAnh;
        private string _sTag;
        private string _sNoiDung;
        private int _iLuotXem;
        private DateTime _tNgayViet;
        private DateTime _tNgayCapNhat;
        private string _sMoTa;
        private Int16 _iTrangThai;

        #region "Properties"
        // 1. Xay dung cac phuong thuc set, get cho FK_sMaGV
        public string FK_sMaGV
        {
            get { return this._FK_sMaGV; }
            set { this._FK_sMaGV = value; }
        }

        // 2. Xay dung cac phuong thuc set, get cho PK_lMaBaiViet
        public Int64 PK_lMaBaiViet
        {
            get { return this._PK_lMaBaiViet; }
            set { this._PK_lMaBaiViet = value; }
        }

        // 3. Xay dung cac phuong thuc set, get cho sTieuDe
        public string sTieuDe
        {
            get { return this._sTieuDe; }
            set { this._sTieuDe = value; }
        }

        // 4. Xay dung cac phuong thuc set, get cho sLinkAnh
        public string sLinkAnh
        {
            get { return this._sLinkAnh; }
            set { this._sLinkAnh = value; }
        }

        // 5. Xay dung cac phuong thuc set, get cho sTag
        public string sTag
        {
            get { return this._sTag; }
            set { this._sTag = value; }
        }

        // 6. Xay dung cac phuong thuc set, get cho sNoiDung
        public string sNoiDung
        {
            get { return this._sNoiDung; }
            set { this._sNoiDung = value; }
        }

        // 7. Xay dung cac phuong thuc set, get cho iLuotXem
        public int iLuotXem
        {
            get { return this._iLuotXem; }
            set { this._iLuotXem = value; }
        }

        // 8. Xay dung cac phuong thuc set, get cho tNgayViet
        public DateTime tNgayViet
        {
            get { return this._tNgayViet; }
            set { this._tNgayViet = value; }
        }

        // 9. Xay dung cac phuong thuc set, get cho tNgayCapNhat
        public DateTime tNgayCapNhat
        {
            get { return this._tNgayCapNhat; }
            set { this._tNgayCapNhat = value; }
        }

        // 10. Xay dung cac phuong thuc set, get cho sMoTa
        public string sMoTa
        {
            get { return this._sMoTa; }
            set { this._sMoTa = value; }
        }

        // 11. Xay dung cac phuong thuc set, get cho iTrangThai
        public Int16 iTrangThai
        {
            get { return this._iTrangThai; }
            set { this._iTrangThai = value; }
        }
        #endregion
    }
}