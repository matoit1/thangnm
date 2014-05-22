using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HaBa.EntityObject;
using HaBa.DataAccessObject;
using System.Data;

namespace HaBa.Client
{
    public partial class HoaDon : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Request.QueryString["iTrangThai"] != null)
                {
                    tblHoaDon_ListUC1.iTrangThai = Convert.ToInt16(Request.QueryString["iTrangThai"]);
                    tblTaiKhoanEO _tblTaiKhoanEO = new tblTaiKhoanEO();
                    _tblTaiKhoanEO.sTenDangNhap = Request.Cookies["HaBa_client"].Value;
                    tblHoaDon_ListUC1.FK_iTaiKhoanID_Nhan = (tblTaiKhoanDAO.TaiKhoan_SelectItemBysTenDangNhap(_tblTaiKhoanEO)).PK_iTaiKhoanID;

                    
                }
            }
            catch
            {
            }
        }

        public override void VerifyRenderingInServerForm(Control control)
        {
            //base.VerifyRenderingInServerForm(control);
        }

        #region "Raise Event"
        protected void SelectRow_Click(object sender, EventArgs e)
        {
            //MonHoc_DetailUC1.BindDataDetail(MonHoc_ListUC1.PK_sMaMonhoc);
        }

        protected void ViewDetail_Click(object sender, EventArgs e)
        {
            mtvMain.SetActiveView(vDetail);
            tblHoaDonEO _tblHoaDonEO = new tblHoaDonEO();
            tblChiTietHoaDonEO _tblChiTietHoaDonEO = new tblChiTietHoaDonEO();
            _tblHoaDonEO.PK_lHoaDonID = tblHoaDon_ListUC1.PK_lHoaDonID;
            _tblChiTietHoaDonEO.FK_lHoaDonID = tblHoaDon_ListUC1.PK_lHoaDonID;
            _tblHoaDonEO = tblHoaDonDAO.HoaDon_SelectItem(_tblHoaDonEO);
            tblHoaDon_PrintUC1.objtblHoaDonEO = _tblHoaDonEO;
            DataSet dsChiTietHoaDon = tblChiTietHoaDonDAO.ChiTietHoaDon_SelectListByFK_lHoaDonID(_tblChiTietHoaDonEO);
            tblHoaDon_PrintUC1.BindData(_tblHoaDonEO, dsChiTietHoaDon);
        }

        protected void SelectRowChiTietHoaDon_Click(object sender, EventArgs e)
        {
            //MonHoc_DetailUC1.BindDataDetail(MonHoc_ListUC1.PK_sMaMonhoc);
        }
        #endregion

        protected void lbtnBack_Click(object sender, EventArgs e)
        {
            mtvMain.SetActiveView(vList);
            tblHoaDon_ListUC1.BindData();
        }
    }
}