using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BusinessObject;

namespace nguyenmanhthang.UserControl
{
    public partial class AccountsListUC : System.Web.UI.UserControl
    {
        #region "Khai Báo Biến, Thuộc tính"
        public event EventHandler ViewAccounts;
        public event EventHandler PageChangeAccounts;
        public bool isBlock;
        private Int64 _Accounts_ID;
        public Int64 Accounts_ID
        {
            get { return this._Accounts_ID; }
            set { _Accounts_ID = value; }
        }
        public bool Accounts_Status
        {
            get { return Convert.ToBoolean(ViewState["Accounts_Status"]); }
            set { ViewState["Accounts_Status"] = value; }
        }
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindDataGrid(Accounts_Status, true);
            }
        }
        public void BindDataGrid(bool _Accounts_Status, bool state_Page)
        {
            if (!state_Page){
                grvListAccounts.PageIndex = 0;
            }
            try
            {
                DataSet dsAccounts = AccountsBO.SelectListByAccounts_Status(_Accounts_Status);
                grvListAccounts.DataSource = dsAccounts;
                grvListAccounts.DataBind();
                lblSo_BanGhi.Text = dsAccounts.Tables[0].Rows.Count.ToString();
            }
            catch { }
        }

        protected void grvListAccounts_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            if (PageChangeAccounts != null)
            {
                PageChangeAccounts(this, EventArgs.Empty);
            }
            grvListAccounts.PageIndex = e.NewPageIndex;
            BindDataGrid(Accounts_Status, true);
        }

        protected void grvListAccounts_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "cmdView")
            {
                this.Accounts_ID = Convert.ToInt64(e.CommandArgument);
                if (ViewAccounts != null)
                {
                    ViewAccounts(this, EventArgs.Empty);
                }
            }
        }
    }
}