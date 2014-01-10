using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BusinessObject;
using nguyenmanhthang.Library.Common;

namespace nguyenmanhthang
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadTopic();
            }
        }

        public void loadTopic()
        {
            try
            {
                DataSet ds = TopicBO.Topic_SelectListToShow(true, 10);
                ds.Tables[0].Columns.Add(new DataColumn("link"));
                for (int i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                {
                    ds.Tables[0].Rows[i]["link"] = RewriteUrl.ConvertToUnSign(ds.Tables[0].Rows[i]["Topic_Title"].ToString());
                }
                rpTopic.DataSource = ds;
                rpTopic.DataBind();
            }
            catch (Exception) { }
        }
    }
}