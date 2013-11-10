using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

namespace nguyenmanhthang.UserControl
{
    public partial class ContactUC : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtFullName.Focus();
            loadDropDownList();
        }

        protected void btnSent_Click(object sender, EventArgs e)
        {
        }
        public void loadDropDownList()
        {
            SortedList slLoadDropDownList = new SortedList();
            int Key;
            string Value;
            try
            {
                Key = 0;
                Value = "Liên hệ";
                slLoadDropDownList.Add(Key, Value);
                Key = 1;
                Value = "Góp ý - Báo lỗi";
                slLoadDropDownList.Add(Key, Value);
                Key = 2;
                Value = "Hợp tác quảng cáo";
                slLoadDropDownList.Add(Key, Value);
                Key = 3;
                Value = "Khác ...";
                slLoadDropDownList.Add(Key, Value);
                ddlType.DataSource = slLoadDropDownList;
                ddlType.DataTextField = "Value";
                ddlType.DataValueField = "Key";
                ddlType.DataBind();
            }
            catch
            {
                lblMsg.Text = "Không Load được các Thể loại";
                lblMsg.CssClass = "alert_error";
            }
        }
    }
}