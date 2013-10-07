using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BusinessObject;

namespace ThangNMjsc.Mobile
{
    public partial class Product : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblVote.CssClass = "rw-ui-container rw-urid-" + Request.QueryString["Products_ID"];
                if (Request.QueryString["Products_ID"] != null)
                {
                    Int64 Products_ID = Convert.ToInt64(Request.QueryString["Products_ID"]);
                    DataSet ds = ProductsBO.getDataSetProductsbyProducts_ID(Products_ID);
                    Page.Title = ds.Tables[0].Rows[0]["Products_Name"].ToString() + "- Tip Shop";
                    Page.MetaDescription = ds.Tables[0].Rows[0]["Products_Name"].ToString() + " - " + ds.Tables[0].Rows[0]["Products_Description"].ToString() + ", " + ds.Tables[0].Rows[0]["Products_Info"].ToString() + ", " + ds.Tables[0].Rows[0]["Products_Origin"].ToString();
                    Page.MetaKeywords = ds.Tables[0].Rows[0]["Products_Name"].ToString() + "," + ds.Tables[0].Rows[0]["Products_Description"].ToString() + ",Sản phẩm mới, Tip Shop, Designed by ThangNM";
                    imgProducts_Image1.ImageUrl = ds.Tables[0].Rows[0]["Products_Image1"].ToString();
                    imgProducts_Image1.AlternateText = "Ảnh mô tả Sản phẩm mã: " + Products_ID;
                    imgProducts_Image2.ImageUrl = ds.Tables[0].Rows[0]["Products_Image2"].ToString();
                    imgProducts_Image2.AlternateText = "Ảnh mô tả Sản phẩm mã: " + Products_ID;
                    imgProducts_Image3.ImageUrl = ds.Tables[0].Rows[0]["Products_Image3"].ToString();
                    imgProducts_Image3.AlternateText = "Ảnh mô tả Sản phẩm mã: " + Products_ID;
                    lblProducts_ID.Text = Convert.ToString(Products_ID);
                    lblProducts_Name.Text = ds.Tables[0].Rows[0]["Products_Name"].ToString();
                    lblProducts_Price.Text = ds.Tables[0].Rows[0]["Products_Price"].ToString();
                    lblProducts_Sale.Text = ds.Tables[0].Rows[0]["Products_Sale"].ToString();
                    lblProducts_Description.Text = ds.Tables[0].Rows[0]["Products_Description"].ToString();
                    lblProducts_Info.Text = ds.Tables[0].Rows[0]["Products_Info"].ToString();
                    lblProducts_Origin.Text = ds.Tables[0].Rows[0]["Products_Origin"].ToString();
                    lblProducts_LastUpdate.Text = ds.Tables[0].Rows[0]["Products_LastUpdate"].ToString();
                    if (Convert.ToBoolean(ds.Tables[0].Rows[0]["Products_VAT"]) == true)
                    {
                        lblVat.Text = " [Đã bao gồm VAT]";
                    }
                    if (Convert.ToBoolean(ds.Tables[0].Rows[0]["Products_Visible"]) == false)
                    {
                        ibtnBuy.Enabled = false;
                        ibtnBuy.ImageUrl = "~/Css/Product/theme/noProduct.png";
                    }
                }
                else
                {
                    Page.Title = "Sản phẩm - Tip Shop";
                    Page.MetaDescription = "Tip Shop chuyên cung cấp các sản phẩm quần áo thời trang và Mỹ phẩm cho Nam, Nữ và Trẻ em";
                    Page.MetaKeywords = "quần áo, thời trang, Mỹ phẩm, Sản phẩm mới, Tip Shop, Designed by ThangNM";
                }
            }
        }

        public DataTable AddProductsIntoCart(Int64 Products_ID, string Products_Name, Int64 Products_Price, int Products_Numbers)
        {
            DataTable tblCart = new DataTable();
            // thực hiện gán giá trị cho 1 dong trong table
            tblCart = (DataTable)Session["Cart"];
            if (tblCart == null)
                tblCart = CreateCart();
            DataRow dr = tblCart.NewRow();
            dr[0] = Products_ID;
            dr[1] = Products_Name;
            dr[2] = Products_Numbers;
            dr[3] = Products_Price;
            dr[4] = Products_Numbers * Products_Price;
            tblCart.Rows.Add(dr);//thêm dòng vừa tạo vào table
            return tblCart;
        }
        public DataTable CreateCart()
        {
            DataTable tb = new DataTable("ListProducts");
            tb.Columns.Add("Products_ID");
            tb.Columns.Add("Products_Name");
            tb.Columns.Add("Products_Numbers");
            tb.Columns.Add("Products_Price");
            tb.Columns.Add("Products_Total");
            return tb;
        }

        protected void ibtnBuy_Click(object sender, ImageClickEventArgs e)
        {
            DataTable tb = new DataTable();
            Int64 Products_ID = Convert.ToInt64(lblProducts_ID.Text);
            string Products_Name = lblProducts_Name.Text;
            Int64 Products_Price = Convert.ToInt64(lblProducts_Price.Text);
            tb = AddProductsIntoCart(Products_ID, Products_Name, Products_Price, 1);
            Session["Cart"] = tb;
            Response.Redirect("~/Cart.aspx");
        }

        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            //int sd = e.Item.ItemIndex;
            DataTable tb = new DataTable();
            string name = e.CommandName;
            if (name == "add")
            {
                Int64 Products_ID = Convert.ToInt64(((Label)e.Item.FindControl("lblProducts_ID")).Text);
                string Products_Name = ((Label)e.Item.FindControl("lblProducts_Name")).Text;
                Int64 Products_Price = Convert.ToInt64(((Label)e.Item.FindControl("lblProducts_Price")).Text);
                tb = AddProductsIntoCart(Products_ID, Products_Name, Products_Price, 1);
                Session["Cart"] = tb;
                Response.Redirect("~/Cart.aspx");
            }
            if (name == "Detail")
            {
                string linkDetail = "~/Product/" + ((Label)e.Item.FindControl("lblProducts_ID")).Text + "/" + RewriteUrl.ConvertToUnSign(((Label)e.Item.FindControl("lblProducts_Name")).Text) + ".html";
                Response.Redirect(linkDetail);
            }
        }
    }
}