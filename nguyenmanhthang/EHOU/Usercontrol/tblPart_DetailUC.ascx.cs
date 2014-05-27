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
    public partial class tblPart_DetailUC : System.Web.UI.UserControl
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

        public void BindDataDetail(tblPartEO _tblPartEO)
        {
            txtPK_iPart.Text = Convert.ToString(_tblPartEO.PK_iPart);
            try { ddlFK_sSubject.SelectedValue = Convert.ToString(_tblPartEO.FK_sSubject); }
            catch { ddlFK_sSubject.SelectedIndex = 0; }
            txtsTitle.Text = Convert.ToString(_tblPartEO.sTitle);
            txtsLinkVideo.Text = Convert.ToString(_tblPartEO.sLinkVideo);
            txtsBlackList.Text = Convert.ToString(_tblPartEO.sBlackList);
            if (_tblPartEO.tDateTimeStart == DateTime.MinValue) { txttDateTimeStart.Text = DateTime.Now.ToString(); } else { txttDateTimeStart.Text = Convert.ToString(_tblPartEO.tDateTimeStart); }
            if (_tblPartEO.tDateTimeEnd == DateTime.MinValue) { txttDateTimeEnd.Text = DateTime.Now.ToString(); } else { txttDateTimeEnd.Text = Convert.ToString(_tblPartEO.tDateTimeEnd); }

            //txttNgayDatHang.Text = Convert.ToString(_tblPartEO.tNgayDatHang);
            //txttNgayGiaoHang.Text = Convert.ToString(_tblPartEO.tNgayGiaoHang);
            try { ddliStatus.SelectedValue = Convert.ToString(_tblPartEO.iStatus); }
            catch { ddliStatus.SelectedIndex = 0; }
        }

        private tblPartEO getObject()
        {
            tblPartEO _tblPartEO = new tblPartEO();
            try
            {
                _tblPartEO.PK_iPart = Convert.ToInt64(txtPK_iPart.Text);
                try { _tblPartEO.FK_sSubject = Convert.ToString(ddlFK_sSubject.SelectedValue); }
                catch { lblFK_sSubject.Text = Messages.Khong_Dung_Dinh_Dang_So; _tblPartEO.FK_sSubject = ""; }
                _tblPartEO.sTitle = Convert.ToString(txtsTitle.Text);
                _tblPartEO.sLinkVideo = Convert.ToString(txtsLinkVideo.Text);
                _tblPartEO.sBlackList = Convert.ToString(txtsBlackList.Text);
                _tblPartEO.tDateTimeStart = Convert.ToDateTime(txttDateTimeStart.Text);
                _tblPartEO.tDateTimeEnd = Convert.ToDateTime(txttDateTimeEnd.Text);
                try { _tblPartEO.iStatus = Convert.ToInt16(ddliStatus.SelectedValue); }
                catch { lbliStatus.Text = Messages.Khong_Dung_Dinh_Dang_So; _tblPartEO.iStatus = 0; }
                return _tblPartEO;
            }
            catch (Exception ex)
            {
                lblMsg.Text = Messages.Loi + ex.Message;
                return _tblPartEO;
            }
        }

        public void loadDataToDropDownList()
        {
            try
            {
                ddlFK_sSubject.DataSource = tblSubjectDAO.Subject_SelectList();
                ddlFK_sSubject.DataTextField = "sName";
                ddlFK_sSubject.DataValueField = "PK_sSubject";
                ddlFK_sSubject.DataBind();

                ddliStatus.DataSource = GetListConstants.tblPart_iStatus_GLC();
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
            lblPK_iPart.Text = "";
            lblFK_sSubject.Text = "";
            lblsTitle.Text = "";
            lblsLinkVideo.Text = "";
            lblsBlackList.Text = "";
            lbltDateTimeStart.Text = "";
            lbltDateTimeEnd.Text = "";
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
                    if (tblPartDAO.Part_Insert(getObject()) == true)
                    {
                        lblMsg.Text = Messages.Them_Thanh_Cong;
                        ClearMessages();
                        tblPartEO _tblPartEO = new tblPartEO();
                        BindDataDetail(_tblPartEO);
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
                
                if (tblPartDAO.Part_Update(getObject()) == true)
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
                if (tblPartDAO.Part_Delete(getObject()) == true)
                {
                    lblMsg.Text = Messages.Xoa_Thanh_Cong;
                    ClearMessages();
                    tblPartEO _tblPartEO = new tblPartEO();
                    BindDataDetail(_tblPartEO);
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
            tblPartEO _tblPartEO = new tblPartEO();
            BindDataDetail(_tblPartEO);
        }
        #endregion
    }
}