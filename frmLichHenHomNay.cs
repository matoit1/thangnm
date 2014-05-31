using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HaMy.DataAccessObject;
using HaMy.EntityObject;

namespace HaMy
{
    public partial class frmLichHenHomNay : Form
    {
        public frmLichHenHomNay()
        {
            InitializeComponent();
        }

        #region LoadData
        public void BindDataGridView()
        {
            grvLichHenHomNay.Visible = false;
            DataSet dsCuocHen = new DataSet();
            try
            {
                tblCuocHenEO _tblCuocHenEO = new tblCuocHenEO();
                _tblCuocHenEO.tNgayGioBatDau = Convert.ToDateTime(dpktNgayGioBatDauDate.Text);
                _tblCuocHenEO.tNgayGioKetThuc = Convert.ToDateTime(dpktNgayGioBatDauDate.Text);
                dsCuocHen = tblCuocHenDAO.CuocHen_Search(_tblCuocHenEO);
                if (dsCuocHen.Tables[0].Rows.Count > 0)
                {
                    grvLichHenHomNay.Visible = true;
                    grvLichHenHomNay.AutoGenerateColumns = false;
                    grvLichHenHomNay.DataSource = dsCuocHen.Tables[0];
                    //grvDoiTac.DataMember = dsDoiTac.Tables[0].ToString();
                }
            }
            catch
            {
            }
        }
        #endregion

        private void frmLichHenHomNay_Load(object sender, EventArgs e)
        {
            BindDataGridView();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            BindDataGridView();
        }
    }
}
