﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CongKy.DataAccessObject;
using CongKy.EntityObject;

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
                lblName.Text =tblTaiKhoanDAO.TaiKhoan_SelectItemBysTenDangNhap(_tblTaiKhoanEO).sHoTen.ToString();
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