using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy.Array
{
    public class NumEquivDominoPairsSoln
    {
        public int NumEquivDominoPairs(int[][] dominoes)
        {
            var map = new Dictionary<string, int>();
            int count = 0;
            string key = string.Empty;
            for (int i = 0; i < dominoes.Length; i++)
            {
                key = Math.Min(dominoes[i][0], dominoes[i][1]).ToString() +
                    "-" +Math.Max(dominoes[i][0], dominoes[i][1]).ToString();

                if (map.ContainsKey(key))
                {
                    count += map[key];
                    map[key]++;
                }
                else
                {
                    map.Add(key, 1);
                }                
            }

            return count;
        }        
    }
}
