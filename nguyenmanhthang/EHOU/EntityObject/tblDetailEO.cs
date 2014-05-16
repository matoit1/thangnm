using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityObject
{
    [Serializable()]
    public class tblDetailEO
    {
        private Int64 _PK_lCaHoc;
        private string _FK_sSubject;
        private string _FK_sStudent;
        private string _sTitle;
        private DateTime _tDateStart;
        private DateTime _tDateEnd;

        #region "Properties"
        // 1. Xay dung cac phuong thuc set, get cho _PK_lCaHoc
        public Int64 PK_lCaHoc
        {
            get { return this._PK_lCaHoc; }
            set { this._PK_lCaHoc = value; }
        }
        // 1. Xay dung cac phuong thuc set, get cho FK_sSubject
        public string FK_sSubject
        {
            get { return this._FK_sSubject; }
            set { this._FK_sSubject = value; }
        }

        // 2. Xay dung cac phuong thuc set, get cho FK_sStudent
        public string FK_sStudent
        {
            get { return this._FK_sStudent; }
            set { this._FK_sStudent = value; }
        }

        // 2. Xay dung cac phuong thuc set, get cho sTitle
        public string sTitle
        {
            get { return this._sTitle; }
            set { this._sTitle = value; }
        }
        // 3. Xay dung cac phuong thuc set, get cho tDateStart
        public DateTime tDateStart
        {
            get { return this._tDateStart; }
            set { this._tDateStart = value; }
        }

        // 4. Xay dung cac phuong thuc set, get cho tDateEnd
        public DateTime tDateEnd
        {
            get { return this._tDateEnd; }
            set { this._tDateEnd = value; }
        }
        #endregion
    }
}