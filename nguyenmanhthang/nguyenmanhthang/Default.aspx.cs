using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BusinessObject;

namespace nguyenmanhthang
{
    public partial class Default1 : System.Web.UI.Page
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
                DataSet dt = TopicBO.Topic_SelectListToShow(true, 10);
                rpTopic.DataSource = dt;
                rpTopic.DataBind();
            }
            catch (Exception) { }
        }
    }
}