using System;
using System.Collections.Generic;
using System.Text;

namespace Battleship.Model
{
    public class Board
    {
<<<<<<< HEAD

        public const int Size;
=======
        public int Size { get; }
>>>>>>> a61745a3d60471917a72fe8fd357eb1e32968510
        public const ConsoleColor blueCage = ConsoleColor.Blue;
        public const ConsoleColor darkCage = ConsoleColor.DarkBlue;
        private Square[,] ocean;
        private bool IsPlacementOk;


<<<<<<< HEAD
        public Board(int size)
        {
            for (int i = 0; i < size; i++)
=======
        public List<List<int>> blueboard;
        public Board(int size)
        {
            this.Size = size;
            
            blueboard = new List<List<int>>();
            for (int i = 0; i < Size; i++)
>>>>>>> a61745a3d60471917a72fe8fd357eb1e32968510
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