using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy.String
{
    public class ReverseWordsSoln
    {
        public string ReverseWords(string s)
        {
            var strArr = s.Split(" ");
            var str = new StringBuilder();
            foreach (var item in strArr)
            {
                for (int i = item.Length-1; i >= 0; i--)
                {
                    str.Append(item[i]);
                }
                str.Append(" ");
            }
            return str.ToString().Trim();
        }
    }
}

