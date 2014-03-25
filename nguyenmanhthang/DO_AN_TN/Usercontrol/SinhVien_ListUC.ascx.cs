using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using DataAccessObject;
using EntityObject;
using System.Data;
using System.IO;
using Shared_Libraries;

namespace DO_AN_TN.UserControl
{
    public partial class SinhVien_ListUC : System.Web.UI.UserControl
    {
        #region "Properties & Event"
        public event EventHandler ViewDetail;
        public event EventHandler SelectRow;
        public event EventHandler AddNew;
        public event EventHandler Search;

        private string _PK_sMaSV;
        public string PK_sMaSV
        {
            get { return this._PK_sMaSV; }
            set { _PK_sMaSV = value; }
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
            grvListSinhVien.Visible = false;
            DataSet dsSinhVien = new DataSet();
            try
            {
                dsSinhVien = SinhVienDAO.SinhVien_SelectList();
                if (Convert.ToInt32(dsSinhVien.Tables[0].Rows.Count.ToString()) > 0)
                {
                    grvListSinhVien.Visible = true;
                    grvListSinhVien.DataSource = dsSinhVien;
                    grvListSinhVien.DataBind();
                    lblTongSoBanGhi.Text = Messages.Tong_So_Ban_Ghi + dsSinhVien.Tables[0].Rows.Count.ToString();
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
        protected void grvListSinhVien_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "cmdView")
            {
                this.PK_sMaSV = Convert.ToString(e.CommandArgument);
                if (ViewDetail != null)
                {
                    ViewDetail(this, EventArgs.Empty);
                }
            }
        }

        protected void grvListSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (GridViewRow row in grvListSinhVien.Rows)
            {
                if (row.RowIndex == grvListSinhVien.SelectedIndex)
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

        protected void grvListSinhVien_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grvListSinhVien.PageIndex = e.NewPageIndex;
            BindData();
        }

        protected void grvListSinhVien_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(grvListSinhVien, "Select$" + e.Row.RowIndex);
                e.Row.ToolTip = "Click to select this row.";
            }
        }

        protected void grvListSinhVien_Sorting(object sender, GridViewSortEventArgs e)
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
            DataSet dsSinhVien = SinhVienDAO.SinhVien_SelectList();
            DataView sortedView = new DataView(dsSinhVien.Tables[0]);
            sortedView.Sort = e.SortExpression + " " + sortingDirection;
            Session["objects"] = sortedView;
            grvListSinhVien.DataSource = sortedView;
            grvListSinhVien.DataBind();
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
            string FileName = "Danh_sach_Sinh_Vien(" + Messages.DateTime_Temp + ").xls";
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
                grvListSinhVien.AllowPaging = false;
                this.BindData();

                grvListSinhVien.HeaderRow.BackColor = Color.White;
                foreach (TableCell cell in grvListSinhVien.HeaderRow.Cells)
                {
                    cell.BackColor = grvListSinhVien.HeaderStyle.BackColor;
                }
                foreach (GridViewRow row in grvListSinhVien.Rows)
                {
                    row.BackColor = Color.White;
                    foreach (TableCell cell in row.Cells)
                    {
                        if (row.RowIndex % 2 == 0)
                        {
                            cell.BackColor = grvListSinhVien.AlternatingRowStyle.BackColor;
                        }
                        else
                        {
                            cell.BackColor = grvListSinhVien.RowStyle.BackColor;
                        }
                        cell.CssClass = "textmode";
                    }
                }

                grvListSinhVien.RenderControl(hw);
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