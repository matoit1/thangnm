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
using EntityObject;

namespace EHOU.UserControl
{
    public partial class PhanCongCongTac_ListUC : System.Web.UI.UserControl
    {
        #region "Properties & Event"
        public event EventHandler ViewDetail;
        public event EventHandler SelectRow;
        public event EventHandler AddNew;

        public PhanCongCongTacEO objPhanCongCongTacEO
        {
            get { return (PhanCongCongTacEO)ViewState["objPhanCongCongTacEO"]; }
            set { ViewState["objPhanCongCongTacEO"] = value; }
        }

        private string _PK_sMaPCCT;
        public string PK_sMaPCCT
        {
            get { return this._PK_sMaPCCT; }
            set { _PK_sMaPCCT = value; }
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
                //BindData();
            }
        }

        public void BindData(PhanCongCongTacEO _PhanCongCongTacEO)
        {
            objPhanCongCongTacEO = _PhanCongCongTacEO;
            grvListPhanCongCongTac.Visible = false;
            string keysearch = txtTextSearch.Text;
            DataSet dsPhanCongCongTac = new DataSet();
            try
            {
                dsPhanCongCongTac = PhanCongCongTacDAO.PhanCongCongTac_SelectList(_PhanCongCongTacEO);
                //var result = DataSet2LinQ.BaiViet(dsBaiViet);
                var result =
                from topic in dsPhanCongCongTac.Tables[0].AsEnumerable()
                select new
                {
                    PK_sMaPCCT = topic.Field<string>("PK_sMaPCCT"),
                    FK_sMaGV = topic.Field<string>("FK_sMaGV"),
                    FK_sMaMonhoc = topic.Field<string>("FK_sMaMonhoc"),
                    tNgayBatDau = topic.Field<DateTime>("tNgayBatDau"),
                    tNgayKetThuc = topic.Field<DateTime>("tNgayKetThuc"),
                    iTrangThai = topic.Field<Int16>("iTrangThai")
                };
                ddlTypeSearch.SelectedValue = typesearch;
                if (Convert.ToInt16(ddlTypeSearch.SelectedValue) == 0)
                {
                    if (keysearch != "")
                    {
                        var search = (from item in result where item.PK_sMaPCCT.ToString().ToUpper().Contains(keysearch.ToString().ToUpper().Trim()) select item);
                        result = search;
                    }
                }
                else
                {
                    if (keysearch != "")
                    {
                        var search = (from item in result where item.FK_sMaGV.ToString().ToUpper().Contains(keysearch.ToString().ToUpper().Trim()) select item);
                        result = search;
                    }
                }
                if (result.Count() > 0)
                {
                    grvListPhanCongCongTac.Visible = true;
                    grvListPhanCongCongTac.DataSource = result.ToList();
                    grvListPhanCongCongTac.DataBind();
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
        protected void grvListPhanCongCongTac_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "cmdView")
            {
                this.PK_sMaPCCT = Convert.ToString(e.CommandArgument);
                if (ViewDetail != null)
                {
                    ViewDetail(this, EventArgs.Empty);
                }
            }
        }

        protected void grvListPhanCongCongTac_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (GridViewRow row in grvListPhanCongCongTac.Rows)
            {
                if (row.RowIndex == grvListPhanCongCongTac.SelectedIndex)
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

        protected void grvListPhanCongCongTac_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grvListPhanCongCongTac.PageIndex = e.NewPageIndex;
            BindData(objPhanCongCongTacEO);
        }

        protected void grvListPhanCongCongTac_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(grvListPhanCongCongTac, "Select$" + e.Row.RowIndex);
                e.Row.ToolTip = "Click to select this row.";
            }
        }

        protected void grvListPhanCongCongTac_Sorting(object sender, GridViewSortEventArgs e)
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
            DataSet dsPhanCongCongTac = PhanCongCongTacDAO.PhanCongCongTac_SelectList(objPhanCongCongTacEO);
            DataView sortedView = new DataView(dsPhanCongCongTac.Tables[0]);
            sortedView.Sort = e.SortExpression + " " + sortingDirection;
            Session["objects"] = sortedView;
            grvListPhanCongCongTac.DataSource = sortedView;
            grvListPhanCongCongTac.DataBind();
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
            BindData(objPhanCongCongTacEO);
        }

        protected void btnRefresh_Click(object sender, EventArgs e)
        {
            BindData(objPhanCongCongTacEO);
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
            string FileName = "Danh_sach_Phan_Cong_Cong_Tac(" + Messages.DateTime_Temp + ").xls";
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
                grvListPhanCongCongTac.AllowPaging = false;
                this.BindData(objPhanCongCongTacEO);

                grvListPhanCongCongTac.HeaderRow.BackColor = Color.White;
                foreach (TableCell cell in grvListPhanCongCongTac.HeaderRow.Cells)
                {
                    cell.BackColor = grvListPhanCongCongTac.HeaderStyle.BackColor;
                }
                foreach (GridViewRow row in grvListPhanCongCongTac.Rows)
                {
                    row.BackColor = Color.White;
                    foreach (TableCell cell in row.Cells)
                    {
                        if (row.RowIndex % 2 == 0)
                        {
                            cell.BackColor = grvListPhanCongCongTac.AlternatingRowStyle.BackColor;
                        }
                        else
                        {
                            cell.BackColor = grvListPhanCongCongTac.RowStyle.BackColor;
                        }
                        cell.CssClass = "textmode";
                    }
                }

                grvListPhanCongCongTac.RenderControl(hw);
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
            BindData(objPhanCongCongTacEO);
        }

        protected void ddlTypeSearch_TextChanged(object sender, EventArgs e)
        {
            typesearch = ddlTypeSearch.SelectedValue;
        }
    }
}