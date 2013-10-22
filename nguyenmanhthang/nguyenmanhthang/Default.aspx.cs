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
                if (Request.QueryString["Topic_ID"] != null)
                {
                    lblMore.Text = "Các bài viết liên quan";
                    pnlDetail.Visible = true;
                    pnlComment.Visible = true;
                    lblVote.CssClass = "rw-ui-container rw-urid-" + Request.QueryString["Products_ID"];
                    try
                    {
                        DataTable dt = TopicBO.Topic_getTopicbyTopic_ID(Convert.ToInt32(Request.QueryString["Topic_ID"])).Tables[0];
                        lblWebsite_Title.Text = Convert.ToString(dt.Rows[0]["Topic_Title"]);
                        lblWebsite_Content.Text = Convert.ToString(dt.Rows[0]["Topic_Content"]);
                        lblWebsite_LastUpdate.Text = "Cập nhật lần cuối: " + Convert.ToString(dt.Rows[0]["Topic_LastUpdate"]);
                    }
                    catch (Exception) { }
                }
                else
                {
                    lblMore.Text = "Tất cả các bài viết";
                    pnlDetail.Visible = false;
                    pnlComment.Visible = false;
                }
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

        protected void rpTopic_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            string name = e.CommandName;
            if (name == "Detail")
            {
                string linkDetail = "~/Topic.aspx?Topic_ID=" + ((HiddenField)e.Item.FindControl("lblWebsite_ID")).Value;
                Response.Redirect(linkDetail);
            }
        }

        protected void rpTopic_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {

        }
    }
}