﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityObject;
using DataAccessObject;

namespace DO_AN_TN.GiangVien
{
    public partial class ThongTinCaNhan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                GiangVien_DetailUC1.btnDelete.Visible = false;
                GiangVien_DetailUC1.btnInsert.Visible = false;
                GiangVien_DetailUC1.btnReset.Visible = false;
                GiangVienEO _GiangVienEO = new GiangVienEO();
                _GiangVienEO.sTendangnhapGV = Request.Cookies["giangvien"].Value;
                _GiangVienEO = GiangVienDAO.GiangVien_SelectBysTendangnhapGV(_GiangVienEO);
                GiangVien_DetailUC1.BindDataDetail(_GiangVienEO);
            }
            catch
            {
            }
        }
    }
}