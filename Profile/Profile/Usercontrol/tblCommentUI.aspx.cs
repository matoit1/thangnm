using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Drawing;
using SharedLibraries;
using EntityObject;
using DataAccessObject;

namespace Profile
{
    public partial class tblCommentUI : System.Web.UI.Page
    {
        #region "Properties & Event"
        public event EventHandler ViewDetail;
        public event EventHandler SelectRow;
        public event EventHandler AddNew;
        public string typesearch
        {
            get { return (string)ViewState["typesearch"]; }
            set { ViewState["typesearch"] = value; }
        }
        #endregion
        private tblCommentEO _objtblCommentEO;
        public tblCommentEO objtblCommentEO
        {
            get { return this._objtblCommentEO; }
            set { _objtblCommentEO = value; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    BindDataGrid();
                    BindDataDdl();
                    ClearMessages();
                }
            }
            catch (Exception)
            {
                lblMsg.Text = Messages.Loi;
            }
        }

        public void BindDataGrid()
        {
            grvList.Visible = false;
            string keysearch = txtTextSearch.Text;
            DataTable dt = tblAccountDAO.SelectList();
            var result =
                from topic in dt.AsEnumerable()
                select new
                {
                    PK_lComment_ID = topic.Field<Int64>("PK_lComment_ID"),
                    FK_lTopicID = topic.Field<Int64>("FK_lTopicID"),
                    sName = topic.Field<String>("sName"),
                    sEmail = topic.Field<String>("sEmail"),
                    sWebsite = topic.Field<String>("sWebsite"),
                    sContent = topic.Field<String>("sContent"),
                    bStatus = topic.Field<Boolean>("bStatus"),
                    tLastUpdate = topic.Field<DateTime>("tLastUpdate")
                };
            ddlTypeSearch.SelectedValue = typesearch;
            if (Convert.ToInt16(ddlTypeSearch.SelectedValue) == 0)
            {
                if (keysearch != "")
                {
                    var search = (from item in result where item.PK_lComment_ID.ToString().ToUpper().Contains(keysearch.ToString().ToUpper().Trim()) select item);
                    result = search;
                }
            }
            else
            {
                if (keysearch != "")
                {
                    var search = (from item in result where item.FK_lTopicID.ToString().ToUpper().Contains(keysearch.ToString().ToUpper().Trim()) select item);
                    result = search;
                }
            }
            if (result.Count() > 0)
            {
                grvList.Visible = true;
                grvList.DataSource = result.ToList();
                grvList.DataBind();
                lblRowCount.Text = Messages.Tong_So_Ban_Ghi + result.Count();
            }
            else
            {
                lblRowCount.Text = Messages.Khong_Thoa_Man_Dieu_Kien_Tim_Kiem;
            }
        }

        public void BindDataDdl()
        {
            DataTable dt = new DataTable();
            dt = tblCommentDAO.SelectList();
            this.grvList.DataSource = dt;
            this.grvList.DataBind();
            dt.Clear();
            dt = null;
        }

        public void BindDataDetail(tblCommentEO _tblCommentEO)
        {
            this.txtPK_lComment_ID.Text = Convert.ToString(_tblCommentEO.PK_lComment_ID);
            this.ddlFK_lTopicID.SelectedValue = Convert.ToString(_tblCommentEO.FK_lTopicID);
            this.txtsName.Text = Convert.ToString(_tblCommentEO.sName);
            this.txtsEmail.Text = Convert.ToString(_tblCommentEO.sEmail);
            this.txtsWebsite.Text = Convert.ToString(_tblCommentEO.sWebsite);
            this.txtsContent.Text = Convert.ToString(_tblCommentEO.sContent);
            this.txtbStatus.Text = Convert.ToString(_tblCommentEO.bStatus);
            this.txttLastUpdate.Text = Convert.ToString(_tblCommentEO.tLastUpdate);
        }

        public void ClearMessages()
        {
            lblPK_lComment_ID.Text = "";
            lblFK_lTopicID.Text = "";
            lblsName.Text = "";
            lblsEmail.Text = "";
            lblsWebsite.Text = "";
            lblsContent.Text = "";
            lblbStatus.Text = "";
            lbltLastUpdate.Text = "";
        }

        public bool CheckInput()
        {
            if (string.IsNullOrEmpty(txtPK_lComment_ID.Text) == true)
            {
                lblPK_lComment_ID.Text = Messages.Khong_Duoc_De_Trong;
                txtPK_lComment_ID.Focus();
                return false;
            }
            return true;
        }

        public tblCommentEO GetObject()
        {
            tblCommentEO _tblCommentEO = new tblCommentEO();
            try
            {
                _tblCommentEO.PK_lComment_ID = Convert.ToInt64(this.txtPK_lComment_ID.Text);
                _tblCommentEO.FK_lTopicID = Convert.ToInt64(this.ddlFK_lTopicID.SelectedValue);
                _tblCommentEO.sName = Convert.ToString(this.txtsName.Text);
                _tblCommentEO.sEmail = Convert.ToString(this.txtsEmail.Text);
                _tblCommentEO.sWebsite = Convert.ToString(this.txtsWebsite.Text);
                _tblCommentEO.sContent = Convert.ToString(this.txtsContent.Text);
                _tblCommentEO.bStatus = Convert.ToBoolean(this.txtbStatus.Text);
                _tblCommentEO.tLastUpdate = Convert.ToDateTime(this.txttLastUpdate.Text);
                return _tblCommentEO;
            }
            catch
            {
                return _tblCommentEO;
            }
        }

        protected void grvList_RowCommand(object source, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "cmdView")
            {
                GridViewRow row = this.grvList.SelectedRow;
                int index = Convert.ToInt16(e.CommandArgument) % grvList.PageSize;
                objtblCommentEO = new tblCommentEO();
                objtblCommentEO.PK_lComment_ID = Convert.ToInt64(grvList.DataKeys[index].Values["PK_lComment_ID"]);
                objtblCommentEO = tblCommentDAO.SelectItem(objtblCommentEO);
                BindDataDetail(objtblCommentEO);
                mtvMain.ActiveViewIndex = 1;
                if (ViewDetail != null)
                {
                    ViewDetail(this, EventArgs.Empty);
                }
            }
        }

        protected void grvList_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (GridViewRow row in grvList.Rows)
            {
                if (row.RowIndex == grvList.SelectedIndex)
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

        protected void grvList_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grvList.PageIndex = e.NewPageIndex;
            BindDataGrid();
        }

        protected void grvList_RowDataBound(object sender, GridViewRowEventArgs e)
        {
        }

        protected void grvList_Sorting(object sender, GridViewSortEventArgs e)
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
            DataTable dt = tblCommentDAO.SelectList();
            DataView sortedView = new DataView(dt);
            sortedView.Sort = e.SortExpression + " " + sortingDirection;
            Session["objects"] = sortedView;
            grvList.DataSource = sortedView;
            grvList.DataBind();
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
        protected void btnInsert_Click(object sender, EventArgs e)
        {
            ClearMessages();
            lblMsg.Text = "";
            try
            {
                if (CheckInput() == true)
                {
                    if (tblCommentDAO.Insert(GetObject()) == true)
                    {
                        lblMsg.Text = Messages.Them_Thanh_Cong;
                        ClearMessages();
                        tblCommentEO _tblCommentEO = new tblCommentEO();
                        BindDataDetail(_tblCommentEO);
                    }
                    else
                    {
                        lblMsg.Text = Messages.Them_That_Bai;
                    }
                }
            }
            catch (Exception ex)
            {
                lblMsg.Text = Messages.Loi + ex.Message;
            }
        }
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            BindDataGrid();
        }
        protected void ddlTypeSearch_TextChanged(object sender, EventArgs e)
        {
            typesearch = ddlTypeSearch.SelectedValue;
        }
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            ClearMessages();
            lblMsg.Text = "";
            try
            {
                if (CheckInput() == true)
                {
                    if (tblCommentDAO.Update(GetObject()) == true)
                    {
                        lblMsg.Text = Messages.Sua_Thanh_Cong;
                        ClearMessages();
                        tblCommentEO _tblCommentEO = new tblCommentEO();
                        BindDataDetail(_tblCommentEO);
                    }
                    else
                    {
                        lblMsg.Text = Messages.Sua_That_Bai;
                    }
                }
            }
            catch (Exception ex)
            {
                lblMsg.Text = Messages.Loi + ex.Message;
            }
        }
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            ClearMessages();
            lblMsg.Text = "";
            try
            {
                if (tblCommentDAO.Delete(GetObject()) == true)
                {
                    lblMsg.Text = Messages.Xoa_Thanh_Cong;
                    ClearMessages();
                    tblCommentEO _tblCommentEO = new tblCommentEO();
                    BindDataDetail(_tblCommentEO);
                }
                else
                {
                    lblMsg.Text = Messages.Xoa_That_Bai;
                }
            }
            catch (Exception ex)
            {
                lblMsg.Text = Messages.Loi + ex.Message;
            }
        }
        protected void btnReset_Click(object sender, EventArgs e)
        {
            ClearMessages(); lblMsg.Text = "";
            tblCommentEO _tblCommentEO = new tblCommentEO();
            BindDataDetail(_tblCommentEO);
        }
        protected void btnRefresh_Click(object sender, EventArgs e)
        {
            BindDataGrid();
        }
        protected void btnInsertNew_Click(object sender, EventArgs e)
        {
            mtvMain.ActiveViewIndex = 1;
        }
        protected void btnDeleteList_Click(object sender, EventArgs e)
        {
        }
        protected void btnExportExcel_Click(object sender, EventArgs e)
        {
        }
        protected void lbtnBack_Click(object sender, EventArgs e)
        {
            tblCommentEO _tblCommentEO = new tblCommentEO();
            BindDataDetail(_tblCommentEO);
            mtvMain.ActiveViewIndex = 0;
            BindDataGrid();
        }
    }
}