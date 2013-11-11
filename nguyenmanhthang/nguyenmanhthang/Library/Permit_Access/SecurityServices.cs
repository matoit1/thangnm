using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using nguyenmanhthang.Library.Permit_Access;

namespace nguyenmanhthang.Library.Permit_Access
{
    public class SecurityServices
    {
        public static bool HasPermission(string FunctionName, int UserID, ItemFunction audit)
        {
            MyLoginDataDataContext ct = new MyLoginDataDataContext();
            UserPermiss myUser = ct.UserPermisses.Where(userp => userp.UserID == UserID && userp.PermissFunc.FunctionName == FunctionName).FirstOrDefault();
            if (myUser != null)
                return Utils.HasPermission(audit, myUser.PermissionNumber.GetValueOrDefault(0));
            return false;
        }
        public static string SetPermission(int UserID, string FunctionName, int AuditNumber)
        {
            MyLoginDataDataContext ct = new MyLoginDataDataContext();
            PermissFunc function = ct.PermissFuncs.Where(p => p.FunctionName == FunctionName).FirstOrDefault();
            if (function == null)
                return "Quyen khong ton tai";
            UserPermiss permis = new UserPermiss();
            permis.UserID = UserID;
            permis.PermissFunc = function;
            permis.PermissionNumber = AuditNumber;
            ct.UserPermisses.InsertOnSubmit(permis);
            ct.SubmitChanges();
            return "Da them quyen thanh cong";
        }
    }
}