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
    public partial class tblAccountUI : System.Web.UI.Page
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
        private tblAccountEO _objtblAccountEO;
        public tblAccountEO objtblAccountEO
        {
            get { return this._objtblAccountEO; }
            set { _objtblAccountEO = value; }
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
                    PK_iAccountsID = topic.Field<Int32>("PK_iAccountsID"),
                    sUsername = topic.Field<String>("sUsername"),
                    sPassword = topic.Field<String>("sPassword"),
                    sEmail = topic.Field<String>("sEmail"),
                    sFullName = topic.Field<String>("sFullName"),
                    sAddress = topic.Field<String>("sAddress"),
                    tDateOfBirth = topic.Field<DateTime>("tDateOfBirth"),
                    sPhoneNumber = topic.Field<String>("sPhoneNumber"),
                    iPermission = topic.Field<Int16>("iPermission"),
                    sLinkAvatar = topic.Field<String>("sLinkAvatar"),
                    sSignature = topic.Field<String>("sSignature"),
                    iAlias = topic.Field<Int16>("iAlias"),
                    bNotification = topic.Field<Boolean>("bNotification"),
                    iStatus = topic.Field<Int16>("iStatus"),
                    tRegisterDate = topic.Field<DateTime>("tRegisterDate")
                };
            ddlTypeSearch.SelectedValue = typesearch;
            if (Convert.ToInt16(ddlTypeSearch.SelectedValue) == 0)
            {
                if (keysearch != "")
                {
                    var search = (from item in result where item.PK_iAccountsID.ToString().ToUpper().Contains(keysearch.ToString().ToUpper().Trim()) select item);
                    result = search;
                }
            }
            else
            {
                if (keysearch != "")
                {
                    var search = (from item in result where item.sUsername.ToString().ToUpper().Contains(keysearch.ToString().ToUpper().Trim()) select item);
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
            dt = tblAccountDAO.SelectList();
            this.grvList.DataSource = dt;
            this.grvList.DataBind();
            dt.Clear();
            dt = null;
        }

        public void BindDataDetail(tblAccountEO _tblAccountEO)
        {
            this.txtPK_iAccountsID.Text = Convert.ToString(_tblAccountEO.PK_iAccountsID);
            this.txtsUsername.Text = Convert.ToString(_tblAccountEO.sUsername);
            this.txtsPassword.Text = Convert.ToString(_tblAccountEO.sPassword);
            this.txtsEmail.Text = Convert.ToString(_tblAccountEO.sEmail);
            this.txtsFullName.Text = Convert.ToString(_tblAccountEO.sFullName);
            this.txtsAddress.Text = Convert.ToString(_tblAccountEO.sAddress);
            this.txttDateOfBirth.Text = Convert.ToString(_tblAccountEO.tDateOfBirth);
            this.txtsPhoneNumber.Text = Convert.ToString(_tblAccountEO.sPhoneNumber);
            this.txtiPermission.Text = Convert.ToString(_tblAccountEO.iPermission);
            this.txtsLinkAvatar.Text = Convert.ToString(_tblAccountEO.sLinkAvatar);
            this.txtsSignature.Text = Convert.ToString(_tblAccountEO.sSignature);
            this.txtiAlias.Text = Convert.ToString(_tblAccountEO.iAlias);
            this.txtbNotification.Text = Convert.ToString(_tblAccountEO.bNotification);
            this.txtiStatus.Text = Convert.ToString(_tblAccountEO.iStatus);
            this.txttRegisterDate.Text = Convert.ToString(_tblAccountEO.tRegisterDate);
        }

        public void ClearMessages()
        {
            lblPK_iAccountsID.Text = "";
            lblsUsername.Text = "";
            lblsPassword.Text = "";
            lblsEmail.Text = "";
            lblsFullName.Text = "";
            lblsAddress.Text = "";
            lbltDateOfBirth.Text = "";
            lblsPhoneNumber.Text = "";
            lbliPermission.Text = "";
            lblsLinkAvatar.Text = "";
            lblsSignature.Text = "";
            lbliAlias.Text = "";
            lblbNotification.Text = "";
            lbliStatus.Text = "";
            lbltRegisterDate.Text = "";
        }

        public bool CheckInput()
        {
            if (string.IsNullOrEmpty(txtPK_iAccountsID.Text) == true)
            {
                lblPK_iAccountsID.Text = Messages.Khong_Duoc_De_Trong;
                txtPK_iAccountsID.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtsUsername.Text) == true)
            {
                lblsUsername.Text = Messages.Khong_Duoc_De_Trong;
                txtsUsername.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtsPassword.Text) == true)
            {
                lblsPassword.Text = Messages.Khong_Duoc_De_Trong;
                txtsPassword.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtsEmail.Text) == true)
            {
                lblsEmail.Text = Messages.Khong_Duoc_De_Trong;
                txtsEmail.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtsFullName.Text) == true)
            {
                lblsFullName.Text = Messages.Khong_Duoc_De_Trong;
                txtsFullName.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtsAddress.Text) == true)
            {
                lblsAddress.Text = Messages.Khong_Duoc_De_Trong;
                txtsAddress.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txttDateOfBirth.Text) == true)
            {
                lbltDateOfBirth.Text = Messages.Khong_Duoc_De_Trong;
                txttDateOfBirth.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtiPermission.Text) == true)
            {
                lbliPermission.Text = Messages.Khong_Duoc_De_Trong;
                txtiPermission.Focus();
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

        public tblAccountEO GetObject()
        {
            tblAccountEO _tblAccountEO = new tblAccountEO();
            try
            {
                _tblAccountEO.PK_iAccountsID = Convert.ToInt32(this.txtPK_iAccountsID.Text);
                _tblAccountEO.sUsername = Convert.ToString(this.txtsUsername.Text);
                _tblAccountEO.sPassword = Convert.ToString(this.txtsPassword.Text);
                _tblAccountEO.sEmail = Convert.ToString(this.txtsEmail.Text);
                _tblAccountEO.sFullName = Convert.ToString(this.txtsFullName.Text);
                _tblAccountEO.sAddress = Convert.ToString(this.txtsAddress.Text);
                _tblAccountEO.tDateOfBirth = Convert.ToDateTime(this.txttDateOfBirth.Text);
                _tblAccountEO.sPhoneNumber = Convert.ToString(this.txtsPhoneNumber.Text);
                _tblAccountEO.iPermission = Convert.ToInt16(this.txtiPermission.Text);
                _tblAccountEO.sLinkAvatar = Convert.ToString(this.txtsLinkAvatar.Text);
                _tblAccountEO.sSignature = Convert.ToString(this.txtsSignature.Text);
                _tblAccountEO.iAlias = Convert.ToInt16(this.txtiAlias.Text);
                _tblAccountEO.bNotification = Convert.ToBoolean(this.txtbNotification.Text);
                _tblAccountEO.iStatus = Convert.ToInt16(this.txtiStatus.Text);
                _tblAccountEO.tRegisterDate = Convert.ToDateTime(this.txttRegisterDate.Text);
                return _tblAccountEO;
            }
            catch
            {
                return _tblAccountEO;
            }
        }

        protected void grvList_RowCommand(object source, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "cmdView")
            {
                GridViewRow row = this.grvList.SelectedRow;
                int index = Convert.ToInt16(e.CommandArgument) % grvList.PageSize;
                objtblAccountEO = new tblAccountEO();
                objtblAccountEO.PK_iAccountsID = Convert.ToInt32(grvList.DataKeys[index].Values["PK_iAccountsID"]);
                objtblAccountEO = tblAccountDAO.SelectItem(objtblAccountEO);
                BindDataDetail(objtblAccountEO);
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
            DataTable dt = tblAccountDAO.SelectList();
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
                    if (tblAccountDAO.Insert(GetObject()) == true)
                    {
                        lblMsg.Text = Messages.Them_Thanh_Cong;
                        ClearMessages();
                        tblAccountEO _tblAccountEO = new tblAccountEO();
                        BindDataDetail(_tblAccountEO);
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
                    if (tblAccountDAO.Update(GetObject()) == true)
                    {
                        lblMsg.Text = Messages.Sua_Thanh_Cong;
                        ClearMessages();
                        tblAccountEO _tblAccountEO = new tblAccountEO();
                        BindDataDetail(_tblAccountEO);
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
                if (tblAccountDAO.Delete(GetObject()) == true)
                {
                    lblMsg.Text = Messages.Xoa_Thanh_Cong;
                    ClearMessages();
                    tblAccountEO _tblAccountEO = new tblAccountEO();
                    BindDataDetail(_tblAccountEO);
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
            tblAccountEO _tblAccountEO = new tblAccountEO();
            BindDataDetail(_tblAccountEO);
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
            tblAccountEO _tblAccountEO = new tblAccountEO();
            BindDataDetail(_tblAccountEO);
            mtvMain.ActiveViewIndex = 0;
            BindDataGrid();
        }
    }
}