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
        public tblPartEO objtblPartEO
        {
            get { return (tblPartEO)ViewState["objtblPartEO"]; }
            set { ViewState["objtblPartEO"] = value; }
        }
        public Int16 iTypeUpload
        {
            get { return (Int16)ViewState["iTypeUpload"]; }
            set { ViewState["iTypeUpload"] = value; }
        }
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
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
            string pathsavefile = "App_Data/Upload/";
            switch (iTypeUpload)
            {
                case 1: pathsavefile = "App_Data/Upload/"; break;
                case 2: pathsavefile = "Upload/"; break;
            }

            string PathUpload = Server.MapPath("~/" + pathsavefile);
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
                    lblMsg.Text = "";
                    try
                    {
                        string link = "../" + pathsavefile + fuMaterial.PostedFile.FileName;
                        fuMaterial.PostedFile.SaveAs(PathUpload + fuMaterial.PostedFile.FileName);
                        switch (iTypeUpload)
                        {
                            case 1:
                            tblMaterialEO _tblMaterialEO = new tblMaterialEO();
                            _tblMaterialEO.FK_sSubject = objtblSubjectEO.PK_sSubject;
                            _tblMaterialEO.FK_sUsername = objtblSubjectEO.FK_sTeacher;
                            _tblMaterialEO.sDescription = txtsDescription.Text;
                            _tblMaterialEO.sLinkDownload = link;
                            _tblMaterialEO.iSize = fuMaterial.PostedFile.ContentLength;
                            _tblMaterialEO.iType = getTypeFile(fuMaterial.PostedFile.FileName);
                            _tblMaterialEO.iStatus = tblMaterial_iStatus_C.Mo;
                            tblMaterialDAO.Material_Insert(_tblMaterialEO);
                            break;

                            case 2:                    
                                tblPartEO _tblPartEO = new tblPartEO();
                                _tblPartEO.PK_iPart =objtblPartEO.PK_iPart;
                                _tblPartEO.FK_sSubject = objtblPartEO.FK_sSubject;
                                _tblPartEO.iStatus = tblPart_iStatus_C.Day_Offline;
                                _tblPartEO.sLinkVideo = link;
                                tblPartDAO.Part_Update_sLinkVideo_sBlackList(_tblPartEO);
                            break;
                        }
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