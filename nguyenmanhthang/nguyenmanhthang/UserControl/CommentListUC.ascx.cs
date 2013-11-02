using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BusinessObject;
using nguyenmanhthang.Library.Common;

namespace nguyenmanhthang.UserControl
{
    public partial class CommentListUC : System.Web.UI.UserControl
    {
        #region "Khai Báo Biến, Thuộc tính, Sự kiện"
        public event EventHandler ViewComment;
        public event EventHandler PageChangeComment;
        public event EventHandler NewComment;
        public event EventHandler DeleteComment;
        public event EventHandler ExportToExcelComment;
        public bool isBlock;
        private Int64 _Topic_ID, _Comment_ID;
        public Int64 Topic_ID
        {
            get { return this._Topic_ID; }
            set { _Topic_ID = value; }
        }
        public Int64 Comment_ID
        {
            get { return this._Comment_ID; }
            set { _Comment_ID = value; }
        }

        private DataSet _dsComment;
        public DataSet dsComment
        {
            get { return this._dsComment; }
            set { _dsComment = value; }
        }
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
            }
        }

        public void ReBindDataGrid(Int64 Topic_ID, bool status)
        {
            isBlock = status;
            BindDataGrid(Topic_ID);
        }

        public void BindDataGrid(Int64 Topic_ID)//true block, 
        {
            try
            {
                DataSet dsCommentList = CommentBO.Comment_SelectListbyTopic_ID(Topic_ID, isBlock);
                grvCommentList.DataSource = dsCommentList;
                grvCommentList.DataBind();
                lblTongSo_BanGhi.Text = Alert.TONG_SO_BAN_GHI + dsCommentList.Tables[0].Rows.Count.ToString();
            }
            catch { }            
        }

        protected void grvCommentList_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grvCommentList.PageIndex = e.NewPageIndex;
            if (PageChangeComment != null)
            {
                PageChangeComment(this, EventArgs.Empty);
            }

        }

        protected void grvCommentList_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Int64 Comment_ID = (Int64)grvCommentList.DataKeys[e.Row.RowIndex].Values["Comment_ID"];
                //LinkButton URL1 = (LinkButton)e.Row.FindControl("hpView");
                //URL1.PostBackUrl = "~/Admin/Edit/OrdersDetails.aspx?Orders_ID=" + Topic_ID + "&ViewMode=true";
            }
        }

        protected void grvCommentList_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "cmdView")
            {
                this.Comment_ID = Convert.ToInt64(e.CommandArgument);
                if (ViewComment != null)
                {
                    ViewComment(this, EventArgs.Empty);
                }
            }
        }

        protected void ibtnDelete_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                String strID = "";
                foreach (GridViewRow row in grvCommentList.SelectedRows)
                {
                    strID += "," + grvCommentList.DataKeys[row.RowIndex].Values["Comment_ID"];

                }
                //CommentBO.Comment_Delete(strID.Substring(1));
                if (DeleteComment != null)
                {
                    DeleteComment(this, EventArgs.Empty);
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
            if (NewComment != null)
            {
                NewComment(this, EventArgs.Empty);
            }
        }

        protected void ibtnExportExcel_Click(object sender, ImageClickEventArgs e)
        {
            string FileName = "Danh_sach_Bai_viet(" + Convert.ToString(DateTime.Now.ToString("dd-MM-yyyy")) + ").xls";
            ExportToExcel(FileName);
        }

        public void ExportToExcel(string fileName)
        {
        //    if (ExportToExcelTopic != null)
        //    {
        //        ExportToExcelTopic(this, EventArgs.Empty);
        //    }
        //    Response.ContentType = "application/vnd.ms-excel";
        //    Response.Charset = "";
        //    Response.AddHeader("Content-Disposition", "attachment;filename=" + fileName);
        //    Response.ContentEncoding = Encoding.Unicode;
        //    Response.BinaryWrite(Encoding.Unicode.GetPreamble());
        //    DataTable dtb = dsTopic.Tables[0];
        //    try
        //    {
        //        StringBuilder sb = new StringBuilder();
        //        //Tạo dòng tiêu để cho bảng tính
        //        for (int count = 0; count < dtb.Columns.Count; count++)
        //        {
        //            if (dtb.Columns[count].ColumnName != null)
        //                sb.Append(dtb.Columns[count].ColumnName);
        //            if (count < dtb.Columns.Count - 1)
        //            {
        //                sb.Append("\t");
        //            }
        //        }
        //        Response.Write(sb.ToString() + "\n");
        //        Response.Flush();
        //        //Duyệt từng bản ghi 
        //        int soDem = 0;
        //        while (dtb.Rows.Count >= soDem + 1)
        //        {
        //            sb = new StringBuilder();

        //            for (int col = 0; col < dtb.Columns.Count - 1; col++)
        //            {
        //                if (dtb.Rows[soDem][col] != null)
        //                    sb.Append(dtb.Rows[soDem][col].ToString().Replace(",", " "));
        //                sb.Append("\t");
        //            }
        //            if (dtb.Rows[soDem][dtb.Columns.Count - 1] != null)
        //                sb.Append(dtb.Rows[soDem][dtb.Columns.Count - 1].ToString().Replace(",", " "));

        //            Response.Write(sb.ToString() + "\n");
        //            Response.Flush();
        //            soDem = soDem + 1;
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        Response.Write(ex.Message);
        //    }
        //    dtb.Dispose();
        //    Response.End();
        }
    }
}