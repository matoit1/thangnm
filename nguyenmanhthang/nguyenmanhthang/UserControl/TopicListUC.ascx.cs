using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BusinessObject;

namespace nguyenmanhthang.UserControl
{
    public partial class ListTopicUC : System.Web.UI.UserControl
    {
        #region "Khai Báo Biến, Thuộc tính, Sự kiện"
            public event EventHandler ViewTopic;
            public event EventHandler PageChangeTopic;
            public event EventHandler NewTopic;
            public event EventHandler DeleteTopic;
            public bool isBlock;
            private Int64 _Topic_ID;
            public Int64 Topic_ID
            {
                get { return this._Topic_ID; }
                set { _Topic_ID = value; }
            }

            private DataSet _dsTopic;
            public DataSet dsTopic
            {
                get { return this._dsTopic; }
                set { _dsTopic = value; }
            }
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindDataGrid(dsTopic);
            }
        }

        public void ReBindDataGrid()
        {
            BindDataGrid(dsTopic);
        }

        protected void BindDataGrid(DataSet ds)
        {
            try
            {
                grvListTopic.DataSource = ds;
                grvListTopic.DataBind();
                lblSo_BanGhi.Text = ds.Tables[0].Rows.Count.ToString();
            }
            catch { }
        }

        protected void grvListTopic_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grvListTopic.PageIndex = e.NewPageIndex;
            if (PageChangeTopic != null)
            {
                PageChangeTopic(this, EventArgs.Empty);
            }
            BindDataGrid(dsTopic);
        }

        protected void grvListTopic_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Int64 Topic_ID = (Int64)grvListTopic.DataKeys[e.Row.RowIndex].Values["Topic_ID"];
                //LinkButton URL1 = (LinkButton)e.Row.FindControl("hpView");
                //URL1.PostBackUrl = "~/Admin/Edit/OrdersDetails.aspx?Orders_ID=" + Topic_ID + "&ViewMode=true";
            }
        }

        protected void grvListTopic_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "cmdView")
            {
                this.Topic_ID = Convert.ToInt64(e.CommandArgument);
                if (ViewTopic != null)
                {
                    ViewTopic(this, EventArgs.Empty);
                }
            }
        }

        protected void ibtnDelete_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                String strID = "";
                foreach (GridViewRow row in grvListTopic.SelectedRows)
                {
                    strID += "," + grvListTopic.DataKeys[row.RowIndex].Values["Topic_ID"];

                }
                TopicBO.Topic_DeleteList(strID.Substring(1));
                if (DeleteTopic != null)
                {
                    DeleteTopic(this, EventArgs.Empty);
                }
                lblMessage.Text = "Xóa thành công";
                lblMessage.CssClass = "alert_success";
            }
            catch (Exception)
            {
                lblMessage.Text = "Xóa thất bại vui lòng kiểm tra lại";
                lblMessage.CssClass = "alert_error";
            }
        }

        protected void ibtnAdd_Click(object sender, ImageClickEventArgs e)
        {
            if (NewTopic != null)
            {
                NewTopic(this, EventArgs.Empty);
            }
        }
    }
}