using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy.String
{
    class GenerateTheStringSoln
    {
        public void execute()
        {
            var res = GenerateTheString(5);
        }

        public string GenerateTheString(int n)
        {
            StringBuilder str = new StringBuilder();
            if (n % 2 == 0)
            {
                for(int i = 0; i < n - 1; i++)
                {
                    str.Append("a");
                }
                str.Append("b");
            }
            else
            {
                for (int i = 0; i < n; i++)
                    str.Append("c");
            }

            return str.ToString();
        }
    }
}
