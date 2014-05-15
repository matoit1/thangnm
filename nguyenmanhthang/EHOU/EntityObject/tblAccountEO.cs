using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityObject
{
    [Serializable()]
    public class tblAccountEO
    {
        private string _PK_sUsername;
        private string _sPassword;
        private string _sEmail;
        private Int16 _iType;
        private Int16 _iStatus;

        #region "Properties"
        // 1. Xay dung cac phuong thuc set, get cho PK_sUsername
        public string PK_sUsername
        {
            get { return this._PK_sUsername; }
            set { this._PK_sUsername = value; }
        }

        // 2. Xay dung cac phuong thuc set, get cho sPassword
        public string sPassword
        {
            get { return this._sPassword; }
            set { this._sPassword = value; }
        }

        // 3. Xay dung cac phuong thuc set, get cho sEmail
        public string sEmail
        {
            get { return this._sEmail; }
            set { this._sEmail = value; }
        }

        // 4. Xay dung cac phuong thuc set, get cho iType
        public Int16 iType
        {
            get { return this._iType; }
            set { this._iType = value; }
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