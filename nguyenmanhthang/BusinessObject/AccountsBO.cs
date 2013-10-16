using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DataAccessObject;
using EntityObject;

namespace BusinessObject
{
    public class AccountsBO
    {
        // 1. Accounts_Insert
        public static bool Accounts_Insert(string Accounts_Username, string Accounts_Password, string Accounts_Email, int Accounts_Prefix, int Accounts_Permission, string Accounts_LinkAvatar, string Accounts_FullName, string Accounts_Address, DateTime Accounts_DateOfBirth, string Accounts_PhoneNumber, string Accounts_Signature, int Accounts_Like, bool Accounts_Notification, bool Accounts_Status)
        {
            AccountsEO _AccountsEO = new AccountsEO();
            _AccountsEO.Accounts_Username = Accounts_Username;
            _AccountsEO.Accounts_Password = Accounts_Password;
            _AccountsEO.Accounts_Email = Accounts_Email;
            _AccountsEO.Accounts_Prefix = Accounts_Prefix;
            _AccountsEO.Accounts_Permission = Accounts_Permission;
            _AccountsEO.Accounts_LinkAvatar = Accounts_LinkAvatar;
            _AccountsEO.Accounts_FullName = Accounts_FullName;
            _AccountsEO.Accounts_Address = Accounts_Address;
            _AccountsEO.Accounts_DateOfBirth = Accounts_DateOfBirth;
            _AccountsEO.Accounts_PhoneNumber = Accounts_PhoneNumber;
            _AccountsEO.Accounts_Signature = Accounts_Signature;
            _AccountsEO.Accounts_Like = Accounts_Like;
            _AccountsEO.Accounts_Notification = Accounts_Notification;
            _AccountsEO.Accounts_Status = Accounts_Status;
            if (AccountsDAO.Accounts_Insert(_AccountsEO))
                return true;
            else
                return false;
        }

        // 2. Accounts_Update
        public static bool Accounts_Update(string Accounts_Username, string Accounts_Password, string Accounts_Email, int Accounts_Prefix, int Accounts_Permission, string Accounts_LinkAvatar, string Accounts_FullName, string Accounts_Address, DateTime Accounts_DateOfBirth, string Accounts_PhoneNumber, string Accounts_Signature, int Accounts_Like, bool Accounts_Notification, bool Accounts_Status)
        {
            AccountsEO _AccountsEO = new AccountsEO();
            _AccountsEO.Accounts_Username = Accounts_Username;
            _AccountsEO.Accounts_Password = Accounts_Password;
            _AccountsEO.Accounts_Email = Accounts_Email;
            _AccountsEO.Accounts_Prefix = Accounts_Prefix;
            _AccountsEO.Accounts_Permission = Accounts_Permission;
            _AccountsEO.Accounts_LinkAvatar = Accounts_LinkAvatar;
            _AccountsEO.Accounts_FullName = Accounts_FullName;
            _AccountsEO.Accounts_Address = Accounts_Address;
            _AccountsEO.Accounts_DateOfBirth = Accounts_DateOfBirth;
            _AccountsEO.Accounts_PhoneNumber = Accounts_PhoneNumber;
            _AccountsEO.Accounts_Signature = Accounts_Signature;
            _AccountsEO.Accounts_Like = Accounts_Like;
            _AccountsEO.Accounts_Notification = Accounts_Notification;
            _AccountsEO.Accounts_Status = Accounts_Status;
            if (AccountsDAO.Accounts_Update(_AccountsEO))
                return true;
            else
                return false;
        }

        // 3. Accounts_ResetPassword
        public static bool Accounts_ResetPassword(string Accounts_Username, string Accounts_Password)
        {
            AccountsEO _AccountsEO = new AccountsEO();
            _AccountsEO.Accounts_Username = Accounts_Username;
            _AccountsEO.Accounts_Password = Accounts_Password;
            if (AccountsDAO.Accounts_ResetPassword(_AccountsEO))
                return true;
            else
                return false;
        }

        // 4. Accounts_Delete
        public static bool Accounts_Delete(string Accounts_Username)
        {
            AccountsEO _AccountsEO = new AccountsEO();
            _AccountsEO.Accounts_Username = Accounts_Username;
            if (AccountsDAO.Accounts_Delete(_AccountsEO))
                return true;
            else
                return false;
        }

        // 5. Accounts_Login
        public static DataSet Accounts_Login(string Accounts_Username, string Accounts_Password)
        {
            AccountsEO _AccountsEO = new AccountsEO();
            _AccountsEO.Accounts_Username = Accounts_Username;
            _AccountsEO.Accounts_Password = Accounts_Password;
            DataSet ds = AccountsDAO.Accounts_Login(_AccountsEO);
            return ds;
        }

        // 6. CheckAccounts_Username
        public static bool CheckAccounts_Username(string Accounts_Username)
        {
            AccountsEO _AccountsEO = new AccountsEO();
            _AccountsEO.Accounts_Username = Accounts_Username;
            if (AccountsDAO.CheckAccounts_Username(_AccountsEO))
                return true;
            else
                return false;
        }

        // 7. CheckAccounts_Email
        public static bool CheckAccounts_Email(string Accounts_Email)
        {
            AccountsEO _AccountsEO = new AccountsEO();
            _AccountsEO.Accounts_Email = Accounts_Email;
            if (AccountsDAO.CheckAccounts_Email(_AccountsEO))
                return true;
            else
                return false;
        }

        // 8. Accounts_SelectListbyAccounts_Username
        public static DataSet Accounts_SelectListbyAccounts_Username(string Accounts_Username)
        {
            AccountsEO _AccountsEO = new AccountsEO();
            _AccountsEO.Accounts_Username = Accounts_Username;
            DataSet ds = AccountsDAO.Accounts_SelectListbyAccounts_Username(_AccountsEO);
            return ds;
        }

        // 9. Accounts_SearchAccounts
        public static DataSet Accounts_SearchAccounts(string Accounts_Username, string Accounts_Email, int Accounts_Permission, string Accounts_FullName, string Accounts_Address)
        {
            AccountsEO _AccountsEO = new AccountsEO();
            _AccountsEO.Accounts_Username = Accounts_Username;
            _AccountsEO.Accounts_Email = Accounts_Email;
            _AccountsEO.Accounts_Permission = Accounts_Permission;
            _AccountsEO.Accounts_FullName = Accounts_FullName;
            _AccountsEO.Accounts_Address = Accounts_Address;
            DataSet ds = AccountsDAO.Accounts_SearchAccounts(_AccountsEO);
            return ds;
        }


    }
}
