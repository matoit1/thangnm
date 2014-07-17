using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityObject;
using DataAccessObject;
using System.Web.UI.HtmlControls;

namespace Profile
{
    public partial class Member : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    if (Request.QueryString["PK_iAccountsID"] != null)
                    {
                        tblAccountEO _tblAccountEO = new tblAccountEO();
                        _tblAccountEO.PK_iAccountsID = Convert.ToInt32(Request.QueryString["PK_iAccountsID"]);
                        _tblAccountEO = tblAccountDAO.SelectItem(_tblAccountEO);


                        lblsFullName.Text = _tblAccountEO.sFullName;
                        lbliAlias.Text = _tblAccountEO.iAlias.ToString();

                        Page.Title = "Thông tin cá nhân thành viên - " + _tblAccountEO.sFullName;
                        HtmlMeta metatag = new HtmlMeta();
                        metatag.Name = "description";
                        metatag.Content = "description of page";
                        Header.Controls.Add(metatag);

                        metatag = new HtmlMeta();
                        metatag.Name = "keywords";
                        metatag.Content = "keywords of page";
                        Header.Controls.Add(metatag);
                    }
                }
            }
            catch { }
        }
    }
}