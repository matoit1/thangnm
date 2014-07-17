using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityObject
{
    [Serializable()]
    public class tblAccountEO
    {
        private int _PK_iAccountsID;
        private string _sUsername;
        private string _sPassword;
        private string _sEmail;
        private string _sFullName;
        private string _sAddress;
        private DateTime _tDateOfBirth;
        private string _sPhoneNumber;
        private int _iPermission;
        private string _sLinkAvatar;
        private string _sSignature;
        private int _iAlias;
        private Boolean _bNotification;
        private int _iStatus;
        private DateTime _tRegisterDate;

        public int PK_iAccountsID
        {
            get { return this._PK_iAccountsID; }
            set { this._PK_iAccountsID = value; }
        }

        public string sUsername
        {
            get { return this._sUsername; }
            set { this._sUsername = value; }
        }

        public string sPassword
        {
            get { return this._sPassword; }
            set { this._sPassword = value; }
        }

        public string sEmail
        {
            get { return this._sEmail; }
            set { this._sEmail = value; }
        }

        public string sFullName
        {
            get { return this._sFullName; }
            set { this._sFullName = value; }
        }

        public string sAddress
        {
            get { return this._sAddress; }
            set { this._sAddress = value; }
        }

        public DateTime tDateOfBirth
        {
            get { return this._tDateOfBirth; }
            set { this._tDateOfBirth = value; }
        }

        public string sPhoneNumber
        {
            get { return this._sPhoneNumber; }
            set { this._sPhoneNumber = value; }
        }

        public int iPermission
        {
            get { return this._iPermission; }
            set { this._iPermission = value; }
        }

        public string sLinkAvatar
        {
            get { return this._sLinkAvatar; }
            set { this._sLinkAvatar = value; }
        }

        public string sSignature
        {
            get { return this._sSignature; }
            set { this._sSignature = value; }
        }

        public int iAlias
        {
            get { return this._iAlias; }
            set { this._iAlias = value; }
        }

        public Boolean bNotification
        {
            get { return this._bNotification; }
            set { this._bNotification = value; }
        }

        public int iStatus
        {
            get { return this._iStatus; }
            set { this._iStatus = value; }
        }

        public DateTime tRegisterDate
        {
            get { return this._tRegisterDate; }
            set { this._tRegisterDate = value; }
        }
    }
}