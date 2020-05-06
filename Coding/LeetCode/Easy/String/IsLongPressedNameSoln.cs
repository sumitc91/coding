using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy.String
{
    class IsLongPressedNameSoln
    {
        public void execute()
        {
            var name = "alex";
            var typed = "aaleelx";

            var res = IsLongPressedName(name, typed);
        }

        public bool IsLongPressedName(string name, string typed)
        {
            if (name[0] != typed[0]) return false;
            for (int i = 0, j=0; i < name.Length;)
            {
                if (name[i] == typed[j])
                {
                    j++;
                    i++;                    
                }
                else
                {
                    if (typed[j] == typed[j - 1])
                        j++;
                    else
                        return false;
                }
                if (j == typed.Length && i == name.Length) 
                    return true;
                if (j >= typed.Length)
                    return false;
                if (i == name.Length)
                    i--;

            }
            return false;
        }
    }
}
