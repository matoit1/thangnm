﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AiLaTrieuPhu.Library;
using System.Data;

namespace AiLaTrieuPhu.Admin
{
    public partial class QLCauHoi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadDL();
        }

        protected void LoadDL()
        {
            grvDanhsachCauhoi.DataSource = CauhoiDAO.DanhsachCauhoi(1);
            grvDanhsachCauhoi.DataBind();
        }

        protected void btnThem_Click(object sender, EventArgs e)
        {
            if (CauhoiDAO.Insert(txtCauhoi_cauhoi.Text, txtCauhoi_A.Text, txtCauhoi_B.Text, txtCauhoi_C.Text, txtCauhoi_D.Text, Convert.ToInt32(txtCauhoi_dung.Text), Convert.ToInt32(txtCauhoi_capdo.Text)) == true)
            {
                lblMsg.Text = "Thêm thành công!!!";
            }
            else
            {
                lblMsg.Text = "Thêm bị lỗi!!!";
            }
        }

        protected void btnSua_Click(object sender, EventArgs e)
        {
            if (CauhoiDAO.Update(Convert.ToInt64(txtCauhoi_ID.Text), txtCauhoi_cauhoi.Text, txtCauhoi_A.Text, txtCauhoi_B.Text, txtCauhoi_C.Text, txtCauhoi_D.Text, Convert.ToInt32(txtCauhoi_dung.Text), Convert.ToInt32(txtCauhoi_capdo.Text)) == true)
            {
                lblMsg.Text = "Cập nhật thành công!!!";
            }
            else
            {
                lblMsg.Text = "Cập nhật bị lỗi!!!";
            }
        }

        protected void btnXoatrang_Click(object sender, EventArgs e)
        {
            txtCauhoi_ID.Text = "";
            txtCauhoi_cauhoi.Text = "";
            txtCauhoi_A.Text = "";
            txtCauhoi_B.Text = "";
            txtCauhoi_C.Text = "";
            txtCauhoi_D.Text = "";
            txtCauhoi_dung.Text = "";
            txtCauhoi_capdo.Text = "";
        }

        protected void btnXoa_Click(object sender, EventArgs e)
        {
            if (CauhoiDAO.Delete(Convert.ToInt64(txtCauhoi_ID.Text)))
            {
                lblMsg.Text = "Xóa thành công!!!";
            }
            else
            {
                lblMsg.Text = "Xóa bị lỗi!!!";
            }
        }

        protected void btnTimkiem_Click(object sender, EventArgs e)
        {
            Int64 id;
            if (txtCauhoi_ID.Text == "")
            {
                id = 0;
            }
            else
            {
                id= Convert.ToInt64(txtCauhoi_ID.Text);
            }
            try
            {
                DataSet ds = CauhoiDAO.Search(id, txtCauhoi_cauhoi.Text);
                grvDanhsachCauhoi.DataSource = ds;
                grvDanhsachCauhoi.DataBind();
            }
            catch (Exception ex) { lblMsg.Text = ex.Message; }
        }
    }
}