using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityObject
{
    public class OrdersDetailsEO
    {
        private Int64 _OrdersDetails_ID;
	    private Int64 _Orders_ID;
	    private Int64 _Pro_ID;
	    private Int64 _OrdersDetails_UnitPrice;
	    private int _OrdersDetails_Quantity;

        // 1. Xay dung cac phuong thuc set, get cho OrdersDetails_ID
        public Int64 OrdersDetails_ID
        {
            get { return this._OrdersDetails_ID; }
            set { this._OrdersDetails_ID = value; }
        }

        // 2. Xay dung cac phuong thuc set, get cho Orders_ID
        public Int64 Orders_ID
        {
            get { return this._Orders_ID; }
            set { this._Orders_ID = value; }
        }

        // 3. Xay dung cac phuong thuc set, get cho Pro_ID
        public Int64 Pro_ID
        {
            get { return this._Pro_ID; }
            set { this._Pro_ID = value; }
        }

        // 4. Xay dung cac phuong thuc set, get cho OrdersDetails_UnitPrice
        public Int64 OrdersDetails_UnitPrice
        {
            get { return this._OrdersDetails_UnitPrice; }
            set { this._OrdersDetails_UnitPrice = value; }
        }

        // 5. Xay dung cac phuong thuc set, get cho OrdersDetails_Quantity
        public int OrdersDetails_Quantity
        {
            get { return this._OrdersDetails_Quantity; }
            set { this._OrdersDetails_Quantity = value; }
        }
    }
}
