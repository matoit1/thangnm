using System;
using System.Security.Principal;
using System.Web;
using System.Web.SessionState;

/// <summary>
/// Contains a "strongly typed" way of referencing session variables
/// </summary>
public static class SessionStateSink {
    //quick-reference for HttpContext.Current.[Session,Request,Response,User,etc]
    #region helpers
    /// <summary>
    /// current response object
    /// </summary>
    private static HttpResponse Response {
        get { return HttpContext.Current.Response; }
    }
    /// <summary>
    /// current request object
    /// </summary>
    private static HttpRequest Request {
        get { return HttpContext.Current.Request; }
    }
    /// <summary>
    /// current Session object
    /// </summary>
    private static HttpSessionState Session {
        get { return HttpContext.Current.Session; }
    }
    /// <summary>
    /// current User object
    /// </summary>
    private static IPrincipal User {
        get { return HttpContext.Current.User; }
    }
    #endregion
    #region session attributes
    public static bool IsTechnician {
        get {
            if (Session["IsTechnician"] == null) {
                Session["IsTechnician"] = false;
            }
            return (bool)Session["IsTechnician"];
        }
        set {
            Session["IsTechnician"] = value;
        }
    }
    #endregion
}
