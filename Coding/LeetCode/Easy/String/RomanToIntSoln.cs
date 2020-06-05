using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy.String
{
    public class RomanToIntSoln
    {
        public int RomanToInt(string s)
        {
            var map = new Dictionary<char, int>();
            map.Add('I',1);
            map.Add('V', 5);
            map.Add('X', 10);
            map.Add('L', 50);
            map.Add('C', 100);
            map.Add('D', 500);
            map.Add('M', 1000);

            int sum = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if(i == s.Length - 1)
                {
                    sum += map[s[i]];
                }
                else
                {
                    if (map[s[i]] < map[s[i + 1]])
                    {
                        sum -= map[s[i]];
                    }
                    else
                    {
                        sum += map[s[i]];
                    }
                }
            }

            return sum;
        }
    }
}
