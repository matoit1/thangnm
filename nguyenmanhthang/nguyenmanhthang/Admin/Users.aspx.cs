using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BusinessObject;

namespace nguyenmanhthang.Admin
{
    public partial class Users : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                AccountsListUC1.Accounts_Status =true;
                AccountsListUC2.Accounts_Status = false;
                tabDetail.Enabled = false;
            }
        }

        protected void Back_Click(object sender, EventArgs e)
        {
            tabDetail.Enabled = false;
            tabAccounts.Enabled = true;
            tabAccountsBlock.Enabled = true;
            tabMain.ActiveTab = tabAccounts;
        }

        protected void PageChangeAccounts_Click(object sender, EventArgs e)
        {
            tabMain.ActiveTab = tabAccounts;
        }

        protected void PageChangeAccountsBlock_Click(object sender, EventArgs e)
        {
            tabMain.ActiveTab = tabAccountsBlock;
        }

        protected void ViewAccounts_Click(object sender, EventArgs e)
        {
            Int64 ID = AccountsListUC1.Accounts_ID;
            AccountsDetailUC1.state = false;
            AccountsDetailUC1.LoadDetailAccounts(ID, false);
            tabMain.ActiveTab = tabDetail;
            tabAccounts.Enabled = false;
            tabAccountsBlock.Enabled = false;
            tabDetail.Enabled = true;
        }

        protected void ViewAccountsBlock_Click(object sender, EventArgs e)
        {
            Int64 ID = AccountsListUC2.Accounts_ID;
            AccountsDetailUC1.state = false;
            AccountsDetailUC1.LoadDetailAccounts(ID, false);
            tabMain.ActiveTab = tabDetail;
            tabAccounts.Enabled = false;
            tabAccountsBlock.Enabled = false;
            tabDetail.Enabled = true;
        }
    }
}