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

namespace EHOU.UserControl
{
    public partial class GiangVien_ListUC : System.Web.UI.UserControl
    {
        #region "Properties & Event"
        public event EventHandler ViewDetail;
        public event EventHandler SelectRow;
        public event EventHandler AddNew;

        private string _PK_sMaGV;
        public string PK_sMaGV
        {
            get { return this._PK_sMaGV; }
            set { _PK_sMaGV = value; }
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
            grvListGiangVien.Visible = false;
            string keysearch = txtTextSearch.Text;
            DataSet dsGiangVien = new DataSet();
            try
            {
                dsGiangVien = GiangVienDAO.GiangVien_SelectList();
                //var result = DataSet2LinQ.BaiViet(dsBaiViet);
                var result =
                from topic in dsGiangVien.Tables[0].AsEnumerable()
                select new
                {
                    PK_sMaGV = topic.Field<string>("PK_sMaGV"),
                    sHotenGV = topic.Field<string>("sHotenGV"),
                    sTendangnhapGV = topic.Field<string>("sTendangnhapGV"),
                    sMatkhauGV = topic.Field<string>("sMatkhauGV"),
                    sEmailGV = topic.Field<string>("sEmailGV"),
                    sDiachiGV = topic.Field<string>("sDiachiGV"),
                    sSdtGV = topic.Field<string>("sSdtGV"),
                    tNgaysinhGV = topic.Field<DateTime>("tNgaysinhGV"),
                    bGioitinhGV = topic.Field<bool>("bGioitinhGV"),
                    sCMNDGV = topic.Field<string>("sCMNDGV"),
                    tNgayCapCMNDGV = topic.Field<DateTime>("tNgayCapCMNDGV"),
                    sNoiCapCMNDGV = topic.Field<string>("sNoiCapCMNDGV"),
                    bHonNhanGV = topic.Field<bool>("bHonNhanGV"),
                    tNgayNhanCongTacGV = topic.Field<DateTime>("tNgayNhanCongTacGV"),
                    iChucVuGV = topic.Field<Int16>("iChucVuGV"),
                    iHocViGV = topic.Field<Int16>("iHocViGV"),
                    bCongChucGV = topic.Field<bool>("bCongChucGV"),
                    sLinkChannelsGV = topic.Field<string>("sLinkChannelsGV"),
                    sLinkChatRoomsGV = topic.Field<string>("sLinkChatRoomsGV"),
                    sLinkAvatarGV = topic.Field<string>("sLinkAvatarGV"),
                    iTrangThaiGV = topic.Field<Int16>("iTrangThaiGV")
                };
                ddlTypeSearch.SelectedValue = typesearch;
                if (Convert.ToInt16(ddlTypeSearch.SelectedValue) == 0)
                {
                    if (keysearch != "")
                    {
                        var search = (from item in result where item.PK_sMaGV.ToString().ToUpper().Contains(keysearch.ToString().ToUpper().Trim()) select item);
                        result = search;
                    }
                }
                else
                {
                    if (keysearch != "")
                    {
                        var search = (from item in result where item.sHotenGV.ToString().ToUpper().Contains(keysearch.ToString().ToUpper().Trim()) select item);
                        result = search;
                    }
                }
                if (result.Count() > 0)
                {
                    grvListGiangVien.Visible = true;
                    grvListGiangVien.DataSource = result.ToList();
                    grvListGiangVien.DataBind();
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