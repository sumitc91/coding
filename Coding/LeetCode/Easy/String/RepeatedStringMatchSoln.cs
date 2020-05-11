using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy.String
{
    public class RepeatedStringMatchSoln
    {
        public int RepeatedStringMatch(string A, string B)
        {
            double len1 = A.Length;
            double len2 = B.Length;
            double times = Math.Ceiling(len2 / len1);
            var str = new StringBuilder();
            for (int i = 0; i < times; i++)
            {
                str.Append(A);
            }
            if (str.ToString().Contains(B))
            {
                return (int)times;
            }
            else
            {
                str.Append(A);
                if (str.ToString().Contains(B))
                    return (int)times + 1;                
            }

            return -1;
        }
    }
}
