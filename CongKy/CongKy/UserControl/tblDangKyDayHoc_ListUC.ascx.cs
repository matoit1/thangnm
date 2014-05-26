using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Drawing;
using CongKy.SharedLibraries;
using System.IO;
using CongKy.DataAccessObject;
using CongKy.EntityObject;

namespace CongKy.UserControl
{
    public partial class tblDangKyDayHoc_ListUC : System.Web.UI.UserControl
    {
        #region "Properties & Event"
        public event EventHandler ViewDetail;
        public event EventHandler SelectRow;
        public event EventHandler AddNew;

        private Int32 _FK_iTaiKhoanID;
        public Int32 FK_iTaiKhoanID
        {
            get { return this._FK_iTaiKhoanID; }
            set { _FK_iTaiKhoanID = value; }
        }

        private Int32 _FK_iMonHocID;
        public Int32 FK_iMonHocID
        {
            get { return this._FK_iMonHocID; }
            set { _FK_iMonHocID = value; }
        }

        private DateTime _tNgayDangKy;
        public DateTime tNgayDangKy
        {
            get { return this._tNgayDangKy; }
            set { _tNgayDangKy = value; }
        }

        private Int16 _iTrangThai;
        public Int16 iTrangThai
        {
            get { return this._iTrangThai; }
            set { _iTrangThai = value; }
        }

        public string typesearch
        {
            get { return (string)ViewState["typesearch"]; }
            set { ViewState["typesearch"] = value; }
        }
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{
            //    BindData();
            //}
        }

        public void BindData(tblDangKyDayHocEO _tblDangKyDayHocEO)
        {
            //objtblDangKyDayHocEO = _tblDangKyDayHocEO;
            grvListBaiViet.Visible = false;
            string keysearch = txtTextSearch.Text;
            DataSet dsDangKyDayHoc = new DataSet();
            try
            {
                dsDangKyDayHoc = tblDangKyDayHocDAO.DangKyDayHoc_SelectList();
                dsDangKyDayHoc.Tables[0].Columns.Add(new DataColumn("FK_iTaiKhoanID_Text", Type.GetType("System.String")));
                //foreach (DataRow dr in dsDangKyDayHoc.Tables[0].Rows)
                //{
                //    dr["FK_iMonHocID_Text"] = tblDangKyDayHocDAO.DangKyDayHoc_SelectItemPK_iMonHocID(Convert.ToString(dr["FK_iMonHocID"])).FK_iMonHocID;
                //}
                //var result = DataSet2LinQ.BaiViet(dsBaiViet);
                var result =
                from topic in dsDangKyDayHoc.Tables[0].AsEnumerable()
                select new
                {
                    FK_iTaiKhoanID = topic.Field<Int32>("FK_iTaiKhoanID"),
                    FK_iMonHocID = topic.Field<Int32>("FK_iMonHocID"),
                };
                ddlTypeSearch.SelectedValue = typesearch;
                if (Convert.ToInt32(ddlTypeSearch.SelectedValue) == 0)
                {
                    if (keysearch != "")
                    {
                        var search = (from item in result where item.FK_iTaiKhoanID.ToString().ToUpper().Contains(keysearch.ToString().ToUpper().Trim()) select item);
                        result = search;
                    }
                }
                else
                {
                    if (keysearch != "")
                    {
                        var search = (from item in result where item.FK_iMonHocID.ToString().ToUpper().Contains(keysearch.ToString().ToUpper().Trim()) select item);
                        result = search;
                    }
                }
                if (result.Count() > 0)
                {
                    grvListBaiViet.Visible = true;
                    grvListBaiViet.DataSource = result.ToList();
                    grvListBaiViet.DataBind();
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
        protected void grvListBaiViet_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "cmdView")
            {
                GridViewRow row = this.grvListBaiViet.SelectedRow;
                int index = Convert.ToInt32(e.CommandArgument) % grvListBaiViet.PageSize;
                this.FK_iTaiKhoanID = Convert.ToInt32(grvListBaiViet.DataKeys[index].Values["FK_iTaiKhoanID"]);
                this.FK_iMonHocID = Convert.ToInt32(grvListBaiViet.DataKeys[index].Values["FK_iMonHocID"]);
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
            //BindData();
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
            DataSet dsBaiViet = tblDangKyDayHocDAO.DangKyDayHoc_SelectList();
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
        protected void Search_Click(object sender, EventArgs e)
        {
            //BindData();
        }

        protected void btnRefresh_Click(object sender, EventArgs e)
        {
            //BindData();
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
                grvListBaiViet.AllowPaging = false;
                //this.BindData();

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

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            //BindData();
        }

        protected void ddlTypeSearch_TextChanged(object sender, EventArgs e)
        {
            typesearch = ddlTypeSearch.SelectedValue;
        }
    }
}