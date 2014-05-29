using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CongKy.EntityObject;
using CongKy.DataAccessObject;

namespace CongKy.GiangVien
{
    public partial class GiaoTrinh : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                tblGiaoTrinh_ListUC1.BindData();
            }
            catch
            {
            }
        }

        #region "Raise Event"
        protected void ViewDetail_Click(object sender, EventArgs e)
        {
            mtvMain.SetActiveView(vDetail);
            tblGiaoTrinhEO _tblGiaoTrinhEO = new tblGiaoTrinhEO();
            _tblGiaoTrinhEO.FK_iMonHocID = tblGiaoTrinh_ListUC1.FK_iMonHocID;
            _tblGiaoTrinhEO.FK_iGiaoTrinhID = tblGiaoTrinh_ListUC1.FK_iGiaoTrinhID;
            _tblGiaoTrinhEO = tblGiaoTrinhDAO.GiaoTrinh_SelectItem(_tblGiaoTrinhEO);
            tblGiaoTrinh_DetailUC1.BindDataDetail(_tblGiaoTrinhEO);
        }

        protected void AddNew_Click(object sender, EventArgs e)
        {
            mtvMain.SetActiveView(vDetail);
            tblGiaoTrinhEO _GiaoTrinhEO = new tblGiaoTrinhEO();
            tblGiaoTrinh_DetailUC1.BindDataDetail(_GiaoTrinhEO);
        }
        #endregion

        protected void lbtnBack_Click(object sender, EventArgs e)
        {
            mtvMain.SetActiveView(vList);
            tblGiaoTrinh_ListUC1.BindData();
        }
    }
}