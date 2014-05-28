using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using CongKy.SharedLibraries;
using System.Drawing;
using System.IO;
using CongKy.DataAccessObject;
using CongKy.EntityObject;

namespace CongKy.UserControl
{
    public partial class tblTaiKhoan_ListUC : System.Web.UI.UserControl
    {
        #region "Properties & Event"
        public event EventHandler ViewDetail;
        public event EventHandler AddNew;

        private Int32 _PK_iTaiKhoanID;
        public Int32 PK_iTaiKhoanID
        {
            get { return this._PK_iTaiKhoanID; }
            set { _PK_iTaiKhoanID = value; }
        }

        private Int16 _iQuyenHan;
        public Int16 iQuyenHan
        {
            get { return this._iQuyenHan; }
            set { _iQuyenHan = value; }
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
                tblTaiKhoanEO _tblTaiKhoanEO = new tblTaiKhoanEO();
                _tblTaiKhoanEO.iQuyenHan = iQuyenHan;
                dsBaiViet = tblTaiKhoanDAO.TaiKhoan_SelectListByiQuyenHan(_tblTaiKhoanEO);
                foreach (DataRow dr in dsBaiViet.Tables[0].Rows)
                {
                    if (string.IsNullOrEmpty(dr["tNgaySinh"].ToString()))
                    {
                        dr["tNgaySinh"] = DateTime.MinValue;
                    }
                }
                //var result = DataSet2LinQ.BaiViet(dsBaiViet);
                var result =
                from topic in dsBaiViet.Tables[0].AsEnumerable()
                select new
                {
                    PK_iTaiKhoanID = topic.Field<Int32>("PK_iTaiKhoanID"),
                    sTenDangNhap = topic.Field<string>("sTenDangNhap"),
                    sMatKhau = "******",
                    //sMatKhau = topic.Field<string>("sMatKhau"),
                    sHoTen = topic.Field<string>("sHoTen"),
                    sEmail = topic.Field<string>("sEmail"),
                    sDiaChi = topic.Field<string>("sDiaChi"),
                    sSoDienThoai = topic.Field<string>("sSoDienThoai"),
                    sLinkAvatar = topic.Field<string>("sLinkAvatar"),
                    tNgaySinh = topic.Field<DateTime>("tNgaySinh"),
                    tNgayDangKy = topic.Field<DateTime>("tNgayDangKy"),
                    iQuyenHan = GetTextConstants.TaiKhoan_iQuyenHan_GTC(topic.Field<Int16>("iQuyenHan")),
                    iTrangThai = GetTextConstants.TaiKhoan_iTrangThai_GTC(topic.Field<Int16>("iTrangThai"))
                };
                ddlTypeSearch.SelectedValue = typesearch;
                if (Convert.ToInt16(ddlTypeSearch.SelectedValue) == 0)
                {
                    if (keysearch != "")
                    {
                        var search = (from item in result where item.PK_iTaiKhoanID.ToString().ToUpper().Contains(keysearch.ToString().ToUpper().Trim()) select item);
                        result = search;
                    }
                }
                else
                {
                    if (keysearch != "")
                    {
                        var search = (from item in result where item.sHoTen.ToString().ToUpper().Contains(keysearch.ToString().ToUpper().Trim()) select item);
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
                this.PK_iTaiKhoanID = Convert.ToInt32(e.CommandArgument);
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
            DataSet dsBaiViet = tblTaiKhoanDAO.TaiKhoan_SelectList();
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