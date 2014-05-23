using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CongKy.EntityObject
{
    [Serializable()]
    public class tblChiTietGiaoTrinhEO
    {
        private Int32 _PK_iGiaoTrinhID;
        private String _sTenBaiHoc;
        private String _sThongTin;
        private String _sLinkDownload;
        private Int16 _iType;
        private DateTime _tNgayCapNhat;
        private Int16 _iTrangThai;

        // 1. Xay dung cac phuong thuc set, get cho PK_iGiaoTrinhID
        public Int32 PK_iGiaoTrinhID
        {
            get { return this._PK_iGiaoTrinhID; }
            set { this._PK_iGiaoTrinhID = value; }
        }

        // 2. Xay dung cac phuong thuc set, get cho sTenBaiHoc
        public String sTenBaiHoc
        {
            get { return this._sTenBaiHoc; }
            set { this._sTenBaiHoc = value; }
        }

        // 3. Xay dung cac phuong thuc set, get cho sThongTin
        public String sThongTin
        {
            get { return this._sThongTin; }
            set { this._sThongTin = value; }
        }

        // 4. Xay dung cac phuong thuc set, get cho sLinkDownload
        public String sLinkDownload
        {
            get { return this._sLinkDownload; }
            set { this._sLinkDownload = value; }
        }

        // 5. Xay dung cac phuong thuc set, get cho iType
        public Int16 iType
        {
            get { return this._iType; }
            set { this._iType = value; }
        }

        // 6. Xay dung cac phuong thuc set, get cho tNgayCapNhat
        public DateTime tNgayCapNhat
        {
            get { return this._tNgayCapNhat; }
            set { this._tNgayCapNhat = value; }
        }

        // 7. Xay dung cac phuong thuc set, get cho iTrangThai
        public Int16 iTrangThai
        {
            get { return this._iTrangThai; }
            set { this._iTrangThai = value; }
        }
    }
}