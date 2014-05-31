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
                    tblChiTietGiaoTrinh_ListUC1.PK_iTaiKhoanID = 0;
                    tblChiTietGiaoTrinh_ListUC1.PK_iMonHocID = 0;
                    tblChiTietGiaoTrinh_ListUC1.PK_iGiaoTrinhID = 0;
                    tblChiTietGiaoTrinh_ListUC1.newfeed = false;
                    tblChiTietGiaoTrinh_ListUC1.BindData();
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

            tblChiTietGiaoTrinh_DetailUC1.btnInsert.Visible = false;
            tblChiTietGiaoTrinh_DetailUC1.btnUpdate.Visible = true;
            tblChiTietGiaoTrinh_DetailUC1.btnDelete.Visible = true;
        }

        protected void AddNew_Click(object sender, EventArgs e)
        {
            mtvMain.SetActiveView(vDetail);
            tblChiTietGiaoTrinhEO _tblChiTietGiaoTrinhEO = new tblChiTietGiaoTrinhEO();
            tblMonHocEO _tblMonHocEO = new tblMonHocEO();
            tblChiTietGiaoTrinh_DetailUC1.BindDataDetail(_tblChiTietGiaoTrinhEO, _tblMonHocEO);

            tblChiTietGiaoTrinh_DetailUC1.btnInsert.Visible = true;
            tblChiTietGiaoTrinh_DetailUC1.btnUpdate.Visible = false;
            tblChiTietGiaoTrinh_DetailUC1.btnDelete.Visible = false;
        }
        #endregion

        protected void lbtnBack_Click(object sender, EventArgs e)
        {
            mtvMain.SetActiveView(vList);
            tblChiTietGiaoTrinh_ListUC1.BindData();
        }
    }
}