using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityObject
{
    public class CommentEO
    {
        private Int64 _Comment_ID;
        private Int64 _Topic_ID;
        private string _Comment_Name;
        private string _Comment_Email;
        private string _Comment_Website;
        private string _Comment_Content;
        private bool _Comment_Status;
        private DateTime _Comment_LastUpdate;

        // 1. Xay dung cac phuong thuc set, get cho Comment_ID
        public Int64 Comment_ID
        {
            get { return this._Comment_ID; }
            set { this._Comment_ID = value; }
        }

        // 2. Xay dung cac phuong thuc set, get cho Topic_ID
        public Int64 Topic_ID
        {
            get { return this._Topic_ID; }
            set { this._Topic_ID = value; }
        }

        // 3. Xay dung cac phuong thuc set, get cho Comment_Name
        public string Comment_Name
        {
            get { return this._Comment_Name; }
            set { this._Comment_Name = value; }
        }

        // 4. Xay dung cac phuong thuc set, get cho Comment_Email
        public string Comment_Email
        {
            get { return this._Comment_Email; }
            set { this._Comment_Email = value; }
        }

        // 5. Xay dung cac phuong thuc set, get cho Comment_Website
        public string Comment_Website
        {
            get { return this._Comment_Website; }
            set { this._Comment_Website = value; }
        }

        // 6. Xay dung cac phuong thuc set, get cho Comment_Content
        public string Comment_Content
        {
            get { return this._Comment_Content; }
            set { this._Comment_Content = value; }
        }

        // 7. Xay dung cac phuong thuc set, get cho Comment_Status
        public bool Comment_Status
        {
            get { return this._Comment_Status; }
            set { this._Comment_Status = value; }
        }

        // 8. Xay dung cac phuong thuc set, get cho Comment_LastUpdate
        public DateTime Comment_LastUpdate
        {
            get { return this._Comment_LastUpdate; }
            set { this._Comment_LastUpdate = value; }
        }
    }
}
