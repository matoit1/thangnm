using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityObject
{
    [Serializable()]
    public class LopHocEO
    {
        private string _PK_sMalop;
        private string _sTenlop;
        private Int16 _iNamvaotruong;
        private Int16 _iSiso;
        private Int16 _iSoNamDaoTao;
        private Int16 _iTrangThai;

        // 1. Xay dung cac phuong thuc set, get cho PK_sMalop
        public string PK_sMalop
        {
            get { return this._PK_sMalop; }
            set { this._PK_sMalop = value; }
        }

        // 2. Xay dung cac phuong thuc set, get cho sTenlop
        public string sTenlop
        {
            get { return this._sTenlop; }
            set { this._sTenlop = value; }
        }

        // 3. Xay dung cac phuong thuc set, get cho iNamvaotruong
        public Int16 iNamvaotruong
        {
            get { return this._iNamvaotruong; }
            set { this._iNamvaotruong = value; }
        }

        // 4. Xay dung cac phuong thuc set, get cho iSiso
        public Int16 iSiso
        {
            get { return this._iSiso; }
            set { this._iSiso = value; }
        }

        // 5. Xay dung cac phuong thuc set, get cho iSoNamDaoTao
        public Int16 iSoNamDaoTao
        {
            get { return this._iSoNamDaoTao; }
            set { this._iSoNamDaoTao = value; }
        }

        // 6. Xay dung cac phuong thuc set, get cho iTrangThai
        public Int16 iTrangThai
        {
            get { return this._iTrangThai; }
            set { this._iTrangThai = value; }
        }
    }
}