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

namespace HaMy
{
    public partial class frmMoiQuanHe : Form
    {
        public frmMoiQuanHe()
        {
            InitializeComponent();
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

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
