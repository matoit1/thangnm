using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

namespace ThangNMjsc.Test
{
    public partial class Url : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            url.Text= ConvertToUnSign("('Nguyễn Mạnh Thắng')");
        }

        /// <summary>

        /// Hàm chuyển đổi chuỗi có dấu thành không dấu

        /// NhanDT 14/01/2011.

        /// </summary>

        /// <param name="text"></param>

        /// <returns></returns>

        public static string ConvertToUnSign(string text)
        {
            for (int i = 32; i < 48; i++)
            {
                text = text.Replace(((char)i).ToString(), " ");
            }
            text = text.Replace(".", "-");
            text = text.Replace(" ", "-");
            text = text.Replace(",", "-");
            text = text.Replace(";", "-");
            text = text.Replace(":", "-");
            Regex regex = new Regex(@"\p{IsCombiningDiacriticalMarks}+");
            string strFormD = text.Normalize(System.Text.NormalizationForm.FormD);
            return regex.Replace(strFormD, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }
    }
}