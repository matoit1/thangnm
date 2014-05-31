using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CongKy.DataAccessObject;
using CongKy.EntityObject;
using System.Data;
using CongKy.SharedLibraries.Constants;

namespace CongKy.ShareInterface
{
    public partial class GiangVienSI : System.Web.UI.MasterPage
    {
        public void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Request.Cookies["CongKy_giangvien"] == null)
                {
                    Response.Redirect("~/GiangVien/Accounts/Login.aspx?Return_Url=" + Server.UrlEncode(Request.AppRelativeCurrentExecutionFilePath + "?" + Request.QueryString));
                }
                tblTaiKhoanEO _tblTaiKhoanEO = new tblTaiKhoanEO();
                _tblTaiKhoanEO.sTenDangNhap = Request.Cookies["CongKy_giangvien"].Value;
                _tblTaiKhoanEO = tblTaiKhoanDAO.TaiKhoan_SelectItemBysTenDangNhap(_tblTaiKhoanEO);
                lblName.Text =_tblTaiKhoanEO.sHoTen.ToString();
                DataSet ds = tblChiTietGiaoTrinhDAO.ChiTietGiaoTrinh_By_PK_iTaiKhoanID_PK_iMonHocID_PK_iGiaoTrinhID(_tblTaiKhoanEO.PK_iTaiKhoanID, 0, 0, ChiTietGiaoTrinh_iTrangThai_C.Mo, true);
                lblNewFeed.Text = ds.Tables[0].Rows.Count.ToString();
            }
            catch
            {
                Response.Cookies["CongKy_giangvien"].Expires = DateTime.Now.AddDays(-1);
                Response.Redirect("~/GiangVien/Accounts/Login.aspx?Return_Url=" + Server.UrlEncode(Request.AppRelativeCurrentExecutionFilePath + "?" + Request.QueryString));
            }
        }

        protected void lbtnLogout_Click(object sender, EventArgs e)
        {
            Response.Cookies["CongKy_giangvien"].Expires = DateTime.Now.AddDays(-1);
            Response.Redirect(Request.Url.ToString());
        }
    }
}