﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Shared_Libraries;
using EntityObject;
using DataAccessObject;

namespace DO_AN_TN.UserControl
{
    public partial class LopHoc_DetailUC : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadDataToDropDownList();
            }
        }

        public void BindDataDetail(LopHocEO _LopHocEO)
        {
            try { txtPK_sMalop.Text = Convert.ToString(_LopHocEO.PK_sMalop); }
            catch { txtPK_sMalop.Text = ""; lblPK_sMalop.Text = Messages.Ma_Khong_Hop_Le; }
            txtsTenlop.Text = Convert.ToString(_LopHocEO.sTenlop);
            txtiNamvaotruong.Text = Convert.ToString(_LopHocEO.iNamvaotruong);
            txtiSiso.Text = Convert.ToString(_LopHocEO.iSiso);
            txtiSoNamDaoTao.Text = Convert.ToString(_LopHocEO.iSoNamDaoTao);
            try { ddliTrangThai.SelectedValue = _LopHocEO.iTrangThai.ToString(); }
            catch { ddliTrangThai.SelectedIndex = 0; }
        }

        #region "Event Button"
        protected void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (LopHocDAO.LopHoc_Insert(getObject()) == true)
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
            try
            {
                if (LopHocDAO.LopHoc_Update(getObject()) == true)
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
            try
            {
                if (LopHocDAO.LopHoc_Delete(getObject()) == true)
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
            LopHocEO _LopHocEO = new LopHocEO();
            BindDataDetail(_LopHocEO);
        }
        #endregion

        private LopHocEO getObject()
        {
            try
            {
                LopHocEO _LopHocEO = new LopHocEO();
                _LopHocEO.PK_sMalop = Convert.ToString(txtPK_sMalop.Text);
                _LopHocEO.sTenlop = Convert.ToString(txtsTenlop.Text);
                try{ _LopHocEO.iNamvaotruong = Convert.ToInt16(txtiNamvaotruong.Text);}
                catch{ lbliNamvaotruong.Text = Messages.Khong_Dung_Dinh_Dang_So;}
                try{ _LopHocEO.iSiso = Convert.ToInt16(txtiSiso.Text);}
                catch{ lbliSiso.Text = Messages.Khong_Dung_Dinh_Dang_So;}
                try{ _LopHocEO.iSoNamDaoTao = Convert.ToInt16(txtiSoNamDaoTao.Text);}
                catch{ lbliSoNamDaoTao.Text = Messages.Khong_Dung_Dinh_Dang_So;}
                _LopHocEO.iTrangThai = Convert.ToInt16(ddliTrangThai.SelectedValue);
                return _LopHocEO;
            }
            catch (Exception)
            {
                throw;
            }
        }
        
        public void loadDataToDropDownList()
        {
            ddliTrangThai.DataSource = GetListConstants.LopHoc_iTrangThai_GLC();
            ddliTrangThai.DataTextField = "Value";
            ddliTrangThai.DataValueField = "Key";
            ddliTrangThai.DataBind();
        }
    }
}