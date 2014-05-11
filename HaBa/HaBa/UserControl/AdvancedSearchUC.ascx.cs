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
            objtblSanPhamEO.PK_lProductID = Convert.ToInt64(txtPK_lProductID.Text);
            objtblSanPhamEO.sName = txtsName.Text;
            objtblSanPhamEO.lPrice = Convert.ToInt64(txtlPrice1.Text);
            objtblSanPhamEO.sDescription = txtsDescription.Text;
            objtblSanPhamEO.sInfomation = txtsInfomation.Text;
            objtblSanPhamEO.sOrigin = txtsOrigin.Text;
        }

        public void clearObject()
        {
            objtblSanPhamEO = null;
            txtPK_lProductID.Text ="";
            txtsName.Text ="";
            txtlPrice1.Text ="";
            txtsDescription.Text ="";
            txtsInfomation.Text ="";
            txtsOrigin.Text ="";
        }
    }
}