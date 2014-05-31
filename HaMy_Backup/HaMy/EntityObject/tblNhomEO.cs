using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HaMy.EntityObject
{
    [Serializable()]
    public class tblNhomEO
    {
        private Int32 _PK_iNhom;
        private String _sTenNhom;

        // 1. Xay dung cac phuong thuc set, get cho PK_iNhom
        public Int32 PK_iNhom
        {
            get { return this._PK_iNhom; }
            set { this._PK_iNhom = value; }
        }

        // 2. Xay dung cac phuong thuc set, get cho sTenNhom
        public String sTenNhom
        {
            get { return this._sTenNhom; }
            set { this._sTenNhom = value; }
        }

    }
}