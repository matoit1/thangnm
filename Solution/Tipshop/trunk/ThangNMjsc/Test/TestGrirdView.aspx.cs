using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessObject;
using BusinessObject;
using System.Data;
using System.Data.SqlClient;

namespace ThangNMjsc.Test
{
    public partial class TestGrirdView : System.Web.UI.Page
    {
        int stt = 1;
        public string get_stt()
        {
            return Convert.ToString(stt++);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            load_data();
        }
        protected void load_data()
        {
         DataTable tb = AnswersBO.getDataSetNewSupports(true).Tables[0];
         //DataTable tb = AccountsBO.getDataSetAccountsbyUsername("admin").Tables[0];
        GridView1.DataSource = tb;
        GridView1.DataBind();
        }
        protected void gvUser_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.AllowPaging = true;
            GridView1.PageSize = 1;
            GridView1.PageIndex = e.NewPageIndex;   //trang hien tai
            int trang_thu = e.NewPageIndex;      //the hien trang thu may
            int so_dong = GridView1.PageSize;       //moi trang co bao nhieu dong
            stt = trang_thu * so_dong + 1;
            load_data();
        }
    }
}