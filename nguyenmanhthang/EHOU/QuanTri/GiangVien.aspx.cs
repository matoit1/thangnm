using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessObject;
using EntityObject;

namespace EHOU.QuanTri
{
    public partial class GiangVien : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        #region "Raise Event"
        protected void ViewDetail_Click(object sender, EventArgs e)
        {
            mtvMain.ActiveViewIndex = 1;
            GiangVienEO _GiangVienEO = new GiangVienEO();
            _GiangVienEO.PK_sMaGV = GiangVien_ListUC1.PK_sMaGV;
            _GiangVienEO = GiangVienDAO.GiangVien_SelectItem(_GiangVienEO);
            GiangVien_DetailUC1.BindDataDetail(_GiangVienEO);
        }
        #endregion

        protected void lbtnBack_Click(object sender, EventArgs e)
        {
            mtvMain.SetActiveView(vList);
        }
    }
}