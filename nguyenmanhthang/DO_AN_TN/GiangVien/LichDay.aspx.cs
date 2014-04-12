using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityObject;
using DataAccessObject;

namespace DO_AN_TN.GiangVien
{
    public partial class LichDay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LichDayVaHoc_ListUC1.btnAddNew.Visible = false;
            LichDayVaHoc_ListUC1.btnDeleteList.Visible = false;
            if (!IsPostBack)
            {
                LichDayVaHocEO _LichDayVaHocEO = new LichDayVaHocEO();
                GiangVienEO _GiangVienEO = new GiangVienEO();
                _GiangVienEO.sTendangnhapGV = Request.Cookies["giangvien"].Value;
                LichDayVaHoc_ListUC1.BindData(_LichDayVaHocEO, 1);
            }
        }
    }
}