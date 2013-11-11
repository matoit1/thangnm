

using System;
namespace nguyenmanhthang.Library.Permit_Access
{
    public partial class MyProfile : WebPageBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            bool result=SecurityServices.HasPermission(StringConstant.MyProfile, Session.GetCurrentUser().UserID, TypeAudit.AddNew);
            if (result == false)
            {
                msgError.Text = "Ban khong co quyen thuc hien chuc nang nay";
            }
            else
            {
                //Thuc hien hanh dong AddNew
            }
        }
        protected void btnEdit_Click(object sender, EventArgs e)
        {
            bool result = SecurityServices.HasPermission(StringConstant.MyProfile, Session.GetCurrentUser().UserID, TypeAudit.Edit);
            if (result == false)
            {
                msgError.Text = "Ban khong co quyen thuc hien chuc nang nay";
            }
            else
            {
                //Thuc hien hanh dong Edit
                SetPermissionForUser();
            }
        }
        protected void SetPermissionForUser()
        {
            SecurityServices.SetPermission(Session.GetCurrentUser().UserID, StringConstant.ChangePass, (int)(ItemFunction.AddNew | ItemFunction.Delete | ItemFunction.Edit | ItemFunction.View));
        }
    }
}