using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessObject;
using System.Data;

namespace ThangNMjsc.UserControls
{
    public partial class SearchProductUC : System.Web.UI.UserControl
    {
        private DataTable _dtSearchProduct;
        protected void Page_Load(object sender, EventArgs e)
        {
            txtProducts_Name.Attributes.Add("placeholder", "Tìm kiếm theo tên Sản phẩm");
        }

        protected void btnShowSearchAdvanced_Click(object sender, EventArgs e)
        {
            if (PanelSearchAdvanced.Visible == true)
            {
                PanelSearchAdvanced.Visible = false;
                btnSearch1.Visible = false;
                btnSearch.Visible = true;
            }
            else
            {
                PanelSearchAdvanced.Visible = true;
                btnSearch1.Visible = true;
                btnSearch.Visible = false;
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtSearchProduct = ProductsBO.getDataSetSearchProductsbyName(txtProducts_Name.Text, txtProducts_Description.Text, txtProducts_Info.Text, txtProducts_Origin.Text).Tables[0];
            }
            catch (Exception)
            {
            }
        }

        public DataTable dtSearchProduct
        {
            get { return this._dtSearchProduct; }
            set { _dtSearchProduct = value; }
        }
    }
}