﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EHOU.Share_Interface
{
    public partial class GiangVien_SI : System.Web.UI.MasterPage
    {
        public void Page_Load(object sender, EventArgs e)
        {
            Session["account_gv"] = "gv1";
            //try
            //{
            //    if (Request.Cookies["giangvien"] == null)
            //    {
            //        Response.Redirect("~/GiangVien/Accounts/Login.aspx?Return_Url=" + Request.Url.ToString());
            //    }
            //    //lblInfo.Text = "   Hi, " + Request.Cookies["giangvien"].Value;
            //}
            //catch
            //{
            //    Response.Cookies["giangvien"].Expires = DateTime.Now.AddDays(-1);
            //    Response.Redirect("~/GiangVien/Accounts/Login.aspx?Return_Url=" + Request.Url.ToString());
            //}
        }

        protected void lbtnLogout_Click(object sender, EventArgs e)
        {
            Response.Cookies["giangvien"].Expires = DateTime.Now.AddDays(-1);
            Response.Redirect(Request.Url.ToString());
        }
    }
}