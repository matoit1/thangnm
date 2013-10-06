using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThangNMjsc
{
    public class Encrypt
    {
        public static string Crypt(string pass)
        {
            return System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(pass.Trim(), "SHA1").ToLower();
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
    }
}