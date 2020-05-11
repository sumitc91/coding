using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy.String
{
    public class JudgeCircleSoln
    {
        public bool JudgeCircle(string moves)
        {
            int x = 0;
            int y = 0;
            for (int i = 0; i < moves.Length; i++)
            {
                switch (moves[i])
                {
                    case 'U':
                        y++;
                        break;
                    case 'D':
                        y--;
                        break;
                    case 'L':
                        x--;
                        break;
                    case 'R':
                        x++;
                        break;
                    default: break;
                }
            }

            return x == 0 && y == 0;
        }
    }
}
