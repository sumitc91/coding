using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy.String
{
    class DefangIPaddrSln
    {
        public void execute()
        {
            var res = DefangIPaddr("255.100.50.0");
        }

        public string DefangIPaddr(string address)
        {
            var str = new StringBuilder();
            for (int i = 0; i < address.Length; i++)
            {
                if (address[i] == '.')
                {
                    str.Append("[.]");
                }
                else
                {
                    str.Append(address[i]);
                }
            }
            return str.ToString();
        }
    }
}
