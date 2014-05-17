using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HaBa.EntityObject
{
    [Serializable()]
    public class tblChiTietHoaDonEO
    {
        private Int64 _FK_lHoaDonID;
        private string _FK_sSanPhamID;
        private Int64 _lGiaBan;
        private Int16 _iSoLuong;

        // 1. Xay dung cac phuong thuc set, get cho FK_lHoaDonID
        public Int64 FK_lHoaDonID
        {
            get { return this._FK_lHoaDonID; }
            set { this._FK_lHoaDonID = value; }
        }

        // 2. Xay dung cac phuong thuc set, get cho FK_sSanPhamID
        public string FK_sSanPhamID
        {
            get { return this._FK_sSanPhamID; }
            set { this._FK_sSanPhamID = value; }
        }

        // 3. Xay dung cac phuong thuc set, get cho lGiaBan
        public Int64 lGiaBan
        {
            get { return this._lGiaBan; }
            set { this._lGiaBan = value; }
        }

        // 4. Xay dung cac phuong thuc set, get cho iSoLuong
        public Int16 iSoLuong
        {
            get { return this._iSoLuong; }
            set { this._iSoLuong = value; }
        }
    }
}