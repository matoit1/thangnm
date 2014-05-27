using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using DataAccessObject;
using Shared_Libraries;
using Newtonsoft.Json.Linq;
using Shared_Libraries.Constants;

namespace EHOU.Share_Interface
{
    public partial class SinhVien_SI : System.Web.UI.MasterPage
    {
        public void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Request.Cookies["LOGINID"] != null) //Chưa Đăng nhập
                {
                    if (Session["LOGINID"] == null || Session["LOGINID"].ToString().Substring(1).Equals(Request.Cookies["LOGINID"].Value) == false) //Chưa tạo session hoặc lỗi
                    {
                        JObject objAcc = Common.RequestInforByLoginID(Request.Cookies["LOGINID"].Value);
                        if (objAcc["username"] != null)
                        {
                            Session["LOGINID"] =  objAcc["type"].ToString() + Request.Cookies["LOGINID"].Value;
                            if (Convert.ToInt16(Session["LOGINID"].ToString().Substring(0, 1)) != tblAccount_iType_C.Sinh_Vien) //Kiểm tra quyền truy cập trang
                            {
                                Response.Write("<script>alert('ERROR: Bạn không có quyền truy cập.')</script>");
                            }
                            else
                            {
                                Response.Write("<script>alert('SUCCESS: Xác thực + tạo session thành công.')</script>");
                            }
                        }
                        else
                        {
                            Response.Write("<script>alert('ERROR: Tài khoản chưa xác thực.')</script>");
                        }
                    }
                    else
                    {
                        if (Convert.ToInt16(Session["LOGINID"].ToString().Substring(0, 1)) != tblAccount_iType_C.Sinh_Vien) //Kiểm tra quyền truy cập trang
                        {
                            Response.Write("<script>alert('ERROR: Bạn không có quyền truy cập.')</script>");
                        }
                        else
                        {
                            Response.Write("<script>alert('SUCCESS: Đã tạo xác thực.')</script>");
                        }
                    }
                }
                else
                {
                    Response.Write("<script>alert('ERROR: Chưa đăng nhập.')</script>");
                    Response.Redirect("https://account.dev.ehou.edu.vn/auth");
                }
            }
            catch (Exception ex)
            {
                Response.Redirect("https://account.dev.ehou.edu.vn/auth");
            }
        }

        protected void lbtnLogout_Click(object sender, EventArgs e)
        {
            Response.Cookies["sinhvien"].Expires = DateTime.Now.AddDays(-1);
            Response.Redirect(Request.Url.ToString());
        }
    }
}