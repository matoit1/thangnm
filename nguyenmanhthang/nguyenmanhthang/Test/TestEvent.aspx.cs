using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

namespace nguyenmanhthang.UserControl
{
    public partial class TestEvent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SortedList slloadDropDownList = new SortedList();
            string Key, Value;
            try
            {
                Key = "0";
                Value = "Articles";
                slloadDropDownList.Add(Key, Value);
                Value = "Tutorials";
                Key = "1";
                slloadDropDownList.Add(Key, Value);
                Value = "Freebies";
                Key = "2";
                slloadDropDownList.Add(Key, Value);
            calMa_LH.DataSource = slloadDropDownList;
            calMa_LH.DataValueField = "Key";
            calMa_LH.DataTextField = "Value";
            calMa_LH.DataBind();
            }
            catch
            {
            }
        }

        protected void MyEventUserControl_PageTitleUpdated(object sender, EventArgs e)
        {
            this.Title = EventUserControl1.PageTitle;
        }
    }
}