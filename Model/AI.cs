using System;
using Battleship.Enums;

namespace Battleship.Model
{
    public class AI : Player
    {
        public override void Move(Board opponentBoard, Player player1, Player player2, Player currentPlayer)
        {
            throw new System.NotImplementedException();
        }

        public AI(ConsoleColor color, PlayerNumber number, int boardSize) : base(color, number, boardSize)
        {
        }
    }
}