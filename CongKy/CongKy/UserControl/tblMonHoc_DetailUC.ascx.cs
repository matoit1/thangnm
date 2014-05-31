using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CongKy.EntityObject;
using CongKy.SharedLibraries;
using CongKy.DataAccessObject;
using CongKy.SharedLibraries.Constants;
using System.Data;

namespace CongKy.UserControl
{
    public partial class tblMonHoc_DetailUC : System.Web.UI.UserControl
    {

        private Int32 _PK_iTaiKhoanID;
        public Int32 PK_iTaiKhoanID
        {
            get { return this._PK_iTaiKhoanID; }
            set { _PK_iTaiKhoanID = value; }
        }
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
            tblDangKyDayHocEO _tblDangKyDayHocEO = new tblDangKyDayHocEO();
            _tblDangKyDayHocEO.FK_iMonHocID = _tblMonHocEO.PK_iMonHocID;
            DataSet ds = tblDangKyDayHocDAO.DangKyDayHoc_SelectByFK_iMonHocID(_tblDangKyDayHocEO);
            txtPK_iMonHocID.Text = Convert.ToString(_tblMonHocEO.PK_iMonHocID);
            txtsTenMonHoc.Text = Convert.ToString(_tblMonHocEO.sTenMonHoc);
            txtsLinkImage.Text = Convert.ToString(_tblMonHocEO.sLinkImage);
            try { ddlFK_iTaiKhoanID.SelectedValue = ds.Tables[0].Rows[0]["FK_iTaiKhoanID"].ToString(); }
            catch { ddlFK_iTaiKhoanID.SelectedIndex = 0; }
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
                _tblMonHocEO.sLinkImage = Convert.ToString(txtsLinkImage.Text);
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
            tblTaiKhoanEO _tblTaiKhoanEO = new tblTaiKhoanEO();
            _tblTaiKhoanEO.iQuyenHan = TaiKhoan_iQuyenHan_C.GiangVien;
            ddlFK_iTaiKhoanID.DataSource = tblTaiKhoanDAO.TaiKhoan_SelectListByiQuyenHan(_tblTaiKhoanEO);
            ddlFK_iTaiKhoanID.DataTextField = "sHoTen";
            ddlFK_iTaiKhoanID.DataValueField = "PK_iTaiKhoanID";
            ddlFK_iTaiKhoanID.DataBind();

            ddliTrangThai.DataSource = GetListConstants.MonHoc_iTrangThai_GLC();
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
                if (tblMonHocDAO.MonHoc_Insert(getObject(), Convert.ToInt32(ddlFK_iTaiKhoanID.SelectedValue)) == true)
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
                   if (tblMonHocDAO.MonHoc_Update(getObject(), Convert.ToInt32(ddlFK_iTaiKhoanID.SelectedValue)) == true)
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
                //tblMonHocEO _tblMonHocEO = new tblMonHocEO();
                //_tblMonHocEO.PK_iMonHocID = getObject().PK_iMonHocID;
                //if (tblMonHocDAO.MonHoc_CheckExists_PK_iMonHocID(_tblMonHocEO) == false)
                //{
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
            //    }
            //    else
            //    {
            //        lblMsg.Text = Messages.Ma_Thanh_Toan_Da_Dung_Trong_Hoa_Don;
            //    }
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

        protected void btnSubscribe_Click(object sender, EventArgs e)
        {
            ClearMessages();
            lblMsg.Text = "";
            tblDangKyDayHocEO _tblDangKyDayHocEO = new tblDangKyDayHocEO();
            _tblDangKyDayHocEO.FK_iMonHocID = getObject().PK_iMonHocID;
            _tblDangKyDayHocEO.FK_iTaiKhoanID = PK_iTaiKhoanID;
            _tblDangKyDayHocEO.iTrangThai = DangKyDayHoc_iTrangThai_C.Mo;
            try
            {
                if (tblDangKyDayHocDAO.DangKyDayHoc_Insert(_tblDangKyDayHocEO) == true)
                {
                    lblMsg.Text = Messages.Dang_Ky_Thanh_Cong;
                    ClearMessages();
                    btnUnsubscribe.Visible = true;
                    btnSubscribe.Visible = false;
                }
                else
                {
                    lblMsg.Text = Messages.Dang_Ky_That_Bai;
                }
            }
            catch (Exception ex)
            {
                lblMsg.Text = Messages.Loi + ex.Message;
            }
        }

        protected void btnUnsubscribe_Click(object sender, EventArgs e)
        {
            ClearMessages();
            lblMsg.Text = "";
            tblDangKyDayHocEO _tblDangKyDayHocEO = new tblDangKyDayHocEO();
            _tblDangKyDayHocEO.FK_iMonHocID = getObject().PK_iMonHocID;
            _tblDangKyDayHocEO.FK_iTaiKhoanID = PK_iTaiKhoanID;
            try
            {
                if (tblDangKyDayHocDAO.DangKyDayHoc_Delete(_tblDangKyDayHocEO) == true)
                {
                    lblMsg.Text = Messages.Huy_Dang_Ky_Thanh_Cong;
                    ClearMessages();
                    btnUnsubscribe.Visible = false;
                    btnSubscribe.Visible = true;
                }
                else
                {
                    lblMsg.Text = Messages.Huy_Dang_Ky_That_Bai;
                }
            }
            catch (Exception ex)
            {
                lblMsg.Text = Messages.Loi + ex.Message;
            }
        }
        #endregion;

        public void Permit_Access()
        {
            txtPK_iMonHocID.Enabled = false;
            lblPK_iMonHocID.Enabled = false;

            txtsTenMonHoc.Enabled = false;
            txtsTenMonHoc.Enabled = false;

            txtsLinkImage.Enabled = false;
            lblsLinkImage.Enabled = false;

            ddlFK_iTaiKhoanID.Enabled = false;
            lblFK_iTaiKhoanID.Enabled = false;

            ddliTrangThai.Visible = false;
            lbliTrangThai.Visible = false;
            lbliTrangThai_Title.Visible = false;

            btnInsert.Visible = false;
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
            btnReset.Visible = false;
        }
    }
}