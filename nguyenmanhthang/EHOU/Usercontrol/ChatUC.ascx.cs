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

namespace EHOU.UserControl
{
    public partial class ChatUC : System.Web.UI.UserControl
    {
        #region "Properties & Event"
        //public event EventHandler ViewDetail;
        //public static string path = HttpContext.Current.Request.MapPath("~/Upload/BlackList.txt");
        public static int indexrow =10;
        public tblMessageEO objtblMessageEO
        {
            get { return (tblMessageEO)ViewState["objTinNhanEO"]; }
            set { ViewState["objTinNhanEO"] = value; }
        }
        public tblSubjectEO objtblSubjectEO
        {
            get { return (tblSubjectEO)ViewState["objtblSubjectEO"]; }
            set { ViewState["objtblSubjectEO"] = value; }
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
                    DataSet ds = tblMessageDAO.Message_SelectList(objtblMessageEO);
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
                List<string> lstAcc = objtblSubjectEO.sBlackList.Split(',').ToList<string>();
                if (lstAcc.Any(s => s.Equals(objtblMessageEO.FK_sUsername)) == false)
                {
                    lblMsg.Text = string.Empty;
                    objtblMessageEO.sContent = Common.ReplaceKeyByEmoticons(Convert.ToString(txtsContent.Text));
                    if (string.IsNullOrEmpty(txtsContent.Text) == false)
                    {
                        if (tblMessageDAO.Message_Insert(objtblMessageEO) == false)
                        {
                            lblMsg.Text = Messages.ChatRoom_Fail;
                        }
                        else
                        {
                            txtsContent.Text = "";
                            txtsContent.Focus();
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
                objtblSubjectEO = tblSubjectDAO.Subject_SelectItem(objtblSubjectEO);
                DataSet ds = tblMessageDAO.Message_SelectList(objtblMessageEO);
                if (iSumMessage != ds.Tables[0].Rows.Count)
                {
                    iSumMessage = ds.Tables[0].Rows.Count;
                    SinhVienEO _SinhVienEO = new SinhVienEO();
                    _SinhVienEO.FK_sMaLop = objtblSubjectEO.PK_sSubject;
                    //lblSumOnline.Text = SinhVienDAO.SinhVien_SelectByFK_sMaLop(_SinhVienEO).Tables[0].Rows.Count.ToString();
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
                HiddenField hfFK_sUsername = (HiddenField)e.Item.FindControl("hfFK_sUsername");
                switch (e.CommandName)
                {
                    case "ibntTool": break;
                    case "ibntDeleteMessage":
                        iSumMessage = 0;
                        objtblMessageEO.PK_lMessage = Convert.ToInt64(((HiddenField)e.Item.FindControl("hfdPK_lMessage")).Value);
                        if (tblMessageDAO.Message_Delete(objtblMessageEO) == false)
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
                        //sAccountDisabe = lblFK_sUsername;
                        objtblSubjectEO.sBlackList = objtblSubjectEO.sBlackList + hfFK_sUsername.Value + ",";
                        tblSubjectDAO.Subject_Update_sLinkVideo_sBlackList(objtblSubjectEO);
                        ((ImageButton)e.Item.FindControl("ibntHideAcc")).Visible = false;
                        ((ImageButton)e.Item.FindControl("ibntShowAcc")).Visible = true;
                        break;
                    case "ibntShowAcc":
                        iSumMessage = 0;
                       // sAccountDisabe = lblFK_sUsername;
                        objtblSubjectEO.sBlackList = objtblSubjectEO.sBlackList.Replace("," + hfFK_sUsername.Value + ",", ",");
                        tblSubjectDAO.Subject_Update_sLinkVideo_sBlackList(objtblSubjectEO);
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
                    tblSubjectEO _tblSubjectEO = new tblSubjectEO();
                    //_LichDayVaHocEO.FK_sMaPCCT = "PCCT000001";
                    //_LichDayVaHocEO.FK_sMalop = "LH00010B1";
                    //_LichDayVaHocEO.iCaHoc = 2;
                    _tblSubjectEO = tblSubjectDAO.Subject_SelectItem(objtblSubjectEO);
                    HiddenField hfFK_sUsername = (HiddenField)e.Item.FindControl("hfFK_sUsername");
                    Label lblFK_sUsername = (Label)e.Item.FindControl("lblFK_sUsername");
                    Label lblsContent = (Label)e.Item.FindControl("lblsContent");
                    ImageButton ibntTool = ((ImageButton)e.Item.FindControl("ibntTool"));
                    ImageButton ibntDeleteMessage = ((ImageButton)e.Item.FindControl("ibntDeleteMessage"));
                    ImageButton ibntHideAcc = ((ImageButton)e.Item.FindControl("ibntHideAcc"));
                    ImageButton ibntShowAcc = ((ImageButton)e.Item.FindControl("ibntShowAcc"));
                    if (ibntTool != null && iTypeUser == Messages.ChatRoom_TypeUser_GiangVien) { ibntTool.Visible = true; } else { ibntTool.Visible = false; }
                    if (ibntDeleteMessage != null && iTypeUser == Messages.ChatRoom_TypeUser_GiangVien) { ibntDeleteMessage.Visible = true; } else { ibntDeleteMessage.Visible = false; }
                    if (ibntHideAcc != null && iTypeUser == Messages.ChatRoom_TypeUser_GiangVien) { ibntHideAcc.Visible = true; } else { ibntHideAcc.Visible = false; }
                    if (ibntShowAcc != null && iTypeUser == Messages.ChatRoom_TypeUser_GiangVien) { ibntShowAcc.Visible = true; } else { ibntShowAcc.Visible = false; }
                    if (hfFK_sUsername != null)
                    {
                        //SinhVienEO _SinhVienEO = new SinhVienEO();
                        //_SinhVienEO.sTendangnhapSV = lblFK_sUsername.Text;
                        //string PK_sMaSV = SinhVienDAO.SinhVien_SelectBysTendangnhapSV(_SinhVienEO).PK_sMaSV;

                        List<string> lstAcc = _tblSubjectEO.sBlackList.Split(',').ToList<string>();
                        if ((lstAcc.Any(s => s.Contains(hfFK_sUsername.Value))) == true)
                        {
                           // sAccountDisabe = lblFK_sUsername.Text;
                            ((ImageButton)e.Item.FindControl("ibntHideAcc")).Visible = false;
                            ((ImageButton)e.Item.FindControl("ibntShowAcc")).Visible = true;
                        }
                        else
                        {
                            //sAccountDisabe = lblFK_sUsername.Text;
                            ((ImageButton)e.Item.FindControl("ibntHideAcc")).Visible = true;
                            ((ImageButton)e.Item.FindControl("ibntShowAcc")).Visible = false;
                        }
                    }
                    if (lblFK_sUsername != null)
                    {
                        //GiangVienEO _GiangVienEO = new GiangVienEO();
                        //_GiangVienEO.PK_sMaGV = lblFK_sUsername.Text;
                        //_GiangVienEO = GiangVienDAO.GiangVien_SelectItem(_GiangVienEO);

                        //SinhVienEO _SinhVienEO = new SinhVienEO();
                        //_SinhVienEO.PK_sMaSV = lblFK_sUsername.Text;
                        //_SinhVienEO = SinhVienDAO.SinhVien_SelectItem(_SinhVienEO);

                        tblDetailEO _tblDetailEO = new tblDetailEO();
                        
                        if (objtblMessageEO.FK_sUsername != null)
                        {
                            lblFK_sUsername.Text = objtblMessageEO.FK_sUsername;
                            if (_tblDetailEO.FK_sStudent != objtblMessageEO.FK_sUsername)
                            {
                                lblFK_sUsername.Font.Underline = true;
                                lblFK_sUsername.ForeColor = System.Drawing.Color.Blue;
                            }
                        }
                        else
                        {
                            if (_tblDetailEO.FK_sStudent != null)
                            {
                                lblFK_sUsername.Text = _tblDetailEO.FK_sStudent;
                            }
                            else
                            {
                                lblFK_sUsername.Text = Messages.Chat_An_Danh;
                            }
                        }
                    }

                    if (lblsContent != null && objtblMessageEO.FK_sUsername == hfFK_sUsername.Value)
                    {
                        lblsContent.ForeColor = System.Drawing.ColorTranslator.FromHtml(sColor);
                    }
                    if (lblFK_sUsername != null && objtblMessageEO.FK_sUsername == hfFK_sUsername.Value)
                    {
                        if (iTypeUser == Messages.ChatRoom_TypeUser_GiangVien)
                        {
                            lblFK_sUsername.ForeColor = System.Drawing.Color.Blue;
                            lblFK_sUsername.ToolTip = Messages.ChatRoom_GiangVien;
                        }
                        else
                        {
                            lblFK_sUsername.ForeColor = System.Drawing.Color.LightSkyBlue;
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
                txtsContent.Width = 140;
            }
            else
            {
                ddlSmiley.Visible = false;
                txtsContent.Width = 210;
            }
        }

        protected void ddlSmiley_TextChanged(object sender, EventArgs e)
        {
            txtsContent.Text = txtsContent.Text + ddlSmiley.SelectedValue;
            txtsContent.Focus();
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