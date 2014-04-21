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
using EntityObject;

namespace DO_AN_TN.UserControl
{
    public partial class DiemThi_ListUC : System.Web.UI.UserControl
    {
        #region "Properties & Event"
        public event EventHandler ViewDetail;
        public event EventHandler SelectRow;
        public event EventHandler AddNew;

        public DiemThiEO objDiemThiEO
        {
            get { return (DiemThiEO)ViewState["objDiemThiEO"]; }
            set { ViewState["objDiemThiEO"] = value; }
        }

        private string _FK_sMaSV;
        public string FK_sMaSV
        {
            get { return this._FK_sMaSV; }
            set { _FK_sMaSV = value; }
        }
        private string _FK_sMaMonhoc;
        public string FK_sMaMonhoc
        {
            get { return this._FK_sMaMonhoc; }
            set { _FK_sMaMonhoc = value; }
        }
        private Int16 _PK_iSolanhoc;
        public Int16 PK_iSolanhoc
        {
            get { return this._PK_iSolanhoc; }
            set { _PK_iSolanhoc = value; }
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

        public void BindData(DiemThiEO _DiemThiEO)
        {
            objDiemThiEO = _DiemThiEO;
            grvListDiemThi.Visible = false;
            string keysearch = txtTextSearch.Text;
            DataSet dsDiemThi = new DataSet();
            try
            {
                dsDiemThi = DiemThiDAO.DiemThi_SelectList(_DiemThiEO);
                //var result = DataSet2LinQ.BaiViet(dsBaiViet);
                var result =
                from topic in dsDiemThi.Tables[0].AsEnumerable()
                select new
                {
                    FK_sMaSV = topic.Field<string>("FK_sMaSV"),
                    FK_sMaMonhoc = topic.Field<string>("FK_sMaMonhoc"),
                    PK_iSolanhoc = topic.Field<Int16>("PK_iSolanhoc"),
                    fDiemchuyencan = topic.Field<double>("fDiemchuyencan"),
                    fDiemgiuaky = topic.Field<double>("fDiemgiuaky"),
                    fDiemthilan1 = topic.Field<double>("fDiemthilan1"),
                    fDiemthilan2 = topic.Field<double>("fDiemthilan2"),
                    iTrangThai = topic.Field<Int16>("iTrangThai")
                };
                ddlTypeSearch.SelectedValue = typesearch;
                if (Convert.ToInt16(ddlTypeSearch.SelectedValue) == 0)
                {
                    if (keysearch != "")
                    {
                        var search = (from item in result where item.FK_sMaSV.ToString().ToUpper().Contains(keysearch.ToString().ToUpper().Trim()) select item);
                        result = search;
                    }
                }
                else
                {
                    if (keysearch != "")
                    {
                        var search = (from item in result where item.FK_sMaMonhoc.ToString().ToUpper().Contains(keysearch.ToString().ToUpper().Trim()) select item);
                        result = search;
                    }
                }
                if (result.Count() > 0)
                {
                    grvListDiemThi.Visible = true;
                    grvListDiemThi.DataSource = result.ToList();
                    grvListDiemThi.DataBind();
                    lblTongSoBanGhi.Text = Messages.Tong_So_Ban_Ghi + result.Count();
                }
                else
                {
                    lblTongSoBanGhi.Text = Messages.Khong_Thoa_Man_Dieu_Kien_Tim_Kiem;
                }

                //dsDiemThi = DiemThiDAO.DiemThi_SelectList(_DiemThiEO);
                //if (Convert.ToInt32(dsDiemThi.Tables[0].Rows.Count.ToString()) > 0)
                //{
                //    grvListDiemThi.Visible = true;
                //    grvListDiemThi.DataSource = dsDiemThi;
                //    grvListDiemThi.DataBind();
                //    lblTongSoBanGhi.Text = Messages.Tong_So_Ban_Ghi + dsDiemThi.Tables[0].Rows.Count.ToString();
                //}
                //else
                //{
                //    lblTongSoBanGhi.Text = Messages.Khong_Thoa_Man_Dieu_Kien_Tim_Kiem;
                //}
            }
            catch (Exception ex)
            {
                lblTongSoBanGhi.Text = Messages.Loi + ex.Message;
            }
        }

        #region "Event GridView"
        protected void grvListDiemThi_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "cmdView")
            {
                GridViewRow row = this.grvListDiemThi.SelectedRow;
                int index = Convert.ToInt16(e.CommandArgument) % grvListDiemThi.PageSize;
                this.FK_sMaSV = Convert.ToString(grvListDiemThi.DataKeys[index].Values["FK_sMaSV"]);
                this.FK_sMaMonhoc = Convert.ToString(grvListDiemThi.DataKeys[index].Values["FK_sMaMonhoc"]);
                this.PK_iSolanhoc = Convert.ToInt16(grvListDiemThi.DataKeys[index].Values["PK_iSolanhoc"]);
                if (ViewDetail != null)
                {
                    ViewDetail(this, EventArgs.Empty);
                }
            }
        }

        protected void grvListDiemThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (GridViewRow row in grvListDiemThi.Rows)
            {
                if (row.RowIndex == grvListDiemThi.SelectedIndex)
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

        protected void grvListDiemThi_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grvListDiemThi.PageIndex = e.NewPageIndex;
            BindData(objDiemThiEO);
        }

        protected void grvListDiemThi_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(grvListDiemThi, "Select$" + e.Row.RowIndex);
                e.Row.ToolTip = "Click to select this row.";
            }
        }

        protected void grvListDiemThi_Sorting(object sender, GridViewSortEventArgs e)
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
            DataSet dsDiemThi = DiemThiDAO.DiemThi_SelectList(objDiemThiEO);
            DataView sortedView = new DataView(dsDiemThi.Tables[0]);
            sortedView.Sort = e.SortExpression + " " + sortingDirection;
            Session["objects"] = sortedView;
            grvListDiemThi.DataSource = sortedView;
            grvListDiemThi.DataBind();
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
            BindData(objDiemThiEO);
        }

        protected void btnRefresh_Click(object sender, EventArgs e)
        {
            BindData(objDiemThiEO);
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
                grvListDiemThi.AllowPaging = false;
                this.BindData(objDiemThiEO);

                grvListDiemThi.HeaderRow.BackColor = Color.White;
                foreach (TableCell cell in grvListDiemThi.HeaderRow.Cells)
                {
                    cell.BackColor = grvListDiemThi.HeaderStyle.BackColor;
                }
                foreach (GridViewRow row in grvListDiemThi.Rows)
                {
                    row.BackColor = Color.White;
                    foreach (TableCell cell in row.Cells)
                    {
                        if (row.RowIndex % 2 == 0)
                        {
                            cell.BackColor = grvListDiemThi.AlternatingRowStyle.BackColor;
                        }
                        else
                        {
                            cell.BackColor = grvListDiemThi.RowStyle.BackColor;
                        }
                        cell.CssClass = "textmode";
                    }
                }

                grvListDiemThi.RenderControl(hw);
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
            BindData(objDiemThiEO);
        }

        protected void ddlTypeSearch_TextChanged(object sender, EventArgs e)
        {
            typesearch = ddlTypeSearch.SelectedValue;
        }
    }
}