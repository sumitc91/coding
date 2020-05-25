using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy.String
{
    public class CompressSoln
    {
        public int Compress(char[] chars)
        {
            if (chars==null)
                return 0;
            if (chars.Length == 1)
                return 1;

            int slow = 0;
            int fast = 1;
            int index = 0;
            while(fast <= chars.Length)
            {
                if ( fast < chars.Length && chars[slow] == chars[fast])
                {
                    fast++;
                }
                else if(fast == chars.Length)
                {
                    slow = UpdateSlowFastPointer(chars, slow, fast,ref index);
                    break;
                }
                else
                {
                    slow = UpdateSlowFastPointer(chars, slow, fast,ref index);
                }                
            }

            return index;
        }

        private static int UpdateSlowFastPointer(char[] chars, int slow, int fast,ref int index)
        {
            if (fast - slow == 1)
            {
                chars[index] = chars[slow];
                if (chars.Length != fast)
                {
                    slow++;
                }                
            }
            else
            {
                int diff = fast - slow;
                var charArr = diff.ToString().ToCharArray();
                chars[index] = chars[slow];
                foreach (var item in charArr)
                {                    
                    index++;
                    chars[index] = item;                    
                }
                slow=fast;                
            }
            index++;

            return slow;
        }
    }
}
