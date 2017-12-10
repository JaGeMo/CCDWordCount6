using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace WordCount
{
    public static class Splitter
    {
        
        public static List<string> SplitString(string in_String)
        {
            List<string> resultList = new List<string>();
            string pattern = @"[A-Za-z0-9\-]+";
            MatchCollection matches = Regex.Matches(in_String, pattern);
            foreach (Match match in matches)
            {
                resultList.Add(match.Value);
            }

            return resultList;
        }
    }
}
