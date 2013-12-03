using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Web.Configuration;
using System.Web.Caching;
using AiLaTrieuPhu.Library;

namespace AiLaTrieuPhu.Accounts
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            { }
        }
        protected void lbtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet temp = TaikhoanDAO.DangNhap(txttaikhoan_tentaikhoan.Text, txttaikhoan_matkhau.Text);
                if (temp.Tables[0].Rows.Count > 0)
                {
                    Response.Cookies["acc"].Expires = DateTime.Now.AddDays(10);
                    Response.Redirect("~/Demo.aspx");
                }
                else
                {
                    lblMsg.Text = "Sai tên tài khoản hoặc mật khẩu.";
                }
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}