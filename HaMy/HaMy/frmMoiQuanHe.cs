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
    public partial class frmMoiQuanHe : Form
    {
        public frmMoiQuanHe()
        {
            InitializeComponent();
        }


        public void BindDataGridView()
        {
            grvMoiQuanHe.Visible = false;
            DataSet dsMoiQuanHe = new DataSet();
            try
            {
                dsMoiQuanHe = tblMoiQuanHeDAO.MoiQuanHe_SelectList();
                if (dsMoiQuanHe.Tables[0].Rows.Count > 0)
                {
                    grvMoiQuanHe.Visible = true;
                    grvMoiQuanHe.DataSource = dsMoiQuanHe;
                    grvMoiQuanHe.DataMember = dsMoiQuanHe.Tables[0].ToString();
                    grvMoiQuanHe.AutoGenerateColumns = true;
                }
            }
            catch
            {
            }
        }

        public void BindDataDetail(tblMoiQuanHeEO _tblMoiQuanHeEO)
        {
            txtPK_iMoiQuanHe.Text = Convert.ToString(_tblMoiQuanHeEO.PK_iMoiQuanHe);
            txtsTen.Text = Convert.ToString(_tblMoiQuanHeEO.sTen);
        }

        public tblMoiQuanHeEO getObject()
        {
            try
            {
                tblMoiQuanHeEO _tblMoiQuanHeEO = new tblMoiQuanHeEO();
                _tblMoiQuanHeEO.PK_iMoiQuanHe = Convert.ToInt32(txtPK_iMoiQuanHe.Text);
                _tblMoiQuanHeEO.sTen = Convert.ToString(txtsTen.Text);
                return _tblMoiQuanHeEO;
            }
            catch (Exception)
            {
                throw;
            }
        }

       
        public void ClearMessages()
        {
            lblPK_iMoiQuanHe.Text = "";
            lblsTen.Text = "";
        }

        #region "Event Button"
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataSet dsMoiQuanHe = new DataSet();
            tblMoiQuanHeDAO.MoiQuanHe_Search(getObject());
            grvMoiQuanHe.Visible = true;
            grvMoiQuanHe.DataSource = dsMoiQuanHe;
            grvMoiQuanHe.DataMember = dsMoiQuanHe.Tables[0].ToString();
            //grvMoiQuanHe.DataBind();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ClearMessages();
            try
            {
                if (tblMoiQuanHeDAO.MoiQuanHe_Insert(getObject()) == true)
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            ClearMessages();
            try
            {
                if (tblMoiQuanHeDAO.MoiQuanHe_Update(getObject()) == true)
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ClearMessages();
            try
            {
                if (tblMoiQuanHeDAO.MoiQuanHe_Delete(getObject()) == true)
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

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            BindDataGridView();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearMessages();
            tblMoiQuanHeEO _tblMoiQuanHeEO = new tblMoiQuanHeEO();
            BindDataDetail(_tblMoiQuanHeEO);
        }
        #endregion

        private void frmMoiQuanHe_Load(object sender, EventArgs e)
        {
            BindDataGridView();
        }

    }
}
