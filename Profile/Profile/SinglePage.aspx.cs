using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System;
using System.Collections.Generic;
using System.Web.UI.HtmlControls;

namespace Profile
{
    public partial class SinglePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    Page.Title = "Title of page";
                    HtmlMeta metatag = new HtmlMeta();
                    metatag.Name = "description";
                    metatag.Content = "description of page";
                    Header.Controls.Add(metatag);

                    metatag = new HtmlMeta();
                    metatag.Name = "keywords";
                    metatag.Content = "keywords of page";
                    Header.Controls.Add(metatag);
                }
            }
            catch { }
        }
    }
}