using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AiLaTrieuPhu
{
    public partial class CountDown : System.Web.UI.Page
    {
        public static int counter;
        protected void Page_Load(object sender, EventArgs e)
        {
            int counter = 10;
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            int counter = Convert.ToInt32(Label1.Text);
            //Label1.Text = counter.ToString();
            Label1.Text = (counter - 1).ToString();
            if(counter==0){
                Response.Write("<script>alert('Hết thời gian trả lời câu hỏi.')</script>");
            }
        }
    }
}