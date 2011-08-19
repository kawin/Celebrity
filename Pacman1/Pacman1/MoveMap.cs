using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pacman
{
    class MoveMap
    {

        public string[][] MoveMapNew(string[][] board, int row, int column, int status, string kindOfplayer)
        {

            int newRow;
            int newColumn;


            if (status == 1)
            {
                if (row > 1)
                {
                    newRow = row - 1;
                    newColumn = column;
                    board[row][column] = previous_position(board, row, column, kindOfplayer);
                    board[newRow][newColumn] = kindOfplayer;
                    column = newColumn;
                }

            }

            else if (status == 2)
            {
                if (row < 7)
                {
                    newRow = row + 1;
                    newColumn = column;
                    board[row][column] = previous_position(board, row, column, kindOfplayer);
                    board[newRow][newColumn] = kindOfplayer;
                    column = newColumn;
                }

            }
            else if (status == 3)
            {
                if (column > 1)
                {
                    newRow = row;
                    newColumn = column - 1;
                    board[row][column] = previous_position(board, row, column, kindOfplayer);
                    board[newRow][newColumn] = kindOfplayer;
                    row = newRow;
                }
            }
            else if (status == 4)
            {
                if (column < 7)
                {
                    newRow = row;
                    newColumn = column + 1;
                    board[row][column] = previous_position(board, row, column, kindOfplayer);
                    board[newRow][newColumn] = kindOfplayer;
                    row = newRow;
                }
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
        private String previous_position(string[][] board, int row, int column, string kindOfPlayer)
        {
            if (kindOfPlayer == board[row][column])
            {
                return " ";
            }
            else
            {
                return board[row][column];
            }
        }

    }
}
