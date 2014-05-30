using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CongKy.DataAccessObject;
using CongKy.EntityObject;

namespace CongKy.QuanTri
{
    public partial class ChiTietGiaoTrinh : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Request.QueryString["iTrangThai"] != null)
                {
                    tblChiTietGiaoTrinh_ListUC1.iTrangThai = Convert.ToInt16(Request.QueryString["iTrangThai"]);
                }
            }
            catch
            {
            }
        }

        #region "Raise Event"
        protected void ViewDetail_Click(object sender, EventArgs e)
        {
            mtvMain.SetActiveView(vDetail);
            tblChiTietGiaoTrinhEO _tblChiTietGiaoTrinhEO = new tblChiTietGiaoTrinhEO();
            _tblChiTietGiaoTrinhEO.PK_iGiaoTrinhID = tblChiTietGiaoTrinh_ListUC1.PK_iGiaoTrinhID;
            _tblChiTietGiaoTrinhEO = tblChiTietGiaoTrinhDAO.ChiTietGiaoTrinh_SelectItem(_tblChiTietGiaoTrinhEO);

            tblMonHocEO _tblMonHocEO = new tblMonHocEO();
            _tblMonHocEO.PK_iMonHocID = tblChiTietGiaoTrinh_ListUC1.PK_iGiaoTrinhID;

            tblChiTietGiaoTrinh_DetailUC1.BindDataDetail(_tblChiTietGiaoTrinhEO, _tblMonHocEO);
        }

        protected void AddNew_Click(object sender, EventArgs e)
        {
            mtvMain.SetActiveView(vDetail);
            tblChiTietGiaoTrinhEO _tblChiTietGiaoTrinhEO = new tblChiTietGiaoTrinhEO();
            tblMonHocEO _tblMonHocEO = new tblMonHocEO();
            tblChiTietGiaoTrinh_DetailUC1.BindDataDetail(_tblChiTietGiaoTrinhEO, _tblMonHocEO);
        }
        #endregion

        protected void lbtnBack_Click(object sender, EventArgs e)
        {
            mtvMain.SetActiveView(vList);
            tblChiTietGiaoTrinh_ListUC1.BindData();
        }
    }
}