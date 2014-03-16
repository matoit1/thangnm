using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessObject;
using Shared_Libraries;
using EntityObject;
using System.Data.SqlTypes;

namespace DO_AN_TN.UserControl
{
    public partial class CauHoi_DetailUC : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                CauHoiDAO.CauHoi_SelectList(getObject());
            }
            catch (Exception ex)
            {
                lblMsg.Text = Messages.Loi + ex.Message;
            }
        }

        protected void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                CauHoiDAO.CauHoi_SelectList(getObject());
            }
            catch (Exception ex)
            {
                lblMsg.Text = Messages.Loi + ex.Message;
            }
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (CauHoiDAO.CauHoi_Insert(getObject()) == true)
                {
                    lblMsg.Text = Messages.Them_Thanh_Cong;
                }
                else
                {
                    lblMsg.Text = Messages.Them_That_Bai;
                }
            }
            catch (Exception ex)
            {
                lblMsg.Text = Messages.Loi + ex.Message;
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (CauHoiDAO.CauHoi_Update(getObject()) == true)
                {
                    lblMsg.Text = Messages.Sua_Thanh_Cong;
                }
                else
                {
                    lblMsg.Text = Messages.Sua_That_Bai;
                }
            }
            catch (Exception ex)
            {
                lblMsg.Text = Messages.Loi + ex.Message;
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (CauHoiDAO.CauHoi_Delete(getObject()) == true)
                {
                    lblMsg.Text = Messages.Xoa_Thanh_Cong;
                }
                else
                {
                    lblMsg.Text = Messages.Xoa_That_Bai;
                }
            }
            catch (Exception ex)
            {
                lblMsg.Text = Messages.Loi + ex.Message;
            }
        }

        protected void btnExport_Click(object sender, EventArgs e)
        {
            CauHoiDAO.CauHoi_SelectList(getObject());
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            ddlFK_sMaGV.SelectedIndex = 0;
            txtPK_iCauhoi_ID.Text = "";
            txtsCauhoi_Cauhoi.Text = "";
            txtsCauhoi_A.Text = "";
            txtsCauhoi_B.Text = "";
            txtsCauhoi_C.Text = "";
            txtsCauhoi_D.Text = "";
            ddliCauhoi_Dung.SelectedIndex = 0;
            ddlsBoCauHoi.SelectedIndex = 0;
            txttNgayTao.Text = "";
            txttNgayCapNhat.Text = "";
            ddliTrangThai.SelectedIndex = 0;
        }

        private CauHoiEO getObject()
        {
            try
            {
                CauHoiEO _CauHoiEO = new CauHoiEO();
                _CauHoiEO.FK_sMaGV = ddlFK_sMaGV.SelectedValue;
                try{_CauHoiEO.PK_iCauhoi_ID = Convert.ToInt16(txtPK_iCauhoi_ID.Text);}
                catch{lblPK_iCauhoi_ID.Text = Messages.Khong_Dung_Dinh_Dang_So;_CauHoiEO.PK_iCauhoi_ID = 0;}
                _CauHoiEO.sCauhoi_Cauhoi = txtsCauhoi_Cauhoi.Text;
                _CauHoiEO.sCauhoi_A = txtsCauhoi_A.Text;
                _CauHoiEO.sCauhoi_B = txtsCauhoi_B.Text;
                _CauHoiEO.sCauhoi_C = txtsCauhoi_C.Text;
                _CauHoiEO.sCauhoi_D = txtsCauhoi_D.Text;
                _CauHoiEO.iCauhoi_Dung = Convert.ToInt16(ddliCauhoi_Dung.SelectedValue);
                _CauHoiEO.sBoCauHoi = ddlsBoCauHoi.SelectedValue;
                try{_CauHoiEO.tNgayTao = Convert.ToDateTime(txttNgayTao.Text);}
                catch{lbltNgayTao.Text = Messages.Khong_Dung_Dinh_Dang_Ngay;}
                try{_CauHoiEO.tNgayCapNhat = Convert.ToDateTime(txttNgayCapNhat.Text);}
                catch{lbltNgayCapNhat.Text = Messages.Khong_Dung_Dinh_Dang_Ngay;}
                _CauHoiEO.iTrangThai = Convert.ToInt16(ddliTrangThai.SelectedValue);
                return _CauHoiEO;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}