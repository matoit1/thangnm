using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessObject;
using EntityObject;
using System.Text.RegularExpressions;
using System.Data;

namespace tydyShop
{
    public partial class Labels : System.Web.UI.Page
    {
        #region "Properties & Event"
        public string keyword
        {
            get { return (string)ViewState["keyword"]; }
            set { ViewState["keyword"] = value; }
        }
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    if (Request.QueryString["keyword"] != null)
                    {
                        keyword = Request.QueryString["keyword"];
                        txtKeyWord.Text = keyword;
                        DataSet ds = ProductDAO.Product_Search(RewriteUrl.Remove_Unicode_Character(Request.QueryString["keyword"]));
                        rptResultSearch.DataSource = ds;
                        rptResultSearch.DataBind();
                        lblMsg.Text = "Tìm thấy " + ds.Tables[0].Rows.Count + " kết quả  (0,99 giây)";
                    }
                }
            }
            catch(Exception ex){
                lblMsg.Text = ex.Message;
            }
        }

        protected void rptResultSearch_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            Label lblsName = ((Label)(e.Item.FindControl("lblsName")));
            Label lblsDescription = ((Label)(e.Item.FindControl("lblsDescription")));
            HyperLink hplChiTietSanPham = ((HyperLink)(e.Item.FindControl("hplChiTietSanPham")));
            lblsName.Text = RewriteUrl.HighLightKeyWords(RewriteUrl.Remove_Unicode_Character(lblsName.Text), RewriteUrl.Remove_Unicode_Character(keyword), "#3333FF");
            lblsDescription.Text = RewriteUrl.HighLightKeyWords(RewriteUrl.Remove_Unicode_Character(lblsDescription.Text), RewriteUrl.Remove_Unicode_Character(keyword), "#3333FF");
            hplChiTietSanPham.NavigateUrl = "~/" + hplChiTietSanPham.NavigateUrl + "/" + RewriteUrl.ConvertToUnSign(hplChiTietSanPham.ImageUrl) + ".html";
            hplChiTietSanPham.ImageUrl = "";
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Label.aspx?keyword=" + txtKeyWord.Text);
            //keyword = txtKeyWord.Text;
            //DataSet ds = ProductDAO.Product_Search(RewriteUrl.Remove_Unicode_Character(txtKeyWord.Text));
            //rptResultSearch.DataSource = ds;
            //rptResultSearch.DataBind();
            //lblMsg.Text = "Tìm thấy " + ds.Tables[0].Rows.Count + " kết quả  (0,99 giây)";
        }

        protected void lbtnAdvancedSearch_Click(object sender, EventArgs e)
        {
            if (AdvancedSearchUC1.Visible == true)
            {
                AdvancedSearchUC1.Visible = false;
            }
            else
            {
                AdvancedSearchUC1.Visible = true;
            }
        }
    }
}