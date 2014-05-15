using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using DataAccessObject;
using EntityObject;
using System.Data;
using System.IO;
using Shared_Libraries;

namespace EHOU.UserControl
{
    public partial class SinhVien_ListUC : System.Web.UI.UserControl
    {
        #region "Properties & Event"
        public event EventHandler ViewDetail;
        public event EventHandler SelectRow;
        public event EventHandler AddNew;
        //public event EventHandler Search;

        private string _PK_sMaSV;
        public string PK_sMaSV
        {
            get { return this._PK_sMaSV; }
            set { _PK_sMaSV = value; }
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
            grvListSinhVien.Visible = false;
            string keysearch = txtTextSearch.Text;
            DataSet dsSinhVien = new DataSet();
            try
            {
                dsSinhVien = SinhVienDAO.SinhVien_SelectList();
                //var result = DataSet2LinQ.BaiViet(dsBaiViet);
                var result =
                from topic in dsSinhVien.Tables[0].AsEnumerable()
                select new
                {
                    FK_sMaLop = topic.Field<string>("FK_sMaLop"),
                    PK_sMaSV = topic.Field<string>("PK_sMaSV"),
                    sHotenSV = topic.Field<string>("sHotenSV"),
                    sTendangnhapSV = topic.Field<string>("sTendangnhapSV"),
                    sMatkhauSV = topic.Field<string>("sMatkhauSV"),
                    sEmailSV = topic.Field<string>("sEmailSV"),
                    sDiachiSV = topic.Field<string>("sDiachiSV"),
                    sSdtSV = topic.Field<string>("sSdtSV"),
                    tNgaysinhSV = topic.Field<DateTime>("tNgaysinhSV"),
                    bGioitinhSV = topic.Field<bool>("bGioitinhSV"),
                    sCMNDSV = topic.Field<string>("sCMNDSV"),
                    tNgayCapCMNDSV = topic.Field<DateTime>("tNgayCapCMNDSV"),
                    sNoiCapCMNDSV = topic.Field<string>("sNoiCapCMNDSV"),
                    bHonNhanSV = topic.Field<bool>("bHonNhanSV"),
                    sNguoiLienHeSV = topic.Field<string>("sNguoiLienHeSV"),
                    sDiaChiNguoiLienHeSV = topic.Field<string>("sDiaChiNguoiLienHeSV"),
                    sSdtNguoiLienHeSV = topic.Field<string>("sSdtNguoiLienHeSV"),
                    iQuanHeVoiNguoiLienHeSV = topic.Field<Int16>("iQuanHeVoiNguoiLienHeSV"),
                    bKetnapDoanSV = topic.Field<bool>("bKetnapDoanSV"),
                    iNamketnapDoanSV = topic.Field<Int16>("iNamketnapDoanSV"),
                    sNoiketnapDoanSV = topic.Field<string>("sNoiketnapDoanSV"),
                    iNamtotnghiepTHPTSV = topic.Field<Int16>("iNamtotnghiepTHPTSV"),
                    tNgayNhapHocSV = topic.Field<DateTime>("tNgayNhapHocSV"),
                    tNgayRaTruongSV = topic.Field<DateTime>("tNgayRaTruongSV"),
                    tNgayCapTheSV = topic.Field<DateTime>("tNgayCapTheSV"),
                    sLinkAvatarSV = topic.Field<string>("sLinkAvatarSV"),
                    iTrangThaiSV = topic.Field<Int16>("iTrangThaiSV")
                };
                ddlTypeSearch.SelectedValue = typesearch;
                if (Convert.ToInt16(ddlTypeSearch.SelectedValue) == 0)
                {
                    if (keysearch != "")
                    {
                        var search = (from item in result where item.PK_sMaSV.ToString().ToUpper().Contains(keysearch.ToString().ToUpper().Trim()) select item);
                        result = search;
                    }
                }
                else
                {
                    if (keysearch != "")
                    {
                        var search = (from item in result where item.sHotenSV.ToString().ToUpper().Contains(keysearch.ToString().ToUpper().Trim()) select item);
                        result = search;
                    }
                }

                if (result.Count() > 0)
                {
                    grvListSinhVien.Visible = true;
                    grvListSinhVien.DataSource = result.ToList();
                    grvListSinhVien.DataBind();
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
        protected void grvListSinhVien_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "cmdView")
            {
                this.PK_sMaSV = Convert.ToString(e.CommandArgument);
                if (ViewDetail != null)
                {
                    ViewDetail(this, EventArgs.Empty);
                }
            }
        }

        protected void grvListSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (GridViewRow row in grvListSinhVien.Rows)
            {
                if (row.RowIndex == grvListSinhVien.SelectedIndex)
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

        protected void grvListSinhVien_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grvListSinhVien.PageIndex = e.NewPageIndex;
            BindData();
        }

        protected void grvListSinhVien_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(grvListSinhVien, "Select$" + e.Row.RowIndex);
                e.Row.ToolTip = "Click to select this row.";
            }
        }

        protected void grvListSinhVien_Sorting(object sender, GridViewSortEventArgs e)
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
            DataSet dsSinhVien = SinhVienDAO.SinhVien_SelectList();
            DataView sortedView = new DataView(dsSinhVien.Tables[0]);
            sortedView.Sort = e.SortExpression + " " + sortingDirection;
            Session["objects"] = sortedView;
            grvListSinhVien.DataSource = sortedView;
            grvListSinhVien.DataBind();
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
            string FileName = "Danh_sach_Sinh_Vien(" + Messages.DateTime_Temp + ").xls";
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
                grvListSinhVien.AllowPaging = false;
                this.BindData();

                grvListSinhVien.HeaderRow.BackColor = Color.White;
                foreach (TableCell cell in grvListSinhVien.HeaderRow.Cells)
                {
                    cell.BackColor = grvListSinhVien.HeaderStyle.BackColor;
                }
                foreach (GridViewRow row in grvListSinhVien.Rows)
                {
                    row.BackColor = Color.White;
                    foreach (TableCell cell in row.Cells)
                    {
                        if (row.RowIndex % 2 == 0)
                        {
                            cell.BackColor = grvListSinhVien.AlternatingRowStyle.BackColor;
                        }
                        else
                        {
                            cell.BackColor = grvListSinhVien.RowStyle.BackColor;
                        }
                        cell.CssClass = "textmode";
                    }
                }

                grvListSinhVien.RenderControl(hw);
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