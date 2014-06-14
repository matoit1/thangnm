using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using EntityObject;
using DataAccessObject;
using System.IO;
using Shared_Libraries;
using System.Data;
using Shared_Libraries.Constants;

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
            get { return (tblMessageEO)ViewState["objtblMessageEO"]; }
            set { ViewState["objtblMessageEO"] = value; }
        }
        public tblPartEO objtblPartEO
        {
            get { return (tblPartEO)ViewState["objtblPartEO"]; }
            set { ViewState["objtblPartEO"] = value; }
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
                    sColor = "#000000";
                    loadDataToDropDownList();
                    DataSet ds = tblMessageDAO.Message_SelectByFK_sRoom(objtblMessageEO);
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
                List<string> lstAcc = objtblPartEO.sBlackList.Split(',').ToList<string>();
                if (lstAcc.Any(s => s.Equals(objtblMessageEO.FK_sUsername)) == false)
                {
                    lblMsg.Text = string.Empty;
                    objtblMessageEO.sContent = Common.ReplaceKeyByEmoticons(Convert.ToString(txtsNoidung.Text));
                    if (string.IsNullOrEmpty(txtsNoidung.Text) == false)
                    {
                        if (tblMessageDAO.Message_Insert(objtblMessageEO) == false)
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
                objtblPartEO = tblPartDAO.Part_SelectItem(objtblPartEO);
                DataSet ds = tblMessageDAO.Message_SelectByFK_sRoom(objtblMessageEO);
                if (iSumMessage != ds.Tables[0].Rows.Count)
                {
                    iSumMessage = ds.Tables[0].Rows.Count;
                    tblAccountEO _tblAccountEO = new tblAccountEO();
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
                HiddenField hfFK_sNguoiGui = (HiddenField)e.Item.FindControl("hfFK_sNguoiGui");
                switch (e.CommandName)
                {
                    case "ibntTool": break;
                    case "ibntDeleteMessage":
                        iSumMessage = 0;
                        objtblMessageEO.PK_lMessage = Convert.ToInt64(((HiddenField)e.Item.FindControl("hfdPK_lTinNhan")).Value);
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
                        objtblPartEO.sBlackList = objtblPartEO.sBlackList + hfFK_sNguoiGui.Value + ",";
                        objtblPartEO.iStatus = 0;
                        tblPartDAO.Part_Update_sLinkVideo_sBlackList(objtblPartEO);
                        ((ImageButton)e.Item.FindControl("ibntHideAcc")).Visible = false;
                        ((ImageButton)e.Item.FindControl("ibntShowAcc")).Visible = true;
                        break;
                    case "ibntShowAcc":
                        iSumMessage = 0;
                        objtblPartEO.sBlackList = objtblPartEO.sBlackList.Replace("," + hfFK_sNguoiGui.Value + ",", ",");
                        objtblPartEO.iStatus = 0;
                        tblPartDAO.Part_Update_sLinkVideo_sBlackList(objtblPartEO);
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
                    tblPartEO _tblPartEO = new tblPartEO();
                    _tblPartEO = tblPartDAO.Part_SelectItem(objtblPartEO);
                    HiddenField hfFK_sNguoiGui = (HiddenField)e.Item.FindControl("hfFK_sNguoiGui");
                    Label lblFK_sNguoiGui = (Label)e.Item.FindControl("lblFK_sNguoiGui");
                    Label lblsNoidung = (Label)e.Item.FindControl("lblsNoidung");
                    ImageButton ibntTool = ((ImageButton)e.Item.FindControl("ibntTool"));
                    ImageButton ibntDeleteMessage = ((ImageButton)e.Item.FindControl("ibntDeleteMessage"));
                    ImageButton ibntHideAcc = ((ImageButton)e.Item.FindControl("ibntHideAcc"));
                    ImageButton ibntShowAcc = ((ImageButton)e.Item.FindControl("ibntShowAcc"));
                    if (ibntTool != null && iTypeUser == tblAccount_iType_C.Giang_Vien) { ibntTool.Visible = true; } else { ibntTool.Visible = false; }
                    if (ibntDeleteMessage != null && iTypeUser == tblAccount_iType_C.Giang_Vien) { ibntDeleteMessage.Visible = true; } else { ibntDeleteMessage.Visible = false; }
                    if (ibntHideAcc != null && iTypeUser == tblAccount_iType_C.Giang_Vien) { ibntHideAcc.Visible = true; } else { ibntHideAcc.Visible = false; }
                    if (ibntShowAcc != null && iTypeUser == tblAccount_iType_C.Giang_Vien) { ibntShowAcc.Visible = true; } else { ibntShowAcc.Visible = false; }
                    if (hfFK_sNguoiGui != null)
                    {
                        List<string> lstAcc = _tblPartEO.sBlackList.Split(',').ToList<string>();
                        if ((lstAcc.Any(s => s.Contains(hfFK_sNguoiGui.Value))) == true)
                        {
                            ((ImageButton)e.Item.FindControl("ibntHideAcc")).Visible = false;
                            ((ImageButton)e.Item.FindControl("ibntShowAcc")).Visible = true;
                        }
                        else
                        {
                            ((ImageButton)e.Item.FindControl("ibntHideAcc")).Visible = true;
                            ((ImageButton)e.Item.FindControl("ibntShowAcc")).Visible = false;
                        }
                    }
                    tblAccountEO _tblAccountEO = new tblAccountEO();
                    _tblAccountEO.PK_sUsername = lblFK_sNguoiGui.Text;
                    _tblAccountEO = tblAccountDAO.Account_SelectItem(_tblAccountEO);
                    if (lblFK_sNguoiGui != null)
                    {
                        if (_tblAccountEO.PK_sUsername != null)
                        {
                            lblFK_sNguoiGui.Text = _tblAccountEO.sName;
                            if (_tblAccountEO.iType == tblAccount_iType_C.Giang_Vien)
                            {
                                lblFK_sNguoiGui.Font.Underline = true;
                                lblFK_sNguoiGui.ForeColor = System.Drawing.Color.Blue;
                            }
                        }
                        else
                        {
                            if (_tblAccountEO.PK_sUsername != null)
                            {
                                lblFK_sNguoiGui.Text = _tblAccountEO.sName;
                            }
                            else
                            {
                                lblFK_sNguoiGui.Text = Messages.Chat_An_Danh;
                            }
                        }
                    }

                    if (lblsNoidung != null && objtblMessageEO.FK_sUsername == hfFK_sNguoiGui.Value)
                    {
                        lblsNoidung.ForeColor = System.Drawing.ColorTranslator.FromHtml(sColor);
                    }
                    if (lblFK_sNguoiGui != null && objtblMessageEO.FK_sUsername == hfFK_sNguoiGui.Value)
                    {
                        if (_tblAccountEO.iType == tblAccount_iType_C.Giang_Vien)
                        {
                            lblFK_sNguoiGui.ForeColor = System.Drawing.Color.Blue;
                            lblFK_sNguoiGui.ToolTip = Messages.ChatRoom_GiangVien;
                        }
                        else
                        {
                            lblFK_sNguoiGui.ForeColor = System.Drawing.Color.LightSkyBlue;
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