using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using DataAccessObject;
using EntityObject;
using Shared_Libraries;
using System.Data;

namespace DO_AN_TN.UserControl
{
    public partial class MonHoc_ListUC : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindData();
        }

        protected void BindData()
        {
            grvListMonHoc.Visible = false;
            MonHocEO _MonHocEO = new MonHocEO();
            DataSet dsMonHoc = new DataSet();
            try
            {
                dsMonHoc = MonHocDAO.MonHoc_SelectList(_MonHocEO);
                if (Convert.ToInt32(dsMonHoc.Tables[0].Rows.Count.ToString()) > 0)
                {
                    grvListMonHoc.Visible = true;
                    grvListMonHoc.DataSource = dsMonHoc;
                    grvListMonHoc.DataBind();
                    lblTongSoBanGhi.Text = Messages.Tong_So_Ban_Ghi + dsMonHoc.Tables[0].Rows.Count.ToString();
                }
                else
                {
                    lblTongSoBanGhi.Text = Messages.Khong_Thoa_Man_Dieu_Kien_Tim_Kiem;
                }
            }
            catch (Exception ex)
            {
                lblTongSoBanGhi.Text = Messages.Loi + ex.Message;
            }
        }

        protected void grvListMonHoc_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }

        protected void grvListMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (GridViewRow row in grvListMonHoc.Rows)
            {
                if (row.RowIndex == grvListMonHoc.SelectedIndex)
                {
                    row.BackColor = ColorTranslator.FromHtml("#A1DCF2");
                    row.ToolTip = string.Empty;
                }
                else
                {
                    row.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                    row.ToolTip = "Click to select this row.";
                }
            }
            try
            {
                //BindInfo(Convert.ToInt64(grvListMonHoc.DataKeys[grvListMonHoc.SelectedIndex].Values["Accounts_ID"]));
            }
            catch (Exception)
            {
            }
        }

        protected void grvListMonHoc_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grvListMonHoc.PageIndex = e.NewPageIndex;
            BindData();
        }

        protected void grvListMonHoc_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(grvListMonHoc, "Select$" + e.Row.RowIndex);
                e.Row.ToolTip = "Click to select this row.";
            }
        }

        protected void grvListMonHoc_Sorting(object sender, GridViewSortEventArgs e)
        {
            string sortingDirection = string.Empty;
            if (direction == SortDirection.Ascending)
            {
                direction = SortDirection.Descending;
                sortingDirection = "Desc";
            }
            else
            {
                direction = SortDirection.Ascending;
                sortingDirection = "Asc";
            }
            MonHocEO _MonHocEO = new MonHocEO();
            DataSet dsMonHoc = MonHocDAO.MonHoc_SelectList(_MonHocEO);
            DataView sortedView = new DataView(dsMonHoc.Tables[0]);
            sortedView.Sort = e.SortExpression + " " + sortingDirection;
            Session["objects"] = sortedView;
            grvListMonHoc.DataSource = sortedView;
            grvListMonHoc.DataBind();
        }

        public SortDirection direction
        {
            get
            {
                if (ViewState["directionState"] == null)
                {
                    ViewState["directionState"] = SortDirection.Ascending;
                }
                return (SortDirection)ViewState["directionState"];
            }
            set
            { ViewState["directionState"] = value; }
        }
    }
}