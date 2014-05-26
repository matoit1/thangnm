using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityObject
{
    [Serializable()]
    public class tblSubject_StudentEO
    {
        private string _FK_sSubject;
        private string _FK_sStudent;
        private Int16 _iStatus;

        #region "Properties"
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

        // 2. Xay dung cac phuong thuc set, get cho iStatus
        public Int16 iStatus
        {
            get { return this._iStatus; }
            set { this._iStatus = value; }
        }
        #endregion
    }
}