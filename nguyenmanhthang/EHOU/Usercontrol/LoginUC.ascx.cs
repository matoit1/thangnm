using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using DataAccessObject;
using EntityObject;
using Shared_Libraries;
using Shared_Libraries.Constants;

namespace EHOU.UserControl
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

            //try
            //{
            //    string Accounts_Username = txtAccounts_Username.Text;
            //    string Accounts_Password = Encrypt.Crypt(txtAccounts_Password.Text);
            //    DataSet temp = AccountsBO.Login(Accounts_Username, Accounts_Password);
            //    if (temp.Tables[0].Rows.Count > 0)
            //    {
            //        state = true;
            //        Response.Cookies["administrator"].Value = Accounts_Username;
            //        if (chkRememberMe.Checked == true)
            //        {
            //            Response.Cookies["administrator"].Expires = DateTime.Now.AddDays(10);
            //        }
            //        else
            //        {
            //            Response.Cookies["administrator"].Expires = DateTime.Now.AddDays(1);
            //        }
            //        string url1 = (String)Session["url1"];
            //        if (Session["url1"] == null)
            //        {
            //            string l = "~/Admin/Default.aspx";
            //            Response.Redirect(l);
            //        }
            //        else
            //        {
            //            Response.Redirect(url1);
            //        }
            //    }
            //    else
            //    {
            //        lblMsg.Text = "Sai tài khoản / mật khẩu";
            //        lblMsg.CssClass = "notificationError";
            //        if (Navigation != null)
            //        {
            //            Navigation(this, EventArgs.Empty);
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    lblMsg.Text = ex.ToString();
            //    if (Navigation != null)
            //    {
            //        Navigation(this, EventArgs.Empty);
            //    }
            //}
        }

        public DataSet Check(Int16 iType)
        {
            DataSet dsOutput = null;
            try
            {
                SinhVienEO _SinhVienEO = new SinhVienEO();
                GiangVienEO _GiangVienEO = new GiangVienEO();

                switch (iType)
                {
                    case 1: _SinhVienEO.sTendangnhapSV = txtsTendangnhap.Text;
                        _SinhVienEO.sMatkhauSV = Security.EnCrypt(txtsMatkhau.Text);
                        _SinhVienEO.iTrangThaiSV = 1;
                        dsOutput = SinhVienDAO.SinhVien_Login(_SinhVienEO); break;
                    case 2: _GiangVienEO.sTendangnhapGV = txtsTendangnhap.Text;
                        _GiangVienEO.sMatkhauGV =  Security.EnCrypt(txtsMatkhau.Text);
                        _GiangVienEO.iTrangThaiGV = 1;
                        dsOutput = GiangVienDAO.GiangVien_Login(_GiangVienEO); break;
                    case 3: _GiangVienEO.sTendangnhapGV = txtsTendangnhap.Text;
                        _GiangVienEO.sMatkhauGV =  Security.EnCrypt(txtsMatkhau.Text);
                        _GiangVienEO.iChucVuGV = GiangVien_iChucVuGV_C.Vien_Truong;
                        _GiangVienEO.iTrangThaiGV = 1;
                        dsOutput = GiangVienDAO.GiangVien_Login(_GiangVienEO); break;
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