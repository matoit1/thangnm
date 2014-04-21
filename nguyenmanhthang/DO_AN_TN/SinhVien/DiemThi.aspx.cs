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
    public partial class DiemThi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                DiemThi_ListUC1.btnAddNew.Visible = false;
                DiemThi_ListUC1.btnDeleteList.Visible = false;
                if (!IsPostBack)
                {
                    DiemThiEO _DiemThiEO = new DiemThiEO();
                    SinhVienEO _SinhVienEO = new SinhVienEO();
                    _SinhVienEO.sTendangnhapSV = Request.Cookies["sinhvien"].Value;
                    _DiemThiEO.FK_sMaSV = SinhVienDAO.SinhVien_SelectBysTendangnhapSV(_SinhVienEO).PK_sMaSV;
                    DiemThi_ListUC1.BindData(_DiemThiEO);
                }
            }
            catch { }
        }
    }
}