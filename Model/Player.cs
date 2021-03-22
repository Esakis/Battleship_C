using System;
using System.Collections.Generic;
using System.Drawing;
using Battleship.Model.Enums;

namespace Battleship.Model
{
    public abstract class Player
    {
        private static int Counter { get; set; } = 0;
        public string Name { get; }
        private ConsoleColor Color { get; set; }
        private PlayerNumber Number { get; set; }
        public Board Board { get; set; }
        public List<Ship> Ships { get; set; } = new List<Ship>();
        private const string DefaultName = "Player";
        public virtual bool IsAlive => Ships.Count > 0;
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
        
        public abstract void Move(Board opponentBoard, Player player1, Player player2, Player currentPlayer);
    }
}