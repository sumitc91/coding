using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy.Array
{
    public class DuplicateZerosSoln
    {
        public void DuplicateZeros(ref int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    if(i+1 != arr.Length)
                    {
                        for (int j = arr.Length-1; j > i; j--)
                        {
                            arr[j] = arr[j-1];
                        }                        
                    }
                    i++;
                }
            }
        }
    }
}
