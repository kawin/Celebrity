using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Pacman
{
    [TestFixture]
    class TestPacman
    {
         
            public string[][] board = new string[9][];
            
            public string pacman = "0";
            public string ghost = "#";
            MoveMap map = new MoveMap();
            public int current_row;
            public int current_column;
            public int Ghost_current_row;
            public int Ghost_current_column;

        [Test]
        public void testHeroMoveUp()
        {
            current_row = 7;
            current_column = 4;

            board[0] = new string[9] { "X", "=", "=", "=", "=", "=", "=", "=", "X" };
            board[1] = new string[9] { "X", " ", " ", " ", "#", " ", " ", " ", "X" };
            board[2] = new string[9] { "X", " ", " ", " ", " ", " ", " ", " ", "X" };
            board[3] = new string[9] { "X", " ", " ", " ", " ", " ", " ", " ", "X" };
            board[4] = new string[9] { "X", " ", " ", " ", " ", " ", " ", " ", "X" };
            board[5] = new string[9] { "X", " ", " ", " ", " ", " ", " ", " ", "X" };
            board[6] = new string[9] { "X", " ", " ", " ", " ", " ", " ", " ", "X" };
            board[7] = new string[9] { "X", " ", " ", " ", "0", " ", " ", " ", "X" }; //first position
            board[8] = new string[9] { "X", "=", "=", "=", "=", "=", "=", "=", "X" };

                
            //Hero should be at [7][4]
            Assert.AreEqual(board[7][4], "0");
            //Hero should not be at [6][4]
            Assert.AreEqual(board[6][4], " ");

            //move hero up
            //MoveMap map = new MoveMap();
            //string[][] new_board = new string[9][];
            //current_row = first_row - 1;
            //current_column = first_column;
            board = map.MoveMapNew(board, current_row, current_column, 1, pacman);
            Assert.AreEqual(board[6][4], "0");
            Assert.AreEqual(board[7][4], " ");
        }

        [Test]
        public void testHeroMoveDown()
        {
            current_row = 6;
            current_column = 4;

            board[0] = new string[9] { "X", "=", "=", "=", "=", "=", "=", "=", "X" };
            board[1] = new string[9] { "X", " ", " ", " ", "#", " ", " ", " ", "X" };
            board[2] = new string[9] { "X", " ", " ", " ", " ", " ", " ", " ", "X" };
            board[3] = new string[9] { "X", " ", " ", " ", " ", " ", " ", " ", "X" };
            board[4] = new string[9] { "X", " ", " ", " ", " ", " ", " ", " ", "X" };
            board[5] = new string[9] { "X", " ", " ", " ", " ", " ", " ", " ", "X" };
            board[6] = new string[9] { "X", " ", " ", " ", "0", " ", " ", " ", "X" };//first position
            board[7] = new string[9] { "X", " ", " ", " ", " ", " ", " ", " ", "X" };  
            board[8] = new string[9] { "X", "=", "=", "=", "=", "=", "=", "=", "X" };

                    
            Assert.AreEqual(board[6][4], "0");
            Assert.AreEqual(board[7][4], " ");

            //move hero down
            
            board = map.MoveMapNew(board, current_row, current_column, 2, pacman);
            Assert.AreEqual(board[7][4], "0");
            Assert.AreEqual(board[6][4], " ");
        }

        [Test]
        public void testHeroMoveLeft()
        {
            current_row = 6;
            current_column = 4;

            board[0] = new string[9] { "X", "=", "=", "=", "=", "=", "=", "=", "X" };
            board[1] = new string[9] { "X", " ", " ", " ", "#", " ", " ", " ", "X" };
            board[2] = new string[9] { "X", " ", " ", " ", " ", " ", " ", " ", "X" };
            board[3] = new string[9] { "X", " ", " ", " ", " ", " ", " ", " ", "X" };
            board[4] = new string[9] { "X", " ", " ", " ", " ", " ", " ", " ", "X" };
            board[5] = new string[9] { "X", " ", " ", " ", " ", " ", " ", " ", "X" };
            board[6] = new string[9] { "X", " ", " ", " ", "0", " ", " ", " ", "X" };//first position
            board[7] = new string[9] { "X", " ", " ", " ", " ", " ", " ", " ", "X" };
            board[8] = new string[9] { "X", "=", "=", "=", "=", "=", "=", "=", "X" };


            Assert.AreEqual(board[6][4], "0");
            Assert.AreEqual(board[6][3], " ");

            //move hero left

            board = map.MoveMapNew(board, current_row, current_column, 3, pacman);
            Assert.AreEqual(board[6][3], "0");
            Assert.AreEqual(board[6][4], " ");
        }


        [Test]
        public void testHeroMoveRight()
        {
            current_row = 6;
            current_column = 4;

            board[0] = new string[9] { "X", "=", "=", "=", "=", "=", "=", "=", "X" };
            board[1] = new string[9] { "X", " ", " ", " ", "#", " ", " ", " ", "X" };
            board[2] = new string[9] { "X", " ", " ", " ", " ", " ", " ", " ", "X" };
            board[3] = new string[9] { "X", " ", " ", " ", " ", " ", " ", " ", "X" };
            board[4] = new string[9] { "X", " ", " ", " ", " ", " ", " ", " ", "X" };
            board[5] = new string[9] { "X", " ", " ", " ", " ", " ", " ", " ", "X" };
            board[6] = new string[9] { "X", " ", " ", " ", "0", " ", " ", " ", "X" };//first position
            board[7] = new string[9] { "X", " ", " ", " ", " ", " ", " ", " ", "X" };
            board[8] = new string[9] { "X", "=", "=", "=", "=", "=", "=", "=", "X" };


            Assert.AreEqual(board[6][4], "0");
            Assert.AreEqual(board[6][5], " ");

            //move hero left

            board = map.MoveMapNew(board, current_row, current_column, 4, pacman);
            Assert.AreEqual(board[6][5], "0");
            Assert.AreEqual(board[6][4], " ");
        }

        [Test]
        public void testHeroCanNotMoveUp()
        {
            current_row = 1;
            current_column = 1;

            board[0] = new string[9] { "X", "=", "=", "=", "=", "=", "=", "=", "X" };
            board[1] = new string[9] { "X", "0", " ", " ", "#", " ", " ", " ", "X" };//first position
            board[2] = new string[9] { "X", " ", " ", " ", " ", " ", " ", " ", "X" };
            board[3] = new string[9] { "X", " ", " ", " ", " ", " ", " ", " ", "X" };
            board[4] = new string[9] { "X", " ", " ", " ", " ", " ", " ", " ", "X" };
            board[5] = new string[9] { "X", " ", " ", " ", " ", " ", " ", " ", "X" };
            board[6] = new string[9] { "X", " ", " ", " ", " ", " ", " ", " ", "X" };
            board[7] = new string[9] { "X", " ", " ", " ", " ", " ", " ", " ", "X" };
            board[8] = new string[9] { "X", "=", "=", "=", "=", "=", "=", "=", "X" };



            Assert.AreEqual(board[1][1], "0");
            Assert.AreEqual(board[0][1], "=");

            board = map.MoveMapNew(board, current_row, current_column, 1, pacman);
            Assert.AreEqual(board[1][1], "0");
            Assert.AreEqual(board[0][1], "=");
        }

        [Test]
        public void testHeroCanNotMoveDown()
        {
            current_row = 7;
            current_column = 7;

            board[0] = new string[9] { "X", "=", "=", "=", "=", "=", "=", "=", "X" };
            board[1] = new string[9] { "X", " ", " ", " ", "#", " ", " ", " ", "X" };//first position
            board[2] = new string[9] { "X", " ", " ", " ", " ", " ", " ", " ", "X" };
            board[3] = new string[9] { "X", " ", " ", " ", " ", " ", " ", " ", "X" };
            board[4] = new string[9] { "X", " ", " ", " ", " ", " ", " ", " ", "X" };
            board[5] = new string[9] { "X", " ", " ", " ", " ", " ", " ", " ", "X" };
            board[6] = new string[9] { "X", " ", " ", " ", " ", " ", " ", " ", "X" };
            board[7] = new string[9] { "X", " ", " ", " ", " ", " ", " ", "0", "X" };
            board[8] = new string[9] { "X", "=", "=", "=", "=", "=", "=", "=", "X" };



            Assert.AreEqual(board[7][7], "0");
            Assert.AreEqual(board[8][7], "=");

            board = map.MoveMapNew(board, current_row, current_column, 2, pacman);
            Assert.AreEqual(board[7][7], "0");
            Assert.AreEqual(board[8][7], "=");
        }

        [Test]
        public void testHeroCanNotMoveleft()
        {
            current_row = 1;
            current_column = 1;

            board[0] = new string[9] { "X", "=", "=", "=", "=", "=", "=", "=", "X" };
            board[1] = new string[9] { "X", "0", " ", " ", "#", " ", " ", " ", "X" };//first position
            board[2] = new string[9] { "X", " ", " ", " ", " ", " ", " ", " ", "X" };
            board[3] = new string[9] { "X", " ", " ", " ", " ", " ", " ", " ", "X" };
            board[4] = new string[9] { "X", " ", " ", " ", " ", " ", " ", " ", "X" };
            board[5] = new string[9] { "X", " ", " ", " ", " ", " ", " ", " ", "X" };
            board[6] = new string[9] { "X", " ", " ", " ", " ", " ", " ", " ", "X" };
            board[7] = new string[9] { "X", " ", " ", " ", " ", " ", " ", " ", "X" };
            board[8] = new string[9] { "X", "=", "=", "=", "=", "=", "=", "=", "X" };



            Assert.AreEqual(board[1][1], "0");
            Assert.AreEqual(board[1][0], "X");

            board = map.MoveMapNew(board, current_row, current_column, 3, pacman);
            Assert.AreEqual(board[1][1], "0");
            Assert.AreEqual(board[1][0], "X");
        }

        [Test]
        public void testHeroCanNotMoveRight()
        {
            current_row = 7;
            current_column = 7;

            board[0] = new string[9] { "X", "=", "=", "=", "=", "=", "=", "=", "X" };
            board[1] = new string[9] { "X", " ", " ", " ", "#", " ", " ", " ", "X" };//first position
            board[2] = new string[9] { "X", " ", " ", " ", " ", " ", " ", " ", "X" };
            board[3] = new string[9] { "X", " ", " ", " ", " ", " ", " ", " ", "X" };
            board[4] = new string[9] { "X", " ", " ", " ", " ", " ", " ", " ", "X" };
            board[5] = new string[9] { "X", " ", " ", " ", " ", " ", " ", " ", "X" };
            board[6] = new string[9] { "X", " ", " ", " ", " ", " ", " ", " ", "X" };
            board[7] = new string[9] { "X", " ", " ", " ", " ", " ", " ", "0", "X" };
            board[8] = new string[9] { "X", "=", "=", "=", "=", "=", "=", "=", "X" };



            Assert.AreEqual(board[7][7], "0");
            Assert.AreEqual(board[7][8], "X");

            board = map.MoveMapNew(board, current_row, current_column, 4, pacman);
            Assert.AreEqual(board[7][7], "0");
            Assert.AreEqual(board[7][8], "X");
        }

        [Test]
        public void testHeroFollowGhost()
        {
            current_row = 1;
            current_column = 3;
            Ghost_current_row = 1;
            Ghost_current_column = 4;

            board[0] = new string[9] { "X", "=", "=", "=", "=", "=", "=", "=", "X" };
            board[1] = new string[9] { "X", " ", " ", "0", "#", " ", " ", " ", "X" };//first position
            board[2] = new string[9] { "X", " ", " ", " ", " ", " ", " ", " ", "X" };
            board[3] = new string[9] { "X", " ", " ", " ", " ", " ", " ", " ", "X" };
            board[4] = new string[9] { "X", " ", " ", " ", " ", " ", " ", " ", "X" };
            board[5] = new string[9] { "X", " ", " ", " ", " ", " ", " ", " ", "X" };
            board[6] = new string[9] { "X", " ", " ", " ", " ", " ", " ", " ", "X" };
            board[7] = new string[9] { "X", " ", " ", " ", " ", " ", " ", " ", "X" };
            board[8] = new string[9] { "X", "=", "=", "=", "=", "=", "=", "=", "X" };



            Assert.AreEqual(board[1][3], "0");
            Assert.AreEqual(board[1][4], "#");
            
            board = map.MoveMapNew(board, Ghost_current_row, Ghost_current_column, 4, pacman);
            board = map.MoveMapNew(board, current_row, current_column, 2, ghost);
            Assert.AreEqual(board[1][3], " ");
            Assert.AreEqual(board[1][4], "0");
            Assert.AreEqual(board[1][5], "#");
        }
    }
}
