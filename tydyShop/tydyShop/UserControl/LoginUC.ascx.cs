using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using DataAccessObject;
using EntityObject;
using SharedLibraries;

namespace tydyShop.UserControl
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
                AccountsEO _AccountsEO = new AccountsEO();

                switch (iType)
                {
                    case 1: _AccountsEO.Accounts_Username = txtsTendangnhap.Text;   //Khách hàng
                        _AccountsEO.Accounts_Password = Security.EnCrypt(txtsMatkhau.Text);
                        _AccountsEO.Accounts_Permission = 1;
                        dsOutput = AccountsDAO.LoginAccountsAdmin(_AccountsEO); break;
                    case 2: _AccountsEO.Accounts_Username = txtsTendangnhap.Text; //Nhân viên
                        _AccountsEO.Accounts_Password = Security.EnCrypt(txtsMatkhau.Text);
                        _AccountsEO.Accounts_Permission = 2;
                        dsOutput = AccountsDAO.LoginAccountsAdmin(_AccountsEO); break;
                    case 3: _AccountsEO.Accounts_Username = txtsTendangnhap.Text; //Quản trị
                        _AccountsEO.Accounts_Password = Security.EnCrypt(txtsMatkhau.Text);
                        _AccountsEO.Accounts_Permission = 3;
                        dsOutput = AccountsDAO.LoginAccountsAdmin(_AccountsEO); break;
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