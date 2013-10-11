using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityObject
{
    public class AccountsEO
    {
        private int _Accounts_ID;
        private string _Accounts_Username;
        private string _Accounts_Password;
        private string _Accounts_Email;
        private int _Accounts_Permission;
        private DateTime _Accounts_RegisterDate;
        private string _Accounts_LinkAvatar;
        private string _Accounts_FullName;
        private string _Accounts_Address;
        private DateTime _Accounts_DateOfBirth;
        private string _Accounts_PhoneNumber;
        private string _Accounts_Signature;
        private int _Accounts_Like;
        private bool _Accounts_Notification;
        private bool _Accounts_Status;

        // 1. Xay dung cac phuong thuc set, get cho Accounts_ID
        public int Accounts_ID
        {
            get { return this._Accounts_ID; }
            set { this._Accounts_ID = value; }
        }

        // 2. Xay dung cac phuong thuc set, get cho Accounts_Username
        public string Accounts_Username
        {
            get { return this._Accounts_Username; }
            set { this._Accounts_Username = value; }
        }

        // 3. Xay dung cac phuong thuc set, get cho _Accounts_Password
        public string Accounts_Password
        {
            get { return this._Accounts_Password; }
            set { this._Accounts_Password = value; }
        }

        // 4. Xay dung cac phuong thuc set, get cho Accounts_Email
        public string Accounts_Email
        {
            get { return this._Accounts_Email; }
            set { this._Accounts_Email = value; }
        }

        // 5. Xay dung cac phuong thuc set, get cho Accounts_Permission
        public int Accounts_Permission
        {
            get { return this._Accounts_Permission; }
            set { this._Accounts_Permission = value; }
        }

        // 6. Xay dung cac phuong thuc set, get cho Accounts_RegisterDate
        public DateTime Accounts_RegisterDate
        {
            get { return this._Accounts_RegisterDate; }
            set { this._Accounts_RegisterDate = value; }
        }

        // 7. Xay dung cac phuong thuc set, get cho Accounts_LinkAvatar
        public string Accounts_LinkAvatar
        {
            get { return this._Accounts_LinkAvatar; }
            set { this._Accounts_LinkAvatar = value; }
        }

        // 8. Xay dung cac phuong thuc set, get cho Accounts_FullName
        public string Accounts_FullName
        {
            get { return this._Accounts_FullName; }
            set { this._Accounts_FullName = value; }
        }

        // 9. Xay dung cac phuong thuc set, get cho Accounts_Address
        public string Accounts_Address
        {
            get { return this._Accounts_Address; }
            set { this._Accounts_Address = value; }
        }

        // 10. Xay dung cac phuong thuc set, get cho Accounts_DateOfBirth
        public DateTime Accounts_DateOfBirth
        {
            get { return this._Accounts_DateOfBirth; }
            set { this._Accounts_DateOfBirth = value; }
        }

        // 11. Xay dung cac phuong thuc set, get cho Accounts_PhoneNumber
        public string Accounts_PhoneNumber
        {
            get { return this._Accounts_PhoneNumber; }
            set { this._Accounts_PhoneNumber = value; }
        }

        // 12. Xay dung cac phuong thuc set, get cho Accounts_Signature
        public string Accounts_Signature
        {
            get { return this._Accounts_Signature; }
            set { this._Accounts_Signature = value; }
        }

        // 13. Xay dung cac phuong thuc set, get cho Accounts_Like
        public int Accounts_Like
        {
            get { return this._Accounts_Like; }
            set { this._Accounts_Like = value; }
        }

        // 14. Xay dung cac phuong thuc set, get cho Accounts_Notification
        public bool Accounts_Notification
        {
            get { return this._Accounts_Notification; }
            set { this._Accounts_Notification = value; }
        }

        // 15. Xay dung cac phuong thuc set, get cho Accounts_Status
        public bool Accounts_Status
        {
            get { return this._Accounts_Status; }
            set { this._Accounts_Status = value; }
        }
    }
}
