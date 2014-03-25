using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityObject;
using DataAccessObject;
using Shared_Libraries;

namespace DO_AN_TN.UserControl
{
    public partial class Error_DetailUC : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadDataToDropDownList();
            }
        }

        public void BindDataDetail(ErrorEO _ErrorEO)
        {
            txtPK_lErrorID.Text = Convert.ToString(_ErrorEO.PK_lErrorID);
            txtsLink.Text = Convert.ToString(_ErrorEO.sLink);
            txtsIP.Text = Convert.ToString(_ErrorEO.sIP);
            txtsBrowser.Text = Convert.ToString(_ErrorEO.sBrowser);
            txtiCodes.Text = Convert.ToString(_ErrorEO.iCodes);
            txttTime.Text = Convert.ToString(_ErrorEO.tTime);
            txttTimeCheck.Text = Convert.ToString(_ErrorEO.tTimeCheck);
            try { ddliStatus.SelectedValue = _ErrorEO.iStatus.ToString(); }
            catch { ddliStatus.SelectedIndex = 0; }
        }

        #region "Event Button"
        protected void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (ErrorDAO.Error_Insert(getObject()) == true)
                {
                    lblMsg.Text = Messages.Them_Thanh_Cong;
                }
                else
                {
                    lblMsg.Text = Messages.Them_That_Bai;
                }
            }
            catch (Exception ex)
            {
                lblMsg.Text = Messages.Loi + ex.Message;
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (ErrorDAO.Error_Update(getObject()) == true)
                {
                    lblMsg.Text = Messages.Sua_Thanh_Cong;
                }
                else
                {
                    lblMsg.Text = Messages.Sua_That_Bai;
                }
            }
            catch (Exception ex)
            {
                lblMsg.Text = Messages.Loi + ex.Message;
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (ErrorDAO.Error_Delete(getObject()) == true)
                {
                    lblMsg.Text = Messages.Xoa_Thanh_Cong;
                }
                else
                {
                    lblMsg.Text = Messages.Xoa_That_Bai;
                }
            }
            catch (Exception ex)
            {
                lblMsg.Text = Messages.Loi + ex.Message;
            }
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            ErrorEO _ErrorEO = new ErrorEO();
            BindDataDetail(_ErrorEO);
        }
        #endregion

        private ErrorEO getObject()
        {
            try
            {
                ErrorEO _ErrorEO = new ErrorEO();
                _ErrorEO.PK_lErrorID = Convert.ToInt64(txtPK_lErrorID.Text);
                _ErrorEO.sLink = txtsLink.Text;
                _ErrorEO.sIP = txtsIP.Text;
                _ErrorEO.sBrowser = txtsBrowser.Text;
                _ErrorEO.iCodes = Convert.ToInt16(txtiCodes.Text);
                _ErrorEO.tTime = Convert.ToDateTime(txttTime.Text);
                _ErrorEO.tTimeCheck = Convert.ToDateTime(txttTimeCheck.Text);
                _ErrorEO.iStatus = Convert.ToInt16(ddliStatus.SelectedValue);
                return _ErrorEO;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void loadDataToDropDownList()
        {
            ddliStatus.DataSource = GetListConstants.Error_iStatus_GLC();
            ddliStatus.DataTextField = "Value";
            ddliStatus.DataValueField = "Key";
            ddliStatus.DataBind();
        }
    }
}