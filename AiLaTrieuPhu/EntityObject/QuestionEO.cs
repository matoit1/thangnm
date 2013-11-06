using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityObject
{
    public class QuestionEO
    {
        private Int64 _Question_ID;
        private string _Question_Ask;
        private string _Question_A;
        private string _Question_B;
        private string _Question_C;
        private string _Question_D;
        private int _Question_True;
        private int _Question_Level;

        // 1. Xay dung cac phuong thuc set, get cho Question_ID
        public Int64 Question_ID
        {
            get { return this._Question_ID; }
            set { this._Question_ID = value; }
        }

        // 2. Xay dung cac phuong thuc set, get cho Question_Ask
        public string Question_Ask
        {
            get { return this._Question_Ask; }
            set { this._Question_Ask = value; }
        }

        // 3. Xay dung cac phuong thuc set, get cho Question_A
        public string Question_A
        {
            get { return this._Question_A; }
            set { this._Question_A = value; }
        }

        // 4. Xay dung cac phuong thuc set, get cho Question_B
        public string Question_B
        {
            get { return this._Question_B; }
            set { this._Question_B = value; }
        }

        // 5. Xay dung cac phuong thuc set, get cho Question_C
        public string Question_C
        {
            get { return this._Question_C; }
            set { this._Question_C = value; }
        }

        // 6. Xay dung cac phuong thuc set, get cho Question_D
        public string Question_D
        {
            get { return this._Question_D; }
            set { this._Question_D = value; }
        }

        // 7. Xay dung cac phuong thuc set, get cho Question_True
        public int Question_True
        {
            get { return this._Question_True; }
            set { this._Question_True = value; }
        }

        // 8. Xay dung cac phuong thuc set, get cho Question_Level
        public int Question_Level
        {
            get { return this._Question_Level; }
            set { this._Question_Level = value; }
        }
    }
}
