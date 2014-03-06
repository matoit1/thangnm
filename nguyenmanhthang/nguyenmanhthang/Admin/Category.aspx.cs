using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using nguyenmanhthang.Library.DataBase;

namespace nguyenmanhthang
{
    public partial class Category : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataSet dsTopic = LoadAnimationDAO.Topic_SelectListbyTopic_Category(1000, 0);
                CategoryListUC1.lblTitle.Text = "Danh sách các nhóm bài viết";
                CategoryListUC1.isBlock = false;
                CategoryListUC1.dsTopic = dsTopic;
            }
        }

        protected void ViewTopic_Click(object sender, EventArgs e)
        {
            Int64 Topic_ID = CategoryListUC1.Topic_ID;
            //mtvMain.ActiveViewIndex = 1;
            //TopicDetailUC1.LoadDetailTopic(Topic_ID, false);
            //CategoryListUC1.ReBindDataGrid(Topic_ID, true);
            //CategoryListUC1.ReBindDataGrid(Topic_ID, false);
        }

        protected void PageChangeTopic_Click(object sender, EventArgs e)
        {
            DataSet dsTopic = LoadAnimationDAO.Topic_SelectListbyTopic_Category(1000, 0);
            CategoryListUC1.dsTopic = dsTopic;
            //tabMain.ActiveTab = TabTopic;
        }
    }
}