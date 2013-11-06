using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityObject
{
    public class RankingEO
    {
        private Int64 _Ranking_ID;
        private Int32 _Ranking_User;
        private Int64 _Ranking_Money;

        // 1. Xay dung cac phuong thuc set, get cho Ranking_ID
        public Int64 Ranking_ID
        {
            get { return this._Ranking_ID; }
            set { this._Ranking_ID = value; }
        }

        // 2. Xay dung cac phuong thuc set, get cho Ranking_User
        public Int32 Ranking_User
        {
            get { return this._Ranking_User; }
            set { this._Ranking_User = value; }
        }

        // 3. Xay dung cac phuong thuc set, get cho Ranking_Money
        public Int64 Ranking_Money
        {
            get { return this._Ranking_Money; }
            set { this._Ranking_Money = value; }
        }
    }
}
