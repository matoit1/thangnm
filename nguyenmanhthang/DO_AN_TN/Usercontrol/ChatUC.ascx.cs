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
        public string sColor
        {
            get { return (string)ViewState["sColor"]; }
            set { ViewState["sColor"] = value; }
        }
        public int iTypeUser
        {
            get { return (int)ViewState["iTypeUser"]; }
            set { ViewState["iTypeUser"] = value; }
        }
        public int iSumMessage
        {
            get { return (int)ViewState["iSumMessage"]; }
            set { ViewState["iSumMessage"] = value; }
        }
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    //objLichDayVaHocEO = new LichDayVaHocEO();
                    //objLichDayVaHocEO.FK_sMaPCCT = "PCCT000001";
                    //objLichDayVaHocEO.FK_sMalop = "LH00010B1";
                    //objLichDayVaHocEO.iCaHoc = 2;
                    //objLichDayVaHocEO = LichDayVaHocDAO.LichDayVaHoc_SelectItem(objLichDayVaHocEO);
                    sColor = "#000000";
                    loadDataToDropDownList();
                    DataSet ds = TinNhanDAO.TinNhan_SelectList(objTinNhanEO);
                    iSumMessage = ds.Tables[0].Rows.Count;
                    rptDialog.DataSource = ds;
                    rptDialog.DataBind();
                    tAutoUpdateMessage.Interval = 5000;
                }
            }
            catch { }
        }

        protected void btnSent_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "";
            try
            {
                List<string> lstAcc = objLichDayVaHocEO.sSinhVienChan.Split(',').ToList<string>();
                if (lstAcc.Any(s => s.Equals(objTinNhanEO.FK_sNguoiGui)) == false)
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
                objLichDayVaHocEO = LichDayVaHocDAO.LichDayVaHoc_SelectItem(objLichDayVaHocEO);
                DataSet ds = TinNhanDAO.TinNhan_SelectList(objTinNhanEO);
                if (iSumMessage != ds.Tables[0].Rows.Count)
                {
                    iSumMessage = ds.Tables[0].Rows.Count;
                    SinhVienEO _SinhVienEO = new SinhVienEO();
                    _SinhVienEO.FK_sMaLop = objLichDayVaHocEO.FK_sMalop;
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
            try
            {
                if (!string.IsNullOrEmpty(obj.ToString()))
                {
                    int status = Convert.ToInt32(obj) % 2;
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
            catch { return color; }
            
        }

        protected void rptDialog_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            try
            {
                //string sAccountDisabe;
                HiddenField hfFK_sNguoiGui = (HiddenField)e.Item.FindControl("hfFK_sNguoiGui");
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
                        //sAccountDisabe = lblFK_sNguoiGui;
                        objLichDayVaHocEO.sSinhVienChan = objLichDayVaHocEO.sSinhVienChan + hfFK_sNguoiGui.Value + ",";
                        LichDayVaHocDAO.LichDayVaHoc_Update_sSinhVienNghi_sSinhVienChan_sLinkVideo(objLichDayVaHocEO);
                        ((ImageButton)e.Item.FindControl("ibntHideAcc")).Visible = false;
                        ((ImageButton)e.Item.FindControl("ibntShowAcc")).Visible = true;
                        break;
                    case "ibntShowAcc":
                        iSumMessage = 0;
                       // sAccountDisabe = lblFK_sNguoiGui;
                        objLichDayVaHocEO.sSinhVienChan = objLichDayVaHocEO.sSinhVienChan.Replace("," + hfFK_sNguoiGui.Value + ",", ",");
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
                //string sAccountDisabe;
                //if (iTypeUser == Messages.ChatRoom_TypeUser_GiangVien)
                //{
                    LichDayVaHocEO _LichDayVaHocEO = new LichDayVaHocEO();
                    //_LichDayVaHocEO.FK_sMaPCCT = "PCCT000001";
                    //_LichDayVaHocEO.FK_sMalop = "LH00010B1";
                    //_LichDayVaHocEO.iCaHoc = 2;
                    _LichDayVaHocEO = LichDayVaHocDAO.LichDayVaHoc_SelectItem(objLichDayVaHocEO);
                    HiddenField hfFK_sNguoiGui = (HiddenField)e.Item.FindControl("hfFK_sNguoiGui");
                    Label lblFK_sNguoiGui = (Label)e.Item.FindControl("lblFK_sNguoiGui");
                    Label lblsNoidung = (Label)e.Item.FindControl("lblsNoidung");
                    ImageButton ibntTool = ((ImageButton)e.Item.FindControl("ibntTool"));
                    ImageButton ibntDeleteMessage = ((ImageButton)e.Item.FindControl("ibntDeleteMessage"));
                    ImageButton ibntHideAcc = ((ImageButton)e.Item.FindControl("ibntHideAcc"));
                    ImageButton ibntShowAcc = ((ImageButton)e.Item.FindControl("ibntShowAcc"));
                    if (ibntTool != null && iTypeUser == Messages.ChatRoom_TypeUser_GiangVien) { ibntTool.Visible = true; } else { ibntTool.Visible = false; }
                    if (ibntDeleteMessage != null && iTypeUser == Messages.ChatRoom_TypeUser_GiangVien) { ibntDeleteMessage.Visible = true; } else { ibntDeleteMessage.Visible = false; }
                    if (ibntHideAcc != null && iTypeUser == Messages.ChatRoom_TypeUser_GiangVien) { ibntHideAcc.Visible = true; } else { ibntHideAcc.Visible = false; }
                    if (ibntShowAcc != null && iTypeUser == Messages.ChatRoom_TypeUser_GiangVien) { ibntShowAcc.Visible = true; } else { ibntShowAcc.Visible = false; }
                    if (hfFK_sNguoiGui != null)
                    {
                        //SinhVienEO _SinhVienEO = new SinhVienEO();
                        //_SinhVienEO.sTendangnhapSV = lblFK_sNguoiGui.Text;
                        //string PK_sMaSV = SinhVienDAO.SinhVien_SelectBysTendangnhapSV(_SinhVienEO).PK_sMaSV;

                        List<string> lstAcc = _LichDayVaHocEO.sSinhVienChan.Split(',').ToList<string>();
                        if ((lstAcc.Any(s => s.Contains(hfFK_sNguoiGui.Value))) == true)
                        {
                           // sAccountDisabe = lblFK_sNguoiGui.Text;
                            ((ImageButton)e.Item.FindControl("ibntHideAcc")).Visible = false;
                            ((ImageButton)e.Item.FindControl("ibntShowAcc")).Visible = true;
                        }
                        else
                        {
                            //sAccountDisabe = lblFK_sNguoiGui.Text;
                            ((ImageButton)e.Item.FindControl("ibntHideAcc")).Visible = true;
                            ((ImageButton)e.Item.FindControl("ibntShowAcc")).Visible = false;
                        }
                    }
                    if (lblFK_sNguoiGui != null)
                    {
                        GiangVienEO _GiangVienEO = new GiangVienEO();
                        _GiangVienEO.PK_sMaGV = lblFK_sNguoiGui.Text;
                        _GiangVienEO = GiangVienDAO.GiangVien_SelectItem(_GiangVienEO);

                        SinhVienEO _SinhVienEO = new SinhVienEO();
                        _SinhVienEO.PK_sMaSV = lblFK_sNguoiGui.Text;
                        _SinhVienEO = SinhVienDAO.SinhVien_SelectItem(_SinhVienEO);
                        
                        if (_GiangVienEO.PK_sMaGV != null)
                        {
                            lblFK_sNguoiGui.Text = _GiangVienEO.sHotenGV;
                            if(_GiangVienEO.PK_sMaGV != objTinNhanEO.FK_sNguoiGui){
                                lblFK_sNguoiGui.Font.Underline = true;
                                lblFK_sNguoiGui.ForeColor = System.Drawing.Color.Blue;
                            }
                        }
                        else
                        {
                            if (_SinhVienEO.PK_sMaSV != null)
                            {
                                lblFK_sNguoiGui.Text = _SinhVienEO.sHotenSV;
                            }
                            else
                            {
                                lblFK_sNguoiGui.Text = Messages.Chat_An_Danh;
                            }
                        }
                    }

                    if (lblsNoidung != null && objTinNhanEO.FK_sNguoiGui == hfFK_sNguoiGui.Value)
                    {
                        lblsNoidung.ForeColor = System.Drawing.ColorTranslator.FromHtml(sColor);
                    }
                    if (lblFK_sNguoiGui != null && objTinNhanEO.FK_sNguoiGui == hfFK_sNguoiGui.Value)
                    {
                        if (iTypeUser == Messages.ChatRoom_TypeUser_GiangVien)
                        {
                            lblFK_sNguoiGui.ForeColor = System.Drawing.Color.Blue;
                            lblFK_sNguoiGui.ToolTip = Messages.ChatRoom_GiangVien;
                        }
                        else
                        {
                            lblFK_sNguoiGui.ForeColor = System.Drawing.Color.LightSkyBlue;
                        }
                    }
                //}
            }
            catch{
            }
        }

        protected void ibtnSmileys_Click(object sender, ImageClickEventArgs e)
        {
            if (ddlSmiley.Visible == false)
            {
                ddlSmiley.Visible = true;
                txtsNoidung.Width = 140;
            }
            else
            {
                ddlSmiley.Visible = false;
                txtsNoidung.Width = 210;
            }
        }

        protected void ddlSmiley_TextChanged(object sender, EventArgs e)
        {
            txtsNoidung.Text = txtsNoidung.Text + ddlSmiley.SelectedValue;
            txtsNoidung.Focus();
        }

        public void loadDataToDropDownList()
        {
            try
            {
                ddlSmiley.DataSource = GetListConstants.Emoticons_GLC();
                ddlSmiley.DataTextField = "Key";
                ddlSmiley.DataValueField = "Key";
                ddlSmiley.DataBind();
            }
            catch { }
        }

        protected void txtColor_TextChanged(object sender, EventArgs e)
        {
            sColor = txtColor.Text;
            iSumMessage = 0;
        }
    }
}