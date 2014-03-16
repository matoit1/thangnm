using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessObject;
using Shared_Libraries.Constants;
using System.IO;
using EntityObject;

namespace DO_AN_TN.Error
{
    public partial class _405 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    ErrorEO _ErrorEO = new ErrorEO();
                    _ErrorEO.sLink = Request.Url.ToString();
                    _ErrorEO.sIP = HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"].Replace("::ffff:", "");
                    _ErrorEO.sBrowser = Request.UserAgent.ToString();
                    _ErrorEO.iCodes = Convert.ToInt16(Path.GetFileName(Request.Path).Replace(".aspx", ""));
                    _ErrorEO.tTime = DateTime.Now;
                    _ErrorEO.tTimeCheck = DateTime.Now;
                    _ErrorEO.iStatus = Error_iStatus_C.Da_Phat_Hien;
                    if (ErrorDAO.Error_Insert(_ErrorEO) == true)
                    {
                        lblMsg.Text = "Ghi Log thành công!";
                    }
                    else
                    {
                        lblMsg.Text = "Ghi Log không thành công!";
                    }
                }
                catch (Exception ex)
                {
                    lblMsg.Text = ex.Message;
                }
            }
        }
    }
}