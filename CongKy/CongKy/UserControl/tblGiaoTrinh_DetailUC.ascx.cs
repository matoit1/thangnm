﻿using System;
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
    public partial class tblChiTietHoaDon_DetailUC : System.Web.UI.UserControl
    {
        //#region "Properties & Event"
        //public Int16 iType
        //{
        //    get { return (Int16)ViewState["iType"]; }
        //    set { ViewState["iType"] = value; }
        //}
        //#endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ClearMessages();
                loadDataToDropDownList();
            }
        }

        public void BindDataDetail(tblGiaoTrinhEO _tblGiaoTrinhEO)
        {
            try { ddlFK_iMonHocID.SelectedValue = Convert.ToString(_tblGiaoTrinhEO.FK_iMonHocID); }
            catch { ddlFK_iMonHocID.SelectedIndex = 0; }
            try { ddlFK_iGiaoTrinhID.SelectedValue = Convert.ToString(_tblGiaoTrinhEO.FK_iGiaoTrinhID); }
            catch { ddlFK_iGiaoTrinhID.SelectedIndex = 0; }
        }

        private tblGiaoTrinhEO getObject()
        {
            try
            {
                tblGiaoTrinhEO _tblGiaoTrinhEO = new tblGiaoTrinhEO();
                try { _tblGiaoTrinhEO.FK_iMonHocID = Convert.ToInt32(ddlFK_iMonHocID.SelectedValue); }
                catch { lblFK_iMonHocID.Text = Messages.Ma_Khong_Hop_Le; }
                try { _tblGiaoTrinhEO.FK_iGiaoTrinhID = Convert.ToInt32(ddlFK_iGiaoTrinhID.SelectedValue); }
                catch { lblFK_iGiaoTrinhID.Text = Messages.Ma_Khong_Hop_Le; }
                return _tblGiaoTrinhEO;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void loadDataToDropDownList()
        {
            ddlFK_iMonHocID.DataSource = tblMonHocDAO.MonHoc_SelectList();
            ddlFK_iMonHocID.DataTextField = "FK_iMonHocID";
            ddlFK_iMonHocID.DataValueField = "FK_iMonHocID";
            ddlFK_iMonHocID.DataBind();

            ddlFK_sSanPhamID.DataSource = tblMonHocDAO.SanPham_SelectList();
            ddlFK_sSanPhamID.DataTextField = "sTenSanPham";
            ddlFK_sSanPhamID.DataValueField = "PK_sSanPhamID";
            ddlFK_sSanPhamID.DataBind();
        }

        public bool CheckInput()
        {
            Int64 num64;
            Int16 num16;
            if (string.IsNullOrEmpty(txtlGiaBan.Text) == true)
            {
                lbllGiaBan.Text = Messages.Khong_Duoc_De_Trong;
                txtlGiaBan.Focus();
                return false;
            }
            else
            {
                bool isNum = Int64.TryParse(txtlGiaBan.Text, out num64);
                if (isNum == false)
                {
                    lbllGiaBan.Text = Messages.Khong_Dung_Dinh_Dang_So;
                    txtlGiaBan.Focus();
                    return false;
                }

            }
            if (string.IsNullOrEmpty(txtiSoLuong.Text) == true)
            {
                lbliSoLuong.Text = Messages.Khong_Duoc_De_Trong;
                txtiSoLuong.Focus();
                return false;
            }
            else
            {
                bool isNum = Int16.TryParse(txtiSoLuong.Text, out num16);
                if (isNum == false)
                {
                    lbliSoLuong.Text = Messages.Khong_Dung_Dinh_Dang_So;
                    txtiSoLuong.Focus();
                    return false;
                }
            }
            return true;
        }

        public void ClearMessages()
        {
            //lblMsg.Text = "";
            lblFK_lHoaDonID.Text = "";
            lblFK_sSanPhamID.Text = "";
            lbllGiaBan.Text = "";
            lbliSoLuong.Text = "";
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
                    if (tblChiTietGiaoTrinhDAO.ChiTietHoaDon_Insert(getObject()) == true)
                    {
                        lblMsg.Text = Messages.Them_Thanh_Cong;
                        ClearMessages();
                        tblChiTietGiaoTrinhEO _tblChiTietHoaDonEO = new tblChiTietGiaoTrinhEO();
                        BindDataDetail(_tblChiTietHoaDonEO);
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
                    if (tblChiTietGiaoTrinhDAO.ChiTietHoaDon_Update(getObject()) == true)
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
                if (tblChiTietGiaoTrinhDAO.ChiTietHoaDon_Delete(getObject()) == true)
                {
                    lblMsg.Text = Messages.Xoa_Thanh_Cong;
                    ClearMessages();
                    tblChiTietGiaoTrinhEO _tblChiTietHoaDonEO = new tblChiTietGiaoTrinhEO();
                    BindDataDetail(_tblChiTietHoaDonEO);
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
            tblChiTietGiaoTrinhEO _tblChiTietHoaDonEO = new tblChiTietGiaoTrinhEO();
            BindDataDetail(_tblChiTietHoaDonEO);
        }
        #endregion
    }
}