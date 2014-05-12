using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNETChat
{
    public partial class Default : System.Web.UI.Page
    {
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserName"]!=null)
			{
				pnlLogin.Visible=false;
				pnlChat.Visible=true;
			}
			else
			{
				pnlLogin.Visible=true;
				pnlChat.Visible=false;
			}
    }

    	protected void btnLogin_Click(object sender, System.EventArgs e)
		{
			Session["UserName"]=txtUserName.Text;
			pnlLogin.Visible=false;
			pnlChat.Visible=true;
		}

		protected void btnChat_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("Chat.aspx?rid="+ lstRooms.SelectedValue );
		}
    }
}