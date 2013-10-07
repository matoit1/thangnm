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
    public partial class Mobile : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Load_ParentProduct();
            if (!IsPostBack)
            {
                try
                {
                    if (Session["Layout"].ToString() == "Desktop")
                    {
                        string url = Request.Url.AbsolutePath.Replace("/Mobile", "");
                        Response.Redirect(url);
                    }
                }
                catch { }
            }
        }

        protected void Load_ParentProduct() // Hien cac danh muc lon Menu
        {
            DataSet ds = ProductsBO.getDataSetGroupProducts_Parent(0);
            rpListParentProduct.DataSource = ds.Tables[0];
            rpListParentProduct.DataBind();
        }

        protected void rpListParentProduct_ItemDataBound(object sender, RepeaterItemEventArgs e)    // Hien cac danh muc con Menu
        {
            //---tuong ung voi mot san pham A duoc dua ra, hien thi danh sach san pham con cua A
            HiddenField hrId = (HiddenField)e.Item.FindControl("hrID"); //--- day la Id cua loai san pham A---
            Repeater rpChildrent = (Repeater)e.Item.FindControl("rpListChildProduct");
            if ((hrId != null) && (rpChildrent != null))
            {
                DataSet ds = ProductsBO.getDataSetGroupProducts_Childrent(Convert.ToInt64(hrId.Value));
                rpChildrent.DataSource = ds.Tables[0];
                rpChildrent.DataBind();
            }
        }

        protected void lbtnDesktop_Layout_Click(object sender, EventArgs e)
        {
            Session["Layout"] = "Desktop";
            Response.Redirect(Request.Url.AbsolutePath);
        }

        protected void lbtnMobile_Layout_Click(object sender, EventArgs e)
        {
            Session["Layout"] = "Mobile";
            Response.Redirect(Request.Url.AbsolutePath);
        }
    }
}