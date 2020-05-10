using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy.String
{
    public class CountBinarySubstringsSoln
    {
        public int CountBinarySubstrings(string s)
        {
            int ans = 0;                        
            for (int i = 2; i <= s.Length; i += 2)
            {
                for (int j = 0; j < s.Length-(i-1); j++)
                {
                    if (IsEqualCount(s.Substring(j, i)))
                    {                       
                        ans++;
                    }
                }
            }

            return ans;
        }

        private bool IsEqualCount(string substring)
        {
            int i = 0;
            int toggle = 0;
            for (int j = 0; j < substring.Length; j++)
            {
                if (substring[j] == '0')
                {
                    i--;
                }
                else
                {
                    i++;
                }

                if (j != 0)
                {
                    if (substring[j - 1] != substring[j])
                        toggle++;
                }
            }

            return i == 0 && toggle == 1;
        }
    }
}
