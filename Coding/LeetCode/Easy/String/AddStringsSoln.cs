using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.AskGif.Easy.String
{
    public class AddStringsSoln
    {
        public string AddStrings(string num1, string num2)
        {
            int len1 = num1.Length;
            int len2 = num2.Length;
            int diff = 0;
            var diffStr = new StringBuilder();
            if (len1 > len2)
            {
                diff = len1 - len2;
                for (int i = 0; i < diff; i++)
                {
                    diffStr.Append("0");
                }
                num2 = diffStr.ToString() + num2;
            }
            else
            {
                diff = len2 - len1;
                for (int i = 0; i < diff; i++)
                {
                    diffStr.Append("0");
                }
                num1 = diffStr.ToString() + num1;
            }

            int carry = 0;
            int val = 0;
            var res = new StringBuilder();
            for (int i = num1.Length-1; i >= 0; i--)
            {
                int n = AsciiToNum(num1[i]) + AsciiToNum(num2[i]) + carry;
                if (n > 9)
                {
                    val = n % 10;
                    res.Append(val.ToString());
                    carry = n / 10;
                }
                else
                {
                    res.Append(n.ToString());
                    carry = 0;
                }
            }
            if (carry > 0)
            {
                res.Append(carry);
            }

            return new string(res.ToString().Reverse().ToArray());            
        }

        private int AsciiToNum(char ch)
        {
            return ch - 48;
        }

    }
}
