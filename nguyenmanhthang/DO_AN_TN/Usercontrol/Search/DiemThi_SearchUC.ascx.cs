using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityObject;

namespace DO_AN_TN.UserControl.Search
{
    public partial class DiemThi_SearchUC : System.Web.UI.UserControl
    {
        #region "Properties & Event"
        public event EventHandler Search;
        public event EventHandler Cancel;

        private SinhVienEO _SinhVienEO;
        public SinhVienEO objSinhVienEO
        {
            get { return this._SinhVienEO; }
            set { _SinhVienEO = value; }
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
            objSinhVienEO.FK_sMaLop = txtFK_sMaLop.Text;
            objSinhVienEO.PK_sMaSV = txtPK_sMaSV.Text;
            objSinhVienEO.sHotenSV = txtsHotenSV.Text;
            objSinhVienEO.sTendangnhapSV = txtsTendangnhapSV.Text;
        }

        public void clearObject()
        {
            objSinhVienEO = null;
            txtFK_sMaLop.Text = "";
            txtPK_sMaSV.Text = "";
            txtsHotenSV.Text = "";
            txtsTendangnhapSV.Text = "";
        }
    }
}