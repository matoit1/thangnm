using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityObject
{
    [Serializable()]
    public class TinNhanEO
    {
        private Int64 _PK_lTinNhan;
        private string _FK_sPhongChat;
        private string _FK_sNguoiGui;
        private string _sNoidung;
        private Int16 _iTrangThai;

        #region "Properties"
        // 1. Xay dung cac phuong thuc set, get cho PK_lTinNhan
        public Int64 PK_lTinNhan
        {
            get { return this._PK_lTinNhan; }
            set { this._PK_lTinNhan = value; }
        }

        // 2. Xay dung cac phuong thuc set, get cho FK_sPhongChat
        public string FK_sPhongChat
        {
            get { return this._FK_sPhongChat; }
            set { this._FK_sPhongChat = value; }
        }

        // 3. Xay dung cac phuong thuc set, get cho FK_sNguoiGui
        public string FK_sNguoiGui
        {
            get { return this._FK_sNguoiGui; }
            set { this._FK_sNguoiGui = value; }
        }

        // 4. Xay dung cac phuong thuc set, get cho sNoidung
        public string sNoidung
        {
            get { return this._sNoidung; }
            set { this._sNoidung = value; }
        }

        // 5. Xay dung cac phuong thuc set, get cho iTrangThai
        public Int16 iTrangThai
        {
            get { return this._iTrangThai; }
            set { this._iTrangThai = value; }
        }
        #endregion
    }
}