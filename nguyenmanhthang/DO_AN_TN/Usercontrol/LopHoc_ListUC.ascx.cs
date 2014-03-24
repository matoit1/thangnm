using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Shared_Libraries;
using DataAccessObject;

namespace DO_AN_TN.UserControl
{
    public partial class LopHoc_ListUC : System.Web.UI.UserControl
    {
#region "Properties & Event"
        public event EventHandler ViewDetail;
        public event EventHandler SelectRow;
        public event EventHandler AddNew;
        public event EventHandler Search;

        private string _PK_sMaMonhoc;
        public string PK_sMaMonhoc
        {
            get { return this._PK_sMaMonhoc; }
            set { _PK_sMaMonhoc = value; }
        }
#endregion

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void BindData()
        {
            grvListLopHoc.Visible = false;
            DataSet dsLopHoc = new DataSet();
            try
            {
                dsLopHoc = LopHocDAO.LopHoc_SelectList();
                if (Convert.ToInt32(dsLopHoc.Tables[0].Rows.Count.ToString()) > 0)
                {
                    grvListLopHoc.Visible = true;
                    grvListLopHoc.DataSource = dsLopHoc;
                    grvListLopHoc.DataBind();
                    lblTongSoBanGhi.Text = Messages.Tong_So_Ban_Ghi + dsLopHoc.Tables[0].Rows.Count.ToString();
                }
                else
                {
                    lblTongSoBanGhi.Text = Messages.Khong_Thoa_Man_Dieu_Kien_Tim_Kiem;
                }
            }
            catch (Exception ex)
            {
                lblTongSoBanGhi.Text = Messages.Loi + ex.Message;
            }
        }

        protected void grvListLopHoc_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

        }

        protected void grvListLopHoc_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }

        protected void grvListLopHoc_RowDataBound(object sender, GridViewRowEventArgs e)
        {

        }

        protected void grvListLopHoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void grvListLopHoc_Sorting(object sender, GridViewSortEventArgs e)
        {

        }
    }
}