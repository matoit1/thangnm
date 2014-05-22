using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HaBa.EntityObject;
using System.Collections;
using HaBa.SharedLibraries;

namespace HaBa.UserControl
{
    public partial class AdvancedSearchUC : System.Web.UI.UserControl
    {
        #region "Properties & Event"
        public event EventHandler Search;
        public event EventHandler Cancel;

        private tblSanPhamEO _tblSanPhamEO;
        public tblSanPhamEO objtblSanPhamEO
        {
            get { return this._tblSanPhamEO; }
            set { _tblSanPhamEO = value; }
        }
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SortedList output = new SortedList();
                output = GetListConstants.SanPham_iDoTuoi_GLC();
                output.Add(Convert.ToInt16(0), "Tất cả");
                ddliDoTuoi.DataSource = output;
                ddliDoTuoi.DataTextField = "Value";
                ddliDoTuoi.DataValueField = "Key";
                ddliDoTuoi.DataBind();

                output = GetListConstants.SanPham_iGioiTinh_GLC();
                output.Add(Convert.ToInt16(0), "Tất cả");
                ddliGioiTinh.DataSource = output;
                ddliGioiTinh.DataTextField = "Value";
                ddliGioiTinh.DataValueField = "Key";
                ddliGioiTinh.DataBind();
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            //string strValue = Page.Request.Form["txtlGiaBan"].ToString();
            if (Search != null)
            {
                getObject();
                Search(this, EventArgs.Empty);
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            if (Cancel != null)
            {
                Cancel(this, EventArgs.Empty);
            }
        }

        public void getObject()
        {
            tblSanPhamEO _tblSanPhamEO = new tblSanPhamEO();
            _tblSanPhamEO.PK_sSanPhamID = Convert.ToString(txtPK_sSanPhamID.Text).Trim();
            _tblSanPhamEO.sTenSanPham = txtsTenSanPham.Text.Trim();
            _tblSanPhamEO.sMoTa = txtsMoTa.Text.Trim();
            _tblSanPhamEO.sXuatXu = txtsXuatXu.Text.Trim();
            _tblSanPhamEO.lGiaBan = Convert.ToInt64(Page.Request.Form["txtlGiaBan"].ToString());
            _tblSanPhamEO.iDoTuoi = Convert.ToInt16(ddliDoTuoi.SelectedValue);
            _tblSanPhamEO.iGioiTinh = Convert.ToInt16(ddliGioiTinh.SelectedValue);
            objtblSanPhamEO = _tblSanPhamEO;
        }

        public void clearObject()
        {
            objtblSanPhamEO = null;
            txtPK_sSanPhamID.Text = "";
            txtsTenSanPham.Text = "";
            //txtlGiaBan.Text = "";
            txtsMoTa.Text = "";
            txtsXuatXu.Text = "";
        }
    }
}