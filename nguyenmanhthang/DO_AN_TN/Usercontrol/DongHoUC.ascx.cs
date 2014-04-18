using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DO_AN_TN.UserControl
{
    public partial class DongHoUC : System.Web.UI.UserControl
    {
        #region "Properties & Event"
        public Int16 current
        {
            get { return (Int16)ViewState["current"]; }
            set { ViewState["current"] = value; }
        }
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                tClock.Interval = 1000;
                //btnClock.Text = DateTime.Now.ToShortTimeString().ToString();
            }
        }

        protected void tClock_Tick(object sender, EventArgs e)
        {
            btnClock.Text = DateTime.Now.ToLongTimeString().ToString();
            switch (DateTime.Now.Hour)
            {
                case 7:
                case 8:
                case 9:
                case 10:
                case 11: current = 1; break;
                case 13:
                case 14:
                case 15:
                case 16:
                case 17: current = 2; break;
                case 18:
                case 19:
                case 20:
                case 21:
                case 22: current = 3; break;
            }
            lblCaHoc.Text = current.ToString();
        }
    }
}