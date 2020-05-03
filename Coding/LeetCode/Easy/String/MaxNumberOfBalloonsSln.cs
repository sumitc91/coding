using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy.String
{
    class MaxNumberOfBalloonsSln
    {
        public void execute()
        {
            var res = MaxNumberOfBalloons("leetcode");
        }

        public int MaxNumberOfBalloons(string text)
        {
            var dict = new Dictionary<char, int>();
            char[] word = new char[] {'b', 'a', 'l', 'l', 'o', 'o', 'n' };
            foreach (var ch in text)
            {
                if(dict.ContainsKey(ch))
                {
                    dict[ch]++;
                }
                else
                {
                    dict[ch] = 1;
                }
            }

            int min = Int16.MaxValue;

            //since l and o appear twice, lets divide it by two in dictionary if they exists
            if(dict.ContainsKey('l'))
                dict['l'] = dict['l'] / 2;
            if (dict.ContainsKey('o'))
                dict['o'] = dict['o'] / 2;

            foreach (var ch in word)
            {
                if (dict.ContainsKey(ch))
                {
                    if(dict[ch]<min)
                    {
                        min = dict[ch];
                    }
                }
                else
                {
                    return 0;
                }
            }

            return min;
        }
    }
}
