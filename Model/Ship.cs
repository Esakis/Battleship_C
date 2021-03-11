using System;
using System.Drawing;

namespace Battleship.Model
{
    public struct Ship
    {
        public Ship(Player owner, char mark, ConsoleColor color = ConsoleColor.Green, int size = 1)
        {
            Owner = owner;
            Size = size;
            Mark = mark;
            Color = color;
        }

        public Player Owner;
        public int Size;
        public char Mark;
        public ConsoleColor Color;
    }
}