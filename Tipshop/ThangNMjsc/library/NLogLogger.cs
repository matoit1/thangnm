using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
 
using System.Diagnostics;

/// <summary>
/// Summary description for NLogLogger
/// </summary>
/// 
namespace Common
{
    public static class NLogLogger
    {
        static NLogLogger()
        {
            
        }

     

        public static void Info(string message)
        {
           
        }

        public static void Fatal(string message)
        {
           
        }

        private static string GetCalleeString()
        {
            foreach (StackFrame sf in new StackTrace().GetFrames())
            {
                if (sf.GetMethod().ReflectedType.Namespace != "Common")
                {
                    return string.Format("{0}.{1}", sf.GetMethod().ReflectedType.Name, sf.GetMethod().Name);
                }
            }

            return string.Empty;
        }
    }
}