using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AiLaTrieuPhu.Library;
using System.Data;

namespace AiLaTrieuPhu.Admin
{
    public partial class QLDiem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadDL();
        }

        protected void LoadDL()
        {
            grvDanhsachDiem.DataSource = DiemDAO.Search(0);
            grvDanhsachDiem.DataBind();
        }

        protected void btnThem_Click(object sender, EventArgs e)
        {
            if (DiemDAO.Insert(Convert.ToInt32(txtDiem_User.Text), Convert.ToInt64(txtDiem_tien.Text)) == true)
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
            if (DiemDAO.Update(Convert.ToInt64(txtDiem_ID.Text), Convert.ToInt32(txtDiem_User.Text), Convert.ToInt64(txtDiem_tien.Text)) == true)
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
            txtDiem_ID.Text = "";
            txtDiem_User.Text = "";
            txtDiem_tien.Text = "";
            txtDiem_ngay.Text = "";
        }

        protected void btnXoa_Click(object sender, EventArgs e)
        {
            if (DiemDAO.Delete(Convert.ToInt64(txtDiem_ID.Text)))
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
            try
            {
                DataSet ds = DiemDAO.Search(Convert.ToInt32(txtDiem_User.Text));
                grvDanhsachDiem.DataSource = ds;
                grvDanhsachDiem.DataBind();
            }
            catch (Exception ex) { lblMsg.Text = ex.Message; }
        }
    }
}