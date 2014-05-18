using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using HaBa.DataAccessObject;
using HaBa.EntityObject;
using HaBa.SharedLibraries.Constants;
using System.Data.SqlClient;

namespace HaBa
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet dsNew= tblSanPhamDAO.SanPham_SelectList();
            DataSet dsOld = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            da.Update(dsNew);
            da.Fill(dsOld);
            Load_ParentProduct();
        }

        protected void Load_ParentProduct() // Hien cac danh muc lon Menu
        {
            tblNhomSanPhamEO _tblNhomSanPhamEO = new tblNhomSanPhamEO();
            _tblNhomSanPhamEO.iTrangThai = NhomSanPham_iTrangThai_C.Mo;
            DataSet ds = tblNhomSanPhamDAO.NhomSanPham_SelectListByiTrangThai(_tblNhomSanPhamEO);
            rptRoot.DataSource = ds.Tables[0];
            rptRoot.DataBind();
        }

        protected void rpListParentProduct_ItemDataBound(object sender, RepeaterItemEventArgs e)    // Hien cac danh muc con Menu
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
    }
}