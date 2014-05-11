using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HaBa.EntityObject
{
    [Serializable()]
    public class tblThanhToanEO
    {
        private int _Pay_ID;
        private string _Pay_Name;
        private bool _Pay_Visible;

        // 1. Xay dung cac phuong thuc set, get cho Pay_ID
        public int Pay_ID
        {
            get { return this._Pay_ID; }
            set { this._Pay_ID = value; }
        }

        // 2. Xay dung cac phuong thuc set, get cho Pay_Name
        public string Pay_Name
        {
            get { return this._Pay_Name; }
            set { this._Pay_Name = value; }
        }

        // 3. Xay dung cac phuong thuc set, get cho Pay_Visible
        public bool Pay_Visible
        {
            get { return this._Pay_Visible; }
            set { this._Pay_Visible = value; }
        }
    }
}