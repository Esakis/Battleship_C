using System;
using System.Collections.Generic;
using System.Drawing;
using Battleship.Enums;

namespace Battleship.Model
{
    public abstract class Player
    {
        private string Name { get; set; }
        private ConsoleColor Color { get; set; }
        private PlayerNumber Number { get; set; }
        public Board Board { get; set; }
        private List<Ship> Ships { get; set; }
        public bool IsAlive => Ships.Count > 0 ? true : false;
        protected Player()
        {
            throw new NotImplementedException();
        }

        protected void CheckField(Board board)
        {
            throw new NotImplementedException();
        }
        
        public abstract void Move(Board opponentBoard);
    }
}