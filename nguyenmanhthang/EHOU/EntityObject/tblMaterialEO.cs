using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityObject
{
    [Serializable()]
    public class tblMaterialEO
    {
        private Int64 _PK_lMaterial;
        private string _FK_sSubject;
        private string _FK_sUsername;
        private string _sDescription;
        private string _sLinkDownload;
        private DateTime _tLastUpdate;
        private Int64 _iSize;
        private Int16 _iType;
        private Int16 _iStatus;

        #region "Properties"
        // 1. Xay dung cac phuong thuc set, get cho PK_lMaterial
        public Int64 PK_lMaterial
        {
            get { return this._PK_lMaterial; }
            set { this._PK_lMaterial = value; }
        }

        // 2. Xay dung cac phuong thuc set, get cho FK_sSubject
        public string FK_sSubject
        {
            get { return this._FK_sSubject; }
            set { this._FK_sSubject = value; }
        }

        // 3. Xay dung cac phuong thuc set, get cho FK_sUsername
        public string FK_sUsername
        {
            get { return this._FK_sUsername; }
            set { this._FK_sUsername = value; }
        }

        // 4. Xay dung cac phuong thuc set, get cho sDescription
        public string sDescription
        {
            get { return this._sDescription; }
            set { this._sDescription = value; }
        }

        // 5. Xay dung cac phuong thuc set, get cho sLinkDownload
        public string sLinkDownload
        {
            get { return this._sLinkDownload; }
            set { this._sLinkDownload = value; }
        }

        // 6. Xay dung cac phuong thuc set, get cho tLastUpdate
        public DateTime tLastUpdate
        {
            get { return this._tLastUpdate; }
            set { this._tLastUpdate = value; }
        }

        // 7. Xay dung cac phuong thuc set, get cho iSize
        public Int64 iSize
        {
            get { return this._iSize; }
            set { this._iSize = value; }
        }

        // 8. Xay dung cac phuong thuc set, get cho iType
        public Int16 iType
        {
            get { return this._iType; }
            set { this._iType = value; }
        }

        // 9. Xay dung cac phuong thuc set, get cho iStatus
        public Int16 iStatus
        {
            get { return this._iStatus; }
            set { this._iStatus = value; }
        }
        #endregion
    }
}