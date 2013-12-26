using System;
using System.Collections.Generic;
using System.Web;

namespace LiveChat
{
    public class Conversation
    {
        int id;
        int clientLCID;//TODO: Change to use an actual UserId
        string subject;
        string author;
        List<MailUpdate> updates = new List<MailUpdate>();

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Subject
        {
            get { return subject; }
            set { subject = value; }
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        //TODO: Change to use an actual UserId
        public int ClientLCID
        {
            get { return clientLCID; }
            set { clientLCID = value; }
        }
        public List<MailUpdate> Updates
        {
            get { return updates; }
        }

        public IEnumerable<IMailUpdate> GetUpdatesAfter(int LastUpdateId)
        {
            List<IMailUpdate> output = new List<IMailUpdate>();
            int index = updates.Count - 1;
            while (index >= 0 && updates[index].Id != LastUpdateId)
            {
                output.Insert(0, updates[index]);
                index--;
            }
            return output;
        }

        public Conversation()
        {
        }

        public bool IsClient()
        {
            //TODO: Change to use an actual UserId
            return (ClientLCID == HttpContext.Current.Session.LCID);
        }

        public void Save()
        {
            DAC.CreateConversation(this);
        }
    }
}