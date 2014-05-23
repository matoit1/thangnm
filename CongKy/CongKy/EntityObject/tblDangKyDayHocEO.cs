using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CongKy.EntityObject
{
    [Serializable()]
    public class tblDangKyDayHocEO
    {
        private Int32 _FK_iTaiKhoanID;
        private Int32 _FK_iMonHocID;
        private DateTime _tNgayDangKy;
        private Int16 _iTrangThai;

        // 1. Xay dung cac phuong thuc set, get cho FK_iTaiKhoanID
        public Int32 FK_iTaiKhoanID
        {
            get { return this._FK_iTaiKhoanID; }
            set { this._FK_iTaiKhoanID = value; }
        }

        // 2. Xay dung cac phuong thuc set, get cho FK_iMonHocID
        public Int32 FK_iMonHocID
        {
            get { return this._FK_iMonHocID; }
            set { this._FK_iMonHocID = value; }
        }

        // 3. Xay dung cac phuong thuc set, get cho tNgayDangKy
        public DateTime tNgayDangKy
        {
            get { return this._tNgayDangKy; }
            set { this._tNgayDangKy = value; }
        }

        // 4. Xay dung cac phuong thuc set, get cho iTrangThai
        public Int16 iTrangThai
        {
            get { return this._iTrangThai; }
            set { this._iTrangThai = value; }
        }

    }
}