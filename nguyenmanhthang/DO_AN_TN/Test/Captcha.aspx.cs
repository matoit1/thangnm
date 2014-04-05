using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Shared_Libraries;
using System.IO;

namespace DO_AN_TN.Test
{
    public partial class Captcha : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool a = FileEquals("E:\\HelloWorld.java", "E:\\Hello.java");
            Label1.Text = "Kết quả: " + a;

            if (!IsPostBack)
            {
                imgCaptcha1.ImageUrl = new CaptchaProvider().CreateCaptcha();
            }
        }

        protected void ChangeCaptcha_Click(object sender, EventArgs e)
        {
            imgCaptcha1.ImageUrl = new CaptchaProvider().CreateCaptcha();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                lblMsg.Text = Common.DocTienBangChu(Convert.ToInt64(txtInput.Text), " đồng");
            }
            catch (Exception ex) { lblMsg.Text = ex.Message; }
        }

        static bool FileEquals(string path1, string path2)
        {
            byte[] file1 = File.ReadAllBytes(path1);
            byte[] file2 = File.ReadAllBytes(path2);
            if (file1.Length == file2.Length)
            {
                for (int i = 0; i < file1.Length; i++)
                {
                    if (file1[i] != file2[i])
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }
    }
}