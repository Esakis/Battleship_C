using System;
using Battleship.Enums;

namespace Battleship.Model
{
    public class StdPlayer : Player
    {
        public override void Move(Board opponentBoard)
        {
            throw new System.NotImplementedException();
        }

        public StdPlayer(ConsoleColor color, PlayerNumber number, int boardSize) : base(color, number, boardSize)
        {
        }
    }
}