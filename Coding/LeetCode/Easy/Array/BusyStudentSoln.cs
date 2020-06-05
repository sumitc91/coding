using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy.Array
{
    public class BusyStudentSoln
    {
        public int BusyStudent(int[] startTime, int[] endTime, int queryTime)
        {
            int count = 0;
            for (int i = 0; i < startTime.Length; i++)
            {
                if(startTime[i] <= queryTime && queryTime <= endTime[i])
                {
                    count++;
                }
            }

            return count;
        }
    }
}
