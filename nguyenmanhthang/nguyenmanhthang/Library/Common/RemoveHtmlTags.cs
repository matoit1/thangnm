using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace nguyenmanhthang.Library.Common
{
    public class RemoveHtmlTags
    {
        public static string RemoveHtmlTagsUsingCharArray(string htmlString)
        {
            var array = new char[htmlString.Length];
            var arrayIndex = 0;
            var inside = false;

            foreach (var @let in htmlString)
            {
                if (let == '<')
                {
                    inside = true;
                    continue;
                }
                if (let == '>')
                {
                    inside = false;
                    continue;
                }
                if (inside) continue;
                array[arrayIndex] = let;
                arrayIndex++;
            }
            return new string(array, 0, arrayIndex);
        }
    }
}