using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy.Array
{
    public class TictactoeSoln
    {
        public string Tictactoe(int[][] moves)
        {
            var matrix = new char[3, 3];

            var playerA = true;
            var input = 'X';
            for (int i = 0; i < moves.Length; i++)
            {
                if (!playerA)
                {
                    input = 'O';                    
                }
                else
                {
                    input = 'X';
                }
                playerA = !playerA;

                //considering inputs are valid
                matrix[moves[i][0], moves[i][1]] = input;
                var check = ValidateMatrix(matrix);
                switch (check)
                {
                    case "O":
                        return "B";                        
                    case "X":
                        return "A";
                    case "Draw":
                        return "Draw";
                    case "Pending":
                        break;
                }
            }

            return "Pending";
        }

        private string ValidateMatrix(char[,] matrix)
        {
            char defaultValue = '\0';
            //First row
            if(matrix[0, 0] != defaultValue && matrix[0, 0] == matrix[0, 1] && matrix[0, 0] == matrix[0, 2])
            {
                return matrix[0, 0].ToString();
            }

            //Second row
            if (matrix[1, 0] != defaultValue &&  matrix[1, 0] == matrix[1, 1] && matrix[1, 0] == matrix[1, 2])
            {
                return matrix[1, 0].ToString();
            }

            //Third row
            if (matrix[2, 0] != defaultValue && matrix[2, 0] == matrix[2, 1] && matrix[2, 0] == matrix[2, 2])
            {
                return matrix[2, 0].ToString();
            }

            //First Column
            if (matrix[0, 0] != defaultValue && matrix[0, 0] == matrix[1, 0] && matrix[0, 0] == matrix[2, 0])
            {
                return matrix[0, 0].ToString();
            }

            //Second Column
            if (matrix[0, 1] != defaultValue && matrix[0, 1] == matrix[1, 1] && matrix[0, 1] == matrix[2, 1])
            {
                return matrix[0, 1].ToString();
            }

            //Third Column
            if (matrix[0, 2] != defaultValue && matrix[0, 2] == matrix[1, 2] && matrix[0, 2] == matrix[2, 2])
            {
                return matrix[0, 2].ToString();
            }

            //Diagonal
            if (matrix[0, 0] != defaultValue && matrix[0, 0] == matrix[1, 1] && matrix[0, 0] == matrix[2, 2])
            {
                return matrix[0, 0].ToString();
            }

            //Diagonal
            if (matrix[0, 2] != defaultValue && matrix[0, 2] == matrix[1, 1] && matrix[0, 2] == matrix[2, 0])
            {
                return matrix[0, 2].ToString();
            }

            //Check if any block is available to play
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if(matrix[i,j] == defaultValue)
                    {
                        return "Pending";
                    }
                }
            }

            return "Draw";
        }
    }
}
