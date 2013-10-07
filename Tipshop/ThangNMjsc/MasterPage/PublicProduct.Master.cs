using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using BusinessObject;
using System.Web.Caching;
using System.Net.Mail;

namespace ThangNMjsc.MasterPage
{
    public partial class PublicProduct : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtAccounts_FullName.Attributes.Add("placeholder", "Nhập Tên của bạn");
            txtAccounts_Email.Attributes.Add("placeholder", "Nhập Email của bạn");
            txtSupports_Content.Attributes.Add("placeholder", "Nhập Nội dung của bạn");
            txtAccounts_FullName.Text = "";
            txtAccounts_Email.Text = "";
            txtSupports_Content.Text = "";
            //Session["Layout"] = "Desktop";
            if (!IsPostBack)
            {
                try
                {
                    if (Session["Layout"].ToString() == "Mobile")
                    {
                        Response.Redirect("/Mobile" + Request.Url.AbsolutePath);
                    }
                        //else
                        //{
                        //    if (isMobileDevice() == true)
                        //    {
                        //        Response.Redirect("/Mobile" + Request.Url.AbsolutePath);
                        //    }
                        //}
                }
                catch { }
                LoadNewProduct();
                Load_ParentProduct();
                LoadLink();
                txtProducts_Name.Attributes.Add("placeholder", "Tìm kiếm theo tên sản phẩm");
                if (Request.Cookies["administrator"] != null) // Neu la Admin
                {
                    panelInfoAccount.Visible = true;
                    panelLogin.Visible = false;
                    try
                    {
                        DataSet ds = AccountsBO.getDataSetAccountsbyUsername(Request.Cookies["administrator"].Value);
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
                else {
                    if(Request.Cookies["client"] != null) // Neu la Customer
                    {
                        panelInfoAccount.Visible = true;
                        panelLogin.Visible = false;
                        try
                        {
                            DataSet ds = AccountsBO.getDataSetAccountsbyUsername(Request.Cookies["client"].Value);
                            imgAvatar.ImageUrl = ds.Tables[0].Rows[0]["Accounts_LinkAvatar"].ToString(); ;
                            lblWelcome.Text = "   Hi, " + ds.Tables[0].Rows[0]["Accounts_Fullname"].ToString(); ;// xuất lời chào.
                            hpEditAccount.NavigateUrl = "~/Customer/Profile.aspx";
                        }
                        catch
                        {
                            Response.Cookies["client"].Expires = DateTime.Now.AddDays(-1);
                            Response.Redirect(Request.Url.AbsolutePath);
                        }
                    }
                    else
                    {
                        panelInfoAccount.Visible = false;
                        panelLogin.Visible = true;
                    }
                }
            }
        }

        private bool isMobileDevice()
        {
            string userAgent = Request.UserAgent.ToLower();
            return userAgent.Contains("iphone") |
                    userAgent.Contains("blackberry") |
                    userAgent.Contains("opera mini") |
                    userAgent.Contains("mobile") |
                    userAgent.Contains("ipad") |
                    userAgent.Contains("android");
        }

        protected void Load_ParentProduct() // Hien cac danh muc lon Menu
        {
            DataSet ds = ProductsBO.getDataSetGroupProducts_Parent(0);
            rpListParentProduct.DataSource = ds.Tables[0];
            rpListParentProduct.DataBind();
            rpListParentProduct1.DataSource = ds.Tables[0];
            rpListParentProduct1.DataBind();
        }

        protected void rpListParentProduct_ItemDataBound(object sender, RepeaterItemEventArgs e)    // Hien cac danh muc con Menu
        {
            //---tuong ung voi mot san pham A duoc dua ra, hien thi danh sach san pham con cua A
            HiddenField hrId = (HiddenField)e.Item.FindControl("hrID"); //--- day la Id cua loai san pham A---
            Repeater rpChildrent = (Repeater)e.Item.FindControl("rpListChildProduct");
            if ((hrId != null) && (rpChildrent != null))
            {
                DataSet ds = ProductsBO.getDataSetGroupProducts_Childrent(Convert.ToInt64(hrId.Value));
                rpChildrent.DataSource = ds.Tables[0];
                rpChildrent.DataBind();
            }
        }

        protected void LoadNewProduct() // Hien danh sach san pham moi o Left Menu
        {
            try
            {
                DataTable tbNewProduct = ProductsBO.getDataSetNewProductTop(3).Tables[0];
                dtlNewProduct.DataSource = tbNewProduct;
                dtlNewProduct.DataBind();
            }
            catch { }
        }

        public void LoadLink()  // Hien noi dung cac lien ket Link
        {
            try
            {
                DataTable dt = WebsiteBO.getDataSetWebsitebyWebsite_ID(4).Tables[0];
                lblLink.Text = Convert.ToString(dt.Rows[0]["Website_Content"]);
            }
            catch (Exception)
            {}
        }

        protected void dtlNewProduct_ItemCommand(object source, DataListCommandEventArgs e) // Xu y su kien cho buttom xem chi tiet san pham o New Product - Left Menu
        {
            DataTable tb = new DataTable();
            string name = e.CommandName;
            if (name == "Detail")
            {
                string linkDetail = "~/Product/" + ((Label)e.Item.FindControl("lblProducts_ID")).Text + "/" + RewriteUrl.ConvertToUnSign(((Label)e.Item.FindControl("lblProducts_Name")).Text) + ".html";
                Response.Redirect(linkDetail);
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)  // Xu y su kien cho buttom Search
        {
            string search = "~/Product/Search.aspx?Products_Name=" + txtProducts_Name.Text;
            Response.Redirect(search);
        }

        protected void btnLogin_Click(object sender, EventArgs e)   // Xu y su kien cho buttom Login
        {
            try
            {
                string Accounts_Username = txtAccounts_Username.Text;
                string Accounts_Password = Encrypt.Crypt(txtAccounts_Password.Text);
                DataSet temp = AccountsBO.setLoginAccounts(Accounts_Username, Accounts_Password);
                if (temp.Tables[0].Rows.Count > 0)
                {
                    if (Convert.ToInt32(temp.Tables[0].Rows[0]["Accounts_Permission"]) > 0) // Kiem tra xem co phai Admin ko?
                    {
                        Response.Cookies["administrator"].Value = Accounts_Username;
                        if (chkRememberMe.Checked == true)
                        {
                            Response.Cookies["administrator"].Expires = DateTime.Now.AddDays(10);
                        }
                        else
                        {
                            Response.Cookies["administrator"].Expires = DateTime.Now.AddDays(1);
                        }
                    }
                    else // La Customer
                    {
                        Response.Cookies["client"].Value = Accounts_Username;
                        if (chkRememberMe.Checked == true)
                        {
                            Response.Cookies["client"].Expires = DateTime.Now.AddDays(10);
                        }
                        else
                        {
                            Response.Cookies["client"].Expires = DateTime.Now.AddDays(1);
                        }
                    }
                    Response.Redirect(Request.Url.AbsolutePath);
                }
                else
                {
                    lblMsg.Text = "Sai tài khoản / mật khẩu";
                    lblMsg.CssClass = "notificationError";
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        protected void lbtnLogout_Click(object sender, EventArgs e)     // Xu y su kien cho buttom Logout
        {
            if(Response.Cookies["administrator"] == null){
            Response.Cookies["administrator"].Expires = DateTime.Now.AddDays(-1);
            Response.Redirect(Request.Url.AbsolutePath);
            }
            else{
                Response.Cookies["client"].Expires = DateTime.Now.AddDays(-1);
                Response.Redirect(Request.Url.AbsolutePath);
            }
        }

        protected void btnContact_Click(object sender, EventArgs e)     // Xu y su kien cho buttom Contact (gui mail)
        {
            SmtpClient SmtpServer = new SmtpClient();
            SmtpServer.Credentials = new System.Net.NetworkCredential("it.site44.com@gmail.com", "ydtndlpacvzspqid");
            SmtpServer.Port = 587;
            SmtpServer.Host = "smtp.gmail.com";
            SmtpServer.EnableSsl = true;
            MailMessage mail = new MailMessage();
            String[] addr = "thang.991992@gmail.com".Split(',');
            try
            {
                mail.From = new MailAddress("it.site44.com@gmail.com", "Hỗ trợ từ Website ThangNM Join Stock Company", System.Text.Encoding.UTF8);
                Byte i;
                for (i = 0; i < addr.Length; i++)
                    mail.To.Add(addr[i]);
                mail.Subject = "From: "+ txtAccounts_Email.Text;
                mail.Body = txtSupports_Content.Text;
                mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                mail.ReplyTo = new MailAddress("thang.991992@gmail.com");
                SmtpServer.Send(mail);
            }
            catch (Exception ex)
            {
            }
        }

        protected void lbtnDesktop_Layout_Click(object sender, EventArgs e)
        {
            Session["Layout"] = "Desktop";
            Response.Redirect(Request.Url.AbsolutePath);
        }

        protected void lbtnMobile_Layout_Click(object sender, EventArgs e)
        {
            Session["Layout"] = "Mobile";
            Response.Redirect(Request.Url.AbsolutePath);
        }
    }
}