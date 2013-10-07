using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using DataAccessObject;
using System.Data;
using BusinessObject;

namespace ThangNMjsc.Test
{
    public partial class TestMenu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            getMenu();
        }

        private void getMenu()
        {
            DataTable dt = ProductsBO.getDataSetGroupProducts(0).Tables[0];
            parentRepeater.DataSource = dt;
            parentRepeater.DataBind();
            DataSet ds = new DataSet();
            //ds.Relations.Add(ds.Tables[0].Columns["Products_ID"]);
            ////ds.Tables["Products"].Columns["Products_ID"],
            ////ds.Tables["Products"].Columns["Products_ID"]);
        }
    }
}