using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace DO_AN_TN.Test
{
    public partial class TestXML : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadQuangCao(Server.MapPath("~/App_Data/QuangCao.xml"));
        }

        protected void LoadQuangCao(string xmlFilePath)
        {
            try
            {
                DataSet ds = new DataSet();
                DataTable table = new DataTable();
                ds.ReadXml(xmlFilePath);
                dlQuangCao.DataSource = ds;
                dlQuangCao.DataBind();
            }
            catch { }
        }
    }
}