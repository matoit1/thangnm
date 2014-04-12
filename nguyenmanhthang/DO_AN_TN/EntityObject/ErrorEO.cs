using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace EntityObject
{
    [Serializable()]
    public class ErrorEO
    {
        private Int64 _PK_lErrorID;
        private string _sLink;
        private string _sIP;
        private string _sBrowser;
        private Int16 _iCodes;
        private DateTime _tTime;
        private DateTime _tTimeCheck;
        private Int16 _iStatus;

        #region "Properties"
        // 1. Xay dung cac phuong thuc set, get cho PK_lErrorID
        public Int64 PK_lErrorID
        {
            get { return this._PK_lErrorID; }
            set { this._PK_lErrorID = value; }
        }

        // 2. Xay dung cac phuong thuc set, get cho sLink
        public string sLink
        {
            get { return this._sLink; }
            set { this._sLink = value; }
        }

        // 3. Xay dung cac phuong thuc set, get cho sIP
        public string sIP
        {
            get { return this._sIP; }
            set { this._sIP = value; }
        }

        // 4. Xay dung cac phuong thuc set, get cho sBrowser
        public string sBrowser
        {
            get { return this._sBrowser; }
            set { this._sBrowser = value; }
        }

        // 5. Xay dung cac phuong thuc set, get cho iCodes
        public Int16 iCodes
        {
            get { return this._iCodes; }
            set { this._iCodes = value; }
        }

        // 6. Xay dung cac phuong thuc set, get cho tTime
        public DateTime tTime
        {
            get { return this._tTime; }
            set { this._tTime = value; }
        }

        // 7. Xay dung cac phuong thuc set, get cho tTimeCheck
        public DateTime tTimeCheck
        {
            get { return this._tTimeCheck; }
            set { this._tTimeCheck = value; }
        }

        // 8. Xay dung cac phuong thuc set, get cho iStatus
        public Int16 iStatus
        {
            get { return this._iStatus; }
            set { this._iStatus = value; }
        }

        public static ErrorEO Convert_DataSet_To_Object(DataSet dsInput)
        {
            ErrorEO objOutput = new ErrorEO();
            try
            {
                objOutput.PK_lErrorID = Convert.ToInt64(dsInput.Tables[0].Rows[0]["PK_lErrorID"]);
                objOutput.sLink = Convert.ToString(dsInput.Tables[0].Rows[0]["sLink"]);
                objOutput.sIP = Convert.ToString(dsInput.Tables[0].Rows[0]["sIP"]);
                objOutput.sBrowser = Convert.ToString(dsInput.Tables[0].Rows[0]["sBrowser"]);
                objOutput.iCodes = Convert.ToInt16(dsInput.Tables[0].Rows[0]["iCodes"]);
                objOutput.tTime = Convert.ToDateTime(dsInput.Tables[0].Rows[0]["tTime"]);
                objOutput.tTimeCheck = Convert.ToDateTime(dsInput.Tables[0].Rows[0]["tTimeCheck"]);
                objOutput.iStatus = Convert.ToInt16(dsInput.Tables[0].Rows[0]["iStatus"]);
                return objOutput;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}