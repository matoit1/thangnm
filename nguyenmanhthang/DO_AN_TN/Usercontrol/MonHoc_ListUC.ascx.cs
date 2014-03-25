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
using System.Text;
using System.IO;

namespace DO_AN_TN.UserControl
{
    public partial class MonHoc_ListUC : System.Web.UI.UserControl
    {
#region "Properties & Event"
        public event EventHandler ViewDetail;
        public event EventHandler SelectRow;
        public event EventHandler AddNew;
        public event EventHandler Search;

        private string _PK_sMaMonhoc;
        public string PK_sMaMonhoc
        {
            get { return this._PK_sMaMonhoc; }
            set { _PK_sMaMonhoc = value; }
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
            grvListMonHoc.Visible = false;
            DataSet dsMonHoc = new DataSet();
            try
            {
                dsMonHoc = MonHocDAO.MonHoc_SelectList();
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
            if (e.CommandName == "cmdView")
            {
                this.PK_sMaMonhoc = Convert.ToString(e.CommandArgument);
                if (ViewDetail != null)
                {
                    ViewDetail(this, EventArgs.Empty);
                }
            }
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
            //if (SelectRow != null)
            //{
            //    PK_sMaMonhoc = grvListMonHoc.DataKeys[grvListMonHoc.SelectedIndex].Values["PK_sMaMonhoc"].ToString();
            //    SelectRow(this, EventArgs.Empty);
            //}
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
                sortingDirection = "DESC";
            }
            else
            {
                direction = SortDirection.Ascending;
                sortingDirection = "ASC";
            }
            DataSet dsMonHoc = MonHocDAO.MonHoc_SelectList();
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

        protected void Navigation_Click(object sender, EventArgs e)
        {
            //if (LoginUC1.state == true) { Response.Redirect(Request.Url.AbsolutePath); } else { Response.Redirect("~/Accounts/Login.aspx"); }
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            if (AddNew != null)
            {
                AddNew(this, EventArgs.Empty);
            }
        }

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

        protected void btnExportExcel_Click(object sender, EventArgs e)
        {
            string FileName = "Danh_sach_Mon_Hoc(" + Messages.DateTime_Temp + ").xls";
            ExportToExcel(FileName);
        }

        //public void ExportToExcel(string fileName)
        //{
        //    Response.ContentType = "application/csv";
        //    Response.Charset = "";
        //    Response.AddHeader("Content-Disposition", "attachment;filename=" + fileName);
        //    Response.ContentEncoding = Encoding.Unicode;
        //    Response.BinaryWrite(Encoding.Unicode.GetPreamble());
        //    DataTable dtb = MonHocDAO.MonHoc_SelectList().Tables[0];
        //    try
        //    {
        //        StringBuilder sb = new StringBuilder();
        //        //Tạo dòng tiêu để cho bảng tính
        //        for (int count = 0; count < dtb.Columns.Count; count++)
        //        {
        //            if (dtb.Columns[count].ColumnName != null)
        //                sb.Append(dtb.Columns[count].ColumnName);
        //            if (count < dtb.Columns.Count - 1)
        //            {
        //                sb.Append("\t");
        //            }
        //        }
        //        Response.Write(sb.ToString() + "\n");
        //        Response.Flush();
        //        //Duyệt từng bản ghi 
        //        int soDem = 0;
        //        while (dtb.Rows.Count >= soDem + 1)
        //        {
        //            sb = new StringBuilder();

        //            for (int col = 0; col < dtb.Columns.Count - 1; col++)
        //            {
        //                if (dtb.Rows[soDem][col] != null)
        //                    sb.Append(dtb.Rows[soDem][col].ToString().Replace(",", " "));
        //                sb.Append("\t");
        //            }
        //            if (dtb.Rows[soDem][dtb.Columns.Count - 1] != null)
        //                sb.Append(dtb.Rows[soDem][dtb.Columns.Count - 1].ToString().Replace(",", " "));

        //            Response.Write(sb.ToString() + "\n");
        //            Response.Flush();
        //            soDem = soDem + 1;
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        Response.Write(ex.Message);
        //    }
        //    dtb.Dispose();
        //    Response.End();
        //}



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
                grvListMonHoc.AllowPaging = false;
                this.BindData();

                grvListMonHoc.HeaderRow.BackColor = Color.White;
                foreach (TableCell cell in grvListMonHoc.HeaderRow.Cells)
                {
                    cell.BackColor = grvListMonHoc.HeaderStyle.BackColor;
                }
                foreach (GridViewRow row in grvListMonHoc.Rows)
                {
                    row.BackColor = Color.White;
                    foreach (TableCell cell in row.Cells)
                    {
                        if (row.RowIndex % 2 == 0)
                        {
                            cell.BackColor = grvListMonHoc.AlternatingRowStyle.BackColor;
                        }
                        else
                        {
                            cell.BackColor = grvListMonHoc.RowStyle.BackColor;
                        }
                        cell.CssClass = "textmode";
                    }
                }

                grvListMonHoc.RenderControl(hw);

                //style to format numbers to string
                string style = @"<style> .textmode { } </style>";
                Response.Write(style);
                Response.Output.Write(sw.ToString());
                Response.Flush();
                Response.End();
            }
        }

        protected void btnDeleteList_Click(object sender, EventArgs e)
        {

        }
    }
}