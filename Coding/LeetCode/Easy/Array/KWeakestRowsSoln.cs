using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.AskGif.Easy.Array
{
    public class KWeakestRowsSoln
    {
        public int[] KWeakestRows(int[][] mat, int k)
        {
            var map = new Dictionary<int, int>();
            for (int i = 0; i < mat.Length; i++)
            {
                for (int j = 0; j < mat[i].Length; j++)
                {
                    if(mat[i][j] == 1)
                    {
                        if (map.ContainsKey(i))
                        {
                            map[i]++;
                        }
                        else
                        {
                            map.Add(i, 1);
                        }
                    }
                    else
                    {
                        if (!map.ContainsKey(i))
                        {
                            map.Add(i, 0);
                        }
                    }
                }
            }

            var sortedCollection = map
                    .OrderBy(x => x.Value)
                    .ThenBy(x => x.Key);

            var res = new int[k];
            int y = 0;
            foreach (var item in sortedCollection)
            {
                res[y] = item.Key;
                y++;
                
                if (y==k)
                {
                    break;
                }
            }            

            return res;
        }
    }
}
