﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DO_AN_TN.QuanTri
{
    public partial class MonHoc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        #region "Raise Event"
        protected void ViewDetail_Click(object sender, EventArgs e)
        {
            mtvMain.ActiveViewIndex = 1;
        }
        #endregion

        protected void lbtnBack_Click(object sender, EventArgs e)
        {
            mtvMain.SetActiveView(vList);
        }
    }
}