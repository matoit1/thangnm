using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using Shared_Libraries.ChatLIB;
using EntityObject;
using DataAccessObject;
using System.IO;
using Shared_Libraries;
using System.Data;

namespace DO_AN_TN.UserControl
{
    public partial class ChatUC : System.Web.UI.UserControl
    {
        #region "Properties & Event"
        //public event EventHandler ViewDetail;
        //public static string path = HttpContext.Current.Request.MapPath("~/Upload/BlackList.txt");
        public static int indexrow =10;
        public TinNhanEO objTinNhanEO
        {
            get { return (TinNhanEO)ViewState["objTinNhanEO"]; }
            set { ViewState["objTinNhanEO"] = value; }
        }

        public LichDayVaHocEO objLichDayVaHocEO
        {
            get { return (LichDayVaHocEO)ViewState["objLichDayVaHocEO"]; }
            set { ViewState["objLichDayVaHocEO"] = value; }
        }
        
        public string sAccountDisabe
        {
            get { return (string)ViewState["sAccountDisabe"]; }
            set { ViewState["sAccountDisabe"] = value; }
        }
        public int iType
        {
            get { return (int)ViewState["iType"]; }
            set { ViewState["iType"] = value; }
        }
        public int iSumMessage
        {
            get { return (int)ViewState["iSumMessage"]; }
            set { ViewState["iSumMessage"] = value; }
        }
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                objLichDayVaHocEO = new LichDayVaHocEO();
                objLichDayVaHocEO.FK_sMaPCCT = "PCCT000001";
                objLichDayVaHocEO.FK_sMalop = "LH00010B1";
                objLichDayVaHocEO.iCaHoc = 2;
                objLichDayVaHocEO = LichDayVaHocDAO.LichDayVaHoc_SelectItem(objLichDayVaHocEO);

                loadDataToDropDownList();
                iType = 1;
                DataSet ds = TinNhanDAO.TinNhan_SelectList(objTinNhanEO);
                iSumMessage = ds.Tables[0].Rows.Count;
                rptDialog.DataSource = ds;
                rptDialog.DataBind();
                tAutoUpdateMessage.Interval = 5000;
            }
        }

        protected void btnSent_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "";
            try
            {
                List<string> lstAcc = objLichDayVaHocEO.sSinhVienChan.Split(',').ToList<string>();
                if (lstAcc.Any(s => s.Equals("SV100000")) == true)
                {
                    lblMsg.Text = string.Empty;
                    objTinNhanEO.sNoidung = Common.ReplaceKeyByEmoticons(Convert.ToString(txtsNoidung.Text));
                    if (string.IsNullOrEmpty(txtsNoidung.Text) == false)
                    {
                        if (TinNhanDAO.TinNhan_Insert(objTinNhanEO) == false)
                        {
                            lblMsg.Text = Messages.ChatRoom_Fail;
                        }
                        else
                        {
                            txtsNoidung.Text = "";
                            txtsNoidung.Focus();
                        }
                    }
                }
                else
                {
                    lblMsg.Text = Messages.ChatRoom_Limit;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void tAutoUpdateMessage_Tick(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = TinNhanDAO.TinNhan_SelectList(objTinNhanEO);
                if (iSumMessage != ds.Tables[0].Rows.Count)
                {
                    iSumMessage = ds.Tables[0].Rows.Count;
                    SinhVienEO _SinhVienEO = new SinhVienEO();
                    _SinhVienEO.FK_sMaLop = "LH00010B1";
                    lblSumOnline.Text = SinhVienDAO.SinhVien_SelectByFK_sMaLop(_SinhVienEO).Tables[0].Rows.Count.ToString();
                    rptDialog.DataSource = ds;
                    rptDialog.DataBind();
                }
            }
            catch { }
        }

        public string GetRowColor(object obj)
        {
            string color = "white";
            if (!string.IsNullOrEmpty(obj.ToString()))
            {
                int status =Convert.ToInt32(obj) % 2;
                switch (status)
                {
                    case 0:
                        color = "#0000FF "; break;
                    case 1:
                        color = "#FF0000"; break;
                    default:
                        color = "#CC66FF"; break;
                }
            }
            return color;
        }

        protected void rptDialog_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            try
            {
                string lblFK_sNguoiGui = ((Label)e.Item.FindControl("lblFK_sNguoiGui")).Text;
                SinhVienEO _SinhVienEO = new SinhVienEO();
                _SinhVienEO.sTendangnhapSV = lblFK_sNguoiGui;
                string PK_sMaSV = SinhVienDAO.SinhVien_SelectBysTendangnhapSV(_SinhVienEO).PK_sMaSV;
                switch (e.CommandName)
                {
                    case "ibntTool": break;
                    case "ibntDeleteMessage":
                        iSumMessage = 0;
                        objTinNhanEO.PK_lTinNhan = Convert.ToInt64(((HiddenField)e.Item.FindControl("hfdPK_lTinNhan")).Value);
                        if (TinNhanDAO.TinNhan_Delete(objTinNhanEO) == false)
                        {
                            ((Label)e.Item.FindControl("lblMsg")).Text = Messages.ChatRoom_Hide_Fail;
                        }
                        else
                        {
                            ((Label)e.Item.FindControl("lblMsg")).Text = Messages.ChatRoom_Hide_Success;
                        }
                        break;
                    case "ibntHideAcc":
                        iSumMessage = 0;
                        sAccountDisabe = PK_sMaSV;
                        objLichDayVaHocEO.sSinhVienChan = objLichDayVaHocEO.sSinhVienChan + sAccountDisabe + ",";
                        LichDayVaHocDAO.LichDayVaHoc_Update_sSinhVienNghi_sSinhVienChan_sLinkVideo(objLichDayVaHocEO);
                        ((ImageButton)e.Item.FindControl("ibntHideAcc")).Visible = false;
                        ((ImageButton)e.Item.FindControl("ibntShowAcc")).Visible = true;
                        break;
                    case "ibntShowAcc":
                        iSumMessage = 0;
                        sAccountDisabe = PK_sMaSV;
                        objLichDayVaHocEO.sSinhVienChan = objLichDayVaHocEO.sSinhVienChan.Replace("," + sAccountDisabe + ",", ",");
                        sAccountDisabe = "";
                        LichDayVaHocDAO.LichDayVaHoc_Update_sSinhVienNghi_sSinhVienChan_sLinkVideo(objLichDayVaHocEO);
                        ((ImageButton)e.Item.FindControl("ibntHideAcc")).Visible = true;
                        ((ImageButton)e.Item.FindControl("ibntShowAcc")).Visible = false;
                        break;
                }
            }
            catch
            {

            }
        }

        protected void rptDialog_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            try{
                if (iType == 1)
                {
                    LichDayVaHocEO _LichDayVaHocEO = new LichDayVaHocEO();
                    _LichDayVaHocEO.FK_sMaPCCT = "PCCT000001";
                    _LichDayVaHocEO.FK_sMalop = "LH00010B1";
                    _LichDayVaHocEO.iCaHoc = 2;
                    _LichDayVaHocEO = LichDayVaHocDAO.LichDayVaHoc_SelectItem(_LichDayVaHocEO);
                    Label lblFK_sNguoiGui = ((Label)e.Item.FindControl("lblFK_sNguoiGui"));
                    ImageButton ibntTool = ((ImageButton)e.Item.FindControl("ibntTool"));
                    ImageButton ibntDeleteMessage = ((ImageButton)e.Item.FindControl("ibntDeleteMessage"));
                    ImageButton ibntHideAcc = ((ImageButton)e.Item.FindControl("ibntHideAcc"));
                    ImageButton ibntShowAcc = ((ImageButton)e.Item.FindControl("ibntShowAcc"));
                    if (ibntTool != null) { ibntTool.Visible = true; } else { ibntTool.Visible = false; }
                    if (ibntDeleteMessage != null) { ibntDeleteMessage.Visible = true; } else { ibntDeleteMessage.Visible = false; }
                    if (ibntHideAcc != null) { ibntHideAcc.Visible = true; } else { ibntHideAcc.Visible = false; }
                    if (ibntShowAcc != null) { ibntShowAcc.Visible = true; } else { ibntShowAcc.Visible = false; }
                    if (lblFK_sNguoiGui != null)
                    {
                        SinhVienEO _SinhVienEO = new SinhVienEO();
                        _SinhVienEO.sTendangnhapSV = lblFK_sNguoiGui.Text;
                        string PK_sMaSV = SinhVienDAO.SinhVien_SelectBysTendangnhapSV(_SinhVienEO).PK_sMaSV;
                        List<string> lstAcc = _LichDayVaHocEO.sSinhVienChan.Split(',').ToList<string>();
                        if (lstAcc.Any(s => s.Equals(PK_sMaSV)) == true)
                        {
                            sAccountDisabe = PK_sMaSV;
                            ((ImageButton)e.Item.FindControl("ibntHideAcc")).Visible = false;
                            ((ImageButton)e.Item.FindControl("ibntShowAcc")).Visible = true;
                        }
                        else
                        {
                            sAccountDisabe = PK_sMaSV;
                            ((ImageButton)e.Item.FindControl("ibntHideAcc")).Visible = true;
                            ((ImageButton)e.Item.FindControl("ibntShowAcc")).Visible = false;
                        }
                    }
                }
            }
            catch{
            }
        }

        protected void ibtnSmileys_Click(object sender, ImageClickEventArgs e)
        {
            if (ddlSmiley.Visible == false)
            {
                ddlSmiley.Visible = true;
                txtsNoidung.Width = 175;
            }
            else
            {
                ddlSmiley.Visible = false;
                txtsNoidung.Width = 235;
            }
        }

        protected void ddlSmiley_TextChanged(object sender, EventArgs e)
        {
            txtsNoidung.Text = txtsNoidung.Text + ddlSmiley.SelectedValue;
            txtsNoidung.Focus();
        }

        public void loadDataToDropDownList()
        {

            ddlSmiley.DataSource = GetListConstants.Emoticons_GLC();
            ddlSmiley.DataTextField = "Key";
            ddlSmiley.DataValueField = "Key";
            ddlSmiley.DataBind();
        }
    }
}