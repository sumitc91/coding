using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy.String
{
    public class MaxPowerSoln
    {
        public int MaxPower(string s)
        {
            if (s.Length == 0) return 0;

            int max = 1;
            int count = 1;
            for(int i=1; i<s.Length; i++)
            {
                if (s[i - 1] == s[i])
                {
                    count++;
                }
                else
                {
                    if(count>max)
                    {
                        max = count;
                    }
                    count = 1;
                }
            }

            if (count > max)
            {
                max = count;
            }

            return max;
        }
    }
}
