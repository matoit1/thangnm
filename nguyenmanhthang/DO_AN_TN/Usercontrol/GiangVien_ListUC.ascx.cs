using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DO_AN_TN.UserControl
{
    public partial class GiangVien_ListUC : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            grvListGiangVien.SelectedRowStyle.BackColor = System.Drawing.Color.Yellow;
        }

        protected void grvListGiangVien_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

        }

        protected void grvListGiangVien_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }

        protected void grvListGiangVien_RowDataBound(object sender, GridViewRowEventArgs e)
        {

        }

        protected void grvListGiangVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void grvListGiangVien_Sorting(object sender, GridViewSortEventArgs e)
        {

        }
    }
}