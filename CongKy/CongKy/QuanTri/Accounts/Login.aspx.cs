using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CongKy.SharedLibraries;
using System.Data;
using CongKy.SharedLibraries.Constants;

namespace CongKy.QuanTri.Accounts
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoginUC1.hplLost.NavigateUrl = "~/QuanTri/Accounts/ForgotPassword.aspx";
            LoginUC1.hplRegister.Visible = false;
        }

        protected void Login_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet dsInput = null;
                dsInput = LoginUC1.Check(TaiKhoan_iQuyenHan_C.QuanTri);
                if (dsInput.Tables[0].Rows.Count > 0)   // 0. Đăng nhập thành công
                {
                    Response.Cookies["CongKy_quantri"].Value = LoginUC1.txtsTenDangNhap.Text;
                    if (LoginUC1.chkRememberMe.Checked == true)
                    {
                        Response.Cookies["CongKy_quantri"].Expires = DateTime.Now.AddDays(10);
                    }
                    else
                    {
                        Response.Cookies["CongKy_quantri"].Expires = DateTime.Now.AddDays(1);
                    }
                    if (Request.QueryString["Return_Url"] == null)
                    {
                        Response.Redirect("~/QuanTri/Default.aspx");
                    }
                    else
                    {
                        Response.Redirect(Request.QueryString["Return_Url"].ToString());
                    }
                }
                else // 1. Đăng nhập thất bại
                {
                    if (dsInput.Tables[2].Rows.Count <= 0)  // 3. Không có quyền vào
                    {
                        LoginUC1.lblMsg.Text = Messages.Khong_Co_Quyen_Truy_Cap;
                    }
                    else
                    {
                        if (dsInput.Tables[3].Rows.Count <= 0)  // 4. Bị khóa tài khoản
                        {
                            LoginUC1.lblMsg.Text = Messages.Tai_Khoan_Da_Bi_Khoa;
                        }
                        else
                        {
                            if (dsInput.Tables[1].Rows.Count > 0)   // 2. Sai mật khẩu
                            {
                                LoginUC1.lblMsg.Text = Messages.Sai_Mat_Khau;
                            }
                            else
                            {  // 5.Lỗi khác!
                                LoginUC1.lblMsg.Text = Messages.Dang_Nhap_That_Bai;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LoginUC1.lblMsg.Text = ex.Message;
            }
        }
    }
}