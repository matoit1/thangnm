using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CongKy.EntityObject;
using CongKy.SharedLibraries;
using CongKy.DataAccessObject;

namespace CongKy.UserControl
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

        public void BindDataDetail(tblMonHocEO _tblMonHocEO)
        {
            txtPK_iMonHocID.Text = Convert.ToString(_tblMonHocEO.PK_iMonHocID);
            txtsTenMonHoc.Text = Convert.ToString(_tblMonHocEO.sTenMonHoc);
            try { ddliTrangThai.SelectedValue = _tblMonHocEO.iTrangThai.ToString(); }
            catch { ddliTrangThai.SelectedIndex = 0; }
        }

        private tblMonHocEO getObject()
        {
            try
            {
                tblMonHocEO _tblMonHocEO = new tblMonHocEO();
                try { _tblMonHocEO.PK_iMonHocID = Convert.ToInt32(txtPK_iMonHocID.Text); }
                catch { lblPK_iMonHocID.Text = Messages.Khong_Dung_Dinh_Dang_So; _tblMonHocEO.PK_iMonHocID = 0; }
                _tblMonHocEO.sTenMonHoc = Convert.ToString(txtsTenMonHoc.Text);
                try { _tblMonHocEO.iTrangThai = Convert.ToInt16(ddliTrangThai.SelectedValue); }
                catch { lbliTrangThai.Text = Messages.Khong_Dung_Dinh_Dang_So; }
                return _tblMonHocEO;
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

        public bool CheckInput()
        {
            if (string.IsNullOrEmpty(txtsTenMonHoc.Text) == true)
            {
                lblsTenMonHoc.Text = Messages.Khong_Duoc_De_Trong;
                txtsTenMonHoc.Focus();
                return false;
            }
            return true;
        }


        public void ClearMessages()
        {
            //lblMsg.Text = "";
            lblPK_iMonHocID.Text = "";
            lblsTenMonHoc.Text = "";
            lbliTrangThai.Text = "";
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
                if (tblMonHocDAO.MonHoc_Insert(getObject()) == true)
                {
                    lblMsg.Text = Messages.Them_Thanh_Cong;
                    ClearMessages();
                    tblMonHocEO _tblMonHocEO = new tblMonHocEO();
                    BindDataDetail(_tblMonHocEO);
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
              if (CheckInput() == true)
               {
                if (tblMonHocDAO.MonHoc_Update(getObject()) == true)
                {
                    lblMsg.Text = Messages.Sua_Thanh_Cong;
                    ClearMessages();
                }
                else
                {
                    lblMsg.Text = Messages.Sua_That_Bai;
                }
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
                tblEO _tblHoaDonEO = new tblHoaDonEO();
                _tblHoaDonEO.FK_iThanhToanID = getObject().PK_iMonHocID;
                if (tblDangKyDayHocDAO.HoaDon_CheckExists_FK_iThanhToanID(_tblHoaDonEO) == false)
                {
                    if (tblMonHocDAO.MonHoc_Delete(getObject()) == true)
                    {
                        lblMsg.Text = Messages.Xoa_Thanh_Cong;
                        ClearMessages();
                        tblMonHocEO _tblMonHocEO = new tblMonHocEO();
                        BindDataDetail(_tblMonHocEO);
                    }
                    else
                    {
                        lblMsg.Text = Messages.Xoa_That_Bai;
                    }
                }
                else
                {
                    lblMsg.Text = Messages.Ma_Thanh_Toan_Da_Dung_Trong_Hoa_Don;
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
            tblMonHocEO _tblMonHocEO = new tblMonHocEO();
            BindDataDetail(_tblMonHocEO);
        }
        #endregion;
    }
}