using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy.String
{
    public class ReverseStringSoln
    {
        public void ReverseString(ref char[] s)
        {
            for(int i=0, j = s.Length - 1; i < j; i++, j--)
            {
                char temp = s[i];
                s[i] = s[j];
                s[j] = temp;
            }
        }
    }
}
