using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using HaBa.DataAccessObject;
using HaBa.Report;
using HaBa.EntityObject;

namespace HaBa.UserControl
{
    public partial class ReportUC : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Page_Init(object sender, EventArgs e)
        {
            try
            {
                ShowReport(Convert.ToInt64(Request.QueryString["PK_sSanPhamID"]));
                crvReport.Attributes.Add("onclick", "window.setTimeout(function() { _spFormOnSubmitCalled = false; }, 10);");
            }
            catch { }
        }

        private void ShowReport(Int64 _PK_sSanPhamID)
        {
            try 
	        {	        
		        crvReport.HasCrystalLogo = false;
                crvReport.HasSearchButton = false;
                crvReport.HasToggleGroupTreeButton = false;
                crvReport.ToolPanelView = CrystalDecisions.Web.ToolPanelViewType.None;
                crvReport.Zoom(100);
                DataSet ds = tblSanPhamDAO.SanPham_SelectList();
                SanPhamRP _SanPhamRP = new SanPhamRP();
                _SanPhamRP.SetDataSource(ds);
                crvReport.ReportSource = _SanPhamRP;
                crvReport.DataBind();
	        }
	        catch (Exception)
	        {
		
		        throw;
	        }
        
        }

    //    private Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
    //    ShowReport(CLng(Request.QueryString("TK")))
    //    crViewer.Attributes.Add("onclick", "window.setTimeout(function() { _spFormOnSubmitCalled = false; }, 10);")

    //End Sub

    //Public Sub ShowReport(ByVal TK_ID As Int64)
    //    Try
    //    crViewer.HasCrystalLogo = False
    //    crViewer.HasSearchButton = False
    //    crViewer.HasToggleGroupTreeButton = False
    //    crViewer.ToolPanelView = CrystalDecisions.Web.ToolPanelViewType.None
    //    crViewer.Zoom(100)
    //    Dim ctlTk As New DTO_KHAI_MD_BC
    //    Dim ds As DataSet = ctlTk.Select_InToKhaiNhap_TheoMau(TK_ID)
    //}
    }
}