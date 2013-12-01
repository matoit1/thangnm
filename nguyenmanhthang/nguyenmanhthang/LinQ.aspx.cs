using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BusinessObject;
using System.Collections;

namespace nguyenmanhthang
{
    public partial class LinQ : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindDataGrid(true);
        }

        public void BindDataGrid(bool _Accounts_Status)
        {
            try
            {
                DataSet dsAccounts = AccountsBO.SelectListByAccounts_Status(_Accounts_Status);
                grvDemo.DataSource = dsAccounts;
                grvDemo.DataBind();
                EnumerableRowCollection  emaDSTokhai = dsAccounts.Tables[0].AsEnumerable();
                IEnumerable res = from item in (dsAccounts.Tables[0].AsEnumerable()) select item;
                //lblTongSoBanGhi.Text = (from item in res select item.Accounts_ID).Count().ToString();
            }
            catch { }
        }
    }
}