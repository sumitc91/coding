using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy.Array
{
    public class CanThreePartsEqualSumSoln
    {
        public bool CanThreePartsEqualSum(int[] A)
        {
            var sum = 0;
            for (int i = 0; i < A.Length; i++)
            {
                sum += A[i];
            }

            if(sum%3 != 0)
            {
                return false;
            }

            int parts = sum / 3;
            int partsCount = 0;

            int temp = 0;
            for (int i = 0; i < A.Length; i++)
            {
                temp += A[i];
                if(temp == parts)
                {
                    temp = 0;
                    partsCount++;
                }
            }

            return temp == 0 && partsCount >= 3;
        }
    }
}
