using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HaMy.EntityObject;
using HaMy.DataAccessObject;
using HaBa.SharedLibraries.Constants;
using HaMy.SharedLibraries;
using HaBa.SharedLibraries;
using System.Media;
using HaMy.Properties;
using System.Reflection;
using System.IO;

namespace HaMy
{
    public partial class frmThongBao : Form
    {
        #region "Properties & Event"
        private tblCuocHenEO _objtblCuocHenEO;
        public tblCuocHenEO objtblCuocHenEO
        {
            get { return this._objtblCuocHenEO; }
            set { _objtblCuocHenEO = value; }
        }
        #endregion
        public frmThongBao()
        {
            InitializeComponent();
        }

        public void BindDataList(DataSet ds)
        {
           // grvCuocHen.Visible = false;
            try
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    grvCuocHen.Visible = true;
                    grvCuocHen.AutoGenerateColumns = false;
                    grvCuocHen.DataSource = ds.Tables[0];
                }
            }
            catch
            {
            }
        }

        public void BindDataDetail(tblCuocHenEO _tblCuocHenEO)
        {
            //grvCuocHen.Visible = false;
            objtblCuocHenEO = _tblCuocHenEO;
            tblNguoiDungEO _tblNguoiDungEO = new tblNguoiDungEO();
            tblDoiTacEO _tblDoiTacEO = new tblDoiTacEO();

            _tblNguoiDungEO.PK_iNguoiDung = _tblCuocHenEO.FK_iNguoiDung;
            _tblDoiTacEO.PK_iDoiTac = _tblCuocHenEO.FK_iDoiTac;

            _tblNguoiDungEO = tblNguoiDungDAO.NguoiDung_SelectItem(_tblNguoiDungEO);
            _tblDoiTacEO = tblDoiTacDAO.DoiTac_SelectItem(_tblDoiTacEO);

            txtPK_lCuocHen.Text = Convert.ToString(_tblCuocHenEO.PK_lCuocHen);
            txtFK_iNguoiDung.Text = _tblNguoiDungEO.sHoTen;
            txtFK_iDoiTac.Text = _tblDoiTacEO.sHoTen;
            txtsNoiDung.Text = Convert.ToString(_tblCuocHenEO.sNoiDung);
            txtsDiaDiem.Text = Convert.ToString(_tblCuocHenEO.sDiaDiem);
            txttNgayGioBatDau.Text = (_tblCuocHenEO.tNgayGioBatDau == DateTime.MinValue) ? DateTime.Now.ToString() : Convert.ToString(_tblCuocHenEO.tNgayGioBatDau);
            txttNgayGioKetThuc.Text = (_tblCuocHenEO.tNgayGioKetThuc == DateTime.MinValue) ? DateTime.Now.ToString() : Convert.ToString(_tblCuocHenEO.tNgayGioKetThuc);
            txtiTrangThai.Text = GetTextConstants.CuocHen_iTrangThai_GTC(_tblCuocHenEO.iTrangThai);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            objtblCuocHenEO.iTrangThai = CuocHen_iTrangThai_C.Tat_Nhac_Nho;
            if(tblCuocHenDAO.CuocHen_Update(objtblCuocHenEO)==true){
                this.Close();
            }
            else{
                lblMsg.Text = Messages.Sua_That_Bai;
            }
        }

        private void grvCuocHen_SelectionChanged(object sender, EventArgs e)
        {
            tblCuocHenEO _tblCuocHenEO = new tblCuocHenEO();
            foreach (DataGridViewRow row in grvCuocHen.SelectedRows)
            {
                _tblCuocHenEO.PK_lCuocHen = Convert.ToInt64(row.Cells[0].Value);
                _tblCuocHenEO.FK_iNguoiDung = Convert.ToInt32(row.Cells[1].Value);
                _tblCuocHenEO.FK_iDoiTac = Convert.ToInt32(row.Cells[2].Value);
                _tblCuocHenEO.sNoiDung = row.Cells[3].Value.ToString();
                _tblCuocHenEO.sDiaDiem = row.Cells[4].Value.ToString();
                _tblCuocHenEO.tNgayGioBatDau = Convert.ToDateTime(row.Cells[5].Value);
                _tblCuocHenEO.tNgayGioKetThuc = Convert.ToDateTime(row.Cells[6].Value);
                _tblCuocHenEO.iTrangThai = Convert.ToInt16(row.Cells[7].Value);
            }
            BindDataDetail(_tblCuocHenEO);
        }

        private void frmThongBao_Load(object sender, EventArgs e)
        {
        }
    }
}
