using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.IO;
using CongKy.SharedLibraries;
using System.Data;
using CongKy.DataAccessObject;
using CongKy.EntityObject;

namespace CongKy.UserControl
{
    public partial class tblChiTietGiaoTrinh_ListUC : System.Web.UI.UserControl
    {
        #region "Properties & Event"
        public event EventHandler ViewDetail;
        public event EventHandler AddNew;

        private Int32 _PK_iGiaoTrinhID;
        public Int32 PK_iGiaoTrinhID
        {
            get { return this._PK_iGiaoTrinhID; }
            set { _PK_iGiaoTrinhID = value; }
        }

        private Int32 _PK_iTaiKhoanID;
        public Int32 PK_iTaiKhoanID
        {
            get { return this._PK_iTaiKhoanID; }
            set { _PK_iTaiKhoanID = value; }
        }

        private Int32 _PK_iMonHocID;
        public Int32 PK_iMonHocID
        {
            get { return this._PK_iMonHocID; }
            set { _PK_iMonHocID = value; }
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

        public void BindData()
        {
            grvListBaiViet.Visible = false;
            string keysearch = txtTextSearch.Text;
            DataSet dsBaiViet = new DataSet();
            try
            {
                tblChiTietGiaoTrinhEO _tblChiTietGiaoTrinhEO = new tblChiTietGiaoTrinhEO();
                _tblChiTietGiaoTrinhEO.iTrangThai = iTrangThai;
                dsBaiViet = tblChiTietGiaoTrinhDAO.ChiTietGiaoTrinh_By_PK_iTaiKhoanID_PK_iMonHocID_PK_iGiaoTrinhID(PK_iTaiKhoanID, PK_iMonHocID, PK_iGiaoTrinhID);
                //var result = DataSet2LinQ.BaiViet(dsBaiViet);
                var result =
                from topic in dsBaiViet.Tables[0].AsEnumerable()
                select new
                {
                    PK_iGiaoTrinhID = topic.Field<Int32>("PK_iGiaoTrinhID"),
                    PK_iMonHocID = topic.Field<Int32>("PK_iMonHocID"),
                    sTenBaiHoc = topic.Field<String>("sTenBaiHoc"),
                    sThongTin = topic.Field<String>("sThongTin"),
                    sLinkDownload = topic.Field<String>("sLinkDownload"),
                    iType = topic.Field<Int16>("iType"),
                    tNgayCapNhat = topic.Field<DateTime>("tNgayCapNhat"),
                    iTrangThai = GetTextConstants.ChiTietGiaoTrinh_iTrangThai_GTC(topic.Field<Int16>("iTrangThai"))
                };
                ddlTypeSearch.SelectedValue = typesearch;
                if (Convert.ToInt16(ddlTypeSearch.SelectedValue) == 0)
                {
                    if (keysearch != "")
                    {
                        var search = (from item in result where item.PK_iGiaoTrinhID.ToString().ToUpper().Contains(keysearch.ToString().ToUpper().Trim()) select item);
                        result = search;
                    }
                }
                else
                {
                    if (keysearch != "")
                    {
                        var search = (from item in result where item.sTenBaiHoc.ToString().ToUpper().Contains(keysearch.ToString().ToUpper().Trim()) select item);
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
            if (e.CommandName == "cmdDetail")
            {
                GridViewRow row = this.grvListBaiViet.SelectedRow;
                int index = Convert.ToInt32(e.CommandArgument) % grvListBaiViet.PageSize;
                this.PK_iGiaoTrinhID = Convert.ToInt32(grvListBaiViet.DataKeys[index].Values["PK_iGiaoTrinhID"]);
                this.PK_iMonHocID = Convert.ToInt32(grvListBaiViet.DataKeys[index].Values["PK_iMonHocID"]);
                if (ViewDetail != null)
                {
                    ViewDetail(this, EventArgs.Empty);
                }
            }
            if (e.CommandName == "cmdView")
            {
                GridViewRow row = this.grvListBaiViet.SelectedRow;
                int index = Convert.ToInt32(e.CommandArgument) % grvListBaiViet.PageSize;
                this.PK_iGiaoTrinhID = Convert.ToInt32(grvListBaiViet.DataKeys[index].Values["PK_iGiaoTrinhID"]);
                Response.Redirect("~/XemTruoc.aspx?PK_iGiaoTrinhID=" + PK_iGiaoTrinhID);
            }
        }

        protected void grvListBaiViet_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grvListBaiViet.PageIndex = e.NewPageIndex;
            BindData();
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
            DataSet dsBaiViet = tblChiTietGiaoTrinhDAO.ChiTietGiaoTrinh_SelectList();
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