using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy.String
{
    class BalancedStringSplitSol
    {
        public void execute()
        {
            var res = BalancedStringSplit("RLRRLLRLRL");
        }

        public int BalancedStringSplit(string s)
        {
            int val = 0;
            int ans = 0;
            for(int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'R')
                {
                    val++;                    
                }
                else
                {
                    val--;
                }
                if (val == 0)
                    ans++;
            }

            return ans;
        }
    }
}
