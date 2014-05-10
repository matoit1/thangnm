using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Shared_Libraries;

namespace DO_AN_TN.Test
{
    public partial class Drop : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadQuyen_Han_GLC();
                loadHoc_Vi_GLC();
                loadGioi_Tinh_GLC();
                loadHon_Nhan_GLC();
                loadCong_Chuc_GLC();
                loadTrang_Thai_Giao_Vien_GLC();
                loadTrang_Thai_Sinh_Vien_GLC();
                loadDoan_Thanh_Nien_Cong_San_HCM_GLC();
                loadQuan_He_Voi_Nguoi_Lien_He_GLC();
                loadHe_So_Tinh_Diem_GLC();
                loadXep_Loai_Ket_Qua_Hoc_Tap_GLC();
                loadTinh_Diem_Chuyen_Can_GLC();
                loadChuc_Vu_GLC();
            }
        }

        public void loadQuyen_Han_GLC()
        {
            ddlSelectList1.DataSource = GetListConstants.Quyen_Han_GLC();
            ddlSelectList1.DataTextField = "Value";
            ddlSelectList1.DataValueField = "Key";
            ddlSelectList1.DataBind();
        }

        public void loadHoc_Vi_GLC()
        {
            ddlSelectList2.DataSource = GetListConstants.GiangVien_iHocViGV_GLC();
            ddlSelectList2.DataTextField = "Value";
            ddlSelectList2.DataValueField = "Key";
            ddlSelectList2.DataBind();
        }

        public void loadGioi_Tinh_GLC()
        {
            ddlSelectList3.DataSource = GetListConstants.Gioi_Tinh_GLC();
            ddlSelectList3.DataTextField = "Value";
            ddlSelectList3.DataValueField = "Key";
            ddlSelectList3.DataBind();
        }

        public void loadHon_Nhan_GLC()
        {
            ddlSelectList4.DataSource = GetListConstants.Hon_Nhan_GLC();
            ddlSelectList4.DataTextField = "Value";
            ddlSelectList4.DataValueField = "Key";
            ddlSelectList4.DataBind();
        }

        public void loadCong_Chuc_GLC()
        {
            ddlSelectList5.DataSource = GetListConstants.GiangVien_bCongChucGV_GLC();
            ddlSelectList5.DataTextField = "Value";
            ddlSelectList5.DataValueField = "Key";
            ddlSelectList5.DataBind();
        }

        public void loadTrang_Thai_Giao_Vien_GLC()
        {
            ddlSelectList6.DataSource = GetListConstants.GiangVien_iTrangThaiGV_GLC();
            ddlSelectList6.DataTextField = "Value";
            ddlSelectList6.DataValueField = "Key";
            ddlSelectList6.DataBind();
        }

        public void loadTrang_Thai_Sinh_Vien_GLC()
        {
            ddlSelectList7.DataSource = GetListConstants.SinhVien_iTrangThaiSV_GLC();
            ddlSelectList7.DataTextField = "Value";
            ddlSelectList7.DataValueField = "Key";
            ddlSelectList7.DataBind();
        }

        public void loadDoan_Thanh_Nien_Cong_San_HCM_GLC()
        {
            ddlSelectList8.DataSource = GetListConstants.SinhVien_bKetnapDoanSV_GLC();
            ddlSelectList8.DataTextField = "Value";
            ddlSelectList8.DataValueField = "Key";
            ddlSelectList8.DataBind();
        }

        public void loadQuan_He_Voi_Nguoi_Lien_He_GLC()
        {
            ddlSelectList9.DataSource = GetListConstants.SinhVien_iQuanHeVoiNguoiLienHeSV_GLC();
            ddlSelectList9.DataTextField = "Value";
            ddlSelectList9.DataValueField = "Key";
            ddlSelectList9.DataBind();
        }

        public void loadHe_So_Tinh_Diem_GLC()
        {
            ddlSelectList10.DataSource = GetListConstants.He_So_Tinh_Diem_GLC();
            ddlSelectList10.DataTextField = "Value";
            ddlSelectList10.DataValueField = "Key";
            ddlSelectList10.DataBind();
        }

        public void loadXep_Loai_Ket_Qua_Hoc_Tap_GLC()
        {
            ddlSelectList11.DataSource = GetListConstants.Xep_Loai_Ket_Qua_Hoc_Tap_GLC();
            ddlSelectList11.DataTextField = "Value";
            ddlSelectList11.DataValueField = "Key";
            ddlSelectList11.DataBind();
        }

        public void loadTinh_Diem_Chuyen_Can_GLC()
        {
            ddlSelectList12.DataSource = GetListConstants.Tinh_Diem_Chuyen_Can_GLC();
            ddlSelectList12.DataTextField = "Value";
            ddlSelectList12.DataValueField = "Key";
            ddlSelectList12.DataBind();
        }

        public void loadChuc_Vu_GLC()
        {
            ddlSelectList13.DataSource = GetListConstants.GiangVien_iChucVuGV_GLC();
            ddlSelectList13.DataTextField = "Value";
            ddlSelectList13.DataValueField = "Key";
            ddlSelectList13.DataBind();
        }

        protected void btnCheck_Click(object sender, EventArgs e)
        {
            lblMsg1.Text = ddlSelectList1.SelectedItem.Value.ToString() + " <=> " + ddlSelectList1.SelectedItem.Text.ToString();
            lblMsg2.Text = ddlSelectList2.SelectedItem.Value.ToString() + " <=> " + ddlSelectList2.SelectedItem.Text.ToString();
            lblMsg3.Text = ddlSelectList3.SelectedItem.Value.ToString() + " <=> " + ddlSelectList3.SelectedItem.Text.ToString();
            lblMsg4.Text = ddlSelectList4.SelectedItem.Value.ToString() + " <=> " + ddlSelectList4.SelectedItem.Text.ToString();
            lblMsg5.Text = ddlSelectList5.SelectedItem.Value.ToString() + " <=> " + ddlSelectList5.SelectedItem.Text.ToString();
            lblMsg6.Text = ddlSelectList6.SelectedItem.Value.ToString() + " <=> " + ddlSelectList6.SelectedItem.Text.ToString();
            lblMsg7.Text = ddlSelectList7.SelectedItem.Value.ToString() + " <=> " + ddlSelectList7.SelectedItem.Text.ToString();
            lblMsg8.Text = ddlSelectList8.SelectedItem.Value.ToString() + " <=> " + ddlSelectList8.SelectedItem.Text.ToString();
            lblMsg9.Text = ddlSelectList9.SelectedItem.Value.ToString() + " <=> " + ddlSelectList9.SelectedItem.Text.ToString();
            lblMsg10.Text = ddlSelectList10.SelectedItem.Value.ToString() + " <=> " + ddlSelectList10.SelectedItem.Text.ToString();
            lblMsg11.Text = ddlSelectList11.SelectedItem.Value.ToString() + " <=> " + ddlSelectList11.SelectedItem.Text.ToString();
            lblMsg12.Text = ddlSelectList12.SelectedItem.Value.ToString() + " <=> " + ddlSelectList12.SelectedItem.Text.ToString();
            lblMsg13.Text = ddlSelectList13.SelectedItem.Value.ToString() + " <=> " + ddlSelectList13.SelectedItem.Text.ToString();
        }

        protected void txtColor_TextChanged(object sender, EventArgs e)
        {
            lblColor.Text = txtColor.Text;
        }
    }
}