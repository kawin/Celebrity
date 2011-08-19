//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace Pacman
//{
//    class ScoreCounter
//    {
//        public void score(int row,int column)
//        {
//            int totalScore = 0;
//            MoveMap map = new MoveMap();
//            bool checkScoreTrue = false;
//            string _score = map.PositionValue(row, column);
//            if (_score == "1")
//            {
//                checkScoreTrue = true;
//            }
//            if (checkScoreTrue == true)
//            {
//                totalScore = totalScore + 100;
//            }
//            Console.WriteLine(totalScore);

//        }
//    }
//}
