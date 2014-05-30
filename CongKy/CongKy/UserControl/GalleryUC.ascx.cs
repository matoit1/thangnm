using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CongKy.DataAccessObject;
using CongKy.EntityObject;
using System.Data;

namespace CongKy.UserControl
{
    public partial class GalleryUC : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            rptGallery.DataSource = tblMonHocDAO.MonHoc_SelectList();
            rptGallery.DataBind();
        }

        protected void rptGallery_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            try
            {
                Label lblContent = (Label)e.Item.FindControl("lblContent");
                if (lblContent != null)
                {
                    tblGiaoTrinhEO _tblGiaoTrinhEO = new tblGiaoTrinhEO();
                    _tblGiaoTrinhEO.FK_iMonHocID = Convert.ToInt32(lblContent.Text);
                    lblContent.Text = "";
                    DataSet ds = tblGiaoTrinhDAO.GiaoTrinh_SelectByFK_iMonHocID(_tblGiaoTrinhEO);
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        lblContent.Text = lblContent.Text + "- " + dr["sTenBaiHoc"].ToString() + " <br //> ";
                    }
                    
                }
            }
            catch
            {
            }
        }
    }
}