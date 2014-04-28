using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityObject
{
    [Serializable()]
    public class OrdersEO
    {
        private Int64 _Orders_ID ;
	    private int _Client_ID;
	    private int _Pay_ID;
        private string _Pay_Email;
	    private string _Pay_FullName;
	    private string _Pay_Address;
	    private string _Pay_PhoneNumber;
	    private string _Pay_Note;
	    private bool _Pay_Status;
	    private DateTime _Pay_DateOfStart;
	    private DateTime _Pay_DateOfFinish;


        // 1. Xay dung cac phuong thuc set, get cho Orders_ID
        public Int64 Orders_ID
        {
            get { return this._Orders_ID; }
            set { this._Orders_ID = value; }
        }

        // 2. Xay dung cac phuong thuc set, get cho Client_ID
        public int Client_ID
        {
            get { return this._Client_ID; }
            set { this._Client_ID = value; }
        }

        // 3. Xay dung cac phuong thuc set, get cho Pay_ID
        public int Pay_ID
        {
            get { return this._Pay_ID; }
            set { this._Pay_ID = value; }
        }

        // 4. Xay dung cac phuong thuc set, get cho Pay_Email
        public string Pay_Email
        {
            get { return this._Pay_Email; }
            set { this._Pay_Email = value; }
        }

        // 5. Xay dung cac phuong thuc set, get cho Pay_FullName
        public string Pay_FullName
        {
            get { return this._Pay_FullName; }
            set { this._Pay_FullName = value; }
        }

        // 6. Xay dung cac phuong thuc set, get cho Pay_Address
        public string Pay_Address
        {
            get { return this._Pay_Address; }
            set { this._Pay_Address = value; }
        }

        // 7. Xay dung cac phuong thuc set, get cho Pay_PhoneNumber
        public string Pay_PhoneNumber
        {
            get { return this._Pay_PhoneNumber; }
            set { this._Pay_PhoneNumber = value; }
        }

        // 8. Xay dung cac phuong thuc set, get cho Pay_Note
        public string Pay_Note
        {
            get { return this._Pay_Note; }
            set { this._Pay_Note = value; }
        }

        // 9. Xay dung cac phuong thuc set, get cho Pay_Status
        public bool Pay_Status
        {
            get { return this._Pay_Status; }
            set { this._Pay_Status = value; }
        }

        // 10. Xay dung cac phuong thuc set, get cho Pay_DateOfStart
        public DateTime Pay_DateOfStart
        {
            get { return this._Pay_DateOfStart; }
            set { this._Pay_DateOfStart = value; }
        }

        // 11. Xay dung cac phuong thuc set, get cho Pay_DateOfFinish
        public DateTime Pay_DateOfFinish
        {
            get { return this._Pay_DateOfFinish; }
            set { this._Pay_DateOfFinish = value; }
        }
    }
}
