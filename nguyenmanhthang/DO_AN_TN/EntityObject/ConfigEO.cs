using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityObject
{
    public class ConfigEO
    {
        private string _PK_sMaMonhoc;

        // 1. Xay dung cac phuong thuc set, get cho PK_sMaMonhoc
        public string PK_sMaMonhoc
        {
            get { return this._PK_sMaMonhoc; }
            set { this._PK_sMaMonhoc = value; }
        }
    }
}