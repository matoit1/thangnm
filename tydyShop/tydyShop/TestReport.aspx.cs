using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using System.Configuration;
using tydyShop.App_Data;

namespace tydyShop
{
    public partial class TestReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["lGroup"] != null)
            {
                Int64 lGroup = Convert.ToInt64(Request.QueryString["lGroup"]);
                ReportDocument crystalReport = new ReportDocument();
                crystalReport.Load(Server.MapPath("~/BaoCao_SanPham.rpt"));
                Demo dsCustomers = GetData("select * from tblProduct where lGroup =" + lGroup);
                crystalReport.SetDataSource(dsCustomers);
                CrystalReportViewer1.ReportSource = crystalReport;
            }
        }

        private Demo GetData(string query)
        {
            string conString = ConfigurationManager.ConnectionStrings["connectdb_x64"].ConnectionString;
            SqlCommand cmd = new SqlCommand(query);
            using (SqlConnection con = new SqlConnection(conString))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter())
                {
                    cmd.Connection = con;

                    sda.SelectCommand = cmd;
                    using (Demo dsCustomers = new Demo())
                    {
                        sda.Fill(dsCustomers, "tblProduct");
                        return dsCustomers;
                    }
                }
            }
        }
    }
}