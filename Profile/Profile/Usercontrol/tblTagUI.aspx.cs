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
    public partial class tblTagUI : System.Web.UI.Page
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
        private tblTagEO _objtblTagEO;
        public tblTagEO objtblTagEO
        {
            get { return this._objtblTagEO; }
            set { _objtblTagEO = value; }
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
                    PK_sTagID = topic.Field<Int16>("PK_sTagID"),
                    FK_lTopicID = topic.Field<Int64>("FK_lTopicID"),
                    sName = topic.Field<String>("sName")
                };
            ddlTypeSearch.SelectedValue = typesearch;
            if (Convert.ToInt16(ddlTypeSearch.SelectedValue) == 0)
            {
                if (keysearch != "")
                {
                    var search = (from item in result where item.PK_sTagID.ToString().ToUpper().Contains(keysearch.ToString().ToUpper().Trim()) select item);
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
            dt = tblTagDAO.SelectList();
            this.grvList.DataSource = dt;
            this.grvList.DataBind();
            dt.Clear();
            dt = null;
        }

        public void BindDataDetail(tblTagEO _tblTagEO)
        {
            this.txtPK_sTagID.Text = Convert.ToString(_tblTagEO.PK_sTagID);
            this.ddlFK_lTopicID.SelectedValue = Convert.ToString(_tblTagEO.FK_lTopicID);
            this.txtsName.Text = Convert.ToString(_tblTagEO.sName);
        }

        public void ClearMessages()
        {
            lblPK_sTagID.Text = "";
            lblFK_lTopicID.Text = "";
            lblsName.Text = "";
        }

        public bool CheckInput()
        {
            if (string.IsNullOrEmpty(txtPK_sTagID.Text) == true)
            {
                lblPK_sTagID.Text = Messages.Khong_Duoc_De_Trong;
                txtPK_sTagID.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtsName.Text) == true)
            {
                lblsName.Text = Messages.Khong_Duoc_De_Trong;
                txtsName.Focus();
                return false;
            }
            return true;
        }

        public tblTagEO GetObject()
        {
            tblTagEO _tblTagEO = new tblTagEO();
            try
            {
                _tblTagEO.PK_sTagID = Convert.ToString(this.txtPK_sTagID.Text);
                _tblTagEO.FK_lTopicID = Convert.ToInt64(this.ddlFK_lTopicID.SelectedValue);
                _tblTagEO.sName = Convert.ToString(this.txtsName.Text);
                return _tblTagEO;
            }
            catch
            {
                return _tblTagEO;
            }
        }

        protected void grvList_RowCommand(object source, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "cmdView")
            {
                GridViewRow row = this.grvList.SelectedRow;
                int index = Convert.ToInt16(e.CommandArgument) % grvList.PageSize;
                objtblTagEO = new tblTagEO();
                objtblTagEO.PK_sTagID = Convert.ToString(grvList.DataKeys[index].Values["PK_sTagID"]);
                objtblTagEO = tblTagDAO.SelectItem(objtblTagEO);
                BindDataDetail(objtblTagEO);
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
            DataTable dt = tblTagDAO.SelectList();
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
                    if (tblTagDAO.Insert(GetObject()) == true)
                    {
                        lblMsg.Text = Messages.Them_Thanh_Cong;
                        ClearMessages();
                        tblTagEO _tblTagEO = new tblTagEO();
                        BindDataDetail(_tblTagEO);
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
                    if (tblTagDAO.Update(GetObject()) == true)
                    {
                        lblMsg.Text = Messages.Sua_Thanh_Cong;
                        ClearMessages();
                        tblTagEO _tblTagEO = new tblTagEO();
                        BindDataDetail(_tblTagEO);
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
                if (tblTagDAO.Delete(GetObject()) == true)
                {
                    lblMsg.Text = Messages.Xoa_Thanh_Cong;
                    ClearMessages();
                    tblTagEO _tblTagEO = new tblTagEO();
                    BindDataDetail(_tblTagEO);
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
            ClearMessages();
            lblMsg.Text = "";
            tblTagEO _tblTagEO = new tblTagEO();
            BindDataDetail(_tblTagEO);
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
            tblTagEO _tblTagEO = new tblTagEO();
            BindDataDetail(_tblTagEO);
            mtvMain.ActiveViewIndex = 0;
            BindDataGrid();
        }
    }
}