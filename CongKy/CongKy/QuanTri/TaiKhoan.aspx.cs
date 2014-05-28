using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CongKy.EntityObject;
using CongKy.DataAccessObject;

namespace CongKy.QuanTri
{
    public partial class TaiKhoan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Request.QueryString["iQuyenHan"] != null)
                {
                    tblTaiKhoan_ListUC1.iQuyenHan = Convert.ToInt16(Request.QueryString["iQuyenHan"]);
                }
            }
            catch
            {
            }
        }

        #region "Raise Event"
        protected void ViewDetail_Click(object sender, EventArgs e)
        {
            mtvMain.SetActiveView(vDetail);
            tblTaiKhoan_DetailUC1.btnInsert.Visible = false;
            tblTaiKhoan_DetailUC1.btnUpdate.Visible = true;
            tblTaiKhoan_DetailUC1.btnDelete.Visible = true;
            tblTaiKhoanEO _tblTaiKhoanEO = new tblTaiKhoanEO();
            _tblTaiKhoanEO.PK_iTaiKhoanID = tblTaiKhoan_ListUC1.PK_iTaiKhoanID;
            _tblTaiKhoanEO = tblTaiKhoanDAO.TaiKhoan_SelectItem(_tblTaiKhoanEO);
            tblTaiKhoan_DetailUC1.BindDataDetail(_tblTaiKhoanEO);
        }

        protected void AddNew_Click(object sender, EventArgs e)
        {
            mtvMain.SetActiveView(vDetail);
            tblTaiKhoan_DetailUC1.btnInsert.Visible = true;
            tblTaiKhoan_DetailUC1.btnUpdate.Visible = false;
            tblTaiKhoan_DetailUC1.btnDelete.Visible = false;
            tblTaiKhoanEO _tblTaiKhoanEO = new tblTaiKhoanEO();
            tblTaiKhoan_DetailUC1.BindDataDetail(_tblTaiKhoanEO);
        }
        #endregion

        protected void lbtnBack_Click(object sender, EventArgs e)
        {
            tblTaiKhoan_DetailUC1.ClearMessages();
            tblTaiKhoan_DetailUC1.lblMsg.Text = "";
            mtvMain.SetActiveView(vList);
            tblTaiKhoan_ListUC1.BindData();
        }
    }
}