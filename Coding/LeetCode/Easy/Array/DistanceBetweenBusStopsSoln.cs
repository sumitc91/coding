using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy.Array
{
    public class DistanceBetweenBusStopsSoln
    {
        public int DistanceBetweenBusStops(int[] distance, int start, int destination)
        {            
            var clockwise = 0;
            bool clockwiseFound = false;

            var antiClockwise = 0;
            bool antiClockwiseFound = false;
            int i = start;
            int j = start;
            
            while (true)
            {
                i++;
                j--;

                if (i > distance.Length - 1)
                {
                    i = 0;
                }

                if (j < 0)
                {
                    j = distance.Length - 1;
                }

                if (i == destination)
                {
                    if ((i - 1) < 0)
                    {
                        clockwise += distance[distance.Length - 1];
                    }
                    else
                    {
                        clockwise += distance[i - 1];
                    }                    
                    clockwiseFound = true;
                }

                if( j == destination)
                {                    
                    antiClockwise += distance[j];                                                     
                    antiClockwiseFound = true;
                }

                if (!clockwiseFound)
                {
                    if ((i - 1) < 0)
                    {
                        clockwise += distance[distance.Length - 1];
                    }
                    else
                    {
                        clockwise += distance[i - 1];
                    }
                }

                if (!antiClockwiseFound)
                {                    
                    antiClockwise += distance[j];                    
                }  
                
                if(clockwiseFound && antiClockwiseFound)
                {
                    break;
                }
            }

            return clockwise < antiClockwise ? clockwise : antiClockwise;
        }
    }
}
