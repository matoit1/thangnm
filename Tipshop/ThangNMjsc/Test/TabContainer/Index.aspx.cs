using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using AjaxControlToolkit;
using System.Data.SqlClient;
using DataAccessObject;

namespace ThangNMjsc.Test.TabContainer
{
    public partial class Index : System.Web.UI.Page
    {
        AjaxControlToolkit.TabContainer tbcDynamic;
        protected void Page_Load(object sender, EventArgs e)
        {
            CreateTabTrip(0, phContent);
        }

        private void CreateTabTrip(int iCateID, PlaceHolder pholder)
        {
            tbcDynamic = new AjaxControlToolkit.TabContainer();
            string sqlCate = "SELECT Website_ID, Website_Title FROM Website";
            DataTable dtb = QueryToDataTable(sqlCate);
            if (dtb.Rows.Count > 0)
            {
                for (int i = 0; i < dtb.Rows.Count; i++)
                {
                    TabPanel tbCategory = new TabPanel();
                    tbCategory.HeaderText = dtb.Rows[i]["Website_Title"].ToString();
                    tbCategory.ID = "Tab" + i.ToString();
                    tbcDynamic.Tabs.Add(tbCategory);
                    Literal ltl1 = new Literal();
                    ltl1.Text = GetListNew(int.Parse("0" + dtb.Rows[i]["Website_ID"]));
                    tbcDynamic.Tabs[i].Controls.Add(ltl1);
                }
                pholder.Controls.Add(tbcDynamic);

            }
        }

        private string GetListNew(int cateID)
        {
            string strHTML = "";
            string strNew = @"SELECT Website_ID, Website_Title, Website_Content FROM Website WHERE Website_ID=" + cateID.ToString() + " ORDER BY Website_ID DESC ";
            DataTable dtb = QueryToDataTable(strNew);
            if (dtb.Rows.Count > 0)
            {
                foreach (DataRow dr in dtb.Rows)
                {
                    strHTML += "<ul>";
                    strHTML += "<li><a href=\"#\">" + dr["Website_Title"] + "</a>";
                    strHTML += "</ul>";
                }
            }
            return strHTML;
        }
        private DataTable QueryToDataTable(string strSQL)
        {
            DataTable dtbTmp = new DataTable();
            SqlConnection conn = Connect.getConnection();
            try
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(strSQL, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "GetData");
                dtbTmp = ds.Tables[0];
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
            }
            return dtbTmp;
        }
    }
}