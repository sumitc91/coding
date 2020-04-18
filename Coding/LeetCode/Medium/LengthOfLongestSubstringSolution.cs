using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Medium
{
    class LengthOfLongestSubstringSolution
    {
        public void execute()
        {
            int res = LengthOfLongestSubstring("abcabcbb");
        }
        public int LengthOfLongestSubstring(string s)
        {
            if (s=="")
            {
                return 0;
            }

            int max = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int len = 1;
                var dict = new Dictionary<char, int>();
                dict.Add(s[i], 1);
                for (int j = i+1; j < s.Length; j++)
                {
                    if (dict.ContainsKey(s[j]))
                    {
                        break;
                    }
                    else
                    {
                        len++;
                        dict.Add(s[j], 1);
                    }
                }
                if (max < len)
                {
                    max = len;
                }
            }
            
            return max;
        }
    }
}
