using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityObject
{
    class CauhoiEO
    {
        private int _CauhoiID;
        private string _tencauhoi;
        private string _daa	;
        private string _dab;
        private string _dac;
        private string _dad;
        private int _dadung;

        public Int32 CauhoiID
        {
            get { return this._CauhoiID; }
            set { this._CauhoiID = value; }
        }

        public string tencauhoi
        {
            get { return this._tencauhoi; }
            set { this._tencauhoi = value; }
        }

        public string daa
        {
            get { return this._daa; }
            set { this._daa = value; }
        }

        public string dab
        {
            get { return this._dab; }
            set { this._dab = value; }
        }

        public string dac
        {
            get { return this._dac; }
            set { this._dac = value; }
        }

        public string dad
        {
            get { return this._dad; }
            set { this._dad = value; }
        }

        public Int32  dadung
        {
            get { return this._dadung; }
            set { this._dadung = value; }
        }
    }
}
