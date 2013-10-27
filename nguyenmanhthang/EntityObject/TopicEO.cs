using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityObject
{
    public class TopicEO
    {
        private Int64 _Topic_ID;
        private int _Topic_Author;
        private string _Topic_Title;
        private string _Topic_LinkImage;
        private int _Topic_Category;
        private int _Topic_Parent;
        private string _Topic_Tag;
        private string _Topic_Content;
        private string _Topic_Description;
        private int _Topic_Visit;
        private bool _Topic_Status;
        private DateTime _Topic_LastUpdate;

        // 1. Xay dung cac phuong thuc set, get cho Topic_ID
        public Int64 Topic_ID
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

        // 4. Xay dung cac phuong thuc set, get cho Topic_LinkImage
        public string Topic_LinkImage
        {
            get { return this._Topic_LinkImage; }
            set { this._Topic_LinkImage = value; }
        }

        // 5. Xay dung cac phuong thuc set, get cho Topic_Category
        public int Topic_Category
        {
            get { return this._Topic_Category; }
            set { this._Topic_Category = value; }
        }

        // 6. Xay dung cac phuong thuc set, get cho Topic_Parent
        public int Topic_Parent
        {
            get { return this._Topic_Parent; }
            set { this._Topic_Parent = value; }
        }

        // 7. Xay dung cac phuong thuc set, get cho Topic_Tag
        public string Topic_Tag
        {
            get { return this._Topic_Tag; }
            set { this._Topic_Tag = value; }
        }

        // 8. Xay dung cac phuong thuc set, get cho Topic_Content
        public string Topic_Content
        {
            get { return this._Topic_Content; }
            set { this._Topic_Content = value; }
        }

        // 9. Xay dung cac phuong thuc set, get cho Topic_Description
        public string Topic_Description
        {
            get { return this._Topic_Description; }
            set { this._Topic_Description = value; }
        }

        // 10. Xay dung cac phuong thuc set, get cho Topic_Visit
        public int Topic_Visit
        {
            get { return this._Topic_Visit; }
            set { this._Topic_Visit = value; }
        }

        // 11. Xay dung cac phuong thuc set, get cho Topic_Status
        public bool Topic_Status
        {
            get { return this._Topic_Status; }
            set { this._Topic_Status = value; }
        }

        // 12. Xay dung cac phuong thuc set, get cho _Topic_LastUpdate
        public DateTime Topic_LastUpdate
        {
            get { return this._Topic_LastUpdate; }
            set { this._Topic_LastUpdate = value; }
        }
    }
}
