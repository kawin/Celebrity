using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pacman
{
    class Program
    {
        static void Main(string[] args)
        {

            string[][] board = new string[9][];

            board[0] = new string[9] { "X", "=", "=", "=", "=", "=", "=", "=", "X" };
            board[1] = new string[9] { "X", " ", " ", " ", "#", " ", " ", " ", "X" };
            board[2] = new string[9] { "X", " ", " ", " ", " ", " ", " ", " ", "X" };
            board[3] = new string[9] { "X", " ", " ", " ", " ", " ", " ", " ", "X" };
            board[4] = new string[9] { "X", " ", " ", " ", " ", " ", " ", " ", "X" };
            board[5] = new string[9] { "X", " ", " ", " ", " ", " ", " ", " ", "X" };
            board[6] = new string[9] { "X", " ", " ", " ", " ", " ", " ", " ", "X" };
            board[7] = new string[9] { "X", " ", " ", " ", "0", " ", " ", " ", "X" }; //first position
            board[8] = new string[9] { "X", "=", "=", "=", "=", "=", "=", "=", "X" };

            MoveMap map = new MoveMap();
            GhostMove ghostmove = new GhostMove();

            map.print(board);
            // Pacman character

            int first_row = 7;
            int first_column = 4;
            int current_row = first_row;
            int current_column = first_column;
            string pacman = "0";

            //ghost character
            int Ghost_first_row = 1;
            int Ghost_first_column = 4;
            int Ghost_current_row = 0;
            int Ghost_current_column = 0;
            string ghost = "#";


            {
                int y = 0;
                while (y <= 1)
                {
                    int[] number = new int[4] { 1, 2, 3, 4 };
                    Random randomnumber = new Random();
                    int ghost_rand_move = randomnumber.Next(1, 5);

                    int Ghost_move = ghost_rand_move;

                    Console.Write("where would you like to go num 'up' 'down' 'left' 'right' : ");
                    string Pacman_move = Console.ReadLine();

                    switch (Pacman_move)
                    {
                        case "u":
                            if (first_row > 1)
                            {
                                current_row = first_row - 1;

                                current_column = first_column;

                                board = map.MoveMapNew(board, current_row, current_column, 1, pacman); //board, column, row, status
                                map.print(board);

                                first_row = current_row;
                                first_column = current_column;
                            }
                            else Console.WriteLine("You can not move !!!!");
                            break;

                        case "d":
                            if (first_row < 7)
                            {
                                current_row = first_row + 1;

                                current_column = first_column;

                                board = map.MoveMapNew(board, current_row, current_column, 2, pacman); //board, column, row, status
                                map.print(board);
                                first_row = current_row;
                                first_column = current_column;
                            }
                            else Console.WriteLine("You can not move !!!!");
                            break;

                        case "l":
                            if (first_column > 1)
                            {
                                current_column = first_column - 1;

                                current_row = first_row;

                                board = map.MoveMapNew(board, current_row, current_column, 3, pacman); //board, column, row, status
                                map.print(board);
                                first_row = current_row;
                                first_column = current_column;
                            }
                            else Console.WriteLine("You can not move !!!!");
                            break;

                        case "r":
                            if (first_column < 7)
                            {
                                current_column = first_column + 1;

                                current_row = first_row;

                                board = map.MoveMapNew(board, current_row, current_column, 4, pacman); //board, column, row, status
                                map.print(board);
                                first_row = current_row;
                                first_column = current_column;
                            }
                            else Console.WriteLine("You can not move !!!!");
                            break;
                    }
                    Console.WriteLine("Ghost move: "+Ghost_move);
                    switch (Ghost_move)
                    {
                        case 1:
                            if (Ghost_first_row > 1)
                            {

                                Ghost_current_row = Ghost_first_row - 1;

                                Ghost_current_column = Ghost_first_column;

                                board = map.MoveMapNew(board, Ghost_current_row, Ghost_current_column, 1, ghost); //board, column, row, status
                                map.print(board);

                                Ghost_first_row = Ghost_current_row;
                                Ghost_first_column = Ghost_current_column;
                            }

                            break;
                        case 2:
                            if (Ghost_first_row < 7)
                            {

                                Ghost_current_row = Ghost_first_row + 1;

                                Ghost_current_column = Ghost_first_column;

                                board = map.MoveMapNew(board, Ghost_current_row, Ghost_current_column, 2, ghost); //board, column, row, status
                                map.print(board);

                                Ghost_first_row = Ghost_current_row;
                                Ghost_first_column = Ghost_current_column;
                            }

                            break;
                        case 3:
                            if (Ghost_first_column > 1)
                            {

                                Ghost_current_column = Ghost_first_column - 1;

                                Ghost_current_row = Ghost_first_row;

                                board = map.MoveMapNew(board, Ghost_current_row, Ghost_current_column, 3, ghost); //board, column, row, status
                                map.print(board);

                                Ghost_first_row = Ghost_current_row;
                                Ghost_first_column = Ghost_current_column;
                            }

                            break;
                        case 4:
                            if (Ghost_first_column < 7)
                            {

                                Ghost_current_column = Ghost_first_column + 1;

                                Ghost_current_row = Ghost_first_row;

                                board = map.MoveMapNew(board, Ghost_current_row, Ghost_current_column, 4, ghost); //board, column, row, status
                                map.print(board);

                                Ghost_first_row = Ghost_current_row;
                                Ghost_first_column = Ghost_current_column;
                            }

                            break;
                    }
                    Console.WriteLine("Ghost current row: " + Ghost_current_row);
                    Console.WriteLine("Ghost current row: " + Ghost_current_column);
                }
            }






        }    
            
        }
    }

