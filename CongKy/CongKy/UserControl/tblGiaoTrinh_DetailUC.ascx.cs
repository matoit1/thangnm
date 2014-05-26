using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CongKy.EntityObject;
using CongKy.SharedLibraries;
using CongKy.DataAccessObject;

namespace CongKy.UserControl
{
    public partial class tblGiaoTrinh_DetailUC : System.Web.UI.UserControl
    {
        //#region "Properties & Event"
        //public Int16 iType
        //{
        //    get { return (Int16)ViewState["iType"]; }
        //    set { ViewState["iType"] = value; }
        //}
        //#endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ClearMessages();
                loadDataToDropDownList();
            }
        }

        public void BindDataDetail(tblGiaoTrinhEO _tblGiaoTrinhEO)
        {
            try { ddlFK_iMonHocID.SelectedValue = Convert.ToString(_tblGiaoTrinhEO.FK_iMonHocID); }
            catch { ddlFK_iMonHocID.SelectedIndex = 0; }
            try { ddlFK_iGiaoTrinhID.SelectedValue = Convert.ToString(_tblGiaoTrinhEO.FK_iGiaoTrinhID); }
            catch { ddlFK_iGiaoTrinhID.SelectedIndex = 0; }
        }

        private tblGiaoTrinhEO getObject()
        {
            try
            {
                tblGiaoTrinhEO _tblGiaoTrinhEO = new tblGiaoTrinhEO();
                try { _tblGiaoTrinhEO.FK_iMonHocID = Convert.ToInt32(ddlFK_iMonHocID.SelectedValue); }
                catch { lblFK_iMonHocID.Text = Messages.Ma_Khong_Hop_Le; }
                try { _tblGiaoTrinhEO.FK_iGiaoTrinhID = Convert.ToInt32(ddlFK_iGiaoTrinhID.SelectedValue); }
                catch { lblFK_iGiaoTrinhID.Text = Messages.Ma_Khong_Hop_Le; }
                return _tblGiaoTrinhEO;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void loadDataToDropDownList()
        {
            ddlFK_iMonHocID.DataSource = tblMonHocDAO.MonHoc_SelectList();
            ddlFK_iMonHocID.DataTextField = "sTenMonHoc";
            ddlFK_iMonHocID.DataValueField = "PK_iMonHocID";
            ddlFK_iMonHocID.DataBind();

            ddlFK_iGiaoTrinhID.DataSource = tblChiTietGiaoTrinhDAO.ChiTietGiaoTrinh_SelectList();
            ddlFK_iGiaoTrinhID.DataTextField = "sTenBaiHoc";
            ddlFK_iGiaoTrinhID.DataValueField = "PK_iGiaoTrinhID";
            ddlFK_iGiaoTrinhID.DataBind();
        }

       
        public void ClearMessages()
        {
            //lblMsg.Text = "";
            lblFK_iMonHocID.Text = "";
            lblFK_iGiaoTrinhID.Text = "";
        }

        #region "Event Button"
        protected void btnInsert_Click(object sender, EventArgs e)
        {
            ClearMessages();
            lblMsg.Text = "";
            try
            {
                    if (tblGiaoTrinhDAO.GiaoTrinh_Insert(getObject()) == true)
                    {
                        lblMsg.Text = Messages.Them_Thanh_Cong;
                        ClearMessages();
                        tblGiaoTrinhEO _tblGiaoTrinhEO = new tblGiaoTrinhEO();
                        BindDataDetail(_tblGiaoTrinhEO);
                    }
                    else
                    {
                        lblMsg.Text = Messages.Them_That_Bai;
                    }
            }
            catch (Exception ex)
            {
                lblMsg.Text = Messages.Loi + ex.Message;
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            ClearMessages();
            lblMsg.Text = "";
            try
            {
                    if (tblGiaoTrinhDAO.GiaoTrinh_Update(getObject()) == true)
                    {
                        lblMsg.Text = Messages.Sua_Thanh_Cong;
                        ClearMessages();
                    }
                    else
                    {
                        lblMsg.Text = Messages.Sua_That_Bai;
                    }
            }
            catch (Exception ex)
            {
                lblMsg.Text = Messages.Loi + ex.Message;
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            ClearMessages();
            lblMsg.Text = "";
            try
            {
                if (tblGiaoTrinhDAO.GiaoTrinh_Delete(getObject()) == true)
                {
                    lblMsg.Text = Messages.Xoa_Thanh_Cong;
                    ClearMessages();
                    tblGiaoTrinhEO _tblGiaoTrinhEO = new tblGiaoTrinhEO();
                    BindDataDetail(_tblGiaoTrinhEO);
                }
                else
                {
                    lblMsg.Text = Messages.Xoa_That_Bai;
                }
            }
            catch (Exception ex)
            {
                lblMsg.Text = Messages.Loi + ex.Message;
            }
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            ClearMessages();
            lblMsg.Text = "";
            tblGiaoTrinhEO _tblGiaoTrinhEO = new tblGiaoTrinhEO();
            BindDataDetail(_tblGiaoTrinhEO);
        }
        #endregion
    }
}