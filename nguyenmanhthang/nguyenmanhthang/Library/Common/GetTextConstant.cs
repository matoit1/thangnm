using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace nguyenmanhthang.Library.Common
{
    public class GetTextConstant
    {
        public static  string getTextByAccounts_Permission(int Accounts_Permission){
            string name;
            switch  (Accounts_Permission)
            {
                case 0: name = "Client"; break;
                case 1: name="Administrator";break;
                case 2: name="Admin";break;
                case 3: name="Author";break;
                case 4: name="Editor";break;
                case 5: name="Visitor";break;
                case 6: name="Followers";break;
                default: name="Anonymous";break;
            }
            return name;
        }

        public static string getPermissDefault(int Accounts_Permission)
        {
            string DefaultValue;
            switch (Accounts_Permission)
            {
                case 0: DefaultValue = "FAQ_btnAdd, FAQ_btnDelete"; break;
                case 1: DefaultValue = "FAQ_btnAdd, FAQ_btnDelete"; break;
                case 2: DefaultValue = "FAQ_btnAdd, FAQ_btnDelete"; break;
                case 3: DefaultValue = "FAQ_btnAdd, FAQ_btnDelete"; break;
                case 4: DefaultValue = "FAQ_btnAdd, FAQ_btnDelete"; break;
                case 5: DefaultValue = "FAQ_btnAdd, FAQ_btnDelete"; break;
                case 6: DefaultValue = "FAQ_btnAdd, FAQ_btnDelete"; break;
                default: DefaultValue = "null"; break;
            }
            return DefaultValue;
        }
    }
}