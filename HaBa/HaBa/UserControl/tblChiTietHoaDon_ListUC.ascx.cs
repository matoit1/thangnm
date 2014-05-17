using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.IO;
using HaBa.SharedLibraries;
using System.Data;
using HaBa.DataAccessObject;

namespace HaBa.UserControl
{
    public partial class tblChiTietHoaDon_ListUC : System.Web.UI.UserControl
    {
        #region "Properties & Event"
        public event EventHandler ViewDetail;
        public event EventHandler SelectRow;
        public event EventHandler AddNew;

        private Int64 _FK_lHoaDonID;
        public Int64 FK_lHoaDonID
        {
            get { return this._FK_lHoaDonID; }
            set { _FK_lHoaDonID = value; }
        }
        private string _FK_sSanPhamID;
        public string FK_sSanPhamID
        {
            get { return this._FK_sSanPhamID; }
            set { _FK_sSanPhamID = value; }
        }

        public string typesearch
        {
            get { return (string)ViewState["typesearch"]; }
            set { ViewState["typesearch"] = value; }
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
            grvListChiTietHoaDon.Visible = false;
            string keysearch = txtTextSearch.Text;
            DataSet dsBaiViet = new DataSet();
            try
            {
                dsBaiViet = tblChiTietHoaDonDAO.ChiTietHoaDon_SelectList();
                //var result = DataSet2LinQ.BaiViet(dsBaiViet);
                var result =
                from topic in dsBaiViet.Tables[0].AsEnumerable()
                select new
                {
                    FK_lHoaDonID = topic.Field<string>("FK_lHoaDonID"),
                    FK_sSanPhamID = topic.Field<Int64>("FK_sSanPhamID"),
                    lGiaBan = topic.Field<string>("lGiaBan"),
                    iSoLuong = topic.Field<string>("iSoLuong")
                };
                ddlTypeSearch.SelectedValue = typesearch;
                if (Convert.ToInt16(ddlTypeSearch.SelectedValue) == 0)
                {
                    if (keysearch != "")
                    {
                        var search = (from item in result where item.FK_lHoaDonID.ToString().ToUpper().Contains(keysearch.ToString().ToUpper().Trim()) select item);
                        result = search;
                    }
                }
                else
                {
                    if (keysearch != "")
                    {
                        var search = (from item in result where item.FK_sSanPhamID.ToString().ToUpper().Contains(keysearch.ToString().ToUpper().Trim()) select item);
                        result = search;
                    }
                }
                if (result.Count() > 0)
                {
                    grvListChiTietHoaDon.Visible = true;
                    grvListChiTietHoaDon.DataSource = result.ToList();
                    grvListChiTietHoaDon.DataBind();
                    lblTongSoBanGhi.Text = Messages.Tong_So_Ban_Ghi + result.Count();
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
        protected void grvListChiTietHoaDon_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "cmdView")
            {
                GridViewRow row = this.grvListChiTietHoaDon.SelectedRow;
                int index = Convert.ToInt16(e.CommandArgument) % grvListChiTietHoaDon.PageSize;
                this.FK_lHoaDonID = Convert.ToInt64(grvListChiTietHoaDon.DataKeys[index].Values["FK_lHoaDonID"]);
                this.FK_sSanPhamID = Convert.ToString(grvListChiTietHoaDon.DataKeys[index].Values["FK_sSanPhamID"]);
                if (ViewDetail != null)
                {
                    ViewDetail(this, EventArgs.Empty);
                }
            }
        }

        protected void grvListChiTietHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (GridViewRow row in grvListChiTietHoaDon.Rows)
            {
                if (row.RowIndex == grvListChiTietHoaDon.SelectedIndex)
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

        protected void grvListChiTietHoaDon_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grvListChiTietHoaDon.PageIndex = e.NewPageIndex;
            BindData();
        }

        protected void grvListChiTietHoaDon_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(grvListChiTietHoaDon, "Select$" + e.Row.RowIndex);
                e.Row.ToolTip = "Click to select this row.";
            }
        }

        protected void grvListChiTietHoaDon_Sorting(object sender, GridViewSortEventArgs e)
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
            DataSet dsBaiViet = tblChiTietHoaDonDAO.ChiTietHoaDon_SelectList();
            DataView sortedView = new DataView(dsBaiViet.Tables[0]);
            sortedView.Sort = e.SortExpression + " " + sortingDirection;
            Session["objects"] = sortedView;
            grvListChiTietHoaDon.DataSource = sortedView;
            grvListChiTietHoaDon.DataBind();
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
            string FileName = "Danh_sach_Bai_Viet(" + Messages.Format_DateTime_Temp + ").xls";
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
                grvListChiTietHoaDon.AllowPaging = false;
                this.BindData();

                grvListChiTietHoaDon.HeaderRow.BackColor = Color.White;
                foreach (TableCell cell in grvListChiTietHoaDon.HeaderRow.Cells)
                {
                    cell.BackColor = grvListChiTietHoaDon.HeaderStyle.BackColor;
                }
                foreach (GridViewRow row in grvListChiTietHoaDon.Rows)
                {
                    row.BackColor = Color.White;
                    foreach (TableCell cell in row.Cells)
                    {
                        if (row.RowIndex % 2 == 0)
                        {
                            cell.BackColor = grvListChiTietHoaDon.AlternatingRowStyle.BackColor;
                        }
                        else
                        {
                            cell.BackColor = grvListChiTietHoaDon.RowStyle.BackColor;
                        }
                        cell.CssClass = "textmode";
                    }
                }

                grvListChiTietHoaDon.RenderControl(hw);
                //style to format numbers to string
                string style = @"<style> .textmode { } </style>";
                Response.Write(style);
                Response.Output.Write(sw.ToString());
                Response.Flush();
                Response.End();
            }
        }
        #endregion

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            BindData();
        }

        protected void ddlTypeSearch_TextChanged(object sender, EventArgs e)
        {
            typesearch = ddlTypeSearch.SelectedValue;
        }
    }
}