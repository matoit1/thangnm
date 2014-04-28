using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityObject
{
    [Serializable()]
    public class WebsiteEO
    {
        private int _Website_ID;
        private string _Website_Title;
        private string _Website_Content;
        private DateTime _Website_LastUpdate;

        // 1. Xay dung cac phuong thuc set, get cho Website_ID
        public int Website_ID
        {
            get { return this._Website_ID; }
            set { this._Website_ID = value; }
        }

        // 2. Xay dung cac phuong thuc set, get cho Website_Title
        public string Website_Title
        {
            get { return this._Website_Title; }
            set { this._Website_Title = value; }
        }

        // 3. Xay dung cac phuong thuc set, get cho Website_Content
        public string Website_Content
        {
            get { return this._Website_Content; }
            set { this._Website_Content = value; }
        }

        // 4. Xay dung cac phuong thuc set, get cho Website_LastUpdate
        public DateTime Website_LastUpdate
        {
            get { return this._Website_LastUpdate; }
            set { this._Website_LastUpdate = value; }
        }
    }
}
