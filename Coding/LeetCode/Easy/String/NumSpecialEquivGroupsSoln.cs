using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.AskGif.Easy.String
{
    class NumSpecialEquivGroupsSoln
    {
        public void execute()
        {
            var input1 = new string[]{"abcd", "cdab", "cbad", "xyzz", "zzxy", "zzyx"};
            var res = NumSpecialEquivGroups(input1);
        }

        public int NumSpecialEquivGroups(string[] A)
        {
            var set = new HashSet<string>();
            for (int i = 0; i < A.Length; i++)
            {
                var even = new StringBuilder();
                var odd = new StringBuilder();
                for (int j = 0; j < A[i].Length; j++)
                {                    
                    if (j % 2 == 0)
                        even.Append(A[i][j]);
                    else
                        odd.Append(A[i][j]);
                }

                var evenStr = string.Concat(even.ToString().OrderBy(c => c));
                var oddStr = string.Concat(odd.ToString().OrderBy(c => c));

                set.Add(evenStr + oddStr);
            }

            return set.Count;
        }
    }
}
