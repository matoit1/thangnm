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
    public partial class GiangVien_ListUC : System.Web.UI.UserControl
    {
        #region "Properties & Event"
        public event EventHandler ViewDetail;
        public event EventHandler SelectRow;
        public event EventHandler AddNew;
        public event EventHandler Search;

        private string _PK_sMaGV;
        public string PK_sMaGV
        {
            get { return this._PK_sMaGV; }
            set { _PK_sMaGV = value; }
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
            grvListGiangVien.Visible = false;
            DataSet dsGiangVien = new DataSet();
            try
            {
                dsGiangVien = GiangVienDAO.GiangVien_SelectList();
                if (Convert.ToInt32(dsGiangVien.Tables[0].Rows.Count.ToString()) > 0)
                {
                    grvListGiangVien.Visible = true;
                    grvListGiangVien.DataSource = dsGiangVien;
                    grvListGiangVien.DataBind();
                    lblTongSoBanGhi.Text = Messages.Tong_So_Ban_Ghi + dsGiangVien.Tables[0].Rows.Count.ToString();
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
        protected void grvListGiangVien_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "cmdView")
            {
                this.PK_sMaGV = Convert.ToString(e.CommandArgument);
                if (ViewDetail != null)
                {
                    ViewDetail(this, EventArgs.Empty);
                }
            }
        }

        protected void grvListGiangVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (GridViewRow row in grvListGiangVien.Rows)
            {
                if (row.RowIndex == grvListGiangVien.SelectedIndex)
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

        protected void grvListGiangVien_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grvListGiangVien.PageIndex = e.NewPageIndex;
            BindData();
        }

        protected void grvListGiangVien_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(grvListGiangVien, "Select$" + e.Row.RowIndex);
                e.Row.ToolTip = "Click to select this row.";
            }
        }

        protected void grvListGiangVien_Sorting(object sender, GridViewSortEventArgs e)
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
            DataSet dsGiangVien = GiangVienDAO.GiangVien_SelectList();
            DataView sortedView = new DataView(dsGiangVien.Tables[0]);
            sortedView.Sort = e.SortExpression + " " + sortingDirection;
            Session["objects"] = sortedView;
            grvListGiangVien.DataSource = sortedView;
            grvListGiangVien.DataBind();
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
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            if (Search != null)
            {
                Search(this, EventArgs.Empty);
            }
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
                grvListGiangVien.AllowPaging = false;
                this.BindData();

                grvListGiangVien.HeaderRow.BackColor = Color.White;
                foreach (TableCell cell in grvListGiangVien.HeaderRow.Cells)
                {
                    cell.BackColor = grvListGiangVien.HeaderStyle.BackColor;
                }
                foreach (GridViewRow row in grvListGiangVien.Rows)
                {
                    row.BackColor = Color.White;
                    foreach (TableCell cell in row.Cells)
                    {
                        if (row.RowIndex % 2 == 0)
                        {
                            cell.BackColor = grvListGiangVien.AlternatingRowStyle.BackColor;
                        }
                        else
                        {
                            cell.BackColor = grvListGiangVien.RowStyle.BackColor;
                        }
                        cell.CssClass = "textmode";
                    }
                }

                grvListGiangVien.RenderControl(hw);
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