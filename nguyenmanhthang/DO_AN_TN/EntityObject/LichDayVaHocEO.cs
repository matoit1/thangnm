using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityObject
{
    public class LichDayVaHocEO
    {
        private string _PK_sMaMonhoc;
        private string _sTenMonhoc;
        private Int16 _iSotrinh;
        private Int16 _iSotietday;
        private Int16 _iTrangThai;

        // 1. Xay dung cac phuong thuc set, get cho PK_sMaMonhoc
        public string PK_sMaMonhoc
        {
            get { return this._PK_sMaMonhoc; }
            set { this._PK_sMaMonhoc = value; }
        }

        // 2. Xay dung cac phuong thuc set, get cho sTenMonhoc
        public string sTenMonhoc
        {
            get { return this._sTenMonhoc; }
            set { this._sTenMonhoc = value; }
        }

        // 3. Xay dung cac phuong thuc set, get cho iSotrinh
        public Int16 iSotrinh
        {
            get { return this._iSotrinh; }
            set { this._iSotrinh = value; }
        }

        // 4. Xay dung cac phuong thuc set, get cho iSotietday
        public Int16 iSotietday
        {
            get { return this._iSotietday; }
            set { this._iSotietday = value; }
        }

        // 5. Xay dung cac phuong thuc set, get cho iTrangThai
        public Int16 iTrangThai
        {
            get { return this._iTrangThai; }
            set { this._iTrangThai = value; }
        }
    }
}