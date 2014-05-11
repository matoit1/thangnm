using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HaBa.SharedLibraries;
using HaBa.DataAccessObject;
using HaBa.EntityObject;

namespace HaBa
{
    public partial class SanPham : System.Web.UI.Page
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
                    if (Request.QueryString["PK_lProductID"] != null)
                    {
                        BindData(Convert.ToInt64(Request.QueryString["PK_lProductID"]));
                    }
                }
            }
            catch (Exception ex)
            {
                lblsName.Text = ex.Message;
            }
        }

        public void BindData(Int64 input)
        {
            try
            {
                tblSanPhamEO _ProductsEO = new tblSanPhamEO();
                _ProductsEO.PK_lProductID = input;
                _ProductsEO = tblSanPhamDAO.Product_SelectItem(_ProductsEO);
                lblsName.Text = _ProductsEO.sName;
                lblsName1.Text = _ProductsEO.sName;
                lbltLastUpdate.Text = _ProductsEO.tLastUpdate.ToString(Messages.Format_DateTime);
                lblsDescription.Text = _ProductsEO.sDescription;
                lblsInfomation.Text = _ProductsEO.sInfomation;
                lblsOrigin.Text = _ProductsEO.sOrigin;
                lbllPrice.Text = _ProductsEO.lPrice.ToString(Messages.Format_Number) + Messages.Viet_Nam_Dong;
                imgsLinkImage.ImageUrl = _ProductsEO.sLinkImage;
                imgsLinkImage.AlternateText = _ProductsEO.sName;
                Url_Image = _ProductsEO.sLinkImage;
                lblbStatus.Text = _ProductsEO.bStatus == true ? Messages.tblProduct_Con_Hang : Messages.tblProduct_Het_Hang;
                lblVote.CssClass = "rw-ui-container rw-urid-" + _ProductsEO.PK_lProductID;
            }
            catch (Exception ex)
            {
                lblsName.Text = ex.Message;
            }
        }
    }
}