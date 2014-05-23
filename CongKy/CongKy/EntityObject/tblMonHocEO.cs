using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CongKy.EntityObject
{
    [Serializable()]
    public class tblMonHocEO
    {
        private Int32 _PK_iMonHocID;
        private String _sTenMonHoc;
        private Int16 _iTrangThai;

        // 1. Xay dung cac phuong thuc set, get cho PK_iMonHocID
        public Int32 PK_iMonHocID
        {
            get { return this._PK_iMonHocID; }
            set { this._PK_iMonHocID = value; }
        }

        // 2. Xay dung cac phuong thuc set, get cho sTenMonHoc
        public String sTenMonHoc
        {
            get { return this._sTenMonHoc; }
            set { this._sTenMonHoc = value; }
        }

        // 3. Xay dung cac phuong thuc set, get cho iTrangThai
        public Int16 iTrangThai
        {
            get { return this._iTrangThai; }
            set { this._iTrangThai = value; }
        }
    }
}