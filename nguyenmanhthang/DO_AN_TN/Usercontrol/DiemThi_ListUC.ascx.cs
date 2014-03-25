﻿using System;
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
    public partial class DiemThi_ListUC : System.Web.UI.UserControl
    {
        #region "Properties & Event"
        public event EventHandler ViewDetail;
        public event EventHandler SelectRow;
        public event EventHandler AddNew;
        public event EventHandler Search;

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
        private string _PK_iSolanhoc;
        public string PK_iSolanhoc
        {
            get { return this._PK_iSolanhoc; }
            set { _PK_iSolanhoc = value; }
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
            grvListDiemThi.Visible = false;
            DataSet dsDiemThi = new DataSet();
            try
            {
                dsDiemThi = DiemThiDAO.DiemThi_SelectList();
                if (Convert.ToInt32(dsDiemThi.Tables[0].Rows.Count.ToString()) > 0)
                {
                    grvListDiemThi.Visible = true;
                    grvListDiemThi.DataSource = dsDiemThi;
                    grvListDiemThi.DataBind();
                    lblTongSoBanGhi.Text = Messages.Tong_So_Ban_Ghi + dsDiemThi.Tables[0].Rows.Count.ToString();
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
        protected void grvListDiemThi_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "cmdView")
            {
                this.FK_sMaSV = Convert.ToString(e.CommandArgument);
                this.FK_sMaMonhoc = Convert.ToString(e.CommandArgument);
                this.PK_iSolanhoc = Convert.ToString(e.CommandArgument);
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
            BindData();
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
            DataSet dsDiemThi = DiemThiDAO.DiemThi_SelectList();
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
                grvListDiemThi.AllowPaging = false;
                this.BindData();

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
    }
}