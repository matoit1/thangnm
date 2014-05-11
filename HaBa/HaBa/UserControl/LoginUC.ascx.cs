using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using HaBa.DataAccessObject;
using HaBa.EntityObject;
using HaBa.SharedLibraries;

namespace HaBa.UserControl
{
    public partial class LoginUC : System.Web.UI.UserControl
    {
        public event EventHandler Navigation;
        public event EventHandler Login;
        public bool state = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            txtsTenDangNhap.Focus();
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (Login != null)
            {
                Login(this, EventArgs.Empty);
            }
        }

        public DataSet Check(Int16 iType)
        {
            DataSet dsOutput = null;
            try
            {
                tblTaiKhoanEO _AccountsEO = new tblTaiKhoanEO();

                switch (iType)
                {
                    case 1: _AccountsEO.sTenDangNhap = txtsTenDangNhap.Text;   //Khách hàng
                        _AccountsEO.sMatKhau = Security.EnCrypt(txtsMatKhau.Text);
                        _AccountsEO.iQuyenHan = 1;
                        dsOutput = tblTaiKhoanDAO.Account_Login(_AccountsEO); break;
                    case 2: _AccountsEO.sTenDangNhap = txtsTenDangNhap.Text; //Nhân viên
                        _AccountsEO.sMatKhau = Security.EnCrypt(txtsMatKhau.Text);
                        _AccountsEO.iQuyenHan = 2;
                        dsOutput = tblTaiKhoanDAO.Account_Login(_AccountsEO); break;
                    case 3: _AccountsEO.sTenDangNhap = txtsTenDangNhap.Text; //Quản trị
                        _AccountsEO.sMatKhau = Security.EnCrypt(txtsMatKhau.Text);
                        _AccountsEO.iQuyenHan = 3;
                        dsOutput = tblTaiKhoanDAO.Account_Login(_AccountsEO); break;
                }
            }
            catch (Exception ex)
            {
                lblMsg.Text = ex.Message;
            }
            return dsOutput;
        }
    }
}