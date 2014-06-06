using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using EntityObject;
using DataAccessObject;
using Shared_Libraries.Constants;
using System.IO;

namespace EHOU
{
    /// <summary>
    /// Summary description for DownloadFile
    /// </summary>
    public class DownloadFile : IHttpHandler, IReadOnlySessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            //if (context.User.Identity.IsAuthenticated)
            //{
            try{
                Int64 PK_lMaterial = Convert.ToInt64(context.Request.QueryString["PK_lMaterial"]);
                tblMaterialEO _tblMaterialEO= new tblMaterialEO();
                _tblMaterialEO.PK_lMaterial = PK_lMaterial;
                _tblMaterialEO = tblMaterialDAO.Material_SelectItem(_tblMaterialEO);
                if (_tblMaterialEO.iStatus == tblMaterial_iStatus_C.Mo)
                {
                    string filename =Path.GetFileName(_tblMaterialEO.sLinkDownload);
                    System.IO.FileInfo file = new System.IO.FileInfo(context.Server.MapPath("~/App_Data/Upload/" + filename));
                    if (file.Exists)
                    {
                        context.Response.Buffer = true;
                        context.Response.Clear();
                        context.Response.AddHeader("content-disposition", "attachment; filename=" + filename);
                        context.Response.ContentType = "application/octet-stream";
                        context.Response.WriteFile("~/App_Data/Upload/" + filename);
                    }
                    else
                    {
                        context.Response.Write("Không tìm thấy file !");
                    }
                }
            }
            catch{
            }
            //}
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}