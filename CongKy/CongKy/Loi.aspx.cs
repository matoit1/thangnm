using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CongKy.SharedLibraries.Constants;
using CongKy.SharedLibraries;

namespace CongKy
{
    public partial class Loi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Request.QueryString["Type"] != null)
                {
                    switch (Convert.ToInt16(Request.QueryString["Type"]))
                    {
                        case ERROR_C.Khong_Co_Quyen: lblMsg.Text = GetTextConstants.ERROR_GTC(ERROR_C.Khong_Co_Quyen); break;

                    }
                }
            }
            catch(Exception ex){
                lblMsg.Text = ex.Message;
            }
        }
    }
}