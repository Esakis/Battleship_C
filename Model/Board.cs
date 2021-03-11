using System;
using System.Collections.Generic;
using System.Text;

namespace Battleship.Model
{
    public class Board
    {
        public const int Size = 9;
        public const ConsoleColor blueCage = ConsoleColor.Blue;
        public const ConsoleColor darkCage = ConsoleColor.DarkBlue;


        public List<List<int>> blueboard;
        public Board()
        {
            blueboard = new List<List<int>>();
            for (int i = 0; i < Size; i++)
            {
                blueboard.Add(new List<int>());
                for (int j = 0; j < Size; j++)
                    blueboard[i].Add(0);
            }
        }
    }
}

