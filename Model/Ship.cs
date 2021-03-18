using System;
using System.Collections.Generic;
using Battleship.Enums;

namespace Battleship.Model
{
    public class Ship
    {
        public Ship(ShipType shipType, List<Square> squares, Player owner, ConsoleColor color = ConsoleColor.Green, int size = 1)
        {
            Owner = owner;
            Size = (int)shipType;
            Color = color;
            ShipType = shipType;
            Squares = squares;
        }

        public Player Owner { get; }
        public ShipType ShipType { get; }
        public List<Square> Squares { get; }
        public int Size { get; }
        public ConsoleColor Color { get; }
    }
}