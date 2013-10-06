using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace ThangNMjsc.Test
{
    public partial class TestDES : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEncrypt_Click(object sender, EventArgs e)
        {
            //txtOutput.Text = DESCSPSample.EncryptTextToMemory(txtInput.Text, ConvertStringToByteArray("0123456789ABCDEF"), ConvertStringToByteArray("1133557799BBDDFF"));
            //txtBegin.Text = DES.Decrypt(txtOutput.Text);
            //txtOutput.Text = Convert.ToString(ConverttoByte("thangnm"));
        }

        protected void btnDecrypt_Click(object sender, EventArgs e)
        {
            //txtOutput.Text = DES.Encrypt(txtInput.Text);
            //txtBegin.Text = DES.Decrypt(txtOutput.Text);
        }

        public static byte[] ConvertStringToByteArray(string input)
        {
            byte[] array = Encoding.ASCII.GetBytes(input);
            return array;
        }

        public static string ConvertByteArrayToString(byte[] array)
        {
            string value = ASCIIEncoding.ASCII.GetString(array);
            Console.WriteLine(value);
            return value;
        }
    }
}