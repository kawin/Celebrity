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

            board[0] = new string[9] { "X", "X", "X", "X", "X", "X", "X", "X", "X" };
            board[1] = new string[9] { "X", " ", " ", " ", "#", " ", " ", " ", "X" };
            board[2] = new string[9] { "X", " ", " ", " ", " ", " ", " ", " ", "X" };
            board[3] = new string[9] { "X", " ", " ", " ", " ", " ", " ", " ", "X" };
            board[4] = new string[9] { "X", " ", " ", " ", " ", " ", " ", " ", "X" };
            board[5] = new string[9] { "X", " ", " ", " ", " ", " ", " ", " ", "X" };
            board[6] = new string[9] { "X", " ", " ", " ", " ", " ", " ", " ", "X" };
            board[7] = new string[9] { "X", " ", " ", " ", "0", " ", " ", " ", "X" };//first position
            board[8] = new string[9] { "X", "X", "X", "X", "X", "X", "X", "X", "X" };

            MoveMap map = new MoveMap();

            Console.ForegroundColor = ConsoleColor.Green;
            map.print(board);
           
            
            // Pacman character
            int first_row = 7;
            int first_column = 4;
            int current_row = first_row;
            int current_column = first_column;
            int next_row = current_row, next_column = current_column;
            string pacman = "0";

            //ghost character
            int Ghost_first_row = 1;
            int Ghost_first_column = 4;
            int Ghost_current_row = Ghost_first_row;
            int Ghost_current_column = Ghost_first_column;
            int Ghost_previous_row = Ghost_current_row;
            int Ghost_previous_column = Ghost_current_column;
            int Ghost_next_row = Ghost_current_row;
            int Ghost_next_column = Ghost_current_column;
            string ghost = "#";



            while (true)
            {
                
                Console.Write("where would you like to go ? 'up' 'down' 'left' 'right' : ");
                //Console.ForegroundColor = ConsoleColor.Green;
                string Pacman_move = Console.ReadLine();
                

                switch (Pacman_move)
                {
                    
                    case "u":
                        if (current_row > 1)
                        {
                            board = map.MoveMapNew(board, current_row, current_column, 1, pacman);
                            //map.print(board); 
                            next_row = current_row - 1;
                        }
                        else Console.WriteLine("You can not move !!!!");
                        break;

                        
                    case "d":
                        if (current_row < 7)
                        {
                            board = map.MoveMapNew(board, current_row, current_column, 2, pacman);
                         //   map.print(board);
                            next_row = current_row + 1;
                        }
                        else Console.WriteLine("You can not move !!!!");
                        break;
                     
                    case "l":
                        if (current_column > 1)
                        {
                            board = map.MoveMapNew(board, current_row, current_column, 3, pacman);
                       //     map.print(board); 
                            next_column = current_column - 1;
                        }
                        else Console.WriteLine("You can not move !!!!");
                       break;
                     
                    case "r":
                       if (current_column < 7)
                       {
                           board = map.MoveMapNew(board, current_row, current_column, 4, pacman);
                        //   map.print(board); 
                           next_column = current_column + 1;
                       }
                       else Console.WriteLine("You can not move !!!!");
                       break;
                }

                Random randomnumber = new Random();
                int ghost_rand_move = randomnumber.Next(1, 5);
                int Ghost_move = ghost_rand_move;

                switch (Ghost_move)
                {
                    case 1:
                        if (Ghost_current_row > 1)
                        {
                            board = map.MoveMapNew(board, Ghost_current_row, Ghost_current_column, 1, ghost);

                            Ghost_previous_row = Ghost_current_row;
                            Ghost_next_row = Ghost_current_row - 1;
                          
                        }
                       // else map.print(board);

                        break;
                    case 2:
                        if (Ghost_current_row < 7)
                        {

                            board = map.MoveMapNew(board, Ghost_current_row, Ghost_current_column, 2, ghost);

                            Ghost_previous_row = Ghost_current_row;
                            Ghost_next_row = Ghost_current_row + 1;
                        }
                       // else map.print(board);

                        break;
                    case 3:
                        if (Ghost_current_column > 1)
                        {

                            board = map.MoveMapNew(board, Ghost_current_row, Ghost_current_column, 3, ghost);

                            Ghost_previous_column = Ghost_current_column;
                            Ghost_next_column = Ghost_current_column - 1;
                        }
                        //else map.print(board);

                        break;
                    case 4:

                        if (Ghost_current_column < 7)
                        {

                            board = map.MoveMapNew(board, Ghost_current_row, Ghost_current_column, 4, ghost);

                            Ghost_previous_column = Ghost_current_column;
                            Ghost_next_column = Ghost_current_column + 1;
                        }
                        

                        break;
                } // switch(Ghost_move)


                // hero moves

                current_row = next_row;
                current_column = next_column;

                // Ghost moves
                Ghost_current_row = Ghost_next_row;
                Ghost_current_column = Ghost_next_column;

                map.print(board);
                

                bool hero_dead = ((current_row == Ghost_current_row) && (current_column == Ghost_current_column));
                if(hero_dead)
                {
                    break;
                }

            }
            Console.WriteLine("G A M E   O V E R !!!");
        }
    }
}

    