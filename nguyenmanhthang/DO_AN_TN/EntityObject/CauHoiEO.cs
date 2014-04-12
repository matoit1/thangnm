using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityObject
{
    [Serializable()]
    public class CauHoiEO
    {
        private string _FK_sMaGV;
        private Int64 _PK_lCauhoi_ID;
        private string _sCauhoi_Cauhoi;
        private string _sCauhoi_A;
        private string _sCauhoi_B;
        private string _sCauhoi_C;
        private string _sCauhoi_D;
        private Int16 _iCauhoi_Dung;
        private string _sBoCauHoi;
        private DateTime _tNgayTao;
        private DateTime _tNgayCapNhat;
        private Int16 _iTrangThai;

        #region "Properties"
        // 1. Xay dung cac phuong thuc set, get cho FK_sMaGV
        public string FK_sMaGV
        {
            get { return this._FK_sMaGV; }
            set { this._FK_sMaGV = value; }
        }

        // 2. Xay dung cac phuong thuc set, get cho PK_lCauhoi_ID
        public Int64 PK_lCauhoi_ID
        {
            get { return this._PK_lCauhoi_ID; }
            set { this._PK_lCauhoi_ID = value; }
        }

        // 3. Xay dung cac phuong thuc set, get cho sCauhoi_Cauhoi
        public string sCauhoi_Cauhoi
        {
            get { return this._sCauhoi_Cauhoi; }
            set { this._sCauhoi_Cauhoi = value; }
        }

        // 4. Xay dung cac phuong thuc set, get cho sCauhoi_A
        public string sCauhoi_A
        {
            get { return this._sCauhoi_A; }
            set { this._sCauhoi_A = value; }
        }

        // 5. Xay dung cac phuong thuc set, get cho sCauhoi_B
        public string sCauhoi_B
        {
            get { return this._sCauhoi_B; }
            set { this._sCauhoi_B = value; }
        }

        // 6. Xay dung cac phuong thuc set, get cho sCauhoi_C
        public string sCauhoi_C
        {
            get { return this._sCauhoi_C; }
            set { this._sCauhoi_C = value; }
        }

        // 7. Xay dung cac phuong thuc set, get cho sCauhoi_D
        public string sCauhoi_D
        {
            get { return this._sCauhoi_D; }
            set { this._sCauhoi_D = value; }
        }

        // 8. Xay dung cac phuong thuc set, get cho iCauhoi_Dung
        public Int16 iCauhoi_Dung
        {
            get { return this._iCauhoi_Dung; }
            set { this._iCauhoi_Dung = value; }
        }

        // 9. Xay dung cac phuong thuc set, get cho sBoCauHoi
        public string sBoCauHoi
        {
            get { return this._sBoCauHoi; }
            set { this._sBoCauHoi = value; }
        }

        // 10. Xay dung cac phuong thuc set, get cho _tNgayTao
        public DateTime tNgayTao
        {
            get { return this._tNgayTao; }
            set { this._tNgayTao = value; }
        }

        // 11. Xay dung cac phuong thuc set, get cho _tNgayCapNhat
        public DateTime tNgayCapNhat
        {
            get { return this._tNgayCapNhat; }
            set { this._tNgayCapNhat = value; }
        }

        // 12. Xay dung cac phuong thuc set, get cho iTrangThai
        public Int16 iTrangThai
        {
            get { return this._iTrangThai; }
            set { this._iTrangThai = value; }
        }
        #endregion
    }
}