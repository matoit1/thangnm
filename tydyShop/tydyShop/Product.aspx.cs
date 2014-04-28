using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

namespace tydyShop
{
    public partial class Product : System.Web.UI.Page
    {
        #region "Properties & Event"
        public string Url_Image
        {
            get { return (string)ViewState["Url_Image"]; }
            set { ViewState["Url_Image"] = value; }
        }
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    if (Request.QueryString["Products_ID"] != null)
                    {
                        BindData(Convert.ToInt64(Request.QueryString["Products_ID"]));
                    }
                }
            }
            catch (Exception ex)
            {
                lblProducts_Name.Text = ex.Message;
            }
        }

        public void BindData(Int64 input)
        {
            try
            {
                ProductsEO _ProductsEO = new ProductsEO();
                _ProductsEO.Products_ID = input;
                _ProductsEO = DataSet2Object.Products(ProductsDAO.Products_SelectItem(_ProductsEO));
                lblProducts_Name.Text = _ProductsEO.Products_Name;
                lblProducts_LastUpdate.Text = _ProductsEO.Products_LastUpdate.ToString(Messages.DateTime_Format);
                lblProducts_Name1.Text = _ProductsEO.Products_Name;
                lblProducts_Description.Text = _ProductsEO.Products_Description;
                lblProducts_Info.Text = _ProductsEO.Products_Info;
                lblProducts_Origin.Text = _ProductsEO.Products_Origin;
                lblProducts_Price.Text = _ProductsEO.Products_Price.ToString();
                imgProducts_Image1.ImageUrl = _ProductsEO.Products_Image1;
                imgProducts_Image1.AlternateText = _ProductsEO.Products_Name;
                Url_Image = _ProductsEO.Products_Image1;
                LoadDataListBox();
            }
            catch (Exception ex)
            {
                lblProducts_Name.Text = ex.Message;
            }
        }

        public void LoadDataListBox()
        {
            SortedList slTag = new SortedList();
            slTag.Add(1, "Phụ kiện");
            slTag.Add(2, "Quần");
            slTag.Add(3, "Váy");
            slTag.Add(4, "Áo");
            lstbTag.DataSource = slTag;
            lstbTag.DataTextField = "Value";
            lstbTag.DataValueField = "Key";
            lstbTag.DataBind();
        }
    }
}