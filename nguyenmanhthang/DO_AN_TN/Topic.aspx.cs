using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using DataAccessObject;
using EntityObject;

namespace DO_AN_TN
{
    public partial class Topic : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Request.QueryString["PK_lMaBaiViet"] != null)
                {

                    pnlDetail.Visible = true;
                    tabMain.Visible = true;
                    loadTopic(Convert.ToInt64(Request.QueryString["PK_lMaBaiViet"]));
                }
                else
                {
                    pnlDetail.Visible = false;
                    tabMain.Visible = false;
                }
                if (!IsPostBack)
                {
                    loadShow();
                }
            }
            catch (Exception ex)
            {
                
            }
        }

        public void loadShow()
        {
            //try
            //{
            //    DataSet ds = TopicBO.Topic_SelectListToShow(true, 5);
            //    ds.Tables[0].Columns.Add(new DataColumn("link"));
            //    for (int i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
            //    {
            //        ds.Tables[0].Rows[i]["link"] = RewriteUrl.ConvertToUnSign(ds.Tables[0].Rows[i]["Topic_Title"].ToString());
            //    }
            //    rptTopic.DataSource = ds;
            //    rptTopic.DataBind();
            //}
            //catch (Exception) { }
        }
        public void loadTopic(Int64 _PK_lMaBaiViet)
        {
            try
            {
                DataSet ds = new DataSet();
                BaiVietEO _BaiVietEO = new BaiVietEO();
                _BaiVietEO.PK_lMaBaiViet = _PK_lMaBaiViet;
                _BaiVietEO = BaiVietDAO.BaiViet_SelectItem(_BaiVietEO);
                lblFK_sMaGV.Text = _BaiVietEO.FK_sMaGV;
                lbliLuotXem.Text = _BaiVietEO.iLuotXem.ToString();
                lblPK_lMaBaiViet.Value = _BaiVietEO.PK_lMaBaiViet.ToString();
                lblsNoiDung.Text = _BaiVietEO.sNoiDung;
                lblsTieuDe.Text = _BaiVietEO.sTieuDe;
                lbltNgayCapNhat.Text = _BaiVietEO.tNgayCapNhat.ToString("dd/mm/yyyy");
                imgsLinkAnh.ImageUrl = _BaiVietEO.sLinkAnh;
                

                //String Tags = ds.Tables[0].Rows[0]["Topic_Tag"].ToString();
                //string[] Tag = new string[10];
                //Tag = Tags.Split(',');
                //DataTable tblTags = new DataTable();
                //tblTags.Columns.Add("Topic_Tag");
                //for (int i = 0; i < Tag.Length; i++)
                //{
                //    DataRow dr = tblTags.NewRow();
                //    dr[0] = Tag[i].Trim();
                //    tblTags.Rows.Add(dr);
                //}
                //rptTag.DataSource = tblTags;
                //rptTag.DataBind();
            }
            catch (Exception)
            {
                pnlDetail.Visible = false;
                tabMain.Visible = false;
            }
        }

        protected void rptTopic_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            //string name = e.CommandName;
            //if (name == "Detail")
            //{
            //    string linkDetail = "~/Bai-viet/" + ((HiddenField)e.Item.FindControl("lblWebsite_ID")).Value + "/" + RewriteUrl.ConvertToUnSign(((Label)e.Item.FindControl("lblWebsite_Title")).Text) + ".html";
            //    //string linkDetail = "~/Topic.aspx?Topic_ID=" + ((HiddenField)e.Item.FindControl("lblWebsite_ID")).Value;
            //    Response.Redirect(linkDetail);
            //    //LinkButton button = e.CommandSource as LinkButton;
            //    //button.PostBackUrl = "";
            //}
        }

        protected void rptTopic_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {

        }

        protected void rptInfo_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            Label lblVote = ((Label)e.Item.FindControl("lblVote"));
            lblVote.CssClass = "rw-ui-container rw-urid-" + Request.QueryString["PK_lMaBaiViet"];

        }

        protected void rptTag_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {

        }
    }
}