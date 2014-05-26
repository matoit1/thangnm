using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityObject
{
    [Serializable()]
    public class tblPartEO
    {
        private Int64 _PK_iPart;
        private string _FK_sSubject;
        private string _sTitle;
        private string _sLinkVideo;
        private string _sBlackList;
        private DateTime _tDateTimeStart;
        private DateTime _tDateTimeEnd;
        private Int16 _iStatus;

        #region "Properties"
        // 1. Xay dung cac phuong thuc set, get cho PK_iPart
        public Int64 PK_iPart
        {
            get { return this._PK_iPart; }
            set { this._PK_iPart = value; }
        }

        // 2. Xay dung cac phuong thuc set, get cho FK_sSubject
        public string FK_sSubject
        {
            get { return this._FK_sSubject; }
            set { this._FK_sSubject = value; }
        }

        // 3. Xay dung cac phuong thuc set, get cho sTitle
        public string sTitle
        {
            get { return this._sTitle; }
            set { this._sTitle = value; }
        }

        // 4. Xay dung cac phuong thuc set, get cho sLinkVideo
        public string sLinkVideo
        {
            get { return this._sLinkVideo; }
            set { this._sLinkVideo = value; }
        }

        // 5. Xay dung cac phuong thuc set, get cho sBlackList
        public string sBlackList
        {
            get { return this._sBlackList; }
            set { this._sBlackList = value; }
        }

        // 6. Xay dung cac phuong thuc set, get cho tDateTimeStart
        public DateTime tDateTimeStart
        {
            get { return this._tDateTimeStart; }
            set { this._tDateTimeStart = value; }
        }

        // 7. Xay dung cac phuong thuc set, get cho tDateTimeEnd
        public DateTime tDateTimeEnd
        {
            get { return this._tDateTimeEnd; }
            set { this._tDateTimeEnd = value; }
        }

        // 8. Xay dung cac phuong thuc set, get cho iStatus
        public Int16 iStatus
        {
            get { return this._iStatus; }
            set { this._iStatus = value; }
        }
        #endregion
    }
}