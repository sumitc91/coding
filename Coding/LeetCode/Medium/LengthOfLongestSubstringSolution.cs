using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Medium
{
    class LengthOfLongestSubstringSolution
    {
        public void execute()
        {
            int res = LengthOfLongestSubstringBySlidingWindow("aabaab!bb");
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

        public int LengthOfLongestSubstringBySlidingWindow(string s)
        {
            int max = 0;            
            int start = 0;
            int end;
            var hashSet = new HashSet<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (hashSet.Contains(s[i]))
                {                    
                    while (s[start] != s[i])
                    {
                        hashSet.Remove(s[start]);
                        start++;
                    }
                    start++;
                }
                else
                {                    
                    hashSet.Add(s[i]);
                    if (max < hashSet.Count)
                    {
                        max = hashSet.Count;
                    }
                }
            }
            return max;
        }
    }
}
