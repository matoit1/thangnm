using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityObject;
using DataAccessObject;

namespace DO_AN_TN.Test
{
    public partial class TBaiViet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public override void VerifyRenderingInServerForm(Control control)
        {
            //base.VerifyRenderingInServerForm(control);
        }

        #region "Raise Event"
        protected void SelectRow_Click(object sender, EventArgs e)
        {
            //MonHoc_DetailUC1.BindDataDetail(MonHoc_ListUC1.PK_sMaMonhoc);
        }

        protected void ViewDetail_Click(object sender, EventArgs e)
        {
            mtvMain.SetActiveView(vDetail);
            BaiVietEO _BaiVietEO = new BaiVietEO();
            _BaiVietEO.PK_lMaBaiViet = BaiViet_ListUC1.PK_lMaBaiViet;
            _BaiVietEO = BaiVietDAO.BaiViet_SelectItem(_BaiVietEO);
            BaiViet_DetailUC1.BindDataDetail(_BaiVietEO);
        }

        protected void AddNew_Click(object sender, EventArgs e)
        {
            mtvMain.SetActiveView(vDetail);
            BaiVietEO _BaiVietEO = new BaiVietEO();
            BaiViet_DetailUC1.BindDataDetail(_BaiVietEO);
        }
        #endregion

        protected void lbtnBack_Click(object sender, EventArgs e)
        {
            mtvMain.SetActiveView(vList);
            BaiViet_ListUC1.BindData();
        }
    }
}