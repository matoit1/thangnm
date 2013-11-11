using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace nguyenmanhthang.Library.Permit_Access
{
    public static class Utils
    {
        public static bool HasPermission(ItemFunction audit, int permission)
        {
            if (((int)audit & permission) == (int)audit)
                return true;
            return false;
        }
    }
}