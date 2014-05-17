using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HaBa.EntityObject;
using HaBa.SharedLibraries;
using HaBa.DataAccessObject;

namespace HaBa.UserControl
{
    public partial class tblThanhToan_DetailUC : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ClearMessages();
                loadDataToDropDownList();
            }
        }

        public void BindDataDetail(tblThanhToanEO _tblThanhToanEO)
        {
            txtPK_iThanhToanID.Text = Convert.ToString(_tblThanhToanEO.PK_iThanhToanID);
            txtsTenThanhToan.Text = Convert.ToString(_tblThanhToanEO.sTenThanhToan);
            try { ddliTrangThai.SelectedValue = _tblThanhToanEO.iTrangThai.ToString(); }
            catch { ddliTrangThai.SelectedIndex = 0; }
        }

        private tblThanhToanEO getObject()
        {
            try
            {
                tblThanhToanEO _tblThanhToanEO = new tblThanhToanEO();
                try { _tblThanhToanEO.PK_iThanhToanID = Convert.ToInt16(txtPK_iThanhToanID.Text); }
                catch { lblPK_iThanhToanID.Text = Messages.Khong_Dung_Dinh_Dang_So; _tblThanhToanEO.PK_iThanhToanID = 0; }
                _tblThanhToanEO.sTenThanhToan = Convert.ToString(txtsTenThanhToan.Text);
                try { _tblThanhToanEO.iTrangThai = Convert.ToInt16(ddliTrangThai.SelectedValue); }
                catch { lbliTrangThai.Text = Messages.Khong_Dung_Dinh_Dang_So; }
                return _tblThanhToanEO;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void loadDataToDropDownList()
        {
            ddliTrangThai.DataSource = GetListConstants.ThanhToan_iTrangThai_GLC();
            ddliTrangThai.DataTextField = "Value";
            ddliTrangThai.DataValueField = "Key";
            ddliTrangThai.DataBind();
        }

        private void ClearMessages()
        {
            lblMsg.Text = "";
            lblPK_iThanhToanID.Text = "";
            lblsTenThanhToan.Text = "";
            lbliTrangThai.Text = "";
        }

        #region "Event Button"
        protected void btnInsert_Click(object sender, EventArgs e)
        {
            ClearMessages();
            try
            {
                if (tblThanhToanDAO.ThanhToan_Insert(getObject()) == true)
                {
                    lblMsg.Text = Messages.Them_Thanh_Cong;
                }
                else
                {
                    lblMsg.Text = Messages.Them_That_Bai;
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
            try
            {
                if (tblThanhToanDAO.ThanhToan_Update(getObject()) == true)
                {
                    lblMsg.Text = Messages.Sua_Thanh_Cong;
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
            try
            {
                if (tblThanhToanDAO.ThanhToan_Delete(getObject()) == true)
                {
                    lblMsg.Text = Messages.Xoa_Thanh_Cong;
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
            tblThanhToanEO _tblThanhToanEO = new tblThanhToanEO();
            BindDataDetail(_tblThanhToanEO);
        }
        #endregion;
    }
}