using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy.String
{
    public class FirstUniqCharSoln
    {
        public int FirstUniqChar(string s)
        {
            var map = new Dictionary<char, int>();
            for(int i=0; i < s.Length; i++)
            {
                if (map.ContainsKey(s[i]))
                {
                    map[s[i]]++;
                }
                else
                {
                    map.Add(s[i], 1);
                }
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (map[s[i]] == 1)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
