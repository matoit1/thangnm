using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityObject;

namespace tydyShop.UserControl
{
    public partial class AdvancedSearchUC : System.Web.UI.UserControl
    {
        #region "Properties & Event"
        public event EventHandler Search;
        public event EventHandler Cancel;

        private ProductEO _ProductEO;
        public ProductEO objProductEO
        {
            get { return this._ProductEO; }
            set { _ProductEO = value; }
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
            objProductEO.PK_lProductID = Convert.ToInt64(txtPK_lProductID.Text);
            objProductEO.sName = txtsName.Text;
            objProductEO.lPrice = Convert.ToInt64(txtlPrice1.Text);
            objProductEO.sDescription = txtsDescription.Text;
            objProductEO.sInfomation = txtsInfomation.Text;
            objProductEO.sOrigin = txtsOrigin.Text;
        }

        public void clearObject()
        {
            objProductEO = null;
            txtPK_lProductID.Text ="";
            txtsName.Text ="";
            txtlPrice1.Text ="";
            txtsDescription.Text ="";
            txtsInfomation.Text ="";
            txtsOrigin.Text ="";
        }
    }
}