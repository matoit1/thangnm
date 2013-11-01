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
                TopicListUC1.lblTitle.Text = "Danh sách các bài viết";
                TopicListUC1.isBlock = false;
                TopicListUC1.dsTopic = dsTopic;
                DataSet dsTopicBlock = TopicBO.Topic_SelectListbyTopic_Status(false);
                TopicListUC2.lblTitle.Text = "Danh sách các bài viết bị khóa";
                TopicListUC2.isBlock = true;
                TopicListUC2.dsTopic = dsTopicBlock;
            }
        }

        protected void ViewTopic_Click(object sender, EventArgs e)
        {
            Int64 Topic_ID = TopicListUC1.Topic_ID;
            mtvMain.ActiveViewIndex = 1;
            TopicDetailUC1.LoadDetailTopic(Topic_ID, false);
        }

        protected void ViewTopicBlock_Click(object sender, EventArgs e)
        {
            Int64 Topic_ID = TopicListUC2.Topic_ID;
            mtvMain.ActiveViewIndex = 1;
            TopicDetailUC1.LoadDetailTopic(Topic_ID, false);
        }

        protected void Back_Click(object sender, EventArgs e)
        {
            mtvMain.ActiveViewIndex = 0;
        }

        protected void PageChangeTopic_Click(object sender, EventArgs e)
        {
            DataSet dsTopic = TopicBO.Topic_SelectListbyTopic_Status(true);
            TopicListUC1.dsTopic = dsTopic;
            tabMain.ActiveTab = TabTopic;
        }

        protected void PageChangeTopicBlock_Click(object sender, EventArgs e)
        {
            DataSet dsTopic = TopicBO.Topic_SelectListbyTopic_Status(false);
            TopicListUC2.dsTopic = dsTopic;
            tabMain.ActiveTab = TabTopicBlock;
        }

        protected void NewTopic_Click(object sender, EventArgs e)
        {
            mtvMain.ActiveViewIndex = 1;
            TopicDetailUC1.LoadDetailTopic(0, true);
        }

        protected void DeleteTopic_Click(object sender, EventArgs e)
        {
            DataSet dsTopic = TopicBO.Topic_SelectListbyTopic_Status(true);
            TopicListUC1.lblTitle.Text = "Danh sách các bài viết";
            TopicListUC1.isBlock = false;
            TopicListUC1.dsTopic = dsTopic;
            TopicListUC1.ReBindDataGrid();
            DataSet dsTopicBlock = TopicBO.Topic_SelectListbyTopic_Status(false);
            TopicListUC2.lblTitle.Text = "Danh sách các bài viết bị khóa";
            TopicListUC2.isBlock = true;
            TopicListUC2.dsTopic = dsTopicBlock;
            TopicListUC2.ReBindDataGrid();
        }

        protected void ExportToExcelTopic_Click(object sender, EventArgs e)
        {
            DataSet dsTopic = TopicBO.Topic_SelectListbyTopic_Status(true);
            TopicListUC1.dsTopic = dsTopic;
            tabMain.ActiveTab = TabTopic;
        }

        protected void ExportToExcelTopicBlock_Click(object sender, EventArgs e)
        {
            DataSet dsTopic = TopicBO.Topic_SelectListbyTopic_Status(false);
            TopicListUC2.dsTopic = dsTopic;
            tabMain.ActiveTab = TabTopicBlock;
        }
    }
}