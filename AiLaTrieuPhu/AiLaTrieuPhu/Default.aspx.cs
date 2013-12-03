using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Data;
using AiLaTrieuPhu.Library;

namespace AiLaTrieuPhu
{
    public partial class _Default : System.Web.UI.Page
    {
        public DataSet Cauhoi;
        public int[] MangCauhoi;
        public Int32 STT;
        //{
        //    get { return Convert.ToInt32(ViewState["STT"]); }
        //    set { ViewState["STT"] = value; }
        //}
        public Int64 CauhoiID
        {
            get { return Convert.ToInt64(ViewState["CauhoiID"]); }
            set { ViewState["CauhoiID"] = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            STT = STT + 1;
            if (!IsPostBack)
            {
                CauhoiID = Common_Public.RandomQuestion();
                LoadDL(CauhoiID);
            }
            lblSTT.Text = Common_Public.TieuDe(STT) + Common_Public.SoTienThuong(STT);
        }

        protected void LoadDL(Int64 id)
        {
            DataSet ds = CauhoiDAO.LoadCauHoiTheoID(id);
            //if (ds.Tables[0].Rows.Count == 0)
            //{
            //LoadDL(CauhoiID);
            //}
            Cauhoi = ds;
            rpCauhoi.DataSource = ds;
            rpCauhoi.DataBind();
        }

        protected void TraLoiSaiRoi()
        {
            DataSet ds = TaikhoanDAO.Search(Request.Cookies["acc"].Value);
            if (DiemDAO.Insert(Convert.ToInt32(ds.Tables[0].Rows[0]["taikhoan_ID"]), Convert.ToInt64(Common_Public.SoTienThuong(STT - 1))) == true)
            {
                Response.Redirect("~/Finish.aspx?state=true");
            }
            else
            {
                Response.Redirect("~/Finish.aspx?state=false");
            }
        }

        protected void rpCauhoi_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            DataSet Cauhoi = CauhoiDAO.LoadCauHoiTheoID(1);
            string name = e.CommandName;
            if (name == "A")
            {
                if (Convert.ToInt32(Cauhoi.Tables[0].Rows[0]["Cauhoi_dung"]) == 1)
                {
                    lblMsg.Text = "Trả lời đúng";
                    LoadDL(Common_Public.RandomQuestion());
                }
                else
                {
                    lblMsg.Text = "Trả lời sai";
                    TraLoiSaiRoi();
                }
            }
            if (name == "B")
            {
                if (Convert.ToInt32(Cauhoi.Tables[0].Rows[0]["Cauhoi_dung"]) == 2)
                {
                    lblMsg.Text = "Trả lời đúng";
                    LoadDL(Common_Public.RandomQuestion());
                }
                else
                {
                    lblMsg.Text = "Trả lời sai";
                    TraLoiSaiRoi();
                }
            }
            if (name == "C")
            {
                if (Convert.ToInt32(Cauhoi.Tables[0].Rows[0]["Cauhoi_dung"]) == 3)
                {
                    lblMsg.Text = "Trả lời đúng";
                    LoadDL(Common_Public.RandomQuestion());
                }
                else
                {
                    lblMsg.Text = "Trả lời sai";
                    TraLoiSaiRoi();
                }
            }
            if (name == "D")
            {
                if (Convert.ToInt32(Cauhoi.Tables[0].Rows[0]["Cauhoi_dung"]) == 4)
                {
                    lblMsg.Text = "Trả lời đúng";
                    LoadDL(Common_Public.RandomQuestion());
                }
                else
                {
                    lblMsg.Text = "Trả lời sai";
                    TraLoiSaiRoi();
                }
            }
        }
    }
}