using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HaBa.EntityObject
{
    [Serializable()]
    public class tblNhomSanPhamEO
    {
        private Int16 _PK_iNhomSanPhamID;
        private Int16 _iNhomCon;
        private string _sTenNhom;
        private Int16 _iTrangThai;

        // 1. Xay dung cac phuong thuc set, get cho PK_iNhomSanPhamID
        public Int16 PK_iNhomSanPhamID
        {
            get { return this._PK_iNhomSanPhamID; }
            set { this._PK_iNhomSanPhamID = value; }
        }

        // 2. Xay dung cac phuong thuc set, get cho iNhomCon
        public Int16 iNhomCon
        {
            get { return this._iNhomCon; }
            set { this._iNhomCon = value; }
        }

        // 3. Xay dung cac phuong thuc set, get cho sTenNhom
        public string sTenNhom
        {
            get { return this._sTenNhom; }
            set { this._sTenNhom = value; }
        }

        // 4. Xay dung cac phuong thuc set, get cho iTrangThai
        public Int16 iTrangThai
        {
            get { return this._iTrangThai; }
            set { this._iTrangThai = value; }
        }
    }
}