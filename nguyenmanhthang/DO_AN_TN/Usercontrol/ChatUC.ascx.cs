using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using Shared_Libraries.ChatLIB;
using EntityObject;
using DataAccessObject;
using Shared_Libraries;
using System.IO;

namespace DO_AN_TN.UserControl
{
    public partial class ChatUC : System.Web.UI.UserControl
    {
        #region "Properties & Event"
        //public event EventHandler ViewDetail;
        public static string path = HttpContext.Current.Request.MapPath("~/Upload/BlackList.txt");
        public static int indexrow =10;
        public TinNhanEO objTinNhanEO
        {
            get { return (TinNhanEO)ViewState["objTinNhanEO"]; }
            set { ViewState["objTinNhanEO"] = value; }
        }
        public string sAccountDisabe
        {
            get { return (string)ViewState["sAccountDisabe"]; }
            set { ViewState["sAccountDisabe"] = value; }
        }
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                rptDialog.DataSource = TinNhanDAO.TinNhan_SelectList(objTinNhanEO);
                rptDialog.DataBind();
                tAutoUpdateMessage.Interval = 1000;
            }
        }

        protected void btnSent_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "";
            try
            {
                if (string.IsNullOrEmpty(sAccountDisabe) == true)
                {
                    lblMsg.Text = string.Empty;
                    objTinNhanEO.sNoidung = Common.ShowIconByKey(Convert.ToString(txtsNoidung.Text));
                    if (string.IsNullOrEmpty(txtsNoidung.Text) == false)
                    {
                        if (TinNhanDAO.TinNhan_Insert(objTinNhanEO) == false)
                        {
                            lblMsg.Text = Messages.ChatRoom_Fail;
                        }
                        else
                        {
                            txtsNoidung.Text = "";
                            txtsNoidung.Focus();
                        }
                    }
                }
                else
                {
                    lblMsg.Text = Messages.ChatRoom_Limit;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void tAutoUpdateMessage_Tick(object sender, EventArgs e)
        {
            try
            {
                SinhVienEO _SinhVienEO = new SinhVienEO();
                _SinhVienEO.FK_sMaLop = "LH00010B1";
                lblSumOnline.Text = SinhVienDAO.SinhVien_SelectByFK_sMaLop(_SinhVienEO).Tables[0].Rows.Count.ToString();
                rptDialog.DataSource = TinNhanDAO.TinNhan_SelectList(objTinNhanEO);
                rptDialog.DataBind();
            }
            catch { }
        }

        public string GetRowColor(object obj)
        {
            string color = "white";
            if (!string.IsNullOrEmpty(obj.ToString()))
            {
                int status =Convert.ToInt32(obj) % 2;
                switch (status)
                {
                    case 0:
                        color = "#0000FF "; break;
                    case 1:
                        color = "#FF0000"; break;
                    default:
                        color = "#CC66FF"; break;
                }
            }
            return color;
        }

        protected void rptDialog_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            try
            {
                string lblFK_sNguoiGui = ((Label)e.Item.FindControl("lblFK_sNguoiGui")).Text;
                SinhVienEO _SinhVienEO = new SinhVienEO();
                _SinhVienEO.sTendangnhapSV = lblFK_sNguoiGui;
                string acc_id = SinhVienDAO.SinhVien_SelectBysTendangnhapSV(_SinhVienEO).PK_sMaSV;
                switch (e.CommandName)
                {
                    case "ibntTool": break;
                    case "ibntDeleteMessage":
                        objTinNhanEO.PK_lTinNhan = Convert.ToInt64(((HiddenField)e.Item.FindControl("hfdPK_lTinNhan")).Value);
                        if (TinNhanDAO.TinNhan_Delete(objTinNhanEO) == false)
                        {
                            lblMsg.Text = Messages.ChatRoom_Hide_Fail;
                        }
                        else
                        {
                            txtsNoidung.Text = Messages.ChatRoom_Hide_Success;
                        }
                        break;
                    case "ibntHideAcc":
                        sAccountDisabe = lblFK_sNguoiGui;
                        //File.AppendAllText(path, acc_id + Environment.NewLine);
                        ((ImageButton)e.Item.FindControl("ibntHideAcc")).Visible = false;
                        ((ImageButton)e.Item.FindControl("ibntShowAcc")).Visible = true;
                        break;
                    case "ibntShowAcc":
                        sAccountDisabe = "";
                        //string line = null;
                        //using (StreamReader reader = new StreamReader(path)) {
                        //    using (StreamWriter writer = new StreamWriter(path))
                        //    {
                        //        while ((line = reader.ReadLine()) != null) {
                        //            if (String.Equals(line, acc_id) == false)
                        //                continue;
                        //            writer.WriteLine(line);
                        //        }
                        //    }
                        //}
                        ((ImageButton)e.Item.FindControl("ibntHideAcc")).Visible = true;
                        ((ImageButton)e.Item.FindControl("ibntShowAcc")).Visible = false;
                        break;
                }
            }
            catch
            {

            }
        }
    }
}