﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityObject;
using DataAccessObject;

namespace DO_AN_TN.Test
{
    public partial class TLopHoc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public override void VerifyRenderingInServerForm(Control control)
        {
            //base.VerifyRenderingInServerForm(control);
        }

        #region "Raise Event"
        protected void SelectRow_Click(object sender, EventArgs e)
        {
            //MonHoc_DetailUC1.BindDataDetail(MonHoc_ListUC1.PK_sMaMonhoc);
        }

        protected void ViewDetail_Click(object sender, EventArgs e)
        {
            mtvMain.SetActiveView(vDetail);
            LopHocEO _LopHocEO = new LopHocEO();
            _LopHocEO.PK_sMalop = LopHoc_ListUC1.PK_sMalop;
            _LopHocEO = LopHocDAO.LopHoc_SelectItem(_LopHocEO);
            LopHoc_DetailUC1.BindDataDetail(_LopHocEO);
        }

        protected void AddNew_Click(object sender, EventArgs e)
        {
            mtvMain.SetActiveView(vDetail);
            LopHocEO _LopHocEO = new LopHocEO();
            LopHoc_DetailUC1.BindDataDetail(_LopHocEO);
        }
        #endregion

        protected void lbtnBack_Click(object sender, EventArgs e)
        {
            mtvMain.SetActiveView(vList);
            LopHoc_ListUC1.BindData();
        }
    }
}