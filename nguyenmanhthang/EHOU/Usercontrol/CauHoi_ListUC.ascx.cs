using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.IO;
using Shared_Libraries;
using DataAccessObject;
using System.Data;

namespace EHOU.UserControl
{
    public partial class CauHoi_ListUC : System.Web.UI.UserControl
    {
        #region "Properties & Event"
        public event EventHandler ViewDetail;
        public event EventHandler SelectRow;
        public event EventHandler AddNew;

        private Int64 _PK_lCauhoi_ID;
        public Int64 PK_lCauhoi_ID
        {
            get { return this._PK_lCauhoi_ID; }
            set { _PK_lCauhoi_ID = value; }
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
            grvListCauHoi.Visible = false;
            string keysearch = txtTextSearch.Text;
            DataSet dsCauHoi = new DataSet();
            try
            {
                dsCauHoi = CauHoiDAO.CauHoi_SelectList();
                //var result = DataSet2LinQ.BaiViet(dsBaiViet);
                var result =
                from topic in dsCauHoi.Tables[0].AsEnumerable()
                select new
                {
                    FK_sMaGV = topic.Field<string>("FK_sMaGV"),
                    PK_lCauhoi_ID = topic.Field<Int64>("PK_lCauhoi_ID"),
                    sCauhoi_Cauhoi = topic.Field<string>("sCauhoi_Cauhoi"),
                    sCauhoi_A = topic.Field<string>("sCauhoi_A"),
                    sCauhoi_B = topic.Field<string>("sCauhoi_B"),
                    sCauhoi_C = topic.Field<string>("sCauhoi_C"),
                    sCauhoi_D = topic.Field<string>("sCauhoi_D"),
                    iCauhoi_Dung = topic.Field<Int16>("iCauhoi_Dung"),
                    sBoCauHoi = topic.Field<string>("sBoCauHoi"),
                    tNgayTao = topic.Field<DateTime>("tNgayTao"),
                    tNgayCapNhat = topic.Field<DateTime>("tNgayCapNhat"),
                    iTrangThai = topic.Field<Int16>("iTrangThai")
                };
                ddlTypeSearch.SelectedValue = typesearch;
                if (Convert.ToInt16(ddlTypeSearch.SelectedValue) == 0)
                {
                    if (keysearch != "")
                    {
                        var search = (from item in result where item.PK_lCauhoi_ID.ToString().ToUpper().Contains(keysearch.ToString().ToUpper().Trim()) select item);
                        result = search;
                    }
                }
                else
                {
                    if (keysearch != "")
                    {
                        var search = (from item in result where item.sCauhoi_Cauhoi.ToString().ToUpper().Contains(keysearch.ToString().ToUpper().Trim()) select item);
                        result = search;
                    }
                }
                if (result.Count() > 0)
                {
                    grvListCauHoi.Visible = true;
                    grvListCauHoi.DataSource = result.ToList();
                    grvListCauHoi.DataBind();
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
        protected void grvListCauHoi_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "cmdView")
            {
                this.PK_lCauhoi_ID = Convert.ToInt64(e.CommandArgument);
                if (ViewDetail != null)
                {
                    ViewDetail(this, EventArgs.Empty);
                }
            }
        }

        protected void grvListCauHoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (GridViewRow row in grvListCauHoi.Rows)
            {
                if (row.RowIndex == grvListCauHoi.SelectedIndex)
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

        protected void grvListCauHoi_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grvListCauHoi.PageIndex = e.NewPageIndex;
            BindData();
        }

        protected void grvListCauHoi_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(grvListCauHoi, "Select$" + e.Row.RowIndex);
                e.Row.ToolTip = "Click to select this row.";
            }
        }

        protected void grvListCauHoi_Sorting(object sender, GridViewSortEventArgs e)
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
            DataSet dsCauHoi = CauHoiDAO.CauHoi_SelectList();
            DataView sortedView = new DataView(dsCauHoi.Tables[0]);
            sortedView.Sort = e.SortExpression + " " + sortingDirection;
            Session["objects"] = sortedView;
            grvListCauHoi.DataSource = sortedView;
            grvListCauHoi.DataBind();
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
                grvListCauHoi.AllowPaging = false;
                this.BindData();

                grvListCauHoi.HeaderRow.BackColor = Color.White;
                foreach (TableCell cell in grvListCauHoi.HeaderRow.Cells)
                {
                    cell.BackColor = grvListCauHoi.HeaderStyle.BackColor;
                }
                foreach (GridViewRow row in grvListCauHoi.Rows)
                {
                    row.BackColor = Color.White;
                    foreach (TableCell cell in row.Cells)
                    {
                        if (row.RowIndex % 2 == 0)
                        {
                            cell.BackColor = grvListCauHoi.AlternatingRowStyle.BackColor;
                        }
                        else
                        {
                            cell.BackColor = grvListCauHoi.RowStyle.BackColor;
                        }
                        cell.CssClass = "textmode";
                    }
                }

                grvListCauHoi.RenderControl(hw);
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