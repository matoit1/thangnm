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
    public partial class QLTaiKhoan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadDL();
        }

        protected void LoadDL()
        {
            grvDanhsachTaikhoan.DataSource = TaikhoanDAO.Search("");
            grvDanhsachTaikhoan.DataBind();
        }

        protected void btnThem_Click(object sender, EventArgs e)
        {
            if (TaikhoanDAO.Insert(txttaikhoan_tentaikhoan.Text,txttaikhoan_matkhau.Text,txttaikhoan_Email.Text,txttaikhoan_tendaydu.Text, txttaikhoan_diachi.Text,Convert.ToDateTime(txttaikhoan_ngaysinh.Text),txttaikhoan_sodienthoai.Text,Convert.ToInt32(txttaikhoan_quyenhan.Text), txttaikhoan_annhdaidien.Text,Convert.ToBoolean(txttaikhoan_trangthai.Text)) == true) 
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
            Int64 id;
            if (txttaikhoan_ID.Text == "")
            {
                id = 0;
            }
            else
            {
                id = Convert.ToInt64(txttaikhoan_ID.Text);
            }
            if (TaikhoanDAO.Update(id, txttaikhoan_tentaikhoan.Text, txttaikhoan_matkhau.Text, txttaikhoan_Email.Text, txttaikhoan_tendaydu.Text, txttaikhoan_diachi.Text, Convert.ToDateTime(txttaikhoan_ngaysinh.Text), txttaikhoan_sodienthoai.Text, Convert.ToInt32(txttaikhoan_quyenhan.Text), txttaikhoan_annhdaidien.Text, Convert.ToBoolean(txttaikhoan_trangthai.Text)) == true)
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
            txttaikhoan_ID.Text = "";
            txttaikhoan_tentaikhoan.Text = "";
            txttaikhoan_matkhau.Text = "";
            txttaikhoan_Email.Text = "";
            txttaikhoan_tendaydu.Text = "";
            txttaikhoan_diachi.Text = "";
            txttaikhoan_ngaysinh.Text = "";
            txttaikhoan_sodienthoai.Text = "";
            txttaikhoan_quyenhan.Text = "";
            txttaikhoan_annhdaidien.Text = "";
            txttaikhoan_trangthai.Text = "";
            txttaikhoan_ngaydangky.Text = "";
        }

        protected void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (TaikhoanDAO.Delete(Convert.ToInt64(txttaikhoan_ID.Text)))
                {
                    lblMsg.Text = "Xóa thành công!!!";
                }
                else
                {
                    lblMsg.Text = "Xóa bị lỗi!!!";
                }
            }
            catch { }
        }

        protected void btnTimkiem_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = TaikhoanDAO.Search(txttaikhoan_tentaikhoan.Text);
                grvDanhsachTaikhoan.DataSource = ds;
                grvDanhsachTaikhoan.DataBind();
            }
            catch (Exception ex) { lblMsg.Text = ex.Message; }
        }
    }
}