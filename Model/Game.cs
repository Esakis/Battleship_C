using System;
using Battleship.Enums;

namespace Battleship.Model
{
    public class Game
    {
        private GameMode Mode { get; }
        private Player Player1 { get; }
        private Player Player2 { get; }
        private Player CurrentPlayer { get; set; }
        private Player Opponent { get; set; }
        public int BoardSize { get; set; }

        public Game(GameMode mode, int boardSize)
        {
            this.Mode = mode;
            this.BoardSize = boardSize;
            this.Player1 = PlayerFactory.StandardPlayer(ConsoleColor.Green, PlayerNumber.First, 10);

            if (this.Mode == GameMode.Standard)
                this.Player2 = PlayerFactory.StandardPlayer(ConsoleColor.Blue, PlayerNumber.Second, 10);
            else if (this.Mode == GameMode.AI)
                this.Player2 = PlayerFactory.AI(ConsoleColor.Red, PlayerNumber.Second, 10);

            // On start of game change current player so player1 is the first in round.
            this.CurrentPlayer = this.Player2;
            this.Opponent = this.Player1;
        }

        public void Play()
        {
            Board player1Board = BoardFactory.RandomPlacement(this.BoardSize, 5, Player1);
            Board player2Board = BoardFactory.RandomPlacement(this.BoardSize, 5, Player2);
            Display.Playground(player1Board, player2Board);

            while (!this.HasWon())
            {
                this.ChangePlayer();
                this.CurrentPlayer.Move(this.Opponent.Board);
            }

            var winner = this.CurrentPlayer;
            Display.Results(winner);
        }

        private void ChangePlayer()
        {
            this.CurrentPlayer = this.CurrentPlayer == this.Player1 ? this.Player2 : this.Player1;
            this.SpecifyOpponent();
        }

        private void SpecifyOpponent()
        {
            this.Opponent = this.CurrentPlayer == Player1 ? this.Player2 : this.Player1;
        }
        
        /// <summary>
        /// Check if current player won
        /// </summary>
        /// <returns>Return true if current player won</returns>
        private bool HasWon()
        {
            if (Opponent.IsAlive)
                return false;
            return true;
        }
    }
}