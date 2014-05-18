﻿using System;
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
    public partial class BaoCao_TaiKhoan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ReportDocument crystalReport = new ReportDocument();
            crystalReport.Load(Server.MapPath("~/Report/TaiKhoanRP.rpt"));
            dsHaBa _dsHaBa = GetData("select * from tblTaiKhoan");
            crystalReport.SetDataSource(_dsHaBa);
            crvTaiKhoan.ReportSource = crystalReport;
        }

        private dsHaBa GetData(string query)
        {
            string conString = ConfigurationManager.ConnectionStrings["connectdb_internet"].ConnectionString;
            SqlCommand cmd = new SqlCommand(query);
            using (SqlConnection con = new SqlConnection(conString))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter())
                {
                    cmd.Connection = con;

                    sda.SelectCommand = cmd;
                    using (dsHaBa _dsHaBa = new dsHaBa())
                    {
                        sda.Fill(_dsHaBa, "tblTaiKhoan");
                        return _dsHaBa;
                    }
                }
            }
        }
    }
}