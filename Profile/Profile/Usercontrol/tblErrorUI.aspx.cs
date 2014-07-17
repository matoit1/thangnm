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
    public partial class tblErrorUI : System.Web.UI.Page
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
        private tblErrorEO _objtblErrorEO;
        public tblErrorEO objtblErrorEO
        {
            get { return this._objtblErrorEO; }
            set { _objtblErrorEO = value; }
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
                    PK_lErrorID = topic.Field<Int64>("PK_lErrorID"),
                    sLink = topic.Field<String>("sLink"),
                    sIP = topic.Field<String>("sIP"),
                    sBrowser = topic.Field<String>("sBrowser"),
                    iCode = topic.Field<Int32>("iCode"),
                    iStatus = topic.Field<Int16>("iStatus"),
                    tTime = topic.Field<DateTime>("tTime"),
                    tTimeCheck = topic.Field<DateTime>("tTimeCheck")
                };
            ddlTypeSearch.SelectedValue = typesearch;
            if (Convert.ToInt16(ddlTypeSearch.SelectedValue) == 0)
            {
                if (keysearch != "")
                {
                    var search = (from item in result where item.PK_lErrorID.ToString().ToUpper().Contains(keysearch.ToString().ToUpper().Trim()) select item);
                    result = search;
                }
            }
            else
            {
                if (keysearch != "")
                {
                    var search = (from item in result where item.sLink.ToString().ToUpper().Contains(keysearch.ToString().ToUpper().Trim()) select item);
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
            dt = tblErrorDAO.SelectList();
            this.grvList.DataSource = dt;
            this.grvList.DataBind();
            dt.Clear();
            dt = null;
        }

        public void BindDataDetail(tblErrorEO _tblErrorEO)
        {
            this.txtPK_lErrorID.Text = Convert.ToString(_tblErrorEO.PK_lErrorID);
            this.txtsLink.Text = Convert.ToString(_tblErrorEO.sLink);
            this.txtsIP.Text = Convert.ToString(_tblErrorEO.sIP);
            this.txtsBrowser.Text = Convert.ToString(_tblErrorEO.sBrowser);
            this.txtiCode.Text = Convert.ToString(_tblErrorEO.iCode);
            this.txtiStatus.Text = Convert.ToString(_tblErrorEO.iStatus);
            this.txttTime.Text = Convert.ToString(_tblErrorEO.tTime);
            this.txttTimeCheck.Text = Convert.ToString(_tblErrorEO.tTimeCheck);
        }

        public void ClearMessages()
        {
            lblPK_lErrorID.Text = "";
            lblsLink.Text = "";
            lblsIP.Text = "";
            lblsBrowser.Text = "";
            lbliCode.Text = "";
            lbliStatus.Text = "";
            lbltTime.Text = "";
            lbltTimeCheck.Text = "";
        }

        public bool CheckInput()
        {
            if (string.IsNullOrEmpty(txtPK_lErrorID.Text) == true)
            {
                lblPK_lErrorID.Text = Messages.Khong_Duoc_De_Trong;
                txtPK_lErrorID.Focus();
                return false;
            }
            return true;
        }

        public tblErrorEO GetObject()
        {
            tblErrorEO _tblErrorEO = new tblErrorEO();
            try
            {
                _tblErrorEO.PK_lErrorID = Convert.ToInt64(this.txtPK_lErrorID.Text);
                _tblErrorEO.sLink = Convert.ToString(this.txtsLink.Text);
                _tblErrorEO.sIP = Convert.ToString(this.txtsIP.Text);
                _tblErrorEO.sBrowser = Convert.ToString(this.txtsBrowser.Text);
                _tblErrorEO.iCode = Convert.ToInt32(this.txtiCode.Text);
                _tblErrorEO.iStatus = Convert.ToInt16(this.txtiStatus.Text);
                _tblErrorEO.tTime = Convert.ToDateTime(this.txttTime.Text);
                _tblErrorEO.tTimeCheck = Convert.ToDateTime(this.txttTimeCheck.Text);
                return _tblErrorEO;
            }
            catch
            {
                return _tblErrorEO;
            }
        }

        protected void grvList_RowCommand(object source, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "cmdView")
            {
                GridViewRow row = this.grvList.SelectedRow;
                int index = Convert.ToInt16(e.CommandArgument) % grvList.PageSize;
                objtblErrorEO = new tblErrorEO();
                objtblErrorEO.PK_lErrorID = Convert.ToInt64(grvList.DataKeys[index].Values["PK_lErrorID"]);
                objtblErrorEO = tblErrorDAO.SelectItem(objtblErrorEO);
                BindDataDetail(objtblErrorEO);
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
            DataTable dt = tblErrorDAO.SelectList();
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
                    if (tblErrorDAO.Insert(GetObject()) == true)
                    {
                        lblMsg.Text = Messages.Them_Thanh_Cong;
                        ClearMessages();
                        tblErrorEO _tblErrorEO = new tblErrorEO();
                        BindDataDetail(_tblErrorEO);
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
                    if (tblErrorDAO.Update(GetObject()) == true)
                    {
                        lblMsg.Text = Messages.Sua_Thanh_Cong;
                        ClearMessages();
                        tblErrorEO _tblErrorEO = new tblErrorEO();
                        BindDataDetail(_tblErrorEO);
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
                if (tblErrorDAO.Delete(GetObject()) == true)
                {
                    lblMsg.Text = Messages.Xoa_Thanh_Cong;
                    ClearMessages();
                    tblErrorEO _tblErrorEO = new tblErrorEO();
                    BindDataDetail(_tblErrorEO);
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
            tblErrorEO _tblErrorEO = new tblErrorEO();
            BindDataDetail(_tblErrorEO);
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
            tblErrorEO _tblErrorEO = new tblErrorEO();
            BindDataDetail(_tblErrorEO);
            mtvMain.ActiveViewIndex = 0;
            BindDataGrid();
        }
    }
}