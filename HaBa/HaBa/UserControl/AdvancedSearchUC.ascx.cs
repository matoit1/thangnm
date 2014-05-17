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
            string strValue = Page.Request.Form["txtlGiaBan"].ToString();
            lblMsg.Text = strValue; 
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
            objtblSanPhamEO.PK_sSanPhamID = Convert.ToString(txtPK_sSanPhamID.Text);
            objtblSanPhamEO.sTenSanPham = txtsTenSanPham.Text;
            objtblSanPhamEO.lGiaBan = Convert.ToInt64(Page.Request.Form["txtlGiaBan"].ToString());
            objtblSanPhamEO.sMoTa = txtsMoTa.Text;
            objtblSanPhamEO.sXuatXu = txtsXuatXu.Text;
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