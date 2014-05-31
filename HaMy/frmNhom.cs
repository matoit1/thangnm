﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HaMy.EntityObject;
using HaMy.SharedLibraries;
using HaBa.SharedLibraries;
using HaMy.DataAccessObject;

namespace HaMy
{
    public partial class frmNhom : Form
    {
        #region "Form"
        public frmNhom()
        {
            InitializeComponent();
        }
        
        private void frmNhom_Load(object sender, EventArgs e)
        {
            ClearMessages();
            txtPK_iNhom.Enabled = false;
            BindDataGridView();
        }
        #endregion

        #region LoadData
        public void BindDataGridView()
        {
            grvNhom.Visible = false;
            DataSet dsNhom = new DataSet();
            try
            {
                dsNhom = tblNhomDAO.Nhom_SelectList();
                if (dsNhom.Tables[0].Rows.Count > 0)
                {
                    grvNhom.Visible = true;
                    grvNhom.AutoGenerateColumns = false;
                    grvNhom.DataSource = dsNhom.Tables[0];
                    //grvNhom.DataMember = dsNhom.Tables[0].ToString();
                }
            }
            catch
            {
            }
        }

        public void BindDataDetail(tblNhomEO _tblNhomEO)
        {
            txtPK_iNhom.Text = Convert.ToString(_tblNhomEO.PK_iNhom);
            txtsTenNhom.Text = Convert.ToString(_tblNhomEO.sTenNhom);
        }

        public tblNhomEO getObject()
        {
            try
            {
                tblNhomEO _tblNhomEO = new tblNhomEO();
                _tblNhomEO.PK_iNhom = (String.IsNullOrEmpty(txtPK_iNhom.Text))? 0 : Convert.ToInt32(txtPK_iNhom.Text);
                _tblNhomEO.sTenNhom = Convert.ToString(txtsTenNhom.Text);
                return _tblNhomEO;
            }
            catch (Exception)
            {
                throw;
            }
        }


        public void ClearMessages()
        {
            //lblMsg.Text = "";
            lblPK_iNhom.Text = "";
            lblsTenNhom.Text = "";
        }

        public bool CheckInput()
        {
            if (string.IsNullOrEmpty(txtPK_iNhom.Text) == true)
            {
                lblPK_iNhom.Text = "Bạn chưa nhập mã";
                return false;
            }
            if (string.IsNullOrEmpty(txtsTenNhom.Text) == true)
            {
                lblsTenNhom.Text = "Bạn chưa nhập tên nhóm";
                return false;
            }
            return true;
        }
        #endregion

        #region "Event DataGridView"
        private void grvNhom_SelectionChanged(object sender, EventArgs e)
        {
            tblNhomEO _tblNhomEO = new tblNhomEO();
            foreach (DataGridViewRow row in grvNhom.SelectedRows)
            {
                _tblNhomEO.PK_iNhom = Convert.ToInt32(row.Cells[0].Value);
                _tblNhomEO.sTenNhom = row.Cells[1].Value.ToString();
            }
            BindDataDetail(_tblNhomEO);
        }
        #endregion

        #region "Event Button"
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataSet dsNhom = new DataSet();
            dsNhom = tblNhomDAO.Nhom_Search(getObject());
            grvNhom.Visible = true;
            grvNhom.AutoGenerateColumns = false;
            grvNhom.DataSource = dsNhom.Tables[0];
            //grvNhom.DataMember = dsNhom.Tables[0].ToString();
            //grvNhom.DataBind();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ClearMessages();
            lblMsg.Text = "";
            try
            {
                if (CheckInput() == true)
                {
                    if (tblNhomDAO.Nhom_Insert(getObject()) == true)
                    {
                        lblMsg.Text = Messages.Them_Thanh_Cong;
                    }
                    else
                    {
                        lblMsg.Text = Messages.Them_That_Bai;
                    }
                    BindDataGridView();
                    tblNhomEO _tblNhomEO = new tblNhomEO();
                    BindDataDetail(_tblNhomEO);
                    ClearMessages();
                }
            }
            catch (Exception ex)
            {
                lblMsg.Text = Messages.Loi + ex.Message;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ClearMessages();
            lblMsg.Text = "";
            try
            {
                if (CheckInput() == true)
                {
                    if (tblNhomDAO.Nhom_Update(getObject()) == true)
                    {
                        lblMsg.Text = Messages.Sua_Thanh_Cong;
                    }
                    else
                    {
                        lblMsg.Text = Messages.Sua_That_Bai;
                    }
                    BindDataGridView();
                    tblNhomEO _tblNhomEO = new tblNhomEO();
                    BindDataDetail(_tblNhomEO);
                }
            }
            catch (Exception ex)
            {
                lblMsg.Text = Messages.Loi + ex.Message;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ClearMessages();
            lblMsg.Text = "";
            try
            {
                if (tblNhomDAO.Nhom_Delete(getObject()) == true)
                {
                    lblMsg.Text = Messages.Xoa_Thanh_Cong;
                }
                else
                {
                    lblMsg.Text = Messages.Xoa_That_Bai;
                }
                BindDataGridView();
                tblNhomEO _tblNhomEO = new tblNhomEO();
                BindDataDetail(_tblNhomEO);
            }
            catch (Exception ex)
            {
                lblMsg.Text = Messages.Loi + ex.Message;
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearMessages();
            lblMsg.Text = "";
            BindDataGridView();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearMessages();
            lblMsg.Text = "";
            tblNhomEO _tblNhomEO = new tblNhomEO();
            BindDataDetail(_tblNhomEO);
        }
        #endregion
    }
}