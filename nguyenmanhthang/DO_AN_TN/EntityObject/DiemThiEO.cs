using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityObject
{
    [Serializable()]
    public class DiemThiEO
    {
        private string _FK_sMaSV;
        private string _FK_sMaMonhoc;
        private Int16 _PK_iSolanhoc;
        private float _fDiemchuyencan;
        private float _fDiemgiuaky;
        private float _fDiemthilan1;
        private float _fDiemthilan2;
        private Int16 _iTrangThai;

        // 1. Xay dung cac phuong thuc set, get cho FK_sMaSV
        public string FK_sMaSV
        {
            get { return this._FK_sMaSV; }
            set { this._FK_sMaSV = value; }
        }

        // 2. Xay dung cac phuong thuc set, get cho FK_sMaMonhoc
        public string FK_sMaMonhoc
        {
            get { return this._FK_sMaMonhoc; }
            set { this._FK_sMaMonhoc = value; }
        }

        // 3. Xay dung cac phuong thuc set, get cho PK_iSolanhoc
        public Int16 PK_iSolanhoc
        {
            get { return this._PK_iSolanhoc; }
            set { this._PK_iSolanhoc = value; }
        }

        // 4. Xay dung cac phuong thuc set, get cho fDiemchuyencan
        public float fDiemchuyencan
        {
            get { return this._fDiemchuyencan; }
            set { this._fDiemchuyencan = value; }
        }

        // 5. Xay dung cac phuong thuc set, get cho fDiemgiuaky
        public float fDiemgiuaky
        {
            get { return this._fDiemgiuaky; }
            set { this._fDiemgiuaky = value; }
        }

        // 6. Xay dung cac phuong thuc set, get cho fDiemthilan1
        public float fDiemthilan1
        {
            get { return this._fDiemthilan1; }
            set { this._fDiemthilan1 = value; }
        }

        // 7. Xay dung cac phuong thuc set, get cho fDiemthilan2
        public float fDiemthilan2
        {
            get { return this._fDiemthilan2; }
            set { this._fDiemthilan2 = value; }
        }

        // 8. Xay dung cac phuong thuc set, get cho iTrangThai
        public Int16 iTrangThai
        {
            get { return this._iTrangThai; }
            set { this._iTrangThai = value; }
        }
    }
}