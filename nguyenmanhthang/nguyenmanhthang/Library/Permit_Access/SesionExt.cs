using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace nguyenmanhthang.Library.Permit_Access
{
    public static class SesionExt
    {
        public static void SetCurrentUser(this HttpSessionState session, SalesUser user)
        {
            session["currentUser"] = user;
        }
        public static SalesUser GetCurrentUser(this HttpSessionState session)
        {
            return session["currentUser"] as SalesUser;
        }
    }
}