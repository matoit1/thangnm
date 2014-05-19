using System;
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
        public frmNhom()
        {
            InitializeComponent();
        }

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
                    //grvNhom.AutoGenerateColumns = false;
                    grvNhom.DataSource = dsNhom.Tables[0].DefaultView;
                    grvNhom.DataMember = dsNhom.Tables[0].ToString();
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
            lblPK_iNhom.Text = "";
            lblsTenNhom.Text = "";
        }

        #region "Event Button"
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataSet dsNhom = new DataSet();
            dsNhom = tblNhomDAO.Nhom_Search(getObject());
            grvNhom.Visible = true;
            grvNhom.DataSource = dsNhom;
            grvNhom.DataMember = dsNhom.Tables[0].ToString();
            //grvNhom.DataBind();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ClearMessages();
            try
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
            }
            catch (Exception ex)
            {
                lblMsg.Text = Messages.Loi + ex.Message;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ClearMessages();
            try
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
            }
            catch (Exception ex)
            {
                lblMsg.Text = Messages.Loi + ex.Message;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ClearMessages();
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
            }
            catch (Exception ex)
            {
                lblMsg.Text = Messages.Loi + ex.Message;
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            BindDataGridView();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearMessages();
            tblNhomEO _tblNhomEO = new tblNhomEO();
            BindDataDetail(_tblNhomEO);
        }
        #endregion

        private void frmNhom_Load(object sender, EventArgs e)
        {
            txtPK_iNhom.Enabled = false;
            BindDataGridView();
        }

        private void grvNhom_SelectionChanged(object sender, EventArgs e)
        {
            tblNhomEO _tblNhomEO = new tblNhomEO();
            foreach (DataGridViewRow row in grvNhom.SelectedRows)
            {
                _tblNhomEO.PK_iNhom = Convert.ToInt16(row.Cells[2].Value);
                _tblNhomEO.sTenNhom = row.Cells[3].Value.ToString();
            }
            BindDataDetail(_tblNhomEO);
        }
    }
}
