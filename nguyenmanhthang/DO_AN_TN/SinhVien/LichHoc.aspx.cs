using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DO_AN_TN.SinhVien
{
    public partial class LichHoc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LichDayVaHoc_ListUC1.btnAddNew.Visible = false;
            LichDayVaHoc_ListUC1.btnDeleteList.Visible = false;
        }
    }
}