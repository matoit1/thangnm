using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityObject;
using DataAccessObject;

namespace EHOU.QuanTri
{
    public partial class SinhVien : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        #region "Raise Event"
        protected void ViewDetail_Click(object sender, EventArgs e)
        {
            mtvMain.ActiveViewIndex = 1;
            SinhVienEO _SinhVienEO = new SinhVienEO();
            _SinhVienEO.PK_sMaSV = SinhVien_ListUC1.PK_sMaSV;
            _SinhVienEO = SinhVienDAO.SinhVien_SelectItem(_SinhVienEO);
            SinhVien_DetailUC1.BindDataDetail(_SinhVienEO);
        }

        protected void AddNew_Click(object sender, EventArgs e)
        {
            mtvMain.SetActiveView(vDetail);
            SinhVienEO _SinhVienEO = new SinhVienEO();
            SinhVien_DetailUC1.BindDataDetail(_SinhVienEO);
        }
        #endregion

        protected void lbtnBack_Click(object sender, EventArgs e)
        {
            mtvMain.SetActiveView(vList);
        }
    }
}