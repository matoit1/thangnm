using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LiveChat
{
    public class DAC
    {
        //TODO: implement a real DAC instead of just keeping stuff in session and making up random Identifiers

        static ConversationCollection converstations = new ConversationCollection();
        public static IEnumerable<Conversation> GetAllConverstations()
        {
            return converstations.GetItems();
        }
        public static Conversation GetConversation(int id)
        {
            return converstations[id];
        }
        public static void CreateConversation(Conversation item)
        {
            item.Id = GetTestId();
            converstations.Add(item);
        }
        public static void CreateMailUpdate(MailUpdate item)
        {
            item.Id = GetTestId();
            GetConversation(item.ConversationId).Updates.Add(item);
        }

        static int TEST_ID = 1;
        static object o = new object();
        static int GetTestId()
        {
            int output;
            lock (o)
            {
                TEST_ID++;
                output = TEST_ID;
            }
            return output;
        }
    }
}