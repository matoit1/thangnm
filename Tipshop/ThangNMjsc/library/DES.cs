//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Security.Cryptography;
//using System.IO;
//using System.Text;

//namespace ThangNMjsc
//{
//    public class DES
//    {
//        public static string Encrypt(string originalString)
//        {
//            if (String.IsNullOrEmpty(originalString))
//            {
//                throw new ArgumentNullException("chuoi ma hoa ko đc rong.");
//            }

//            DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
//            MemoryStream memoryStream = new MemoryStream();
//            CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoProvider.CreateEncryptor(64,byte()), CryptoStreamMode.Write);

//            StreamWriter writer = new StreamWriter(cryptoStream);
//            writer.Write(originalString);
//            writer.Flush();
//            cryptoStream.FlushFinalBlock();
//            writer.Flush();

//            return Convert.ToBase64String(memoryStream.GetBuffer(), 0, (int)memoryStream.Length);
//        }

//        public static string Decrypt(string cryptedString)
//        {
//            if (String.IsNullOrEmpty(cryptedString))
//            {
//                throw new ArgumentNullException("chuoi can giai ma ko dc phep rong.");
//            }

//            DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
//            MemoryStream memoryStream = new MemoryStream(Convert.FromBase64String(cryptedString));
//            CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoProvider.CreateDecryptor(_bytes, _bytes), CryptoStreamMode.Read);
//            StreamReader reader = new StreamReader(cryptoStream);

//            return reader.ReadToEnd();
//        }

//        //public byte[] bytes {
//        //    get { return this._bytes; }
//        //    set { this._bytes = value; }
//        //}
//    }
//}