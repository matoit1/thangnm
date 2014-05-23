using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HaBa.EntityObject;
using HaBa.DataAccessObject;

namespace HaBa.Admin
{
    public partial class ThanhToan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Request.QueryString["iTrangThai"] != null)
                {
                    tblThanhToan_ListUC1.iTrangThai = Convert.ToInt16(Request.QueryString["iTrangThai"]);
                }
            }
            catch
            {
            }
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
            tblThanhToanEO _tblThanhToanEO = new tblThanhToanEO();
            _tblThanhToanEO.PK_iThanhToanID = tblThanhToan_ListUC1.PK_iThanhToanID;
            _tblThanhToanEO = tblThanhToanDAO.ThanhToan_SelectItem(_tblThanhToanEO);
            tblThanhToan_DetailUC1.BindDataDetail(_tblThanhToanEO);
        }

        protected void AddNew_Click(object sender, EventArgs e)
        {
            mtvMain.SetActiveView(vDetail);
            tblThanhToanEO _tblThanhToanEO = new tblThanhToanEO();
            tblThanhToan_DetailUC1.BindDataDetail(_tblThanhToanEO);
        }
        #endregion

        protected void lbtnBack_Click(object sender, EventArgs e)
        {
            tblThanhToan_DetailUC1.ClearMessages();
            tblThanhToan_DetailUC1.lblMsg.Text = "";
            mtvMain.SetActiveView(vList);
            tblThanhToan_ListUC1.BindData();
        }
    }
}