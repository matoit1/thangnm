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
                        //imgsLinkImage.ImageUrl = _tblTopicEO.sLinkImage;
                        //imgsLinkImage.ImageUrl =_tblTopicEO.sTitle;


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
                    }
                }
            }
            catch { }
        }
    }
}