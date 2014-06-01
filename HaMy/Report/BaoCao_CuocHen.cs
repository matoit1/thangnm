using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HaMy.DataAccessObject;
using CrystalDecisions.CrystalReports.Engine;
using System.IO;
using HaBa.SharedLibraries;
using HaMy.EntityObject;

namespace HaMy.Report
{
    public partial class frmBaoCao_CuocHen : Form
    {
        public frmBaoCao_CuocHen()
        {
            InitializeComponent();
        }

        private void frmBaoCao_CuocHen_Load(object sender, EventArgs e)
        {
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            tblCuocHenEO _tblCuocHenEO = new tblCuocHenEO();
            _tblCuocHenEO.tNgayGioBatDau = Convert.ToDateTime(dpktNgayGioBatDau.Text);
            _tblCuocHenEO.tNgayGioKetThuc = Convert.ToDateTime(dpktNgayGioKetThuc.Text);
            DataTable dt = tblCuocHenDAO.CuocHen_Search(_tblCuocHenEO).Tables[0];

            ReportDocument crystalReport = new ReportDocument();
            crystalReport.Load(System.IO.Directory.GetCurrentDirectory().Replace("bin\\Debug", "") + "Report/CuocHen.rpt");
            //DataTable dt = tblCuocHenDAO.CuocHen_SelectList().Tables[0];
            dt.Columns.Add(new DataColumn("FK_iNguoiDung_Text", Type.GetType("System.String")));
            dt.Columns.Add(new DataColumn("FK_iDoiTac_Text", Type.GetType("System.String")));
            dt.Columns.Add(new DataColumn("iTrangThai_Text", Type.GetType("System.String")));

            foreach (DataRow dr in dt.Rows)
            {
                tblDoiTacEO _tblDoiTacEO = new tblDoiTacEO();
                _tblDoiTacEO.PK_iDoiTac = Convert.ToInt32(dr["FK_iDoiTac"]);
                dr["FK_iNguoiDung_Text"] = tblNguoiDungDAO.NguoiDung_SelectItemPK_iNguoiDung(Convert.ToInt32(dr["FK_iNguoiDung"])).sHoTen;
                dr["FK_iDoiTac_Text"] = tblDoiTacDAO.DoiTac_SelectItem(_tblDoiTacEO).sHoTen;
                dr["iTrangThai_Text"] = GetTextConstants.CuocHen_iTrangThai_GTC(Convert.ToInt16(dr["iTrangThai"]));
            }
            crystalReport.SetDataSource(dt);
            crvCuocHen.ReportSource = crystalReport;
        }
    }
}
