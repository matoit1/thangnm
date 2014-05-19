using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using HaBa.EntityObject;
using HaBa.DataAccessObject;
using HaBa.SharedLibraries.Constants;

namespace HaBa.UserControl
{
    public partial class ProducGroupUC : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    DataSet ds = new DataSet();
                    tblNhomSanPhamEO _tblNhomSanPhamEO = new tblNhomSanPhamEO();
                    _tblNhomSanPhamEO.iTrangThai = NhomSanPham_iTrangThai_C.Mo;
                    _tblNhomSanPhamEO.iNhomCon = 0;
                    ds = tblNhomSanPhamDAO.NhomSanPham_SelectListByiTrangThai_iNhomCon(_tblNhomSanPhamEO);
                    rptLoadProductGroup.DataSource = ds;
                    rptLoadProductGroup.DataBind();
                }
            }
            catch
            {
            }
        }
    }
}