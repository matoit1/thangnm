using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Tech : System.Web.UI.Page {

    //TODO: Update page to use security, etc and pull from database instead of cache.

    protected void Page_Load(object sender, EventArgs e) {
        if (!Page.IsPostBack) {
            chkTech.Checked = SessionStateSink.IsTechnician;
            bind();
        }
    }
    protected void chkTech_CheckedChanged(object sender, EventArgs e) {
        SessionStateSink.IsTechnician = chkTech.Checked;
        bind();
    }

    private void bind() {
        if (SessionStateSink.IsTechnician) {
            gvMain.DataSource = DAC.GetAllConverstations();
            gvMain.DataBind();
        } else {
            gvMain.DataSource = null;
            gvMain.DataBind();
        }
    }
}