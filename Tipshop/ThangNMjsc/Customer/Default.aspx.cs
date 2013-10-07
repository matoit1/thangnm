using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessObject;
using BusinessObject;
using System.Data;

namespace ThangNMjsc.Customer
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = AccountsBO.getDataSetAccountsbyUsername(Request.Cookies["client"].Value);
                imgbtnProfile.ImageUrl = ds.Tables[0].Rows[0]["Accounts_LinkAvatar"].ToString();
            }
            catch
            {
            }
        }
    }
}