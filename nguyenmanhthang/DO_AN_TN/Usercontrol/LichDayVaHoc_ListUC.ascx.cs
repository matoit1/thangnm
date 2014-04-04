using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.IO;
using Shared_Libraries;
using System.Data;
using DataAccessObject;

namespace DO_AN_TN.UserControl
{
    public partial class LichDayVaHoc_ListUC : System.Web.UI.UserControl
    {
        #region "Properties & Event"
        public event EventHandler ViewDetail;
        public event EventHandler SelectRow;
        public event EventHandler AddNew;

        private string _FK_sMaPCCT;
        public string FK_sMaPCCT
        {
            get { return this._FK_sMaPCCT; }
            set { _FK_sMaPCCT = value; }
        }
        private string _FK_sMalop;
        public string FK_sMalop
        {
            get { return this._FK_sMalop; }
            set { _FK_sMalop = value; }
        }
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindData();
            }
        }

        public void BindData()
        {
            grvListLichDayVaHoc.Visible = false;
            DataSet dsLichDayVaHoc = new DataSet();
            try
            {
                dsLichDayVaHoc = LichDayVaHocDAO.LichDayVaHoc_SelectList();
                if (Convert.ToInt32(dsLichDayVaHoc.Tables[0].Rows.Count.ToString()) > 0)
                {
                    grvListLichDayVaHoc.Visible = true;
                    grvListLichDayVaHoc.DataSource = dsLichDayVaHoc;
                    grvListLichDayVaHoc.DataBind();
                    lblTongSoBanGhi.Text = Messages.Tong_So_Ban_Ghi + dsLichDayVaHoc.Tables[0].Rows.Count.ToString();
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

        #region "Event GridView"
        protected void grvListLichDayVaHoc_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "cmdView")
            {
                GridViewRow row = this.grvListLichDayVaHoc.SelectedRow;
                int index = Convert.ToInt16(e.CommandArgument) % grvListLichDayVaHoc.PageSize;
                this.FK_sMaPCCT = Convert.ToString(grvListLichDayVaHoc.DataKeys[index].Values["FK_sMaPCCT"]);
                this.FK_sMalop = Convert.ToString(grvListLichDayVaHoc.DataKeys[index].Values["FK_sMalop"]);
                if (ViewDetail != null)
                {
                    ViewDetail(this, EventArgs.Empty);
                }
            }
        }

        protected void grvListLichDayVaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (GridViewRow row in grvListLichDayVaHoc.Rows)
            {
                if (row.RowIndex == grvListLichDayVaHoc.SelectedIndex)
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
        }

        protected void grvListLichDayVaHoc_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grvListLichDayVaHoc.PageIndex = e.NewPageIndex;
            BindData();
        }

        protected void grvListLichDayVaHoc_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(grvListLichDayVaHoc, "Select$" + e.Row.RowIndex);
                e.Row.ToolTip = "Click to select this row.";
            }
        }

        protected void grvListLichDayVaHoc_Sorting(object sender, GridViewSortEventArgs e)
        {
            string sortingDirection = string.Empty;
            if (direction == SortDirection.Ascending)
            {
                direction = SortDirection.Descending;
                sortingDirection = "DESC";
            }
            else
            {
                direction = SortDirection.Ascending;
                sortingDirection = "ASC";
            }
            DataSet dsLichDayVaHoc = LichDayVaHocDAO.LichDayVaHoc_SelectList();
            DataView sortedView = new DataView(dsLichDayVaHoc.Tables[0]);
            sortedView.Sort = e.SortExpression + " " + sortingDirection;
            Session["objects"] = sortedView;
            grvListLichDayVaHoc.DataSource = sortedView;
            grvListLichDayVaHoc.DataBind();
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
        #endregion

        #region "Event Button"
        protected void Search_Click(object sender, EventArgs e)
        {
            BindData();
        }

        protected void btnRefresh_Click(object sender, EventArgs e)
        {
            BindData();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            if (AddNew != null)
            {
                AddNew(this, EventArgs.Empty);
            }
        }

        protected void btnDeleteList_Click(object sender, EventArgs e)
        {

        }

        protected void btnExportExcel_Click(object sender, EventArgs e)
        {
            string FileName = "Danh_sach_Bai_Viet(" + Messages.DateTime_Temp + ").xls";
            ExportToExcel(FileName);
        }

        protected void ExportToExcel(string fileName)
        {
            Response.Clear();
            Response.Buffer = true;
            Response.AddHeader("Content-Disposition", "attachment;filename=" + fileName);
            Response.Charset = "";
            Response.ContentType = "application/vnd.ms-excel";
            using (StringWriter sw = new StringWriter())
            {
                HtmlTextWriter hw = new HtmlTextWriter(sw);
                //To Export all pages
                grvListLichDayVaHoc.AllowPaging = false;
                this.BindData();

                grvListLichDayVaHoc.HeaderRow.BackColor = Color.White;
                foreach (TableCell cell in grvListLichDayVaHoc.HeaderRow.Cells)
                {
                    cell.BackColor = grvListLichDayVaHoc.HeaderStyle.BackColor;
                }
                foreach (GridViewRow row in grvListLichDayVaHoc.Rows)
                {
                    row.BackColor = Color.White;
                    foreach (TableCell cell in row.Cells)
                    {
                        if (row.RowIndex % 2 == 0)
                        {
                            cell.BackColor = grvListLichDayVaHoc.AlternatingRowStyle.BackColor;
                        }
                        else
                        {
                            cell.BackColor = grvListLichDayVaHoc.RowStyle.BackColor;
                        }
                        cell.CssClass = "textmode";
                    }
                }

                grvListLichDayVaHoc.RenderControl(hw);
                //style to format numbers to string
                string style = @"<style> .textmode { } </style>";
                Response.Write(style);
                Response.Output.Write(sw.ToString());
                Response.Flush();
                Response.End();
            }
        }
        #endregion
    }
}