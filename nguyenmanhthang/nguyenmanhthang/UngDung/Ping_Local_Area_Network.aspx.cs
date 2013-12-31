using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.NetworkInformation;
using System.Data;
using System.Net;
using System.Management;
using System.Text.RegularExpressions;

namespace nguyenmanhthang.UngDung
{
    public partial class Ping_Local_Area_Network : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string str = @"
    Với tinh thần chia sẻ, giao lưu và học hỏi với các bạn tôi lập 
    website hmweb - Chia sẻ là niềm vui. Chia sẻ những gì có thể cũng 
    là một phần trong những sở thích của tôi. Tôi hy vọng qua hmweb 
    bạn có thể tìm kiếm được những thông tin hữu ích cho các bạn, 
    Những thông tin, kiến thức trên hmweb chủ yếu tập trung vào 
    lĩnh vực lập trình với asp.net, csharp, javascript, SQL server, 
    tài liệu, video hướng dẫn ôn thi tốt nghiêp, cao đẳng và đại học. 
    Qua hmweb tôi cũng nhận thấy khá hơn rất nhiều và cũng học thêm 
    được nhiều điều do tìm kiếm nội dung để viết bài và khi viết bài 
    tôi nhận thấy khả năng trình bày cũng được cải thiện nhiều.";
            lblContent.Text = HighlightKeyWords(str, "hmweb", "yellow");
            string ipAddress = Request.ServerVariables["REMOTE_ADDR"];
            lblTitle.Text = "Ping địa chỉ IP mạng LAN - " + ipAddress;
        }

        private DataTable GetData()
        {
            DataTable dtb = new DataTable();
            //Tạo các Columns
            dtb.Columns.Add("IP");
            dtb.Columns.Add("Address");
            //Thêm các bản ghi
            dtb.Rows.Add("192.168.1.1", "Router");
            dtb.Rows.Add("192.168.1.106", "ThangNM");
            dtb.Rows.Add("192.168.1.100", "Windows-Phone");
            dtb.Rows.Add("192.168.1.101", "Windows-Phone");
            dtb.Rows.Add("192.168.1.102", "m2hoang");
            dtb.Rows.Add("192.168.1.103", "android-49b1d8a0b92d1fe2");
            dtb.Rows.Add("192.168.1.104", "NguyenDucDuong");
            dtb.Rows.Add("192.168.1.105", "ComputersiPhone");
            dtb.Rows.Add("192.168.1.107", "android-4eaac012c6e71867");
            dtb.Rows.Add("192.168.1.108", "");
            dtb.Rows.Add("192.168.1.109", "WR340G");
            dtb.Rows.Add("192.168.1.110", "PC2011050811IXZ");
            dtb.Rows.Add("192.168.1.112", "anhmai-09160919");
            dtb.Rows.Add("192.168.1.113", "hoang");
            dtb.Rows.Add("192.168.1.114", "administrator");
            dtb.Rows.Add("192.168.1.115", "VAIO");
            dtb.Rows.Add("192.168.1.117", "Toshiba");
            return dtb;
        }

        private string PingIP()
        {
            string strOut = "";
            DataTable dtbData = GetData();
            Ping ping = new Ping();
            strOut += "<TABLE cellpadding=\"0\" cellspacing=\"1\"  bgcolor=\"#cccccc\" width=100%>";
            for (int i = 0; i < dtbData.Rows.Count; i++)
            {
                PingReply pingreply = ping.Send(dtbData.Rows[i]["IP"] + "");
                if (pingreply.Status.ToString().ToLower() != "success")
                {
                    strOut += "<TR>";
                    strOut += "<TD bgcolor=\"#FFFFFF\"><font color=red>";
                    strOut += dtbData.Rows[i]["Address"] + "</font></TD>";
                    strOut += "<TD colspan=3 bgcolor=\"#FFFFFF\"> <font color=red>" + dtbData.Rows[i]["IP"] + "" + " " + pingreply.Status.ToString() + "</font></TD>";
                    strOut += "</TR>";
                }
                else
                {
                    strOut += "<TR>";
                    strOut += "<TD  bgcolor=\"#FFFFFF\">";
                    strOut += dtbData.Rows[i]["Address"] + "</TD>";
                    strOut += "<TD bgcolor=\"#FFFFFF\" align=center > " + pingreply.Address + " " + pingreply.Status.ToString() + "</TD>";
                    strOut += "<TD bgcolor=\"#FFFFFF\">Round trip times: " + Convert.ToString(pingreply.RoundtripTime) + "</TD>";
                    strOut += "<TD bgcolor=\"#FFFFFF\">Buffer Size: " + pingreply.Buffer.Length.ToString() + "</TD>";
                    strOut += "</TR>";
                }
            }
            strOut += "</TABLE>";
            return strOut;
        }

        //Begin Demo
        private static string GetIpAddress()
        {
            string strHostName = "";
            strHostName = System.Net.Dns.GetHostName();
            IPHostEntry ipEntry = System.Net.Dns.GetHostEntry(strHostName);
            IPAddress[] addr = ipEntry.AddressList;
            return addr[addr.Length - 1].ToString();
        }
        private string GetMac()
        {
            string Mac = string.Empty;
            ManagementClass MC = new ManagementClass("Win32_NetworkAdapter");
            ManagementObjectCollection MOCol = MC.GetInstances();
            foreach (ManagementObject MO in MOCol)
                if (MO != null)
                {
                    if (MO["MacAddress"] != null)
                    {
                        Mac = MO["MACAddress"].ToString();
                        if (Mac != string.Empty)
                            break;
                    }
                }
            return Mac;
        }
        private string GetOSName()
        {
            System.OperatingSystem os = System.Environment.OSVersion;
            string osName = "Unknown";
            switch (os.Platform)
            {
                case System.PlatformID.Win32Windows:
                    switch (os.Version.Minor)
                    {
                        case 0:
                            osName = "Windows 95";
                            break;
                        case 10:
                            osName = "Windows 98";
                            break;
                        case 90:
                            osName = "Windows ME";
                            break;
                    }
                    break;
                case System.PlatformID.Win32NT:
                    switch (os.Version.Major)
                    {
                        case 3:
                            osName = "Windws NT 3.51";
                            break;
                        case 4:
                            osName = "Windows NT 4";
                            break;
                        case 5:
                            if (os.Version.Minor == 0)
                                osName = "Windows 2000";
                            else if (os.Version.Minor == 1)
                                osName = "Windows XP";
                            else if (os.Version.Minor == 2)
                                osName = "Windows Server 2003";
                            break;
                        case 6:
                            osName = "Windows Vista";
                            break;
                    }
                    break;
            }

            return osName + ", " + os.Version.ToString();
        }
        //End Demo

        protected void btnGet_Click(object sender, EventArgs e)
        {
            lblTest1.Text = "";
            lblTest2.Text = "";
            lblTest3.Text = "";
            lblTest1.Text= GetIpAddress();
            lblTest2.Text = GetMac();
            lblTest3.Text = GetOSName();
        }
        protected void btnPing_Click(object sender, EventArgs e)
        {
            lblContent.Text = "";
            lblContent.Text = PingIP();
        }


        /// <summary>
        /// Đánh dấu từ khóa với thuộc tính background-color
        /// </summary>
        /// <param name="text"></param>
        /// <param name="keywords">Từ khóa tìm kiếm</param>
        /// <param name="cssClass">Css style hoặc color đánh dấu từ khóa</param>
        /// <returns>string</returns>
        private string HighlightKeyWords(string text, string keywords, string cssClass)
        {
            if (text == String.Empty || keywords == String.Empty || cssClass == String.Empty)
                return text;
            var words = keywords.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            return words.Select(
                word => word.Trim()).Aggregate(
                    text,
                    (current, pattern) =>
                        Regex.Replace(current,
                                        pattern,
                                        string.Format("<span style=\"background-color:{0}\">{1}</span>",
                                        cssClass,
                                        "$0"),
                                        RegexOptions.IgnoreCase));
            return words.Select(word => "\\b" + word.Trim() + "\\b").Aggregate(text, (current, pattern) => Regex.Replace(current,pattern,string.Format("<span style=\"background-color:{0}\">{1}</span>",cssClass,"$0"),RegexOptions.IgnoreCase));
        }
    }
}