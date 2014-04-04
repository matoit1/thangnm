using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using Shared_Libraries;
using DataAccessObject;
using System.Media;
using EntityObject;
using Shared_Libraries.Constants;

namespace DO_AN_TN.UserControl
{
    public partial class TracNghiemUC : System.Web.UI.UserControl
    { 
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BinData();
                btnTime.Text = "30";
                tThoiGianTraLoiCauHoi.Interval = 1000;
            }
        }

        protected void tThoiGianTraLoiCauHoi_Tick(object sender, EventArgs e)
        {
            int CountDown = Convert.ToInt16(btnTime.Text) - 1;
            btnTime.Text = CountDown.ToString();
            if (0 < CountDown && CountDown <= 10)
            {
                SoundPlayer x = new SoundPlayer();
                x.SoundLocation = Server.MapPath("\\Media\\Virus.WAV");
                x.Play();
            }
            if (CountDown <= 0)
            {
                btnTime.Text = "0";
                btnTime.BackColor = System.Drawing.Color.Red;
            }
        }

        public void BinData()
        {
            List<int> a = Common.Random_Array_Not_Duplicate(CauHoiDAO.CauHoi_CountAll(), 10);
            List<int> b = Common.Get_List_ID_by_List_Index(a, CauHoiDAO.CauHoi_SelectList());
            List<string> l2 = b.ConvertAll<string>(x => x.ToString());
            string strID = String.Join(",", b.ToArray());
            //string strIndexItem = string.Join(",", Shared_Libraries.Random_Array_Not_Duplicate(CauhoiDAO.CountAllQuestion(),3).ToArray());
            lvQuestion.DataSource = CauHoiDAO.CauHoi_SelectList_Question_by_Array_Cauhoi_ID(strID);
            lvQuestion.DataBind();
            //Label1.Text = strID;
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            int true_false = 0;
            Int16 key, value, dung;
            SortedList slCheck = new SortedList();
            for (int i = 0; i < lvQuestion.Items.Count; i++)
            {
                dung = 0;
                Label lblTemp = (Label)lvQuestion.Items[i].FindControl("questionID");
                RadioButton rbtnsCauhoi_A = (RadioButton)lvQuestion.Items[i].FindControl("rbtnsCauhoi_A");
                RadioButton rbtnsCauhoi_B = (RadioButton)lvQuestion.Items[i].FindControl("rbtnsCauhoi_B");
                RadioButton rbtnsCauhoi_C = (RadioButton)lvQuestion.Items[i].FindControl("rbtnsCauhoi_C");
                RadioButton rbtnsCauhoi_D = (RadioButton)lvQuestion.Items[i].FindControl("rbtnsCauhoi_D");
                if (rbtnsCauhoi_A.Checked == true) { dung = 1; }
                if (rbtnsCauhoi_B.Checked == true) { dung = 2; }
                if (rbtnsCauhoi_C.Checked == true) { dung = 3; }
                if (rbtnsCauhoi_D.Checked == true) { dung = 4; }
                value = dung;
                key = Convert.ToInt16(lblTemp.Text.ToString());
                slCheck.Add(key, value);

                Label lblResuilt = (Label)lvQuestion.Items[i].FindControl("lblResuilt");
                if (CauHoiDAO.Check(key, value) != true)
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
            DiemThiEO _DiemThiEO = new DiemThiEO();
            SinhVienEO _SinhVienEO = new SinhVienEO();
            _SinhVienEO.sTendangnhapSV = Request.Cookies["sinhvien"].Value;
            _DiemThiEO.FK_sMaSV = SinhVienDAO.SinhVien_SelectBysTendangnhapSV(_SinhVienEO).PK_sMaSV;
            _DiemThiEO.FK_sMaMonhoc = "MH000004";
            _DiemThiEO.PK_iSolanhoc = 1;
            _DiemThiEO.fDiemgiuaky = true_false;
            _DiemThiEO.iTrangThai = DiemThi_iTrangThai_C.Binh_Thuong;
            if (DiemThiDAO.DiemThi_Insert(_DiemThiEO) == true)
            {
                lblMsg.Text = lblMsg.Text + "<br />" + "Chấm điểm thành công!";
            }
            else
            {
                lblMsg.Text = lblMsg.Text + "<br />" + "Chấm điểm không thành công!";
            }
            //Response.Write("<script>alert('Bạn đã trả lời đúng: " + true_false + "/10" + "')</script>");
            //Response.Write("<script>alert('Cần cố gắng nhiều hơn nhoé')</script>");
        }
    }
}