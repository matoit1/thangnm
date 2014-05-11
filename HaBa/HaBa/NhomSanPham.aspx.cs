using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HaBa.EntityObject;
using HaBa.DataAccessObject;

namespace HaBa
{
    public partial class NhomSanPham : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    if (Request.QueryString["lGroup"] != null)
                    {
                        tblSanPhamEO _tblSanPhamEO = new tblSanPhamEO();
                        _tblSanPhamEO.lGroup = Convert.ToInt64(Request.QueryString["lGroup"]);
                        _tblSanPhamEO.bStatus = true;
                        Gallery3DUC1.BindData(tblSanPhamDAO.Product_SelectList_All_Product_In_Group(_tblSanPhamEO));
                    }
                }
            }
            catch { }
        }
    }
}