using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy.String
{
    public class LongestCommonPrefixSoln
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if(strs.Length == 0)
            {
                return "";
            }

            if(strs.Length == 1)
            {
                return strs[0];
            }

            int minLength = Int16.MaxValue;
            for (int i = 0; i < strs.Length; i++)
            {
                if(strs[i].Length < minLength)
                {
                    minLength = strs[i].Length;
                }
            }

            if(minLength == Int16.MaxValue)
            {
                minLength = 0;
            }

            for(int i = 0; i < minLength; i++)
            {
                char ch = strs[0][i];
                for(int j = 1; j < strs.Length; j++)
                {
                    if(ch != strs[j][i])
                    {
                        return strs[0].Substring(0, i);
                    }
                }
            }

            return strs[0].Substring(0,minLength);
        }
    }
}
