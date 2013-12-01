using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using System.Data;
using BusinessObject;

namespace nguyenmanhthang.Library.Common
{
    public class SecurityFunction
    {
        public static bool CheckPermission(string CurrentUser, string FunctionName)
        {
            try
            {
                Int32 id = Convert.ToInt32(AccountsBO.GetAccounts_IDbyAccounts_Username(CurrentUser).Tables[0].Rows[0]["Accounts_ID"]);
                DataSet temp = AccountsBO.CheckPermiss(id, FunctionName);
                if (temp.Tables[0].Rows.Count > 0)
                {
                    return true;
                }
                else { return false; }
            }
            catch { return false; }
        }

        public static bool setFunction(string Username, string Password)
        {
            return false;
        }

        //SortedList
        //    DataSet dsTopic = TopicBO.Topic_SelectListbyTopic_Status(true);
        //    IEnumerable<DataRow> bankCodes = (from q in dsTopic.Tables[0].AsEnumerable() select q);
        //    DataTable dt = bankCodes.CopyToDataTable();
        //    return dt;
        //    //return dsTopic.Tables[0].AsEnumerable();
    }
}