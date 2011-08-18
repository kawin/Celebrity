using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pacman
{
    class GhostMove
    {

        public string[][] GhostPosition(string[][] board, int row, int column, int status)
        {
            if (status == 1)
            {
                board[row + 1][column] = " ";
                board[row][column] = "#";
            }
                
            else if (status == 2)
            {
                board[row - 1][column] = " ";
                board[row][column] = "#";
            }
            else if (status == 3)
            {
                board[row][column + 1] = " ";
                board[row][column] = "#";
            }
            else if (status == 4)
            {
                board[row][column - 1] = " ";
                board[row][column] = "#";
            }
            return board;
        }
        public void print(string[][] board)
        {

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(board[i][j] + " ");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}