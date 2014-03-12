using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using DataAccessObject;
using EntityObject;
using System.Data;

namespace DO_AN_TN.UserControl
{
    public partial class SinhVien_ListUC : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            grvList.DataSource = SqlDataSource1;
            grvList.DataBind();
            grvList.SelectedRowStyle.BackColor = System.Drawing.Color.Yellow;
        }

        protected void grvList_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "cmdView")
            {
                Int64  Accounts_ID = Convert.ToInt64(e.CommandArgument);
                //if (ViewAccounts != null)
                //{
                //    ViewAccounts(this, EventArgs.Empty);
                //}
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
            try
            {
                bindinfo(Convert.ToInt64(grvList.DataKeys[grvList.SelectedIndex].Values["Accounts_ID"]));
            }
            catch (Exception)
            {
            }
        }

        protected void grvList_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(grvList, "Select$" + e.Row.RowIndex);
                e.Row.ToolTip = "Click to select this row.";
            }
        }

        public void bindinfo(Int64 input){
            AccountsEO a = new AccountsEO();
            a.Accounts_ID = input;
            DataSet ds = AccountsDAO.SelectInfoByAccounts_ID(a);
            txtMa.Text = ds.Tables[0].Rows[0]["Accounts_ID"].ToString();
            txtTen.Text = ds.Tables[0].Rows[0]["Accounts_Username"].ToString();
            txtEmail.Text = ds.Tables[0].Rows[0]["Accounts_Email"].ToString();
            txtHoten.Text = ds.Tables[0].Rows[0]["Accounts_FullName"].ToString();
        }
    }
}