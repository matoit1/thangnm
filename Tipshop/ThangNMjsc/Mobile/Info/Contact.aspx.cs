using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BusinessObject;

namespace ThangNMjsc.Mobile.Info
{
    public partial class Contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = WebsiteBO.getDataSetWebsitebyWebsite_ID(3).Tables[0];
                lblContact.Text = Convert.ToString(dt.Rows[0]["Website_Content"]);
            }
            catch (Exception)
            { }
        }
    }
}