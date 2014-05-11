using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HaBa.EntityObject
{
    [Serializable()]
    public class tblThanhToanEO
    {
        private Int16 _PK_iThanhToanID;
        private string _sTenThanhToan;
        private Int16 _iTrangThai;

        // 1. Xay dung cac phuong thuc set, get cho PK_iThanhToanID
        public Int16 PK_iThanhToanID
        {
            get { return this._PK_iThanhToanID; }
            set { this._PK_iThanhToanID = value; }
        }

        // 2. Xay dung cac phuong thuc set, get cho sTenThanhToan
        public string sTenThanhToan
        {
            get { return this._sTenThanhToan; }
            set { this._sTenThanhToan = value; }
        }

        // 3. Xay dung cac phuong thuc set, get cho iTrangThai
        public Int16 iTrangThai
        {
            get { return this._iTrangThai; }
            set { this._iTrangThai = value; }
        }
    }
}