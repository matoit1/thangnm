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
    public partial class ListTopicUC : System.Web.UI.UserControl
    {
        private DataSet _dsTopic;
        public DataSet dsTopic
        {
            get { return this._dsTopic; }
            set { _dsTopic = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindDataGrid(dsTopic);
            }
        }

        protected void BindDataGrid(DataSet ds)
        {
            try
            {
                grvListTopic.DataSource = ds;
                grvListTopic.DataBind();
                lblSo_BanGhi.Text = ds.Tables[0].Rows.Count.ToString();
            }
            catch { }
        }

        protected void grvListTopic_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grvListTopic.PageIndex = e.NewPageIndex;
            BindDataGrid(dsTopic);
        }

        protected void grvListTopic_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "cmdView")
            {
                Int64 Topic_ID = Convert.ToInt64(e.CommandArgument);
            }
        }
    }
}