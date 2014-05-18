using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using HaBa.DataAccessObject;
using HaBa.App_Data;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.Web;
using System.Configuration;
using System.Data.SqlClient;

namespace HaBa.Report
{
    public partial class BaoCao_HoaDon : System.Web.UI.Page
    {
        private dsHaBa _dsHaBa;
        public dsHaBa dsHaBa_Common
        {
            get { return this._dsHaBa; }
            set { _dsHaBa = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["PK_lHoaDonID"] != null)
            {
                dsHaBa_Common = new dsHaBa();
                Int64 PK_lHoaDonID = Convert.ToInt64(Request.QueryString["PK_lHoaDonID"]);
                ReportDocument crystalReport = new ReportDocument();
                crystalReport.Load(Server.MapPath("~/Report/HoaDonRP.rpt"));
                GetDataHoaDon("select * from tblHoaDon where PK_lHoaDonID = " + PK_lHoaDonID);
                GetDataChiTietHoaDon("select * from tblChiTietHoaDon where FK_lHoaDonID = " + PK_lHoaDonID);
                crystalReport.SetDataSource(_dsHaBa);
                crvHoaDon.ReportSource = crystalReport;
            }
        }

        private void GetDataHoaDon(string query)
        {
            string conString = ConfigurationManager.ConnectionStrings["connectdb_internet"].ConnectionString;
            SqlCommand cmd = new SqlCommand(query);
            using (SqlConnection con = new SqlConnection(conString))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter())
                {
                    cmd.Connection = con;

                    sda.SelectCommand = cmd;
                    sda.Fill(dsHaBa_Common, "tblHoaDon");
                }
            }
        }

        private void GetDataChiTietHoaDon(string query)
        {
            string conString = ConfigurationManager.ConnectionStrings["connectdb_internet"].ConnectionString;
            SqlCommand cmd = new SqlCommand(query);
            using (SqlConnection con = new SqlConnection(conString))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter())
                {
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    sda.Fill(dsHaBa_Common, "tblChiTietHoaDon");
                }
            }
        }
    }
}