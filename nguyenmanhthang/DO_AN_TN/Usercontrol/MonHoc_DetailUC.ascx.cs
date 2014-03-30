using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessObject;
using EntityObject;
using Shared_Libraries;

namespace DO_AN_TN.UserControl
{
    public partial class MonHoc_DetailUC : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ClearMessages();
                loadDataToDropDownList();
            }
        }

        public void BindDataDetail(MonHocEO _MonHocEO)
        {
            try { txtPK_sMaMonhoc.Text = _MonHocEO.PK_sMaMonhoc; }
            catch { txtPK_sMaMonhoc.Text = ""; lblPK_sMaMonhoc.Text = Messages.Loi_Tai_Du_Lieu; }
            txtsTenMonhoc.Text = _MonHocEO.sTenMonhoc;
            txtiSotrinh.Text = _MonHocEO.iSotrinh.ToString();
            txtiSotietday.Text = _MonHocEO.iSotietday.ToString();
            try{ ddliTrangThai.SelectedValue = _MonHocEO.iTrangThai.ToString();}
            catch { ddliTrangThai.SelectedIndex = 0; lbliTrangThai.Text = Messages.Loi_Tai_Du_Lieu; }
        }

        private MonHocEO getObject()
        {
            try
            {
                MonHocEO _MonHocEO = new MonHocEO();
                try { _MonHocEO.PK_sMaMonhoc = txtPK_sMaMonhoc.Text; }
                catch { txtPK_sMaMonhoc.Text = ""; lblPK_sMaMonhoc.Text = Messages.Ma_Khong_Hop_Le; }
                _MonHocEO.sTenMonhoc = txtsTenMonhoc.Text;
                try{ _MonHocEO.iSotrinh = Convert.ToInt16(txtiSotrinh.Text);}
                catch { lbliSotrinh.Text = Messages.Khong_Dung_Dinh_Dang_So; }
                try{_MonHocEO.iSotietday = Convert.ToInt16(txtiSotietday.Text);}
                catch{ lbliSotietday.Text = Messages.Khong_Dung_Dinh_Dang_So;}
                _MonHocEO.iTrangThai = Convert.ToInt16(ddliTrangThai.SelectedValue);
                return _MonHocEO;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void loadDataToDropDownList()
        {
            ddliTrangThai.DataSource = GetListConstants.MonHoc_iTrangThai_GLC();
            ddliTrangThai.DataTextField = "Value";
            ddliTrangThai.DataValueField = "Key";
            ddliTrangThai.DataBind();
        }

        private void ClearMessages()
        {
            lblMsg.Text = "";
            lblPK_sMaMonhoc.Text = "";
            lblsTenMonhoc.Text = "";
            lbliSotrinh.Text = "";
            lbliSotietday.Text = "";
            lbliTrangThai.Text = "";
        }

        #region "Event Button"
        protected void btnInsert_Click(object sender, EventArgs e)
        {
            ClearMessages();
            try
            {
                if (MonHocDAO.MonHoc_Insert(getObject()) == true)
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
                if (MonHocDAO.MonHoc_Update(getObject()) == true)
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
                if (MonHocDAO.MonHoc_Delete(getObject()) == true)
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
            MonHocEO _MonHocEO = new MonHocEO();
            BindDataDetail(_MonHocEO);
        }
        #endregion
    }
}