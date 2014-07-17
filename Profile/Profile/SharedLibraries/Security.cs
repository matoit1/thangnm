using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace SharedLibraries
{
    public class Security
    {
        /// <summary>
        /// EnCrypt (Mã hóa chuỗi theo thuật toán SHA1)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string EnCrypt(string input)
        {
            return System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(input.Trim(), "SHA1").ToLower();
        }

        public static string RandomPassword()
        {
            string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            string res = "";
            Random rnd = new Random();
            for (int i = 0; i < 16; i++)
            {
                res += valid[rnd.Next(valid.Length)];
            }
            string randpass = res;
            return randpass;
        }

        //public static bool CheckPermission(string CurrentUser, string FunctionName)
        //{
        //    try
        //    {
        //        Int32 id = Convert.ToInt32(AccountsBO.GetAccounts_IDbyAccounts_Username(CurrentUser).Tables[0].Rows[0]["Accounts_ID"]);
        //        DataSet temp = AccountsBO.CheckPermiss(id, FunctionName);
        //        if (temp.Tables[0].Rows.Count > 0)
        //        {
        //            return true;
        //        }
        //        else { return false; }
        //    }
        //    catch { return false; }
        //}

        public static bool setFunction(string Username, string Password)
        {
            return false;
        }
    }
}