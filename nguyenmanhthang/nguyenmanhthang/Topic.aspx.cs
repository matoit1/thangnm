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
    public partial class Topic : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["Topic_ID"] != null)
            {
                lblMore.Text = "Các bài viết liên quan";
                pnlDetail.Visible = true;
                pnlComment.Visible = true;
                loadTopic(Convert.ToInt64(Request.QueryString["Topic_ID"]));
            }
            else
            {
                lblMore.Text = "Tất cả các bài viết";
                pnlDetail.Visible = false;
                pnlComment.Visible = false;
                loadShow();
            }
            if (!IsPostBack)
            {
            }
        }

        public void loadShow()
        {
            try
            {
                DataSet dt = TopicBO.Topic_SelectListToShow(true, 5);
                rptTopic.DataSource = dt;
                rptTopic.DataBind();
            }
            catch (Exception) { }
        }
        public void loadTopic(Int64 ID)
        {
            try
            {
                TopicBO.Topic_ASC_Visit(ID);
            }
            catch (Exception) { }

            try
            {
                DataSet dt = TopicBO.Topic_getTopicbyTopic_ID(ID);
                rptInfo.DataSource = dt;
                rptInfo.DataBind();
                String Tags = dt.Tables[0].Rows[0]["Topic_Tag"].ToString();
                string[] Tag = new string[10];
                Tag = Tags.Split(',');
                DataTable tblTags = new DataTable();
                tblTags.Columns.Add("Topic_Tag");
                for (int i = 0; i < Tag.Length; i++)
                {
                    DataRow dr = tblTags.NewRow();
                    dr[0] = Tag[i].Trim();
                    tblTags.Rows.Add(dr);
                }
                rptTag.DataSource = tblTags;
                rptTag.DataBind();
            }
            catch (Exception) { }
        }

        protected void rptTopic_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            string name = e.CommandName;
            if (name == "Detail")
            {
                string linkDetail = "~/Topic.aspx?Topic_ID=" + ((HiddenField)e.Item.FindControl("lblWebsite_ID")).Value;
                Response.Redirect(linkDetail);
            }
        }

        protected void rptTopic_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {

        }

        protected void rptInfo_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            Label lblVote= ((Label)e.Item.FindControl("lblVote"));
            lblVote.CssClass = "rw-ui-container rw-urid-" + Request.QueryString["Topic_ID"];
            
        }

        protected void rptTag_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            
        }
    }
}