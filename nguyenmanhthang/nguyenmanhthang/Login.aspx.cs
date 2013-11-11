using nguyenmanhthang.Library.Permit_Access;
using System;
using System.Linq;

namespace nguyenmanhthang
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            //Kiểm tra người dùng hợp lệ
            if (string.IsNullOrEmpty(txtPassword.Text.Trim()) || string.IsNullOrEmpty(txtUsername.Text.Trim()))
            {
                lblMsgError.Text = "Vui lòng kiểm tra tên đăng nhập và mật khẩu.";
                return;
            }
            //Xuống csdl lấy người dùng có tên đăng nhập và mật khẩu.
            IQueryable<SalesUser> sales = from u in new MyLoginDataDataContext().SalesUsers
                                          where u.Username == txtUsername.Text.Trim() && u.Password == txtPassword.Text
                                          select u;
            SalesUser user = sales.FirstOrDefault();
            if (user != null)
            {
                Session.SetCurrentUser(user);
                string returnUrl = Request.QueryString["returnUrl"];                                
                if (!string.IsNullOrEmpty(returnUrl))
                    Response.Redirect(returnUrl);
                else
                    Response.Redirect("Myfile.aspx");
            }
            else
            {
                lblMsgError.Text = "Thông tin đăng nhập không hợp lệ";
            }

        }
    }
}