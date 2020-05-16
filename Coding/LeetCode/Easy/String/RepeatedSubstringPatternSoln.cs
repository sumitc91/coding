using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy.String
{
    public class RepeatedSubstringPatternSoln
    {
        public bool RepeatedSubstringPattern(string s)
        {
            var len = s.Length;
            for(int i = 1; i <= len / 2; i++)
            {
                if(len % i == 0)
                {
                    int mul = len / i;
                    var str = new StringBuilder();
                    while (mul != 0)
                    {
                        str.Append(s.Substring(0, i));
                        mul--;
                    }

                    if (str.ToString() == s)
                        return true;
                }
            }

            return false;
        }
    }
}
