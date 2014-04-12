using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityObject
{
    [Serializable()]
    public class PhanCongCongTacEO
    {
        private string _PK_sMaPCCT;
        private string _FK_sMaGV;
        private string _FK_sMaMonhoc;
        private DateTime _tNgayBatDau;
        private DateTime _tNgayKetThuc;
        private Int16 _iTrangThai;

        // 1. Xay dung cac phuong thuc set, get cho PK_sMaPCCT
        public string PK_sMaPCCT
        {
            get { return this._PK_sMaPCCT; }
            set { this._PK_sMaPCCT = value; }
        }

        // 2. Xay dung cac phuong thuc set, get cho FK_sMaGV
        public string FK_sMaGV
        {
            get { return this._FK_sMaGV; }
            set { this._FK_sMaGV = value; }
        }

        // 3. Xay dung cac phuong thuc set, get cho FK_sMaMonhoc
        public string FK_sMaMonhoc
        {
            get { return this._FK_sMaMonhoc; }
            set { this._FK_sMaMonhoc = value; }
        }

        // 4. Xay dung cac phuong thuc set, get cho tNgayBatDau
        public DateTime tNgayBatDau
        {
            get { return this._tNgayBatDau; }
            set { this._tNgayBatDau = value; }
        }

        // 5. Xay dung cac phuong thuc set, get cho tNgayKetThuc
        public DateTime tNgayKetThuc
        {
            get { return this._tNgayKetThuc; }
            set { this._tNgayKetThuc = value; }
        }

        // 6. Xay dung cac phuong thuc set, get cho iTrangThai
        public Int16 iTrangThai
        {
            get { return this._iTrangThai; }
            set { this._iTrangThai = value; }
        }
    }
}