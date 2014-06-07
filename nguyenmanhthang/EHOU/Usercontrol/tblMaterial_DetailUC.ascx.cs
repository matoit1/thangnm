using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessObject;
using Shared_Libraries;
using EntityObject;

namespace EHOU.Usercontrol
{
    public partial class tblMaterial_DetailUC : System.Web.UI.UserControl
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

        public void BindDataDetail(tblMaterialEO _tblMaterialEO)
        {
            txtPK_lMaterial.Text = Convert.ToString(_tblMaterialEO.PK_lMaterial);
            try { ddlFK_sSubject.SelectedValue = Convert.ToString(_tblMaterialEO.FK_sSubject); }
            catch { ddlFK_sSubject.SelectedIndex = 0; }
            try { ddlFK_sUsername.SelectedValue = Convert.ToString(_tblMaterialEO.FK_sUsername); }
            catch { ddlFK_sUsername.SelectedIndex = 0; }
            txtsDescription.Text = Convert.ToString(_tblMaterialEO.sDescription);
            txtsLinkDownload.Text = Convert.ToString(_tblMaterialEO.sLinkDownload);
            if (_tblMaterialEO.tLastUpdate == DateTime.MinValue) { txttLastUpdate.Text = DateTime.Now.ToString(); } else { txttLastUpdate.Text = Convert.ToString(_tblMaterialEO.tLastUpdate); }
            txtiSize.Text = Convert.ToString(_tblMaterialEO.iSize);
            txtiType.Text = Convert.ToString(_tblMaterialEO.iType);
            try { ddliStatus.SelectedValue = Convert.ToString(_tblMaterialEO.iStatus); }
            catch { ddliStatus.SelectedIndex = 0; }
        }

        private tblMaterialEO getObject()
        {
            tblMaterialEO _tblMaterialEO = new tblMaterialEO();
            try
            {
                _tblMaterialEO.PK_lMaterial = Convert.ToInt64(txtPK_lMaterial.Text);
                try { _tblMaterialEO.FK_sSubject = Convert.ToString(ddlFK_sSubject.SelectedValue); }
                catch { lblFK_sSubject.Text = Messages.Khong_Dung_Dinh_Dang_So; _tblMaterialEO.FK_sSubject = ""; }
                try { _tblMaterialEO.FK_sUsername = Convert.ToString(ddlFK_sUsername.SelectedValue); }
                catch { lblFK_sUsername.Text = Messages.Khong_Dung_Dinh_Dang_So; _tblMaterialEO.FK_sUsername = ""; }
                _tblMaterialEO.sDescription = Convert.ToString(txtsDescription.Text);
                _tblMaterialEO.sLinkDownload = Convert.ToString(txtsLinkDownload.Text);
                _tblMaterialEO.tLastUpdate = Convert.ToDateTime(txttLastUpdate.Text);
                try { _tblMaterialEO.iStatus = Convert.ToInt16(ddliStatus.SelectedValue); }
                catch { lbliStatus.Text = Messages.Khong_Dung_Dinh_Dang_So; _tblMaterialEO.iStatus = 0; }
                return _tblMaterialEO;
            }
            catch (Exception ex)
            {
                lblMsg.Text = Messages.Loi + ex.Message;
                return _tblMaterialEO;
            }
        }

        public void loadDataToDropDownList()
        {
            try
            {
                tblSubjectEO _tblSubjectEO = new tblSubjectEO();
                ddlFK_sSubject.DataSource = tblSubjectDAO.Subject_SelectList();
                ddlFK_sSubject.DataTextField = "sName";
                ddlFK_sSubject.DataValueField = "PK_sSubject";
                ddlFK_sSubject.DataBind();

                ddlFK_sUsername.DataSource = tblAccountDAO.Account_SelectList();
                ddlFK_sUsername.DataTextField = "sName";
                ddlFK_sUsername.DataValueField = "PK_sUsername";
                ddlFK_sUsername.DataBind();

                ddliStatus.DataSource = GetListConstants.tblMessage_iStatus_GLC();
                ddliStatus.DataTextField = "Value";
                ddliStatus.DataValueField = "Key";
                ddliStatus.DataBind();
            }
            catch (Exception ex)
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
            lblPK_lMaterial.Text = "";
            lblFK_sSubject.Text = "";
            lblFK_sUsername.Text = "";
            lblsDescription.Text = "";
            lblsLinkDownload.Text = "";
            lbltLastUpdate.Text = "";
            lbliSize.Text = "";
            lbliType.Text = "";
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
                    if (tblMaterialDAO.Material_Insert(getObject()) == true)
                    {
                        lblMsg.Text = Messages.Them_Thanh_Cong;
                        ClearMessages();
                        tblMaterialEO _tblMaterialEO = new tblMaterialEO();
                        BindDataDetail(_tblMaterialEO);
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
                if (tblMaterialDAO.Material_Update(getObject()) == true)
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
                if (tblMaterialDAO.Material_Delete(getObject()) == true)
                {
                    lblMsg.Text = Messages.Xoa_Thanh_Cong;
                    ClearMessages();
                    tblMaterialEO _tblMaterialEO = new tblMaterialEO();
                    BindDataDetail(_tblMaterialEO);
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
            tblMaterialEO _tblMaterialEO = new tblMaterialEO();
            BindDataDetail(_tblMaterialEO);
        }
        #endregion
    }
}