using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityObject
{
    [Serializable()]
    public class tblErrorEO
    {
        private Int64 _PK_lErrorID;
        private string _sLink;
        private string _sIP;
        private string _sBrowser;
        private int _iCode;
        private int _iStatus;
        private DateTime _tTime;
        private DateTime _tTimeCheck;

        public Int64 PK_lErrorID
        {
            get { return this._PK_lErrorID; }
            set { this._PK_lErrorID = value; }
        }

        public string sLink
        {
            get { return this._sLink; }
            set { this._sLink = value; }
        }

        public string sIP
        {
            get { return this._sIP; }
            set { this._sIP = value; }
        }

        public string sBrowser
        {
            get { return this._sBrowser; }
            set { this._sBrowser = value; }
        }

        public int iCode
        {
            get { return this._iCode; }
            set { this._iCode = value; }
        }

        public int iStatus
        {
            get { return this._iStatus; }
            set { this._iStatus = value; }
        }

        public DateTime tTime
        {
            get { return this._tTime; }
            set { this._tTime = value; }
        }

        public DateTime tTimeCheck
        {
            get { return this._tTimeCheck; }
            set { this._tTimeCheck = value; }
        }
    }
}