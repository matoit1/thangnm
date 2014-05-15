using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityObject
{
    [Serializable()]
    public class tblSubjectEO
    {
        private string _PK_sSubject;
        private string _sName;
        private string _FK_sTeacher;
        private string _sLinkVideo;
        private string _sBlackList;
        private Int16 _iStatus;

        #region "Properties"
        // 1. Xay dung cac phuong thuc set, get cho PK_sSubject
        public string PK_sSubject
        {
            get { return this._PK_sSubject; }
            set { this._PK_sSubject = value; }
        }

        // 2. Xay dung cac phuong thuc set, get cho sName
        public string sName
        {
            get { return this._sName; }
            set { this._sName = value; }
        }

        // 3. Xay dung cac phuong thuc set, get cho FK_sTeacher
        public string FK_sTeacher
        {
            get { return this._FK_sTeacher; }
            set { this._FK_sTeacher = value; }
        }

        // 4. Xay dung cac phuong thuc set, get cho sLinkVideo
        public string sLinkVideo
        {
            get { return this._sLinkVideo; }
            set { this._sLinkVideo = value; }
        }

        // 4. Xay dung cac phuong thuc set, get cho sBlackList
        public string sBlackList
        {
            get { return this._sBlackList; }
            set { this._sBlackList = value; }
        }

        // 5. Xay dung cac phuong thuc set, get cho iStatus
        public Int16 iStatus
        {
            get { return this._iStatus; }
            set { this._iStatus = value; }
        }
        #endregion
    }
}