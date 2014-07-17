using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityObject
{
    [Serializable()]
    public class tblCategoryEO
    {
        private int _PK_iCategoryID;
        private int _iParent;
        private string _sName;
        private int _iStatus;

        public int PK_iCategoryID
        {
            get { return this._PK_iCategoryID; }
            set { this._PK_iCategoryID = value; }
        }

        public int iParent
        {
            get { return this._iParent; }
            set { this._iParent = value; }
        }

        public string sName
        {
            get { return this._sName; }
            set { this._sName = value; }
        }

        public int iStatus
        {
            get { return this._iStatus; }
            set { this._iStatus = value; }
        }
    }
}