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
using DataAccessObject;
using Shared_Libraries;

namespace EHOU.UserControl
{
    public partial class tblSubject_Student_DetailUC : System.Web.UI.UserControl
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

        public void BindDataDetail(tblSubject_StudentEO _tblSubject_StudentEO)
        {
            try { ddlFK_sSubject.SelectedValue = Convert.ToString(_tblSubject_StudentEO.FK_sSubject); }
            catch { ddlFK_sSubject.SelectedIndex = 0; }
            try { ddlFK_sStudent.SelectedValue = Convert.ToString(_tblSubject_StudentEO.FK_sStudent); }
            catch { ddlFK_sStudent.SelectedIndex = 0; }
            try { ddliStatus.SelectedValue = Convert.ToString(_tblSubject_StudentEO.iStatus); }
            catch { ddliStatus.SelectedIndex = 0; }
        }

        private tblSubject_StudentEO getObject()
        {
            tblSubject_StudentEO _tblSubject_StudentEO = new tblSubject_StudentEO();
            try
            {
                try { _tblSubject_StudentEO.FK_sSubject = Convert.ToString(ddlFK_sSubject.SelectedValue); }
                catch { lblFK_sSubject.Text = Messages.Khong_Dung_Dinh_Dang_So; _tblSubject_StudentEO.FK_sSubject = ""; }
                try { _tblSubject_StudentEO.FK_sStudent = Convert.ToString(ddlFK_sStudent.SelectedValue); }
                catch { lblFK_sStudent.Text = Messages.Khong_Dung_Dinh_Dang_So; _tblSubject_StudentEO.FK_sStudent = ""; }
                try { _tblSubject_StudentEO.iStatus = Convert.ToInt16(ddliStatus.SelectedValue); }
                catch { lbliStatus.Text = Messages.Khong_Dung_Dinh_Dang_So; _tblSubject_StudentEO.iStatus = 0; }
                return _tblSubject_StudentEO;
            }
            catch (Exception ex)
            {
                lblMsg.Text = Messages.Loi + ex.Message;
                return _tblSubject_StudentEO;
            }
        }

        public void loadDataToDropDownList()
        {
            try
            {
                ddlFK_sSubject.DataSource = tblSubjectDAO.Subject_SelectList();
                ddlFK_sSubject.DataTextField = "sName";
                ddlFK_sSubject.DataValueField = "PK_iTaiKhoanID";
                ddlFK_sSubject.DataBind();

                ddlFK_sStudent.DataSource = tblAccountDAO.Account_SelectList();
                ddlFK_sStudent.DataTextField = "sName";
                ddlFK_sStudent.DataValueField = "PK_sUsername";
                ddlFK_sStudent.DataBind();

                ddliStatus.DataSource = GetListConstants.GiangVien_iTrangThaiGV_GLC();
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
            lblFK_sSubject.Text = "";
            lblFK_sStudent.Text = "";
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
                    if (tblSubject_StudentDAO.Subject_Student_Insert(getObject()) == true)
                    {
                        lblMsg.Text = Messages.Them_Thanh_Cong;
                        ClearMessages();
                        tblSubject_StudentEO _tblSubject_StudentEO = new tblSubject_StudentEO();
                        BindDataDetail(_tblSubject_StudentEO);
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
                if (tblSubject_StudentDAO.Subject_Student_Update(getObject()) == true)
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
                if (tblSubject_StudentDAO.Subject_Student_Delete(getObject()) == true)
                {
                    lblMsg.Text = Messages.Xoa_Thanh_Cong;
                    ClearMessages();
                    tblSubject_StudentEO _tblSubject_StudentEO = new tblSubject_StudentEO();
                    BindDataDetail(_tblSubject_StudentEO);
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
            tblSubject_StudentEO _tblSubject_StudentEO = new tblSubject_StudentEO();
            BindDataDetail(_tblSubject_StudentEO);
        }
        #endregion
    }
}