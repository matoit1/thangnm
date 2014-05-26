using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EHOU.DataAccessObject;
using System.Text.RegularExpressions;
using System.Data;
using EntityObject;
using Shared_Libraries;
using DataAccessObject;

namespace EHOU.UserControl
{
    public partial class tblMessage_DetailUC : System.Web.UI.UserControl
    {
        #region "Properties & Event"
        public Int16 iType
        {
            get { return (Int16)ViewState["iType"]; }
            set { ViewState["iType"] = value; }
        }
        public string sWarning
        {
            get { return (string)ViewState["sWarning"]; }
            set { ViewState["sWarning"] = value; }
        }
        public int iState 
        {
            get { return (int)ViewState["iState"]; }
            set { ViewState["iState"] = value; }
        }
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ClearMessages();
                loadDataToDropDownList();
            }
        }

        public void BindDataDetail(tblMessageEO _tblMessageEO)
        {
            txtPK_lMessage.Text = Convert.ToString(_tblMessageEO.PK_lMessage);
            try { ddlFK_sRoom.SelectedValue = Convert.ToString(_tblMessageEO.FK_sRoom); }
            catch { ddlFK_sRoom.SelectedIndex = 0; }
            try { ddlFK_sUsername.SelectedValue = Convert.ToString(_tblMessageEO.FK_sUsername); }
            catch { ddlFK_sUsername.SelectedIndex = 0; }
            txtsContent.Text = Convert.ToString(_tblMessageEO.sContent);
            if (_tblMessageEO.tDateSent == DateTime.MinValue) { txttDateSent.Text = DateTime.Now.ToString(); } else { txttDateSent.Text = Convert.ToString(_tblMessageEO.tDateSent); }
            try { ddliStatus.SelectedValue = Convert.ToString(_tblMessageEO.iStatus); }
            catch { ddliStatus.SelectedIndex = 0; }
        }

        private tblMessageEO getObject()
        {
            tblMessageEO _tblMessageEO = new tblMessageEO();
            try
            {
                _tblMessageEO.PK_lMessage = Convert.ToInt64(txtPK_lMessage.Text);
                try { _tblMessageEO.FK_sRoom = Convert.ToString(ddlFK_sRoom.SelectedValue); }
                catch { lblFK_sRoom.Text = Messages.Khong_Dung_Dinh_Dang_So; _tblMessageEO.FK_sRoom = ""; }
                try { _tblMessageEO.FK_sUsername = Convert.ToString(ddlFK_sUsername.SelectedValue); }
                catch { lblFK_sUsername.Text = Messages.Khong_Dung_Dinh_Dang_So; _tblMessageEO.FK_sUsername = ""; }
                _tblMessageEO.sContent = Convert.ToString(txtsContent.Text);
                _tblMessageEO.tDateSent = Convert.ToDateTime(txttDateSent.Text);
                try { _tblMessageEO.iStatus = Convert.ToInt16(ddliStatus.SelectedValue); }
                catch { lbliStatus.Text = Messages.Khong_Dung_Dinh_Dang_So; _tblMessageEO.iStatus = 0; }
                return _tblMessageEO;
            }
            catch (Exception ex)
            {
                lblMsg.Text = Messages.Loi + ex.Message;
                return _tblMessageEO;
            }
        }

        public void loadDataToDropDownList()
        {
            try
            {
                tblSubjectEO _tblSubjectEO = new tblSubjectEO();
                ddlFK_sRoom.DataSource = tblSubjectDAO.Subject_SelectList();
                ddlFK_sRoom.DataTextField = "sName";
                ddlFK_sRoom.DataValueField = "PK_sSubject";
                ddlFK_sRoom.DataBind();

                ddlFK_sUsername.DataSource = tblAccountDAO.Account_SelectList();
                ddlFK_sUsername.DataTextField = "sName";
                ddlFK_sUsername.DataValueField = "PK_sUsername";
                ddlFK_sUsername.DataBind();

                ddliStatus.DataSource = GetListConstants.CauHoi_iTrangThai_GLC();
                ddliStatus.DataTextField = "Value";
                ddliStatus.DataValueField = "Key";
                ddliStatus.DataBind();
            }
            catch(Exception ex)
            {
                lblMsg.Text = Messages.Loi + ex.Message;
            }
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

        public void ClearMessages()
        {
            //lblMsg.Text = "";
            lblPK_lMessage.Text = "";
            lblFK_sRoom.Text = "";
            lblFK_sUsername.Text = "";
            lblsContent.Text = "";
            lbltDateSent.Text = "";
            lbliStatus.Text = "";
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
                    if (tblMessageDAO.Message_Insert(getObject()) == true)
                    {
                        lblMsg.Text = Messages.Them_Thanh_Cong;
                        ClearMessages();
                        tblMessageEO _tblMessageEO = new tblMessageEO();
                        BindDataDetail(_tblMessageEO);
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
            string warning = "";
            try
            {
                if (tblMessageDAO.Message_Update(getObject()) == true)
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
                if (tblMessageDAO.Message_Delete(getObject()) == true)
                {
                    lblMsg.Text = Messages.Xoa_Thanh_Cong;
                    ClearMessages();
                    tblMessageEO _tblMessageEO = new tblMessageEO();
                    BindDataDetail(_tblMessageEO);
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
            tblMessageEO _tblMessageEO = new tblMessageEO();
            BindDataDetail(_tblMessageEO);
        }
        #endregion
    }
}