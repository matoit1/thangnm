using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityObject
{
    [Serializable()]
    public class tblMessageEO
    {
        private Int64 _PK_lMessage;
        private string _FK_sRoom;
        private string _FK_sUsername;
        private string _sContent;
        private DateTime _tDateSent;
        private Int16 _iStatus;

        #region "Properties"
        // 1. Xay dung cac phuong thuc set, get cho PK_lMessage
        public Int64 PK_lMessage
        {
            get { return this._PK_lMessage; }
            set { this._PK_lMessage = value; }
        }

        // 2. Xay dung cac phuong thuc set, get cho FK_sRoom
        public string FK_sRoom
        {
            get { return this._FK_sRoom; }
            set { this._FK_sRoom = value; }
        }

        // 3. Xay dung cac phuong thuc set, get cho FK_sUsername
        public string FK_sUsername
        {
            get { return this._FK_sUsername; }
            set { this._FK_sUsername = value; }
        }

        // 4. Xay dung cac phuong thuc set, get cho sContent
        public string sContent
        {
            get { return this._sContent; }
            set { this._sContent = value; }
        }

        // 5. Xay dung cac phuong thuc set, get cho tDateSent
        public DateTime tDateSent
        {
            get { return this._tDateSent; }
            set { this._tDateSent = value; }
        }

        // 6. Xay dung cac phuong thuc set, get cho iStatus
        public Int16 iStatus
        {
            get { return this._iStatus; }
            set { this._iStatus = value; }
        }
        #endregion
    }
}