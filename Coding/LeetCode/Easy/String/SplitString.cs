using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy
{
    class SplitString
    {
        public void execute()
        {
            string s = "011101";

            MaxScore(s);
        }

        public int MaxScore(string s)
        {
            int zero = 0;
            int ones = 0;
            int max = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '1')
                    ones++;
            }

            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[i] == '0')
                    zero++;
                else
                    ones--;
                max = Math.Max(max, zero + ones);
            }

            return max;
        }
    }
}
