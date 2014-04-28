using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityObject
{
    [Serializable()]
    public class AdvertisementEO
    {
        private int _PK_iAdvID;
        private string _sTitle;
        private string _sLink;
        private string _sImage;

        // 1. Xay dung cac phuong thuc set, get cho PK_iAdvID
        public int PK_iAdvID
        {
            get { return this._PK_iAdvID; }
            set { this._PK_iAdvID = value; }
        }

        // 2. Xay dung cac phuong thuc set, get cho Title
        public string sTitle
        {
            get { return this._sTitle; }
            set { this._sTitle = value; }
        }

        // 3. Xay dung cac phuong thuc set, get cho Link
        public string sLink
        {
            get { return this._sLink; }
            set { this._sLink = value; }
        }

        // 4. Xay dung cac phuong thuc set, get cho Image
        public string sImage
        {
            get { return this._sImage; }
            set { this._sImage = value; }
        }
    }
}