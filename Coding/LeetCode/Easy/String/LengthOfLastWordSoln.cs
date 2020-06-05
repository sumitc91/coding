using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy.String
{
    public class LengthOfLastWordSoln
    {
        public int LengthOfLastWord(string s)
        {
            int count = 0;
            int lastRes = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if(s[i]==' ')
                {
                    if(count != 0)
                    {
                        lastRes = count;
                    }
                    
                    count = 0;
                }
                else
                {
                    count++;
                }
            }
            if(count == 0)
            {
                count = lastRes;
            }

            return count;
        }
    }
}
