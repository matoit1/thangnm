using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System;
using System.Collections.Generic;
using System.Web.UI.HtmlControls;
using EntityObject;
using DataAccessObject;
using System.Data;

namespace Profile
{
    public partial class Topic : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    if (Request.QueryString["PK_lTopicID"] != null)
                    {
                        tblTopicEO _tblTopicEO = new tblTopicEO();
                        _tblTopicEO.PK_lTopicID = Convert.ToInt64(Request.QueryString["PK_lTopicID"]);
                        _tblTopicEO = tblTopicDAO.SelectItem(_tblTopicEO);


                        lblsTitle.Text = _tblTopicEO.sTitle;
                        lblsContent.Text = _tblTopicEO.sContent;
                        lblFK_iAccountsID.Text = _tblTopicEO.FK_iAccountsID.ToString();
                        lbliVisit.Text = _tblTopicEO.iVisit.ToString();
                        lbltLastUpdate.Text = _tblTopicEO.tLastUpdate.ToString();
                        hplFK_iAccountsID.NavigateUrl = "~/Member.aspx?PK_iAccountsID=" + _tblTopicEO.FK_iAccountsID.ToString();
                        hplPK_lTopicID1.NavigateUrl = "~/Topic.aspx?PK_lTopicID=" + _tblTopicEO.PK_lTopicID.ToString();
                        hplPK_lTopicID.NavigateUrl = hplPK_lTopicID1.NavigateUrl + "#comment";

                        Page.Title = "Nguyễn Mạnh Thắng - " + _tblTopicEO.sTitle;
                        HtmlMeta metatag = new HtmlMeta();
                        metatag.Name = "description";
                        metatag.Content = "description of page";
                        Header.Controls.Add(metatag);

                        metatag = new HtmlMeta();
                        metatag.Name = "keywords";
                        metatag.Content = "keywords of page";
                        Header.Controls.Add(metatag);

                        _tblTopicEO.iLike = 0;
                        _tblTopicEO.iVisit = _tblTopicEO.iVisit + 1;
                        tblTopicDAO.Update_iVisit_Or_iLike(_tblTopicEO);

                        DataTable dt = new DataTable();
                        tblTagEO _tblTagEO = new tblTagEO();
                        _tblTagEO.FK_lTopicID = _tblTopicEO.PK_lTopicID;
                        dt = tblTagDAO.SelectBy_FK_lTopicID(_tblTagEO);
                        rptTag.DataSource = dt;
                        rptTag.DataBind();

                    }
                }
            }
            catch { }
        }
    }
}