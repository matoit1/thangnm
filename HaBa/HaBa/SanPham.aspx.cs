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
                    if (Request.QueryString["PK_sSanPhamID"] != null)
                    {
                        BindData(Convert.ToString(Request.QueryString["PK_sSanPhamID"]));
                    }
                }
            }
            catch (Exception ex)
            {
                lblsName.Text = ex.Message;
            }
        }

        public void BindData(string input)
        {
            try
            {
                tblSanPhamEO _ProductsEO = new tblSanPhamEO();
                _ProductsEO.PK_sSanPhamID = input;
                _ProductsEO = tblSanPhamDAO.SanPham_SelectItem(_ProductsEO);
                lblsName.Text = _ProductsEO.sTenSanPham;
                lblsTenSanPham.Text = _ProductsEO.sTenSanPham;
                lbltLastUpdate.Text = _ProductsEO.tNgayCapNhat.ToString(Messages.Format_DateTime);
                lblsMoTa.Text = _ProductsEO.sMoTa;
                lblsXuatXu.Text = _ProductsEO.sXuatXu;
                lbllGiaBan.Text = _ProductsEO.lGiaBan.ToString(Messages.Format_Number) + Messages.Viet_Nam_Dong;
                imgsLinkImage.ImageUrl = _ProductsEO.sLinkImage;
                imgsLinkImage.AlternateText = _ProductsEO.sTenSanPham;
                Url_Image = _ProductsEO.sLinkImage.Replace("~","..");
                lbliTrangThai.Text = GetTextConstants.SanPham_iTrangThai_GTC(_ProductsEO.iTrangThai);
                lblVote.CssClass = "rw-ui-container rw-urid-" + _ProductsEO.PK_sSanPhamID;
            }
            catch (Exception ex)
            {
                lblsName.Text = ex.Message;
            }
        }
    }
}