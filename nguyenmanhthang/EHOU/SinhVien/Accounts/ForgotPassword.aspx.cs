using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityObject;
using DataAccessObject;
using Shared_Libraries;

namespace EHOU.SinhVien.Accounts
{
    public partial class ForgotPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ForgotPasswordUC1.login_url = Request.Url.Host+"/SinhVien/Accounts/Login.aspx";
        }

        protected void ResetPassword_Click(object sender, EventArgs e)
        {
            SinhVienEO _SinhVienEO = new SinhVienEO();
            _SinhVienEO.sTendangnhapSV = ForgotPasswordUC1.txtsTendangnhap.Text;
            _SinhVienEO = SinhVienDAO.SinhVien_SelectBysTendangnhapSV(_SinhVienEO);
            if (_SinhVienEO.PK_sMaSV != null)
            {
                if (ForgotPasswordUC1.txtsTendangnhap.Text == _SinhVienEO.sTendangnhapSV)
                {
                    if (ForgotPasswordUC1.txtsEmail1.Text == _SinhVienEO.sEmailSV)
                    {
                        ForgotPasswordUC1.Reset_Password(ForgotPasswordUC1.txtsTendangnhap.Text, ForgotPasswordUC1.txtsEmail1.Text, 1);
                        ForgotPasswordUC1.lblMsg1.Text = Messages.Doi_Mat_Khau_Thanh_Cong;
                        ForgotPasswordUC1.lblMsg1.CssClass = "notificationSuccessful";
                    }
                    else
                    {
                        ForgotPasswordUC1.lblMsg1.Text = Messages.Sai_Email;
                        ForgotPasswordUC1.lblMsg1.CssClass = "notificationError";
                    }
                }
                else
                {
                    ForgotPasswordUC1.lblMsg1.Text = Messages.Sai_Ten_Tai_Khoan;
                    ForgotPasswordUC1.lblMsg1.CssClass = "notificationError";
                }
            }
            else
            {
                ForgotPasswordUC1.lblMsg1.Text = Messages.Sai_Ten_Tai_Khoan_Hoac_Email;
                ForgotPasswordUC1.lblMsg1.CssClass = "notificationError";
            }
        }

        protected void FindAccount_Click(object sender, EventArgs e)
        {
            SinhVienEO _SinhVienEO = new SinhVienEO();
            _SinhVienEO.sEmailSV = ForgotPasswordUC1.txtsEmail2.Text;
            _SinhVienEO.sSdtSV = ForgotPasswordUC1.txtsSdt.Text;
            _SinhVienEO = SinhVienDAO.SinhVien_SelectBysEmailSVvssSdtSV(_SinhVienEO);
            if (_SinhVienEO.PK_sMaSV != null)
            {
                ForgotPasswordUC1.Reset_Password(_SinhVienEO.sTendangnhapSV, ForgotPasswordUC1.txtsEmail2.Text, 1);
                ForgotPasswordUC1.lblMsg2.Text = Messages.Gui_Mail_Doi_Mat_Khau_Thanh_Cong;
                ForgotPasswordUC1.lblMsg2.CssClass = "notificationSuccessful";
            }
            else
            {
                ForgotPasswordUC1.lblMsg2.Text = Messages.Sai_Email_Hoac_So_Dien_Thoai;
                ForgotPasswordUC1.lblMsg2.CssClass = "notificationError";
            }
        }
    }
}