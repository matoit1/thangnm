using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CongKy.DataAccessObject;

namespace CongKy.UserControl
{
    public partial class GalleryUC : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            rptGallery.DataSource = tblMonHocDAO.MonHoc_SelectList();
            rptGallery.DataBind();
        }
    }
}