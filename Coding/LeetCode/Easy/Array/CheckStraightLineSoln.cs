using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy.Array
{
    public class CheckStraightLineSoln
    {
        public bool CheckStraightLine(int[][] coordinates)
        {
            double m = 0;
            double c = 0;
            
            if(coordinates.Length == 0)
            {
                return false;
            }

            if(coordinates.Length == 1 || coordinates.Length == 2)
            {
                return true;
            }
            
            //Equation of Line y = mx + c
            //Let's find value for m and c;
            //y1 = mx1 + c
            //y2 = mx2 + c
            //y2 - y1 = m(x2 - x1);

            var x1 = coordinates[0][0];
            var x2 = coordinates[1][0];
            var y1 = coordinates[0][1];
            var y2 = coordinates[1][1];

            if((x2-x1) == 0)            
            {
                //check if all x is same;
                for (int i = 2; i < coordinates.Length; i++)
                {
                    if(x1 != coordinates[i][0])
                    {
                        return false;
                    };
                }
                return true;
            }

            m = (double)(y2 - y1) / (x2 - x1);
            c = y1 - m * x1;

            for (int i = 2; i < coordinates.Length; i++)
            {
                if(coordinates[i][1] != m * coordinates[i][0] + c)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
