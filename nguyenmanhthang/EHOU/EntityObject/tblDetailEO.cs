using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityObject
{
    [Serializable()]
    public class tblDetailEO
    {
        private string _FK_sSubject;
        private string _FK_sStudent;

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
        #endregion
    }
}