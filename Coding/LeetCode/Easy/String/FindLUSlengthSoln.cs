using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy.String
{
    public class FindLUSlengthSoln
    {
        public int FindLUSlength(string a, string b)
        {
            if (a == b)
                return -1;
            else
                return Math.Max(a.Length, b.Length);
        }
    }
}
