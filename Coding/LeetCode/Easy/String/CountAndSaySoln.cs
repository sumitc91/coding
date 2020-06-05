using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy.String
{
    public class CountAndSaySoln
    {
        public string CountAndSay(int n)
        {
            var strPrev = "1";
                     
            for (int i = 1; i < n; i++)
            {
                var current = new StringBuilder();
                if (strPrev.Length == 1)
                {
                    current.Append("1");
                    current.Append(strPrev);
                    strPrev = current.ToString();
                    continue;
                }

                int count = 1;
                for (int j = 1; j <= strPrev.Length; j++)
                {
                    if (j < strPrev.Length && strPrev[j - 1] == strPrev[j])
                    {
                        count++;
                    }
                    else
                    {
                        current.Append(count.ToString());
                        current.Append(strPrev[j - 1]);
                        count = 1;
                    }
                }
                strPrev = current.ToString();
            }

            return strPrev;
        }
    }
}
