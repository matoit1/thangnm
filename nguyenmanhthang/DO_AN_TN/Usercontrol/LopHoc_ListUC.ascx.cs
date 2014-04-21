using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Shared_Libraries;
using DataAccessObject;
using System.IO;
using System.Drawing;

namespace DO_AN_TN.UserControl
{
    public partial class LopHoc_ListUC : System.Web.UI.UserControl
    {
#region "Properties & Event"
        public event EventHandler ViewDetail;
        public event EventHandler SelectRow;
        public event EventHandler AddNew;

        private string _PK_sMalop;
        public string PK_sMalop
        {
            get { return this._PK_sMalop; }
            set { _PK_sMalop = value; }
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
            grvListLopHoc.Visible = false;
            string keysearch = txtTextSearch.Text;
            DataSet dsLopHoc = new DataSet();
            try
            {
                dsLopHoc = LopHocDAO.LopHoc_SelectList();
                //var result = DataSet2LinQ.BaiViet(dsBaiViet);
                var result =
                from topic in dsLopHoc.Tables[0].AsEnumerable()
                select new
                {
                    PK_sMalop = topic.Field<string>("PK_sMalop"),
                    sTenlop = topic.Field<string>("sTenlop"),
                    iNamvaotruong = topic.Field<Int16>("iNamvaotruong"),
                    iSiso = topic.Field<Int16>("iSiso"),
                    iSoNamDaoTao = topic.Field<Int16>("iSoNamDaoTao"),
                    iTrangThai = topic.Field<Int16>("iTrangThai")
                };
                ddlTypeSearch.SelectedValue = typesearch;
                if (Convert.ToInt16(ddlTypeSearch.SelectedValue) == 0)
                {
                    if (keysearch != "")
                    {
                        var search = (from item in result where item.PK_sMalop.ToString().ToUpper().Contains(keysearch.ToString().ToUpper().Trim()) select item);
                        result = search;
                    }
                }
                else
                {
                    if (keysearch != "")
                    {
                        var search = (from item in result where item.sTenlop.ToString().ToUpper().Contains(keysearch.ToString().ToUpper().Trim()) select item);
                        result = search;
                    }
                }
                if (result.Count() > 0)
                {
                    grvListLopHoc.Visible = true;
                    grvListLopHoc.DataSource = result.ToList();
                    grvListLopHoc.DataBind();
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
        protected void grvListLopHoc_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "cmdView")
            {
                this.PK_sMalop = Convert.ToString(e.CommandArgument);
                if (ViewDetail != null)
                {
                    ViewDetail(this, EventArgs.Empty);
                }
            }
        }

        protected void grvListLopHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (GridViewRow row in grvListLopHoc.Rows)
            {
                if (row.RowIndex == grvListLopHoc.SelectedIndex)
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

        protected void grvListLopHoc_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grvListLopHoc.PageIndex = e.NewPageIndex;
            BindData();
        }

        protected void grvListLopHoc_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(grvListLopHoc, "Select$" + e.Row.RowIndex);
                e.Row.ToolTip = "Click to select this row.";
            }
        }

        protected void grvListLopHoc_Sorting(object sender, GridViewSortEventArgs e)
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
            DataSet dsLopHoc = LopHocDAO.LopHoc_SelectList();
            DataView sortedView = new DataView(dsLopHoc.Tables[0]);
            sortedView.Sort = e.SortExpression + " " + sortingDirection;
            Session["objects"] = sortedView;
            grvListLopHoc.DataSource = sortedView;
            grvListLopHoc.DataBind();
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
                grvListLopHoc.AllowPaging = false;
                this.BindData();

                grvListLopHoc.HeaderRow.BackColor = Color.White;
                foreach (TableCell cell in grvListLopHoc.HeaderRow.Cells)
                {
                    cell.BackColor = grvListLopHoc.HeaderStyle.BackColor;
                }
                foreach (GridViewRow row in grvListLopHoc.Rows)
                {
                    row.BackColor = Color.White;
                    foreach (TableCell cell in row.Cells)
                    {
                        if (row.RowIndex % 2 == 0)
                        {
                            cell.BackColor = grvListLopHoc.AlternatingRowStyle.BackColor;
                        }
                        else
                        {
                            cell.BackColor = grvListLopHoc.RowStyle.BackColor;
                        }
                        cell.CssClass = "textmode";
                    }
                }

                grvListLopHoc.RenderControl(hw);
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