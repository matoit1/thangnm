using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using DataAccessObject;

namespace DO_AN_TN.Share_Interface
{
    public partial class SinhVien_SI : System.Web.UI.MasterPage
    {
        public void Page_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    if (Request.Cookies["sinhvien"] == null)
            //    {
            //        Session["url1"] = Request.Url.AbsolutePath;
            //        Response.Redirect("~/Accounts/Login.aspx");
            //    }
            //    DataSet ds = SinhVienDAO.SinhVien_SelectItem(Request.Cookies["sinhvien"].Value);
            //    //imgAvatar.ImageUrl = ds.Tables[0].Rows[0]["Accounts_LinkAvatar"].ToString();
            //    hplAccounts_Fullname.Text = "   Hi, " + ds.Tables[0].Rows[0]["sHotenSV"].ToString();// xuất lời chào.
            //    hplAccounts_Fullname.NavigateUrl = "~/User.aspx?Accounts_Username=" + Request.Cookies["sinhvien"].Value;
            //}
            //catch
            //{
            //    Response.Cookies["sinhvien"].Expires = DateTime.Now.AddDays(-1);
            //    Response.Redirect("~/Accounts/Login.aspx");
            //}
        }

        protected void lbtnLogout_Click(object sender, EventArgs e)
        {
            Response.Cookies["sinhvien"].Expires = DateTime.Now.AddDays(-1);
            Response.Redirect(Request.Url.AbsolutePath);
        }
    }
}