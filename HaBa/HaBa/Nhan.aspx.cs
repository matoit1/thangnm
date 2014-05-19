using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HaBa.DataAccessObject;
using System.Data;
using HaBa.SharedLibraries;

namespace HaBa
{
    public partial class Nhan : System.Web.UI.Page
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
                        DataSet ds = tblSanPhamDAO.SanPham_Search_Common(RewriteUrl.Remove_Unicode_Character(Request.QueryString["keyword"]));
                        rptResultSearch.DataSource = ds;
                        rptResultSearch.DataBind();
                        lblMsg.Text = "Tìm thấy " + ds.Tables[0].Rows.Count + " kết quả  (0,99 giây)";
                        
                    }
                }
            }
            catch (Exception ex)
            {
                lblMsg.Text = ex.Message;
            }
        }

        protected void rptResultSearch_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            Label lblsTenSanPham = ((Label)(e.Item.FindControl("lblsTenSanPham")));
            Label lblsMoTa = ((Label)(e.Item.FindControl("lblsMoTa")));
            HyperLink hplChiTietSanPham = ((HyperLink)(e.Item.FindControl("hplChiTietSanPham")));
            lblsTenSanPham.Text = RewriteUrl.HighLightKeyWords(RewriteUrl.Remove_Unicode_Character(lblsTenSanPham.Text), RewriteUrl.Remove_Unicode_Character(keyword), "#3333FF");
            lblsMoTa.Text = RewriteUrl.HighLightKeyWords(RewriteUrl.Remove_Unicode_Character(lblsMoTa.Text), RewriteUrl.Remove_Unicode_Character(keyword), "#3333FF");
            //hplChiTietSanPham.NavigateUrl = "~/" + hplChiTietSanPham.NavigateUrl + "/" + RewriteUrl.ConvertToUnSign(hplChiTietSanPham.ImageUrl) + ".html";
            //hplChiTietSanPham.ImageUrl = "";
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Nhan.aspx?keyword=" + txtKeyWord.Text);
            //keyword = txtKeyWord.Text;
            //DataSet ds = tblSanPhamDAO.Product_Search(RewriteUrl.Remove_Unicode_Character(txtKeyWord.Text));
            //rptResultSearch.DataSource = ds;
            //rptResultSearch.DataBind();
            //lblMsg.Text = "Tìm thấy " + ds.Tables[0].Rows.Count + " kết quả  (0,99 giây)";
        }

        protected void Search_Click(object sender, EventArgs e)
        {
            try
            {
                lblMsg.Text = "";
                txtKeyWord.Text = "";
                keyword = null;
                DataSet ds = tblSanPhamDAO.SanPham_Search(AdvancedSearchUC1.objtblSanPhamEO);
                lblMsg.Text = "Tìm thấy " + ds.Tables[0].Rows.Count + " kết quả  (0,99 giây)";
                rptResultSearch.DataSource = ds;
                rptResultSearch.DataBind();
            }
            catch
            {
            }
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