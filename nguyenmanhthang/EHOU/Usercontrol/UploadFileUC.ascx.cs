using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;
using System.Text;
using Shared_Libraries;
using System.IO;
using EntityObject;
using Shared_Libraries.Constants;
using DataAccessObject;

namespace EHOU.UserControl
{
    public partial class UploadFileUC : System.Web.UI.UserControl
    {
        #region "Properties & Event"
        public event EventHandler Refresh;
        public string linkfilevideo;
        public tblSubjectEO objtblSubjectEO
        {
            get { return (tblSubjectEO)ViewState["objtblSubjectEO"]; }
            set { ViewState["objtblSubjectEO"] = value; }
        }
        public string sTypeUpload
        {
            get { return (string)ViewState["sTypeUpload"]; }
            set { ViewState["sTypeUpload"] = value; }
        }
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            objtblSubjectEO = tblSubjectDAO.Subject_SelectItem_By_PK_sSubject("CRP2020");
        }

        public Int16 getTypeFile(string input){
            Int16 typefile=0;
            switch (Path.GetExtension(input.ToUpper()))
                {
                    case ".FLV": case ".MP4": case ".OGG": case ".WEBM": case ".F4V": case ".MKV": case ".AVI": case ".3G2": 
                    case ".MOV": case ".MPG": case ".WMV": typefile = tblMaterial_iType_C.Video; break;
                    case ".PDF": typefile = tblMaterial_iType_C.Pdf; break;
                    default: typefile = tblMaterial_iType_C.Other; break;
                }
            return typefile;
        }

        protected void UploadFile_Click(object sender, EventArgs e)
        {
            string PathUpload = Server.MapPath("~/App_Data/Upload/");
            if (String.IsNullOrEmpty(txtsDescription.Text))
            {
                lblMsg.Text = Messages.Field_Empty;
                txtsDescription.Focus();
            }
            else
            {
                if (String.IsNullOrEmpty(fuMaterial.PostedFile.FileName))
                {
                    lblMsg.Text = Messages.Field_Empty;
                    fuMaterial.Focus();
                }
                else
                {
                    tblMaterialEO _tblMaterialEO = new tblMaterialEO();
                    _tblMaterialEO.FK_sSubject = objtblSubjectEO.PK_sSubject;
                    _tblMaterialEO.FK_sUsername = objtblSubjectEO.FK_sTeacher;
                    _tblMaterialEO.sDescription = txtsDescription.Text;
                    _tblMaterialEO.sLinkDownload = "../App_Data/Upload/" + fuMaterial.PostedFile.FileName;
                    _tblMaterialEO.iSize = fuMaterial.PostedFile.ContentLength;
                    _tblMaterialEO.iType = getTypeFile(fuMaterial.PostedFile.FileName);
                    _tblMaterialEO.iStatus = tblMaterial_iStatus_C.Mo;
                    tblMaterialDAO.Material_Insert(_tblMaterialEO);
                    lblMsg.Text = "";
                    try
                    {
                        fuMaterial.PostedFile.SaveAs(PathUpload + fuMaterial.PostedFile.FileName);
                        lblMsg.Text = Messages.Tai_Len_Thanh_Cong;
                        if (Refresh != null)
                        {
                            Refresh(this, EventArgs.Empty);
                        }
                    }
                    catch (Exception Ex)
                    {
                        lblMsg.Text += Messages.Loi + Ex.Message;
                    }
                }
            }
        }
    }
}