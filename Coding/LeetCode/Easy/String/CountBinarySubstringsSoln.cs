using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy.String
{
    public class CountBinarySubstringsSoln
    {
        public int CountBinarySubstrings(string s)
        {
            var groups = new int[s.Length];
            groups[0] = 1;
            int j = 0;
            for (int i = 1; i < s.Length; i++)
            {
                if(s[i-1] != s[i])
                {
                    j++;
                    groups[j] = 1;
                }
                else
                {
                    groups[j]++;
                }
            }

            int sum = 0;
            for (int i = 1; i < s.Length; i++)
            {
                sum += Math.Min(groups[i - 1], groups[i]);
            }

            return sum;
        }

        
    }
}
