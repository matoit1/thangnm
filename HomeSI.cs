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
using HaMy.Properties;
using System.Media;


namespace HaMy
{
    public partial class HomeSI : Form
    {
        public frmThongBao _frmThongBao = new frmThongBao();
        public HomeSI()
        {
            InitializeComponent();
        }

        private void tsmiNhom_Click(object sender, EventArgs e)
        {
            CloseAllWindowsChild();
            frmNhom _frmNhom = new frmNhom();
            _frmNhom.MdiParent = this;
            _frmNhom.Show();
        }

        private void tsmiNguoiDung_Click(object sender, EventArgs e)
        {
            CloseAllWindowsChild();
            frmNguoiDung _frmNguoiDung = new frmNguoiDung();
            _frmNguoiDung.MdiParent = this;
            _frmNguoiDung.Show();
        }

        private void tsmiMoiQuanHe_Click(object sender, EventArgs e)
        {
            CloseAllWindowsChild();
            frmMoiQuanHe _frmMoiQuanHe = new frmMoiQuanHe();
            _frmMoiQuanHe.MdiParent = this;
            _frmMoiQuanHe.Show();
        }

        private void tsmiDoiTac_Click(object sender, EventArgs e)
        {
            CloseAllWindowsChild();
            frmDoiTac _frmDoiTac = new frmDoiTac();
            _frmDoiTac.MdiParent = this;
            _frmDoiTac.Show();
        }

        private void tsmiCuocHen_Click(object sender, EventArgs e)
        {
            CloseAllWindowsChild();
            frmCuocHen _frmCuocHen = new frmCuocHen();
            _frmCuocHen.MdiParent = this;
            _frmCuocHen.Show();
        }

        private void tsmiThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void CloseAllWindowsChild()
        {
            foreach (Form chirdForm in MdiChildren)
            {
                chirdForm.Close();
            }
        }

        private void tsmiBaoCao_Click(object sender, EventArgs e)
        {
            CloseAllWindowsChild();
            //frmBaoCao_CuocHen _frmBaoCao_CuocHen = new frmBaoCao_CuocHen();
            //_frmBaoCao_CuocHen.MdiParent = this;
            //_frmBaoCao_CuocHen.Show();
        }

        private void HomeSI_Load(object sender, EventArgs e)
        {
            tCurrentDateTime.Enabled = true;
        }

        private void tCurrentDateTime_Tick(object sender, EventArgs e)
        {
            this.Text = "Phần mềm quản lý lịch hẹn - Nguyễn Thị Hà My    " + DateTime.Now.ToString();
            DataSet  ds = tblCuocHenDAO.CuocHen_SelectList_Notifycation();
            int sl = ds.Tables[0].Rows.Count;
            if(sl >0){

               //this.Show();

                Resources.ResourceManager.GetStream("Virus", Resources.Culture);
                System.IO.Stream s = Resources.ResourceManager.GetStream("Virus", Resources.Culture);
                SoundPlayer player = new SoundPlayer(s);
                player.Play();
                if (_frmThongBao.Visible == false)
                {
                    if (sl > 1)
                    {
                        _frmThongBao = new frmThongBao();
                        _frmThongBao.Show();
                        _frmThongBao.BindDataList(ds);
                    }
                    else
                    {
                        _frmThongBao = new frmThongBao();
                        _frmThongBao.Show();
                        tblCuocHenEO _tblCuocHenEO = new tblCuocHenEO();
                        _tblCuocHenEO.PK_lCuocHen = Convert.ToInt64(ds.Tables[0].Rows[0]["PK_lCuocHen"]);
                        _tblCuocHenEO = tblCuocHenDAO.CuocHen_SelectItem(_tblCuocHenEO);
                        _frmThongBao.BindDataDetail(_tblCuocHenEO);
                    }
                }
            }
        }

        private void tsmiLichHenHomNay_Click(object sender, EventArgs e)
        {
            CloseAllWindowsChild();
            frmLichHenHomNay _frmLichHenHomNay = new frmLichHenHomNay();
            _frmLichHenHomNay.MdiParent = this;
            _frmLichHenHomNay.Show();
        }
    }
}
