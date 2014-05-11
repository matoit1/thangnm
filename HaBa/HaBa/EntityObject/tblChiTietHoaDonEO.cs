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
        private Int64 _FK_lSanPhamID;
        private Int64 _lGiaBan;
        private Int16 _iSoLuong;

        // 1. Xay dung cac phuong thuc set, get cho FK_lHoaDonID
        public Int64 FK_lHoaDonID
        {
            get { return this._FK_lHoaDonID; }
            set { this._FK_lHoaDonID = value; }
        }

        // 2. Xay dung cac phuong thuc set, get cho FK_lSanPhamID
        public Int64 FK_lSanPhamID
        {
            get { return this._FK_lSanPhamID; }
            set { this._FK_lSanPhamID = value; }
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