using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HaBa.EntityObject;
using System.Data;
using HaBa.DataAccessObject;
using HaBa.SharedLibraries.Constants;

namespace HaBa.UserControl
{
    public partial class MenuUC : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    Load_ParentProduct();
                }
            }
            catch { }
        }

        protected void Load_ParentProduct() // Hien cac danh muc lon Menu
        {
            tblNhomSanPhamEO _tblNhomSanPhamEO = new tblNhomSanPhamEO();
            _tblNhomSanPhamEO.iTrangThai = NhomSanPham_iTrangThai_C.Mo;
            _tblNhomSanPhamEO.iNhomCon = 0;
            DataSet ds = tblNhomSanPhamDAO.NhomSanPham_SelectListByiTrangThai_iNhomCon(_tblNhomSanPhamEO);
            rptRoot.DataSource = ds.Tables[0];
            rptRoot.DataBind();
        }

        protected void rptRoot_ItemDataBound(object sender, RepeaterItemEventArgs e)    // Hien cac danh muc con Menu
        {
            //---tuong ung voi mot san pham A duoc dua ra, hien thi danh sach san pham con cua A
            HiddenField hrfPK_iNhomSanPhamID = (HiddenField)e.Item.FindControl("hrfPK_iNhomSanPhamID"); //--- day la Id cua loai san pham A---
            Repeater rpChildrent = (Repeater)e.Item.FindControl("rptiNhomCon");
            if ((hrfPK_iNhomSanPhamID != null) && (rpChildrent != null))
            {
                tblNhomSanPhamEO _tblNhomSanPhamEO = new tblNhomSanPhamEO();
                _tblNhomSanPhamEO.iNhomCon = Convert.ToInt16(hrfPK_iNhomSanPhamID.Value);
                DataSet ds = tblNhomSanPhamDAO.NhomSanPham_SelectListByiNhomCon(_tblNhomSanPhamEO);
                rpChildrent.DataSource = ds.Tables[0];
                rpChildrent.DataBind();
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Nhan.aspx?keyword=" +txtKeyWord.Text);
        }
    }
}