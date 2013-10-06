using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityObject
{
    public class SupportsEO
    {
        private Int64 _Supports_ID;
        private int _Customer_ID;
        private Int64 _Product_ID;
        private string _Supports_Type;
        private bool _Supports_Status;
        // 1. Xay dung cac phuong thuc set, get cho Supports_ID
        public Int64 Supports_ID
        {
            get { return this._Supports_ID; }
            set { this._Supports_ID = value; }
        }

        // 2. Xay dung cac phuong thuc set, get cho Customer_ID
        public int Customer_ID
        {
            get { return this._Customer_ID; }
            set { this._Customer_ID = value; }
        }

        // 3. Xay dung cac phuong thuc set, get cho Product_ID
        public Int64 Product_ID
        {
            get { return this._Product_ID; }
            set { this._Product_ID = value; }
        }

        // 4. Xay dung cac phuong thuc set, get cho Supports_Type
        public string Supports_Type
        {
            get { return this._Supports_Type; }
            set { this._Supports_Type = value; }
        }

        // 5. Xay dung cac phuong thuc set, get cho Answers_Status
        public bool Supports_Status
        {
            get { return this._Supports_Status; }
            set { this._Supports_Status = value; }
        }
    }
}
