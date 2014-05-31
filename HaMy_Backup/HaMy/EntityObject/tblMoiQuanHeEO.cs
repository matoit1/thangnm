using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HaMy.EntityObject
{
    [Serializable()]
    public class tblMoiQuanHeEO
    {
        private Int32 _PK_iMoiQuanHe;
        private String _sTen;

        // 1. Xay dung cac phuong thuc set, get cho PK_iMoiQuanHe
        public Int32 PK_iMoiQuanHe
        {
            get { return this._PK_iMoiQuanHe; }
            set { this._PK_iMoiQuanHe = value; }
        }

        // 2. Xay dung cac phuong thuc set, get cho sTen
        public String sTen
        {
            get { return this._sTen; }
            set { this._sTen = value; }
        }

    }
}