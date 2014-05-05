using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using DataAccessObject;
using EntityObject;
using SharedLibraries;

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
                ProductEO _ProductsEO = new ProductEO();
                _ProductsEO.PK_lProductID = input;
                _ProductsEO = ProductDAO.Product_SelectItem(_ProductsEO);
                lblProducts_Name.Text = _ProductsEO.sName;
                lblProducts_LastUpdate.Text = _ProductsEO.tLastUpdate.ToString(Messages.DateTime_Format);
                lblProducts_Name1.Text = _ProductsEO.sName;
                lblProducts_Description.Text = _ProductsEO.sDescription;
                lblProducts_Info.Text = _ProductsEO.sInfomation;
                lblProducts_Origin.Text = _ProductsEO.sOrigin;
                lblProducts_Price.Text = _ProductsEO.lPrice.ToString();
                imgProducts_Image1.ImageUrl = _ProductsEO.sLinkImage;
                imgProducts_Image1.AlternateText = _ProductsEO.sName;
                Url_Image = _ProductsEO.sLinkImage;
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