﻿using System;
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

namespace DO_AN_TN.UserControl
{
    public partial class MonHoc_ListUC : System.Web.UI.UserControl
    {
        public event EventHandler ViewDetail;
        public event EventHandler SelectRow;
        private string _PK_sMaMonhoc;
        public string PK_sMaMonhoc
        {
            get { return this._PK_sMaMonhoc; }
            set { _PK_sMaMonhoc = value; }
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindData();
            }
        }

        protected void BindData()
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
            if (LoginUC1.state == true) { Response.Redirect(Request.Url.AbsolutePath); } else { Response.Redirect("~/Accounts/Login.aspx"); }
        }
    }
}