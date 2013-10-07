using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using BusinessObject;

namespace ThangNMjsc.Product
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Load_ProductGroup();
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

        protected void Load_ProductGroup()
        {
            DataSet ds = ProductsBO.getDataSetGroupProducts_Parent(0);
            rpListProductGroup.DataSource = ds.Tables[0];
            rpListProductGroup.DataBind();
        }

        protected void rpListProductGroup_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            //---tuong ung voi mot san pham A duoc dua ra, hien thi danh sach san pham con cua A
            HiddenField hrId = (HiddenField)e.Item.FindControl("hrID"); //--- day la Id cua loai san pham A---
            Repeater rpListProduct = (Repeater)e.Item.FindControl("rpListProduct");
            if ((hrId != null) && (rpListProduct != null))
            {
                DataSet ds = ProductsBO.getDataSetProductbyProducts_GroupTop(Convert.ToInt64(hrId.Value),3);
                rpListProduct.DataSource = ds.Tables[0];
                rpListProduct.DataBind();
            }
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

        //protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        //{
        //    //int sd = e.Item.ItemIndex;
        //    DataTable tb = new DataTable();
        //    string name = e.CommandName;
        //    if (name == "add")
        //    {
        //        Int64 Products_ID = Convert.ToInt64(((Label)e.Item.FindControl("lblProducts_ID")).Text);
        //        string Products_Name = ((Label)e.Item.FindControl("lblProducts_Name")).Text;
        //        Int64 Products_Price = Convert.ToInt64(((Label)e.Item.FindControl("lblProducts_Price")).Text);
        //        tb = AddProductsIntoCart(Products_ID, Products_Name, Products_Price, 1);
        //        Session["Cart"] = tb;
        //        Response.Redirect("~/Cart.aspx");
        //    }
        //    if (name == "Detail")
        //    {
        //        string linkDetail = "~/Product/" + ((Label)e.Item.FindControl("lblProducts_ID")).Text + "/" + RewriteUrl.ConvertToUnSign(((Label)e.Item.FindControl("lblProducts_Name")).Text) + ".html";
        //        Response.Redirect(linkDetail);
        //    }
        //}

        protected void rpListProduct_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
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