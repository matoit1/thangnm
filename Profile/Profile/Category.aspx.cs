using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityObject;
using DataAccessObject;
using System.Data;

namespace Profile
{
    public partial class Category : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    DataTable dt = new DataTable();
                    dt = tblTopicDAO.SelectList();
                    rptTopic.DataSource = dt;
                    rptTopic.DataBind();
                    //lblTitle.Text = _tblTopicEO.sTitle;
                    //lblContent.Text = _tblTopicEO.sContent;

                    //hplTopic.NavigateUrl = "~/Topic.aspx?PK_lTopicID=" + dt.Rows[0]["PK_lTopicID"].ToString();
                    //hplTopic1.NavigateUrl = hplTopic.NavigateUrl.ToString();
                    //hplTopic2.NavigateUrl = hplTopic.NavigateUrl.ToString();
                    //hplTopic3.NavigateUrl = hplTopic.NavigateUrl.ToString();
                    //imgsLinkImage.ImageUrl = dt.Rows[0]["sLinkImage"].ToString();
                    //lblsTitle.Text = dt.Rows[0]["sTitle"].ToString();
                    //lbltLastUpdate.Text = dt.Rows[0]["tLastUpdate"].ToString();
                    //lblFK_iAccountsID.Text = dt.Rows[0]["FK_iAccountsID"].ToString();
                    //lbliVisit.Text = dt.Rows[0]["iVisit"].ToString();
                    //lbliLike.Text = dt.Rows[0]["iLike"].ToString();
                    //lblsDescription.Text = dt.Rows[0]["sDescription"].ToString();
                }
            }
            catch { }
        }

        protected void rptTopic_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            try
            {
                DataTable tb = new DataTable();
                if (e.CommandName == "Like")
                {
                    tblTopicEO _tblTopicEO = new tblTopicEO();
                    _tblTopicEO.PK_lTopicID = Convert.ToInt64(((HiddenField)e.Item.FindControl("hfID")).Value);
                    _tblTopicEO = tblTopicDAO.SelectItem(_tblTopicEO);
                    _tblTopicEO.iLike = _tblTopicEO.iLike +1;
                    tblTopicDAO.Update_iVisit_Or_iLike(_tblTopicEO);
                    DataTable dt = new DataTable();
                    dt = tblTopicDAO.SelectList();
                    rptTopic.DataSource = dt;
                    rptTopic.DataBind();
                }
            }
            catch { }
        }
    }
}