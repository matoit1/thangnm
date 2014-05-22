using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HaBa.SharedLibraries;
using HaBa.DataAccessObject;
using HaBa.EntityObject;
using System.Data;
using HaBa.SharedLibraries.Constants;

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
                lblPK_sSanPhamID.Text = _ProductsEO.PK_sSanPhamID;
                lblFK_iNhomSanPhamID.Text = tblNhomSanPhamDAO.NhomSanPham_SelectItem_By_PK_iNhomSanPhamID(_ProductsEO.FK_iNhomSanPhamID).sTenNhom;
                lblsName.Text = _ProductsEO.sTenSanPham;
                lblsTenSanPham.Text = _ProductsEO.sTenSanPham;
                //lblsMoTa.Text = _ProductsEO.sMoTa;
                lblsThongTin.Text = _ProductsEO.sThongTin;
                lblsXuatXu.Text = _ProductsEO.sXuatXu;
                imgsLinkImage.ImageUrl = _ProductsEO.sLinkImage;
                imgsLinkImage.AlternateText = _ProductsEO.sTenSanPham;
                Url_Image = _ProductsEO.sLinkImage.Replace("~", "..");
                lbllGiaBan.Text = _ProductsEO.lGiaBan.ToString(Messages.Format_Number);
                lbliVAT.Text = _ProductsEO.iVAT.ToString() + " %";
                lbliDoTuoi.Text = GetTextConstants.SanPham_iDoTuoi_GTC(_ProductsEO.iDoTuoi);
                lbliGioiTinh.Text = GetTextConstants.SanPham_iGioiTinh_GTC(_ProductsEO.iGioiTinh);
                lbliSoLuong.Text = _ProductsEO.iSoLuong.ToString();
                lbltLastUpdate.Text = _ProductsEO.tNgayCapNhat.ToString(Messages.Format_DateTime);
                lbliTrangThai.Text = GetTextConstants.SanPham_iTrangThai_GTC(_ProductsEO.iTrangThai);
                lblVote.CssClass = "rw-ui-container rw-urid-" + _ProductsEO.PK_sSanPhamID;
                if (_ProductsEO.iTrangThai == SanPham_iTrangThai_C.Het_Hang)
                {
                    btnBuy.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                lblsName.Text = ex.Message;
            }
        }


        public DataTable AddProductsIntoCart(string PK_sSanPhamID, string sTenSanPham, Int64 lGiaBan, Int16 iSoLuong)
        {
            DataTable tblCart = new DataTable();
            try
            {
                // thực hiện gán giá trị cho 1 dong trong table
                tblCart = (DataTable)Session["GioHang"];
                if (tblCart == null)
                    tblCart = CreateCart();
                DataRow dr = tblCart.NewRow();
                dr[0] = PK_sSanPhamID;
                dr[1] = sTenSanPham;
                dr[2] = iSoLuong;
                dr[3] = lGiaBan;
                dr[4] = iSoLuong * lGiaBan;
                tblCart.Rows.Add(dr);//thêm dòng vừa tạo vào table
                return tblCart;
            }
            catch { return tblCart; }
        }
        public DataTable CreateCart()
        {
            DataTable tb = new DataTable("ListProducts");
            tb.Columns.Add("PK_sSanPhamID");
            tb.Columns.Add("sTenSanPham");
            tb.Columns.Add("iSoLuong");
            tb.Columns.Add("lGiaBan");
            tb.Columns.Add("lThanhTien");
            return tb;
        }

        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            //int sd = e.Item.ItemIndex;
            DataTable tb = new DataTable();
            string name = e.CommandName;
            if (name == "add")
            {
                string PK_sSanPhamID = Convert.ToString(((Label)e.Item.FindControl("lblPK_sSanPhamID")).Text);
                string sTenSanPham = ((Label)e.Item.FindControl("lblsTenSanPham")).Text;
                Int64 lGiaBan = Convert.ToInt64(((Label)e.Item.FindControl("lbllGiaBan")).Text);
                tb = AddProductsIntoCart(PK_sSanPhamID, sTenSanPham, lGiaBan, 1);
                Session["GioHang"] = tb;
                Response.Redirect("~/GioHang.aspx");
            }
            if (name == "Detail")
            {
                string linkDetail = "~/Product/" + ((Label)e.Item.FindControl("lblPK_sSanPhamID")).Text + "/" + RewriteUrl.ConvertToUnSign(((Label)e.Item.FindControl("lblsTenSanPham")).Text) + ".html";
                Response.Redirect(linkDetail);
            }
        }

        protected void btnBuy_Click(object sender, EventArgs e)
        {
            DataTable tb = new DataTable();
            string PK_sSanPhamID = Convert.ToString(lblPK_sSanPhamID.Text);
            string sTenSanPham = lblsName.Text;
            Int64 lGiaBan = Convert.ToInt64(lbllGiaBan.Text.Replace(",","").Replace(".",""));
            tb = AddProductsIntoCart(PK_sSanPhamID, sTenSanPham, lGiaBan, 1);
            Session["GioHang"] = tb;
            Response.Redirect("~/GioHang.aspx");
        }
    }
}