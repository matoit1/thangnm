using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityObject
{
    [Serializable()]
    public class tblTagEO
    {
        private int _PK_sTagID;
        private Int64 _FK_lTopicID;
        private string _sName;

        public int PK_sTagID
        {
            get { return this._PK_sTagID; }
            set { this._PK_sTagID = value; }
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
    }
}