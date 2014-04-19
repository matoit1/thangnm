using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityObject
{
    [Serializable()]
    public class LichDayVaHocEO
    {
        private string _FK_sMaPCCT;
        private string _FK_sMalop;
        private Int16 _iCaHoc;
        private DateTime _tNgayDay;
        private Int16 _iSoTietDay;
        private string _sSinhVienNghi;
        private string _sLinkVideo;
        private Int16 _iTrangThai;

        // 1. Xay dung cac phuong thuc set, get cho FK_sMaPCCT
        public string FK_sMaPCCT
        {
            get { return this._FK_sMaPCCT; }
            set { this._FK_sMaPCCT = value; }
        }

        // 2. Xay dung cac phuong thuc set, get cho FK_sMalop
        public string FK_sMalop
        {
            get { return this._FK_sMalop; }
            set { this._FK_sMalop = value; }
        }

        // 3. Xay dung cac phuong thuc set, get cho iCaHoc
        public Int16 iCaHoc
        {
            get { return this._iCaHoc; }
            set { this._iCaHoc = value; }
        }

        // 4. Xay dung cac phuong thuc set, get cho tNgayDay
        public DateTime tNgayDay
        {
            get { return this._tNgayDay; }
            set { this._tNgayDay = value; }
        }

        // 5. Xay dung cac phuong thuc set, get cho iSoTietDay
        public Int16 iSoTietDay
        {
            get { return this._iSoTietDay; }
            set { this._iSoTietDay = value; }
        }

        // 6. Xay dung cac phuong thuc set, get cho sSinhVienNghi
        public string sSinhVienNghi
        {
            get { return this._sSinhVienNghi; }
            set { this._sSinhVienNghi = value; }
        }

        // 7. Xay dung cac phuong thuc set, get cho sLinkVideo
        public string sLinkVideo
        {
            get { return this._sLinkVideo; }
            set { this._sLinkVideo = value; }
        }

        // 8. Xay dung cac phuong thuc set, get cho iTrangThai
        public Int16 iTrangThai
        {
            get { return this._iTrangThai; }
            set { this._iTrangThai = value; }
        }
    }
}