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
    public partial class tblTopicUI : System.Web.UI.Page
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
        private tblTopicEO _objtblTopicEO;
        public tblTopicEO objtblTopicEO
        {
            get { return this._objtblTopicEO; }
            set { _objtblTopicEO = value; }
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
                    PK_lTopicID = topic.Field<Int64>("PK_lTopicID"),
                    FK_iCategoryID = topic.Field<Int16>("FK_iCategoryID"),
                    FK_iAccountsID = topic.Field<Int32>("FK_iAccountsID"),
                    sTitle = topic.Field<String>("sTitle"),
                    sLinkImage = topic.Field<String>("sLinkImage"),
                    sContent = topic.Field<String>("sContent"),
                    sDescription = topic.Field<String>("sDescription"),
                    iVisit = topic.Field<Int32>("iVisit"),
                    iLike = topic.Field<Int32>("iLike"),
                    iStatus = topic.Field<Int16>("iStatus"),
                    tLastUpdate = topic.Field<DateTime>("tLastUpdate")
                };
            ddlTypeSearch.SelectedValue = typesearch;
            if (Convert.ToInt16(ddlTypeSearch.SelectedValue) == 0)
            {
                if (keysearch != "")
                {
                    var search = (from item in result where item.PK_lTopicID.ToString().ToUpper().Contains(keysearch.ToString().ToUpper().Trim()) select item);
                    result = search;
                }
            }
            else
            {
                if (keysearch != "")
                {
                    var search = (from item in result where item.FK_iCategoryID.ToString().ToUpper().Contains(keysearch.ToString().ToUpper().Trim()) select item);
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
            dt = tblTopicDAO.SelectList();
            this.grvList.DataSource = dt;
            this.grvList.DataBind();
            dt.Clear();
            dt = null;
        }

        public void BindDataDetail(tblTopicEO _tblTopicEO)
        {
            this.txtPK_lTopicID.Text = Convert.ToString(_tblTopicEO.PK_lTopicID);
            this.ddlFK_iCategoryID.SelectedValue = Convert.ToString(_tblTopicEO.FK_iCategoryID);
            this.ddlFK_iAccountsID.SelectedValue = Convert.ToString(_tblTopicEO.FK_iAccountsID);
            this.txtsTitle.Text = Convert.ToString(_tblTopicEO.sTitle);
            this.txtsLinkImage.Text = Convert.ToString(_tblTopicEO.sLinkImage);
            this.txtsContent.Text = Convert.ToString(_tblTopicEO.sContent);
            this.txtsDescription.Text = Convert.ToString(_tblTopicEO.sDescription);
            this.txtiVisit.Text = Convert.ToString(_tblTopicEO.iVisit);
            this.txtiLike.Text = Convert.ToString(_tblTopicEO.iLike);
            this.txtiStatus.Text = Convert.ToString(_tblTopicEO.iStatus);
            this.txttLastUpdate.Text = Convert.ToString(_tblTopicEO.tLastUpdate);
        }

        public void ClearMessages()
        {
            lblPK_lTopicID.Text = "";
            lblFK_iCategoryID.Text = "";
            lblFK_iAccountsID.Text = "";
            lblsTitle.Text = "";
            lblsLinkImage.Text = "";
            lblsContent.Text = "";
            lblsDescription.Text = "";
            lbliVisit.Text = "";
            lbliLike.Text = "";
            lbliStatus.Text = "";
            lbltLastUpdate.Text = "";
        }

        public bool CheckInput()
        {
            if (string.IsNullOrEmpty(txtPK_lTopicID.Text) == true)
            {
                lblPK_lTopicID.Text = Messages.Khong_Duoc_De_Trong;
                txtPK_lTopicID.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtiStatus.Text) == true)
            {
                lbliStatus.Text = Messages.Khong_Duoc_De_Trong;
                txtiStatus.Focus();
                return false;
            }
            return true;
        }

        public tblTopicEO GetObject()
        {
            tblTopicEO _tblTopicEO = new tblTopicEO();
            try
            {
                _tblTopicEO.PK_lTopicID = Convert.ToInt64(this.txtPK_lTopicID.Text);
                _tblTopicEO.FK_iCategoryID = Convert.ToInt16(this.ddlFK_iCategoryID.SelectedValue);
                _tblTopicEO.FK_iAccountsID = Convert.ToInt32(this.ddlFK_iAccountsID.SelectedValue);
                _tblTopicEO.sTitle = Convert.ToString(this.txtsTitle.Text);
                _tblTopicEO.sLinkImage = Convert.ToString(this.txtsLinkImage.Text);
                _tblTopicEO.sContent = Convert.ToString(this.txtsContent.Text);
                _tblTopicEO.sDescription = Convert.ToString(this.txtsDescription.Text);
                _tblTopicEO.iVisit = Convert.ToInt32(this.txtiVisit.Text);
                _tblTopicEO.iLike = Convert.ToInt32(this.txtiLike.Text);
                _tblTopicEO.iStatus = Convert.ToInt16(this.txtiStatus.Text);
                _tblTopicEO.tLastUpdate = Convert.ToDateTime(this.txttLastUpdate.Text);
                return _tblTopicEO;
            }
            catch
            {
                return _tblTopicEO;
            }
        }

        protected void grvList_RowCommand(object source, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "cmdView")
            {
                GridViewRow row = this.grvList.SelectedRow;
                int index = Convert.ToInt16(e.CommandArgument) % grvList.PageSize;
                objtblTopicEO = new tblTopicEO();
                objtblTopicEO.PK_lTopicID = Convert.ToInt64(grvList.DataKeys[index].Values["PK_lTopicID"]);
                objtblTopicEO = tblTopicDAO.SelectItem(objtblTopicEO);
                BindDataDetail(objtblTopicEO);
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
            DataTable dt = tblTopicDAO.SelectList();
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
                    if (tblTopicDAO.Insert(GetObject()) == true)
                    {
                        lblMsg.Text = Messages.Them_Thanh_Cong;
                        ClearMessages();
                        tblTopicEO _tblTopicEO = new tblTopicEO();
                        BindDataDetail(_tblTopicEO);
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
                    if (tblTopicDAO.Update(GetObject()) == true)
                    {
                        lblMsg.Text = Messages.Sua_Thanh_Cong;
                        ClearMessages();
                        tblTopicEO _tblTopicEO = new tblTopicEO();
                        BindDataDetail(_tblTopicEO);
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
                if (tblTopicDAO.Delete(GetObject()) == true)
                {
                    lblMsg.Text = Messages.Xoa_Thanh_Cong;
                    ClearMessages();
                    tblTopicEO _tblTopicEO = new tblTopicEO();
                    BindDataDetail(_tblTopicEO);
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
            tblTopicEO _tblTopicEO = new tblTopicEO();
            BindDataDetail(_tblTopicEO);
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
            tblTopicEO _tblTopicEO = new tblTopicEO();
            BindDataDetail(_tblTopicEO);
            mtvMain.ActiveViewIndex = 0;
            BindDataGrid();
        }
    }
}