using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessObject;

namespace TracNghiemTrucTuyen
{
    public partial class QLCauhoi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BinData();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (CauhoiDAO.Insert(txttencauhoi.Text, txtdaa.Text, txtdab.Text, txtdac.Text, txtdad.Text, Convert.ToInt32(txtdadung.Text)) == true)
            {
                lblMsg.Text = "Them thanh cong";
            }
            else
            { lblMsg.Text = "Them that bai"; }
        }

        public void BinData(){
            //grvDS.DataSource = CauhoiDAO.LoadDSCauHoi();
            //grvDS.DataBind();
        }
    }
}