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
            txtsTendangnhap.Focus();
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
                AccountEO _AccountsEO = new AccountEO();

                switch (iType)
                {
                    case 1: _AccountsEO.sUsername = txtsTendangnhap.Text;   //Khách hàng
                        _AccountsEO.sPassword = Security.EnCrypt(txtsMatkhau.Text);
                        _AccountsEO.iPermission = 1;
                        dsOutput = AccountDAO.Account_Login(_AccountsEO); break;
                    case 2: _AccountsEO.sUsername = txtsTendangnhap.Text; //Nhân viên
                        _AccountsEO.sPassword = Security.EnCrypt(txtsMatkhau.Text);
                        _AccountsEO.iPermission = 2;
                        dsOutput = AccountDAO.Account_Login(_AccountsEO); break;
                    case 3: _AccountsEO.sUsername = txtsTendangnhap.Text; //Quản trị
                        _AccountsEO.sPassword = Security.EnCrypt(txtsMatkhau.Text);
                        _AccountsEO.iPermission = 3;
                        dsOutput = AccountDAO.Account_Login(_AccountsEO); break;
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