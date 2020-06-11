using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy.Array
{
    public class MinTimeToVisitAllPointsSoln
    {
        public int MinTimeToVisitAllPoints(int[][] points)
        {
            if(points.Length == 0)
            {
                return 0;
            }

            int time = 0;
            int sourceX = points[0][0];
            int sourceY = points[0][1];
            for (int i = 1; i < points.Length; i++)
            {
                int destinationX = points[i][0];
                int destinationY = points[i][1];
                time += CalculateTimeBetweenPoints(sourceX, sourceY, destinationX, destinationY);

                sourceX = destinationX;
                sourceY = destinationY;
            }

            return time;
        }

        private int CalculateTimeBetweenPoints(int sourceX, int sourceY, int destinationX, int destinationY)
        {
            int time = 0;
            int diffX = Math.Abs(sourceX - destinationX);
            int diffY = Math.Abs(sourceY - destinationY);

            int diagonalMove = Math.Min(diffX, diffY);
            time = diagonalMove + Math.Abs(diffX - diffY);
            return time;
        }
    }
}
