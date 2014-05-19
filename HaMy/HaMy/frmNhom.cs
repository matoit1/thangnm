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
    public partial class frmNhom : Form
    {
        public frmNhom()
        {
            InitializeComponent();
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
                _tblNhomEO.PK_iNhom = Convert.ToInt32(txtPK_iNhom.Text);
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
