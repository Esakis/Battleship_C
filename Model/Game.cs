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

        public Game(GameMode mode)
        {
            this.Mode = mode;
            this.Player1 = PlayerFactory.StandardPlayer();

            if (this.Mode == GameMode.Standard)
                this.Player2 = PlayerFactory.StandardPlayer();
            else if (this.Mode == GameMode.AI)
                this.Player2 = PlayerFactory.AI();

            // On start of game change current player so player1 is the first in round.
            this.CurrentPlayer = this.Player2;
            this.Opponent = this.Player1;
        }

        public void Play()
        {
            Board Player1 = new Board();
            Board Player2 = new Board();
            Display.Playground(this.Player1.Board);
            Display.Playground(this.Player2.Board);

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

        private bool HasWon()
        {
            if (Opponent.IsAlive)
                return false;
            return true;
        }
    }
}