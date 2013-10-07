using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

namespace ThangNMjsc.Product
{
    public partial class Index : System.Web.UI.Page
    {
        public DataTable AddProductsIntoCart(string Products_Name, Int64 Products_Price, int Products_Numbers, Int64 Products_ID)
        {
            DataTable tblCart = new DataTable();
            // thực hiện gán giá trị cho 1 dong trong table
            tblCart = (DataTable)Session["Cart"];
            if (tblCart == null)
                tblCart = taogiohang();
            DataRow dr = tblCart.NewRow();
            dr[0] = Products_Name;
            dr[1] = Products_Numbers;
            dr[2] = Products_Price;
            dr[3] = Products_Numbers * Products_Price;
            dr[4] = Products_ID;
            //thêm dòng vừa tạo vào table
            tblCart.Rows.Add(dr);
            return tblCart;
        }
        public DataTable taogiohang()
        {
            DataTable tb = new DataTable("ListProducts");
            tb.Columns.Add("Products_Name");
            tb.Columns.Add("Products_Numbers");
            tb.Columns.Add("Products_Price");
            tb.Columns.Add("Products_Total");
            tb.Columns.Add("Products_ID");
            return tb;
        }

        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            //int sd = e.Item.ItemIndex;
            DataTable tb = new DataTable();
            string name = e.CommandName;
            if (name == "add")
            {
                Int64 Products_ID = Convert.ToInt64(e.Item.ItemIndex);
                string Products_Name = ((Label)e.Item.FindControl("lblProducts_Name")).Text;
                Int64 Products_Price = Convert.ToInt64(((Label)e.Item.FindControl("lblProducts_Price")).Text);
                tb = AddProductsIntoCart(Products_Name, Products_Price, 1, Products_ID);
            }

            Session["Cart"] = tb;
            Response.Redirect("cart.aspx");
        }
    }
}