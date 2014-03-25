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
    public partial class BaiViet_ListUC : System.Web.UI.UserControl
    {
        #region "Properties & Event"
        public event EventHandler ViewDetail;
        public event EventHandler SelectRow;
        public event EventHandler AddNew;
        public event EventHandler Search;

        private Int64 _PK_lMaBaiViet;
        public Int64 PK_lMaBaiViet
        {
            get { return this._PK_lMaBaiViet; }
            set { _PK_lMaBaiViet = value; }
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
            grvListBaiViet.Visible = false;
            DataSet dsBaiViet = new DataSet();
            try
            {
                dsBaiViet = BaiVietDAO.BaiViet_SelectList();
                if (Convert.ToInt32(dsBaiViet.Tables[0].Rows.Count.ToString()) > 0)
                {
                    grvListBaiViet.Visible = true;
                    grvListBaiViet.DataSource = dsBaiViet;
                    grvListBaiViet.DataBind();
                    lblTongSoBanGhi.Text = Messages.Tong_So_Ban_Ghi + dsBaiViet.Tables[0].Rows.Count.ToString();
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
        protected void grvListBaiViet_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "cmdView")
            {
                this.PK_lMaBaiViet = Convert.ToInt64(e.CommandArgument);
                if (ViewDetail != null)
                {
                    ViewDetail(this, EventArgs.Empty);
                }
            }
        }

        protected void grvListBaiViet_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (GridViewRow row in grvListBaiViet.Rows)
            {
                if (row.RowIndex == grvListBaiViet.SelectedIndex)
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

        protected void grvListBaiViet_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grvListBaiViet.PageIndex = e.NewPageIndex;
            BindData();
        }

        protected void grvListBaiViet_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(grvListBaiViet, "Select$" + e.Row.RowIndex);
                e.Row.ToolTip = "Click to select this row.";
            }
        }

        protected void grvListBaiViet_Sorting(object sender, GridViewSortEventArgs e)
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
            DataSet dsBaiViet = BaiVietDAO.BaiViet_SelectList();
            DataView sortedView = new DataView(dsBaiViet.Tables[0]);
            sortedView.Sort = e.SortExpression + " " + sortingDirection;
            Session["objects"] = sortedView;
            grvListBaiViet.DataSource = sortedView;
            grvListBaiViet.DataBind();
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
                grvListBaiViet.AllowPaging = false;
                this.BindData();

                grvListBaiViet.HeaderRow.BackColor = Color.White;
                foreach (TableCell cell in grvListBaiViet.HeaderRow.Cells)
                {
                    cell.BackColor = grvListBaiViet.HeaderStyle.BackColor;
                }
                foreach (GridViewRow row in grvListBaiViet.Rows)
                {
                    row.BackColor = Color.White;
                    foreach (TableCell cell in row.Cells)
                    {
                        if (row.RowIndex % 2 == 0)
                        {
                            cell.BackColor = grvListBaiViet.AlternatingRowStyle.BackColor;
                        }
                        else
                        {
                            cell.BackColor = grvListBaiViet.RowStyle.BackColor;
                        }
                        cell.CssClass = "textmode";
                    }
                }

                grvListBaiViet.RenderControl(hw);
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