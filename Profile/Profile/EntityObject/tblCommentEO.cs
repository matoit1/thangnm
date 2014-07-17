using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityObject
{
    [Serializable()]
    public class tblCommentEO
    {
        private Int64 _PK_lComment_ID;
        private Int64 _FK_lTopicID;
        private string _sName;
        private string _sEmail;
        private string _sWebsite;
        private string _sContent;
        private Boolean _bStatus;
        private DateTime _tLastUpdate;

        public Int64 PK_lComment_ID
        {
            get { return this._PK_lComment_ID; }
            set { this._PK_lComment_ID = value; }
        }

        public Int64 FK_lTopicID
        {
            get { return this._FK_lTopicID; }
            set { this._FK_lTopicID = value; }
        }

        public string sName
        {
            get { return this._sName; }
            set { this._sName = value; }
        }

        public string sEmail
        {
            get { return this._sEmail; }
            set { this._sEmail = value; }
        }

        public string sWebsite
        {
            get { return this._sWebsite; }
            set { this._sWebsite = value; }
        }

        public string sContent
        {
            get { return this._sContent; }
            set { this._sContent = value; }
        }

        public Boolean bStatus
        {
            get { return this._bStatus; }
            set { this._bStatus = value; }
        }

        public DateTime tLastUpdate
        {
            get { return this._tLastUpdate; }
            set { this._tLastUpdate = value; }
        }
    }
}