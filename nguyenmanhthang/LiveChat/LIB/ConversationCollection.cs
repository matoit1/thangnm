using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace LiveChat
{
    public class ConversationCollection : KeyedCollection<int, Conversation>
    {
        protected override int GetKeyForItem(Conversation item)
        {
            return item.Id;
        }
        public IEnumerable<Conversation> GetItems()
        {
            return this.Items;
        }
    }
}