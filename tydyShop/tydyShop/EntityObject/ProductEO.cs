using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityObject
{
    [Serializable()]
    public class ProductEO
    {
        private Int64 _PK_lProductID;
        private Int64 _lGroup;
        private Int64 _lParent;
        private string _sName;
        private Int64 _lPrice;
        private Int64 _lSale;
        private bool _bVAT;
        private string _sDescription;
        private string _sInfomation;
        private string _sOrigin;
        private int _iQuantity;
        private string _sLinkImage;
        private string _sLinkImageThumbnail;
        private DateTime _tLastUpdate;
        private bool _bStatus;

        // 1. Xay dung cac phuong thuc set, get cho PK_lProductID
        public Int64 PK_lProductID
        {
            get { return this._PK_lProductID; }
            set { this._PK_lProductID = value; }
        }

        // 2. Xay dung cac phuong thuc set, get cho lGroup
        public Int64 lGroup
        {
            get { return this._lGroup; }
            set { this._lGroup = value; }
        }

        // 3. Xay dung cac phuong thuc set, get cho lParent
        public Int64 lParent
        {
            get { return this._lParent; }
            set { this._lParent = value; }
        }

        // 4. Xay dung cac phuong thuc set, get cho sName
        public string sName
        {
            get { return this._sName; }
            set { this._sName = value; }
        }

        // 5. Xay dung cac phuong thuc set, get cho lPrice
        public Int64 lPrice
        {
            get { return this._lPrice; }
            set { this._lPrice = value; }
        }

        // 6. Xay dung cac phuong thuc set, get cho lSale
        public Int64 lSale
        {
            get { return this._lSale; }
            set { this._lSale = value; }
        }

        // 7. Xay dung cac phuong thuc set, get cho bVAT
        public bool bVAT
        {
            get { return this._bVAT; }
            set { this._bVAT = value; }
        }

        // 8. Xay dung cac phuong thuc set, get cho sDescription
        public string sDescription
        {
            get { return this._sDescription; }
            set { this._sDescription = value; }
        }

        // 9. Xay dung cac phuong thuc set, get cho sInfomation
        public string sInfomation
        {
            get { return this._sInfomation; }
            set { this._sInfomation = value; }
        }

        // 10. Xay dung cac phuong thuc set, get cho sOrigin
        public string sOrigin
        {
            get { return this._sOrigin; }
            set { this._sOrigin = value; }
        }

        // 11. Xay dung cac phuong thuc set, get cho iQuantity
        public int iQuantity
        {
            get { return this._iQuantity; }
            set { this._iQuantity = value; }
        }

        // 12. Xay dung cac phuong thuc set, get cho sLinkImage
        public string sLinkImage
        {
            get { return this._sLinkImage; }
            set { this._sLinkImage = value; }
        }

        // 13. Xay dung cac phuong thuc set, get cho sLinkImageThumbnail
        public string sLinkImageThumbnail
        {
            get { return this._sLinkImageThumbnail; }
            set { this._sLinkImageThumbnail = value; }
        }

        // 14. Xay dung cac phuong thuc set, get cho tLastUpdate
        public DateTime tLastUpdate
        {
            get { return this._tLastUpdate; }
            set { this._tLastUpdate = value; }
        }

        // 15. Xay dung cac phuong thuc set, get cho bStatus
        public bool bStatus
        {
            get { return this._bStatus; }
            set { this._bStatus = value; }
        }
    }
}
