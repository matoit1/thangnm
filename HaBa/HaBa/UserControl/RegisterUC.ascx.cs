using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HaBa.SharedLibraries;
using HaBa.DataAccessObject;
using HaBa.EntityObject;
using HaBa.SharedLibraries.Constants;
using System.Threading;
using System.Text.RegularExpressions;

namespace HaBa.UserControl
{
    public partial class RegisterUC : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                imgCaptcha.ImageUrl = new CaptchaProvider().CreateCaptcha();
            }
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            ClearMessages();
            if (CheckInput() == true)
            {
                tblTaiKhoanEO _tblTaiKhoanEO = new tblTaiKhoanEO();
                _tblTaiKhoanEO.sTenDangNhap = txtsTenDangNhap.Text;
                _tblTaiKhoanEO.sMatKhau = Security.EnCrypt(txtsMatKhau.Text.Trim());
                _tblTaiKhoanEO.sHoTen = txtsHoTen.Text;
                _tblTaiKhoanEO.sEmail = txtsEmail.Text;
                _tblTaiKhoanEO.sDiaChi = "";
                _tblTaiKhoanEO.sSoDienThoai = "";
                _tblTaiKhoanEO.sLinkAvatar = "";
                _tblTaiKhoanEO.iQuyenHan = TaiKhoan_iQuyenHan_C.Khach_Hang;
                _tblTaiKhoanEO.iTrangThai = TaiKhoan_iTrangThai_C.Mo;
                if (tblTaiKhoanDAO.TaiKhoan_Insert(_tblTaiKhoanEO) == true)
                {
                    lblMsg.Text = Messages.Dang_Ky_Thanh_Cong;
                    Response.AddHeader("REFRESH", "3;URL=/Client/Accounts/Login.aspx");
                }
                else
                {
                    lblMsg.Text = Messages.Dang_Ky_That_Bai;
                }
            }
        }

        public bool CheckInput()
        {
            tblTaiKhoanEO _tblTaiKhoanEO = new tblTaiKhoanEO();
            if (string.IsNullOrEmpty(txtsTenDangNhap.Text) == true)
            {
                lblsTenDangNhap.Text = Messages.Truong_Bat_Buoc;
                txtsTenDangNhap.Focus();
                return false;
            }
            else
            {
                _tblTaiKhoanEO.sTenDangNhap = txtsTenDangNhap.Text;
                if (tblTaiKhoanDAO.TaiKhoan_CheckExists_sTenDangNhap(_tblTaiKhoanEO) == true)
                {
                    lblsTenDangNhap.Text = Messages.Ten_Tai_Khoan_Da_Duoc_Su_Dung;
                    txtsTenDangNhap.Focus();
                    return false;
                }
            }
            if (string.IsNullOrEmpty(txtsMatKhau.Text) == true)
            {
                lblsMatKhau.Text = Messages.Truong_Bat_Buoc;
                txtsMatKhau.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtsMatKhau1.Text) == true)
            {
                lblsMatKhau1.Text = Messages.Truong_Bat_Buoc;
                lblsMatKhau1.Focus();
                return false;
            }
            else {
                if (txtsMatKhau.Text.Trim().Contains(txtsMatKhau1.Text.Trim()) == false)
                {
                    lblsMatKhau1.Text = Messages.Mat_Khau_Khong_Trung_Khop;
                    lblsMatKhau1.Focus();
                    return false;
                }
            }
            if (string.IsNullOrEmpty(txtsHoTen.Text) == true)
            {
                lblsHoTen.Text = Messages.Truong_Bat_Buoc;
                txtsHoTen.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtsEmail.Text) == true)
            {
                lblsEmail.Text = Messages.Truong_Bat_Buoc;
                txtsEmail.Focus();
                return false;
            }
            else
            {
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regex.Match(txtsEmail.Text);
                if (match.Success == false)
                {
                    lblsEmail.Text = Messages.Khong_Dung_Dinh_Dang_Email;
                    txtsEmail.Focus();
                    return false;
                }
                else
                {
                    _tblTaiKhoanEO.sEmail = txtsEmail.Text;
                    if (tblTaiKhoanDAO.TaiKhoan_CheckExists_sEmail(_tblTaiKhoanEO) == true)
                    {
                        lblsEmail.Text = Messages.Email_Da_Duoc_Su_Dung;
                        txtsEmail.Focus();
                        return false;
                    }
                }
            }
            if (string.IsNullOrEmpty(txtsCaptcha.Text) == true)
            {
                lblsCaptcha.Text = Messages.Truong_Bat_Buoc;
                txtsCaptcha.Focus();
                return false;
            }
            else
            {
                CaptchaProvider captchaPro = new CaptchaProvider();
                if (captchaPro.IsValidCode(txtsCaptcha.Text) == false)
                {
                    lblsCaptcha.Text = Messages.Sai_Captcha;
                    imgCaptcha.ImageUrl = new CaptchaProvider().CreateCaptcha();
                    txtsCaptcha.Text = "";
                    txtsCaptcha.Focus();
                    return false;
                }
            }
            return true;
        }

        public void ClearMessages()
        {
            lblMsg.Text = "";
            lblsTenDangNhap.Text = "";
            lblsMatKhau.Text = "";
            lblsMatKhau1.Text = "";
            lblsHoTen.Text = "";
            lblsEmail.Text = "";
            lblsCaptcha.Text = "";
        }

        protected void ChangeCaptcha_Click(object sender, ImageClickEventArgs e)
        {
            imgCaptcha.ImageUrl = new CaptchaProvider().CreateCaptcha();
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtsTenDangNhap.Text = "";
            txtsMatKhau.Text = "";
            txtsMatKhau1.Text = "";
            txtsHoTen.Text = "";
            txtsEmail.Text = "";
            txtsCaptcha.Text = "";
        }
    }
}