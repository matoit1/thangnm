﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace nguyenmanhthang.Error
{
    public partial class _401 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Request.ServerVariables("REMOTE_ADDR");
            Request.Browser.Browsers.ToString();
        }
    }
}