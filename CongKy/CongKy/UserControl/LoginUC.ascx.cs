using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using CongKy.DataAccessObject;
using CongKy.EntityObject;
using CongKy.SharedLibraries;
using CongKy.SharedLibraries.Constants;

namespace CongKy.UserControl
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
                _AccountsEO.sTenDangNhap = txtsTenDangNhap.Text;
                _AccountsEO.sMatKhau = Security.EnCrypt(txtsMatKhau.Text.Trim());
                _AccountsEO.iQuyenHan = iType;
                _AccountsEO.iTrangThai = TaiKhoan_iTrangThai_C.Mo;
                dsOutput = tblTaiKhoanDAO.TaiKhoan_Login(_AccountsEO);
            }
            catch (Exception ex)
            {
                lblMsg.Text = ex.Message;
            }
            return dsOutput;
        }
    }
}