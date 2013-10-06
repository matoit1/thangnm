using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessObject;
using BusinessObject;
using System.Data;

namespace ThangNMjsc.Admin
{
    public partial class TestGrid : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadNewSupport();
            }
        }

        protected void loadNewSupport()
        {
            DataTable tb = AnswersBO.getDataSetNewSupports(false).Tables[0];
            //DataTable tb = AccountsBO.getDataSetAccountsbyUsername("admin").Tables[0];
            grvListNewSupport.DataSource = tb;
            grvListNewSupport.DataBind();
        }

        //private void loadNewSupport()
        //{
        //    try
        //    {
        //        DataTable dt = AnswersBO.getDataSetNewSupports(false).Tables[0];
        //        rpNewSupport.DataSource = dt;
        //        rpNewSupport.DataBind();
        //    }
        //    catch (Exception)
        //    {
        //    }
        //}

        //protected void Delete_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        AnswersBO.setdeleteAnswersbyAnswers_ID(Convert.ToInt32(AnswersBO.getDataSetNewSupports(false).Tables[0].Rows[0]["Answers_ID"]));
        //        loadNewSupport();
        //    }
        //    catch (Exception)
        //    {
        //        Response.Write("<script>alert('Delete Fail')</script>");
        //    }
        //}

        //protected void btnSearch_Click(object sender, EventArgs e)
        //{
        //    string search = "~/Admin/Searchs/SearchAnswers.aspx?contentsearch=" + txtSearch.Text;
        //    Response.Redirect(search);
        //}

        //protected void grvListNewSupport_RowCommand(object sender, GridViewCommandEventArgs e)
        //{
        //    if (e.CommandName == "cmdDelete") 
        //    {
        //        try
        //        {
        //           // Int64 Supports_ID = (Int64)grvListNewSupport.DataKeys[e.Row.RowIndex].Values["Supports_ID"];
        //           // Int32 Answers_ID = (Int32)grvListNewSupport.DataKeyNames[];
        //            //AnswersBO.setdeleteAnswersbyAnswers_ID(Answers_ID);
        //            //loadNewSupport();
        //        }
        //        catch (Exception)
        //        {
        //            Response.Write("<script>alert('Delete Fail')</script>");
        //        }
        //    }


            //int sd = e.Item.ItemIndex;
            //DataTable tb = new DataTable();
            //string name = e.CommandName;
            //if (name == "add")
            //{
            //    Int64 Products_ID = Convert.ToInt64(e.Item.ItemIndex);
            //    string Products_Name = ((Label)e.Item.FindControl("lblProducts_Name")).Text;
            //    Int64 Products_Price = Convert.ToInt64(((Label)e.Item.FindControl("lblProducts_Price")).Text);
            //    tb = AddProductsIntoCart(Products_Name, Products_Price, 1, Products_ID);
            //    Session["Cart"] = tb;
            //    Response.Redirect("cart.aspx");
            //}
            //if (name == "Detail")
            //{
            //    string linkDetail = "~/Product/Product.aspx?Products_ID=" + ((Label)e.Item.FindControl("lblProducts_ID")).Text;
            //    Response.Redirect(linkDetail);
            //}
        //}


        protected void grvListNewSupport_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grvListNewSupport.PageIndex = e.NewPageIndex;
            loadNewSupport();
        }

        protected void Delete_Click(object sender, EventArgs e)
        {
            String strID = "";
            foreach (GridViewRow row in grvListNewSupport.SelectedRows )
            {
                strID += "," + (Int64)grvListNewSupport.DataKeys[row.RowIndex].Values["Supports_ID"];
                
            }
            AnswersBO.setdeleteAnswersbyAnswers_ID(strID.Substring(1));
            loadNewSupport();
            Label8.Text = "Xoa thanh cong";
        }

        protected void grvListNewSupport_RowDataBound1(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                HyperLink hpLink = (HyperLink)e.Row.FindControl("hpReply");
                Int64 Supports_ID = (Int64)grvListNewSupport.DataKeys[e.Row.RowIndex].Values["Supports_ID"];
                hpLink.NavigateUrl = "~/Admin/Edit/ReplyNewSupport.aspx?Supports_ID=" + Supports_ID;
            }
        }
    }
}