using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Data;

namespace nguyenmanhthang.UserControl
{
    public partial class DroplistKey : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void ddlValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtKey.Text = ddlValue.SelectedIndex.ToString();
        }

        public void DataSource(SortedList sl)
        {
            ddlValue.DataSource = sl;
            ddlValue.DataValueField = "Key";
            ddlValue.DataTextField = "Value";
            ddlValue.DataBind();
        }

        protected void ddlValue_TextChanged(object sender, EventArgs e)
        {

        }
    }
}