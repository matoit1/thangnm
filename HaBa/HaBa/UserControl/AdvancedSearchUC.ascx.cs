using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HaBa.EntityObject;

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

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            if (Search != null)
            {
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
            objtblSanPhamEO.PK_lSanPhamID = Convert.ToInt64(txtPK_lSanPhamID.Text);
            objtblSanPhamEO.sTenSanPham = txtsTenSanPham.Text;
            objtblSanPhamEO.lGiaBan = Convert.ToInt64(txtlGiaBan.Text);
            objtblSanPhamEO.sMoTa = txtsMoTa.Text;
            objtblSanPhamEO.sXuatXu = txtsXuatXu.Text;
        }

        public void clearObject()
        {
            objtblSanPhamEO = null;
            txtPK_lSanPhamID.Text = "";
            txtsTenSanPham.Text = "";
            txtlGiaBan.Text = "";
            txtsMoTa.Text = "";
            txtsXuatXu.Text = "";
        }
    }
}