using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using nguyenmanhthang.Library.Common;

namespace nguyenmanhthang
{
    public partial class FAQ : System.Web.UI.Page
    {
        #region "Hằng số Khai Báo Biến, Thuộc tính, Sự kiện"
            protected const string Page_ID = "FAQ_"; //Mã Page
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            
            
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (SecurityFunction.CheckPermission("admin", Page_ID + btnAdd.ID) == true)
            {
                lblMsg.Text = Alert.Grant;
                lblMsg.CssClass = "notificationSuccessful";
            }
            else
            {
                lblMsg.Text = Alert.Deny;
                lblMsg.CssClass = "notificationError";
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            if (SecurityFunction.CheckPermission("admin", Page_ID + btnDelete.ID) == true)
            {
                lblMsg.Text = Alert.Grant;
                lblMsg.CssClass = "notificationSuccessful";
            }
            else
            {
                lblMsg.Text = Alert.Deny;
                lblMsg.CssClass = "notificationError";
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (SecurityFunction.CheckPermission("admin", Page_ID + btnUpdate.ID) == true)
            {
                lblMsg.Text = Alert.Grant;
                lblMsg.CssClass = "notificationSuccessful";
            }
            else
            {
                lblMsg.Text = Alert.Deny;
                lblMsg.CssClass = "notificationError";
            }
        }

        protected void btnView_Click(object sender, EventArgs e)
        {
            if (SecurityFunction.CheckPermission("admin", Page_ID + btnView.ID) == true)
            {
                lblMsg.Text = Alert.Grant;
                lblMsg.CssClass = "notificationSuccessful";
            }
            else
            {
                lblMsg.Text = Alert.Deny;
                lblMsg.CssClass = "notificationError";
            }
        }
    }
}