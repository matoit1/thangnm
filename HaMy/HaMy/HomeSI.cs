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

        private void nhomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhom _frmNhom = new frmNhom();
            _frmNhom.MdiParent = this;
            _frmNhom.Show();
            nhomToolStripMenuItem.Enabled = false;
        }

        private void nguoiDungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNguoiDung _frmNguoiDung = new frmNguoiDung();
            _frmNguoiDung.MdiParent = this;
            _frmNguoiDung.Show();
            nguoiDungToolStripMenuItem.Enabled = false;
        }

        private void moiQuanHeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMoiQuanHe _frmMoiQuanHe = new frmMoiQuanHe();
            _frmMoiQuanHe.MdiParent = this;
            _frmMoiQuanHe.Show();
            moiQuanHeToolStripMenuItem.Enabled = false;
        }

        private void doiTacToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoiTac _frmDoiTac = new frmDoiTac();
            _frmDoiTac.MdiParent = this;
            _frmDoiTac.Show();
            doiTacToolStripMenuItem.Enabled = false;
        }

        private void cuocHenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCuocHen _frmCuocHen = new frmCuocHen();
            _frmCuocHen.MdiParent = this;
            _frmCuocHen.Show();
            cuocHenToolStripMenuItem.Enabled = false;
        }

        private void closeOtherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form chirdForm in MdiChildren)
            {
                chirdForm.Close();
            }
        }
    }
}
