using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HaBa.EntityObject
{
    [Serializable()]
    public class tblTaiKhoanEO
    {
        private int _PK_iAccountID;
        private string _sFullName;
        private string _sUsername;
        private string _sPassword;
        private string _sEmail;
        private string _sAddress;
        private string _sPhoneNumber;
        private string _sLinkAvatar;
        private DateTime _tDateOfBirth;
        private DateTime _tRegisterDate;
        private Int16 _iPermission;
        private bool _bStatus;

        // 1. Xay dung cac phuong thuc set, get cho PK_iAccountID
        public int PK_iAccountID
        {
            get { return this._PK_iAccountID; }
            set { this._PK_iAccountID = value; }
        }

        // 2. Xay dung cac phuong thuc set, get cho sFullName
        public string sFullName
        {
            get { return this._sFullName; }
            set { this._sFullName = value; }
        }

        // 3. Xay dung cac phuong thuc set, get cho sUsername
        public string sUsername
        {
            get { return this._sUsername; }
            set { this._sUsername = value; }
        }

        // 4. Xay dung cac phuong thuc set, get cho sPassword
        public string sPassword
        {
            get { return this._sPassword; }
            set { this._sPassword = value; }
        }

        // 5. Xay dung cac phuong thuc set, get cho sEmail
        public string sEmail
        {
            get { return this._sEmail; }
            set { this._sEmail = value; }
        }

        // 6. Xay dung cac phuong thuc set, get cho sAddress
        public string sAddress
        {
            get { return this._sAddress; }
            set { this._sAddress = value; }
        }

        // 7. Xay dung cac phuong thuc set, get cho sPhoneNumber
        public string sPhoneNumber
        {
            get { return this._sPhoneNumber; }
            set { this._sPhoneNumber = value; }
        }

        // 8. Xay dung cac phuong thuc set, get cho sLinkAvatar
        public string sLinkAvatar
        {
            get { return this._sLinkAvatar; }
            set { this._sLinkAvatar = value; }
        }

        // 9. Xay dung cac phuong thuc set, get cho tDateOfBirth
        public DateTime tDateOfBirth
        {
            get { return this._tDateOfBirth; }
            set { this._tDateOfBirth = value; }
        }

        // 10. Xay dung cac phuong thuc set, get cho tRegisterDate
        public DateTime tRegisterDate
        {
            get { return this._tRegisterDate; }
            set { this._tRegisterDate = value; }
        }

        // 11. Xay dung cac phuong thuc set, get cho iPermission
        public Int16 iPermission
        {
            get { return this._iPermission; }
            set { this._iPermission = value; }
        }

        // 12. Xay dung cac phuong thuc set, get cho _bStatus
        public bool bStatus
        {
            get { return this._bStatus; }
            set { this._bStatus = value; }
        }
    }
}