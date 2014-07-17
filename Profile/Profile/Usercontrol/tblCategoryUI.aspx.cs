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
    public partial class tblCategoryUI : System.Web.UI.Page
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
        private tblCategoryEO _objtblCategoryEO;
        public tblCategoryEO objtblCategoryEO
        {
            get { return this._objtblCategoryEO; }
            set { _objtblCategoryEO = value; }
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
            DataTable dt = tblCategoryDAO.SelectList();
            var result =
                from topic in dt.AsEnumerable()
                select new
                {
                    PK_iCategoryID = topic.Field<Int16>("PK_iCategoryID"),
                    iParent = topic.Field<Int16>("iParent"),
                    sName = topic.Field<String>("sName"),
                    iStatus = topic.Field<Int16>("iStatus")
                };
            ddlTypeSearch.SelectedValue = typesearch;
            if (Convert.ToInt16(ddlTypeSearch.SelectedValue) == 0)
            {
                if (keysearch != "")
                {
                    var search = (from item in result where item.PK_iCategoryID.ToString().ToUpper().Contains(keysearch.ToString().ToUpper().Trim()) select item);
                    result = search;
                }
            }
            else
            {
                if (keysearch != "")
                {
                    var search = (from item in result where item.iParent.ToString().ToUpper().Contains(keysearch.ToString().ToUpper().Trim()) select item);
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
            dt = tblCategoryDAO.SelectList();
            this.grvList.DataSource = dt;
            this.grvList.DataBind();
            dt.Clear();
            dt = null;
        }

        public void BindDataDetail(tblCategoryEO _tblCategoryEO)
        {
            this.txtPK_iCategoryID.Text = Convert.ToString(_tblCategoryEO.PK_iCategoryID);
            this.txtiParent.Text = Convert.ToString(_tblCategoryEO.iParent);
            this.txtsName.Text = Convert.ToString(_tblCategoryEO.sName);
            this.txtiStatus.Text = Convert.ToString(_tblCategoryEO.iStatus);
        }

        public void ClearMessages()
        {
            lblPK_iCategoryID.Text = "";
            lbliParent.Text = "";
            lblsName.Text = "";
            lbliStatus.Text = "";
        }

        public bool CheckInput()
        {
            if (string.IsNullOrEmpty(txtPK_iCategoryID.Text) == true)
            {
                lblPK_iCategoryID.Text = Messages.Khong_Duoc_De_Trong;
                txtPK_iCategoryID.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtiParent.Text) == true)
            {
                lbliParent.Text = Messages.Khong_Duoc_De_Trong;
                txtiParent.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtsName.Text) == true)
            {
                lblsName.Text = Messages.Khong_Duoc_De_Trong;
                txtsName.Focus();
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

        public tblCategoryEO GetObject()
        {
            tblCategoryEO _tblCategoryEO = new tblCategoryEO();
            try
            {
                _tblCategoryEO.PK_iCategoryID = Convert.ToInt16(this.txtPK_iCategoryID.Text);
                _tblCategoryEO.iParent = Convert.ToInt16(this.txtiParent.Text);
                _tblCategoryEO.sName = Convert.ToString(this.txtsName.Text);
                _tblCategoryEO.iStatus = Convert.ToInt16(this.txtiStatus.Text);
                return _tblCategoryEO;
            }
            catch
            {
                return _tblCategoryEO;
            }
        }

        protected void grvList_RowCommand(object source, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "cmdView")
            {
                GridViewRow row = this.grvList.SelectedRow;
                int index = Convert.ToInt16(e.CommandArgument) % grvList.PageSize;
                objtblCategoryEO = new tblCategoryEO();
                objtblCategoryEO.PK_iCategoryID = Convert.ToInt16(grvList.DataKeys[index].Values["PK_iCategoryID"]);
                objtblCategoryEO = tblCategoryDAO.SelectItem(objtblCategoryEO);
                BindDataDetail(objtblCategoryEO);
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
            DataTable dt = tblCategoryDAO.SelectList();
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
                    if (tblCategoryDAO.Insert(GetObject()) == true)
                    {
                        lblMsg.Text = Messages.Them_Thanh_Cong;
                        ClearMessages();
                        tblCategoryEO _tblCategoryEO = new tblCategoryEO();
                        BindDataDetail(_tblCategoryEO);
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
                    if (tblCategoryDAO.Update(GetObject()) == true)
                    {
                        lblMsg.Text = Messages.Sua_Thanh_Cong;
                        ClearMessages();
                        tblCategoryEO _tblCategoryEO = new tblCategoryEO();
                        BindDataDetail(_tblCategoryEO);
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
                if (tblCategoryDAO.Delete(GetObject()) == true)
                {
                    lblMsg.Text = Messages.Xoa_Thanh_Cong;
                    ClearMessages();
                    tblCategoryEO _tblCategoryEO = new tblCategoryEO();
                    BindDataDetail(_tblCategoryEO);
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
            tblCategoryEO _tblCategoryEO = new tblCategoryEO();
            BindDataDetail(_tblCategoryEO);
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
            tblCategoryEO _tblCategoryEO = new tblCategoryEO();
            BindDataDetail(_tblCategoryEO);
            mtvMain.ActiveViewIndex = 0;
            BindDataGrid();
        }
    }
}