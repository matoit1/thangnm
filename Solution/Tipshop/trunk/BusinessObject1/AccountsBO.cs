using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntityObject;
using System.Data;
using DataAccessObject;

namespace BusinessObject
{
    public class AccountsBO
    {
        //Login Accounts Admin
        public static DataSet setLoginAccountsAdmin(string Accounts_Username, string Accounts_Password)
        {
            DataSet ds = AccountsDAO.LoginAccountsAdmin(Accounts_Username, Accounts_Password);
            return ds;
        }


        //Login Accounts
        public static DataSet setLoginAccounts(string Accounts_Username, string Accounts_Password)
        {
            DataSet ds = AccountsDAO.LoginAccounts(Accounts_Username, Accounts_Password);
            return ds;
        }



        //Register Accounts Admin
        public static bool setInsertAccountsAdmin(string Accounts_Username, string Accounts_Password, string Accounts_Email, int Accounts_Permission, string Accounts_LinkAvatar, string Accounts_FullName, string Accounts_Address, DateTime Accounts_DateOfBirth, string Accounts_PhoneNumber, bool Accounts_Status)
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
            _AccountsEO.Accounts_Status = Accounts_Status;
            if (AccountsDAO.InsertAccountsAdmin(_AccountsEO))
                return true;
            else
                return false;
        }



        //Register Accounts
        public static bool setInsertAccounts(string Accounts_Username, string Accounts_Password, string Accounts_Email, string Accounts_LinkAvatar, string Accounts_FullName, string Accounts_Address, DateTime Accounts_DateOfBirth, string Accounts_PhoneNumber)
        {
            AccountsEO _AccountsEO = new AccountsEO();
            _AccountsEO.Accounts_Username = Accounts_Username;
            _AccountsEO.Accounts_Password = Accounts_Password;
            _AccountsEO.Accounts_Email = Accounts_Email;
            _AccountsEO.Accounts_LinkAvatar = Accounts_LinkAvatar;
            _AccountsEO.Accounts_FullName = Accounts_FullName;
            _AccountsEO.Accounts_Address = Accounts_Address;
            _AccountsEO.Accounts_DateOfBirth = Accounts_DateOfBirth;
            _AccountsEO.Accounts_PhoneNumber = Accounts_PhoneNumber;
            if (AccountsDAO.InsertAccounts(_AccountsEO))
                return true;
            else
                return false;
        }




        //Update Accounts Admin
        public static bool setUpdateAccountsAdmin(string Accounts_Username, string Accounts_Password, string Accounts_Email, int Accounts_Permission, string Accounts_LinkAvatar, string Accounts_FullName, string Accounts_Address, DateTime Accounts_DateOfBirth, string Accounts_PhoneNumber, bool Accounts_Status)
        {
            AccountsEO _AccountsEO = new AccountsEO();
            _AccountsEO.Accounts_Username = Accounts_Username;
            _AccountsEO. Accounts_Password= Accounts_Password;
            _AccountsEO.Accounts_Email = Accounts_Email;
            _AccountsEO.Accounts_Permission = Accounts_Permission;
            _AccountsEO.Accounts_LinkAvatar = Accounts_LinkAvatar;
            _AccountsEO.Accounts_FullName = Accounts_FullName;
            _AccountsEO.Accounts_Address = Accounts_Address;
            _AccountsEO.Accounts_DateOfBirth = Accounts_DateOfBirth;
            _AccountsEO.Accounts_PhoneNumber = Accounts_PhoneNumber;
            _AccountsEO.Accounts_Status = Accounts_Status;
            if (AccountsDAO.UpdateAccountsAdmin(_AccountsEO))
                return true;
            else
                return false;
        }



        //Update Accounts
        public static bool setUpdateAccounts(string Accounts_Username, string Accounts_Password, string Accounts_Email, string Accounts_LinkAvatar, string Accounts_FullName, string Accounts_Address, DateTime Accounts_DateOfBirth, string Accounts_PhoneNumber)
        {
            AccountsEO _AccountsEO = new AccountsEO();
            _AccountsEO.Accounts_Username = Accounts_Username;
            _AccountsEO.Accounts_Password = Accounts_Password;
            _AccountsEO.Accounts_Email = Accounts_Email;
            _AccountsEO.Accounts_LinkAvatar = Accounts_LinkAvatar;
            _AccountsEO.Accounts_FullName = Accounts_FullName;
            _AccountsEO.Accounts_Address = Accounts_Address;
            _AccountsEO.Accounts_DateOfBirth = Accounts_DateOfBirth;
            _AccountsEO.Accounts_PhoneNumber = Accounts_PhoneNumber;
            if (AccountsDAO.UpdateAccounts(_AccountsEO))
                return true;
            else
                return false;
        }



        // ResetPasswordAccounts
        public static bool setResetPasswordAccounts(string Accounts_Username, string Accounts_Password)
        {
            AccountsEO _AccountsEO = new AccountsEO();
            _AccountsEO.Accounts_Username = Accounts_Username;
            _AccountsEO.Accounts_Password = Accounts_Password;
            if (AccountsDAO.ResetPasswordAccounts(_AccountsEO))
                return true;
            else
                return false;
        }


        //Delete Accounts by Username
        public static bool setdeleteAccountsbyUsername(String Accounts_Username)
        {
            if (AccountsDAO.deleteAccountsbyUsername(Accounts_Username))
                return true;
            else
                return false;
        }

        //Check Email Accounts
        public static DataSet setCheckEmailAccounts(string Accounts_Email)
        {
            DataSet ds = AccountsDAO.CheckEmailAccounts(Accounts_Email);
            return ds;
        }

        //Check Username Accounts
        public static DataSet setCheckUsernameAccounts(string Accounts_Username)
        {
            DataSet ds = AccountsDAO.CheckUsernameAccounts(Accounts_Username);
            return ds;
        }
        //Get DataSet Accounts
        public static DataSet getDataSetAccounts(int Accounts_Permission)
        {
            DataSet ds = AccountsDAO.DataSetAccounts(Accounts_Permission);
            return ds;
        }

        //Begin Get DataSet Accounts by Username
        public static DataSet getDataSetAccountsbyUsername(string Accounts_Username)
        {
            return AccountsDAO.DataSetAccountsbyUsername(Accounts_Username);
        }

        //Begin Get DataSet Search Accounts by Fullname
        public static DataSet getDataSetSearchAccountsbyFullname(string Accounts_Fullname, string Accounts_Username, string Accounts_Email, string Accounts_Permission, string Accounts_Address)
        {
            return AccountsDAO.DataSetSearchAccountsbyFullname(Accounts_Fullname, Accounts_Username, Accounts_Email, Accounts_Permission, Accounts_Address);
        }
    }
}
