using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HaMy.EntityObject
{
    [Serializable()]
    public class tblCuocHenEO
    {
        private Int64 _PK_lCuocHen;
        private Int32 _FK_iNguoiDung;
        private Int32 _FK_iDoiTac;
        private String _sNoiDung;
        private String _sDiaDiem;
        private DateTime _tNgayGioBatDau;
        private DateTime _tNgayGioKetThuc;
        private Int16 _iTrangThai;

        // 1. Xay dung cac phuong thuc set, get cho PK_lCuocHen
        public Int64 PK_lCuocHen
        {
            get { return this._PK_lCuocHen; }
            set { this._PK_lCuocHen = value; }
        }

        // 2. Xay dung cac phuong thuc set, get cho FK_iNguoiDung
        public Int32 FK_iNguoiDung
        {
            get { return this._FK_iNguoiDung; }
            set { this._FK_iNguoiDung = value; }
        }

        // 3. Xay dung cac phuong thuc set, get cho FK_iDoiTac
        public Int32 FK_iDoiTac
        {
            get { return this._FK_iDoiTac; }
            set { this._FK_iDoiTac = value; }
        }

        // 4. Xay dung cac phuong thuc set, get cho sNoiDung
        public String sNoiDung
        {
            get { return this._sNoiDung; }
            set { this._sNoiDung = value; }
        }

        // 5. Xay dung cac phuong thuc set, get cho sDiaDiem
        public String sDiaDiem
        {
            get { return this._sDiaDiem; }
            set { this._sDiaDiem = value; }
        }

        // 6. Xay dung cac phuong thuc set, get cho tNgayGioBatDau
        public DateTime tNgayGioBatDau
        {
            get { return this._tNgayGioBatDau; }
            set { this._tNgayGioBatDau = value; }
        }

        // 7. Xay dung cac phuong thuc set, get cho tNgayGioKetThuc
        public DateTime tNgayGioKetThuc
        {
            get { return this._tNgayGioKetThuc; }
            set { this._tNgayGioKetThuc = value; }
        }

        // 8. Xay dung cac phuong thuc set, get cho iTrangThai
        public Int16 iTrangThai
        {
            get { return this._iTrangThai; }
            set { this._iTrangThai = value; }
        }
    }
}