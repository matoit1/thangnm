using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Shared_Libraries;
using Newtonsoft.Json.Linq;
using EntityObject;
using DataAccessObject;

namespace EHOU.Usercontrol
{
    public partial class tblAccount_DetailUC : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ClearMessages();
                loadDataToDropDownList();
            }
        }

        public void BindDataDetail(tblAccountEO _tblAccountEO)
        {
            txtPK_sUsername.Text = _tblAccountEO.PK_sUsername;
            txtsPassword.Text = _tblAccountEO.sPassword;
            txtsName.Text = _tblAccountEO.sName;
            txtsEmail.Text = _tblAccountEO.sEmail;
            try { ddliType.SelectedValue = Convert.ToString(_tblAccountEO.iType); }
            catch { ddliType.SelectedIndex = 0; }
            try { ddliStatus.SelectedValue = Convert.ToString(_tblAccountEO.iStatus); }
            catch { ddliStatus.SelectedIndex = 0; }
        }

        private tblAccountEO getObject()
        {
            tblAccountEO _tblAccountEO = new tblAccountEO();
            try
            {
                _tblAccountEO.PK_sUsername = Convert.ToString(txtPK_sUsername.Text);
                _tblAccountEO.sPassword = Convert.ToString(txtsPassword.Text);
                _tblAccountEO.sName = Convert.ToString(txtsName.Text);
                _tblAccountEO.sEmail = Convert.ToString(txtsEmail.Text);
                try { _tblAccountEO.iType = Convert.ToInt16(ddliType.SelectedValue); }
                catch { lbliType.Text = Messages.Khong_Dung_Dinh_Dang_So; _tblAccountEO.iType = 0; }
                try { _tblAccountEO.iStatus = Convert.ToInt16(ddliStatus.SelectedValue); }
                catch { lbliStatus.Text = Messages.Khong_Dung_Dinh_Dang_So; _tblAccountEO.iStatus = 0; }
                return _tblAccountEO;
            }
            catch (Exception ex)
            {
                lblMsg.Text = Messages.Loi + ex.Message;
                return _tblAccountEO;
            }
        }

        public void loadDataToDropDownList()
        {
            ddliType.DataSource = GetListConstants.tblAccount_iType_GLC();
            ddliType.DataTextField = "Value";
            ddliType.DataValueField = "Key";
            ddliType.DataBind();

            ddliStatus.DataSource = GetListConstants.tblAccount_iStatus_GLC();
            ddliStatus.DataTextField = "Value";
            ddliStatus.DataValueField = "Key";
            ddliStatus.DataBind();
        }

        public void ClearMessages()
        {
            //lblMsg.Text = "";
            lblPK_sUsername.Text = "";
            lblsPassword.Text = "";
            lblsName.Text = "";
            lblsEmail.Text = "";
            lbliType.Text = "";
            lbliStatus.Text = "";
        }

        public bool CheckInput()
        {
            //if (string.IsNullOrEmpty(txtsHoTen.Text) == true)
            //{
            //    lblsHoTen.Text = Messages.Khong_Duoc_De_Trong;
            //    txtsHoTen.Focus();
            //    return false;
            //}
            //if (string.IsNullOrEmpty(txtsEmail.Text) == true)
            //{
            //    lblsEmail.Text = Messages.Khong_Duoc_De_Trong;
            //    txtsEmail.Focus();
            //    return false;
            //}
            //else
            //{
            //    Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            //    Match match = regex.Match(txtsEmail.Text);
            //    if (match.Success == false)
            //    {
            //        lblsEmail.Text = Messages.Khong_Dung_Dinh_Dang_Email;
            //        txtsEmail.Focus();
            //        return false;
            //    }
            //}
            //if (string.IsNullOrEmpty(txtsDiaChi.Text) == true)
            //{
            //    lblsDiaChi.Text = Messages.Khong_Duoc_De_Trong;
            //    txtsDiaChi.Focus();
            //    return false;
            //}
            //if (string.IsNullOrEmpty(txtsSoDienThoai.Text) == true)
            //{
            //    lblsSoDienThoai.Text = Messages.Khong_Duoc_De_Trong;
            //    txtsSoDienThoai.Focus();
            //    return false;
            //}
            //else
            //{
            //    string sdt;
            //    sdt = txtsSoDienThoai.Text.Trim().Replace(" ", "");
            //    try { Convert.ToInt64(sdt); }
            //    catch
            //    {
            //        lblsSoDienThoai.Text = Messages.Khong_Dung_Dinh_Dang_So_Dien_Thoai;
            //        txtsSoDienThoai.Focus();
            //        return false;
            //    }
            //    if (sdt.Length < 10)
            //    {
            //        lblsSoDienThoai.Text = Messages.Khong_Dung_Dinh_Dang_So_Dien_Thoai_Do_Dai;
            //        txtsSoDienThoai.Focus();
            //        return false;
            //    }
            //}
            return true;
        }

        #region "Event Button"
        protected void btnInsert_Click(object sender, EventArgs e)
        {
            ClearMessages();
            lblMsg.Text = "";
            try
            {
                if (CheckInput() == true)
                {
                    if (tblAccountDAO.Account_Insert(getObject()) == true)
                    {
                        lblMsg.Text = Messages.Them_Thanh_Cong;
                        ClearMessages();
                        tblAccountEO _tblAccountEO = new tblAccountEO();
                        BindDataDetail(_tblAccountEO);
                    }
                    else
                    {
                        lblMsg.Text = Messages.Them_That_Bai;
                    }
                }
            }
            catch (Exception ex)
            {
                lblMsg.Text = Messages.Loi + ex.Message;
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            ClearMessages();
            lblMsg.Text = "";
            try
            {
                if (tblAccountDAO.Account_Update(getObject()) == true)
                {
                    lblMsg.Text = Messages.Sua_Thanh_Cong;
                    ClearMessages();
                }
                else
                {
                    lblMsg.Text = Messages.Sua_That_Bai;
                }
            }
            catch (Exception ex)
            {
                lblMsg.Text = Messages.Loi + ex.Message;
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            ClearMessages();
            lblMsg.Text = "";
            try
            {
                if (tblAccountDAO.Account_Delete(getObject()) == true)
                {
                    lblMsg.Text = Messages.Xoa_Thanh_Cong;
                    ClearMessages();
                    tblAccountEO _tblAccountEO = new tblAccountEO();
                    BindDataDetail(_tblAccountEO);
                }
                else
                {
                    lblMsg.Text = Messages.Xoa_That_Bai;
                }
            }
            catch (Exception ex)
            {
                lblMsg.Text = Messages.Loi + ex.Message;
            }
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            ClearMessages();
            lblMsg.Text = "";
            tblAccountEO _tblAccountEO = new tblAccountEO();
            BindDataDetail(_tblAccountEO);
        }
        #endregion
    }
}