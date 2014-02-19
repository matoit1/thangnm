using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessObject;

namespace TracNghiemTrucTuyen
{
    public partial class ThiTracNghiemNao : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BinData();
                lblMsg.Text = randomarray().ToString();
            }
        }

        public void BinData()
        {
            rptLoadCauHoi.DataSource = CauhoiDAO.SelectList();
            rptLoadCauHoi.DataBind();
        }

        protected void rptLoadCauHoi_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            string name = e.CommandName;
            if (name == "check")
            {
                int idcauhoi = Convert.ToInt32( ((Label)e.Item.FindControl("lblIDCauhoi")).Text);    //Lay ID cua cau hoi
                bool caua = ((RadioButton)e.Item.FindControl("rdoA")).Checked;
                bool caub = ((RadioButton)e.Item.FindControl("rdoB")).Checked;
                bool cauc = ((RadioButton)e.Item.FindControl("rdoC")).Checked;
                bool caud = ((RadioButton)e.Item.FindControl("rdoD")).Checked;
                int dung=0;
                if(caua==true){ // nay di
                    dung=1;// ko bao h luon luon bang 1 de so sanh vs db ay
                }
                if(caub==true){
                    dung=2;
                }
                if(cauc==true){
                    dung=3;
                }
                if(caud==true){
                    dung=4;
                }

                if (dung == Convert.ToInt32(CauhoiDAO.LoadCauHoibyID(idcauhoi).Tables[0].Rows[0]["dadung"].ToString()))
                    
                {
                    lblMsg.Text = "Câu: "+ idcauhoi + " Đúng";
                    ((Label)e.Item.FindControl("lblKetqua")).Text = "Câu: " + idcauhoi + " Đúng";
                    ((Button)e.Item.FindControl("CheckIn")).Enabled = false;
                    
                }
                else {
                    lblMsg.Text = "Câu: " + idcauhoi + " Sai";
                    ((Label)e.Item.FindControl("lblKetqua")).Text = "Câu: " + idcauhoi + " Sai";
                    ((Button)e.Item.FindControl("CheckIn")).Enabled = false;
                }
            }
        }


        static int randomarray()
        {
            int[] a = {3,4,5,6,7};
            int n = 5;
            Random ran = new Random();
            int i = ran.Next(n);
            return i;
        }  
    }
}