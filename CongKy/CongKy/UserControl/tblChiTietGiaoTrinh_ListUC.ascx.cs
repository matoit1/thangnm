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

        private String _sTenBaiHoc;
        public String sTenBaiHoc
        {
            get { return this._sTenBaiHoc; }
            set { _sTenBaiHoc = value; }
        }

        private String _sThongTin;
        public String sThongTin
        {
            get { return this._sThongTin; }
            set { _sThongTin = value; }
        }

        private String _sLinkDownload;
        public String sLinkDownload
        {
            get { return this._sLinkDownload; }
            set { _sLinkDownload = value; }
        }

        private Int16 _iType;
        public Int16 iType
        {
            get { return this._iType; }
            set { _iType = value; }
        }

        private DateTime _tNgayCapNhat;
        public DateTime tNgayCapNhat
        {
            get { return this._tNgayCapNhat; }
            set { _tNgayCapNhat = value; }
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
            if (!IsPostBack)
            {
                BindData();
            }
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
                dsBaiViet = tblChiTietGiaoTrinhDAO.ChiTietGiaoTrinh_SelectList();
                //var result = DataSet2LinQ.BaiViet(dsBaiViet);
                var result =
                from topic in dsBaiViet.Tables[0].AsEnumerable()
                select new
                {
                    PK_iGiaoTrinhID = topic.Field<Int32>("PK_iGiaoTrinhID"),
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
            if (e.CommandName == "cmdView")
            {
                this.PK_iGiaoTrinhID = Convert.ToInt32(e.CommandArgument);
                if (ViewDetail != null)
                {
                    ViewDetail(this, EventArgs.Empty);
                }
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