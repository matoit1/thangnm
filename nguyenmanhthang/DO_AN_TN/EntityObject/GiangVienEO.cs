using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityObject
{
    public class GiangVienEO
    {
        private string _PK_sMaGV;
        private string _sHotenGV;
        private string _sTendangnhapGV;
        private string _sMatkhauGV;
        private string _sEmailGV;
        private string _sDiachiGV;
        private string _sSdtGV;
        private DateTime _tNgaysinhGV;
        private bool _bGioitinhGV;
        private string _sCMNDGV;
        private DateTime _tNgayCapCMNDGV;
        private string _sNoiCapCMNDGV;
        private bool _bHonNhanGV;
        private DateTime _tNgayNhanCongTacGV;
        private Int16 _iChucVuGV;
        private Int16 _iHocViGV;
        private bool _bCongChucGV;
        private string _sLinkChannelsGV;
        private string _sLinkChatRoomsGV;
        private string _sLinkAvatarGV;
        private Int16 _iTrangThaiGV;

        #region "Method"
        // 1. Xay dung cac phuong thuc set, get cho PK_sMaGV
        public string PK_sMaGV
        {
            get { return this._PK_sMaGV; }
            set { this._PK_sMaGV = value; }
        }

        // 2. Xay dung cac phuong thuc set, get cho sHotenGV
        public string sHotenGV
        {
            get { return this._sHotenGV; }
            set { this._sHotenGV = value; }
        }

        // 3. Xay dung cac phuong thuc set, get cho sTendangnhapGV
        public string sTendangnhapGV
        {
            get { return this._sTendangnhapGV; }
            set { this._sTendangnhapGV = value; }
        }

        // 4. Xay dung cac phuong thuc set, get cho sMatkhauGV
        public string sMatkhauGV
        {
            get { return this._sMatkhauGV; }
            set { this._sMatkhauGV = value; }
        }


        // 5. Xay dung cac phuong thuc set, get cho sEmailGV
        public string sEmailGV
        {
            get { return this._sEmailGV; }
            set { this._sEmailGV = value; }
        }

        // 6. Xay dung cac phuong thuc set, get cho sDiachiGV
        public string sDiachiGV
        {
            get { return this._sDiachiGV; }
            set { this._sDiachiGV = value; }
        }

        // 7. Xay dung cac phuong thuc set, get cho sSdtGV
        public string sSdtGV
        {
            get { return this._sSdtGV; }
            set { this._sSdtGV = value; }
        }

        // 8. Xay dung cac phuong thuc set, get cho tNgaysinhGV
        public DateTime tNgaysinhGV
        {
            get { return this._tNgaysinhGV; }
            set { this._tNgaysinhGV = value; }
        }

        // 9. Xay dung cac phuong thuc set, get cho bGioitinhGV
        public bool bGioitinhGV
        {
            get { return this._bGioitinhGV; }
            set { this._bGioitinhGV = value; }
        }

        // 10. Xay dung cac phuong thuc set, get cho sCMNDGV
        public string sCMNDGV
        {
            get { return this._sCMNDGV; }
            set { this._sCMNDGV = value; }
        }

        // 11. Xay dung cac phuong thuc set, get cho tNgayCapCMNDGV
        public DateTime tNgayCapCMNDGV
        {
            get { return this._tNgayCapCMNDGV; }
            set { this._tNgayCapCMNDGV = value; }
        }

        // 12. Xay dung cac phuong thuc set, get cho sNoiCapCMNDGV
        public string sNoiCapCMNDGV
        {
            get { return this._sNoiCapCMNDGV; }
            set { this._sNoiCapCMNDGV = value; }
        }

        // 13. Xay dung cac phuong thuc set, get cho bHonNhanGV
        public bool bHonNhanGV
        {
            get { return this._bHonNhanGV; }
            set { this._bHonNhanGV = value; }
        }

        // 14. Xay dung cac phuong thuc set, get cho tNgayNhanCongTacGV
        public DateTime tNgayNhanCongTacGV
        {
            get { return this._tNgayNhanCongTacGV; }
            set { this._tNgayNhanCongTacGV = value; }
        }

        // 16. Xay dung cac phuong thuc set, get cho iChucVuGV
        public Int16 iChucVuGV
        {
            get { return this._iChucVuGV; }
            set { this._iChucVuGV = value; }
        }

        // 17. Xay dung cac phuong thuc set, get cho iHocViGV
        public Int16 iHocViGV
        {
            get { return this._iHocViGV; }
            set { this._iHocViGV = value; }
        }

        // 18. Xay dung cac phuong thuc set, get cho bCongChucGV
        public bool bCongChucGV
        {
            get { return this._bCongChucGV; }
            set { this._bCongChucGV = value; }
        }

        // 19. Xay dung cac phuong thuc set, get cho sLinkChannelsGV
        public string sLinkChannelsGV
        {
            get { return this._sLinkChannelsGV; }
            set { this._sLinkChannelsGV = value; }
        }

        // 20. Xay dung cac phuong thuc set, get cho sLinkChatRoomsGV
        public string sLinkChatRoomsGV
        {
            get { return this._sLinkChatRoomsGV; }
            set { this._sLinkChatRoomsGV = value; }
        }

        // 21. Xay dung cac phuong thuc set, get cho sLinkAvatarGV
        public string sLinkAvatarGV
        {
            get { return this._sLinkAvatarGV; }
            set { this._sLinkAvatarGV = value; }
        }

        // 22. Xay dung cac phuong thuc set, get cho iTrangThaiGV
        public Int16 iTrangThaiGV
        {
            get { return this._iTrangThaiGV; }
            set { this._iTrangThaiGV = value; }
        }
        #endregion
    }
}