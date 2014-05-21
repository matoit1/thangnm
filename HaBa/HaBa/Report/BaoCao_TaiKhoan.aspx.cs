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
    public partial class BaoCao_TaiKhoan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                ReportDocument crystalReport = new ReportDocument();
                crystalReport.Load(Server.MapPath("~/Report/TaiKhoanRP.rpt"));
                DataSet dsHaBa = new DataSet();
                DataTable dttblTaiKhoan = new DataTable();
                dttblTaiKhoan = tblTaiKhoanDAO.TaiKhoan_SelectList().Tables[0];
                dttblTaiKhoan.Columns.Add(new DataColumn("iQuyenHan_Text", Type.GetType("System.String")));
                dttblTaiKhoan.Columns.Add(new DataColumn("iTrangThai_Text", Type.GetType("System.String")));
                foreach (DataRow dr in dttblTaiKhoan.Rows)
                {
                    dr["iQuyenHan_Text"] = GetTextConstants.TaiKhoan_iTrangThai_GTC(Convert.ToInt16(dr["iQuyenHan"]));
                    dr["iTrangThai_Text"] = GetTextConstants.TaiKhoan_iTrangThai_GTC(Convert.ToInt16(dr["iTrangThai"]));
                }
                dttblTaiKhoan.TableName = "tblTaiKhoan";
                dsHaBa.Tables.Add(dttblTaiKhoan.Copy());
                crystalReport.SetDataSource(dsHaBa);
                crvTaiKhoan.ReportSource = crystalReport;
            }
            catch (Exception ex) { lblMsg.Text = ex.Message; }
        }
    }
}