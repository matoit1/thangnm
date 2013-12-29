using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessObject;
using System.Data;

namespace nguyenmanhthang.Common
{
    public partial class Default : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadNewTopic();
                if (Request.Cookies["administrator"] != null) // Neu la Admin
                {
                    panelInfoAccount.Visible = true;
                    try
                    {
                        DataSet ds = AccountsBO.SelectInfoByAccounts_Username(Request.Cookies["administrator"].Value);
                        imgAvatar.ImageUrl = ds.Tables[0].Rows[0]["Accounts_LinkAvatar"].ToString();
                        lblWelcome.Text = "   Hi, " + ds.Tables[0].Rows[0]["Accounts_Fullname"].ToString();// xuất lời chào.
                        hpEditAccount.NavigateUrl = "~/Admin/Edit/EditAccounts.aspx?Accounts_Username=" + Request.Cookies["administrator"].Value;
                    }
                    catch
                    {
                        Response.Cookies["administrator"].Expires = DateTime.Now.AddDays(-1);
                        Response.Redirect(Request.Url.AbsolutePath);
                    }
                }
                else
                {
                    panelInfoAccount.Visible = false;
                }
            }
        }

        protected void lbtnLogout_Click(object sender, EventArgs e)     // Xu y su kien cho buttom Logout
        {
            if (Response.Cookies["administrator"] == null)
            {
                Response.Cookies["administrator"].Expires = DateTime.Now.AddDays(-1);
                Response.Redirect(Request.Url.AbsolutePath);
            }
            else
            {
                Response.Cookies["client"].Expires = DateTime.Now.AddDays(-1);
                Response.Redirect(Request.Url.AbsolutePath);
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {

        }

        protected void LoadNewTopic() // Hien danh sach san pham moi o Left Menu
        {
            try
            {
                DataTable tbNewProduct = TopicBO.Topic_SelectListToShow(true, 3).Tables[0];
                dtlNewTopic.DataSource = tbNewProduct;
                dtlNewTopic.DataBind();
            }
            catch { }
        }

        protected void dtlNewTopic_ItemCommand(object source, DataListCommandEventArgs e) // Xu y su kien cho buttom xem chi tiet san pham o New Product - Left Menu
        {
            DataTable tb = new DataTable();
            string name = e.CommandName;
            if (name == "Detail")
            {
                string linkDetail = "~/Topic.aspx/?Topic_ID=" + ((HiddenField)e.Item.FindControl("hdfTopic_ID")).Value;
                Response.Redirect(linkDetail);
            }
        }

        protected void Navigation_Click(object sender, EventArgs e)
        {
            if (LoginUC1.state == true) { Response.Redirect(Request.Url.AbsolutePath); } else { Response.Redirect("~/Accounts/Login.aspx"); }
        }
    }
}