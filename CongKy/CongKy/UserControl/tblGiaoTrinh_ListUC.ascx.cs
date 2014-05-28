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
    public partial class tblGiaoTrinh_ListUC : System.Web.UI.UserControl
    {
        #region "Properties & Event"
        public event EventHandler ViewDetail;
        public event EventHandler AddNew;

        private Int32 _FK_iMonHocID;
        public Int32 FK_iMonHocID
        {
            get { return this._FK_iMonHocID; }
            set { _FK_iMonHocID = value; }
        }
        private Int32 _FK_iGiaoTrinhID;
        public Int32 FK_iGiaoTrinhID
        {
            get { return this._FK_iGiaoTrinhID; }
            set { _FK_iGiaoTrinhID = value; }
        }

        public tblGiaoTrinhEO objtblGiaoTrinhEO
        {
            get { return (tblGiaoTrinhEO)ViewState["objtblGiaoTrinhEO"]; }
            set { ViewState["objtblGiaoTrinhEO"] = value; }
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

        public void BindData(tblGiaoTrinhEO _tblGiaoTrinhEO)
        {
            objtblGiaoTrinhEO = _tblGiaoTrinhEO;
            grvListGiaoTrinh.Visible = false;
            string keysearch = txtTextSearch.Text;
            DataSet dsGiaoTrinh = new DataSet();
            try
            {
                dsGiaoTrinh = tblGiaoTrinhDAO.GiaoTrinh_SelectList();
                dsGiaoTrinh.Tables[0].Columns.Add(new DataColumn("FK_iMonHocID_Text", Type.GetType("System.String")));
                //foreach (DataRow dr in dsGiaoTrinh.Tables[0].Rows)
                //{
                //    dr["FK_iMonHocID_Text"] = tblGiaoTrinhDAO.GiaoTrinh_SelectItemPK_iMonHocID(Convert.ToString(dr["FK_iMonHocID"])).FK_iMonHocID;
                //}
                //var result = DataSet2LinQ.BaiViet(dsBaiViet);
                var result =
                from topic in dsGiaoTrinh.Tables[0].AsEnumerable()
                select new
                {
                    FK_iMonHocID = topic.Field<Int32>("FK_iMonHocID"),
                    FK_iGiaoTrinhID = topic.Field<Int32>("FK_iGiaoTrinhID"),
                };
                ddlTypeSearch.SelectedValue = typesearch;
                if (Convert.ToInt32(ddlTypeSearch.SelectedValue) == 0)
                {
                    if (keysearch != "")
                    {
                        var search = (from item in result where item.FK_iMonHocID.ToString().ToUpper().Contains(keysearch.ToString().ToUpper().Trim()) select item);
                        result = search;
                    }
                }
                else
                {
                    if (keysearch != "")
                    {
                        var search = (from item in result where item.FK_iGiaoTrinhID.ToString().ToUpper().Contains(keysearch.ToString().ToUpper().Trim()) select item);
                        result = search;
                    }
                }
                if (result.Count() > 0)
                {
                    grvListGiaoTrinh.Visible = true;
                    grvListGiaoTrinh.DataSource = result.ToList();
                    grvListGiaoTrinh.DataBind();
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
        protected void grvListGiaoTrinh_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "cmdView")
            {
                GridViewRow row = this.grvListGiaoTrinh.SelectedRow;
                int index = Convert.ToInt32(e.CommandArgument) % grvListGiaoTrinh.PageSize;
                this.FK_iMonHocID = Convert.ToInt32(grvListGiaoTrinh.DataKeys[index].Values["FK_iMonHocID"]);
                this.FK_iGiaoTrinhID = Convert.ToInt32(grvListGiaoTrinh.DataKeys[index].Values["FK_iGiaoTrinhID"]);
                if (ViewDetail != null)
                {
                    ViewDetail(this, EventArgs.Empty);
                }
            }
        }

        protected void grvListGiaoTrinh_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grvListGiaoTrinh.PageIndex = e.NewPageIndex;
            BindData(objtblGiaoTrinhEO);
        }

        protected void grvListGiaoTrinh_Sorting(object sender, GridViewSortEventArgs e)
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
            DataSet dsBaiViet = tblGiaoTrinhDAO.GiaoTrinh_SelectList();
            DataView sortedView = new DataView(dsBaiViet.Tables[0]);
            sortedView.Sort = e.SortExpression + " " + sortingDirection;
            Session["objects"] = sortedView;
            grvListGiaoTrinh.DataSource = sortedView;
            grvListGiaoTrinh.DataBind();
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
            BindData(objtblGiaoTrinhEO);
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
            BindData(objtblGiaoTrinhEO);
        }

        protected void ddlTypeSearch_TextChanged(object sender, EventArgs e)
        {
            typesearch = ddlTypeSearch.SelectedValue;
        }
    }
}