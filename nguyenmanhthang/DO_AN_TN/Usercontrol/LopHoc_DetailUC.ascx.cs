using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Shared_Libraries;
using EntityObject;

namespace DO_AN_TN.UserControl
{
    public partial class LopHoc_DetailUC : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadDataToDropDownList();
            }
        }

        public void loadDataToDropDownList()
        {
            ddliTrangThai.DataSource = GetListConstants.LopHoc_iTrangThai_GLC();
            ddliTrangThai.DataTextField = "Value";
            ddliTrangThai.DataValueField = "Key";
            ddliTrangThai.DataBind();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {

        }

        protected void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {

        }

        protected void btnExport_Click(object sender, EventArgs e)
        {

        }

        protected void btnReset_Click(object sender, EventArgs e)
        {

        }

        private LopHocEO getObject()
        {
            try
            {
                LopHocEO _LopHocEO = new LopHocEO();
                _LopHocEO.PK_sMalop = txtPK_sMalop.Text;
                _LopHocEO.sTenlop = txtsTenlop.Text;
                try{ _LopHocEO.iNamvaotruong = Convert.ToInt16(txtiNamvaotruong.Text);}
                catch{ lbliNamvaotruong.Text = Messages.Khong_Dung_Dinh_Dang_So;}
                try{ _LopHocEO.iSiso = Convert.ToInt16(txtiSiso.Text);}
                catch{ lbliSiso.Text = Messages.Khong_Dung_Dinh_Dang_So;}
                try{ _LopHocEO.iSoNamDaoTao = Convert.ToInt16(txtiSoNamDaoTao.Text);}
                catch{ lbliSoNamDaoTao.Text = Messages.Khong_Dung_Dinh_Dang_So;}
                _LopHocEO.iTrangThai = Convert.ToInt16(ddliTrangThai.SelectedValue);
                return _LopHocEO;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}