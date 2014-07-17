using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityObject
{
    [Serializable()]
    public class tblTopicEO
    {
        private Int64 _PK_lTopicID;
        private Int16 _FK_iCategoryID;
        private int _FK_iAccountsID;
        private string _sTitle;
        private string _sLinkImage;
        private string _sContent;
        private string _sDescription;
        private int _iVisit;
        private int _iLike;
        private int _iStatus;
        private DateTime _tLastUpdate;

        public Int64 PK_lTopicID
        {
            get { return this._PK_lTopicID; }
            set { this._PK_lTopicID = value; }
        }

        public Int16 FK_iCategoryID
        {
            get { return this._FK_iCategoryID; }
            set { this._FK_iCategoryID = value; }
        }

        public int FK_iAccountsID
        {
            get { return this._FK_iAccountsID; }
            set { this._FK_iAccountsID = value; }
        }

        public string sTitle
        {
            get { return this._sTitle; }
            set { this._sTitle = value; }
        }

        public string sLinkImage
        {
            get { return this._sLinkImage; }
            set { this._sLinkImage = value; }
        }

        public string sContent
        {
            get { return this._sContent; }
            set { this._sContent = value; }
        }

        public string sDescription
        {
            get { return this._sDescription; }
            set { this._sDescription = value; }
        }

        public int iVisit
        {
            get { return this._iVisit; }
            set { this._iVisit = value; }
        }

        public int iLike
        {
            get { return this._iLike; }
            set { this._iLike = value; }
        }

        public int iStatus
        {
            get { return this._iStatus; }
            set { this._iStatus = value; }
        }

        public DateTime tLastUpdate
        {
            get { return this._tLastUpdate; }
            set { this._tLastUpdate = value; }
        }
    }
}