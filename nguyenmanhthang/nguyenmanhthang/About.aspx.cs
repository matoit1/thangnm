using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessObject;
using System.Data;
using nguyenmanhthang.Library.DataBase;

namespace nguyenmanhthang
{
    public partial class About : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["Topic_ID"] != null)
            {
                try
                {
                    CommentUC1.Topic_ID = Convert.ToInt64(Request.QueryString["Topic_ID"]);
                }
                catch { }
                lblMore.Text = "Các bài viết liên quan";
                pnlDetail.Visible = true;
                tabMain.Visible = true;
                loadTopic(Convert.ToInt64(Request.QueryString["Topic_ID"]));
            }
            else
            {
                lblMore.Text = "Tất cả các bài viết";
                pnlDetail.Visible = false;
                tabMain.Visible = false;
            }
            if (!IsPostBack)
            {
                loadShow();
            }
        }

        public void loadShow()
        {
            try
            {
                DataSet ds = LoadAnimationDAO.Topic_SelectListbyTopic_Category(100, 57);
                rptTopic.DataSource = ds;
                rptTopic.DataBind();
            }
            catch (Exception) { }
        }
        public void loadTopic(Int64 Topic_ID)
        {
            DataSet ds;
            try
            {
                TopicBO.Topic_ASC_Visit(Topic_ID);
            }
            catch (Exception) { }

            try
            {
                ds = CommentBO.Comment_SelectListbyTopic_ID(Topic_ID, true);
                rptComment.DataSource = ds;
                rptComment.DataBind();
            }
            catch (Exception) { }

            try
            {
                ds = TopicBO.Topic_getTopicbyTopic_ID(Topic_ID);
                rptInfo.DataSource = ds;
                rptInfo.DataBind();
                String Tags = ds.Tables[0].Rows[0]["Topic_Tag"].ToString();
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
            catch (Exception)
            {
                lblMore.Text = "Các bài viết có thể bạn quan tâm";
                lblMessage.Text = "Không tìm thấy bài viết !";
                lblMessage.CssClass = "alert_success";
                pnlDetail.Visible = false;
                tabMain.Visible = false;
            }
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
            Label lblVote = ((Label)e.Item.FindControl("lblVote"));
            lblVote.CssClass = "rw-ui-container rw-urid-" + Request.QueryString["Topic_ID"];

        }

        protected void rptTag_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {

        }

        protected void btnPrevious_Click(object sender, EventArgs e)
        {
        }
    }
}