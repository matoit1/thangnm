using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace EntityObject
{
    [Serializable()]
    public class AnswersEO
    {
        private Int64 _Answers_ID;
        private Int64 _Support_ID;
        private int _Staff_ID;
        private string _Answers_Content;
        private string _Answers_Question;
        private DateTime _Answers_DateTimeA;
        private DateTime _Answers_DateTimeB;
        // 1. Xay dung cac phuong thuc set, get cho Answers_ID
        public Int64 Answers_ID
        {
            get { return this._Answers_ID; }
            set { this._Answers_ID = value; }
        }

        // 2. Xay dung cac phuong thuc set, get cho Support_ID
        public Int64 Support_ID
        {
            get { return this._Support_ID; }
            set { this._Support_ID = value; }
        }

        // 3. Xay dung cac phuong thuc set, get cho Staff_ID
        public int Staff_ID
        {
            get { return this._Staff_ID; }
            set { this._Staff_ID = value; }
        }

        // 4. Xay dung cac phuong thuc set, get cho Answers_Content
        public string Answers_Content
        {
            get { return this._Answers_Content; }
            set { this._Answers_Content = value; }
        }

        // 8. Xay dung cac phuong thuc set, get cho Answers_Question
        public string Answers_Question
        {
            get { return this._Answers_Question; }
            set { this._Answers_Question = value; }
        }


        // 9. Xay dung cac phuong thuc set, get cho Answers_DateTimeA
        public DateTime Answers_DateTimeA
        {
            get { return this._Answers_DateTimeA; }
            set { this._Answers_DateTimeA = value; }
        }

        // 10. Xay dung cac phuong thuc set, get cho Answers_DateTimeB
        public DateTime Answers_DateTimeB
        {
            get { return this._Answers_DateTimeB; }
            set { this._Answers_DateTimeB = value; }
        }
    }
}
