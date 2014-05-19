using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HaMy
{
    public partial class HomeSI : Form
    {
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
    }
}
