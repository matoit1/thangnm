using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace HaBa.UserControl
{
    public partial class Gallery3DUC : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {

                }
            }
            catch
            {
            }
        }

        public void BindData(DataSet input)
        {
            rptAdv.DataSource = input;
            rptAdv.DataBind();
        }
    }
}