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
    public partial class Tag : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TopicListUC1.ibtnAdd.Visible = false;
            TopicListUC1.ibtnDelete.Visible = false;
            TopicListUC1.ibtnExportExcel.Visible = false;
            if (!IsPostBack)
            {
                if (Request.QueryString["Topic_Tag"] != null)
                {
                    try
                    {
                        DataSet dsTopic = TopicBO.Topic_SelectListbyTopic_Tag(Request.QueryString["Topic_Tag"]);
                        TopicListUC1.lblTitle.Text = "Danh sách các bài viết";
                        TopicListUC1.isBlock = false;
                        TopicListUC1.dsTopic = dsTopic;
                    }
                    catch { }
                }
            }
        }

        protected void ViewTopic_Click(object sender, EventArgs e)
        {
            try
            {
                Int64 Topic_ID = TopicListUC1.Topic_ID;
                DataSet ds = TopicBO.Topic_getTopicbyTopic_ID(Topic_ID);
                Response.Redirect("~/Bai-viet/" + Topic_ID + "/" + RewriteUrl.ConvertToUnSign(ds.Tables[0].Rows[0]["Topic_Title"].ToString()) + ".html");
            }
            catch { }
        }

        protected void PageChangeTopic_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet dsTopic = TopicBO.Topic_SelectListbyTopic_Tag(Request.QueryString["Topic_Tag"]);
            TopicListUC1.dsTopic = dsTopic;
            }
            catch { }
        }
    }
}