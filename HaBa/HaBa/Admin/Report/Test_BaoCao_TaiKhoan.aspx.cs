using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using HaBa.DataAccessObject;
using CrystalDecisions.CrystalReports.Engine;
using HaBa.App_Data;
using System.Data.SqlClient;
using System.Configuration;

namespace HaBa.Report
{
    public partial class Test_BaoCao_TaiKhoan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {try
            {
            ReportDocument crystalReport = new ReportDocument();
            crystalReport.Load(Server.MapPath("~/Report/TaiKhoanRP.rpt"));
            //dsHaBa _dsHaBa = GetData("select * from tblTaiKhoan");
            DataSet _dsHaBa = tblTaiKhoanDAO.TaiKhoan_SelectList();
            _dsHaBa.Tables[0].TableName = "tblTaiKhoan";
            crystalReport.SetDataSource(_dsHaBa);
            crvTaiKhoan.ReportSource = crystalReport;
            }
        catch { }
        }
    }
}