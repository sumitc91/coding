using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy.String
{
    public class StrStrSoln
    {
        public int StrStr(string haystack, string needle)
        {
            if(haystack == needle)
            {
                return 0;
            }

            if (string.IsNullOrEmpty(haystack))
            {
                return -1;
            }

            if (string.IsNullOrEmpty(needle))
            {
                return 0;
            }

            if(needle.Length > haystack.Length)
            {
                return -1;
            }

            for(int i = 0; i < haystack.Length - needle.Length + 1; i++)
            {
                bool found = true;
                if (haystack[i] == needle[0])
                {
                    for (int j = 1; j < needle.Length; j++)
                    {
                        if(haystack[i+j] != needle[j])
                        {
                            found = false;
                        }
                    }

                    if (found)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
    }
}
