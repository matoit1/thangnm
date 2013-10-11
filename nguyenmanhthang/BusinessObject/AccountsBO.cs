using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DataAccessObject;

namespace BusinessObject
{
    public class AccountsBO
    {
        //Login Accounts Admin
        public static DataSet Accounts_Login(string Accounts_Username, string Accounts_Password)
        {
            DataSet ds = AccountsDAO.Accounts_Login(Accounts_Username, Accounts_Password);
            return ds;
        }

        //Begin getAccountsbyUsername
        public static DataSet getAccountsbyUsername(string Accounts_Username)
        {
            return AccountsDAO.getAccountsbyUsername(Accounts_Username);
        }
    }
}
