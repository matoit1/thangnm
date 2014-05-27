using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EHOU.DataAccessObject;
using EntityObject;
using DataAccessObject;

namespace EHOU.QuanTri
{
    public partial class tblAccount : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Request.QueryString["iTrangThai"] != null)
                {
                    tblAccount_ListUC1.iTrangThai = Convert.ToInt16(Request.QueryString["iTrangThai"]);
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
            tblAccount_DetailUC1.btnInsert.Visible = false;
            tblAccount_DetailUC1.btnUpdate.Visible = true;
            tblAccount_DetailUC1.btnDelete.Visible = true;
            tblAccount_DetailUC1.txtPK_sUsername.Enabled = false;
            tblAccount_DetailUC1.ddliType.Enabled = false;
            tblAccount_DetailUC1.ddliStatus.Enabled = false;
            tblAccountEO _tblAccountEO = new tblAccountEO();
            _tblAccountEO.PK_sUsername = tblAccount_ListUC1.PK_sUsername;
            _tblAccountEO = tblAccountDAO.Account_SelectItem(_tblAccountEO);
            tblAccount_DetailUC1.BindDataDetail(_tblAccountEO);
        }

        protected void AddNew_Click(object sender, EventArgs e)
        {
            mtvMain.SetActiveView(vDetail);
            tblAccount_DetailUC1.btnInsert.Visible = true;
            tblAccount_DetailUC1.btnUpdate.Visible = false;
            tblAccount_DetailUC1.btnDelete.Visible = false;
            tblAccount_DetailUC1.txtPK_sUsername.Enabled = true;
            tblAccount_DetailUC1.ddliType.Enabled = true;
            tblAccount_DetailUC1.ddliStatus.Enabled = true;
            tblAccountEO _tblAccountEO = new tblAccountEO();
            tblAccount_DetailUC1.BindDataDetail(_tblAccountEO);
        }


        protected void SelectRowChiTietHoaDon_Click(object sender, EventArgs e)
        {
            //MonHoc_DetailUC1.BindDataDetail(MonHoc_ListUC1.PK_sMaMonhoc);
        }
        #endregion

        protected void lbtnBack_Click(object sender, EventArgs e)
        {
            tblAccount_DetailUC1.ClearMessages();
            tblAccount_DetailUC1.lblMsg.Text = "";
            mtvMain.SetActiveView(vList);
            tblAccount_ListUC1.BindData();
        }
    }
}