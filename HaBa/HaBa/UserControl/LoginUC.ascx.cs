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
using HaBa.SharedLibraries.Constants;

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
                _AccountsEO.sTenDangNhap = txtsTenDangNhap.Text;
                _AccountsEO.sMatKhau = Security.EnCrypt(txtsMatKhau.Text);
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