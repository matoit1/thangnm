﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HaBa.EntityObject;
using HaBa.DataAccessObject;

namespace HaBa
{
    public partial class NhomSanPham : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    if (Request.QueryString["PK_iNhomSanPhamID"] != null)
                    {
                        tblSanPhamEO _tblSanPhamEO = new tblSanPhamEO();
                        _tblSanPhamEO.FK_iNhomSanPhamID = Convert.ToInt16(Request.QueryString["PK_iNhomSanPhamID"]);
                        _tblSanPhamEO.iTrangThai = 1;
                        Gallery3DUC1.BindData(tblSanPhamDAO.SanPham_SelectByFK_iNhomSanPhamID(_tblSanPhamEO));
                    }
                }
            }
            catch { }
        }
    }
}