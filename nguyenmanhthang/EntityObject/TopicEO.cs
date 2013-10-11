using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityObject
{
    public class TopicEO
    {
        private int _Topic_ID;
        private int _Topic_Author;
        private string _Topic_Title;
        private string _Topic_Category;
        private string _Topic_Tag;
        private string _Topic_Content;
        private int _Topic_Visit;
        private DateTime _Topic_LastUpdate;

        // 1. Xay dung cac phuong thuc set, get cho Topic_ID
        public int Topic_ID
        {
            get { return this._Topic_ID; }
            set { this._Topic_ID = value; }
        }

        // 2. Xay dung cac phuong thuc set, get cho Topic_Author
        public int Topic_Author
        {
            get { return this._Topic_Author; }
            set { this._Topic_Author = value; }
        }

        // 3. Xay dung cac phuong thuc set, get cho Topic_Title
        public string Topic_Title
        {
            get { return this._Topic_Title; }
            set { this._Topic_Title = value; }
        }

        // 4. Xay dung cac phuong thuc set, get cho Topic_Category
        public string Topic_Category
        {
            get { return this._Topic_Category; }
            set { this._Topic_Category = value; }
        }

        // 5. Xay dung cac phuong thuc set, get cho Topic_Tag
        public string Topic_Tag
        {
            get { return this._Topic_Tag; }
            set { this._Topic_Tag = value; }
        }

        // 6. Xay dung cac phuong thuc set, get cho Topic_Content
        public string Topic_Content
        {
            get { return this._Topic_Content; }
            set { this._Topic_Content = value; }
        }

        // 7. Xay dung cac phuong thuc set, get cho Topic_Visit
        public int Topic_Visit
        {
            get { return this._Topic_Visit; }
            set { this._Topic_Visit = value; }
        }

        // 8. Xay dung cac phuong thuc set, get cho _Topic_LastUpdate
        public DateTime Topic_LastUpdate
        {
            get { return this._Topic_LastUpdate; }
            set { this._Topic_LastUpdate = value; }
        }
    }
}
