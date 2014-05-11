using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using HaBa.DataAccessObject;
using HaBa.EntityObject;

namespace HaBa.UserControl
{
    public partial class ShowAllProductUC : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    DataSet ds = new DataSet();
                    tblSanPhamEO _tblSanPhamEO = new tblSanPhamEO();
                    _tblSanPhamEO.bStatus = true;
                    ds = tblSanPhamDAO.Product_SelectList_All_Product(_tblSanPhamEO);
                    rptLoadAllProduct.DataSource = ds;
                    rptLoadAllProduct.DataBind();
                }
            }
            catch
            {
            }
        }
    }
}