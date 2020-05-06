using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy.String
{
    class NumUniqueEmailsSoln
    {
        public void execute()
        {
            var input = new string[] { 
                "test.email+alex@leetcode.com", 
                "test.e.mail+bob.cathy@leetcode.com", 
                "testemail+david@lee.tcode.com"
            };
            var res = NumUniqueEmails(input);
        }

        public int NumUniqueEmails(string[] emails)
        {
            var set = new HashSet<string>();
            for (int i = 0; i < emails.Length; i++)
            {
                set.Add(ReturnUniqueEmail(emails[i]));
            }
            return set.Count;
        }

        private string ReturnUniqueEmail(string email)
        {
            var split = email.Split("@");
            var local = split[0];
            //ignore everything after +
            local = local.Split('+')[0];

            //remove all dots (.)
            local = local.Replace(".", "");
            return local + "@" + split[1];
        }
    }
}
