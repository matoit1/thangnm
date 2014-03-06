using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BusinessObject;
using System.Text;
using System.IO;
using System.Drawing;
using nguyenmanhthang.Library.Common;

namespace nguyenmanhthang.UserControl
{
    public partial class TopicListUC : System.Web.UI.UserControl
    {
        #region "Khai Báo Biến, Thuộc tính, Sự kiện"
            public event EventHandler ViewTopic;
            public event EventHandler PageChangeTopic;
            public event EventHandler NewTopic;
            public event EventHandler DeleteTopic;
            public event EventHandler ExportToExcelTopic;
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
                grvTopicList.DataSource = ds;
                grvTopicList.DataBind();
                lblTongSo_BanGhi.Text = Alert.TONG_SO_BAN_GHI + ds.Tables[0].Rows.Count.ToString();
            }
            catch { }
        }

        protected void grvTopicList_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grvTopicList.PageIndex = e.NewPageIndex;
            if (PageChangeTopic != null)
            {
                PageChangeTopic(this, EventArgs.Empty);
            }
            BindDataGrid(dsTopic);
        }

        protected void grvTopicList_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Int64 Topic_ID = (Int64)grvTopicList.DataKeys[e.Row.RowIndex].Values["Topic_ID"];
                //LinkButton URL1 = (LinkButton)e.Row.FindControl("hpView");
                //URL1.PostBackUrl = "~/Admin/Edit/OrdersDetails.aspx?Orders_ID=" + Topic_ID + "&ViewMode=true";
            }
        }

        protected void grvTopicList_RowCommand(object sender, GridViewCommandEventArgs e)
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
                foreach (GridViewRow row in grvTopicList.SelectedRows)
                {
                    strID += "," + grvTopicList.DataKeys[row.RowIndex].Values["Topic_ID"];

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

        protected void ibtnExportExcel_Click(object sender, ImageClickEventArgs e)
        {
            string FileName = "Danh_sach_Bai_viet(" + Convert.ToString(DateTime.Now.ToString("dd-MM-yyyy")) + ").xls";
            ExportToExcel(FileName);
        }

        public void ExportToExcel(string fileName)
        {
            if (ExportToExcelTopic != null)
            {
                ExportToExcelTopic(this, EventArgs.Empty);
            }
            Response.ContentType = "application/vnd.ms-excel";
            Response.Charset = "";
            Response.AddHeader("Content-Disposition", "attachment;filename=" + fileName);
            Response.ContentEncoding = Encoding.Unicode;
            Response.BinaryWrite(Encoding.Unicode.GetPreamble());
            DataTable dtb = dsTopic.Tables[0];
            try
            {
                StringBuilder sb = new StringBuilder();
                //Tạo dòng tiêu để cho bảng tính
                for (int count = 0; count < dtb.Columns.Count; count++)
                {
                    if (dtb.Columns[count].ColumnName != null)
                        sb.Append(dtb.Columns[count].ColumnName);
                    if (count < dtb.Columns.Count - 1)
                    {
                        sb.Append("\t");
                    }
                }
                Response.Write(sb.ToString() + "\n");
                Response.Flush();
                //Duyệt từng bản ghi 
                int soDem = 0;
                while (dtb.Rows.Count >= soDem + 1)
                {
                    sb = new StringBuilder();

                    for (int col = 0; col < dtb.Columns.Count - 1; col++)
                    {
                        if (dtb.Rows[soDem][col] != null)
                            sb.Append(dtb.Rows[soDem][col].ToString().Replace(",", " "));
                        sb.Append("\t");
                    }
                    if (dtb.Rows[soDem][dtb.Columns.Count - 1] != null)
                        sb.Append(dtb.Rows[soDem][dtb.Columns.Count - 1].ToString().Replace(",", " "));

                    Response.Write(sb.ToString() + "\n");
                    Response.Flush();
                    soDem = soDem + 1;
                }

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
            dtb.Dispose();
            Response.End();
        }
    }
}