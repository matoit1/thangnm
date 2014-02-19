using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessObject;
using System.Collections;

namespace TracNghiemTrucTuyen
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BinData();
            }
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            int true_false=0;
            int key, value, dung = 0;
            SortedList slCheck = new SortedList();
            for (int i =0; i<lvQuestion.Items.Count; i++)
            {
                Label lblTemp =(Label) lvQuestion.Items[i].FindControl("questionID");
                RadioButton rdA = (RadioButton ) lvQuestion.Items[i].FindControl("ansA");
                RadioButton rdB = (RadioButton ) lvQuestion.Items[i].FindControl("ansB");
                RadioButton rdC = (RadioButton ) lvQuestion.Items[i].FindControl("ansC");
                RadioButton rdD = (RadioButton)lvQuestion.Items[i].FindControl("ansD");
                if (rdA.Checked == true){ dung = 1;}
                if (rdB.Checked == true){ dung = 2;}
                if (rdC.Checked == true){ dung = 3;}
                if (rdD.Checked == true){ dung = 4;} 
                value = dung;
                key = Convert.ToInt32(lblTemp.Text.ToString());
                slCheck.Add(key, value);

                Label lblResuilt = (Label)lvQuestion.Items[i].FindControl("lblResuilt");
                if (CauhoiDAO.CheckQuestion(key, value) != true)
                {
                    lblResuilt.Text = "Bạn đã trả lời sai";
                    lblResuilt.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    lblResuilt.Text = "Bạn đã trả lời đúng";
                    lblResuilt.ForeColor = System.Drawing.Color.Blue;
                    true_false = true_false + 1;
                }
            }
            lblMsg.Text = "Bạn đã trả lời đúng: " + true_false + "/10";
            Response.Write("<script>alert('Bạn đã trả lời đúng: " + true_false + "/10" + "')</script>");
            Response.Write("<script>alert('Cần cố gắng nhiều hơn nhoé')</script>");
        }

        public void BinData()
        {
            string strID = string.Join(",", Shared_Libraries.Get_List_ID_by_List_Index(Shared_Libraries.Random_Array_Not_Duplicate(CauhoiDAO.CountAllQuestion(), 10), CauhoiDAO.SelectList()).ToArray());
            //string strIndexItem = string.Join(",", Shared_Libraries.Random_Array_Not_Duplicate(CauhoiDAO.CountAllQuestion(),3).ToArray());
            lvQuestion.DataSource = CauhoiDAO.SelectList_Question_by_Array_Cauhoi_ID(strID);
            lvQuestion.DataBind();
            //Label1.Text = strID;
        }
    }
}