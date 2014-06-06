using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityObject;
using DataAccessObject;
using Shared_Libraries;

namespace EHOU.UserControl
{
    public partial class Thong_Tin_Lop_HocUC : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //tSyncCurrentTime.Interval = 1000;
        }

        public void BinData(tblSubjectEO _tblSubjectEO, tblPartEO _tblPartEO)
        {
            lblsTitle.Text = _tblPartEO.sTitle;
            lblsName.Text = _tblSubjectEO.sName;
            tblSubject_StudentEO _tblSubject_StudentEO = new tblSubject_StudentEO();
            tblAccountEO _tblAccountEO = new tblAccountEO();
            _tblSubject_StudentEO.FK_sSubject = _tblSubjectEO.PK_sSubject;
            _tblAccountEO.PK_sUsername = _tblSubjectEO.FK_sTeacher;
            lblFK_sTeacher.Text = tblAccountDAO.Account_SelectItem(_tblAccountEO).sName + " - " + _tblSubjectEO.FK_sTeacher;
            lbliSiso.Text = tblSubject_StudentDAO.Subject_Student_SelectByFK_sSubject(_tblSubject_StudentEO).Tables[0].Rows.Count.ToString();
            lbltDateTimeStart.Text = _tblPartEO.tDateTimeStart.ToString();
            lbltDateTimeEnd.Text = _tblPartEO.tDateTimeEnd.ToString();
            lbliStatus.Text = GetTextConstants.tblPart_iStatus_GTC(_tblSubjectEO.iStatus);
        }
    }
}