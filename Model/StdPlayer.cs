using System;
using Battleship.Enums;

namespace Battleship.Model
{
    public class StdPlayer : Player
    {
        public StdPlayer(ConsoleColor color, PlayerNumber number, int boardSize) : base(color, number, boardSize)
        {
        }

        public override void Move(Board opponentBoard)
        {
            bool accepted = false;
            while(!accepted)
            {
                Move move = Input.GetMove();
                switch (move)
                {
                    case Enums.Move.Up:
                        if (opponentBoard.SelectedField.Y > 0)
                        {
                            MoveUp(opponentBoard);
                        }

                        break;
                    case Enums.Move.Right:
                        if (opponentBoard.SelectedField.X < opponentBoard.Size - 1)
                        {
                            MoveRight(opponentBoard);
                        }

                        break;
                    case Enums.Move.Down:
                        if (opponentBoard.SelectedField.Y < opponentBoard.Size - 1)
                        {
                            MoveDown(opponentBoard);
                        }

                        break;
                    case Enums.Move.Left:
                        if (opponentBoard.SelectedField.X > 0)
                        {
                            MoveLeft(opponentBoard);
                        }

                        break;
                    case Enums.Move.Accept:
                        accepted = true;
                        break;
                }
            }
            opponentBoard.CheckField();
        }

        private void MoveLeft(Board opponentBoard)
        {
            opponentBoard.SelectedField.X--;
        }

        private void MoveDown(Board opponentBoard)
        {
            opponentBoard.SelectedField.Y++;
        }

        private void MoveRight(Board opponentBoard)
        {
            opponentBoard.SelectedField.X++;
        }

        private void MoveUp(Board opponentBoard)
        {
            opponentBoard.SelectedField.Y--;
        }
    }
}