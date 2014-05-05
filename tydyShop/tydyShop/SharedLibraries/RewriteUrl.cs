using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;

namespace tydyShop
{
    public class RewriteUrl
    {
        public static string ConvertToUnSign(string text)
        {
            for (int i = 32; i < 48; i++)
            {
                text = text.Replace(((char)i).ToString(), " ");
            }
            text = text.Replace(".", "-");
            text = text.Replace(" ", "-");
            text = text.Replace(",", "-");
            text = text.Replace(";", "-");
            text = text.Replace(":", "-");
            Regex regex = new Regex(@"\p{IsCombiningDiacriticalMarks}+");
            string strFormD = text.Normalize(System.Text.NormalizationForm.FormD);
            return regex.Replace(strFormD, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }

        public static string Remove_Unicode_Character(string text)
        {
            for (int i = 32; i < 48; i++)
            {
                text = text.Replace(((char)i).ToString(), " ");
            }
            Regex regex = new Regex(@"\p{IsCombiningDiacriticalMarks}+");
            string strFormD = text.Normalize(System.Text.NormalizationForm.FormD);
            return regex.Replace(strFormD, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }

        /// <summary>
        /// Đánh dấu từ khóa với thuộc tính background-color
        /// </summary>
        /// <param name="text"></param>
        /// <param name="keywords">Từ khóa tìm kiếm</param>
        /// <param name="cssClass">Css style hoặc color đánh dấu từ khóa</param>
        /// <returns>string</returns>
        public static string HighLightKeyWords(string text, string keywords, string cssClass)
        {
            if (text == String.Empty || keywords == String.Empty || cssClass == String.Empty)
                return text;
            var words = keywords.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Select(
                word => word.Trim()).Aggregate(text, (current, pattern) =>
                Regex.Replace(current, pattern, string.Format("<span style=\"color:{0}; font-weight: bold\">{1}</span>", cssClass, "$0"), RegexOptions.IgnoreCase));
            return words.Select(word => "\\b" + word.Trim() + "\\b").Aggregate(text, (current, pattern) => Regex.Replace(current, pattern, string.Format("<span style=\"background-color:{0}\">{1}</span>", cssClass, "$0"), RegexOptions.IgnoreCase));
        }
    }
}