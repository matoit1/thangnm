using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CongKy.EntityObject;
using CongKy.DataAccessObject;

namespace CongKy.QuanTri
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
            tblMonHoc_DetailUC1.btnInsert.Visible = false;
            tblMonHoc_DetailUC1.btnUpdate.Visible = true;
            tblMonHoc_DetailUC1.btnDelete.Visible = true;
        }

        protected void AddNew_Click(object sender, EventArgs e)
        {
            mtvMain.SetActiveView(vDetail);
            tblMonHocEO _MonHocEO = new tblMonHocEO();
            tblMonHoc_DetailUC1.BindDataDetail(_MonHocEO);
            tblMonHoc_DetailUC1.btnInsert.Visible = true;
            tblMonHoc_DetailUC1.btnUpdate.Visible = false;
            tblMonHoc_DetailUC1.btnDelete.Visible = false;
        }
        #endregion

        protected void lbtnBack_Click(object sender, EventArgs e)
        {
            mtvMain.SetActiveView(vList);
            tblMonHoc_ListUC1.BindData();
        }
    }
}