using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy.String
{
    class FreqAlphabetsSol
    {
        public void execute()
        {
            var res = FreqAlphabets("10#11#12");
        }
        public string FreqAlphabets(string s)
        {
            string[] alphabet = {"","a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p",
                               "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"};
            var str = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                if(i+2 < s.Length && s[i+2] == '#')
                {
                    str.Append(alphabet[Int32.Parse(s.Substring(i, 2))]);
                    i += 2;
                }
                else
                {
                    str.Append(alphabet[Int32.Parse(s.Substring(i, 1))]);
                }
            }

            return str.ToString();
        }
    }
}
