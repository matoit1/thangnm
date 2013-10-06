using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessObject;
using BusinessObject;
using System.Data;
using System.Text;

namespace ThangNMjsc.Admin
{
    public partial class Products : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtProducts_Name.Attributes.Add("placeholder", "Tìm kiếm theo tên Sản phẩm");
                loadProducts();
            }
        }

        private void loadProducts()
        {
            try
            {
                DataTable dt = ProductsBO.getDataSetProducts(0).Tables[0];
                grvListProducts.DataSource = dt;
                grvListProducts.DataBind();
            }
            catch (Exception)
            {
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                String strID = "";
                foreach (GridViewRow row in grvListProducts.SelectedRows)
                {
                    strID += "," + (Int64)grvListProducts.DataKeys[row.RowIndex].Values["Products_ID"];

                }
                ProductsBO.setdeleteProductsbyProducts_ID(strID.Substring(1));
                loadProducts();
                Label13.Text = "Xóa thành công";
                Label13.CssClass = "notificationSuccessful";
            }
            catch (Exception)
            {
                Label13.Text = "Xóa thất bại vui lòng kiểm tra lại";
                Label13.CssClass = "notificationError";
            }
        }

        protected void grvListProducts_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Int64 Products_ID = (Int64)grvListProducts.DataKeys[e.Row.RowIndex].Values["Products_ID"];
                HyperLink URL1 = (HyperLink)e.Row.FindControl("hpView");
                URL1.NavigateUrl = "~/Admin/Edit/EditProducts.aspx?Products_ID=" + Products_ID + "&ViewMode=true";
                HyperLink URL2 = (HyperLink)e.Row.FindControl("hpEdit");
                URL2.NavigateUrl = "~/Admin/Edit/EditProducts.aspx?Products_ID=" + Products_ID;
            }
        }

        protected void grvListProducts_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grvListProducts.PageIndex = e.NewPageIndex;
            loadProducts();
        }

        protected void btnShowSearchAdvanced_Click(object sender, EventArgs e)
        {
            if (PanelSearchAdvanced.Visible == true)
            {
                PanelSearchAdvanced.Visible = false;
            }
            else
            {
                PanelSearchAdvanced.Visible = true;
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = ProductsBO.getDataSetSearchProductsbyName(txtProducts_Name.Text, txtProducts_Description.Text, txtProducts_Info.Text, txtProducts_Origin.Text).Tables[0];
                grvListProducts.DataSource = dt;
                grvListProducts.DataBind();
            }
            catch (Exception)
            {
            }
        }

        protected void btnExportExel_Click(object sender, EventArgs e)
        {
            string FileName = "Danh_sach_San_pham(" + Convert.ToString(DateTime.Now.ToString("dd-MM-yyyy")) + ").xls";
            ExportToExcel(FileName);
        }

        public void ExportToExcel(string fileName)
        {
            Response.ContentType = "application/csv";
            Response.Charset = "";
            Response.AddHeader("Content-Disposition", "attachment;filename=" + fileName);
            Response.ContentEncoding = Encoding.Unicode;
            Response.BinaryWrite(Encoding.Unicode.GetPreamble());
            DataTable dtb = ProductsBO.getDataSetProducts(0).Tables[0];
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