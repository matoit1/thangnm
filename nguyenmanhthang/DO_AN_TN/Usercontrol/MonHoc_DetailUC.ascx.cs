﻿using System;
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

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                MonHocDAO.MonHoc_SelectList(getObject());
            }
            catch (Exception ex)
            {
                lblMsg.Text = Messages.Loi + ex.Message;
            }
        }

        protected void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                MonHocDAO.MonHoc_SelectList(getObject());
            }
            catch (Exception ex)
            {
                lblMsg.Text = Messages.Loi + ex.Message;
            }
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
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

        protected void btnExport_Click(object sender, EventArgs e)
        {
            MonHocDAO.MonHoc_SelectList(getObject());
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtPK_sMaMonhoc.Text = "";
            txtsTenMonhoc.Text = "";
            txtiSotrinh.Text = "";
            txtiSotietday.Text = "";
            txtiTrangThai.Text = "";
        }

        private MonHocEO getObject()
        {
            try
            {
                MonHocEO _MonHocEO = new MonHocEO();
                _MonHocEO.PK_sMaMonhoc = txtPK_sMaMonhoc.Text;
                _MonHocEO.sTenMonhoc = txtsTenMonhoc.Text;
                try{
                    _MonHocEO.iSotrinh = Convert.ToInt16(txtiSotrinh.Text);
                }
                catch{
                    txtiSotrinh.Text = "0";
                    _MonHocEO.iSotrinh = 0;
                }
                try
                {
                    _MonHocEO.iSotietday = Convert.ToInt16(txtiSotietday.Text);
                }
                catch
                {
                    txtiSotietday.Text = "0";
                    _MonHocEO.iSotietday = 0;
                }
                try
                {
                    _MonHocEO.iTrangThai = Convert.ToInt16(txtiTrangThai.Text);
                }
                catch
                {
                    txtiTrangThai.Text = "0";
                    _MonHocEO.iTrangThai = 0;
                }
                return _MonHocEO;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}