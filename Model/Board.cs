using System;
using System.Collections.Generic;
using System.Text;

namespace Battleship.Model
{
    public class Board
    {
        public int Size { get; }
        public const ConsoleColor blueCage = ConsoleColor.Blue;
        public const ConsoleColor darkCage = ConsoleColor.DarkBlue;


        public List<List<int>> blueboard;
        public Board(int size)
        {
            this.Size = size;
            
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