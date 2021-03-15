using System;
using System.Collections.Generic;
using System.Drawing;
using Battleship.Enums;

namespace Battleship.Model
{
    public abstract class Player
    {
        private static int Counter { get; set; } = 0;
        private string Name { get; set; }
        private ConsoleColor Color { get; set; }
        private PlayerNumber Number { get; set; }
        public Board Board { get; set; }
        private List<Ship> Ships { get; set; } = new List<Ship>();
        private const string DefaultName = "Player";
        public bool IsAlive => Ships.Count > 0;
        protected Player(ConsoleColor color, PlayerNumber number, int boardSize)
        {
            Counter++;
            this.Name = DefaultName + Convert.ToString(Counter);
            this.Color = color;
            this.Number = number;
            this.Board = new Board(boardSize);
        }

        protected void CheckField(Board board)
        {
            throw new NotImplementedException();
        }
        
        public abstract void Move(Board opponentBoard);
    }
}