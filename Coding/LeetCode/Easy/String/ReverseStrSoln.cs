using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy.String
{
    public class ReverseStrSoln
    {
        public string ReverseStr(string s, int k)
        {
            var count = Math.Ceiling((double)s.Length / k);
            bool rev = true;
            if (k >= s.Length)
            {
                k = s.Length;
            }

            var str = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                rev = i % 2 == 0; //reverse for odd position
                for (int j = k-1, x = 0; j >= 0; j--,x++)
                {                    
                    if (rev)
                    {
                        if ((i * k) + j > s.Length - 1) continue;
                        str.Append(s[(i * k)+j]);
                    }
                    else
                    {
                        if((i * k) + x > s.Length - 1) break;
                        str.Append(s[(i * k)+x]);
                    }
                }
            }

            return str.ToString();
        }
    }
}
