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
    public partial class Topic : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataSet dsTopic = TopicBO.Topic_SelectListbyTopic_Status(true);
                ListTopicUC1.lblTitle.Text = "Danh sách các bài viết";
                ListTopicUC1.dsTopic = dsTopic;

                DataSet dsTopicBlock = TopicBO.Topic_SelectListbyTopic_Status(false);
                ListTopicUC2.lblTitle.Text = "Danh sách các bài viết bị khóa";
                ListTopicUC2.dsTopic = dsTopicBlock;
            }
        }
    }
}