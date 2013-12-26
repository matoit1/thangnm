using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using System.Web.UI.HtmlControls;

namespace LiveChat
{
    public partial class chat : System.Web.UI.Page
    {
        #region conversationid
        int? _conversationId;
        public int? ConversationId
        {
            get { return _conversationId; }
            set
            {
                divContent.InnerHtml = "<input type='hidden' id='ConversationId' value='" + value.ToString() + "' />";

                _conversationId = value;
            }
        }
        #endregion

        #region binding / page-load

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Request["type"] == "tech")
                    bindTech();
                else
                    bindClient();

                bindConversationInfo();
            }
        }

        private void bindConversationInfo()
        {
            Conversation c = DAC.GetConversation(_conversationId.Value);
            lblName.Text = c.Author;
            lblTitle.Text = c.Subject;
            Page.Title = "Chatting about: " + c.Subject;
        }

        private void bindClient()
        {
            if (!String.IsNullOrEmpty(Request["id"]))
            {
                int id = int.Parse(Request["id"]);

                CheckConversationAccess(DAC.GetConversation(id));
                this.ConversationId = id;
            }
            else
            {
                Conversation c = new Conversation();
                //TODO: Replace Test Code for creatign a new conversation... (this could be separate page, and not needed here then)
                /***************** TESTING CODE *******************/
                c.Subject = "Yet another problem";
                c.ClientLCID = Session.LCID;//If you have an actual UserId, that would be better than storing the session id.
                c.Save();
                /**************************************************/
                this.ConversationId = c.Id;
            }
        }

        private void bindTech()
        {
            if (!SessionStateSink.IsTechnician)
                Response.Redirect("tech.aspx");

            this.ConversationId = int.Parse(Request["id"]);
        }
        #endregion


        #region webmethods / helpers
        private static void CheckConversationAccess(Conversation c)
        {
            if (!SessionStateSink.IsTechnician && !c.IsClient())
            {
                throw new Exception("Unauthorized Access");
            }
        }

        [WebMethod]
        public static IEnumerable<IMailUpdate> GetUpdates(int ConversationId, int LastUpdateId)
        {
            Conversation c = DAC.GetConversation(ConversationId);
            CheckConversationAccess(c);
            return c.GetUpdatesAfter(LastUpdateId);
        }


        [WebMethod]
        public static string SendUpdate(int ConversationId, string update)
        {
            Conversation c = DAC.GetConversation(ConversationId);
            CheckConversationAccess(c);

            //TODO: Replace Test Code for posting a message MailUpdate
            /***************** TESTING CODE *******************/
            MailUpdate item = new MailUpdate();
            item.Author = SessionStateSink.IsTechnician ? "Technician" : "Client";//you should populate this from user information.
            item.CssClass = SessionStateSink.IsTechnician ? "tech" : "client";//you can leave this or find a different way of handling it.
            item.TimeStamp = DateTime.Now;
            item.Message = update;
            item.ConversationId = c.Id;
            item.Save();
            /**************************************************/
            return "";
        }
        #endregion
    }
}