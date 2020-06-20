using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy.Array
{
    public class PrefixesDivBy5Soln
    {
        public IList<bool> PrefixesDivBy5(int[] A)
        {
            if (A == null || A.Length <= 0) return null;
            int num = 0;
            var list = new List<bool>();
            foreach (var i in A)            
            {
                num = (num * 2 + i) % 5;
                if (num == 0)
                {
                    list.Add(true);
                }
                else
                {
                    list.Add(false);
                }
            }
            return list;
        }
    }
}
