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
        // 1. Insert
        public static bool Insert(string Accounts_Username, string Accounts_Password, string Accounts_Email, int Accounts_Permission, string Accounts_LinkAvatar, string Accounts_FullName, string Accounts_Address, DateTime Accounts_DateOfBirth, string Accounts_PhoneNumber, string Accounts_Signature, int Accounts_Like, bool Accounts_Notification, bool Accounts_Status)
        {
            AccountsEO _AccountsEO = new AccountsEO();
            _AccountsEO.Accounts_Username = Accounts_Username;
            _AccountsEO.Accounts_Password = Accounts_Password;
            _AccountsEO.Accounts_Email = Accounts_Email;
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
            if (AccountsDAO.Insert(_AccountsEO))
                return true;
            else
                return false;
        }

        // 2. Update
        public static bool Update(string Accounts_Username, string Accounts_Password, string Accounts_Email, int Accounts_Permission, string Accounts_LinkAvatar, string Accounts_FullName, string Accounts_Address, DateTime Accounts_DateOfBirth, string Accounts_PhoneNumber, string Accounts_Signature, int Accounts_Like, bool Accounts_Notification, bool Accounts_Status)
        {
            AccountsEO _AccountsEO = new AccountsEO();
            _AccountsEO.Accounts_Username = Accounts_Username;
            _AccountsEO.Accounts_Password = Accounts_Password;
            _AccountsEO.Accounts_Email = Accounts_Email;
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
            if (AccountsDAO.Update(_AccountsEO))
                return true;
            else
                return false;
        }

        // 3. ResetPassword
        public static bool ResetPassword(string Accounts_Username, string Accounts_Password)
        {
            AccountsEO _AccountsEO = new AccountsEO();
            _AccountsEO.Accounts_Username = Accounts_Username;
            _AccountsEO.Accounts_Password = Accounts_Password;
            if (AccountsDAO.ResetPassword(_AccountsEO))
                return true;
            else
                return false;
        }

        // 4. Delete
        public static bool Delete(string Accounts_Username)
        {
            AccountsEO _AccountsEO = new AccountsEO();
            _AccountsEO.Accounts_Username = Accounts_Username;
            if (AccountsDAO.Delete(_AccountsEO))
                return true;
            else
                return false;
        }

        // 5. Login
        public static DataSet Login(string Accounts_Username, string Accounts_Password)
        {
            AccountsEO _AccountsEO = new AccountsEO();
            _AccountsEO.Accounts_Username = Accounts_Username;
            _AccountsEO.Accounts_Password = Accounts_Password;
            DataSet ds = AccountsDAO.Login(_AccountsEO);
            return ds;
        }

        // 6. CheckAccounts_Username
        public static DataSet CheckAccounts_Username(string Accounts_Username)
        {
            AccountsEO _AccountsEO = new AccountsEO();
            _AccountsEO.Accounts_Username = Accounts_Username;
            DataSet ds = AccountsDAO.CheckAccounts_Username(_AccountsEO);
            return ds;
        }

        // 7. CheckAccounts_Email
        public static DataSet CheckAccounts_Email(string Accounts_Email)
        {
            AccountsEO _AccountsEO = new AccountsEO();
            _AccountsEO.Accounts_Email = Accounts_Email;
            DataSet ds = AccountsDAO.CheckAccounts_Email(_AccountsEO);
            return ds;
        }

        // 8. SelectInfoByAccounts_Username
        public static DataSet SelectInfoByAccounts_Username(string Accounts_Username)
        {
            AccountsEO _AccountsEO = new AccountsEO();
            _AccountsEO.Accounts_Username = Accounts_Username;
            DataSet ds = AccountsDAO.SelectInfoByAccounts_Username(_AccountsEO);
            return ds;
        }

        // 9. SelectInfoByAccounts_ID
        public static DataSet SelectInfoByAccounts_ID(Int64 Accounts_ID)
        {
            AccountsEO _AccountsEO = new AccountsEO();
            _AccountsEO.Accounts_ID = Accounts_ID;
            DataSet ds = AccountsDAO.SelectInfoByAccounts_ID(_AccountsEO);
            return ds;
        }

        // 10. SelectInfoByAccounts_EmailvsAccounts_PhoneNumber
        public static DataSet SelectInfoByAccounts_EmailvsAccounts_PhoneNumber(string Accounts_Email, string Accounts_PhoneNumber)
        {
            AccountsEO _AccountsEO = new AccountsEO();
            _AccountsEO.Accounts_Email = Accounts_Email;
            _AccountsEO.Accounts_PhoneNumber = Accounts_PhoneNumber;
            DataSet ds = AccountsDAO.SelectInfoByAccounts_EmailvsAccounts_PhoneNumber(_AccountsEO);
            return ds;
        }

        // 10. SearchAccounts
        public static DataSet SearchAccounts(string Accounts_Username, string Accounts_Email, int Accounts_Permission, string Accounts_FullName, string Accounts_Address)
        {
            AccountsEO _AccountsEO = new AccountsEO();
            _AccountsEO.Accounts_Username = Accounts_Username;
            _AccountsEO.Accounts_Email = Accounts_Email;
            _AccountsEO.Accounts_Permission = Accounts_Permission;
            _AccountsEO.Accounts_FullName = Accounts_FullName;
            _AccountsEO.Accounts_Address = Accounts_Address;
            DataSet ds = AccountsDAO.SearchAccounts(_AccountsEO);
            return ds;
        }

        // 11. GetAccounts_IDbyAccounts_Username
        public static DataSet GetAccounts_IDbyAccounts_Username(string Accounts_Username)
        {
            AccountsEO _AccountsEO = new AccountsEO();
            _AccountsEO.Accounts_Username = Accounts_Username;
            DataSet ds = AccountsDAO.GetAccounts_IDbyAccounts_Username(_AccountsEO);
            return ds;
        }

        // 12. SelectListByAccounts_Status
        public static DataSet SelectListByAccounts_Status(bool Accounts_Status)
        {
            AccountsEO _AccountsEO = new AccountsEO();
            _AccountsEO.Accounts_Status = Accounts_Status;
            DataSet ds = AccountsDAO.SelectListByAccounts_Status(_AccountsEO);
            return ds;
        }
    }
}
