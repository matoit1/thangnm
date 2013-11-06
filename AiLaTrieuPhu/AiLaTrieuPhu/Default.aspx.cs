using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace AiLaTrieuPhu
{
    public partial class _Default : System.Web.UI.Page
    {
        public static int counter;
        protected void Page_Load(object sender, EventArgs e)
        {
            //PostBackTrigger trigger = new PostBackTrigger();
            //trigger.ControlID = btnCountDown.UniqueID;
            //UpdatePanelMain.Triggers.Add(trigger);
        }

        protected void timerCountDown_Tick(object sender, EventArgs e)
        {
            counter = Convert.ToInt32(btnCountDown.Text);
            btnCountDown.Text = (counter - 1).ToString();
            if (counter == 0)
            {
                btnCountDown.Text = "Timeout !!!";
                btnCountDown.BackColor = Color.Red;
                Response.Write("<script>alert('Hết thời gian trả lời câu hỏi.')</script>");
            }
        }
    }
}