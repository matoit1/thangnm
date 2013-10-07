﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessObject;
using BusinessObject;
using System.Data;

namespace ThangNMjsc.Info
{
    public partial class ThangNMjsc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = WebsiteBO.getDataSetWebsitebyWebsite_ID(1).Tables[0];
                lblInfo.Text = Convert.ToString(dt.Rows[0]["Website_Content"]);
            }
            catch (Exception)
            { }
        }
    }
}