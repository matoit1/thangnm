using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityObject;
using DataAccessObject;

namespace DO_AN_TN.SinhVien
{
    public partial class ThongTinCaNhan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                SinhVienEO _SinhVienEO = new SinhVienEO();
                _SinhVienEO.sTendangnhapSV = Request.Cookies["sinhvien"].Value;
                _SinhVienEO = SinhVienDAO.SinhVien_SelectBysTendangnhapSV(_SinhVienEO);
                SinhVien_DetailUC1.BindDataDetail(_SinhVienEO);
            }
            catch
            {

            }
        }
    }
}