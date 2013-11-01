using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace nguyenmanhthang.Library.Common
{
    public class GetTextConstant
    {
        public string getTextByAccounts_Permission(int Accounts_Permission){
            string name;
            switch  (Accounts_Permission)
            {
                case 1: name="Administrator";break;
                case 2: name="Administrator";break;
                case 3: name="Author";break;
                case 4: name="Editor";break;
                case 5: name="Visitor";break;
                case 6: name="Followers";break;
                default: name="Anonymous";break;
            }
            
            return name;
        }
    }
}