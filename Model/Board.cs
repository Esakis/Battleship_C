using System;
using System.Collections.Generic;
using System.Text;

namespace Battleship.Model
{
    public class Board
    {

        public const int Size;
        public const ConsoleColor blueCage = ConsoleColor.Blue;
        public const ConsoleColor darkCage = ConsoleColor.DarkBlue;
        private Square[,] ocean;
        private bool IsPlacementOk;


        public Board(int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    board[i, j] = "  ";
                }
            }

        }

        public void MakeBoard()
        {
            //INIT BOARD
            
            //string[,] MakeEmptyBoard()
            //{
            //    string[,] board = new string[Size, Size];
            //    for (int i = 0; i < Size; i++)
            //    {
            //        for (int j = 0; j < Size; j++)
            //        {
            //            board[i, j] = "  ";
            //        }
            //    }
            //    return board;
            //}
        }
    }
}

