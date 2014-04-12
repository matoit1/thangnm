using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityObject
{
    [Serializable()]
    public class SinhVienEO
    {
        private string _FK_sMaLop;
        private string _PK_sMaSV;
        private string _sHotenSV;
        private string _sTendangnhapSV;
        private string _sMatkhauSV;
        private string _sEmailSV;
        private string _sDiachiSV;
        private string _sSdtSV;
        private DateTime _tNgaysinhSV;
        private bool _bGioitinhSV;
        private string _sCMNDSV;
        private DateTime _tNgayCapCMNDSV;
        private string _sNoiCapCMNDSV;
        private bool _bHonNhanSV;
        private string _sNguoiLienHeSV;
        private string _sDiaChiNguoiLienHeSV;
        private string _sSdtNguoiLienHeSV;
        private Int16 _iQuanHeVoiNguoiLienHeSV;
        private bool _bKetnapDoanSV;
        private Int16 _iNamketnapDoanSV;
        private string _sNoiketnapDoanSV;
        private Int16 _iNamtotnghiepTHPTSV;
        private DateTime _tNgayNhapHocSV;
        private DateTime _tNgayRaTruongSV;
        private DateTime _tNgayCapTheSV;
        private string _sLinkAvatarSV;
        private Int16 _iTrangThaiSV;

        #region "Method"
        // 1. Xay dung cac phuong thuc set, get cho FK_sMaLop
        public string FK_sMaLop
        {
            get { return this._FK_sMaLop; }
            set { this._FK_sMaLop = value; }
        }

        // 2. Xay dung cac phuong thuc set, get cho PK_sMaSV
        public string PK_sMaSV
        {
            get { return this._PK_sMaSV; }
            set { this._PK_sMaSV = value; }
        }

        // 3. Xay dung cac phuong thuc set, get cho sHotenSV
        public string sHotenSV
        {
            get { return this._sHotenSV; }
            set { this._sHotenSV = value; }
        }

        // 4. Xay dung cac phuong thuc set, get cho sTendangnhapSV
        public string sTendangnhapSV
        {
            get { return this._sTendangnhapSV; }
            set { this._sTendangnhapSV = value; }
        }

        // 5. Xay dung cac phuong thuc set, get cho sMatkhauSV
        public string sMatkhauSV
        {
            get { return this._sMatkhauSV; }
            set { this._sMatkhauSV = value; }
        }


        // 6. Xay dung cac phuong thuc set, get cho sEmailSV
        public string sEmailSV
        {
            get { return this._sEmailSV; }
            set { this._sEmailSV = value; }
        }

        // 7. Xay dung cac phuong thuc set, get cho sDiachiSV
        public string sDiachiSV
        {
            get { return this._sDiachiSV; }
            set { this._sDiachiSV = value; }
        }

        // 8. Xay dung cac phuong thuc set, get cho sSdtSV
        public string sSdtSV
        {
            get { return this._sSdtSV; }
            set { this._sSdtSV = value; }
        }

        // 9. Xay dung cac phuong thuc set, get cho tNgaysinhSV
        public DateTime tNgaysinhSV
        {
            get { return this._tNgaysinhSV; }
            set { this._tNgaysinhSV = value; }
        }
        
        // 10. Xay dung cac phuong thuc set, get cho bGioitinhSV
        public bool bGioitinhSV
        {
            get { return this._bGioitinhSV; }
            set { this._bGioitinhSV = value; }
        }

        // 11. Xay dung cac phuong thuc set, get cho sCMNDSV
        public string sCMNDSV
        {
            get { return this._sCMNDSV; }
            set { this._sCMNDSV = value; }
        }

        // 12. Xay dung cac phuong thuc set, get cho tNgayCapCMNDSV
        public DateTime tNgayCapCMNDSV
        {
            get { return this._tNgayCapCMNDSV; }
            set { this._tNgayCapCMNDSV = value; }
        }

        // 13. Xay dung cac phuong thuc set, get cho sNoiCapCMNDSV
        public string sNoiCapCMNDSV
        {
            get { return this._sNoiCapCMNDSV; }
            set { this._sNoiCapCMNDSV = value; }
        }

        // 14. Xay dung cac phuong thuc set, get cho bHonNhanSV
        public bool bHonNhanSV
        {
            get { return this._bHonNhanSV; }
            set { this._bHonNhanSV = value; }
        }

        // 15. Xay dung cac phuong thuc set, get cho sNguoiLienHeSV
        public string sNguoiLienHeSV
        {
            get { return this._sNguoiLienHeSV; }
            set { this._sNguoiLienHeSV = value; }
        }

        // 16. Xay dung cac phuong thuc set, get cho sDiaChiNguoiLienHeSV
        public string sDiaChiNguoiLienHeSV
        {
            get { return this._sDiaChiNguoiLienHeSV; }
            set { this._sDiaChiNguoiLienHeSV = value; }
        }

        // 17. Xay dung cac phuong thuc set, get cho sSdtNguoiLienHeSV
        public string sSdtNguoiLienHeSV
        {
            get { return this._sSdtNguoiLienHeSV; }
            set { this._sSdtNguoiLienHeSV = value; }
        }

        // 18. Xay dung cac phuong thuc set, get cho iQuanHeVoiNguoiLienHeSV
        public Int16 iQuanHeVoiNguoiLienHeSV
        {
            get { return this._iQuanHeVoiNguoiLienHeSV; }
            set { this._iQuanHeVoiNguoiLienHeSV = value; }
        }

        // 19. Xay dung cac phuong thuc set, get cho bKetnapDoanSV
        public bool bKetnapDoanSV
        {
            get { return this._bKetnapDoanSV; }
            set { this._bKetnapDoanSV = value; }
        }
        #endregion

        // 20. Xay dung cac phuong thuc set, get cho iNamketnapDoanSV
        public Int16 iNamketnapDoanSV
        {
            get { return this._iNamketnapDoanSV; }
            set { this._iNamketnapDoanSV = value; }
        }


        // 21. Xay dung cac phuong thuc set, get cho sNoiketnapDoanSV
        public string sNoiketnapDoanSV
        {
            get { return this._sNoiketnapDoanSV; }
            set { this._sNoiketnapDoanSV = value; }
        }

        // 22. Xay dung cac phuong thuc set, get cho iNamtotnghiepTHPTSV
        public Int16 iNamtotnghiepTHPTSV
        {
            get { return this._iNamtotnghiepTHPTSV; }
            set { this._iNamtotnghiepTHPTSV = value; }
        }

        // 23. Xay dung cac phuong thuc set, get cho tNgayNhapHocSV
        public DateTime tNgayNhapHocSV
        {
            get { return this._tNgayNhapHocSV; }
            set { this._tNgayNhapHocSV = value; }
        }

        // 24. Xay dung cac phuong thuc set, get cho tNgayRaTruongSV
        public DateTime tNgayRaTruongSV
        {
            get { return this._tNgayRaTruongSV; }
            set { this._tNgayRaTruongSV = value; }
        }

        // 25. Xay dung cac phuong thuc set, get cho tNgayCapTheSV
        public DateTime tNgayCapTheSV
        {
            get { return this._tNgayCapTheSV; }
            set { this._tNgayCapTheSV = value; }
        }

        // 26. Xay dung cac phuong thuc set, get cho sLinkAvatarSV
        public string sLinkAvatarSV
        {
            get { return this._sLinkAvatarSV; }
            set { this._sLinkAvatarSV = value; }
        }

        // 27. Xay dung cac phuong thuc set, get cho iTrangThaiSV
        public Int16 iTrangThaiSV
        {
            get { return this._iTrangThaiSV; }
            set { this._iTrangThaiSV = value; }
        }
    }
}