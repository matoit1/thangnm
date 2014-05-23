using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CongKy.EntityObject
{
    [Serializable()]
    public class tblGiaoTrinhEO
    {
        private Int32 _FK_iMonHocID;
        private Int32 _FK_iGiaoTrinhID;

        // 1. Xay dung cac phuong thuc set, get cho FK_iMonHocID
        public Int32 FK_iMonHocID
        {
            get { return this._FK_iMonHocID; }
            set { this._FK_iMonHocID = value; }
        }

        // 2. Xay dung cac phuong thuc set, get cho FK_iGiaoTrinhID
        public Int32 FK_iGiaoTrinhID
        {
            get { return this._FK_iGiaoTrinhID; }
            set { this._FK_iGiaoTrinhID = value; }
        }
    }
}