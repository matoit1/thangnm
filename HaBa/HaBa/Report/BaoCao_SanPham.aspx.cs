using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using CrystalDecisions.CrystalReports.Engine;
using HaBa.App_Data;
using HaBa.DataAccessObject;
using HaBa.SharedLibraries;

namespace HaBa.Report
{
    public partial class BaoCao_SanPham : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                ReportDocument crystalReport = new ReportDocument();
                crystalReport.Load(Server.MapPath("~/Report/SanPhamRP.rpt"));
                DataSet dsHaBa = new DataSet();
                DataTable dttblSanPham = new DataTable();
                dttblSanPham = tblSanPhamDAO.SanPham_SelectList().Tables[0];
                dttblSanPham.Columns.Add(new DataColumn("FK_iNhomSanPhamID_Text", Type.GetType("System.String")));
                dttblSanPham.Columns.Add(new DataColumn("iDoTuoi_Text", Type.GetType("System.String")));
                dttblSanPham.Columns.Add(new DataColumn("iGioiTinh_Text", Type.GetType("System.String")));
                dttblSanPham.Columns.Add(new DataColumn("iTrangThai_Text", Type.GetType("System.String")));
                foreach (DataRow dr in dttblSanPham.Rows)
                {
                    dr["FK_iNhomSanPhamID_Text"] = tblNhomSanPhamDAO.NhomSanPham_SelectItem_By_PK_iNhomSanPhamID(Convert.ToInt16(dr["FK_iNhomSanPhamID"])).sTenNhom;
                    dr["iDoTuoi_Text"] = GetTextConstants.SanPham_iDoTuoi_GTC(Convert.ToInt16(dr["iDoTuoi"]));
                    dr["iGioiTinh_Text"] = GetTextConstants.SanPham_iGioiTinh_GTC(Convert.ToInt16(dr["iGioiTinh"]));
                    dr["iTrangThai_Text"] = GetTextConstants.HoaDon_iTrangThai_GTC(Convert.ToInt16(dr["iTrangThai"]));
                }
                dttblSanPham.TableName = "tblSanPham";
                dsHaBa.Tables.Add(dttblSanPham.Copy());
                crystalReport.SetDataSource(dsHaBa);
                crvSanPham.ReportSource = crystalReport;
            }
            catch (Exception ex) {lblMsg.Text = ex.Message; }
        }
    }
}