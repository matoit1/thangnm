using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CongKy.DataAccessObject;
using CongKy.EntityObject;

namespace CongKy.GiangVien
{
    public partial class MonHoc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Request.QueryString["iTrangThai"] != null)
                {
                    tblMonHoc_ListUC1.iTrangThai = Convert.ToInt16(Request.QueryString["iTrangThai"]);
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
            tblMonHocEO _tblMonHocEO = new tblMonHocEO();
            _tblMonHocEO.PK_iMonHocID = tblMonHoc_ListUC1.PK_iMonHocID;
            _tblMonHocEO = tblMonHocDAO.MonHoc_SelectItem(_tblMonHocEO);
            tblMonHoc_DetailUC1.BindDataDetail(_tblMonHocEO);
        }

        protected void AddNew_Click(object sender, EventArgs e)
        {
            mtvMain.SetActiveView(vDetail);
            tblMonHocEO _MonHocEO = new tblMonHocEO();
            tblMonHoc_DetailUC1.BindDataDetail(_MonHocEO);
        }
        #endregion

        protected void lbtnBack_Click(object sender, EventArgs e)
        {
            mtvMain.SetActiveView(vList);
            tblMonHoc_ListUC1.BindData();
        }
    }
}