﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessObject;

namespace nguyenmanhthang.UserControl
{
    public partial class CommentUC : System.Web.UI.UserControl
    {
        private Int64 _Topic_ID;
        public Int64 Topic_ID
        {
            get { return this._Topic_ID; }
            set { _Topic_ID = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnComment_Click(object sender, EventArgs e)
        {
            try
            {
                string Comment_Website;
                if (txtComment_Website.Text.Contains("http://") || txtComment_Website.Text.Contains("https://"))
                {
                    Comment_Website = txtComment_Website.Text;
                }
                else
                {
                    Comment_Website = "http://" + txtComment_Website.Text;
                }
                bool check = CommentBO.Comment_Insert(Topic_ID, txtComment_Name.Text, txtComment_Email.Text, Comment_Website, txtComment_Content.Text);
                if (check == true)
                {
                    lblMessage.Text = "Bình luận thành công";
                    lblMessage.CssClass = "alert_success";
                    txtComment_Content.Text = "";
                    Response.Redirect(Request.Url.AbsoluteUri + "#comment_success");
                }
                else
                {
                    lblMessage.Text = "Có lỗi xảy ra. Vui lòng kiểm tra lại";
                    lblMessage.CssClass = "alert_error";
                }
            }
            catch (Exception)
            {
                lblMessage.Text = "Có lỗi xảy ra. Vui lòng kiểm tra lại";
                lblMessage.CssClass = "alert_error";
            }
        }
    }
}