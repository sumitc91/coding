using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy.String
{
    class NumSmallerByFrequencySol
    {
        public void execute()
        {
            var queries = new string[] { "bbb", "cc" };
            var words = new string[]{"a", "aa", "aaa", "aaaa"};
            var res = NumSmallerByFrequency(queries, words);
        }

        public int[] NumSmallerByFrequency(string[] queries, string[] words)
        {
            int[] queries_count = new int[queries.Length];
            int[] words_count = new int[words.Length];
            int[] ans = new int[queries.Length];

            for (int i = 0; i < queries.Length; i++)
            {
                queries_count[i] = -1;
                ans[i] = 0;
            }

            for (int i = 0; i < words.Length; i++)
            {
                words_count[i] = -1;
            }

            for(int i = 0; i < queries.Length; i++)
            {
                if (queries_count[i] == -1)
                {
                    queries_count[i] = CalculateCount(queries[i]);
                }

                for (int j = 0; j < words.Length; j++)
                {
                    
                    if(words_count[j] == -1)
                    {
                        words_count[j] = CalculateCount(words[j]);
                    }

                    if (queries_count[i] < words_count[j])
                    { 
                        ans[i]++; 
                    }
                }
            }

            return ans;
        }

        private int CalculateCount(string v)
        {
            if (v == "") return 0;

            char minChar = v[0];
            int count = 1;
            for(int i= 1; i < v.Length; i++)
            {
                if (v[i] < minChar)
                {
                    minChar = v[i];
                    count = 1;
                }
                else if(v[i] == minChar)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
