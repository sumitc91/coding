using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy.String
{
    public class CountSegmentsSoln
    {
        public int CountSegments(string s)
        {
            if (s.Length == 0) return 0;
            var list = new List<string>();
            int count = 1;
            if(s[0] == ' ')
            {
                count = 0;
            }

            for(int i = 1; i < s.Length-1; i++)
            {
                if(s[i] == ' ' && s[i+1] != ' ')
                {
                    list.Add(s.Substring(0, i));
                    count++;
                }
            }

            return count;
        }
    }
}
