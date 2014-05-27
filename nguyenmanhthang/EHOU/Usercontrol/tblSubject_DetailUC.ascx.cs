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
    public partial class tblSubject_DetailUC : System.Web.UI.UserControl
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

        public void BindDataDetail(tblSubjectEO _tblSubjectEO)
        {
            txtPK_sSubject.Text = Convert.ToString(_tblSubjectEO.PK_sSubject);
            try { ddlFK_sTeacher.SelectedValue = Convert.ToString(_tblSubjectEO.FK_sTeacher); }
            catch { ddlFK_sTeacher.SelectedIndex = 0; }
            txtsName.Text = Convert.ToString(_tblSubjectEO.sName);
            try { ddliStatus.SelectedValue = Convert.ToString(_tblSubjectEO.iStatus); }
            catch { ddliStatus.SelectedIndex = 0; }
        }

        private tblSubjectEO getObject()
        {
            tblSubjectEO _tblSubjectEO = new tblSubjectEO();
            try
            {
                _tblSubjectEO.PK_sSubject = Convert.ToString(txtPK_sSubject.Text);
                try { _tblSubjectEO.FK_sTeacher = Convert.ToString(ddlFK_sTeacher.SelectedValue); }
                catch { lblFK_sTeacher.Text = Messages.Khong_Dung_Dinh_Dang_So; _tblSubjectEO.FK_sTeacher = ""; }
                _tblSubjectEO.sName = Convert.ToString(txtsName.Text);
                try { _tblSubjectEO.iStatus = Convert.ToInt16(ddliStatus.SelectedValue); }
                catch { lbliStatus.Text = Messages.Khong_Dung_Dinh_Dang_So; _tblSubjectEO.iStatus = 0; }
                return _tblSubjectEO;
            }
            catch (Exception ex)
            {
                lblMsg.Text = Messages.Loi + ex.Message;
                return _tblSubjectEO;
            }
        }

        public void loadDataToDropDownList()
        {
            try
            {
                ddlFK_sTeacher.DataSource = tblAccountDAO.Account_SelectList();
                ddlFK_sTeacher.DataTextField = "sTenThanhToan";
                ddlFK_sTeacher.DataValueField = "PK_iThanhToanID";
                ddlFK_sTeacher.DataBind();

                ddliStatus.DataSource = GetListConstants.tblSubject_iStatus_GLC();
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
            lblPK_sSubject.Text = "";
            lblFK_sTeacher.Text = "";
            lblsName.Text = "";
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
                    if (tblSubjectDAO.Subject_Insert(getObject()) == true)
                    {
                        lblMsg.Text = Messages.Them_Thanh_Cong;
                        ClearMessages();
                        tblSubjectEO _tblSubjectEO = new tblSubjectEO();
                        BindDataDetail(_tblSubjectEO);
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
                if (tblSubjectDAO.Subject_Update(getObject()) == true)
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
                if (tblSubjectDAO.Subject_Delete(getObject()) == true)
                {
                    lblMsg.Text = Messages.Xoa_Thanh_Cong;
                    ClearMessages();
                    tblSubjectEO _tblSubjectEO = new tblSubjectEO();
                    BindDataDetail(_tblSubjectEO);
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
            tblSubjectEO _tblSubjectEO = new tblSubjectEO();
            BindDataDetail(_tblSubjectEO);
        }
        #endregion
    }
}